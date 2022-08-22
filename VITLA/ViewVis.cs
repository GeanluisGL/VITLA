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
    public partial class ViewVis : Form
    {
        public ViewVis()
        {
            InitializeComponent();
        }

        N_ViewVis objN = new N_ViewVis();
        E_ViewVis objE = new E_ViewVis();
        int builO;
        bool Edit = false;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewVis_Load(object sender, EventArgs e)
        {
            //Yo solo ensillo caballo porque pa burro no hay montura...El que me quite esa hembra tiene la muerte segura

            if (Form1.role == 0)
            {
                
                viewV(builO, Form1.NameU);
                loaderCB();
            }
            else if (Form1.role == 1)
            {

               
                viewA(builO);
                loaderCB();

            }

        }

        public void loaderCB()
        {

        }


            

            public void viewV(int name, string user)
        {
            N_ViewVis objNegocio = new N_ViewVis();
            dataGridView1.DataSource = objNegocio.ListaEa(name, user);
        }

        public void viewA(int name)
        {
            N_ViewVis objNegocio = new N_ViewVis();
            dataGridView1.DataSource = objNegocio.Listaa(name);
        }

        private void DepartCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            builO = DepartCBox.SelectedIndex;
        }

        private void Editbt_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Edit = true;
                objE.ID = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                objE.Nombre_Visitante = dataGridView1.CurrentRow.Cells["Nombre_Visitante"].Value.ToString();
                objE.Apellido = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                objE.Carrera = dataGridView1.CurrentRow.Cells["Carrera"].Value.ToString();
                objE.Correo = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                DepartCBox.SelectedIndex = (int)dataGridView1.CurrentRow.Cells["Id_Edificio"].Value;
                string checkI = dataGridView1.CurrentRow.Cells["Check_in"].Value.ToString();
                CheckInBtn.Value = Convert.ToDateTime(checkI);
                string checkO = dataGridView1.CurrentRow.Cells["Check_out"].Value.ToString();
                CheckOut.Value = Convert.ToDateTime(CheckOut);
                VsMotive.Text = dataGridView1.CurrentRow.Cells["Motivo_Visita"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }
    }   
}
