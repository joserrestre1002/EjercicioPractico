using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Drawing;

namespace EjercicioPractico.Pages
{
    public partial class PantallaCaptura : System.Web.UI.Page
    {

         Modulo1 modulo = new Modulo1();
        

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            string FileNames = "";

            if (FileUpload.HasFiles)
            {
                string path = Server.MapPath("~/uploads/");
                if (Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }



                foreach (HttpPostedFile file in FileUpload.PostedFiles)
                {

                    file.SaveAs(path + file.FileName);

                    FileNames = FileNames + file.FileName + "/";
                }
            }

            modulo.EscribirDB(modulo._conexion,TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtCalle.Text, TxtNumero.Text, TxtColonia.Text, TxtCp.Text, TxtTel.Text, TxtRfc.Text, FileNames, "Enviado","");

            Response.Redirect("index.aspx");
        }


       void CargarDAtos()
       {

       }

        protected void BtnLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/ListadoProspectos.aspx");
        }

        public enum MessageType {Succes, error,Info,Warning};

       
        protected void BtnSalir_Click(object sender, EventArgs e)     
        {

            Response.Redirect("~/Pages/ListadoProspectos.aspx");

        }
    }
}