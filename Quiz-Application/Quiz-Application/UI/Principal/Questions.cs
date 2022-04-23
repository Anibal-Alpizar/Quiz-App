using log4net;
using Quiz_Application.Interfaces;
using Quiz_Application.Layers.BLL;
using Quiz_Application.Layers.Entities;
using Quiz_Application.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class Questions : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public Questions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanFields();
            EnableFields();
            EnableButtons();
            this.CargarDatos();
            this.btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPrincipalQuestion.Text) || string.IsNullOrEmpty(this.txtOption1.Text)
                           || string.IsNullOrEmpty(this.txtOption2.Text) || string.IsNullOrEmpty(this.txtOption3.Text)
                           || string.IsNullOrEmpty(this.txtOption4.Text) || string.IsNullOrEmpty(this.txtCorrectOption.Text))
            {
                MessageBox.Show("Information is missing");

            }
            else
            {
                IBLLQuestions _IBLLElectronico = new BLLQuestions();

                try
                {
                    Question oElectronico = new Question();

                    oElectronico.Id = this.txtId.Text;
                    oElectronico.Description = this.txtPrincipalQuestion.Text;
                    oElectronico.Question1 = this.txtOption1.Text;
                    oElectronico.Question2 = this.txtOption2.Text;
                    oElectronico.Question3 = this.txtOption3.Text;
                    oElectronico.Question4 = this.txtOption4.Text;
                    oElectronico.CorrectQuestion = this.txtCorrectOption.Text;


                    oElectronico = _IBLLElectronico.SaveQuestion(oElectronico);

                    MessageBox.Show("Question added with satisfaction.");
                    this.btnNew.Enabled = true;
                    CleanFields();
                    DesEnableFields();
                    this.CargarDatos();


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
        private void CargarDatos()
        {
            IBLLQuestions _IBLLQuestions = new BLLQuestions();
            this.dgvDatos.DataSource = _IBLLQuestions.GetAllQuestions();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
            this.button3.Enabled = true;
            this.button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question oCliente = null;   //important** Question NO Question*s*
           // CargarDatos();
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oCliente = this.dgvDatos.SelectedRows[0].DataBoundItem as Question;
                    this.txtId.Text = (oCliente.Id).ToString();
                    this.txtPrincipalQuestion.Text = oCliente.Description;
                    this.txtOption1.Text = oCliente.Question1;
                    this.txtOption2.Text = oCliente.Question2;
                    this.txtOption3.Text = oCliente.Question3;
                    this.txtOption4.Text = oCliente.Question4;
                    this.txtCorrectOption.Text = oCliente.CorrectQuestion;
                    EnableFields();
                    btnAdd.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanFields();
            btnAdd.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IBLLQuestions _BLLElectronico = new BLLQuestions();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {

                    Question oElectronicoBodegaDTO = this.dgvDatos.SelectedRows[0].DataBoundItem as Question;
                    if (MessageBox.Show($"¿Seguro que desea borrar numero de pregunta {oElectronicoBodegaDTO.Id} cuya pregunta es: {oElectronicoBodegaDTO.Description}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLElectronico.DeleteQuestion(oElectronicoBodegaDTO.Id.ToString());
                        this.CargarDatos();
                    }
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
        private void EnableFields()
        {
            txtId.Enabled = true;
            txtPrincipalQuestion.Enabled = true;
            txtOption1.Enabled = true;
            txtOption2.Enabled = true;
            txtOption3.Enabled = true;
            txtOption4.Enabled = true;
            txtCorrectOption.Enabled = true;
        }
        private void DesEnableFields()
        {
            txtId.Enabled = false;
            txtPrincipalQuestion.Enabled = false;
            txtOption1.Enabled = false;
            txtOption2.Enabled = false;
            txtOption3.Enabled = false;
            txtOption4.Enabled = false;
            txtCorrectOption.Enabled = false;
        }
        private void CleanFields()
        {
            txtId.Text = "";
            txtPrincipalQuestion.Text = "";
            txtOption1.Text = "";
            txtOption2.Text = "";
            txtOption3.Text = "";
            txtOption4.Text = "";
            txtCorrectOption.Text = "";
        }
        private void EnableButtons()
        {
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnAdd.Enabled = true;
            this.btnCancel.Enabled = true;
        }
    }
}
