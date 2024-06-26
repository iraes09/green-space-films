﻿namespace ProyectoGreenSpace
{
    partial class FrmPayInfo
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalApplied = new System.Windows.Forms.Label();
            this.TotalImportApplied = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountImport = new System.Windows.Forms.Label();
            this.lblTotalImport = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.nudSeat = new System.Windows.Forms.NumericUpDown();
            this.txtDiscounts = new System.Windows.Forms.TextBox();
            this.txtTypeHall = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtShedule = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.lblSeating = new System.Windows.Forms.Label();
            this.lblDiscounts = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblShedule = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTypeHall = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pctMovie = new System.Windows.Forms.PictureBox();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(603, 579);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 45);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Atrás";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(777, 579);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 45);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(958, 578);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(138, 45);
            this.btnPay.TabIndex = 51;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotalApplied
            // 
            this.lblTotalApplied.AutoSize = true;
            this.lblTotalApplied.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalApplied.Location = new System.Drawing.Point(773, 525);
            this.lblTotalApplied.Name = "lblTotalApplied";
            this.lblTotalApplied.Size = new System.Drawing.Size(182, 23);
            this.lblTotalApplied.TabIndex = 50;
            this.lblTotalApplied.Text = "TOTAL APLICADO:";
            // 
            // TotalImportApplied
            // 
            this.TotalImportApplied.AutoSize = true;
            this.TotalImportApplied.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalImportApplied.Location = new System.Drawing.Point(998, 525);
            this.TotalImportApplied.Name = "TotalImportApplied";
            this.TotalImportApplied.Size = new System.Drawing.Size(21, 23);
            this.TotalImportApplied.TabIndex = 49;
            this.TotalImportApplied.Text = "€";
            this.TotalImportApplied.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(816, 492);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(131, 23);
            this.lblDiscount.TabIndex = 48;
            this.lblDiscount.Text = "DESCUENTO:";
            // 
            // lblDiscountImport
            // 
            this.lblDiscountImport.AutoSize = true;
            this.lblDiscountImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountImport.Location = new System.Drawing.Point(998, 492);
            this.lblDiscountImport.Name = "lblDiscountImport";
            this.lblDiscountImport.Size = new System.Drawing.Size(21, 23);
            this.lblDiscountImport.TabIndex = 47;
            this.lblDiscountImport.Text = "€";
            this.lblDiscountImport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalImport
            // 
            this.lblTotalImport.AutoSize = true;
            this.lblTotalImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImport.Location = new System.Drawing.Point(998, 458);
            this.lblTotalImport.Name = "lblTotalImport";
            this.lblTotalImport.Size = new System.Drawing.Size(21, 23);
            this.lblTotalImport.TabIndex = 46;
            this.lblTotalImport.Text = "€";
            this.lblTotalImport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(816, 458);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 23);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "TOTAL:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.nudSeat);
            this.grpInfo.Controls.Add(this.txtDiscounts);
            this.grpInfo.Controls.Add(this.txtTypeHall);
            this.grpInfo.Controls.Add(this.textBox1);
            this.grpInfo.Controls.Add(this.txtShedule);
            this.grpInfo.Controls.Add(this.txtDuration);
            this.grpInfo.Controls.Add(this.txtTickets);
            this.grpInfo.Controls.Add(this.txtMovie);
            this.grpInfo.Controls.Add(this.lblSeating);
            this.grpInfo.Controls.Add(this.lblDiscounts);
            this.grpInfo.Controls.Add(this.lblTickets);
            this.grpInfo.Controls.Add(this.lblDuration);
            this.grpInfo.Controls.Add(this.lblShedule);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Controls.Add(this.lblTypeHall);
            this.grpInfo.Controls.Add(this.lblMovie);
            this.grpInfo.Controls.Add(this.lblTitle);
            this.grpInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(530, 36);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(631, 395);
            this.grpInfo.TabIndex = 44;
            this.grpInfo.TabStop = false;
            // 
            // nudSeat
            // 
            this.nudSeat.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSeat.Location = new System.Drawing.Point(485, 340);
            this.nudSeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeat.Name = "nudSeat";
            this.nudSeat.Size = new System.Drawing.Size(120, 36);
            this.nudSeat.TabIndex = 34;
            this.nudSeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDiscounts
            // 
            this.txtDiscounts.BackColor = System.Drawing.Color.White;
            this.txtDiscounts.Enabled = false;
            this.txtDiscounts.Location = new System.Drawing.Point(17, 333);
            this.txtDiscounts.Multiline = true;
            this.txtDiscounts.Name = "txtDiscounts";
            this.txtDiscounts.Size = new System.Drawing.Size(232, 43);
            this.txtDiscounts.TabIndex = 33;
            // 
            // txtTypeHall
            // 
            this.txtTypeHall.BackColor = System.Drawing.Color.White;
            this.txtTypeHall.Enabled = false;
            this.txtTypeHall.Location = new System.Drawing.Point(412, 108);
            this.txtTypeHall.Multiline = true;
            this.txtTypeHall.Name = "txtTypeHall";
            this.txtTypeHall.Size = new System.Drawing.Size(193, 43);
            this.txtTypeHall.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(17, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 43);
            this.textBox1.TabIndex = 31;
            // 
            // txtShedule
            // 
            this.txtShedule.BackColor = System.Drawing.Color.White;
            this.txtShedule.Enabled = false;
            this.txtShedule.Location = new System.Drawing.Point(235, 225);
            this.txtShedule.Multiline = true;
            this.txtShedule.Name = "txtShedule";
            this.txtShedule.Size = new System.Drawing.Size(93, 43);
            this.txtShedule.TabIndex = 30;
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(386, 221);
            this.txtDuration.Multiline = true;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(93, 43);
            this.txtDuration.TabIndex = 29;
            // 
            // txtTickets
            // 
            this.txtTickets.BackColor = System.Drawing.Color.White;
            this.txtTickets.Enabled = false;
            this.txtTickets.Location = new System.Drawing.Point(524, 221);
            this.txtTickets.Multiline = true;
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(81, 43);
            this.txtTickets.TabIndex = 28;
            // 
            // txtMovie
            // 
            this.txtMovie.BackColor = System.Drawing.Color.White;
            this.txtMovie.Enabled = false;
            this.txtMovie.Location = new System.Drawing.Point(17, 112);
            this.txtMovie.Multiline = true;
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(294, 43);
            this.txtMovie.TabIndex = 27;
            // 
            // lblSeating
            // 
            this.lblSeating.AutoSize = true;
            this.lblSeating.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeating.Location = new System.Drawing.Point(481, 307);
            this.lblSeating.Name = "lblSeating";
            this.lblSeating.Size = new System.Drawing.Size(99, 23);
            this.lblSeating.TabIndex = 26;
            this.lblSeating.Text = "BUTACAS";
            // 
            // lblDiscounts
            // 
            this.lblDiscounts.AutoSize = true;
            this.lblDiscounts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscounts.ForeColor = System.Drawing.Color.White;
            this.lblDiscounts.Location = new System.Drawing.Point(18, 307);
            this.lblDiscounts.Name = "lblDiscounts";
            this.lblDiscounts.Size = new System.Drawing.Size(133, 23);
            this.lblDiscounts.TabIndex = 25;
            this.lblDiscounts.Text = "DESCUENTOS";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.ForeColor = System.Drawing.Color.White;
            this.lblTickets.Location = new System.Drawing.Point(525, 195);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(80, 23);
            this.lblTickets.TabIndex = 24;
            this.lblTickets.Text = "TICKETS";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(372, 195);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(118, 23);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "DURACIÓN";
            // 
            // lblShedule
            // 
            this.lblShedule.AutoSize = true;
            this.lblShedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShedule.ForeColor = System.Drawing.Color.White;
            this.lblShedule.Location = new System.Drawing.Point(231, 199);
            this.lblShedule.Name = "lblShedule";
            this.lblShedule.Size = new System.Drawing.Size(103, 23);
            this.lblShedule.TabIndex = 22;
            this.lblShedule.Text = "HORARIO";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(23, 199);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 23);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "NOMBRE";
            // 
            // lblTypeHall
            // 
            this.lblTypeHall.AutoSize = true;
            this.lblTypeHall.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeHall.ForeColor = System.Drawing.Color.White;
            this.lblTypeHall.Location = new System.Drawing.Point(401, 82);
            this.lblTypeHall.Name = "lblTypeHall";
            this.lblTypeHall.Size = new System.Drawing.Size(137, 23);
            this.lblTypeHall.TabIndex = 20;
            this.lblTypeHall.Text = "TIPO DE SALA";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.ForeColor = System.Drawing.Color.White;
            this.lblMovie.Location = new System.Drawing.Point(18, 86);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(99, 23);
            this.lblMovie.TabIndex = 11;
            this.lblMovie.Text = "PELÍCULA";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(482, 34);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "ESTRENOS - PELÍCULAS MAYO 2024";
            // 
            // pctMovie
            // 
            this.pctMovie.Image = global::ProyectoGreenSpace.Properties.Resources.image_picture_icon_143003;
            this.pctMovie.Location = new System.Drawing.Point(45, 45);
            this.pctMovie.Name = "pctMovie";
            this.pctMovie.Size = new System.Drawing.Size(418, 561);
            this.pctMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMovie.TabIndex = 43;
            this.pctMovie.TabStop = false;
            // 
            // FrmPayInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 660);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotalApplied);
            this.Controls.Add(this.TotalImportApplied);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblDiscountImport);
            this.Controls.Add(this.lblTotalImport);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.pctMovie);
            this.Name = "FrmPayInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPayInfo";
            this.Load += new System.EventHandler(this.FrmPayInfo_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalApplied;
        private System.Windows.Forms.Label TotalImportApplied;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountImport;
        private System.Windows.Forms.Label lblTotalImport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtDiscounts;
        private System.Windows.Forms.TextBox txtTypeHall;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtShedule;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label lblSeating;
        private System.Windows.Forms.Label lblDiscounts;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblShedule;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTypeHall;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pctMovie;
        private System.Windows.Forms.NumericUpDown nudSeat;
    }
}