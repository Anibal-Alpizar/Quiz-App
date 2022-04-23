using log4net;
using Quiz_Application.Interfaces;
using Quiz_Application.Layers.BLL;
using Quiz_Application.Layers.Entities;
using Quiz_Application.Properties;
using Quiz_Application.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/

namespace Quiz_Application.UI.Principal
{
    public partial class Pay : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public Pay()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Certification certificacion = new Certification();
            certificacion.Visible = true;
            this.Hide();
        }
        private void Pay_Load(object sender, EventArgs e)
        {
            LoadDolarPrice();
            LoadCombo();
            cardNameMasterCard.Text = Settings.Default.Nombre;
            cardNameVisa.Text = Settings.Default.Nombre;
            this.dgvDolar.Visible = false;
            this.txtCliente.Text = Settings.Default.Nombre;

        }
        private void LoadCombo()
        {
            cmbTarjeta.DataSource = System.Enum.GetValues(typeof(PaymentType));
            cmbTarjeta.SelectedIndex = 1;

        }
        private void LoadDolarPrice()
        {
            string correoRegistrado = "your email";
            string token = "your token";    //delete later**** 
            string nombreRegistrado = "your name";
            try
            {
                // Habilitar TLS12
                System.Net.ServicePointManager.SecurityProtocol =
                                              SecurityProtocolType.Tls12;
                // wsindicadoreseconomicosSoap12 Binding tomado del app.Config
                Agente.wsindicadoreseconomicosSoapClient cliente =
                     new Agente.wsindicadoreseconomicosSoapClient("wsindicadoreseconomicosSoap12");

                DataSet ds = cliente.ObtenerIndicadoresEconomicos("317",    /* 317 Compra / 318 Venta */
                                                                  "initial date",      /* Fecha Inicial */
                                                                  "final date",      /* Fecha Final */
                                                                  nombreRegistrado,  /* Su Nombre Registrado   BCCR */
                                                                  "N",
                                                                  correoRegistrado, /* Correo Registrado BCCR */
                                                                  token             /* Token enviado por el BCCR */
                                                                 );

                // Autogenere las columnas del DataGridView
                dgvDolar.AutoGenerateColumns = true;
                // Muestre los datos que vienen en el DataSet en la posicion 0 (Table) 
                dgvDolar.DataSource = ds.Tables[0];

                lblPriceDolar.Text = dgvDolar.Rows[0].Cells[2].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPay.Text))
            {
                MessageBox.Show("You cannot leave fields blank");
                txtPay.Focus();
            }
            else
            {

                IBLLInvoice _IBLLElectronico = new BLLInvoice();

                try
                {
                    Invoice oInvoice = new Invoice();

                    oInvoice.Studen = Settings.Default.Login;
                    oInvoice.Pay = this.txtPay.Text;

                    oInvoice = _IBLLElectronico.SaveInvoice(oInvoice);
                    MessageBox.Show("Payment made successfully");
                    this.btnCertificate.Enabled = true;
                    this.btnCertificate.Visible = true;
                    this.button2.Enabled = false;


                }

                catch (Exception er)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerateQR()
        {
            string quizPrice = txtQuizPrice.Text;
            string card = cmbTarjeta.Text;
            string client = txtCliente.Text;
            string dolarPrice = lblPriceDolar.Text;
            string urPay = txtPay.Text;

            Zen.Barcode.CodeQrBarcodeDraw codigoqr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            imgQR.Image = codigoqr.Draw(
                quizPrice + 
                card + 
                client +  
                dolarPrice + 
                urPay 
                ,
                10);

            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG |*.jpeg";
            saveFileDialog1.FileName = "QrCode.png"; //Default file name


            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string varimg = saveFileDialog1.FileName;
                Bitmap varbmp = new Bitmap(imgQR.Image);
                varbmp.Save(varimg, ImageFormat.Jpeg);
            }
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPay.Text))
            {
                MessageBox.Show("You cannot leave fields blank");
                txtPay.Focus();
            }
            else
            {
                GenerateQR();
            }
        }
    }
}
