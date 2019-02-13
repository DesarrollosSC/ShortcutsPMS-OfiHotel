using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;

namespace ShortcutsPMS
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void Config_Load(object sender, EventArgs e)
        {

           // lblCarpetaArxius.Text = obtenirRuta();
           // txtBxConceptoSrv.Text = obtenirConcepto("Serv");
         //   txtBxConceptoProd.Text = obtenirConcepto("Prod");
          //  txtCodProd.Text = obtenirConcepto("CodProd");
          //  txtCodServ.Text = obtenirConcepto("CodServ");
            leerConcepto();
        }

        private void btnBuscarArxius_Click(object sender, EventArgs e)
        {
            string ruta;
          
            folderBrowserDialog1.ShowDialog();
            ruta = folderBrowserDialog1.SelectedPath.ToString();

            Microsoft.Win32.RegistryKey keyConfig;

            keyConfig = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\ShortcutsPMS\Config");

            keyConfig.SetValue("Ruta", ruta);

            keyConfig.Close();

          //  lblCarpetaArxius.Text = ruta;
        }

        public string obtenirRuta()
        {

            string userRoot = "HKEY_LOCAL_MACHINE";
            string subkey = "SOFTWARE\\ShortcutsPMS\\Config";
            string subkey2 = "SOFTWARE\\Wow6432Node\\ShortcutsPMS\\Config";

            string keyName = userRoot + "\\" + subkey;
            string keyName2 = userRoot + "\\" + subkey2;

            string ruta = "";


            if (Registry.GetValue(keyName, "Ruta", null) != null)
            {
                ruta = (string)Registry.GetValue(keyName,"Ruta", "");

            }
            else if (Registry.GetValue(keyName2, "Ruta", null) != null)
            {
                ruta = (string)Registry.GetValue(keyName2, "Ruta", "");
            }
            else
            {
                ruta = "No creada";
            }

            return ruta;
        }

        public string obtenirConcepto(string tipos)
        {
            string userRoot = "HKEY_LOCAL_MACHINE";
            string subkey = "SOFTWARE\\ShortcutsPMS\\Config";
            string subkey2 = "SOFTWARE\\Wow6432Node\\ShortcutsPMS\\Config";

            string keyName = userRoot + "\\" + subkey;
            string keyName2 = userRoot + "\\" + subkey2;

            string concepto = "";
            string valor = "";

            if (tipos == "Prod")
            {
                valor = "ConceptoProducto";
            }
            else if (tipos == "Serv")
            {
                valor = "ConceptoServicio";
            }
            else if (tipos=="CodServ")
            { 
                valor="CodServicio";
            }
            else if (tipos=="CodProd")
            {
                valor = "CodProducto";
            }
            else if (tipos == "Inst")
            {
                valor = "Instancia";
            }
            else if (tipos == "Bdd")
            {
                valor = "Bdd";
            }
            else if (tipos == "Pass")
            {
                valor = "Pass";
            }

            if (Registry.GetValue(keyName, valor, null) != null)
            {
                concepto = (string)Registry.GetValue(keyName, valor, "");

            }
            else if (Registry.GetValue(keyName2, valor, null) != null)
            {
                concepto = (string)Registry.GetValue(keyName2, valor, "");
            }
            else
            {
                if (tipos == "Prod")
                {
                    concepto = "Prod Spa";
                }
                else if (tipos == "Serv")
                {
                    concepto = "Serv Spa";
                }
                else if (tipos == "CodServ")
                {
                    valor = "SPA";
                }
                else if (tipos == "CodProd")
                {
                    valor = "SPA1";
                }
            }
           
           
            return concepto;
        }

        public void guardarConcepto(string [] concepto)
        {
            Microsoft.Win32.RegistryKey keyConfig;

            keyConfig = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\ShortcutsPMS\Config");

            keyConfig.SetValue("ConceptoProducto", concepto[0]);
            keyConfig.SetValue("ConceptoServicio", concepto[1]);
            keyConfig.SetValue("CodServicio", concepto[2]);
            keyConfig.SetValue("CodProducto", concepto[3]);
            keyConfig.SetValue("Instancia", concepto[4]);
            keyConfig.SetValue("Bdd", concepto[5]);
            keyConfig.SetValue("Pass", concepto[6]);
            keyConfig.SetValue("ConceptoTratamiento", concepto[8]);
            keyConfig.SetValue("CodTratamiento", concepto[7]);

            keyConfig.Close();

        }
        public void leerConcepto()
        {
            Microsoft.Win32.RegistryKey keyConfig;

            keyConfig = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\ShortcutsPMS\Config");

            txtCodServ.Text = keyConfig.GetValue("CodServicio").ToString();
            txtCodProd.Text = keyConfig.GetValue("CodProducto").ToString();
            txtBxConceptoSrv.Text = keyConfig.GetValue("ConceptoServicio").ToString();
            txtBxConceptoProd.Text = keyConfig.GetValue("ConceptoProducto").ToString();
            txtInstancia.Text = keyConfig.GetValue("Instancia").ToString();
            txtBdd.Text = keyConfig.GetValue("Bdd").ToString();
            txtPass.Text = keyConfig.GetValue("Pass").ToString();
            txtCodTrat.Text = keyConfig.GetValue("CodTratamiento").ToString();
            txtBxConceptoTrat.Text = keyConfig.GetValue("ConceptoTratamiento").ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string[] conceptos = new string[9];

            conceptos[0] = txtBxConceptoProd.Text;
            conceptos[1] = txtBxConceptoSrv.Text;
            conceptos[2] = txtCodServ.Text;
            conceptos[3] = txtCodProd.Text;
            conceptos[4] =txtInstancia.Text;
            conceptos[5] = txtBdd.Text;
            conceptos[6] = txtPass.Text;
            conceptos[7] = txtCodTrat.Text;
            conceptos[8] = txtBxConceptoTrat.Text;

            guardarConcepto(conceptos);
        }
    }
}
