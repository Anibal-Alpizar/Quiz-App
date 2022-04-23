using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Application.UI.Principal.Report.Scores
{
    public partial class frmInformeScores : Form
    {
        public frmInformeScores()
        {
            InitializeComponent();
        }

        private void frmInformeScores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetScores.MostrarCalificaiones' table. You can move, or remove it, as needed.
            this.MostrarCalificaionesTableAdapter.Fill(this.DataSetScores.MostrarCalificaiones);

            this.reportViewer1.RefreshReport();
        }

        private void toolStripBtnSendEmail_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Imagenes JPG,PNG|*.jpg;*.png";
            guardar.FileName = "InformeScore.jpg"; //Default file name

            guardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            guardar.ShowDialog();

            if (guardar.FileName != "")
            {
                //bitmap y setear tamagno
                Bitmap bm = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));


                FileStream flujo = new FileStream(guardar.FileName, FileMode.Create, FileAccess.Write);
                bm.Save(flujo, System.Drawing.Imaging.ImageFormat.Bmp);

                //Close all
                flujo.Close();
                bm.Dispose();
            }
            Attachment attachment = new Attachment(@"C:\Users\aniba\Desktop\InformeScore.jpg"); //** change this

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            msg.To.Add("anibalpruebas1@gmail.com");
            msg.Subject = "Certificate";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = "Se adjunta el informe";
            msg.Attachments.Add(attachment);

            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("forsendemail90@gmail.com");


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("forsendemail90@gmail.com", "ADaniel1234"); //changed later*
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com"; //mail.dominio.ComponentModel

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
