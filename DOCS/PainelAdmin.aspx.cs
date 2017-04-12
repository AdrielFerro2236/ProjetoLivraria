using System;

public partial class PainelAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*esse trecho verifica se exite a sessão "autenticação", se não existir
         * redireciona o usuário para a página index
         */
         if (Session["autenticado"] == null)
         {
            Response.Redirect("Index.aspx");
         }
        lblUsuario.Text = Session["nome"].ToString();
    }
}