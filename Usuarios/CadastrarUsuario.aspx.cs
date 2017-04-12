using System;
using System.Data.SqlClient;

public partial class Usuarios_CadastrarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Server=adriel-pc\\sqlexpress;Trusted_Connection=Yes"))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO TB_USUARIOS (NOME, SOBRENOME, EMAIL, SENHA) VALUES (@NOME, @SOBRENOME, @EMAIL, @SENHA)", con))
            {
                cmd.Parameters.AddWithValue("NOME", txtNome.Text);
                cmd.Parameters.AddWithValue("SOBRENOME", txtSobreNome.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("SENHA", txtSenha.Text);

                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > -1)
                    {
                        lblMensagem.Text = "Post cadastrado com sucesso";
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = "Houve algum problema: " + ex;
                }
            }
        }
    }
}