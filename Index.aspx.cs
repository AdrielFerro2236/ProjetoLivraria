using System;
using System.Web.UI;
using System.Data.SqlClient;


public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Session.Abandon();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Server=adriel - pc\\sqlexpress;DataBase=DB_LIVRARIA;Trusted_Connection=Yes;"))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM TB_USUARIOS where NOME_USUARIO = @usuario AND SENHA = @senha", con))
            {
                cmd.Parameters.AddWithValue("usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                try
                {
                    con.Open();
                    SqlDataReader sdrUsuario = cmd.ExecuteReader();
                    sdrUsuario.Read();
                    if (sdrUsuario.HasRows)
                    {
                        Session["autenticado"] = "OK";
                        Session["nome"] = sdrUsuario.GetString(1);
                        Response.Redirect("PainelAdmin.aspx");
                    }
                    else
                    {
                        lblMensagem.Text = "Usuário ou senha inválida";
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = "Erro de banco de dados.Contate o suport." + ex.Message;
                }

            }
        }
    }
}