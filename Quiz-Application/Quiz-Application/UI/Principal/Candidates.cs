using log4net;
using Newtonsoft.Json;
using Quiz_Application.Clases;
using Quiz_Application.Interfaces;
using Quiz_Application.Layers.BLL;
using Quiz_Application.Layers.Entities;
using Quiz_Application.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class Candidates : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public Candidates()
        {
            InitializeComponent();
        }

        private void Candidates_Load(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnEdit.Enabled = false;

            string jsonDatos = "";
            jsonDatos = File.ReadAllText(@"../../JSON/countries.json");
            List<CountriesJSON> listaJson = JsonConvert.DeserializeObject<List<CountriesJSON>>(jsonDatos);
            cbmAdrress.Items.Insert(0, "Select your country");
            cbmAdrress.SelectedIndex = 0;
            foreach (var item in listaJson)
            {
                //  cmbCountries.Items.Add(item.name.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtAge.Text)
                || string.IsNullOrEmpty(this.txtPassword.Text)
                || string.IsNullOrEmpty(this.txtPhone.Text))
            {
                MessageBox.Show("Information is missing");
                Reset();
            }
            else
            {
                IBLLCandidates _IBLLElectronico = new BLLCandidates();

                try
                {
                    Candidate oCandidate = new Candidate();

                    oCandidate.Id = this.txtId.Text;
                    oCandidate.Name = this.txtName.Text;
                    oCandidate.Age = int.Parse(this.txtAge.Text);
                    oCandidate.Password = this.txtPassword.Text;
                    oCandidate.Add = this.cbmAdrress.Text;
                    oCandidate.Phone = this.txtPhone.Text;

                    oCandidate = _IBLLElectronico.SaveCandidate(oCandidate);

                    MessageBox.Show("Candidate added with satisfaction.");
                    this.btnNew.Enabled = true;
                    DesActivate();
                    Reset();
                    DesEnabledCrudButtons();
                    this.CargarDatos();
                    this.btnDelete.Enabled = true;
                    this.btnEdit.Enabled = true;
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
        private void EnabledCrudButtons()
        {
            this.btnAdd.Enabled = true;
            this.btnDelete.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnCancel.Enabled = true;
        }
        private void DesEnabledCrudButtons()
        {
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnCancel.Enabled = false;
        }
        private void Reset()
        {
            this.txtName.Text = "";
            this.txtAge.Text = "";
            this.txtPassword.Text = "";
            this.txtPhone.Text = "";
        }
        private void Activate()
        {
            this.txtName.Enabled = true;
            this.txtAge.Enabled = true;
            this.txtPassword.Enabled = true;
            this.txtPhone.Enabled = true;
            this.cbmAdrress.Enabled = true;
        }
        private void DesActivate()
        {
            this.txtName.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtPassword.Enabled = false;
            this.txtPhone.Enabled = false;
            this.cbmAdrress.Enabled = false;
        }
        private void CargarDatos()
        {
            IBLLCandidates _IBLLCandidate = new BLLCandidates();
            this.dgvDatos.DataSource = _IBLLCandidate.GetAllCandidates();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnabledCrudButtons();
            Activate();
            LoadJson();
            CleanAll();
            CargarDatos();
            this.btnDelete.Enabled = true;
            this.btnEdit.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
            this.btnDelete.Enabled = true;
            this.btnEdit.Enabled = true;
        }
        private void EnableFields()
        {
            this.txtName.Enabled = true;
            this.txtAge.Enabled = true;
            this.cbmAdrress.Enabled = true;
            this.txtPassword.Enabled = true;
            this.txtPhone.Enabled = true;
        }

            
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            Candidate oCandidate = null;
            EnableFields();
            this.btnAdd.Enabled = true;
            LoadJson();
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    oCandidate = this.dgvDatos.SelectedRows[0].DataBoundItem as Candidate;

                    this.txtId.Text = (oCandidate.Id).ToString();
                    this.txtName.Text = oCandidate.Name.ToString();
                    this.txtAge.Text = oCandidate.Age.ToString();

                    this.txtPassword.Text = oCandidate.Password.ToString();
                    this.txtPhone.Text = oCandidate.Phone.ToString();

                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.btnEdit.Enabled = true;
                    this.btnDelete.Enabled = true;
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IBLLCandidates _IBLLCandidate = new BLLCandidates();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {

                    Candidate oElectronicoBodegaDTO = this.dgvDatos.SelectedRows[0].DataBoundItem as Candidate;
                    if (MessageBox.Show($"¿Seguro que desea borrar al usuario {oElectronicoBodegaDTO.Name}con identificacion de: {oElectronicoBodegaDTO.Id}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _IBLLCandidate.DeleteCandidate(oElectronicoBodegaDTO.Id.ToString());
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
        private void LoadJson()
        {
            string jsonDatos = "";
            jsonDatos = File.ReadAllText(@"../../JSON/countries.json");
            List<CountriesJSON> listaJson = JsonConvert.DeserializeObject<List<CountriesJSON>>(jsonDatos);
            cbmAdrress.Items.Insert(0, "Select your country");
            cbmAdrress.SelectedIndex = 0;
            foreach (var item in listaJson)
            {
                cbmAdrress.Items.Add(item.name.ToString());
            }
        }
        private void CleanAll()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
        }
    }
}
