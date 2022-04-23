
namespace Quiz_Application.UI.Principal.Report.Scores
{
    partial class frmInformeScores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MostrarCalificaionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetScores = new Quiz_Application.UI.Principal.Report.Scores.DataSetScores();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MostrarCalificaionesTableAdapter = new Quiz_Application.UI.Principal.Report.Scores.DataSetScoresTableAdapters.MostrarCalificaionesTableAdapter();
            this.tspBarraSuperior = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSendEmail = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarCalificaionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetScores)).BeginInit();
            this.tspBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // MostrarCalificaionesBindingSource
            // 
            this.MostrarCalificaionesBindingSource.DataMember = "MostrarCalificaiones";
            this.MostrarCalificaionesBindingSource.DataSource = this.DataSetScores;
            // 
            // DataSetScores
            // 
            this.DataSetScores.DataSetName = "DataSetScores";
            this.DataSetScores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MostrarCalificaionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quiz_Application.UI.Principal.Report.Scores.ImprimirScores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 618);
            this.reportViewer1.TabIndex = 0;
            // 
            // MostrarCalificaionesTableAdapter
            // 
            this.MostrarCalificaionesTableAdapter.ClearBeforeFill = true;
            // 
            // tspBarraSuperior
            // 
            this.tspBarraSuperior.AutoSize = false;
            this.tspBarraSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSendEmail});
            this.tspBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.tspBarraSuperior.Name = "tspBarraSuperior";
            this.tspBarraSuperior.Size = new System.Drawing.Size(800, 55);
            this.tspBarraSuperior.TabIndex = 75;
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
            // frmInformeScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.tspBarraSuperior);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmInformeScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInformeScores";
            this.Load += new System.EventHandler(this.frmInformeScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarCalificaionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetScores)).EndInit();
            this.tspBarraSuperior.ResumeLayout(false);
            this.tspBarraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MostrarCalificaionesBindingSource;
        private DataSetScores DataSetScores;
        private DataSetScoresTableAdapters.MostrarCalificaionesTableAdapter MostrarCalificaionesTableAdapter;
        private System.Windows.Forms.ToolStrip tspBarraSuperior;
        private System.Windows.Forms.ToolStripButton toolStripBtnSendEmail;
    }
}