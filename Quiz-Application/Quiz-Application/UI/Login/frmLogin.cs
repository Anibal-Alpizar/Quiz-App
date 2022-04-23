using Quiz_Application.Interfaces;
using Quiz_Application.Layers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Quiz_Application.Layers.BLL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Quiz_Application.Properties;
using System.Reflection;
using Quiz_Application.Util;
using Quiz_Application.UI.Principal;
using Quiz_Application.UI.Load;
using Quiz_Application.UI.Principal.Report;


/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/

namespace Quiz_Application.UI.Login
{
    public partial class frmLogin : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Debe validar los datos requeridos
            IBLLCandidates _BLLUsuario = new BLLCandidates();
            epError.Clear();
            Candidate oUsuario = null;
            try
            {
                if (string.IsNullOrEmpty(this.txtLogin.Text))
                {
                    epError.SetError(txtLogin, "Usuario requerido");
                    this.txtLogin.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    epError.SetError(txtPassword, "Contraseá requerida");
                    this.txtPassword.Focus();
                    return;
                }

                oUsuario = _BLLUsuario.Login(this.txtLogin.Text,
                                           this.txtPassword.Text);

                if (oUsuario == null)
                {
                    ++contador;
                    MessageBox.Show("Error en el acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Si el contador es 3 cierre la aplicación
                    if (contador == 3)
                    {
                        // se devuelve Cancel
                        MessageBox.Show("Se equivocó en 3 ocasiones, el Sistema se Cerrará por seguridad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                        Application.Exit();
                    }
                }
                else
                {
                    Settings.Default.Login = this.txtLogin.Text.Trim();
                    Settings.Default.Password = this.txtPassword.Text.Trim();
                    Settings.Default.Nombre = oUsuario.Name;
                    Settings.Default.RolId = oUsuario.Id;


                    frmLoad frmLoad = new frmLoad();                   
                    frmLoad.Show();                 
                    this.Hide();

                    // Log 
                    _MyLogControlEventos.InfoFormat("Entró a la aplicación :{0}", Settings.Default.Nombre);
                    this.DialogResult = DialogResult.OK;

                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Enter(string pHolder, TextBox pText)
        {
            if (pText.Text == pHolder)
            {
                pText.Text = string.Empty;
                pText.ForeColor = Color.Black;
            }
        }
        public void Leave(string pHolder, TextBox pText)
        {
            if (pText.Text == string.Empty)
            {
                pText.Text = pHolder;
                pText.ForeColor = Color.DimGray;
            }
        }
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            Enter("User name", txtLogin);
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            Leave("User name", txtLogin);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Enter("Password", txtPassword);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Leave("Password", txtPassword);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Leave("User name", txtLogin);
            Leave("Password", txtPassword);
        }
    }
}
