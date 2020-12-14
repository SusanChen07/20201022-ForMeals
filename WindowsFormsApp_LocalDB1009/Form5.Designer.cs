namespace WindowsFormsApp_LocalDB1009
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.btn刪除學生 = new System.Windows.Forms.Button();
            this.btn修改學生 = new System.Windows.Forms.Button();
            this.btn刪除班級 = new System.Windows.Forms.Button();
            this.btn修改班級 = new System.Windows.Forms.Button();
            this.btn儲存班級 = new System.Windows.Forms.Button();
            this.btn儲存學生 = new System.Windows.Forms.Button();
            this.btn新增學生 = new System.Windows.Forms.Button();
            this.btn新增班級 = new System.Windows.Forms.Button();
            this.panSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt班級 = new System.Windows.Forms.TextBox();
            this.txt學號 = new System.Windows.Forms.TextBox();
            this.txt學生 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbox學生 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox班級 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn管理員 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "管理班級與學生";
            // 
            // btn刪除學生
            // 
            this.btn刪除學生.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btn刪除學生.FlatAppearance.BorderSize = 0;
            this.btn刪除學生.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn刪除學生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除學生.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btn刪除學生.Image = ((System.Drawing.Image)(resources.GetObject("btn刪除學生.Image")));
            this.btn刪除學生.Location = new System.Drawing.Point(8, 427);
            this.btn刪除學生.Name = "btn刪除學生";
            this.btn刪除學生.Size = new System.Drawing.Size(212, 50);
            this.btn刪除學生.TabIndex = 43;
            this.btn刪除學生.Text = "刪除學生";
            this.btn刪除學生.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn刪除學生.UseVisualStyleBackColor = true;
            this.btn刪除學生.Click += new System.EventHandler(this.btn刪除學生_Click);
            // 
            // btn修改學生
            // 
            this.btn修改學生.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btn修改學生.FlatAppearance.BorderSize = 0;
            this.btn修改學生.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn修改學生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改學生.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btn修改學生.Image = ((System.Drawing.Image)(resources.GetObject("btn修改學生.Image")));
            this.btn修改學生.Location = new System.Drawing.Point(8, 375);
            this.btn修改學生.Name = "btn修改學生";
            this.btn修改學生.Size = new System.Drawing.Size(212, 50);
            this.btn修改學生.TabIndex = 42;
            this.btn修改學生.Text = "修改學生";
            this.btn修改學生.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn修改學生.UseVisualStyleBackColor = true;
            this.btn修改學生.Click += new System.EventHandler(this.btn修改學生_Click);
            // 
            // btn刪除班級
            // 
            this.btn刪除班級.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btn刪除班級.FlatAppearance.BorderSize = 0;
            this.btn刪除班級.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn刪除班級.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除班級.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn刪除班級.Image = ((System.Drawing.Image)(resources.GetObject("btn刪除班級.Image")));
            this.btn刪除班級.Location = new System.Drawing.Point(8, 219);
            this.btn刪除班級.Name = "btn刪除班級";
            this.btn刪除班級.Size = new System.Drawing.Size(212, 50);
            this.btn刪除班級.TabIndex = 41;
            this.btn刪除班級.Text = "刪除班級";
            this.btn刪除班級.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn刪除班級.UseVisualStyleBackColor = true;
            this.btn刪除班級.Click += new System.EventHandler(this.btn刪除班級_Click);
            // 
            // btn修改班級
            // 
            this.btn修改班級.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btn修改班級.FlatAppearance.BorderSize = 0;
            this.btn修改班級.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn修改班級.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改班級.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn修改班級.Image = ((System.Drawing.Image)(resources.GetObject("btn修改班級.Image")));
            this.btn修改班級.Location = new System.Drawing.Point(8, 167);
            this.btn修改班級.Name = "btn修改班級";
            this.btn修改班級.Size = new System.Drawing.Size(212, 50);
            this.btn修改班級.TabIndex = 40;
            this.btn修改班級.Text = "修改班級";
            this.btn修改班級.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn修改班級.UseVisualStyleBackColor = true;
            this.btn修改班級.Click += new System.EventHandler(this.btn修改班級_Click);
            // 
            // btn儲存班級
            // 
            this.btn儲存班級.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btn儲存班級.FlatAppearance.BorderSize = 0;
            this.btn儲存班級.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn儲存班級.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存班級.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn儲存班級.Image = ((System.Drawing.Image)(resources.GetObject("btn儲存班級.Image")));
            this.btn儲存班級.Location = new System.Drawing.Point(8, 115);
            this.btn儲存班級.Name = "btn儲存班級";
            this.btn儲存班級.Size = new System.Drawing.Size(212, 50);
            this.btn儲存班級.TabIndex = 39;
            this.btn儲存班級.Text = "儲存班級";
            this.btn儲存班級.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn儲存班級.UseVisualStyleBackColor = true;
            this.btn儲存班級.Click += new System.EventHandler(this.btn儲存班級_Click);
            // 
            // btn儲存學生
            // 
            this.btn儲存學生.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btn儲存學生.FlatAppearance.BorderSize = 0;
            this.btn儲存學生.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn儲存學生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存學生.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btn儲存學生.Image = ((System.Drawing.Image)(resources.GetObject("btn儲存學生.Image")));
            this.btn儲存學生.Location = new System.Drawing.Point(8, 323);
            this.btn儲存學生.Name = "btn儲存學生";
            this.btn儲存學生.Size = new System.Drawing.Size(212, 50);
            this.btn儲存學生.TabIndex = 36;
            this.btn儲存學生.Text = "儲存學生";
            this.btn儲存學生.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn儲存學生.UseVisualStyleBackColor = true;
            this.btn儲存學生.Click += new System.EventHandler(this.btn儲存學生_Click);
            // 
            // btn新增學生
            // 
            this.btn新增學生.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btn新增學生.FlatAppearance.BorderSize = 0;
            this.btn新增學生.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn新增學生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增學生.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btn新增學生.Image = ((System.Drawing.Image)(resources.GetObject("btn新增學生.Image")));
            this.btn新增學生.Location = new System.Drawing.Point(8, 271);
            this.btn新增學生.Name = "btn新增學生";
            this.btn新增學生.Size = new System.Drawing.Size(212, 50);
            this.btn新增學生.TabIndex = 35;
            this.btn新增學生.Text = "新增學生";
            this.btn新增學生.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn新增學生.UseVisualStyleBackColor = true;
            this.btn新增學生.Click += new System.EventHandler(this.btn新增學生_Click);
            // 
            // btn新增班級
            // 
            this.btn新增班級.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.btn新增班級.FlatAppearance.BorderSize = 0;
            this.btn新增班級.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn新增班級.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增班級.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn新增班級.Image = ((System.Drawing.Image)(resources.GetObject("btn新增班級.Image")));
            this.btn新增班級.Location = new System.Drawing.Point(8, 63);
            this.btn新增班級.Name = "btn新增班級";
            this.btn新增班級.Size = new System.Drawing.Size(212, 50);
            this.btn新增班級.TabIndex = 34;
            this.btn新增班級.Text = "新增班級";
            this.btn新增班級.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn新增班級.UseVisualStyleBackColor = true;
            this.btn新增班級.Click += new System.EventHandler(this.btn新增班級_Click);
            // 
            // panSide
            // 
            this.panSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.panSide.Location = new System.Drawing.Point(0, 63);
            this.panSide.Name = "panSide";
            this.panSide.Size = new System.Drawing.Size(10, 50);
            this.panSide.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 62);
            this.panel1.TabIndex = 37;
            // 
            // txt班級
            // 
            this.txt班級.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txt班級.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt班級.Location = new System.Drawing.Point(304, 102);
            this.txt班級.Name = "txt班級";
            this.txt班級.Size = new System.Drawing.Size(176, 39);
            this.txt班級.TabIndex = 50;
            // 
            // txt學號
            // 
            this.txt學號.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txt學號.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt學號.Location = new System.Drawing.Point(304, 230);
            this.txt學號.Name = "txt學號";
            this.txt學號.Size = new System.Drawing.Size(176, 39);
            this.txt學號.TabIndex = 48;
            // 
            // txt學生
            // 
            this.txt學生.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txt學生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt學生.Location = new System.Drawing.Point(304, 168);
            this.txt學生.Name = "txt學生";
            this.txt學生.Size = new System.Drawing.Size(176, 39);
            this.txt學生.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label3.Location = new System.Drawing.Point(233, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 46;
            this.label3.Text = "學號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(233, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "學生";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label5.Location = new System.Drawing.Point(233, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 44;
            this.label5.Text = "班級";
            // 
            // txt密碼
            // 
            this.txt密碼.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(304, 300);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Size = new System.Drawing.Size(176, 39);
            this.txt密碼.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label4.Location = new System.Drawing.Point(233, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 51;
            this.label4.Text = "密碼";
            // 
            // lbox學生
            // 
            this.lbox學生.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.lbox學生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox學生.FormattingEnabled = true;
            this.lbox學生.ItemHeight = 30;
            this.lbox學生.Location = new System.Drawing.Point(533, 103);
            this.lbox學生.Name = "lbox學生";
            this.lbox學生.Size = new System.Drawing.Size(367, 334);
            this.lbox學生.TabIndex = 53;
            this.lbox學生.SelectedIndexChanged += new System.EventHandler(this.lbox學生_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label6.Location = new System.Drawing.Point(537, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 34);
            this.label6.TabIndex = 54;
            this.label6.Text = "班級";
            // 
            // cbox班級
            // 
            this.cbox班級.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.cbox班級.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox班級.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox班級.FormattingEnabled = true;
            this.cbox班級.Location = new System.Drawing.Point(612, 13);
            this.cbox班級.Name = "cbox班級";
            this.cbox班級.Size = new System.Drawing.Size(178, 38);
            this.cbox班級.TabIndex = 55;
            this.cbox班級.SelectedIndexChanged += new System.EventHandler(this.cbox班級_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label7.Location = new System.Drawing.Point(309, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 37);
            this.label7.TabIndex = 56;
            this.label7.Text = "查詢與編輯";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label8.Location = new System.Drawing.Point(537, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 35);
            this.label8.TabIndex = 57;
            this.label8.Text = "學號";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label9.Location = new System.Drawing.Point(668, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 35);
            this.label9.TabIndex = 58;
            this.label9.Text = "學生";
            // 
            // btn管理員
            // 
            this.btn管理員.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btn管理員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn管理員.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn管理員.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btn管理員.Image = ((System.Drawing.Image)(resources.GetObject("btn管理員.Image")));
            this.btn管理員.Location = new System.Drawing.Point(238, 375);
            this.btn管理員.Name = "btn管理員";
            this.btn管理員.Size = new System.Drawing.Size(242, 50);
            this.btn管理員.TabIndex = 60;
            this.btn管理員.Text = "設為管理員";
            this.btn管理員.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn管理員.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn管理員.UseVisualStyleBackColor = true;
            this.btn管理員.Click += new System.EventHandler(this.btn管理員_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(924, 501);
            this.Controls.Add(this.btn管理員);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox班級);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbox學生);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt班級);
            this.Controls.Add(this.txt學號);
            this.Controls.Add(this.txt學生);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn刪除學生);
            this.Controls.Add(this.btn修改學生);
            this.Controls.Add(this.btn刪除班級);
            this.Controls.Add(this.btn修改班級);
            this.Controls.Add(this.btn儲存班級);
            this.Controls.Add(this.btn儲存學生);
            this.Controls.Add(this.btn新增學生);
            this.Controls.Add(this.btn新增班級);
            this.Controls.Add(this.panSide);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "管理班級與學生";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn刪除學生;
        private System.Windows.Forms.Button btn修改學生;
        private System.Windows.Forms.Button btn刪除班級;
        private System.Windows.Forms.Button btn修改班級;
        private System.Windows.Forms.Button btn儲存班級;
        private System.Windows.Forms.Button btn儲存學生;
        private System.Windows.Forms.Button btn新增學生;
        private System.Windows.Forms.Button btn新增班級;
        private System.Windows.Forms.Panel panSide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt班級;
        private System.Windows.Forms.TextBox txt學號;
        private System.Windows.Forms.TextBox txt學生;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbox學生;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox班級;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn管理員;
    }
}