using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLayer;
using ELayer;

namespace VITLA
{
    public partial class Form1 : Form
    {

       E_Login Eobj = new E_Login();
       N_Login Nobj = new N_Login();

        public static string userM;
        public static int role;
        public static string NameU;
        public static string LastNa;
        public static string Career;
        public static string Mail;

        PScreen frm1 = new PScreen();

        public Form1()
        {
            InitializeComponent();
        }

        //Login Method
        void Loger()
        { 
            DataTable dt = new DataTable();
            Eobj.User = Username.Text;
            Eobj.Password = PassWbox.Text;

            dt = Nobj.N_Log(Eobj);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Bienvenido " + dt.Rows[0][3].ToString(), "Mensaje", MessageBoxButtons.OK);
                userM = dt.Rows[0][0].ToString();
                role = Convert.ToInt32(dt.Rows[0][2]);
                NameU = dt.Rows[0][3].ToString();
                LastNa = dt.Rows[0][4].ToString();
                Career = dt.Rows[0][5].ToString();
                Mail = dt.Rows[0][6].ToString();

                frm1.ShowDialog();

                Form1 login = new Form1();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    Application.Run(new PScreen());

                    Username.Clear();
                    PassWbox.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #region Utility
        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_Screen RS  = new Register_Screen();
            this.Hide();
            RS.Show();
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion




        private void LogBtn_Click(object sender, EventArgs e)
        {

            Loger();        

        }
    }
}
