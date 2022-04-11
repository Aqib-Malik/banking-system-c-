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
    public partial class create_account : Form
    {

        functions fn = new functions();
        string query,query2;
        public static string ra;
        
        public create_account()
        {
            InitializeComponent();
        }

        private void create_account_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int randomNumder;
            Random randm = new Random();
            randomNumder = randm.Next();
            MessageBox.Show($"Your Acoount Number is {randomNumder}");
            ra = randomNumder.ToString();
            if ((txt_name.Text != "") && (txt_d_pin.Text != "") && (txt_o_credit.Text != ""))
            {
                query = "insert into create_account(name,o_credit,d_pin,a_num)values('" + txt_name.Text + "','" + txt_o_credit.Text + "','" + txt_d_pin.Text + "','" + ra + "')";
                //query = "insert into employee(employee_name,employee_address,employee_gender,employee_position,employee_phone,employee_education,employee_id)values('" + txt_emp_name.Text + "','" + txt_emp_address.Text + "','" + txt_emp_gender.Text + "','" + txt_emp_position.Text + "','" + txt_emp_phone.Text + "','" + txt_emp_education.Text + "','" + txt_emp_id.Text + "')";
                fn.setData(query);
                String l = "  ( Opening Credit Rs." + txt_o_credit.Text+")";
                string p = DateTime.Now.ToString();
                query2 = "insert into t_history(history,credit,a_num,t_credit)values('" + p + "','" + l + "','" + ra + "','" + txt_o_credit.Text + "')";// where t_history.a_num=create_account.a_num";
                fn.setData(query2);

                //load_data();
                //clearall();
                // MessageBox.Show(TEXT_DOP.Value.ToString());


            }
            else
            {
                MessageBox.Show("Incomplete Data", "Incomplete");
                //MessageBox.Show(TEXT_DOP.Value.ToString());
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 a = new Form1();
            //a.Show();
        }
    }
}
