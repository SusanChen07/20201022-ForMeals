using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace WindowsFormsApp_LocalDB1009
{
    public partial class Form5 : Form
    {
        int 班級id;
        int 學號;
        string 密碼;
        string 學生;
        string 班級 = "";
        string myDBConnectionString = @"Data Source=.;Initial Catalog=mealdb;Integrated Security=True";
        List<string> list班級 = new List<string>();
        List<int> list班級id = new List<int>();
        List<string> listLbox學生 = new List<string>();
        List<int> list學生no = new List<int>();
        List<string> list學生 = new List<string>();
        List<string> list密碼 = new List<string>();
        public Form5()
        {
            InitializeComponent();
            //panside效果
            panSide.Height = btn新增班級.Height;
            panSide.Top = btn新增班級.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            載入班級();
            cbox班級.SelectedIndex = 0;
            載入學生();
        }

        void 載入班級()
        {
            //先清空
            list班級.Clear();
            list班級id.Clear();
            cbox班級.Items.Clear();
            txt班級.Text = "";

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from class";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list班級.Add((string)reader["classname"]);
                list班級id.Add((int)reader["classid"]);
            }
            foreach (string i in list班級)
            {
                cbox班級.Items.Add(i);
            }
            reader.Close();
            con.Close();

        }
        void 載入學生()
        {
            lbox學生.Items.Clear();
            listLbox學生.Clear();
            list學生no.Clear();
            list學生.Clear();
            list密碼.Clear();
            班級id = list班級id[cbox班級.SelectedIndex];

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from person where classid = @val1";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@val1", (int)班級id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strstudent = string.Format("{0}\t     {1}\t", (int)reader["personno"], (string)reader["personname"]);
                list學生no.Add((int)reader["personno"]);
                list學生.Add((string)reader["personname"]);
                list密碼.Add((string)reader["personpassword"]);
                listLbox學生.Add(strstudent);
                
            }
            foreach (string i in listLbox學生)
            {
                lbox學生.Items.Add(i);
            }
            reader.Close();
            con.Close();
        }
        void 刪除學生()
        {
            DialogResult R = MessageBox.Show("確定要刪除此學生?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (R == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                學號 = Convert.ToInt32(txt學號.Text);
                //檢查學號非空
                if (txt學號.Text == "")
                {
                    MessageBox.Show("請選擇要刪除的學生");
                }
                else
                {
                    string SQL = @"delete person where personno = @val1";
                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@val1", 學號);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("刪除成功");
                    }
                    else
                    {
                        MessageBox.Show("此學號不存在");
                    }
                }
                con.Close();
                載入學生();
                清空();

            }
            else
            {//取消刪除
                MessageBox.Show("已取消刪除");
            }
        }
        void 清空()
        {
            txt學生.Text = "";
            txt學號.Text = "";
            txt密碼.Text = "";
        }

        private void btn新增班級_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn新增班級.Height;
            panSide.Top = btn新增班級.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            txt班級.Text = "";
            txt學生.Text = "";
            txt學號.Text = "";
            txt密碼.Text = "";
            lbox學生.Items.Clear();


        }

        private void btn儲存班級_Click(object sender, EventArgs e)
        {
            ////panside效果
            panSide.Height = btn儲存班級.Height;
            panSide.Top = btn儲存班級.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            //儲存班級
            班級 = txt班級.Text;
            Console.WriteLine(班級);
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //檢查班級非null
            if (txt班級.Text == "")
            {
                MessageBox.Show("請輸入要新增的班級名稱");
            }
            else
            {
                //檢查班級是否已存在
                string cSQL = "select * from class where classname = @checkName";
                SqlCommand cmd = new SqlCommand(cSQL, con);
                cmd.Parameters.AddWithValue("@checkName", (string)班級);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("此班級已存在");
                    reader.Close();
                }
                else
                {
                    reader.Close();

                    string iSQL = @"INSERT into class values (@val1)";
                    SqlCommand icmd = new SqlCommand(iSQL, con);
                    icmd.Parameters.AddWithValue("@val1", (string)班級);
                    icmd.ExecuteNonQuery();
                    MessageBox.Show("新增班級成功");

                }
            }
            con.Close();
            載入班級();

        }

        private void btn修改班級_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn修改班級.Height;
            panSide.Top = btn修改班級.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //檢查店家非空
            if (cbox班級.SelectedItem == null)
            {
                MessageBox.Show("請選擇要修改的班級");
            }
            else
            {
                if (班級id > 0)
                {
                    string iSQL = @"update class set classname = @val1 where classid = @val2";
                    SqlCommand cmd = new SqlCommand(iSQL, con);
                    cmd.Parameters.AddWithValue("@val1", (string)txt班級.Text);
                    cmd.Parameters.AddWithValue("@val2", (int)班級id);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                        MessageBox.Show("修改班級成功");
                }
                else
                {
                    MessageBox.Show("此班級名稱不存在");
                }
            }
            con.Close();
            載入班級();
            清空();
            lbox學生.Items.Clear();

        }

        private void btn刪除班級_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn刪除班級.Height;
            panSide.Top = btn刪除班級.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            班級id = list班級id[cbox班級.SelectedIndex];
            DialogResult R = MessageBox.Show("確定要刪除此班級?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (R == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                //檢查班級非空
                if (txt班級.Text == "")
                {
                    MessageBox.Show("請選擇要刪除的班級");
                }
                else
                {
                    string iSQL = @"delete class where classid = @val1";
                    SqlCommand icmd = new SqlCommand(iSQL, con);
                    icmd.Parameters.AddWithValue("@val1", 班級id);
                    int irow = icmd.ExecuteNonQuery();
                    if (irow > 0)
                    {

                        MessageBox.Show("刪除班級成功，將一併刪除此班級之學生資料");
                        string SQL = @"delete person where classid = @val1";
                        SqlCommand cmd = new SqlCommand(SQL, con);
                        cmd.Parameters.AddWithValue("@val1", 班級id);
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("此班級之學生資料刪除完畢");
                            lbox學生.Items.Clear();
                          
                        }

                    }
                    else
                    {
                        MessageBox.Show("此班級名稱不存在");
                    }
                }
                con.Close();
                載入班級();
                
                
            }
            else
            {//取消刪除
                MessageBox.Show("已取消刪除班級");
            }
        }

        private void btn新增學生_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn新增學生.Height;
            panSide.Top = btn新增學生.Top;
            panSide.BackColor = Color.FromArgb(238, 108, 77);

            if (txt班級.Text != "")
            {
                txt學生.Text = "";
                txt學號.Text = "";
                txt密碼.Text = "1234";
            }
            else
            {
                MessageBox.Show("請選擇要新增學生的班級");
            }
        }

        private void btn儲存學生_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn儲存學生.Height;
            panSide.Top = btn儲存學生.Top;
            panSide.BackColor = Color.FromArgb(238, 108, 77);

            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //檢查班級非null
            if (txt班級.Text == "")
            {
                MessageBox.Show("請選擇要新增學生的班級");
            }
            else if (txt學生.Text == "" || txt學號.Text == "" || txt密碼.Text == "")
            {
                MessageBox.Show("請輸入要新增的學生,學號及密碼");
            }
            else
            {
                int personNo = Convert.ToInt32(txt學號.Text);
                string personPassword = txt密碼.Text;
                班級id = list班級id[cbox班級.SelectedIndex];
                //檢查學生是否已存在
                string cSQL = @"select * from [person] where [personno] = @PNO";
                SqlCommand cmd = new SqlCommand(cSQL, con);
                cmd.Parameters.AddWithValue("@PNO", (int)personNo);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("此學號已存在");
                    reader.Close();
                }
                else
                {
                    reader.Close();

                    學號 = Convert.ToInt32(txt學號.Text);
                    int classId = list班級id[cbox班級.SelectedIndex];
                    密碼 = txt密碼.Text;
                    string tSQL = @"insert into person (personno,personname,classid,personpassword,pauthority)values (@val1,@val2,@val3,@val4,@val5)";
                    SqlCommand icmd = new SqlCommand(tSQL, con);
                    icmd.Parameters.AddWithValue("@val1", 學號);
                    icmd.Parameters.AddWithValue("@val2", (string)txt學生.Text);
                    icmd.Parameters.AddWithValue("@val3", classId);
                    icmd.Parameters.AddWithValue("@val4", 密碼);
                    icmd.Parameters.AddWithValue("@val5", 101);
                    int row = icmd.ExecuteNonQuery();
                    if (row>0)
                        MessageBox.Show("新增學號: " + 學號 + " 完成");

                }

            }
            con.Close();
            載入學生();
        }

        private void btn修改學生_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn修改學生.Height;
            panSide.Top = btn修改學生.Top;
            panSide.BackColor = Color.FromArgb(238, 108, 77);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //檢查學生非空
            if (txt班級.Text == "")
            {
                MessageBox.Show("請選擇要修改學生的班級");
            }
            else if (txt學生.Text == "" || txt學號.Text == "" || txt密碼.Text == "")
            {
                MessageBox.Show("請選擇要修改的學生");
            }
            else
            {
                int personNo = Convert.ToInt32(txt學號.Text);
                int personPassword = Convert.ToInt32(txt密碼.Text);
                班級id = list班級id[cbox班級.SelectedIndex];
                string tSQL = @"update person set personname = @val1 ,classid = @val2, personpassword = @val3 where personno = @val4";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", (string)txt學生.Text);
                cmd.Parameters.AddWithValue("@val2", 班級id);
                cmd.Parameters.AddWithValue("@val3", personPassword);
                cmd.Parameters.AddWithValue("@val4", personNo);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("修改學生資料成功");
                }
                else
                {
                    MessageBox.Show("此學號不存在");
                }
                con.Close();
            }

            載入學生();
        }

        private void btn刪除學生_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn刪除學生.Height;
            panSide.Top = btn刪除學生.Top;
            panSide.BackColor = Color.FromArgb(238, 108, 77);

            刪除學生();
        }

        private void cbox班級_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt班級.Text = list班級[cbox班級.SelectedIndex];
            班級id = list班級id[cbox班級.SelectedIndex];
            載入學生();
            txt學生.Text = "";
            txt學號.Text = "";
            txt密碼.Text = "";

        }

        private void lbox學生_SelectedIndexChanged(object sender, EventArgs e)
        {
            學號 = list學生no[lbox學生.SelectedIndex];
            學生 = list學生[lbox學生.SelectedIndex].ToString();
            密碼 = list密碼[lbox學生.SelectedIndex];
            txt學號.Text = 學號.ToString();
            txt學生.Text = 學生;
            txt密碼.Text = 密碼.ToString();
        }

        private void btn管理員_Click(object sender, EventArgs e)
        {
            Form7 form管理員 = new Form7();
            form管理員.ShowDialog();
        }
    }
}
