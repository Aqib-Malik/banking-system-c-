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
    public partial class log_in : Form
    {
        public static string iid,d,user_name;
        functions fn = new functions();
        string query;

        public log_in()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_a_num.Text != "" && txt_a_num.Text != "" && txt_name.Text != "" && txt_pin.Text != "")
            {
                user_name = txt_name.Text;
                //MessageBox.Show(create_account.ra);
                query = "select * from create_account where name='" + txt_name.Text.Trim() + "' and 	a_num='" + txt_a_num.Text.Trim() + "' and 	d_pin='" + txt_pin.Text.Trim() + "'";
                fn.checkData(query);
                if (functions.g == true)
                {
                    query = "select a_num  from create_account where name='" + txt_name.Text.Trim() + "' and 	a_num='" + txt_a_num.Text.Trim() + "' and 	d_pin='" + txt_pin.Text.Trim() + "'";
                    DataSet ds = fn.getData(query);
                    guna2DataGridView1.DataSource = ds.Tables[0];
                    string q = ds.Tables[0].ToString();

                    iid = guna2DataGridView1.Rows[0].Cells[0].Value.ToString();
                    this.Hide();
                    
                    main_form a = new main_form();
                    a.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Incomlete Data");



        }
        }
        

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void log_in_Load(object sender, EventArgs e)
        {
            
        }
    }
}
