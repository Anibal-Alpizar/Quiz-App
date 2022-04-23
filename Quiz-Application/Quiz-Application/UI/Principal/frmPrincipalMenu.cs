using Quiz_Application.Properties;
using Quiz_Application.UI.Principal.Report;
using Quiz_Application.UI.Principal.Report.Questions;
using Quiz_Application.UI.Principal.Report.Scores;
using Quiz_Application.UI.Principal.Report.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
Copyright(c) 2022 Anibal - Alpizar.
https://github.com/Anibal-Alpizar
*/

namespace Quiz_Application.UI.Principal
{
    public partial class frmPrincipalMenu : Form
    {
        public frmPrincipalMenu()
        {
            InitializeComponent();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void OpenFormPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void frmPrincipalMenu_Load(object sender, EventArgs e)
        {
            OpenFormPanel(new Dashboard());
            this.txtUserName.Text = Settings.Default.Nombre;
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Login.Equals("Admin") || Settings.Default.Login.Equals("admin"))
            {
                OpenFormPanel(new Candidates());
            }
            else
            {
                MessageBox.Show("You are not authorized to this section");
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new Dashboard());
        }

        private void btnMaintenanceQuestions_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Login.Equals("Admin") || Settings.Default.Login.Equals("admin"))
            {
                OpenFormPanel(new Questions());
            }
            else
            {
                MessageBox.Show("You are not authorized to this section");
            }
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new Quices());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new AboutMe());
        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconcerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Login.Equals("Reporter") || Settings.Default.Login.Equals("reporter") ||
              Settings.Default.Login.Equals("Admin") || Settings.Default.Login.Equals("admin"))
            {
                frmInformeScores frmInformeScores = new frmInformeScores();
                frmInformeScores.Show();
            }
            else
            {
                MessageBox.Show("You are not authorized to this section");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Settings.Default.Login.Equals("Reporter") || Settings.Default.Login.Equals("reporter") ||
           Settings.Default.Login.Equals("Admin") || Settings.Default.Login.Equals("admin"))
            {
                frmInformeQuestions frmInformeQuestions = new frmInformeQuestions();
                frmInformeQuestions.Show();
            }
            else
            {
                MessageBox.Show("You are not authorized to this section");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Settings.Default.Login.Equals("Reporter") || Settings.Default.Login.Equals("reporter") ||
                Settings.Default.Login.Equals("Admin") || Settings.Default.Login.Equals("admin"))
            {
                frmInformeStudents frmInformeStudents = new frmInformeStudents();
                frmInformeStudents.Show();
            }
            else
            {
                MessageBox.Show("You are not authorized to this section");
            }
        }
    }
}
