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
    public partial class Auser : Form
    {

        bool Edit = false;
        N_Auser objN = new N_Auser();
        E_Auser objE = new E_Auser();


        public Auser()
        {
            InitializeComponent();
        }

        private void ContBtn_Click(object sender, EventArgs e)
        {
            if (Edit == true)
            {
                try
                {
                    objE.Name = NameBox.Text.ToUpper();
                    objE.Last_Name = LastNBox.Text.ToUpper();
                    objE.Career= CareerBoxU.Text.ToUpper();
                    objE.Mail = MailBox.Text.ToUpper();
                    objE.Rol_Id = UserRolebO.SelectedIndex;
                    objE.Id = IdUserBox.Text.ToString();
                   
                    objN.UppdateA(objE);

                    MessageBox.Show("Registro guardado.");
                    limpiar();
                  
                    Edit = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro." + ex);
                }
            }
        }

        #region C1
        private void IdUserBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void IdUserBox_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region C2 
        private void Auser_Load(object sender, EventArgs e)
        {
            LoadDgv(NameBox.Text);
        }


        private void NameBox_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            LoadDgv(NameBox.Text);

        }
        #endregion

        private void Editbt_Click(object sender, EventArgs e)
        {
         

            if (DataUs.SelectedRows.Count > 0)
            {
                Edit = true;
                IdUserBox.Text = DataUs.CurrentRow.Cells["Id"].Value.ToString();
                IdUserBox.Enabled = false;
                NameBox.Text = DataUs.CurrentRow.Cells["Name"].Value.ToString();
                LastNBox.Text = DataUs.CurrentRow.Cells["Last_Name"].Value.ToString();
                CareerBoxU.Text = DataUs.CurrentRow.Cells["Career"].Value.ToString();
                MailBox.Text = DataUs.CurrentRow.Cells["Mail"].Value.ToString();
                UserRolebO.SelectedIndex = (int)DataUs.CurrentRow.Cells["Rol_Id"].Value;


            }
            else {
                MessageBox.Show("Selecciona una fila");
            }

        }

        public void limpiar()
        {

            NameBox.Text = "";
            LastNBox.Text = "";
            CareerBoxU.Text = "";
            MailBox.Text = "";
            UserRolebO.SelectedIndex = -1; 


        }
       
        private void LoadDgv(string name)
        {
            N_Auser objNeg = new N_Auser();
            DataUs.DataSource = objNeg.viewEU(name);
        }


        #region C3
        private void DataUs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void DeletU_Click(object sender, EventArgs e)
        {
            if (DataUs.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar el usuario seleccionado?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    objE.Id = DataUs.CurrentRow.Cells[0].Value.ToString();
                    objN.DeleterA(objE);
                    MessageBox.Show("Registro eliminado");

                    objN.Showlist();
                    
                }
                else if (dialogResult == DialogResult.No)
                { 
                    
                }

            }
        }
    }
}
