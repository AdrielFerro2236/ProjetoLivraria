using System;
using System.Data.SqlClient;

public partial class Usuarios_AlterarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string codigo = Request.QueryString["id"];
            lblId.Text = codigo;

            using (SqlConnection con = new SqlConnection("Server=adriel-pc\\sqlexpress;Database=db_google;Trusted_Connection=Yes;"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tb_USUARIO where id = " + codigo, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader sdrInfPosts = cmd.ExecuteReader();
                        sdrInfPosts.Read();
                        txtNome.Text = sdrInfPosts.GetString(2);
                        txtSobreNome.Text = sdrInfPosts.GetString(1);
                        txtEmail.Text = sdrInfPosts.GetString(3);
                        txtUserName.Text = sdrInfPosts.GetString(4);
                    }
                    catch
                    {
                        //mensagem de erro
                        lblErro.Text = "Erro de banco de dados. Contate o suporte.";
                    }
                }
            }
        }
        }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        string codigo = Request.QueryString["id"];

        using (SqlConnection con = new SqlConnection("Server=adriel-pc\\sqlexpress;Database=db_google;Trusted_Connection=Yes"))
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE TB_USUARIOS SET NOME = @NOME, SOBRENOME = @SOBRENOME, EMAIL = @EMAIL, NOME_USUARIO = @NOME_USUARIO WHERE ID = " + codigo, con))
            {
                cmd.Parameters.AddWithValue("NOME", txtNome.Text);
                cmd.Parameters.AddWithValue("SOBRENOME", txtSobreNome.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("NOMEUSUARIO", txtUserName.Text);

                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > -1)
                    {
                        lblErro.Text = "Usuário alterado com sucesso";
                    }
                }
                catch (Exception ex)
                {
                    lblErro.Text = "Houve algum problema: " + ex;
                }
            }
        }
    }
}