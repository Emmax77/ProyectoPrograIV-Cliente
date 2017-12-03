using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ProyectoPatrono
{
    public partial class Gestor : Form
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        int contExcel = 0;
        int contXML = 0;
        int contTXT = 0;

        public Gestor()
        {
            InitializeComponent();
        }


        private void Gestor_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            contExcel += 1;
            OFD.Title = "Seleccione el archivo de Excel";
            OFD.FileName = string.Empty;
            OFD.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            OFD.ShowDialog();
        }


        private void OFD_FileOk_1(object sender, CancelEventArgs e)
        {
            dgvDatosBanco.DataSource = null;
            if (contExcel > 0) {
                string rutaArchivo = OFD.FileName;
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
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        nombreHoja = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }

                //Read Data from the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            DataTable dt = new DataTable();
                            cmd.CommandText = "SELECT * From [" + nombreHoja + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();

                            //Populate DataGridView.
                            dgvDatosBanco.DataSource = dt;
                        }
                    }

                }
                contExcel = 0;
            }//fin del if de Excel
            else if (contXML > 0) {
                contXML = 0;
            }//fin del if XML
            else if (contTXT > 0) {
                contTXT = 0;
            }//fin del if de txt

            
        }//Fin de metodo ok de open file dialog

        private void btnXML_Click(object sender, EventArgs e)
        {
            contXML += 1;
            OFD.Title = "Seleccione el archivo de XML";
            OFD.FileName = string.Empty;
            OFD.Filter = "Archivos de XML (*.xml)|*.xml";
            OFD.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contTXT += 1;
            OFD.Title = "Seleccione el archivo de TXT";
            OFD.FileName = string.Empty;
            OFD.Filter = "Archivos de TXT (*.txt)|*.txt";
            OFD.ShowDialog();
        }
    }
}
