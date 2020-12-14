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
using System.Security.Permissions;
using WindowsFormsApp_LocalDB1009.Database1DataSet1TableAdapters;
using System.IO;

namespace WindowsFormsApp_LocalDB1009
{
    public partial class Form1 : Form
    {
        string myDBConnectionString = "";        
        string 日期 = "";
        //string 班級 = "";
        string 學生 = "";
        string 店家 = "";
        string 品項 = "";
        int intSelect店家 = 0;
        int 單價;
        int 數量;
        int 總價;
        List<string> list班級 = new List<string>();
        List<string> list學生 = new List<string>();
        List<string> list店家 = new List<string>();
        List<string> list圖片 = new List<string>();
        List<string> list值日生 = new List<string>();
        Dictionary<string, int> dicFooditem = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            myDBConnectionString = @"Data Source=.;Initial Catalog=mealdb;Integrated Security=True";//連線字串的物件            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();             
            
            //log班級&學生
            string aSQL = "select * from person a inner join class b on a.classid = b.classid where a.personid = @val1";
            SqlCommand acmd = new SqlCommand(aSQL, con);
            acmd.Parameters.AddWithValue("@val1", Globalval.logid);
            SqlDataReader areader = acmd.ExecuteReader();
            while (areader.Read())
            {
                學生 = (string)areader["personname"];
                Globalval.班級 = (string)areader["classname"];
                lbl學生.Text = string.Format("學生: {0}", 學生);
                lbl班級.Text = string.Format("班級: {0}", Globalval.班級);
            }
            areader.Close();

            //店家            
            string tSQLStore = "select * from store";
            SqlCommand cmdstore = new SqlCommand(tSQLStore, con);
            SqlDataReader readerstore = cmdstore.ExecuteReader();
            
            string strstore = "";
            int j = 0;
            while (readerstore.Read())
            {
                strstore = string.Format("{0}", readerstore["storename"]);
                list店家.Add(strstore);
                j += 1;
            }
            foreach (string item in list店家)
            {
                cbox店家.Items.Add(item);
            }
            
            cbox店家.SelectedIndex = 0;
            intSelect店家 = cbox店家.SelectedIndex + 1;
            店家 = list店家[cbox店家.SelectedIndex];
            加入品項按鈕();
            readerstore.Close();
            
            //顯示值日生
            string dSQL = "select * from person where pauthority = @val2 and classid = @val3";
            SqlCommand dcmd = new SqlCommand(dSQL, con);
            dcmd.Parameters.AddWithValue("@val2", 11);
            dcmd.Parameters.AddWithValue("@val3", Globalval.classID);
            SqlDataReader dreader = dcmd.ExecuteReader();
            int k = 0;
            string duty;
            while (dreader.Read())
            {
                duty = (string)dreader["personname"];
                list值日生.Add(duty);
                k += 1;
            }
            foreach(string d in list值日生)
            {
                cbox值日生.Items.Add(d);
            }
            cbox值日生.SelectedIndex = 0;


            //日期
            lblOdate.Text = "訂購日期: " + DateTime.Now.ToString("yyyy/MM/dd");
            日期 = DateTime.Now.ToString("yyyy/MM/dd");

            //dgv訂購明細
            update訂單明細();
           
            con.Close();

            //btn顯示by權限
            if (Globalval.logauth >100)
            {//學生
                btn管理.Visible = false;
                btn統計.Visible = false;
                btn指派值日生.Visible = false;
                btn管理學生.Visible = false;
                btn清空.Visible = false;
                MessageBox.Show("Hi~" + 學生 + " 今天想吃些什麼?");
            }
            else if(Globalval.logauth >10)
            {//值日生
                btn管理.Visible = false;
                btn統計.Visible = true;
                btn指派值日生.Visible = true;
                btn管理學生.Visible = false;
                btn清空.Visible = true;
                lbl學生.Text = "值日生:" + 學生;
                MessageBox.Show("Hi~" + 學生 + " 您今日是值日生");
            }
            else if(Globalval.logauth <= 10)
            {//管理者
                btn管理.Visible = true;
                btn統計.Visible = true;
                btn指派值日生.Visible = true;
                btn管理學生.Visible = true;
                btn清空.Visible = true;
                lbl學生.Text = "管理員:" + 學生;
                MessageBox.Show("Hi~" + 學生 + " 管理員");
            }
            //dgv欄位寬度
            if (dgv訂購明細.Rows.Count>0)
            {
                DataGridViewColumn column1 = dgv訂購明細.Columns[0];
                column1.Width = 80;
                DataGridViewColumn column4 = dgv訂購明細.Columns[3];
                column4.Width = 80;
            }
            
