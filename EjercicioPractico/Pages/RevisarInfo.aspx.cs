using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPractico.Pages
{
    public partial class RevisarInfo : System.Web.UI.Page
    {

        readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public static string sID = "-1";
        public static string sOPc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    sID= Request.QueryString["id"].ToString();
                    CargarDatos();
                }
            }
        }


        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoProspectos.aspx");
        }

        void CargarDatos()
        {
            _connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("sp_read", _connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = sID;
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
            DataTable dataTable= dataSet.Tables[0];
            DataRow row= dataTable.Rows[0];
            TxtNombre.Text = row[1].ToString();
            TxtApellido1.Text = row[2].ToString();
            TxtApellido2.Text = row[3].ToString();
            TxtCalle.Text=row[4].ToString();
            TxtNumero.Text = row[5].ToString();
            TxtColonia.Text = row[6].ToString();
            TxtCp.Text = row[7].ToString();
            TxtTel.Text = row[8].ToString();
            TxtRfc.Text = row[9].ToString();
            string files = row[10].ToString();

            string[] listaDeArchivos = files.Split('/');

            foreach (var archivo in listaDeArchivos)
            {
                DropDownList.Items.Add(archivo);
            }

            _connection.Close();
        }
    }
}