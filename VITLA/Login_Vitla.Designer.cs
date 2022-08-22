namespace VITLA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LogBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PassWbox = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VITLA.Properties.Resources.BGItla;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-250, -250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 799);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Username);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.LogBtn);
            this.panel2.Controls.Add(this.PassWbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(262, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 291);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(39, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Username.Location = new System.Drawing.Point(36, 101);
            this.Username.Mask = "0000-0000";
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(259, 26);
            this.Username.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(225)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(38, 228);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(225)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LogBtn
            // 
            this.LogBtn.AnimationHoverSpeed = 0.07F;
            this.LogBtn.AnimationSpeed = 0.03F;
            this.LogBtn.BaseColor = System.Drawing.Color.Blue;
            this.LogBtn.BorderColor = System.Drawing.Color.Black;
            this.LogBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.LogBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.LogBtn.CheckedForeColor = System.Drawing.Color.White;
            this.LogBtn.CheckedImage = global::VITLA.Properties.Resources.Login;
            this.LogBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.LogBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LogBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LogBtn.ForeColor = System.Drawing.Color.White;
            this.LogBtn.Image = global::VITLA.Properties.Resources.Login;
            this.LogBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LogBtn.LineColor = System.Drawing.Color.DarkCyan;
            this.LogBtn.Location = new System.Drawing.Point(197, 217);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.OnHoverBaseColor = System.Drawing.Color.MidnightBlue;
            this.LogBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LogBtn.OnHoverImage = null;
            this.LogBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.LogBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LogBtn.Size = new System.Drawing.Size(98, 42);
            this.LogBtn.TabIndex = 3;
            this.LogBtn.Text = "Login";
            this.LogBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // PassWbox
            // 
            this.PassWbox.BaseColor = System.Drawing.Color.White;
            this.PassWbox.BorderColor = System.Drawing.Color.Silver;
            this.PassWbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassWbox.FocusedBaseColor = System.Drawing.Color.White;
            this.PassWbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PassWbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PassWbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PassWbox.Location = new System.Drawing.Point(36, 167);
            this.PassWbox.Name = "PassWbox";
            this.PassWbox.PasswordChar = '●';
            this.PassWbox.Size = new System.Drawing.Size(259, 30);
            this.PassWbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 356);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 395);
            this.MinimumSize = new System.Drawing.Size(385, 395);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox PassWbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton LogBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Username;
    }
}

