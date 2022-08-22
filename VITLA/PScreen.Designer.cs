namespace VITLA
{
    partial class PScreen
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
            this.PanelControler = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AuserBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.VvisBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.AvisBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.PanelControler.SuspendLayout();
            this.gunaGradient2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControler
            // 
            this.PanelControler.Controls.Add(this.panel2);
            this.PanelControler.Controls.Add(this.gunaGradient2Panel1);
            this.PanelControler.Controls.Add(this.panel1);
            this.PanelControler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControler.Location = new System.Drawing.Point(0, 0);
            this.PanelControler.Name = "PanelControler";
            this.PanelControler.Size = new System.Drawing.Size(804, 427);
            this.PanelControler.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 394);
            this.panel2.TabIndex = 5;
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.label2);
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Lavender;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.DarkBlue;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(692, 33);
            this.gunaGradient2Panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.AuserBtn);
            this.panel1.Controls.Add(this.VvisBtn);
            this.panel1.Controls.Add(this.AvisBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(692, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 427);
            this.panel1.TabIndex = 3;
            // 
            // AuserBtn
            // 
            this.AuserBtn.AnimationHoverSpeed = 0.07F;
            this.AuserBtn.AnimationSpeed = 0.03F;
            this.AuserBtn.BackColor = System.Drawing.Color.Blue;
            this.AuserBtn.BaseColor1 = System.Drawing.Color.White;
            this.AuserBtn.BaseColor2 = System.Drawing.Color.DarkBlue;
            this.AuserBtn.BorderColor = System.Drawing.Color.Black;
            this.AuserBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AuserBtn.Enabled = false;
            this.AuserBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AuserBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AuserBtn.ForeColor = System.Drawing.Color.White;
            this.AuserBtn.Image = global::VITLA.Properties.Resources.AddU1;
            this.AuserBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AuserBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.AuserBtn.Location = new System.Drawing.Point(0, 196);
            this.AuserBtn.Name = "AuserBtn";
            this.AuserBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AuserBtn.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.AuserBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AuserBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AuserBtn.OnHoverImage = null;
            this.AuserBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AuserBtn.Size = new System.Drawing.Size(112, 57);
            this.AuserBtn.TabIndex = 2;
            this.AuserBtn.Click += new System.EventHandler(this.AuserBtn_Click_1);
            // 
            // VvisBtn
            // 
            this.VvisBtn.AnimationHoverSpeed = 0.07F;
            this.VvisBtn.AnimationSpeed = 0.03F;
            this.VvisBtn.BackColor = System.Drawing.Color.Blue;
            this.VvisBtn.BaseColor1 = System.Drawing.Color.White;
            this.VvisBtn.BaseColor2 = System.Drawing.Color.DarkBlue;
            this.VvisBtn.BorderColor = System.Drawing.Color.Black;
            this.VvisBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.VvisBtn.FocusedColor = System.Drawing.Color.Empty;
            this.VvisBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VvisBtn.ForeColor = System.Drawing.Color.White;
            this.VvisBtn.Image = global::VITLA.Properties.Resources.search;
            this.VvisBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VvisBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.VvisBtn.Location = new System.Drawing.Point(0, 133);
            this.VvisBtn.Name = "VvisBtn";
            this.VvisBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.VvisBtn.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.VvisBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.VvisBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.VvisBtn.OnHoverImage = null;
            this.VvisBtn.OnPressedColor = System.Drawing.Color.Black;
            this.VvisBtn.Size = new System.Drawing.Size(112, 57);
            this.VvisBtn.TabIndex = 1;
            this.VvisBtn.Click += new System.EventHandler(this.VvisBtn_Click_1);
            // 
            // AvisBtn
            // 
            this.AvisBtn.AnimationHoverSpeed = 0.07F;
            this.AvisBtn.AnimationSpeed = 0.03F;
            this.AvisBtn.BackColor = System.Drawing.Color.Blue;
            this.AvisBtn.BaseColor1 = System.Drawing.Color.White;
            this.AvisBtn.BaseColor2 = System.Drawing.Color.DarkBlue;
            this.AvisBtn.BorderColor = System.Drawing.Color.Black;
            this.AvisBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AvisBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AvisBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AvisBtn.ForeColor = System.Drawing.Color.White;
            this.AvisBtn.Image = global::VITLA.Properties.Resources.add;
            this.AvisBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AvisBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.AvisBtn.Location = new System.Drawing.Point(0, 70);
            this.AvisBtn.Name = "AvisBtn";
            this.AvisBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AvisBtn.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.AvisBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AvisBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AvisBtn.OnHoverImage = null;
            this.AvisBtn.OnPressedColor = System.Drawing.Color.Black;
            this.AvisBtn.Size = new System.Drawing.Size(112, 57);
            this.AvisBtn.TabIndex = 0;
            this.AvisBtn.Click += new System.EventHandler(this.AvisBtn_Click_1);
            // 
            // PScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 427);
            this.Controls.Add(this.PanelControler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PScreen";
            this.Load += new System.EventHandler(this.PScreen_Load);
            this.PanelControler.ResumeLayout(false);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelControler;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientButton AuserBtn;
        private Guna.UI.WinForms.GunaGradientButton VvisBtn;
        private Guna.UI.WinForms.GunaGradientButton AvisBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}