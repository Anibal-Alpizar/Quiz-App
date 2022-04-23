using log4net;
using Quiz_Application.Layers.BLL;
using Quiz_Application.Layers.Entities;
using Quiz_Application.Properties;
using Quiz_Application.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    public partial class Certification : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        private List<Certificate> QuestionsList = new List<Certificate>();


        public Certification()
        {
            InitializeComponent();
        }
        private void Certification_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.txtUserName.Text = Settings.Default.Login;

            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            this.lblDate.Text = $"Certificacion obtenida el {Date}";
            LoadQuestions();
            ShowInformacion();

        }
        private void ShowInformacion()
        {
        this.lblcongra.Text = dvgQuestionONLYADMIN.Rows[0].Cells[3].Value.ToString();
        this.lblFinalMessage.Text = dvgQuestionONLYADMIN.Rows[0].Cells[4].Value.ToString();
        this.lblPlace.Text = dvgQuestionONLYADMIN.Rows[0].Cells[2].Value.ToString();
        this.lblMessage.Text = dvgQuestionONLYADMIN.Rows[0].Cells[1].Value.ToString();

        }
        private void LoadQuestions()
        {
            BLLCertificate oBllQuiz = new BLLCertificate();
            this.dvgQuestionONLYADMIN.DataSource = oBllQuiz.GetInformation();        
        }

        private void toolStripBtnSendEmail_Click(object sender, EventArgs e)
        {

            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Imagenes JPG,PNG|*.jpg;*.png";
            guardar.FileName = "Certificate.jpg"; //Default file name

            guardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            guardar.ShowDialog();

            if(guardar.FileName != "")
            {
                //bitmap y setear tamagno
                Bitmap bm = new Bitmap(this.Width,this.Height);
                this.DrawToBitmap(bm,new Rectangle(0, 0, this.Width, this.Height));


                FileStream flujo = new FileStream(guardar.FileName, FileMode.Create, FileAccess.Write);
                bm.Save(flujo, System.Drawing.Imaging.ImageFormat.Bmp);

                //Close all
                flujo.Close();
                bm.Dispose();
            }
            
            Attachment attachment = new Attachment(@"C:\"); //** change this

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            msg.To.Add("email here");
            msg.Subject = "Certificate";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = "Email message here";
            msg.Attachments.Add(attachment);

            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("forsendemail90@gmail.com");  //put your email here


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("your email.@.com", "password account"); //changed later*
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com"; //mail.domain.ComponentModel

            try
            {
                cliente.Send(msg);
                MessageBox.Show("Check your email");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al enviar");
            }

        }
    }         
}
