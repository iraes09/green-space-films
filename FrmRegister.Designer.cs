﻿namespace ProyectoGreenSpace
{
    partial class FrmRegister
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
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.lklblLogin = new System.Windows.Forms.LinkLabel();
            this.pibImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pibBritish = new System.Windows.Forms.PictureBox();
            this.pibSpanish = new System.Windows.Forms.PictureBox();
            this.grpRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBritish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibSpanish)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.lklblLogin);
            this.grpRegister.Controls.Add(this.pibImage);
            this.grpRegister.Controls.Add(this.btnUpload);
            this.grpRegister.Controls.Add(this.lblUsername);
            this.grpRegister.Controls.Add(this.btnRegister);
            this.grpRegister.Controls.Add(this.txtMail);
            this.grpRegister.Controls.Add(this.txtRepeat);
            this.grpRegister.Controls.Add(this.txtPassword);
            this.grpRegister.Controls.Add(this.txtUsername);
            this.grpRegister.Controls.Add(this.lblMail);
            this.grpRegister.Controls.Add(this.lblRepeat);
            this.grpRegister.Controls.Add(this.lblPassword);
            this.grpRegister.Location = new System.Drawing.Point(26, 26);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(532, 486);
            this.grpRegister.TabIndex = 27;
            this.grpRegister.TabStop = false;
            this.grpRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.grpRegister_Paint);
            // 
            // lklblLogin
            // 
            this.lklblLogin.AutoSize = true;
            this.lklblLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblLogin.Location = new System.Drawing.Point(59, 426);
            this.lklblLogin.Name = "lklblLogin";
            this.lklblLogin.Size = new System.Drawing.Size(363, 23);
            this.lklblLogin.TabIndex = 39;
            this.lklblLogin.TabStop = true;
            this.lklblLogin.Text = "¿Ya tienes una cuenta? Inicia sesión";
            this.lklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblLogin_LinkClicked);
            // 
            // pibImage
            // 
            this.pibImage.Location = new System.Drawing.Point(295, 64);
            this.pibImage.Name = "pibImage";
            this.pibImage.Size = new System.Drawing.Size(201, 228);
            this.pibImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImage.TabIndex = 36;
            this.pibImage.TabStop = false;
            this.pibImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pibImage_Paint);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(295, 298);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(201, 38);
            this.btnUpload.TabIndex = 37;
            this.btnUpload.Text = "Cargar foto";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(59, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 23);
            this.lblUsername.TabIndex = 35;
            this.lblUsername.Text = "Usuario";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(63, 366);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(433, 38);
            this.btnRegister.TabIndex = 34;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.btnRegister_Paint);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(63, 142);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(204, 32);
            this.txtMail.TabIndex = 29;
            this.toolTip1.SetToolTip(this.txtMail, "Introduce un correo electrónico.");
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtRepeat
            // 
            this.txtRepeat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeat.Location = new System.Drawing.Point(63, 304);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.PasswordChar = '*';
            this.txtRepeat.Size = new System.Drawing.Size(204, 32);
            this.txtRepeat.TabIndex = 33;
            this.toolTip1.SetToolTip(this.txtRepeat, "Introduce de nuevo la contraseña.");
            this.txtRepeat.Enter += new System.EventHandler(this.txtRepeat_Enter);
            this.txtRepeat.Leave += new System.EventHandler(this.txtRepeat_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(63, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(204, 32);
            this.txtPassword.TabIndex = 31;
            this.toolTip1.SetToolTip(this.txtPassword, "Introduce una contraseña.");
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(63, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(204, 32);
            this.txtUsername.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txtUsername, "Introduce un nombre de usuario.");
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(59, 116);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(194, 23);
            this.lblMail.TabIndex = 32;
            this.lblMail.Text = "Correo electrónico";
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeat.Location = new System.Drawing.Point(59, 269);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(199, 23);
            this.lblRepeat.TabIndex = 30;
            this.lblRepeat.Text = "Repetir Contraseña";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(59, 189);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(125, 23);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Contraseña";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pibBritish
            // 
            this.pibBritish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibBritish.Image = global::ProyectoGreenSpace.Properties.Resources.united_kingdom;
            this.pibBritish.Location = new System.Drawing.Point(655, 26);
            this.pibBritish.Name = "pibBritish";
            this.pibBritish.Size = new System.Drawing.Size(70, 60);
            this.pibBritish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibBritish.TabIndex = 30;
            this.pibBritish.TabStop = false;
            this.pibBritish.Click += new System.EventHandler(this.pibBritish_Click);
            // 
            // pibSpanish
            // 
            this.pibSpanish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibSpanish.Image = global::ProyectoGreenSpace.Properties.Resources.spain;
            this.pibSpanish.Location = new System.Drawing.Point(579, 26);
            this.pibSpanish.Name = "pibSpanish";
            this.pibSpanish.Size = new System.Drawing.Size(70, 60);
            this.pibSpanish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSpanish.TabIndex = 29;
            this.pibSpanish.TabStop = false;
            this.pibSpanish.Click += new System.EventHandler(this.pibSpanish_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 539);
            this.Controls.Add(this.pibBritish);
            this.Controls.Add(this.pibSpanish);
            this.Controls.Add(this.grpRegister);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GREEN SPACE FILMS";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBritish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibSpanish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.PictureBox pibImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel lklblLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pibBritish;
        private System.Windows.Forms.PictureBox pibSpanish;
    }
}