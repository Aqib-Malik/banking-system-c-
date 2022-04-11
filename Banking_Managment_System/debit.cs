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
    public partial class debit : Form
    {
        public static int g;
        main_form b = new main_form();
        functions fn = new functions();
        String query;
        public static int j,z;
        public static string p;
        public debit()
        {
            InitializeComponent();
        }

        private void debit_Load(object sender, EventArgs e)
        {
            
    }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            
            try
            {
                b.load_daya();
                if (txt_credit.Text != "" && int.Parse(txt_credit.Text) <= int.Parse(main_form.cre))
                {

                   
                   main_form.g=main_form.g+int.Parse(txt_credit.Text);
                    MessageBox.Show(main_form.g.ToString());
                    
                   // int i= int.Parse(txt_credit.Text) + int.Parse(main_form.t_debit);
                   // //main_form.t_debit = i.ToString();
                   //main_form.t_debit = j.ToString();
                    int add = int.Parse(main_form.cre) - int.Parse(txt_credit.Text);

                    query = "update create_account set o_credit	='" + add.ToString() + "' where a_num  = '" + log_in.iid + "'";// "  where employee_id='" + at + "'";

                    fn.setData(query);
                    b.load_daya();
                    string p = DateTime.Now.ToString();
                    //query = "insert into t_history(history)values('" + p + "')";
                    query = "insert into t_history(history,debit,a_num,t_credit)values('" + p + "','" +"(Debit Balance Rs."+ txt_credit.Text +")"+ "','" + log_in.iid + "','" + main_form.cre + "')";// where t_history.a_num=create_account.a_num using(a_num)";
                    fn.setData(query);
                    this.Hide();
                    main_form c = new main_form();
                    c.Show();


                }
                else
                {
                    MessageBox.Show("Some thing not valid", "Invalid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
