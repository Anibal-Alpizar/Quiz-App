
namespace Quiz_Application.UI.Principal
{
    partial class Pay
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
            this.btnCertificate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNameVisa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cardNameMasterCard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDolar = new System.Windows.Forms.DataGridView();
            this.lblPriceDolar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.imgQR = new System.Windows.Forms.PictureBox();
            this.tlpAgrupamiento = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.rdbContado = new System.Windows.Forms.RadioButton();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuizPrice = new System.Windows.Forms.TextBox();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDolar)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).BeginInit();
            this.tlpAgrupamiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCertificate
            // 
            this.btnCertificate.BackColor = System.Drawing.Color.White;
            this.btnCertificate.Enabled = false;
            this.btnCertificate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.btnCertificate.Location = new System.Drawing.Point(559, 261);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.Size = new System.Drawing.Size(75, 42);
            this.btnCertificate.TabIndex = 0;
            this.btnCertificate.Text = "Certificate";
            this.btnCertificate.UseVisualStyleBackColor = false;
            this.btnCertificate.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(48)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cardNameVisa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(29, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 137);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Quiz_Application.Properties.Resources.ChipCard30px;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(195, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(55, 48);
            this.panel5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "**** **** **** 8857\r\n";
            // 
            // cardNameVisa
            // 
            this.cardNameVisa.AutoSize = true;
            this.cardNameVisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNameVisa.ForeColor = System.Drawing.Color.White;
            this.cardNameVisa.Location = new System.Drawing.Point(22, 70);
            this.cardNameVisa.Name = "cardNameVisa";
            this.cardNameVisa.Size = new System.Drawing.Size(79, 16);
            this.cardNameVisa.TabIndex = 3;
            this.cardNameVisa.Text = "User-Name";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Quiz_Application.Properties.Resources.visaIco60px;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(25, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 38);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cardNameMasterCard);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(308, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 137);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Quiz_Application.Properties.Resources.ChipCard30px;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(190, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(55, 48);
            this.panel6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "**** **** **** 4352";
            // 
            // cardNameMasterCard
            // 
            this.cardNameMasterCard.AutoSize = true;
            this.cardNameMasterCard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNameMasterCard.ForeColor = System.Drawing.Color.White;
            this.cardNameMasterCard.Location = new System.Drawing.Point(22, 70);
            this.cardNameMasterCard.Name = "cardNameMasterCard";
            this.cardNameMasterCard.Size = new System.Drawing.Size(79, 16);
            this.cardNameMasterCard.TabIndex = 3;
            this.cardNameMasterCard.Text = "User-Name";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Quiz_Application.Properties.Resources.MastarCardIco60px;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(25, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(52, 38);
            this.panel4.TabIndex = 2;
            // 
            // dgvDolar
            // 
            this.dgvDolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDolar.Location = new System.Drawing.Point(11, 126);
            this.dgvDolar.Name = "dgvDolar";
            this.dgvDolar.Size = new System.Drawing.Size(10, 10);
            this.dgvDolar.TabIndex = 4;
            this.dgvDolar.Visible = false;
            // 
            // lblPriceDolar
            // 
            this.lblPriceDolar.AutoSize = true;
            this.lblPriceDolar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceDolar.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPriceDolar.Location = new System.Drawing.Point(132, 116);
            this.lblPriceDolar.Name = "lblPriceDolar";
            this.lblPriceDolar.Size = new System.Drawing.Size(110, 20);
            this.lblPriceDolar.TabIndex = 5;
            this.lblPriceDolar.Text = "0000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(3, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dollar price";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(950, 63);
            this.panel7.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 31);
            this.label11.TabIndex = 33;
            this.label11.Text = "Billing";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::Quiz_Application.Properties.Resources.Github60px1;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(899, 7);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(46, 53);
            this.panel10.TabIndex = 32;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::Quiz_Application.Properties.Resources.In60px;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(848, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(46, 53);
            this.panel9.TabIndex = 31;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(132, 139);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(192, 23);
            this.txtPay.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(369, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Pay Now";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quiz price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateQR);
            this.groupBox1.Controls.Add(this.imgQR);
            this.groupBox1.Controls.Add(this.tlpAgrupamiento);
            this.groupBox1.Controls.Add(this.btnCertificate);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(27, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 309);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay Now";
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.BackColor = System.Drawing.Color.White;
            this.btnGenerateQR.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateQR.Location = new System.Drawing.Point(450, 261);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(103, 42);
            this.btnGenerateQR.TabIndex = 14;
            this.btnGenerateQR.Text = "Generate QR";
            this.btnGenerateQR.UseVisualStyleBackColor = false;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // imgQR
            // 
            this.imgQR.Location = new System.Drawing.Point(649, 78);
            this.imgQR.Name = "imgQR";
            this.imgQR.Size = new System.Drawing.Size(256, 196);
            this.imgQR.TabIndex = 13;
            this.imgQR.TabStop = false;
            // 
            // tlpAgrupamiento
            // 
            this.tlpAgrupamiento.BackColor = System.Drawing.SystemColors.Control;
            this.tlpAgrupamiento.ColumnCount = 3;
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tlpAgrupamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 306F));
            this.tlpAgrupamiento.Controls.Add(this.txtPay, 1, 6);
            this.tlpAgrupamiento.Controls.Add(this.label6, 0, 5);
            this.tlpAgrupamiento.Controls.Add(this.label7, 0, 0);
            this.tlpAgrupamiento.Controls.Add(this.label9, 0, 2);
            this.tlpAgrupamiento.Controls.Add(this.txtCliente, 1, 4);
            this.tlpAgrupamiento.Controls.Add(this.rdbContado, 1, 1);
            this.tlpAgrupamiento.Controls.Add(this.cmbTarjeta, 1, 2);
            this.tlpAgrupamiento.Controls.Add(this.label10, 0, 1);
            this.tlpAgrupamiento.Controls.Add(this.txtQuizPrice, 1, 0);
            this.tlpAgrupamiento.Controls.Add(this.rdbCredito, 2, 1);
            this.tlpAgrupamiento.Controls.Add(this.label5, 0, 4);
            this.tlpAgrupamiento.Controls.Add(this.lblPriceDolar, 1, 5);
            this.tlpAgrupamiento.Controls.Add(this.label8, 0, 6);
            this.tlpAgrupamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpAgrupamiento.Location = new System.Drawing.Point(29, 78);
            this.tlpAgrupamiento.Name = "tlpAgrupamiento";
            this.tlpAgrupamiento.RowCount = 7;
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgrupamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgrupamiento.Size = new System.Drawing.Size(614, 173);
            this.tlpAgrupamiento.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Card";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(132, 90);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(192, 23);
            this.txtCliente.TabIndex = 3;
            // 
            // rdbContado
            // 
            this.rdbContado.AutoSize = true;
            this.rdbContado.Location = new System.Drawing.Point(132, 32);
            this.rdbContado.Name = "rdbContado";
            this.rdbContado.Size = new System.Drawing.Size(70, 21);
            this.rdbContado.TabIndex = 4;
            this.rdbContado.Text = "Debito";
            this.rdbContado.UseVisualStyleBackColor = true;
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(132, 59);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(192, 25);
            this.cmbTarjeta.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Payment type";
            // 
            // txtQuizPrice
            // 
            this.txtQuizPrice.Enabled = false;
            this.txtQuizPrice.Location = new System.Drawing.Point(132, 3);
            this.txtQuizPrice.Name = "txtQuizPrice";
            this.txtQuizPrice.ReadOnly = true;
            this.txtQuizPrice.Size = new System.Drawing.Size(200, 23);
            this.txtQuizPrice.TabIndex = 12;
            this.txtQuizPrice.Text = "$1000";
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Checked = true;
            this.rdbCredito.Location = new System.Drawing.Point(340, 32);
            this.rdbCredito.Name = "rdbCredito";
            this.tlpAgrupamiento.SetRowSpan(this.rdbCredito, 2);
            this.rdbCredito.Size = new System.Drawing.Size(75, 21);
            this.rdbCredito.TabIndex = 5;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(3, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Your pay";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(27, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 233);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My Cards";
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(950, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDolar);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDolar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgQR)).EndInit();
            this.tlpAgrupamiento.ResumeLayout(false);
            this.tlpAgrupamiento.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCertificate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cardNameVisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cardNameMasterCard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvDolar;
        private System.Windows.Forms.Label lblPriceDolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlpAgrupamiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.RadioButton rdbContado;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuizPrice;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgQR;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGenerateQR;
    }
}