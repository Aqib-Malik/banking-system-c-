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
    public partial class credit : Form
    {
        public int l = 0;
        main_form b = new main_form();
        public static string x,p;
        functions fn = new functions();
        string query;
        public credit()
        {
            InitializeComponent();
        }

        private void credit_Load(object sender, EventArgs e)
        {

        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            l++;
            try
            {
                b.load_daya();
                if (txt_credit.Text != "")
                {
                    int add = int.Parse(txt_credit.Text) + int.Parse(main_form.cre);

                    query = "update create_account set o_credit	='" + add.ToString() + "' where a_num  = '" + log_in.iid + "'";
                    //x = x+DateTime.Now.ToString() + "\n";
                    //for (int k = 0; k < l; k++)
                    //{
                    //    x =x+ DateTime.Now.ToString()+"\n";
                    //}
                    fn.setData(query);
                    b.load_daya();
                    p = DateTime.Now.ToString();
                    query = "insert into t_history(history,credit,a_num,t_credit)values('" + p + "','" + "(Credit Balance Rs." + txt_credit.Text + ")" + "','" + log_in.iid + "','" + main_form.cre + "')";
                    //query = "insert into t_history(history,a_num)values('" + p + "','" + log_in.iid + "')";
                    fn.setData(query);
                    this.Hide();
                    main_form c = new main_form();
                    c.Show();

                }
                else
                {
                    MessageBox.Show("Please choose atleast one item", "select");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void load_data()
        {
            //query = "select o_credit from create_account where b_id='" + log_in.iid + "'";
            //DataSet ds = fn.getData(query);
            //guna2DataGridView1.DataSource = ds.Tables[0];
            //string q = ds.Tables[0].ToString();
            //string cre;
            //cre = guna2DataGridView1.Rows[0].Cells[0].Value.ToString();
            //MessageBox.Show($"Your current Balance is {cre} .Rs");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void txt_credit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
