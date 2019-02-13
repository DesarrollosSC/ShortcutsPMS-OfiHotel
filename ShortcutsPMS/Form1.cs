using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

using System.Globalization;
using Microsoft.Win32;
using System.IO;

namespace ShortcutsPMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'shortcutsPOSDataSet.historys' Puede moverla o quitarla según sea necesario.
            this.historysTableAdapter.Fill(this.shortcutsPOSDataSet.historys);
            // TODO: esta línea de código carga datos en la tabla 'shortcutsPOSDataSet.scvShortcutsPMS' Puede moverla o quitarla según sea necesario.
           this.scvShortcutsPMSTableAdapter.Fill(this.shortcutsPOSDataSet.scvShortcutsPMS);
            IntegracionesSPA.IntegracionSPA spa = new IntegracionesSPA.IntegracionSPA();
           
            
            spa.inicializar("OfiHotel", "Ofihotel137", "sa", "salon.spa", spa.proveedores.ProviderSQL());
            DateTime data = DateTime.Now;

            string fechaString = string.Format("{0:dd/MM/yyyy}", data);

            data= DateTime.Parse(fechaString.ToString());

            scvShortcutsPMSDataGridView.DataSource = scvShortcutsPMSTableAdapter.GetDataOrderDesc(data);

            string[] ultimaVenta = new string[8];

            ultimaVenta = obtenirUltimaVenta();

            UltimaSaleID = ultimaVenta[0];

            timer1.Start();
            timer1.Interval = 5000; // 1 min 60000

        }

     /*   private String[] obtenirReserva(string hab)
        {
            String [] reserva = new string [2];

            try
            {
                
                string ruta = obtenirRuta();
                string cadena = "Driver={Microsoft dBASE Driver (*.dbf)};DriverId=277;dbq=" + ruta;
                OdbcConnection con = new OdbcConnection();
                con.ConnectionString = cadena;

                con.Open();

                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandText = "select ESTADO,RESERVA from MAJHABIT.DBF where HABITACION=?";

                OdbcParameter habitacion = new OdbcParameter("@hab", OdbcType.VarChar);
                habitacion.Value = hab;
                cmd.Parameters.Add(habitacion);

                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reserva[0] = reader[0].ToString();
                    reserva[1] = reader[1].ToString();
                }

                con.Close();

                return reserva;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return reserva;

        }*/

        private string[] obtenirUltimaVenta()
        {
            string[] UltimaVenta = new string[8];

            try
            {

                DataTable ultimaVentaTable = new DataTable();

                ultimaVentaTable = scvShortcutsPMSTableAdapter.GetDataUltimaVenta();

                UltimaVenta[0] = ultimaVentaTable.Rows[0]["SaleID"].ToString();
                UltimaVenta[1] = ultimaVentaTable.Rows[0]["Date"].ToString();
                UltimaVenta[2] = ultimaVentaTable.Rows[0]["ClientId"].ToString();
                UltimaVenta[3] = ultimaVentaTable.Rows[0]["Hab"].ToString();
                UltimaVenta[4] = ultimaVentaTable.Rows[0]["Time"].ToString();
                UltimaVenta[5] = ultimaVentaTable.Rows[0]["PrecioSinIva"].ToString();
                UltimaVenta[6] = ultimaVentaTable.Rows[0]["Iva"].ToString();
                UltimaVenta[7] = ultimaVentaTable.Rows[0]["Precio"].ToString();
            }
            catch (Exception e)
            {
                UltimaVenta[0] = "0";
            }

            return UltimaVenta;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           realitzarProces();
        }

        private void realitzarProces()
        {
            IntegracionesSPA.IntegracionSPA spa = new IntegracionesSPA.IntegracionSPA();
            IntegracionesSPA.result res = new IntegracionesSPA.result();
            if (obtenirConcepto("Inst") != "NODATOS")
            {
                res = spa.inicializar(obtenirConcepto("Inst"), obtenirConcepto("Bdd"), "sa", obtenirConcepto("Pass"), spa.proveedores.ProviderSQL());
                if (!res.estadoFuncion)
                {
                    for (int i = 1; i <= spa.erroresAdo.Count; i++)
                    {
                        MessageBox.Show(spa.erroresAdo.Item[i].descripcion);
                    }
                }
                DateTime data = DateTime.Now;
                string fechaString = string.Format("{0:dd/MM/yyyy}", data);
                data = DateTime.Parse(fechaString.ToString());

                //Creo un nuevo formato de numero para poder cambiar la , por un . en el precio de las transacciones.
                NumberFormatInfo nfi = new CultureInfo("es-ES", false).NumberFormat;

                string[] ultimaVenta;
                string[] taulaReserva;
                string[] imports;
                string Hab;
                int saleIdActual, saleIdUltimaVenta;

                try
                {

                    ultimaVenta = obtenirUltimaVenta();

                    saleIdActual = int.Parse(UltimaSaleID);
                    saleIdUltimaVenta = int.Parse(ultimaVenta[0].ToString());


                    if (saleIdActual < saleIdUltimaVenta) //saleIdActual es la ultima saleID procesada
                    //saleIdUltimaVenta es la id de la ultima venta realitzada 
                    {
                        UltimaSaleID = ultimaVenta[0].ToString();
                        Hab = ultimaVenta[3].ToString();

                        if (Hab != "")
                        {
                            res = spa.EstaHabOcupada(Hab);
                            //  taulaReserva = obtenirReserva(Hab);

                            if (res.estadoFuncion)
                            {
                                imports = obtenirImports(int.Parse(ultimaVenta[0]));
                                //res = spa.AgregarCargoHAB(Hab, obtenirConcepto("CodServ"), obtenirConcepto("Serv"), Convert.ToDouble(ultimaVenta[7]), true);

                                if (imports[0] != null)
                                {
                                    string tipos = "PRODUCTOS SPA";

                                    res = spa.AgregarCargoHAB(Hab, obtenirConcepto("CodProd"), obtenirConcepto("Prod"), double.Parse(imports[0].ToString()), false);
                                    if (!res.estadoFuncion)
                                    {
                                        for (int i = 1; i <= spa.erroresAdo.Count; i++)
                                        {
                                            MessageBox.Show(spa.erroresAdo.Item[i].descripcion);
                                        }
                                    }

                                    //MessageBox.Show(res.estadoFuncion.ToString());
                                    //MessageBox.Show(obtenirConcepto("CodProd"));
                                    //MessageBox.Show(double.Parse(imports[0].ToString(), CultureInfo.GetCultureInfo("es-ES").NumberFormat).ToString());
                                }
                                if (imports[1] != null)
                                {
                                    string tipos = "PRODUCTOS SPA";
                                    res = spa.AgregarCargoHAB(Hab, obtenirConcepto("CodServ"), obtenirConcepto("Serv"), double.Parse(imports[1].ToString()), false);
                                    if (!res.estadoFuncion)
                                    {
                                        for (int i = 1; i <= spa.erroresAdo.Count; i++)
                                        {
                                            MessageBox.Show(spa.erroresAdo.Item[i].descripcion);
                                        }
                                    }
                                    //MessageBox.Show(res.estadoFuncion.ToString());
                                    //MessageBox.Show(obtenirConcepto("CodServ"));
                                    //MessageBox.Show(double.Parse(imports[1].ToString(), CultureInfo.GetCultureInfo("es-ES").NumberFormat).ToString());
                                    //escriureVentas(Hab, fechaString, imports[1], taulaReserva[1], Hora, saleId.ToString(), Total, tipos);
                                }

                                if (imports[2] != null)
                                {

                                    res = spa.AgregarCargoHAB(Hab, obtenirConcepto("CodTrat"), obtenirConcepto("Trat"), double.Parse(imports[2].ToString()), false);
                                    if (!res.estadoFuncion)
                                    {
                                        for (int i = 1; i <= spa.erroresAdo.Count; i++)
                                        {
                                            MessageBox.Show(spa.erroresAdo.Item[i].descripcion);
                                        }
                                    }
                                    //MessageBox.Show(res.estadoFuncion.ToString());
                                    //MessageBox.Show(obtenirConcepto("CodServ"));
                                    //MessageBox.Show(double.Parse(imports[1].ToString(), CultureInfo.GetCultureInfo("es-ES").NumberFormat).ToString());
                                    //escriureVentas(Hab, fechaString, imports[1], taulaReserva[1], Hora, saleId.ToString(), Total, tipos);
                                }

                                if (!res.estadoFuncion)
                                {
                                    for (int i = 1; i <= spa.erroresAdo.Count; i++)
                                    {
                                        MessageBox.Show(spa.erroresAdo.Item[i].descripcion);
                                    }
                                }

                            }
                            else
                            {
                                string nota;
                                nota = ultimaVenta[1] + "-La habitación " + ultimaVenta[3] + " esta DESOCUPADA.";
                                escriureLog(nota);
                            }
                        }

                        scvShortcutsPMSDataGridView.DataSource = scvShortcutsPMSTableAdapter.GetDataOrderDesc(data);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
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
                    ruta = (string)Registry.GetValue(keyName, "Ruta", "");

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
            else if (tipos == "CodServ")
            {
                valor = "CodServicio";
            }
            else if (tipos == "CodProd")
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
            else if (tipos == "CodTrat")
            {
                valor = "CodTratamiento";
            }
            else if (tipos == "Trat")
            {
                valor = "ConceptoTratamiento";
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
                concepto = "NODATOS";
            }

            return concepto;
        }

        public string[] obtenirImports(int SaleID)
        {
            string[] imports = new string[3];
            double sumaP = 0, sumaS = 0, sumaT = 0;

            try
            {
                DataTable importProd = new DataTable();
                importProd=historysTableAdapter.GetDataImportProd(SaleID);
                if (importProd.Rows.Count > 0)
                {
                    for (int i= 0;i<importProd.Rows.Count;i++)
                    {
                        sumaP = sumaP+double.Parse(importProd.Rows[i]["total"].ToString());
                    }
                    imports[0] =sumaP.ToString();
                }

                DataTable importServ = new DataTable();
                importServ = historysTableAdapter.GetDataImportServ(SaleID);
                if (importServ.Rows.Count > 0)
                {
                    for (int i = 0; i < importServ.Rows.Count; i++)
                    {
                        sumaS=sumaS+ double.Parse(importServ.Rows[i]["total"].ToString());
                    }
                    imports[1] = sumaS.ToString();
                }

                DataTable importTrat = new DataTable();
                importTrat = historysTableAdapter.GetDataImportTrat(SaleID);
                if (importTrat.Rows.Count > 0)
                {
                    for (int i = 0; i < importTrat.Rows.Count; i++)
                    {
                        sumaT = sumaT + double.Parse(importTrat.Rows[i]["total"].ToString());
                    }
                    imports[2] = sumaT.ToString();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return imports;
        }

        private void enviarVenta()
        {
            string[] taulaReserva;
            string[] imports;

            if (this.scvShortcutsPMSDataGridView.RowCount > 0)
            {
                IntegracionesSPA.IntegracionSPA spa = new IntegracionesSPA.IntegracionSPA();
                IntegracionesSPA.result res = new IntegracionesSPA.result();
                res = spa.inicializar(obtenirConcepto("Inst"), obtenirConcepto("Bdd"), "sa", obtenirConcepto("Pass"), spa.proveedores.ProviderSQL());
              //  MessageBox.Show(res.estadoFuncion.ToString());
                int indexSelect = this.scvShortcutsPMSDataGridView.CurrentRow.Index;

                int saleId = int.Parse(this.scvShortcutsPMSDataGridView.Rows[indexSelect].Cells[0].Value.ToString());

                string Hab = this.scvShortcutsPMSDataGridView.Rows[indexSelect].Cells[1].Value.ToString();
                string Base = this.scvShortcutsPMSDataGridView.Rows[indexSelect].Cells[4].Value.ToString();
                string Hora = this.scvShortcutsPMSDataGridView.Rows[indexSelect].Cells[3].Value.ToString();
                string Total = this.scvShortcutsPMSDataGridView.Rows[indexSelect].Cells[6].Value.ToString();

                if (Hab != "")
                {
                    res = spa.EstaHabOcupada(Hab); //obtenirReserva(Hab);

                    if (res.estadoFuncion)
                    {

                        string fechaString = string.Format("{0:dd/MM/yyyy}", dateTimePicker1.Value);

                        DialogResult resultat= MessageBox.Show("Esta Seguro que quiere registrar esta venta","Aviso",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                        if (resultat == DialogResult.OK)
                        {
                            imports = obtenirImports(saleId);
                           // MessageBox.Show(imports[1].ToString());
                            if (imports[0] != null)
                            {
                                string tipos = "PRODUCTOS SPA";

                                res = spa.AgregarCargoHAB(Hab, obtenirConcepto("CodProd"), obtenirConcepto("Prod"), double.Parse(imports[0].ToString()), false);
                                if (!res.estadoFuncion)
                                {
                                    for (int i = 1; i <= spa.erroresAdo.Count; i++)
                                    {
                                        MessageBox.Show(spa.erroresAdo.Item[i].descripcion);
                                    }
                                }
                                
                                //MessageBox.Show(res.estadoFuncion.ToString());
                                //MessageBox.Show(obtenirConcepto("CodProd"));
                                //MessageBox.Show(double.Parse(imports[0].ToString(), CultureInfo.GetCultureInfo("es-ES").NumberFormat).ToString());
                            }
                            if (imports[1] != null)
                            {
                                string tipos = "PRODUCTOS SPA";
                                res = spa.AgregarCargoHAB(Hab, obtenirConcepto("CodServ"), obtenirConcepto("Serv"), double.Parse(imports[1].ToString()), false);
                               if (!res.estadoFuncion)
                               {
                                   for (int i = 1; i <= spa.erroresAdo.Count;i++ )
                                   {
                                       MessageBox.Show(spa.erroresAdo.Item[i].descripcion);
                                   }
                               }
                                //MessageBox.Show(res.estadoFuncion.ToString());
                                //MessageBox.Show(obtenirConcepto("CodServ"));
                                //MessageBox.Show(double.Parse(imports[1].ToString(), CultureInfo.GetCultureInfo("es-ES").NumberFormat).ToString());
                                //escriureVentas(Hab, fechaString, imports[1], taulaReserva[1], Hora, saleId.ToString(), Total, tipos);
                            }
                            if (imports[2] != null)
                            {
                                
                                res = spa.AgregarCargoHAB(Hab, obtenirConcepto("CodTrat"), obtenirConcepto("Trat"), double.Parse(imports[2].ToString()), false);
                                if (!res.estadoFuncion)
                                {
                                    for (int i = 1; i <= spa.erroresAdo.Count; i++)
                                    {
                                        MessageBox.Show(spa.erroresAdo.Item[i].descripcion);
                                    }
                                }
                                //MessageBox.Show(res.estadoFuncion.ToString());
                                //MessageBox.Show(obtenirConcepto("CodServ"));
                                //MessageBox.Show(double.Parse(imports[1].ToString(), CultureInfo.GetCultureInfo("es-ES").NumberFormat).ToString());
                                //escriureVentas(Hab, fechaString, imports[1], taulaReserva[1], Hora, saleId.ToString(), Total, tipos);
                            }

                            if (res.estadoFuncion)
                            {
                                MessageBox.Show("Transacción registrada correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Esta habitación no esta ocupada en este momento.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Esta venta no esta asignada a ninguna Habitación!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void escriureLog(string nota)
        {
            string path;
            Directory.CreateDirectory("LOG");
            path = Path.GetFullPath("LOG");
            string fileName = path + "/ShortcutsPMSLog.txt";
            System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true);
            writer.WriteLine(nota);
            writer.Close();
        }

        private void btnCargarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaString = string.Format("{0:dd/MM/yyyy}", dateTimePicker1.Value);

                DateTime data = DateTime.Parse(fechaString.ToString());

                scvShortcutsPMSDataGridView.DataSource = scvShortcutsPMSTableAdapter.GetDataOrderDesc(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnEnviarVenta_Click(object sender, EventArgs e)
        {
            enviarVenta();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Form Config = new Config();

            Config.Show();
        }

        private bool existeixArxiu(string arxiu)
        {
            bool existeix = false;

            if (System.IO.File.Exists(arxiu))
            {
                existeix = true;
            }

            return existeix;
        }

        private void scvShortcutsPMSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
