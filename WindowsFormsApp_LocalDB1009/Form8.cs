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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            txt密碼1.UseSystemPasswordChar = true;
            txt密碼2.UseSystemPasswordChar = true;
        }

        private void btn修改密碼_Click(object sender, EventArgs e)
        {
            if (txt密碼1.Text == "" || txt密碼2.Text == "")
            {
                MessageBox.Show("請輸入兩次新密碼");
            }
            else if(txt密碼1.Text != txt密碼2.Text)
            {
                MessageBox.Show("兩次新密碼輸入不一致，請再重新輸入");
                txt密碼1.Text = "";
                txt密碼2.Text = "";
            }
            else
            {
                string PASSWORD = txt密碼1.Text;
                SqlConnection con = new SqlConnection(Globalval.myDBConStr);
                con.Open();

                string tSQL = "update person set personpassword = @val1 where personid = @val2";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", PASSWORD);
                cmd.Parameters.AddWithValue("@val2", Globalval.logid);
                int row = cmd.ExecuteNonQuery();
                if (row>0)
                {
                    MessageBox.Show("修改密碼成功，請重新登入");
                    //隱藏視窗 重新登入
                    this.Hide();
                    Form3 form登入 = new Form3();
                    form登入.ShowDialog();
                }
                else
                {
                    MessageBox.Show("修改失敗，請再重新試試看");
                }
                con.Close();
            }
        }
    }
}
