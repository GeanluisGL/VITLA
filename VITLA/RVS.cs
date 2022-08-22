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
    public partial class RVS : Form
    {
        public RVS()
        {
            InitializeComponent();
        }

        E_RVS objE = new E_RVS();   
        N_RVS objN = new N_RVS();
        private bool Edit = false;
        public static int BuiI;
        string BuiII;
        
        #region C3
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void ImagU_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*,jpg| PNG files|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    ImagU.Text = imageLocation;
                }

            }
            catch (Exception) {

                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK);
            
            }

        }

        private void ContBtn_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {

                    objE.Nombrev = Form1.NameU;
                    objE.Apel = Form1.LastNa;
                    objE.Carrera = Form1.Career;
                    objE.Mail = Form1.Mail;
                    objE.Edif = Convert.ToInt32(BuiI);
                    objE.AulaR = CLrCbox.Text.ToString();
                    objE.Checkin = CheckInBtn.Value.TimeOfDay.ToString();
                    objE.Checout = CheckOut.Value.TimeOfDay.ToString();
                    objE.MotV = VsMotive.Text.ToString();
                    objE.PhVis = ImagU.Text.ToString();

                    objN.Creav(objE);

                    MessageBox.Show("Visit registered.");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Visit can't be registered" + ex);
                  

                }
            }

            PScreen ps = new PScreen();
                this.Hide();
                ps.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RVS_Load(object sender, EventArgs e)
        {
            loaderCB();
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

            #region try3
            //CLrCbox.DisplayMember = "NameC";
            //CLrCbox.ValueMember = "ID";
            //objE.Idc =  DepartCBox.SelectedIndex;
            //CLrCbox.DataSource = objN.ShowC(objE);
            #endregion 
        }
        private void loaderCB()
        {
            objE.PAction = "BI";
            objE.PId = null;
            DataTable dt = objN.ShowBNC(objE);
            if (dt.Rows.Count > 0)
            {
                DepartCBox.DisplayMember = "NameB";
                DepartCBox.ValueMember = "IDB";
                DepartCBox.DataSource = dt;
            } 

            #region try2
            //DepartCBox.DisplayMember = "Edificio";
            //DepartCBox.ValueMember = "ID";
            //DepartCBox.DataSource = objN.ShowBuill();
            //if (objN.dt.Rows.Count > 0)
            //{
            //}
            #endregion
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
    }
}
