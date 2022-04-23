using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/


namespace Quiz_Application.UI.Principal
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDolarPrice();
            this.dgvDolar.Visible = false;
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

                lblDolarPrice.Text = dgvDolar.Rows[0].Cells[2].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
