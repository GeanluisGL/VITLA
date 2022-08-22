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
        int BuiI;
        int builO;
        bool Edit = false;
        string nameU = Form1.NameU;
        int rol = Form1.role;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewVis_Load(object sender, EventArgs e)
        {
            //Yo solo ensillo caballo porque pa burro no hay montura...El que me quite esa hembra tiene la muerte segura

          
                viewV(Form1.role, Form1.NameU);


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
            BuiI = DepartCBox.SelectedIndex;

            if (BuiI == 0)
            {
                loaderC1();
            }
            else if (BuiI == 1)
            {
                loaderC2();
            }
            else if (BuiI == 2)
            {
                loaderC3();
            }
            else if (BuiI == 3)
            {
                loaderC4();
            }
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
                VsMotive.Text = dataGridView1.CurrentRow.Cells["Motivo_Visita"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }


        private void loaderC1()
        {

            CLrCbox.Items.Clear();
            CLrCbox.Items.Add("A10");
            CLrCbox.Items.Add("A11");
            CLrCbox.Items.Add("A12");
            CLrCbox.Items.Add("A13");
            CLrCbox.Items.Add("A14");
            CLrCbox.Items.Add("A15");


        }


        private void loaderC2()
        {

            CLrCbox.Items.Clear();
            CLrCbox.Items.Add("B20");
            CLrCbox.Items.Add("B21");
            CLrCbox.Items.Add("B22");
            CLrCbox.Items.Add("B23");
            CLrCbox.Items.Add("B24");
            CLrCbox.Items.Add("B25");

        }

        private void loaderC3()
        {
            CLrCbox.Items.Clear();
            CLrCbox.Items.Add("C30");
            CLrCbox.Items.Add("C31");
            CLrCbox.Items.Add("C32");
            CLrCbox.Items.Add("C33");
            CLrCbox.Items.Add("C34");
            CLrCbox.Items.Add("C35");


        }

        private void loaderC4()
        {

            CLrCbox.Items.Clear();
            CLrCbox.Items.Add("D40");
            CLrCbox.Items.Add("D41");
            CLrCbox.Items.Add("D42");
            CLrCbox.Items.Add("D43");
            CLrCbox.Items.Add("D44");
            CLrCbox.Items.Add("D45");

        }

        private void DeletU_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar la visita seleccionado?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    objE.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    objN.Delet(objE);
                    MessageBox.Show("Registro eliminado");
                    objN.Showlist();

                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }
            private void ContBtn_Click(object sender, EventArgs e)
            {
                if (Edit == true)
                {
                    try
                    {
                        objE.ID = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                        objE.Nombre_Visitante = dataGridView1.CurrentRow.Cells["Nombre_Visitante"].Value.ToString();
                        objE.Apellido = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                        objE.Carrera = dataGridView1.CurrentRow.Cells["Carrera"].Value.ToString();
                        objE.Correo = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                        objE.Id_Edificio = DepartCBox.SelectedIndex;
                        objE.Aula = CLrCbox.Text;
                        objE.Check_in = CheckInBtn.Value.ToString();
                        objE.Check_out = CheckOut.Value.ToString();
                        objE.Motivo_Visita = VsMotive.Text.ToString();
                        objE.Foto_Visita = "";

                        objN.Updatte(objE);

                        MessageBox.Show("Registro guardado.");


                        objN.Showlist();
                        Edit = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro." + ex);
                    }
                }
            }
        }
    }
