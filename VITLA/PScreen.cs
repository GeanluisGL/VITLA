using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VITLA
{
    public partial class PScreen : Form
    {
        public PScreen()
        {
            InitializeComponent();
        }

        #region Form Funtion


        private void PScreen_Load(object sender, EventArgs e)
        {
            if (Form1.role == 1)
            {

                label1.Text = Form1.NameU + " " + Form1.LastNa;
                label2.Text = "Role: Admin";

                AuserBtn.Enabled = true;

            }

            else if (Form1.role == 0)
            {

                label1.Text = Form1.NameU + " " + Form1.LastNa;
                label2.Text = "Role: Invitado | Estudiante";
            }

            else if (Register_Screen.role == 0)
            {

                label1.Text = Register_Screen.NameU + " " + Register_Screen.LastNa;
                label2.Text = "Role: Invitado | Estudiante";


            }

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

        //Metodo para abrir formulario dentro de un panel
        private void AbrirForm<Miform>() where Miform : Form, new() {
            Form formulario; 
            //Busca en la coleccion el formulario 
            formulario = panel2.Controls.OfType<Miform>().FirstOrDefault();

            //Si el formulario /instancia no existe
            if (formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel2.Controls.Add(formulario);
                panel2.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
             
        }

        private void AvisBtn_Click_1(object sender, EventArgs e)
        {
            AbrirForm<RVS>();
        }

        private void VvisBtn_Click_1(object sender, EventArgs e)
        {
            AbrirForm<ViewVis>();
        }

        private void AuserBtn_Click_1(object sender, EventArgs e)
        {
          AbrirForm<Auser>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
