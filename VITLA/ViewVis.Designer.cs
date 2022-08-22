namespace VITLA
{
    partial class ViewVis
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeletU = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.VsMotive = new Guna.UI.WinForms.GunaTextBox();
            this.CLrCbox = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartCBox = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImagU = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Editbt = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CheckOut = new System.Windows.Forms.DateTimePicker();
            this.CheckInBtn = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 394);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::VITLA.Properties.Resources.BGItla;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(-13, -222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 799);
            this.panel3.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CheckInBtn);
            this.panel2.Controls.Add(this.CheckOut);
            this.panel2.Controls.Add(this.Editbt);
            this.panel2.Controls.Add(this.DeletU);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.ContBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.VsMotive);
            this.panel2.Controls.Add(this.CLrCbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DepartCBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ImagU);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(55, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 327);
            this.panel2.TabIndex = 40;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.DeletU.Location = new System.Drawing.Point(488, 275);
            this.DeletU.Name = "DeletU";
            this.DeletU.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.DeletU.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeletU.OnHoverForeColor = System.Drawing.Color.White;
            this.DeletU.OnHoverImage = null;
            this.DeletU.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeletU.OnPressedColor = System.Drawing.Color.Black;
            this.DeletU.Size = new System.Drawing.Size(78, 30);
            this.DeletU.TabIndex = 41;
            this.DeletU.Text = "Delete";
            this.DeletU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(267, 213);
            this.dataGridView1.TabIndex = 40;
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
            this.ContBtn.Location = new System.Drawing.Point(405, 275);
            this.ContBtn.Name = "ContBtn";
            this.ContBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ContBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ContBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ContBtn.OnHoverImage = null;
            this.ContBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ContBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ContBtn.Size = new System.Drawing.Size(78, 30);
            this.ContBtn.TabIndex = 38;
            this.ContBtn.Text = "Continue";
            this.ContBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "Visit Register ";
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
            this.VsMotive.Location = new System.Drawing.Point(405, 79);
            this.VsMotive.MultiLine = true;
            this.VsMotive.Name = "VsMotive";
            this.VsMotive.PasswordChar = '\0';
            this.VsMotive.Size = new System.Drawing.Size(194, 53);
            this.VsMotive.TabIndex = 29;
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
            this.CLrCbox.Location = new System.Drawing.Point(405, 52);
            this.CLrCbox.Name = "CLrCbox";
            this.CLrCbox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CLrCbox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CLrCbox.Size = new System.Drawing.Size(194, 26);
            this.CLrCbox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(319, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Building";
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
            "Mecatronica | Edificio 1",
            "Multimedia | Edificio 2",
            "Software | Edificio 3 ",
            "Oficinas | Edificio 4 "});
            this.DepartCBox.Location = new System.Drawing.Point(405, 20);
            this.DepartCBox.Name = "DepartCBox";
            this.DepartCBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DepartCBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.DepartCBox.Size = new System.Drawing.Size(194, 26);
            this.DepartCBox.TabIndex = 30;
            this.DepartCBox.SelectedIndexChanged += new System.EventHandler(this.DepartCBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(307, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Check Out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(319, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Check In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 48);
            this.label2.TabIndex = 33;
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
            this.ImagU.Location = new System.Drawing.Point(405, 228);
            this.ImagU.Name = "ImagU";
            this.ImagU.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ImagU.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ImagU.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.ImagU.OnHoverImage = null;
            this.ImagU.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ImagU.OnPressedColor = System.Drawing.Color.Black;
            this.ImagU.Size = new System.Drawing.Size(161, 32);
            this.ImagU.TabIndex = 32;
            this.ImagU.Text = "Upload Image";
            this.ImagU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(290, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Visit motive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(304, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Classroom";
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
            this.Editbt.Location = new System.Drawing.Point(92, 275);
            this.Editbt.Name = "Editbt";
            this.Editbt.OnHoverBaseColor = System.Drawing.Color.OliveDrab;
            this.Editbt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Editbt.OnHoverForeColor = System.Drawing.Color.LightGray;
            this.Editbt.OnHoverImage = null;
            this.Editbt.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Editbt.OnPressedColor = System.Drawing.Color.Black;
            this.Editbt.Size = new System.Drawing.Size(98, 33);
            this.Editbt.TabIndex = 42;
            this.Editbt.Text = "Editar";
            this.Editbt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Editbt.Click += new System.EventHandler(this.Editbt_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CheckOut.Location = new System.Drawing.Point(419, 187);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(161, 27);
            this.CheckOut.TabIndex = 43;
            // 
            // CheckInBtn
            // 
            this.CheckInBtn.Font = new System.Drawing.Font("Sitka Small", 12F);
            this.CheckInBtn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CheckInBtn.Location = new System.Drawing.Point(419, 150);
            this.CheckInBtn.Name = "CheckInBtn";
            this.CheckInBtn.Size = new System.Drawing.Size(161, 27);
            this.CheckInBtn.TabIndex = 44;
            // 
            // ViewVis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 394);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewVis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewVis";
            this.Load += new System.EventHandler(this.ViewVis_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox CLrCbox;
        private Guna.UI.WinForms.GunaComboBox DepartCBox;
        private Guna.UI.WinForms.GunaTextBox VsMotive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton ImagU;
        private Guna.UI.WinForms.GunaAdvenceButton ContBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaAdvenceButton DeletU;
        private Guna.UI.WinForms.GunaAdvenceButton Editbt;
        private System.Windows.Forms.DateTimePicker CheckInBtn;
        private System.Windows.Forms.DateTimePicker CheckOut;
    }
}