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
using System.IO;

namespace WindowsFormsApp_LocalDB1009
{
    public partial class Form4 : Form
    {
        int listviewId;
        int selectedID = 0;
        int 店家id;
        string myDBConnectionString = @"Data Source=.;Initial Catalog=mealdb;Integrated Security=True";
        string 店家;
        string image_dir = @"images\";
        string image_name = "demo.png";
        List<string> list店家 = new List<string>();
        List<int> list店家id = new List<int>();
        List<string> listItemName = new List<string>();
        List<int> listItemID = new List<int>();
        List<int> listItemPrice = new List<int>();
        List<int> listLastItemId = new List<int>();
        List<string> listImgName = new List<string>();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn新增店家.Height;
            panSide.Top = btn新增店家.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            //myDBConnectionString = @"Data Source=.;Initial Catalog=mealdb;Integrated Security=True";//連線字串的物件            
            載入店家();
            cbx店家.SelectedIndex = 0;
            店家id = list店家id[cbx店家.SelectedIndex];
            txt店家.Text = list店家[cbx店家.SelectedIndex];

            讀取品項();
            //顯示品項細項();
            產生圖片View();

        }
        void 載入店家()
        {
            //先清空
            list店家.Clear();
            list店家id.Clear();
            cbx店家.Items.Clear();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from store";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list店家.Add((string)reader["storename"]);
                list店家id.Add((int)reader["storeid"]);
            }
            foreach (string i in list店家)
            {
                cbx店家.Items.Add(i);
            }
            reader.Close();
            con.Close();
        }
        void 讀取品項()
        {
            listItemID.Clear();
            listItemName.Clear();
            listItemPrice.Clear();
            imageList1.Images.Clear();
            listImgName.Clear();
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from [item] where storeid = @ID";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@ID", 店家id);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            int i = 0;

            while (reader.Read())
            {
                listItemID.Add((int)reader["itemid"]);
                listItemName.Add((string)reader["itemname"]);
                listItemPrice.Add((int)reader["itemunitprice"]);
                image_name = (string)reader["itemimage"];
                listImgName.Add(image_name);
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                i += 1;
            }
            //MessageBox.Show(i.ToString() + "筆資料受影響");
            reader.Close();
            con.Close();
        }

        private void btn新增店家_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn新增店家.Height;
            panSide.Top = btn新增店家.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            //cbx店家.ForeColor = Color.Gray;
            cbx店家.Text = "";
            txt店家.Text = "";
            txt品項.Text = "";
            txt價格.Text = "";
            pic品項.Image = null;
            listView1.Items.Clear();

        }

        private void btn新增品項_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn新增品項.Height;
            panSide.Top = btn新增品項.Top;
            panSide.BackColor = Color.FromArgb(238, 108, 77);
            if(txt店家.Text != "")
            {
                txt品項.Text = "";
                txt價格.Text = "";
                pic品項.Image = null;
            }
            else
            {
                MessageBox.Show("請選擇要新增品項的店家");
            }
            

        }

        private void btn選擇照片_Click(object sender, EventArgs e)
        {
            //取得最後的itemid
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from [item]";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int ITEMID;
            int i = 0;

            while (reader.Read())
            {
                ITEMID = (int)reader["itemid"];
                listLastItemId.Add(ITEMID);
                i += 1;
            }
            reader.Close();
            con.Close();
            int length = listLastItemId.Count;
            int lastItemId = listLastItemId[length - 1]+1;


            //選圖片
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpg;*jpeg;*.png";

            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pic品項.Image = Image.FromFile(f.FileName);
                //FileName是路徑>去fromfile取得檔名
                string fileExt = Path.GetExtension(f.SafeFileName);
                //SafeFileName是檔名>去getextension取得副檔名
                if (selectedID > 0)
                {
                    image_name = "item" + selectedID.ToString()+ DateTime.Now.ToString("yyyyMMddHHmmss") + fileExt;
                }
                else
                {
                    image_name = "item" + lastItemId.ToString()+ DateTime.Now.ToString("yyyyMMddHHmmss") + fileExt;
                }
                
                //image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + fileExt;
            }
        }

        private void btn儲存店家_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn儲存店家.Height;
            panSide.Top = btn儲存店家.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            //儲存店家
            店家 = txt店家.Text;
            Console.WriteLine(店家);
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //檢查店家非null
            if (txt店家.Text == "")
            {
                MessageBox.Show("請輸入要新增的店家名稱");
            }
            else
            {
                //檢查店家是否已存在
                string cSQL = "select * from store where storename = @checkName";
                SqlCommand cmd = new SqlCommand(cSQL, con);
                cmd.Parameters.AddWithValue("@checkName", (string)店家);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("此店家已存在");
                    reader.Close();
                }
                else
                {
                    reader.Close();

                    string iSQL = @"INSERT into store values (@val1)";
                    SqlCommand icmd = new SqlCommand(iSQL, con);
                    icmd.Parameters.AddWithValue("@val1", (string)店家);
                    icmd.ExecuteNonQuery();
                    MessageBox.Show("新增店家成功");

                }
            }
            con.Close();
            載入店家();

        }

        private void btn儲存品項_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn儲存品項.Height;
            panSide.Top = btn儲存品項.Top;
            panSide.BackColor = Color.FromArgb(238, 108, 77);
            
            //int price;
            //int storeid;

            //SqlConnection con = new SqlConnection(myDBConnectionString);
            //con.Open();
            //檢查店家非null
            if (txt店家.Text == "")
            {
                MessageBox.Show("請選擇要新增品項的店家");
            }
            else if (txt品項.Text == "" || txt價格.Text == "")
            {
                MessageBox.Show("請輸入要新增的品項及價格");
            }
            else if((txt品項.Text != "") && (txt價格.Text != "") && (pic品項.Image == null))
            {
                //預設圖片
                儲存無照片品項();

            }
            else if((txt品項.Text != "") && (txt價格.Text != "") && (pic品項.Image != null))
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                pic品項.Image.Save(image_dir + image_name);
                int price = Convert.ToInt32(txt價格.Text);
                int storeid = list店家id[cbx店家.SelectedIndex];
                //檢查品項是否已存在?
                string cSQL = @"select * from [item] where [storeid] = @sStoreid and [itemname] = @sItemname";
                SqlCommand cmd = new SqlCommand(cSQL, con);
                cmd.Parameters.AddWithValue("@sStoreid", (int)storeid);
                cmd.Parameters.AddWithValue("@sItemname", (string)txt品項.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                //int row = cmd.ExecuteNonQuery();
                //Console.WriteLine(storeid.ToString() + "影響:" + row.ToString());
                if (reader.HasRows)
                {
                    MessageBox.Show("此品項已存在");
                    reader.Close();

                }
                else
                {
                    reader.Close();
                    //int price = Convert.ToInt32(txt價格.Text);
                    //int storeid = list店家id[cbx店家.SelectedIndex];
                    string iSQL = @"insert into item (itemname,itemunitprice,storeid,itemimage)values (@val1,@val2,@val3,@val4)";
                    SqlCommand icmd = new SqlCommand(iSQL, con);
                    icmd.Parameters.AddWithValue("@val1", (string)txt品項.Text);
                    icmd.Parameters.AddWithValue("@val2", (int)price);
                    icmd.Parameters.AddWithValue("@val3", (int)storeid);
                    icmd.Parameters.AddWithValue("@val4", image_name);
                    int irow = icmd.ExecuteNonQuery();
                    MessageBox.Show("新增品項: " + txt品項.Text + "完成");

                }
                con.Close();
            }
            
            讀取品項();            
            產生圖片View();
        }
        void 儲存無照片品項()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //pic品項.Image.Save(image_dir + img);
            int price = Convert.ToInt32(txt價格.Text);
            int storeid = list店家id[cbx店家.SelectedIndex];
            //檢查品項是否已存在??
            string cSQL = @"select * from [item] where [storeid] = @sStoreid and [itemname] = @sItemname";
            SqlCommand cmd = new SqlCommand(cSQL, con);
            cmd.Parameters.AddWithValue("@sStoreid", (int)storeid);
            cmd.Parameters.AddWithValue("@sItemname", (string)txt品項.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
                MessageBox.Show("此品項已存在");
                reader.Close();

            }
            else
            {
                reader.Close();
                //int price = Convert.ToInt32(txt價格.Text);
                //int storeid = list店家id[cbx店家.SelectedIndex];
                string iSQL = @"insert into item (itemname,itemunitprice,storeid,itemimage)values (@val1,@val2,@val3,@val4)";
                SqlCommand icmd = new SqlCommand(iSQL, con);
                icmd.Parameters.AddWithValue("@val1", (string)txt品項.Text);
                icmd.Parameters.AddWithValue("@val2", (int)price);
                icmd.Parameters.AddWithValue("@val3", (int)storeid);
                icmd.Parameters.AddWithValue("@val4", "demo.png");
                int irow = icmd.ExecuteNonQuery();
                MessageBox.Show("新增品項: " + txt品項.Text + "完成");

            }
            con.Close();
        }
        
        private void btn修改店家_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn修改店家.Height;
            panSide.Top = btn修改店家.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            //檢查店家非空
            if (cbx店家.Text == "")
            {
                MessageBox.Show("請選擇要修改的店家");
            }
            else
            {
                if (店家id > 0)
                {
                    string iSQL = @"update store set storename = @val1 where storeid = @val2";
                    SqlCommand icmd = new SqlCommand(iSQL, con);
                    icmd.Parameters.AddWithValue("@val1", (string)txt店家.Text);
                    icmd.Parameters.AddWithValue("@val2", (int)店家id);
                    int row = icmd.ExecuteNonQuery();
                    if(row > 0)
                        MessageBox.Show("修改店家成功");
                }
                else
                {
                    MessageBox.Show("此店家名稱不存在");
                }
            }
            con.Close();
            載入店家();

        }

        private void cbx店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            店家id = list店家id[cbx店家.SelectedIndex];
            txt店家.Text = list店家[cbx店家.SelectedIndex];
            txt價格.Text = "";
            txt品項.Text = "";
            pic品項.Image = null;
            讀取品項();
            //顯示品項細項();
            產生圖片View();            

        }

        private void btn刪除店家_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn刪除店家.Height;
            panSide.Top = btn刪除店家.Top;
            panSide.BackColor = Color.FromArgb(152, 193, 217);
            string s = txt店家.Text;
            int storeid = list店家id[cbx店家.SelectedIndex];
            Console.WriteLine(s);
            DialogResult R = MessageBox.Show("確定要刪除此店家?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (R == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                //檢查店家非空
                if (txt店家.Text == "")
                {
                    MessageBox.Show("請選擇要刪除的店家");
                }
                else
                {
                    string iSQL = @"delete store where storename = @val1";
                    SqlCommand icmd = new SqlCommand(iSQL, con);
                    icmd.Parameters.AddWithValue("@val1", (string)s);
                    int row = icmd.ExecuteNonQuery();
                    if (row>0)
                    {
                        
                        MessageBox.Show("刪除店家成功,將會一併刪除此店家的品項");
                        //一併刪除此店家的品項
                        string tSQL = @"delete item where storeid = @val1";
                        SqlCommand cmd = new SqlCommand(tSQL, con);
                        cmd.Parameters.AddWithValue("@val1", storeid);
                        int trow = cmd.ExecuteNonQuery();
                        if (trow > 0)
                        {
                            MessageBox.Show("刪除品項成功");
                            txt店家.Text = "";
                            txt品項.Text = "";
                            txt價格.Text = "";
                            listView1.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("此店家的品項已不存在");
                        }
                    }
                    else
                    {
                        MessageBox.Show("此店家名稱不存在");
                    }
                }
                con.Close();
                載入店家();

            }
            else
            {//取消刪除
                MessageBox.Show("已取消刪除");

            }

            
        }
        string d = DateTime.Now.ToString("yyyyMMdd");
        private void btn修改品項_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn修改品項.Height;
            panSide.Top = btn修改品項.Top;
            panSide.BackColor = Color.FromArgb(238, 108, 77);

            //pic品項.Image.Save(image_dir + image_name);
            //SqlConnection con = new SqlConnection(myDBConnectionString);
            //con.Open();


            //int price = Convert.ToInt32(txt價格.Text);
            //店家id = list店家id[cbx店家.SelectedIndex];
            //檢查店家非空

            if (selectedID > -1)
            {
                if (txt品項.Text == "" || txt價格.Text == "" || image_name == "")
                {
                    MessageBox.Show("請選擇要修改的品項");
                }
                else
                {
                    if(image_name != listImgName[listviewId])
                    {
                        pic品項.Image.Save(image_dir + image_name);
                    }
                        
                    int price = Convert.ToInt32(txt價格.Text);
                    店家id = list店家id[cbx店家.SelectedIndex];
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();

                    string iSQL = @"update item set itemname = @val1 ,itemunitprice = @val2, storeid = @val3,itemimage= @val4 where itemid = @val5";
                    SqlCommand icmd = new SqlCommand(iSQL, con);
                    icmd.Parameters.AddWithValue("@val1", (string)txt品項.Text);
                    icmd.Parameters.AddWithValue("@val2", (int)price);
                    icmd.Parameters.AddWithValue("@val3", (int)店家id);
                    icmd.Parameters.AddWithValue("@val4", image_name);
                    icmd.Parameters.AddWithValue("@val5", (int)selectedID);
                    int row = icmd.ExecuteNonQuery();
                    if (row > 0) { 
                        MessageBox.Show("修改品項成功");
                    }
                    else
                    {
                    MessageBox.Show("此品項名稱不存在");
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("請選擇要修改的品項");
            }
            
            
            讀取品項();
            產生圖片View();
        }


        private void btn刪除品項_Click(object sender, EventArgs e)
        {
            //panside效果
            panSide.Height = btn刪除品項.Height;
            panSide.Top = btn刪除品項.Top;
            panSide.BackColor = Color.FromArgb(238, 108, 77);
            //刪除店家 也要一併刪除品項  這邊寫成方法
            刪除品項();

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            selectedID = (int)listView1.SelectedItems[0].Tag; //藏在tag物件裡,因為是物件要做隱含轉換
            listviewId = (int)listView1.SelectedItems[0].ImageIndex;
            //FormDetail myFormDetail = new FormDetail();
            //myFormDetail.productID = selectedID;
            //myFormDetail.ShowDialog();
            if (selectedID >= 0)
            {
                顯示品項細項();
            }
            
        }

        void 顯示品項細項()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string tSQL = "select * from [item] where itemid = @SearchID";
            SqlCommand cmd = new SqlCommand(tSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", selectedID);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                //txtID.Text = productID.ToString();
                txt品項.Text = (string)reader["itemname"];
                txt價格.Text = reader["itemunitprice"].ToString();
                image_name = (string)reader["itemimage"];
                pic品項.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
        }
        
        void 產生圖片View()
        {
            listView1.Clear();
            listView1.View = View.LargeIcon;
            imageList1.ImageSize = new Size(160, 160);
            listView1.LargeImageList = imageList1;  //顯示imagelist的內容

            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();  //list圖示的顯示元件
                item.ImageIndex = i;  //圖片索引跟i對應
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listItemName[i]; //文字跟i對應
                item.Tag = listItemID[i];  //tag是一個隱藏資訊(object)
                listView1.Items.Add(item);
            }
        }
        void 刪除品項()
        {
            string s = txt品項.Text;
            Console.WriteLine(s);
            DialogResult R = MessageBox.Show("確定要刪除此品項?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (R == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                //檢查品項非空
                if (txt品項.Text == "")
                {
                    MessageBox.Show("請選擇要刪除的品項");
                }
                else
                {
                    string iSQL = @"delete item where itemid = @val1";
                    SqlCommand icmd = new SqlCommand(iSQL, con);
                    icmd.Parameters.AddWithValue("@val1", selectedID);
                    int row = icmd.ExecuteNonQuery();
                    if (row > 0)
                    {

                        MessageBox.Show("刪除品項成功");
                    }
                    else
                    {
                        MessageBox.Show("此品項名稱不存在");
                    }
                }
                con.Close();
                讀取品項();                
                產生圖片View();
                txt品項.Text = "";
                txt價格.Text = "";

            }
            else
            {//取消刪除
                MessageBox.Show("已取消刪除");
            }
        }
    }
}
