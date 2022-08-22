namespace VITLA
{
    partial class RVS
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
            this.CheckOut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.CheckInBtn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImagU = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CLrCbox = new Guna.UI.WinForms.GunaComboBox();
            this.DepartCBox = new Guna.UI.WinForms.GunaComboBox();
            this.VsMotive = new Guna.UI.WinForms.GunaTextBox();
            this.ContBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VITLA.Properties.Resources.BGItla;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 799);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CheckOut);
            this.panel2.Controls.Add(this.CheckInBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ImagU);
            this.panel2.Controls.Add(this.CLrCbox);
            this.panel2.Controls.Add(this.DepartCBox);
            this.panel2.Controls.Add(this.VsMotive);
            this.panel2.Controls.Add(this.ContBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(47, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 327);
            this.panel2.TabIndex = 0;
            // 
            // CheckOut
            // 
            this.CheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckOut.BorderRadius = 0;
            this.CheckOut.ForeColor = System.Drawing.Color.White;
            this.CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CheckOut.FormatCustom = null;
            this.CheckOut.Location = new System.Drawing.Point(439, 146);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(161, 36);
            this.CheckOut.TabIndex = 27;
            this.CheckOut.Value = new System.DateTime(2022, 8, 21, 3, 25, 30, 0);
            // 
            // CheckInBtn
            // 
            this.CheckInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckInBtn.BorderRadius = 0;
            this.CheckInBtn.ForeColor = System.Drawing.Color.White;
            this.CheckInBtn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CheckInBtn.FormatCustom = null;
            this.CheckInBtn.Location = new System.Drawing.Point(439, 92);
            this.CheckInBtn.Name = "CheckInBtn";
            this.CheckInBtn.Size = new System.Drawing.Size(161, 36);
            this.CheckInBtn.TabIndex = 26;
            this.CheckInBtn.Value = new System.DateTime(2022, 8, 21, 3, 25, 40, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(341, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Check Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(353, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Check In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(362, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 48);
            this.label2.TabIndex = 23;
            this.label2.Text = "Visitor \r\nimage";
            // 
            // ImagU
            // 
            this.ImagU.AnimationHoverSpeed = 0.07F;
            this.ImagU.AnimationSpeed = 0.03F;
            this.ImagU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ImagU.BaseColor = System.Drawing.Color.Maroon;
            this.ImagU.BorderColor = System.Drawing.Color.Black;
            this.ImagU.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ImagU.CheckedBorderColor = System.Drawing.Color.Black;
            this.ImagU.CheckedForeColor = System.Drawing.Color.White;
            this.ImagU.CheckedImage = global::VITLA.Properties.Resources.Login;
            this.ImagU.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ImagU.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImagU.FocusedColor = System.Drawing.Color.Empty;
            this.ImagU.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.ImagU.ForeColor = System.Drawing.Color.White;
            this.ImagU.Image = null;
            this.ImagU.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImagU.ImageSize = new System.Drawing.Size(20, 20);
            this.ImagU.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ImagU.Location = new System.Drawing.Point(439, 207);
            this.ImagU.Name = "ImagU";
            this.ImagU.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ImagU.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ImagU.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.ImagU.OnHoverImage = null;
            this.ImagU.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ImagU.OnPressedColor = System.Drawing.Color.Black;
            this.ImagU.Size = new System.Drawing.Size(161, 33);
            this.ImagU.TabIndex = 22;
            this.ImagU.Text = "Upload Image";
            this.ImagU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ImagU.Click += new System.EventHandler(this.ImagU_Click);
            // 
            // CLrCbox
            // 
            this.CLrCbox.BackColor = System.Drawing.Color.Transparent;
            this.CLrCbox.BaseColor = System.Drawing.Color.White;
            this.CLrCbox.BorderColor = System.Drawing.Color.Silver;
            this.CLrCbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CLrCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CLrCbox.FocusedColor = System.Drawing.Color.Empty;
            this.CLrCbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CLrCbox.ForeColor = System.Drawing.Color.Black;
            this.CLrCbox.FormattingEnabled = true;
            this.CLrCbox.Items.AddRange(new object[] {
            ""});
            this.CLrCbox.Location = new System.Drawing.Point(140, 146);
            this.CLrCbox.Name = "CLrCbox";
            this.CLrCbox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CLrCbox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CLrCbox.Size = new System.Drawing.Size(194, 26);
            this.CLrCbox.TabIndex = 21;
            // 
            // DepartCBox
            // 
            this.DepartCBox.BackColor = System.Drawing.Color.Transparent;
            this.DepartCBox.BaseColor = System.Drawing.Color.White;
            this.DepartCBox.BorderColor = System.Drawing.Color.Silver;
            this.DepartCBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DepartCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartCBox.FocusedColor = System.Drawing.Color.Empty;
            this.DepartCBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DepartCBox.ForeColor = System.Drawing.Color.Black;
            this.DepartCBox.FormattingEnabled = true;
            this.DepartCBox.Items.AddRange(new object[] {
            ""});
            this.DepartCBox.Location = new System.Drawing.Point(140, 94);
            this.DepartCBox.Name = "DepartCBox";
            this.DepartCBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DepartCBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.DepartCBox.Size = new System.Drawing.Size(194, 26);
            this.DepartCBox.TabIndex = 20;
            this.DepartCBox.SelectedIndexChanged += new System.EventHandler(this.DepartCBox_SelectedIndexChanged);
            // 
            // VsMotive
            // 
            this.VsMotive.BaseColor = System.Drawing.Color.White;
            this.VsMotive.BorderColor = System.Drawing.Color.Silver;
            this.VsMotive.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VsMotive.FocusedBaseColor = System.Drawing.Color.White;
            this.VsMotive.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.VsMotive.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.VsMotive.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VsMotive.Location = new System.Drawing.Point(140, 198);
            this.VsMotive.MultiLine = true;
            this.VsMotive.Name = "VsMotive";
            this.VsMotive.PasswordChar = '\0';
            this.VsMotive.Size = new System.Drawing.Size(194, 53);
            this.VsMotive.TabIndex = 14;
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
            this.ContBtn.LineColor = System.Drawing.Color.Navy;
            this.ContBtn.Location = new System.Drawing.Point(299, 272);
            this.ContBtn.Name = "ContBtn";
            this.ContBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ContBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ContBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ContBtn.OnHoverImage = null;
            this.ContBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ContBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ContBtn.Size = new System.Drawing.Size(98, 42);
            this.ContBtn.TabIndex = 13;
            this.ContBtn.Text = "Register";
            this.ContBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContBtn.Click += new System.EventHandler(this.ContBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(50, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 72);
            this.label6.TabIndex = 12;
            this.label6.Text = "Visit \r\nMotive\r\n\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Classroom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Building";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(257, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visit Register ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 394);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(692, 394);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(692, 394);
            this.Name = "RVS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Visita";
            this.Load += new System.EventHandler(this.RVS_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaComboBox DepartCBox;
        private Guna.UI.WinForms.GunaTextBox VsMotive;
        private Guna.UI.WinForms.GunaAdvenceButton ContBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox CLrCbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton ImagU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker CheckOut;
        private Bunifu.Framework.UI.BunifuDatepicker CheckInBtn;
    }
}