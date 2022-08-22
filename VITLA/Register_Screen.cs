using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELayer;
using NLayer;

namespace VITLA
{
    public partial class Register_Screen : Form
    {
        public Register_Screen()
        {
            InitializeComponent();
        }

        public static int role;
        public static string UserID; 
        public static string NameU;
        public static string LastNa;
        public static string Career;
        public static string Mail;

        private bool Edit = false;
        string careerb;
        N_Register objN = new N_Register();
        E_Register objE = new E_Register();

        E_Login Eobj = new E_Login();
        N_Login Nobj = new N_Login();

        #region Utility
        private void gunaButton1_Click(object sender, EventArgs e)
        {

            Form1 lv = new Form1();
            this.Hide();
            lv.Show();
        }

        private void MatriculaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Carrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void MailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Screen_Load(object sender, EventArgs e)
        {
            CarrerBox.SelectedIndex = -1;
        }

        private void PwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void ContBtn_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {

                try
                {


                    objE.MatricID = IdUserBox.Text;
                    objE.NameU = NameBox.Text;
                    objE.LastNa = LastNBox.Text;
                    objE.Career = careerb;
                    objE.Mail = Mailbox.Text;
                    objE.Pword = PwordBox.Text;
                    objE.UserRole = role = 0;
                    UserID = IdUserBox.Text;

                    NameU = objE.NameU;
                    LastNa = objE.LastNa;
                  
                    objN.Ncreate(objE);
                    MessageBox.Show("Bienvenido a VSITLA");

                    PScreen ps = new PScreen();
                    ps.Show();
                    this.Hide();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar correctamente. " + ex);

    }
                }
                

            }

        private void CarrerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            careerb = CarrerBox.Text.ToString();
        }
    }
    }