            //panside效果
            panSide.Height = btn訂購.Height;
            panSide.Top = btn訂購.Top;
        }
        int dgvselectID;
        private void dgv訂購明細_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>-1)
            {
                string dgvselect = dgv訂購明細.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgvselectID = Convert.ToInt32(dgvselect);
                Console.WriteLine(dgvselectID);
            }
            
        }
        void update訂單明細()
        {
            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select [oid] 訂單編號,[operson] 學生,[oitem] 品項,oqty 數量, oitemtotal 價錢 from odetail where [odelete] = @val1 and [oclass] = @val2 order by 1";
            SqlCommand cmddgv = new SqlCommand(tSQL, con);
            cmddgv.Parameters.AddWithValue("@val1", 1);
            cmddgv.Parameters.AddWithValue("@val2", Globalval.班級);
            SqlDataReader readerdgv = cmddgv.ExecuteReader();
            if (readerdgv.HasRows)
            {
                DataTable dt = new DataTable();                
                dt.Load(readerdgv);
                dgv訂購明細.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dgv訂購明細.DataSource = dt;
            }
            

            readerdgv.Close();
            con.Close();
            
            //MessageBox.Show("已重新整理");

        }

        List<RadioButton> listRadio便當 = new List<RadioButton>();
        List<int> list品項id = new List<int>();
        void 加入品項按鈕()
        {
            dicFooditem.Clear();
            list品項id.Clear();
            list圖片.Clear();
            
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from item where storeid = @val1";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@val1", (int)intSelect店家);
            SqlDataReader reader = cmd.ExecuteReader();
            
            int i = 0;
            int k = 0;
            int h = 0;
           
            while (reader.Read())
            {
                string str = string.Format("{0}", reader["itemname"]);
                int price = Convert.ToInt32(string.Format("{0}", reader["itemUnitprice"]));
                int itemid = Convert.ToInt32(reader["itemid"]);
                string img = (string)reader["itemimage"];
                dicFooditem.Add(str,price);
                list品項id.Add(itemid);
                list圖片.Add(img);
                
                i += 1;
            }
            for (int j=0; j<dicFooditem.Count;j++)
            {
                var item = dicFooditem.ElementAt(j);
                var itemkey = item.Key;
                int itemvalue = item.Value;
                if(j%4 == 0&& j != 0)
                {
                    k = 0;
                    h += 30;
                }
                                               
                RadioButton myRadio = new RadioButton();
                myRadio.Location = new Point(20 + 170 * k, 20+h);
                myRadio.Size = new Size(170, 25);
                myRadio.Padding = new Padding(0);
                myRadio.Text = itemkey + " " + itemvalue.ToString() + "元";
                myRadio.Tag = itemvalue;
                myRadio.Name = itemkey;
                myRadio.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                myRadio.ForeColor = Color.FromArgb(152, 193, 217);
                myRadio.CheckedChanged += new EventHandler(radio便當共用_CheckedChanged);
              

                pan3.Controls.Add(myRadio);
                listRadio便當.Add(myRadio);
                k++;                
                
            }
            
            reader.Close();
            con.Close();            
        }
        

        private void radio便當共用_CheckedChanged(object sender, EventArgs e)
        {//sender 是觸發事件的物件(object),也就是把記憶體位置傳過來   e就是事件本身

            RadioButton myRadio = (RadioButton)sender;
            品項 = myRadio.Name;
            //MessageBox.Show("主餐選了:" + 品項);
            數量 = 1;
            txt數量.Text = 數量.ToString();            
            單價 = (int)myRadio.Tag;
            計算價錢();
            顯示品項照片();
            //CheckedChanged 離開和進入都會呼叫兩次messagebox 所以messagebox只是拿來debug而已

        }
        void 顯示品項照片()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from [item] where itemname = @SearchNAME";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@SearchNAME", 品項);
            SqlDataReader reader = cmd.ExecuteReader();
            string image_dir = @"images\";
            string image_name = "";
            int i = 0;
            while (reader.Read())
            {                
                image_name = (string)reader["itemimage"];
                pic1.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
        }
        void 計算價錢()
        {
            總價 = 單價 * 數量;
            lbl價錢.Text = "價錢:  " + 總價.ToString() + "元";

        }

        private void cbox店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            pan3.Controls.Clear();
            intSelect店家 = cbox店家.SelectedIndex + 1;
            店家 = list店家[cbox店家.SelectedIndex];
            加入品項按鈕();
        }

        private void txt數量_TextChanged(object sender, EventArgs e)
        {
            if (txt數量.Text != "")
            {               
                bool ifNum = Int32.TryParse(txt數量.Text, out 數量);
                if ((ifNum == true) && (數量 >= 1))
                {

                }
                else
                { //輸入非整數
                    MessageBox.Show("數量有誤,請輸入整數");
                    數量 = 1;
                    txt數量.Text = 數量.ToString();
                }
            }
            else
            {
                數量 = 1;
            }
            計算價錢();

        }

        private void btn訂購_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn訂購.Height;
            panSide.Top = btn訂購.Top;

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            if (品項 != "")
            {
                string tSQL = @"INSERT into oDetail(odate,oclass,operson,ostore,oitem,oqty,ounitprice,oitemtotal,odelete,opersonid) values (@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10)";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", 日期);
                cmd.Parameters.AddWithValue("@val2", Globalval.班級);
                cmd.Parameters.AddWithValue("@val3", 學生);
                cmd.Parameters.AddWithValue("@val4", 店家);
                cmd.Parameters.AddWithValue("@val5", 品項);
                cmd.Parameters.AddWithValue("@val6", 數量);
                cmd.Parameters.AddWithValue("@val7", 單價);
                cmd.Parameters.AddWithValue("@val8", 總價);
                cmd.Parameters.AddWithValue("@val9", 1);
                cmd.Parameters.AddWithValue("@val10", Globalval.logid);
                cmd.ExecuteNonQuery();

                con.Close();
                update訂單明細();
                MessageBox.Show("已加入訂購明細");
            }
            else
            {
                MessageBox.Show("請選擇要訂購的品項");
            }
            

        }

        private void btn清空_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn清空.Height;
            panSide.Top = btn清空.Top;

            DialogResult R = MessageBox.Show("確定要刪除此店家?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (R == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string tSQL = "update [oDetail] set [odelete] = @val2 where [odelete] = @val1";
                SqlCommand cmd = new SqlCommand(tSQL, con);
                cmd.Parameters.AddWithValue("@val1", 1);
                cmd.Parameters.AddWithValue("@val2", 0);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("已清空訂購明細");
                }
                update訂單明細();
                con.Close();
                
            }
            else
            {
                MessageBox.Show("取消清空訂購明細");
            }
            

            
            

        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn刪除.Height;
            panSide.Top = btn刪除.Top;
            if (dgv訂購明細.Rows.Count > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();

                string tSQLdel = "update [oDetail] set [oDelete] = @val2 where [oId] = @val1 and [opersonid] = @val3";
                SqlCommand cmdDel = new SqlCommand(tSQLdel, con);
                cmdDel.Parameters.AddWithValue("@val1", dgvselectID);
                cmdDel.Parameters.AddWithValue("@val2", 0);
                cmdDel.Parameters.AddWithValue("@val3", Globalval.logid);
                int rows = cmdDel.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("刪除成功");
                }
                else
                {
                    MessageBox.Show("無法刪除別人的訂購紀錄");
                }
                update訂單明細();
                con.Close();
                
            }
            else
            {
                update訂單明細();
            }
            
            
        }

        private void btn統計_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn統計.Height;
            panSide.Top = btn統計.Top;

            Form2 form統計列表 = new Form2();
            form統計列表.ShowDialog();
        }

        private void btn管理_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn管理.Height;
            panSide.Top = btn管理.Top;

            Form4 form管理 = new Form4();
            form管理.ShowDialog();
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn登出.Height;
            panSide.Top = btn登出.Top;

            Form3 form登入 = new Form3();
            form登入.ShowDialog();
            //如何把form1關掉
            this.Hide();
            
        }

        private void btn管理學生_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn管理學生.Height;
            panSide.Top = btn管理學生.Top;

            Form5 form管理學生 = new Form5();
            form管理學生.ShowDialog();
        }

        private void btn指派值日生_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn指派值日生.Height;
            panSide.Top = btn指派值日生.Top;

            Form6 form值日生 = new Form6();
            form值日生.ShowDialog();
        }
    }
}
