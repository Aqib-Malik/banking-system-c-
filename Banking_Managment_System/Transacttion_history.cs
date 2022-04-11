using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Managment_System
{
    public partial class Transacttion_history : Form
    {
        
        functions fn = new functions();
        string query;
        public Transacttion_history()
        {
            InitializeComponent();
        }

        private void Transacttion_history_Load(object sender, EventArgs e)
        {
            load_data();
            //credit a = new credit();
            ////a.l;
            //label1.Text = label1.Text+credit.x;

            
        }
        public void load_data()
        {
            main_form b = new main_form();
            
            query = "select history,credit,debit,t_credit from t_history where a_num='" + log_in.iid + "'";
            b.load_daya();
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            
            string q = ds.Tables[0].ToString();
            //int t = guna2DataGridView1.RowCount;
            //string s="";
            //label6.Text = "0";
            //for (int i=0;i<t;i++)
            //{
                
            //    s =s+guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
            //    label6.Text=Convert.ToString(double.Parse(label6.Text)+ double.Parse(guna2DataGridView1.Rows[i].Cells[3].Value.ToString()));
            //}
            //string cre;
            //cre = guna2DataGridView1.Rows[0].Cells[0].Value.ToString();
           // MessageBox.Show($"Your current Balance is {cre} .Rs");
        }
        private void btn_credit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form c = new main_form();
            c.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
