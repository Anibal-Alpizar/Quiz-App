
namespace Quiz_Application.UI.Principal.Report.Students
{
    partial class frmInformeStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MostrarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetStudents = new Quiz_Application.UI.Principal.Report.Students.DataSetStudents();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MostrarUsuariosTableAdapter = new Quiz_Application.UI.Principal.Report.Students.DataSetStudentsTableAdapters.MostrarUsuariosTableAdapter();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSendEmail = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStudents)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // MostrarUsuariosBindingSource
            // 
            this.MostrarUsuariosBindingSource.DataMember = "MostrarUsuarios";
            this.MostrarUsuariosBindingSource.DataSource = this.DataSetStudents;
            // 
            // DataSetStudents
            // 
            this.DataSetStudents.DataSetName = "DataSetStudents";
            this.DataSetStudents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.MostrarUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quiz_Application.UI.Principal.Report.Students.ImprimirStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 617);
            this.reportViewer1.TabIndex = 0;
            // 
            // MostrarUsuariosTableAdapter
            // 
            this.MostrarUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.AutoSize = false;
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSendEmail});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(800, 55);
            this.tspBarraSuperior.TabIndex = 76;
            this.tspBarraSuperior.Text = "toolStrip1";
            // 
            // toolStripBtnSendEmail
            // 
            this.toolStripBtnSendEmail.Image = global::Quiz_Application.Properties.Resources.EmailIco40px;
            this.toolStripBtnSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSendEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSendEmail.Name = "toolStripBtnSendEmail";
            this.toolStripBtnSendEmail.Size = new System.Drawing.Size(193, 52);
            this.toolStripBtnSendEmail.Text = "Save and Send to my email";
            this.toolStripBtnSendEmail.Click += new System.EventHandler(this.toolStripBtnSendEmail_Click);
            // 
            // frmInformeStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmInformeStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInformeStudents";
            this.Load += new System.EventHandler(this.frmInformeStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetStudents)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MostrarUsuariosBindingSource;
        private DataSetStudents DataSetStudents;
        private DataSetStudentsTableAdapters.MostrarUsuariosTableAdapter MostrarUsuariosTableAdapter;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSendEmail;
    }
}