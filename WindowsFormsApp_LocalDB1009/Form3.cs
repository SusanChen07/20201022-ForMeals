using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //ADO.net元件

namespace WindowsFormsApp_LocalDB1009
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt帳號.ForeColor = Color.Gray;
            txt帳號.Text = "請輸入學號";
            txt密碼.ForeColor = Color.Gray;
            txt密碼.Text = "請輸入密碼";
            

        }

        private void txt密碼_MouseClick(object sender, MouseEventArgs e)
        {
            txt密碼.ForeColor = Color.FromArgb(46, 50, 65);
            txt密碼.Clear();
            txt密碼.UseSystemPasswordChar = true;
        }

        private void txt帳號_MouseClick(object sender, MouseEventArgs e)
        {
            txt帳號.ForeColor = Color.FromArgb(46, 50, 65);
            txt帳號.Clear();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            Globalval.帳號 = txt帳號.Text;
            Globalval.密碼 = txt密碼.Text;
            if(Globalval.帳號 == "" || Globalval.密碼 == "" || Globalval.帳號 == "請輸入學號" || Globalval.密碼 == "請輸入密碼")
            {
                MessageBox.Show("請輸入帳號及密碼");
            }

            SqlConnection con = new SqlConnection(Globalval.myDBConStr);
            con.Open();

            string tSQL = "select * from person where personno = @val1 and personpassword = @val2";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@val1", Globalval.帳號);
            cmd.Parameters.AddWithValue("@val2", Globalval.密碼);
            SqlDataReader reader = cmd.ExecuteReader();
            
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Globalval.logid = Convert.ToInt32(string.Format("{0}", reader["personid"]));
                    Globalval.logauth = Convert.ToInt32(string.Format("{0}", reader["pauthority"]));
                    Globalval.classID = Convert.ToInt32(reader["classid"]);
                                       
                }
                //隱藏視窗 叫出菜單
                this.Hide();
                Form1 form菜單 = new Form1();
                form菜單.ShowDialog();

            }
            else
            {
                MessageBox.Show("帳號或密碼是錯誤的");
                
            }
            reader.Close();
            con.Close();

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn修改密碼_Click(object sender, EventArgs e)
        {
            Globalval.帳號 = txt帳號.Text;
            Globalval.密碼 = txt密碼.Text;
            if (Globalval.帳號 == "" || Globalval.密碼 == "" || Globalval.帳號 == "請輸入學號" || Globalval.密碼 == "請輸入密碼")
            {
                MessageBox.Show("請輸入帳號及密碼");
            }

            SqlConnection con = new SqlConnection(Globalval.myDBConStr);
            con.Open();

            string tSQL = "select * from person where personno = @val1 and personpassword = @val2";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@val1", Globalval.帳號);
            cmd.Parameters.AddWithValue("@val2", Globalval.密碼);
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Globalval.logid = Convert.ToInt32(string.Format("{0}", reader["personid"]));
                    Globalval.classID = Convert.ToInt32(reader["classid"]);

                }
                //隱藏視窗 叫出菜單
                this.Hide();
                Form8 form密碼 = new Form8();
                form密碼.ShowDialog();

            }
            else
            {
                MessageBox.Show("帳號或密碼是錯誤的");

            }
            reader.Close();
            con.Close();
        }
    }
}
