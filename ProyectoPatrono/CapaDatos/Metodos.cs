using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Metodos

    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public static string nom { get; set; }
        public static string ape1 { get; set; }
        public static string ape2 { get; set; }
        string Cadena = @"Data Source=EMMANUELGR\SQL2016;Initial Catalog=Patrono;Integrated Security=True";
        SqlConnection objConexion;
        SqlCommand objComando;
        OleDbConnection con;
        OleDbCommand cmd;
        public static string error {get;set;}

        private void Conectar(bool pConectar)
        {
            objConexion = new SqlConnection();
            objConexion.ConnectionString = Cadena;
            if (pConectar)
            {
                objConexion.Open();
            }
            else
            {
                objConexion.Close();

            }
        }

        public DataTable excelRetorno(string n) {

                string rutaArchivo = n;
                string extension = Path.GetExtension(rutaArchivo);
                string header = "YES";
                string conStr, nombreHoja;

                conStr = string.Empty;
                switch (extension)
                {

                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03ConString, rutaArchivo, header);
                        break;

                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07ConString, rutaArchivo, header);
                        break;
                }

            //Get the name of the First Sheet.
            cmd = new OleDbCommand();
            con = new OleDbConnection(conStr);
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = con;
                con.Open();
                DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                nombreHoja = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                con.Close();

                OleDbDataAdapter oda = new OleDbDataAdapter();
                
                cmd.CommandText = "SELECT * From [" + nombreHoja + "]";
                cmd.Connection = con;
                con.Open();
                oda.SelectCommand = cmd;
                oda.Fill(dt);
                con.Close();

                //Populate DataGridView.
                return dt;
            }
            catch (Exception ex)
            {
                con.Close();
                return dt;
            }
            
                        
                    }



        public bool ConsultarEmpleados(int id)
        {
            nom = "";
            ape1 = "";
            ape2 = "";
            try
            {
                SqlDataReader dr;
                Conectar(true);
                objComando = new SqlCommand();
                objComando.Connection = objConexion;
                objComando.CommandTimeout = 0;
                objComando.CommandType = CommandType.Text;
                objComando.CommandText = "Select * from Empleado where idEmpleado=" + id;
                dr = objComando.ExecuteReader();
                while (dr.Read()) {
                    nom = dr.GetString(1);
                    ape1 = dr.GetString(2);
                    ape2 = dr.GetString(3);
                }
                Conectar(false);
                return true;

            }
            catch (Exception ex)
            {
                error = ex.ToString();
                Conectar(false);
                return false;
            }
        }


        public bool realizarPago(int lote, int idEmpleado, int credito, int amortizacion, int intereses, string nom, string ape1, string ape2) {
            int cont = 0;
            SqlDataReader dr;
            try
            {
                Conectar(true);
                objComando = new SqlCommand();
                objComando.Connection = objConexion;
                objComando.CommandTimeout = 0;
                objComando.CommandType = CommandType.Text;
                objComando.CommandText = "Select MAX(idDeduccion) from DeduccionEmpleado";
                dr = objComando.ExecuteReader();
                while (dr.Read())
                {
                       cont = dr.GetInt32(0);
                    
                    
                }
                Conectar(false);
                Conectar(true);
                objComando = new SqlCommand();
                objComando.Connection = objConexion;
                objComando.CommandTimeout = 0;
                objComando.CommandType = CommandType.Text;
                objComando.CommandText = "insert into DeduccionEmpleado(IdDeduccion,IdLote,IdEmpleado,FechaCorte,IdCredito,Amortizacion,Intereses) values ("+ (cont + 1)+", "+lote+", "+idEmpleado+", "+ "'04/12/2017'"+","+credito+","+amortizacion+","+intereses+")";
                int num = objComando.ExecuteNonQuery();
                objComando.CommandText = "insert into DeduccionAplicada(IdDeduccion,Amortizacion,Intereses) values (" + (cont + 1) + ", " + amortizacion + "," + intereses + ")";
                num = objComando.ExecuteNonQuery();
                Conectar(false);
                return true;
            }
            catch (Exception ex)
            {
                Conectar(false);
                error = ex.ToString();
                return false;
            }
            
        }

    }
    
}
