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

namespace WindowsFormsApp_LocalDB1009
{
    public partial class Form7 : Form
    {
        string myDBConnectionString = @"Data Source=.;Initial Catalog=mealdb;Integrated Security=True";
        List<int> listPersonId = new List<int>();
        List<string> listPname = new List<string>();
        List<int> listManageId = new List<int>();
        List<string> listMname = new List<string>();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lbl班級.Text = "班級: " + Globalval.班級;
            加入學生();
            加入管理員();
        }
        void 加入學生()
        {
            listPersonId.Clear();
            listPname.Clear();
            cbox學生.Items.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();

            string tSQL = "select * from person where classid = @val1";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@val1", Globalval.classID);
            SqlDataReader reader = cmd.ExecuteReader();
            string pname;
            int PERSONID;
            int i = 0;
            while (reader.Read())
            {
                pname = string.Format("{0}", (string)reader["personname"]);
                PERSONID = (int)reader["personid"];
                listPname.Add(pname);
                listPersonId.Add(PERSONID);
                i += 1;
            }
            foreach (string item in listPname)
            {
                cbox學生.Items.Add(item);
            }
            reader.Close();
            con.Close();
            cbox學生.SelectedIndex = 0;
        }
        void 加入管理員()
        {
            listMname.Clear();
            listManageId.Clear();
            cbox管理員.Items.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string iSQL = "select * from person where classid = @val2 and pauthority = @val3";
            SqlCommand icmd = new SqlCommand(iSQL, con);
            icmd.Parameters.AddWithValue("@val2", Globalval.classID);
            icmd.Parameters.AddWithValue("@val3", 1);
            SqlDataReader ireader = icmd.ExecuteReader();
            string mname;
            int mId;
            int j = 0;
            while (ireader.Read())
            {
                mname = (string)ireader["personname"];
                mId = (int)ireader["personid"];
                listMname.Add(mname);
                listManageId.Add(mId);
                j += 1;
            }
            foreach (string d in listMname)
            {
                cbox管理員.Items.Add(d);
            }

            ireader.Close();
            con.Close();
            cbox管理員.SelectedIndex = 0;
        }
        private void btn設為管理員_Click(object sender, EventArgs e)
        {
            int studentId = listPersonId[cbox學生.SelectedIndex];
            string studentName = listPname[cbox學生.SelectedIndex];
            if (studentId > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();

                string tSQL = @"update person set pauthority = @val1 where personid = @val2";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", 1);
                cmd.Parameters.AddWithValue("@val2", studentId);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("已修改" + studentName + "成為管理員");
                }
                else
                {
                    MessageBox.Show("修改失敗");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("請選擇要設為管理員的學生");
            }
            加入管理員();
        }

        private void btn取消管理員_Click(object sender, EventArgs e)
        {

            DialogResult R = MessageBox.Show("確定要刪除您自己的管理員身分?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (R == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();

                string tSQL = @"update person set pauthority = @val1 where personid = @val2";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", 101);
                cmd.Parameters.AddWithValue("@val2", Globalval.logid);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("已刪除您的管理員身分");
                }
                else
                {
                    MessageBox.Show("刪除失敗");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("已取消刪除管理員身分");
            }
            加入管理員();
        }
    }
}
