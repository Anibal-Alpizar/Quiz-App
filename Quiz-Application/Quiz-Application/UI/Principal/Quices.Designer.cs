
namespace Quiz_Application.UI.Principal
{
    partial class Quices
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rtb4 = new System.Windows.Forms.RichTextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dvgQuestionONLYADMIN = new System.Windows.Forms.DataGridView();
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rtb3 = new System.Windows.Forms.RichTextBox();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.rtbPregunta = new System.Windows.Forms.RichTextBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvgQuestionONLYADMIN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Image = global::Quiz_Application.Properties.Resources.Start40px;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(338, 120);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 46);
            this.btnStart.TabIndex = 72;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(298, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 71;
            this.label1.Text = "Good Luck";
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb4.Location = new System.Drawing.Point(36, 385);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(32, 24);
            this.rdb4.TabIndex = 70;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "-";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.Visible = false;
            // 
            // rtb4
            // 
            this.rtb4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb4.Location = new System.Drawing.Point(74, 387);
            this.rtb4.Name = "rtb4";
            this.rtb4.ReadOnly = true;
            this.rtb4.Size = new System.Drawing.Size(642, 24);
            this.rtb4.TabIndex = 69;
            this.rtb4.Text = "";
            this.rtb4.Visible = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.Location = new System.Drawing.Point(574, 513);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(142, 44);
            this.btnSiguiente.TabIndex = 68;
            this.btnSiguiente.Text = "Next";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dvgQuestionONLYADMIN
            // 
            this.dvgQuestionONLYADMIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgQuestionONLYADMIN.Location = new System.Drawing.Point(116, 50);
            this.dvgQuestionONLYADMIN.Name = "dvgQuestionONLYADMIN";
            this.dvgQuestionONLYADMIN.Size = new System.Drawing.Size(10, 10);
            this.dvgQuestionONLYADMIN.TabIndex = 67;
            this.dvgQuestionONLYADMIN.Visible = false;
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.AutoSize = true;
            this.lblTiempoTranscurrido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTiempoTranscurrido.Font = new System.Drawing.Font("Book Antiqua", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTranscurrido.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(679, 431);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(37, 43);
            this.lblTiempoTranscurrido.TabIndex = 66;
            this.lblTiempoTranscurrido.Text = "0";
            this.lblTiempoTranscurrido.Visible = false;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3.Location = new System.Drawing.Point(36, 263);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(32, 24);
            this.rdb3.TabIndex = 65;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "-";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.Visible = false;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb2.Location = new System.Drawing.Point(36, 308);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(32, 24);
            this.rdb2.TabIndex = 64;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "-";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.Visible = false;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.Location = new System.Drawing.Point(36, 343);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(32, 24);
            this.rdb1.TabIndex = 63;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "-";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.Visible = false;
            // 
            // rtb3
            // 
            this.rtb3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb3.Location = new System.Drawing.Point(74, 263);
            this.rtb3.Name = "rtb3";
            this.rtb3.ReadOnly = true;
            this.rtb3.Size = new System.Drawing.Size(642, 24);
            this.rtb3.TabIndex = 62;
            this.rtb3.Text = "";
            this.rtb3.Visible = false;
            // 
            // rtb2
            // 
            this.rtb2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb2.Location = new System.Drawing.Point(74, 308);
            this.rtb2.Name = "rtb2";
            this.rtb2.ReadOnly = true;
            this.rtb2.Size = new System.Drawing.Size(642, 24);
            this.rtb2.TabIndex = 61;
            this.rtb2.Text = "";
            this.rtb2.Visible = false;
            // 
            // rtb1
            // 
            this.rtb1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.Location = new System.Drawing.Point(74, 346);
            this.rtb1.Name = "rtb1";
            this.rtb1.ReadOnly = true;
            this.rtb1.Size = new System.Drawing.Size(642, 24);
            this.rtb1.TabIndex = 60;
            this.rtb1.Text = "";
            this.rtb1.Visible = false;
            // 
            // rtbPregunta
            // 
            this.rtbPregunta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPregunta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPregunta.Location = new System.Drawing.Point(74, 198);
            this.rtbPregunta.Name = "rtbPregunta";
            this.rtbPregunta.ReadOnly = true;
            this.rtbPregunta.Size = new System.Drawing.Size(642, 34);
            this.rtbPregunta.TabIndex = 59;
            this.rtbPregunta.Text = "";
            this.rtbPregunta.Visible = false;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Quices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(786, 611);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rtb4);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dvgQuestionONLYADMIN);
            this.Controls.Add(this.lblTiempoTranscurrido);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.rtb3);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.rtbPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quices";
            this.Text = "Quices";
            ((System.ComponentModel.ISupportInitialize)(this.dvgQuestionONLYADMIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RichTextBox rtb4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dvgQuestionONLYADMIN;
        private System.Windows.Forms.Label lblTiempoTranscurrido;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RichTextBox rtb3;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.RichTextBox rtbPregunta;
        private System.Windows.Forms.Timer tmr;
    }
}