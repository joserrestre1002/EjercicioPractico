using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EjercicioPractico.Pages
{
    public partial class ListadoProspectos : System.Web.UI.Page
    {
        Modulo1 modulo = new Modulo1();

       
        protected void Page_Load(object sender, EventArgs e)
        {
            GridUsuarios = modulo.CargarTabla(modulo._conexion, GridUsuarios);
            
        }

        protected void BtnRevisar_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            int columna = selectedrow.RowIndex;
            columna += 1;
            id=columna.ToString();
            Response.Redirect("~/Pages/RevisarInfo.aspx?id="+id);

        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/index.aspx");

        }
    }
}