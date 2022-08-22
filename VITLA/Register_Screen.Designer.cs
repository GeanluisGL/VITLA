namespace VITLA
{
    partial class Register_Screen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CarrerBox = new Guna.UI.WinForms.GunaComboBox();
            this.IdUserBox = new System.Windows.Forms.MaskedTextBox();
            this.LastNBox = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PwordBox = new Guna.UI.WinForms.GunaTextBox();
            this.ContBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Mailbox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Backbutton = new Guna.UI.WinForms.GunaButton();
            this.NameBox = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VITLA.Properties.Resources.BGItla;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-250, -275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 799);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CarrerBox);
            this.panel2.Controls.Add(this.IdUserBox);
            this.panel2.Controls.Add(this.LastNBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.PwordBox);
            this.panel2.Controls.Add(this.ContBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Mailbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Backbutton);
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(262, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 456);
            this.panel2.TabIndex = 0;
            // 
            // CarrerBox
            // 
            this.CarrerBox.BackColor = System.Drawing.Color.Transparent;
            this.CarrerBox.BaseColor = System.Drawing.Color.White;
            this.CarrerBox.BorderColor = System.Drawing.Color.Silver;
            this.CarrerBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CarrerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarrerBox.FocusedColor = System.Drawing.Color.Empty;
            this.CarrerBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CarrerBox.ForeColor = System.Drawing.Color.Black;
            this.CarrerBox.FormattingEnabled = true;
            this.CarrerBox.Items.AddRange(new object[] {
            "Simulaciones Interactivas y Videojuegos",
            "Telecomunicaciones",
            "Inteligencia Artificial",
            "Informatica Forense",
            "Energias Renovables",
            "Redes de Informacion",
            "Mecatronica",
            "Manufactura Automatizada",
            "Manufactura de Dispositivos Médicos",
            "Diseño Industrial",
            "Multimedia",
            "Sonido",
            "Desarrollo de software",
            "Analitica y ciencia de datos",
            "Seguridad Informatica",
            ""});
            this.CarrerBox.Location = new System.Drawing.Point(36, 233);
            this.CarrerBox.Name = "CarrerBox";
            this.CarrerBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CarrerBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CarrerBox.Size = new System.Drawing.Size(160, 26);
            this.CarrerBox.TabIndex = 20;
            this.CarrerBox.SelectedIndexChanged += new System.EventHandler(this.CarrerBox_SelectedIndexChanged);
            // 
            // IdUserBox
            // 
            this.IdUserBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.IdUserBox.Location = new System.Drawing.Point(36, 105);
            this.IdUserBox.Mask = "0000-0000";
            this.IdUserBox.Name = "IdUserBox";
            this.IdUserBox.Size = new System.Drawing.Size(135, 26);
            this.IdUserBox.TabIndex = 19;
            // 
            // LastNBox
            // 
            this.LastNBox.BaseColor = System.Drawing.Color.White;
            this.LastNBox.BorderColor = System.Drawing.Color.Silver;
            this.LastNBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNBox.FocusedBaseColor = System.Drawing.Color.White;
            this.LastNBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LastNBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.LastNBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.LastNBox.Location = new System.Drawing.Point(216, 171);
            this.LastNBox.Name = "LastNBox";
            this.LastNBox.PasswordChar = '\0';
            this.LastNBox.Size = new System.Drawing.Size(160, 30);
            this.LastNBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // PwordBox
            // 
            this.PwordBox.BaseColor = System.Drawing.Color.White;
            this.PwordBox.BorderColor = System.Drawing.Color.Silver;
            this.PwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PwordBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PwordBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PwordBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PwordBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwordBox.Location = new System.Drawing.Point(36, 296);
            this.PwordBox.Name = "PwordBox";
            this.PwordBox.PasswordChar = '●';
            this.PwordBox.Size = new System.Drawing.Size(340, 32);
            this.PwordBox.TabIndex = 14;
            this.PwordBox.TextChanged += new System.EventHandler(this.PwordBox_TextChanged);
            // 
            // ContBtn
            // 
            this.ContBtn.AnimationHoverSpeed = 0.07F;
            this.ContBtn.AnimationSpeed = 0.03F;
            this.ContBtn.BaseColor = System.Drawing.Color.Blue;
            this.ContBtn.BorderColor = System.Drawing.Color.Black;
            this.ContBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ContBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.ContBtn.CheckedForeColor = System.Drawing.Color.White;
            this.ContBtn.CheckedImage = global::VITLA.Properties.Resources.Login;
            this.ContBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ContBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ContBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ContBtn.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.ContBtn.ForeColor = System.Drawing.Color.White;
            this.ContBtn.Image = null;
            this.ContBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ContBtn.LineColor = System.Drawing.Color.Blue;
            this.ContBtn.Location = new System.Drawing.Point(157, 385);
            this.ContBtn.Name = "ContBtn";
            this.ContBtn.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.ContBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ContBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ContBtn.OnHoverImage = null;
            this.ContBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ContBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ContBtn.Size = new System.Drawing.Size(98, 42);
            this.ContBtn.TabIndex = 13;
            this.ContBtn.Text = "Continue";
            this.ContBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContBtn.Click += new System.EventHandler(this.ContBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(215, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mail";
            // 
            // Mailbox
            // 
            this.Mailbox.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.Mailbox.Location = new System.Drawing.Point(216, 233);
            this.Mailbox.Mask = "00000000@itla.edu.do";
            this.Mailbox.Name = "Mailbox";
            this.Mailbox.Size = new System.Drawing.Size(160, 26);
            this.Mailbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Career";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(215, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID/Matricula";
            // 
            // Backbutton
            // 
            this.Backbutton.AnimationHoverSpeed = 0.07F;
            this.Backbutton.AnimationSpeed = 0.03F;
            this.Backbutton.BaseColor = System.Drawing.Color.Transparent;
            this.Backbutton.BorderColor = System.Drawing.Color.Black;
            this.Backbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Backbutton.FocusedColor = System.Drawing.Color.Empty;
            this.Backbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Backbutton.ForeColor = System.Drawing.Color.White;
            this.Backbutton.Image = global::VITLA.Properties.Resources.logout;
            this.Backbutton.ImageSize = new System.Drawing.Size(30, 30);
            this.Backbutton.Location = new System.Drawing.Point(334, 20);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.Backbutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Backbutton.OnHoverForeColor = System.Drawing.Color.White;
            this.Backbutton.OnHoverImage = null;
            this.Backbutton.OnPressedColor = System.Drawing.Color.Black;
            this.Backbutton.Size = new System.Drawing.Size(42, 42);
            this.Backbutton.TabIndex = 4;
            this.Backbutton.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // NameBox
            // 
            this.NameBox.BaseColor = System.Drawing.Color.White;
            this.NameBox.BorderColor = System.Drawing.Color.Silver;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.FocusedBaseColor = System.Drawing.Color.White;
            this.NameBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.NameBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.NameBox.Location = new System.Drawing.Point(36, 168);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.Size = new System.Drawing.Size(160, 31);
            this.NameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // Register_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 501);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 540);
            this.MinimumSize = new System.Drawing.Size(458, 540);
            this.Name = "Register_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_Screen";
            this.Load += new System.EventHandler(this.Register_Screen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox NameBox;
        private Guna.UI.WinForms.GunaButton Backbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Mailbox;
        private Guna.UI.WinForms.GunaAdvenceButton ContBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox PwordBox;
        private Guna.UI.WinForms.GunaTextBox LastNBox;
        private System.Windows.Forms.MaskedTextBox IdUserBox;
        private Guna.UI.WinForms.GunaComboBox CarrerBox;
    }
}