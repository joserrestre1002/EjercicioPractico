using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.Common;

namespace EjercicioPractico.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        Modulo1 modulo = new Modulo1();

        readonly SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public static string sID = "-1";
        public static string sOPc = "";
        static string estatus = "Enviado";
        string files = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTabla();

           TxtNotas.Visible = false;
            LbNotas.Visible = false;

            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    sID= Request.QueryString["id"].ToString();
                    CargarDatos();
                }
            }
        }

      

        protected void BtnRevisar_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            int columna = selectedrow.RowIndex;
            columna += 1;
            id = columna.ToString();
            Response.Redirect("~/Pages/EvaluacionProspecto.aspx?id=" + id);

           
        }



        void CargarTabla()
        {

            modulo.CargarTabla(modulo._conexion, GridUsuarios);  
        }

        void CargarDatos()
        {
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("sp_read", sqlConnection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            DataRow row = dataTable.Rows[0];
            TxtNombre.Text = row[1].ToString();
            TxtApellido1.Text = row[2].ToString();
            TxtApellido2.Text = row[3].ToString();
            TxtCalle.Text = row[4].ToString();
            TxtNumero.Text = row[5].ToString();
            TxtColonia.Text = row[6].ToString();
            TxtCp.Text = row[7].ToString();
            TxtTel.Text = row[8].ToString();
            TxtRfc.Text = row[9].ToString();
            files = row[10].ToString();

            string[] listaDeArchivos = files.Split('/');

            foreach (var archivo in listaDeArchivos)
            {
                DropDownList.Items.Add(archivo);
            }

            sqlConnection.Close();
        }

        protected void Btn_actualizar_Click(object sender, EventArgs e)
        {

            modulo.ActualizarDB(modulo._conexion,sID,TxtNombre.Text,TxtApellido1.Text, TxtApellido2.Text,TxtCalle.Text,TxtNumero.Text,TxtColonia.Text,TxtCp.Text,TxtTel.Text,TxtRfc.Text,files,estatus,TxtNotas.Text);
            sID = "-1";
            Response.Redirect("~/Pages/EvaluacionProspecto.aspx");
            


        }


        protected void BtnRechazo_Click(object sender, EventArgs e)
        {
            estatus = "Rechazado";
            Btn_actualizar.Visible = true;
            Label1.Text = "Estado Seleccionado:" + estatus;
             TxtNotas.Visible = true;
            TxtApellido1.Visible = true;
          

        }

        protected void BtnAprobar_Click(object sender, EventArgs e)
        {
           TxtNotas.Visible = false;
            
            estatus = "Aprobado";
            Label1.Text ="Estado Seleccionado: "+ estatus;
            Btn_actualizar.Visible = true;
            LbNotas.Visible = false;
          

        }

        
       
    }
}