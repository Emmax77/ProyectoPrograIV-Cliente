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
using System.Xml;

namespace ProyectoPatrono
{
    public partial class Gestor : Form
    {

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
            Stream input = null;
            dgvDatosBanco.DataSource = null;
            if (contExcel > 0) { 
            string rutaArchivo = OFD.FileName;
            CapaLogica.Logica.ruta = rutaArchivo;
            CapaLogica.Logica n = new CapaLogica.Logica();
            dgvDatosBanco.DataSource = n.retornoExcel();
            dgvActual.DataSource = n.retornoExcel();
            dgvEdicion.DataSource = n.retornoExcel();
    
            contExcel = 0;
            }//fin del if de Excel
            else if (contXML > 0) {
                try
                {
                    if ((input = OFD.OpenFile()) != null)
                    {
                        using (input)
                        {
                            XmlReader xmlFile = XmlReader.Create(input, new XmlReaderSettings());
                            DataSet dataSet = new DataSet();
                            dataSet.ReadXml(xmlFile);
                            DataSet containers = new DataSet();
                            dgvDatosBanco.DataSource = dataSet.Tables[0];
                            dgvActual.DataSource = dataSet.Tables[0];
                            dgvEdicion.DataSource = dataSet.Tables[0];
                            xmlFile.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR");
                }

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Reporte.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dgvEdicion, sfd.FileName); // Here dataGridview1 is your grid view name

            }
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            int id = Convert.ToInt32(txtIdEmpleado.Text);
            CapaLogica.Logica m = new CapaLogica.Logica();
            if (m.consultar(id) == true)
            {
                txtNombre.Text = CapaLogica.Logica.nom;
                txtApellido1.Text = CapaLogica.Logica.ape1;
                txtApellido2.Text = CapaLogica.Logica.ape2;
            }
            else {
                MessageBox.Show(CapaLogica.Logica.error);
            }
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            int idlote = 0;
            int idCredito = 0;
            int amortizacion = 0;
            int intereses = 0;
            
            string nombre = txtNombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;
            try
            {
                if (nombre != "")
                {
                    int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                    foreach (DataGridViewRow dgvRenglon in dgvEdicion.Rows)
                    {
                        idlote = Convert.ToInt32(dgvRenglon.Cells[0].Value);
                        idCredito = Convert.ToInt32(dgvRenglon.Cells[3].Value);
                        amortizacion = Convert.ToInt32(dgvRenglon.Cells[7].Value);
                        intereses = Convert.ToInt32(dgvRenglon.Cells[8].Value);
                    }
                    CapaLogica.Logica o = new CapaLogica.Logica();
                    if (o.pago(idlote, idEmpleado, idCredito, amortizacion, intereses, nombre, apellido1, apellido2) == true)
                    {
                        MessageBox.Show("Pago aplicado");
                    }
                    else
                    {
                        MessageBox.Show(CapaLogica.Logica.error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el Empleado para realizar el pago");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            
            
        }
    }
}
