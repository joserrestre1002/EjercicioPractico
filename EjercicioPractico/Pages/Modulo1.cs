using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Net.NetworkInformation;
using System.Security.Cryptography;


using System.Collections.Generic;


using System.Linq;
using System.Web.Caching;


namespace EjercicioPractico.Pages
{

  
    public class Modulo1 : IHttpModule
    {
        public readonly SqlConnection _conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);


        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
        }


        public void EscribirDB(SqlConnection _conexion, string Nombre, string Apellido1, string Apellido2, string Calle, string Numero, string Colonia, string Cp, string Telefono, string rfc, string Archivos, string Estatus, string Notas )
        {
            
            enviarDatosADb("sp_create","-1", Nombre,Apellido1,Apellido2,Calle,Numero, Colonia, Cp, Telefono, rfc,Archivos,Estatus,Notas);
            
        }

        public void ActualizarDB(SqlConnection _conexion, string id, string Nombre, string Apellido1, string Apellido2, string Calle, string Numero, string Colonia, string Cp, string Telefono, string rfc, string Archivos, string Estatus, string Notas)
        {
            if (id != "-1")
            {

                enviarDatosADb("sp_update", id, Nombre, Apellido1, Apellido2, Calle, Numero, Colonia, Cp, Telefono, rfc, Archivos, Estatus, Notas);
              
               
            }
            else
            {

            }
        }

        public GridView CargarTabla(SqlConnection sqlConnection, GridView GridUsuarios)
        {
            //creamos comando para enviar
            SqlCommand cmd = new SqlCommand("sp_load3", sqlConnection);
            //espesificamos el tipo de comando a enviar
            cmd.CommandType = CommandType.StoredProcedure;
            //abrimos la conexion
            sqlConnection.Open();
            //Creamos un objeto de tipo SqlDataAdapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            //Creamos un objeto de tipo DataTabla
            DataTable dataTable = new DataTable();
            //dataAdapter se llenara con el valor de datatable
            dataAdapter.Fill(dataTable);
            //el grid Creado en la vista tandra los valores  de dataTable
            GridUsuarios.DataSource = dataTable;
            //enlasa los datos al control grid de la vista
            GridUsuarios.DataBind();
            //cerramos la conexion
            sqlConnection.Close();

            return GridUsuarios;
        }

        void enviarDatosADb(string procedure, string id, string Nombre, string Apellido1, string Apellido2, string Calle, string Numero, string Colonia, string Cp, string Telefono, string rfc, string Archivos, string Estatus, string Notas)
        {
            SqlCommand cmd = new SqlCommand(procedure, _conexion);
            _conexion.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            
            if(id != "-1")
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            }
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
            cmd.Parameters.Add("@ApellidoUno", SqlDbType.VarChar).Value = Apellido1;
            cmd.Parameters.Add("@ApellidoDos", SqlDbType.VarChar).Value = Apellido2;
            cmd.Parameters.Add("@Calle", SqlDbType.VarChar).Value = Calle;
            cmd.Parameters.Add("@Numero", SqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@Colonia", SqlDbType.VarChar).Value = Colonia;
            cmd.Parameters.Add("@CodigoPostal", SqlDbType.VarChar).Value = Cp;
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Telefono;
            cmd.Parameters.Add("@rfc", SqlDbType.VarChar).Value = rfc;
            cmd.Parameters.Add("@Archivos", SqlDbType.VarChar).Value = Archivos;
            cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Estatus;
            cmd.Parameters.Add("@Notas", SqlDbType.VarChar).Value = Notas;
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
    }
}
