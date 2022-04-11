using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Managment_System
{
    public partial class main_form : Form
    {
        public static int g;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse

          );
        public static string cre,t_debit;
        functions fn = new functions();
        string query;
        public main_form()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        
        private void main_form_Load(object sender, EventArgs e)
        {
            lbl_username.Text = log_in.user_name.ToUpper();
            load_daya();
            lbl_totall_money.Text = cre+".Rs";
            lbl_total_debit.Text = g.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            load_daya();
            //DataSet ds=fn.getData(query);
            //guna2DataGridView1.DataSource = ds.Tables[0];
            //string q = ds.Tables[0].ToString();
            
            //cre = guna2DataGridView1.Rows[0].Cells[0].Value.ToString();
            MessageBox.Show($"Your current Balance is {cre} .Rs");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 a = new Form1();
            a.Show();
        }

        

        
        public void load_daya()
        {
            query = "select o_credit from create_account where 	a_num ='" + log_in.iid + "'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            string q = ds.Tables[0].ToString();
            cre = guna2DataGridView1.Rows[0].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Transacttion_history a = new Transacttion_history();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            credit a = new credit();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            debit a = new debit();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_daya();
            
            MessageBox.Show($"Your current Balance is {cre} .Rs");
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 a = new Form1();
            //a.Show();
        }
        
    }
}
