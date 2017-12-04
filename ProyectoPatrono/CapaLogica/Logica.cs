using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Logica
    {
        public static string ruta { get; set; }
        public static DataTable tabla { get; set; }
        public static string idEmpleado { get; set; }
        public static string error { get; set; }
        public static string nom { get; set; }
        public static string ape1 { get; set; }
        public static string ape2 { get; set; }


        public DataTable retornoExcel() {
            CapaDatos.Metodos n = new CapaDatos.Metodos();
             tabla = n.excelRetorno(ruta);
            return tabla;
        }


        public bool consultar(int n) {
            CapaDatos.Metodos o = new CapaDatos.Metodos();
            nom = "";
            ape1 = "";
            ape2 = "";
            if (o.ConsultarEmpleados(n) == true)
            {
                nom = CapaDatos.Metodos.nom;
                ape1 = CapaDatos.Metodos.ape1;
                ape2 = CapaDatos.Metodos.ape2;
                return true;
            }
            else {
                error = CapaDatos.Metodos.error;
                return false;
            }

        }

        public bool pago(int lote, int idEmpleado ,int credito, int amortizacion, int intereses, string nom, string ape1, string ape2) {
            CapaDatos.Metodos n = new CapaDatos.Metodos();
            if (n.realizarPago(lote, idEmpleado, credito, amortizacion, intereses, nom, ape1, ape2) == true)
            {
                return true;
            }
            else {
                error = CapaDatos.Metodos.error;
                return false;
            }
        }
    }
}
