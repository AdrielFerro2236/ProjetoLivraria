using System;
using System.Data.SqlClient;

public partial class Usuarios_ExcluirUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string codigo = Request.QueryString["id"];
        lblId.Text = codigo;

        using (SqlConnection con = new SqlConnection("Serveradriel-pc\\sqlexpress;Database=db_google;Trusted_Connection=Yes;"))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tb_USUARIO where id = " + codigo, con))
            {
                try
                {
                    con.Open();
                    SqlDataReader sdrInfPosts = cmd.ExecuteReader();
                    sdrInfPosts.Read();
                    lblNome.Text = sdrInfPosts.GetString(2);
                    lblSobreNome.Text = sdrInfPosts.GetString(1);
                    lblEmail.Text = sdrInfPosts.GetString(3);

                }
                catch
                {
                    //mensagem de erro
                    lblErro.Text = "Erro de banco de dados. Contate o suporte.";
                }
            }
        }
    }

    protected void btnSim_Click(object sender, EventArgs e)
    {
        string codigo = Request.QueryString["id"];

        using (SqlConnection con = new SqlConnection("Server=adriel-pc\\sqlexpress;Database=db_google;Trusted_Connection=Yes;"))
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM tb_USUARIO where id = " + codigo, con))
            {
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    lblNome.Text = "";
                    lblSobreNome.Text = "";
                    lblId.Text = "";
                    lblEmail.Text = "";
                    lblUserName.Text = "";

                    lblErro.Text = "Usuário excluído com sucesso. Click no VOLTAR para retornar à tela inicial.";
                }
                catch
                {
                    //mensagem de erro
                    lblErro.Text = "Erro de banco de dados. Contate o suporte.";
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}