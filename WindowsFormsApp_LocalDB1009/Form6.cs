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
    public partial class Form6 : Form
    {
        string myDBConnectionString = @"Data Source=.;Initial Catalog=mealdb;Integrated Security=True";
        List<int> listPersonId = new List<int>();
        List<string> listPname = new List<string>();
        List<int> listDutyId = new List<int>();
        List<string> listDname = new List<string>();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lbl班級.Text = "班級: " + Globalval.班級;
            加入學生();
            加入值日生();
            

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
        void 加入值日生()
        {
            listDname.Clear();
            listDutyId.Clear();
            cbox值日生.Items.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string iSQL = "select * from person where classid = @val2 and pauthority = @val3";
            SqlCommand icmd = new SqlCommand(iSQL, con);
            icmd.Parameters.AddWithValue("@val2", Globalval.classID);
            icmd.Parameters.AddWithValue("@val3", 11);
            SqlDataReader ireader = icmd.ExecuteReader();
            string dname;
            int dutyId;
            int j = 0;
            while (ireader.Read())
            {
                dname = (string)ireader["personname"];
                dutyId = (int)ireader["personid"];
                listDname.Add(dname);
                listDutyId.Add(dutyId);
                j += 1;
            }
            foreach (string d in listDname)
            {
                cbox值日生.Items.Add(d);
            }

            ireader.Close();
            con.Close();
            cbox值日生.SelectedIndex = 0;
        }

        private void btn設為值日生_Click(object sender, EventArgs e)
        {
            int studentId = listPersonId[cbox學生.SelectedIndex];
            string studentName = listPname[cbox學生.SelectedIndex];
            if (studentId > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                
                string tSQL = @"update person set pauthority = @val1 where personid = @val2";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", 11);
                cmd.Parameters.AddWithValue("@val2", studentId);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("已修改" + studentName + "成為值日生");
                }
                else
                {
                    MessageBox.Show("修改失敗");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("請選擇要設為值日生的學生");
            }
            加入學生();
            加入值日生();

        }

        private void btn取消值日生_Click(object sender, EventArgs e)
        {
            int dutyId = listDutyId[cbox值日生.SelectedIndex];
            string dutyName = listDname[cbox值日生.SelectedIndex];
            if (dutyId > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();

                string tSQL = @"update person set pauthority = @val1 where personid = @val2";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", 101);
                cmd.Parameters.AddWithValue("@val2", dutyId);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("已取消" + dutyName + "值日生身分");
                }
                else
                {
                    MessageBox.Show("取消失敗");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("請選擇要取消身分的值日生");
            }
            加入學生();
            加入值日生();
        }
    }
}
