namespace VITLA
{
    partial class Auser
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new Guna.UI.WinForms.GunaTextBox();
            this.LastNBox = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserRolebO = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdUserBox = new Guna.UI.WinForms.GunaTextBox();
            this.DataUs = new System.Windows.Forms.DataGridView();
            this.MailBox = new Guna.UI.WinForms.GunaTextBox();
            this.CareerBoxU = new Guna.UI.WinForms.GunaTextBox();
            this.Editbt = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DeletU = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataUs)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(296, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Career";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(296, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(296, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID/Matricula";
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
            this.NameBox.Location = new System.Drawing.Point(291, 128);
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.Size = new System.Drawing.Size(160, 31);
            this.NameBox.TabIndex = 21;
            this.NameBox.TabStopChanged += new System.EventHandler(this.NameBox_TabStopChanged);
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
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
            this.LastNBox.Location = new System.Drawing.Point(463, 131);
            this.LastNBox.Name = "LastNBox";
            this.LastNBox.PasswordChar = '\0';
            this.LastNBox.Size = new System.Drawing.Size(160, 30);
            this.LastNBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(462, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(462, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last Name";
            // 
            // UserRolebO
            // 
            this.UserRolebO.BackColor = System.Drawing.Color.Transparent;
            this.UserRolebO.BaseColor = System.Drawing.Color.White;
            this.UserRolebO.BorderColor = System.Drawing.Color.Silver;
            this.UserRolebO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UserRolebO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserRolebO.FocusedColor = System.Drawing.Color.Empty;
            this.UserRolebO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserRolebO.ForeColor = System.Drawing.Color.Black;
            this.UserRolebO.FormattingEnabled = true;
            this.UserRolebO.Items.AddRange(new object[] {
            "Invitado",
            "Administrador"});
            this.UserRolebO.Location = new System.Drawing.Point(464, 65);
            this.UserRolebO.Name = "UserRolebO";
            this.UserRolebO.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserRolebO.OnHoverItemForeColor = System.Drawing.Color.White;
            this.UserRolebO.Size = new System.Drawing.Size(160, 26);
            this.UserRolebO.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(469, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "User Role ";
            // 
            // ContBtn
            // 
            this.ContBtn.AnimationHoverSpeed = 0.07F;
            this.ContBtn.AnimationSpeed = 0.03F;
            this.ContBtn.BaseColor = System.Drawing.Color.Blue;
            this.ContBtn.BorderColor = System.Drawing.Color.Black;
            this.ContBtn.CheckedBaseColor = System.Drawing.Color.Navy;
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
            this.ContBtn.Location = new System.Drawing.Point(507, 301);
            this.ContBtn.Name = "ContBtn";
            this.ContBtn.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue;
            this.ContBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ContBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ContBtn.OnHoverImage = null;
            this.ContBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ContBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ContBtn.Size = new System.Drawing.Size(98, 42);
            this.ContBtn.TabIndex = 33;
            this.ContBtn.Text = "Continue";
            this.ContBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContBtn.Click += new System.EventHandler(this.ContBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(71, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "User editor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IdUserBox);
            this.panel1.Controls.Add(this.DataUs);
            this.panel1.Controls.Add(this.MailBox);
            this.panel1.Controls.Add(this.CareerBoxU);
            this.panel1.Controls.Add(this.Editbt);
            this.panel1.Controls.Add(this.DeletU);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ContBtn);
            this.panel1.Controls.Add(this.UserRolebO);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LastNBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(34, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 360);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // IdUserBox
            // 
            this.IdUserBox.BaseColor = System.Drawing.Color.White;
            this.IdUserBox.BorderColor = System.Drawing.Color.Silver;
            this.IdUserBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdUserBox.FocusedBaseColor = System.Drawing.Color.White;
            this.IdUserBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.IdUserBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.IdUserBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.IdUserBox.Location = new System.Drawing.Point(291, 61);
            this.IdUserBox.Name = "IdUserBox";
            this.IdUserBox.PasswordChar = '\0';
            this.IdUserBox.Size = new System.Drawing.Size(160, 31);
            this.IdUserBox.TabIndex = 40;
            // 
            // DataUs
            // 
            this.DataUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUs.Location = new System.Drawing.Point(3, 40);
            this.DataUs.Name = "DataUs";
            this.DataUs.Size = new System.Drawing.Size(282, 255);
            this.DataUs.TabIndex = 39;
            this.DataUs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUs_CellContentClick);
            // 
            // MailBox
            // 
            this.MailBox.BaseColor = System.Drawing.Color.White;
            this.MailBox.BorderColor = System.Drawing.Color.Silver;
            this.MailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MailBox.FocusedBaseColor = System.Drawing.Color.White;
            this.MailBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MailBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.MailBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.MailBox.Location = new System.Drawing.Point(463, 195);
            this.MailBox.Name = "MailBox";
            this.MailBox.PasswordChar = '\0';
            this.MailBox.Size = new System.Drawing.Size(160, 30);
            this.MailBox.TabIndex = 38;
            // 
            // CareerBoxU
            // 
            this.CareerBoxU.BaseColor = System.Drawing.Color.White;
            this.CareerBoxU.BorderColor = System.Drawing.Color.Silver;
            this.CareerBoxU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CareerBoxU.FocusedBaseColor = System.Drawing.Color.White;
            this.CareerBoxU.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CareerBoxU.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.CareerBoxU.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.CareerBoxU.Location = new System.Drawing.Point(291, 195);
            this.CareerBoxU.Name = "CareerBoxU";
            this.CareerBoxU.PasswordChar = '\0';
            this.CareerBoxU.Size = new System.Drawing.Size(160, 30);
            this.CareerBoxU.TabIndex = 37;
            // 
            // Editbt
            // 
            this.Editbt.AnimationHoverSpeed = 0.07F;
            this.Editbt.AnimationSpeed = 0.03F;
            this.Editbt.BaseColor = System.Drawing.Color.Green;
            this.Editbt.BorderColor = System.Drawing.Color.Black;
            this.Editbt.CheckedBaseColor = System.Drawing.Color.Chartreuse;
            this.Editbt.CheckedBorderColor = System.Drawing.Color.Black;
            this.Editbt.CheckedForeColor = System.Drawing.Color.White;
            this.Editbt.CheckedImage = global::VITLA.Properties.Resources.Login;
            this.Editbt.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Editbt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Editbt.FocusedColor = System.Drawing.Color.Empty;
            this.Editbt.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.Editbt.ForeColor = System.Drawing.Color.White;
            this.Editbt.Image = null;
            this.Editbt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Editbt.ImageSize = new System.Drawing.Size(20, 20);
            this.Editbt.LineColor = System.Drawing.Color.Blue;
            this.Editbt.Location = new System.Drawing.Point(91, 301);
            this.Editbt.Name = "Editbt";
            this.Editbt.OnHoverBaseColor = System.Drawing.Color.OliveDrab;
            this.Editbt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Editbt.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.Editbt.OnHoverImage = null;
            this.Editbt.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Editbt.OnPressedColor = System.Drawing.Color.Black;
            this.Editbt.Size = new System.Drawing.Size(98, 42);
            this.Editbt.TabIndex = 36;
            this.Editbt.Text = "Editar";
            this.Editbt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Editbt.Click += new System.EventHandler(this.Editbt_Click);
            // 
            // DeletU
            // 
            this.DeletU.AnimationHoverSpeed = 0.07F;
            this.DeletU.AnimationSpeed = 0.03F;
            this.DeletU.BaseColor = System.Drawing.Color.Red;
            this.DeletU.BorderColor = System.Drawing.Color.Black;
            this.DeletU.CheckedBaseColor = System.Drawing.Color.Crimson;
            this.DeletU.CheckedBorderColor = System.Drawing.Color.Black;
            this.DeletU.CheckedForeColor = System.Drawing.Color.White;
            this.DeletU.CheckedImage = global::VITLA.Properties.Resources.Login;
            this.DeletU.CheckedLineColor = System.Drawing.Color.DimGray;
            this.DeletU.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeletU.FocusedColor = System.Drawing.Color.Empty;
            this.DeletU.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.DeletU.ForeColor = System.Drawing.Color.White;
            this.DeletU.Image = null;
            this.DeletU.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeletU.ImageSize = new System.Drawing.Size(20, 20);
            this.DeletU.LineColor = System.Drawing.Color.Crimson;
            this.DeletU.Location = new System.Drawing.Point(392, 301);
            this.DeletU.Name = "DeletU";
            this.DeletU.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.DeletU.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeletU.OnHoverForeColor = System.Drawing.Color.White;
            this.DeletU.OnHoverImage = null;
            this.DeletU.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeletU.OnPressedColor = System.Drawing.Color.Black;
            this.DeletU.Size = new System.Drawing.Size(98, 42);
            this.DeletU.TabIndex = 35;
            this.DeletU.Text = "Delete";
            this.DeletU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeletU.Click += new System.EventHandler(this.DeletU_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::VITLA.Properties.Resources.BGItla;
            this.panel2.Location = new System.Drawing.Point(-5, -202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 799);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Auser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Auser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataUs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox NameBox;
        private Guna.UI.WinForms.GunaTextBox LastNBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox UserRolebO;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton ContBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton DeletU;
        private Guna.UI.WinForms.GunaAdvenceButton Editbt;
        private Guna.UI.WinForms.GunaTextBox CareerBoxU;
        private Guna.UI.WinForms.GunaTextBox MailBox;
        private System.Windows.Forms.DataGridView DataUs;
        private Guna.UI.WinForms.GunaTextBox IdUserBox;
    }
}