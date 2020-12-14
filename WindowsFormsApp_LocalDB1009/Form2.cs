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
using System.Collections;

namespace WindowsFormsApp_LocalDB1009
{
    public partial class Form2 : Form
    {
        string myDBConnectionString = "";
        List<string> list訂購資訊 = new List<string>();
        int sum;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            myDBConnectionString = @"Data Source=.;Initial Catalog=mealdb;Integrated Security=True";

            update統計列表();
            訂購資訊();
            lbl統計標題.Text = Globalval.班級 + "的統計列表";
            lbl日期.Text = "訂購日期: " + DateTime.Now.ToString("yyyy/MM/dd");
            lbl總價.Text = "總價: " + sum.ToString() + "元";

            //搜尋
            cbox搜尋.Items.Add("學生");
            cbox搜尋.Items.Add("店家");
            cbox搜尋.Items.Add("品項");


        }

        void update統計列表()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select [ostore] as 店家,[oitem] as 品項,sum(oqty) as 數量 , sum(oitemtotal) as 價錢 from odetail where [odelete] = @val1 and [oclass] = @val2 group by [ostore],[oitem] order by 1";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@val1", 1);
            cmd.Parameters.AddWithValue("@val2", Globalval.班級);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv統計.DataSource = dt;

            }

            reader.Close();
            con.Close();
            //MessageBox.Show("統計完成");

        }
        void 訂購資訊()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select [ostore] as 店家,[oitem] as 品項,sum(oqty) as 數量 , sum(oitemtotal) as 價錢 from odetail where [odelete] = @val1 and [oclass] = @val2 group by [ostore],[oitem] order by 1";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@val1", 1);
            cmd.Parameters.AddWithValue("@val2", Globalval.班級);
            SqlDataReader reader = cmd.ExecuteReader();
            string strOrderInfo = "";
            int i = 0;
            sum = 0;

            while (reader.Read())
            {
                strOrderInfo = string.Format("{0,-10}{1,10}{2,6}個{3,6}元", reader["店家"], reader["品項"], reader["數量"], reader["價錢"]);
                list訂購資訊.Add(strOrderInfo);
                sum += (int)reader["價錢"];
                i += 1;
            }

            reader.Close();
            con.Close();
            MessageBox.Show("總計:" + sum.ToString() + "元");

        }


        private void btn存檔_Click(object sender, EventArgs e)
        {
            string strFilePath = @"C:\";

            //檔名加亂數
            Random myRnd = new Random();
            int MyNum = myRnd.Next(1000, 9999);
            string strFileName = DateTime.Now.ToString("yyyyMMddmmss") + MyNum.ToString() + @"便當訂購單.txt";

            string wholeFilePath = strFilePath + strFileName;

            //存檔
            SaveFileDialog sfd = new SaveFileDialog();
            //預設目錄
            sfd.InitialDirectory = @"C:\";
            //預設檔名
            sfd.FileName = strFileName;
            //檔案格式
            sfd.Filter = "Txt File|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                wholeFilePath = sfd.FileName;
            }
            else
            {
                return;
            }

            //檔案內容
            List<string> linesAllitemsList = new List<string>();

            linesAllitemsList.Add("****************************  便當訂購單 ******************************");
            linesAllitemsList.Add("======================================================================");
            linesAllitemsList.Add("訂購日期: " + DateTime.Now.ToString("yyyy/MM/dd"));
            linesAllitemsList.Add("----------------------------------------------------------------------");
            linesAllitemsList.Add("訂購品項:\n\n");


            if (list訂購資訊.Count > 0)
            {
                foreach (string item in list訂購資訊)
                {
                    linesAllitemsList.Add(item);
                }

            }

            linesAllitemsList.Add("\n---------------------------------------------------------------------");
            linesAllitemsList.Add("訂購單總價: " + sum.ToString() + "元");
            linesAllitemsList.Add("=======================================================================");

            System.IO.File.WriteAllLines(wholeFilePath, linesAllitemsList, Encoding.UTF8);
            MessageBox.Show("存檔成功");
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            //搜尋欄位轉換成資料表欄位
            string strSearchColumn = cbox搜尋.SelectedItem.ToString();
            if(strSearchColumn == "學生")
            {
                strSearchColumn = "operson";
            }
            else if(strSearchColumn == "店家")
            {
                strSearchColumn = "ostore";
            }
            else if(strSearchColumn == "品項")
            {
                strSearchColumn = "oitem";
            }

            if (txt搜尋.Text != "")
            {
                string tSQL = "select [ostore] as 店家,[oitem] as 品項,[operson] as 學生,[oqty] as 數量,[oitemtotal] as 價錢 from odetail where [odelete] = @val1 and [oclass] = @val2 and [" + strSearchColumn + "] like @SearchString order by 1,2 ";

                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", 1);
                cmd.Parameters.AddWithValue("@val2", Globalval.班級);
                cmd.Parameters.AddWithValue("@SearchString", "%" + txt搜尋.Text + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgv搜尋.DataSource = dt;

                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dgv搜尋.DataSource = dt;
                    MessageBox.Show("找不到訂購資料");
                }

            }
            else
            {
                MessageBox.Show("請輸入搜尋字串");
            }
        }
    }
}
