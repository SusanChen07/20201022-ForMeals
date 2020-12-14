namespace WindowsFormsApp_LocalDB1009
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl統計標題 = new System.Windows.Forms.Label();
            this.dgv統計 = new System.Windows.Forms.DataGridView();
            this.btn存檔 = new System.Windows.Forms.Button();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.lbl日期 = new System.Windows.Forms.Label();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.dgv搜尋 = new System.Windows.Forms.DataGridView();
            this.cbox搜尋 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn搜尋 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv統計)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv搜尋)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl統計標題
            // 
            this.lbl統計標題.AutoSize = true;
            this.lbl統計標題.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl統計標題.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.lbl統計標題.Location = new System.Drawing.Point(13, 30);
            this.lbl統計標題.Name = "lbl統計標題";
            this.lbl統計標題.Size = new System.Drawing.Size(133, 37);
            this.lbl統計標題.TabIndex = 11;
            this.lbl統計標題.Text = "統計列表";
            // 
            // dgv統計
            // 
            this.dgv統計.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.dgv統計.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv統計.Location = new System.Drawing.Point(20, 161);
            this.dgv統計.Name = "dgv統計";
            this.dgv統計.RowTemplate.Height = 24;
            this.dgv統計.Size = new System.Drawing.Size(409, 328);
            this.dgv統計.TabIndex = 12;
            // 
            // btn存檔
            // 
            this.btn存檔.FlatAppearance.BorderSize = 0;
            this.btn存檔.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn存檔.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn存檔.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn存檔.Image = ((System.Drawing.Image)(resources.GetObject("btn存檔.Image")));
            this.btn存檔.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn存檔.Location = new System.Drawing.Point(262, 104);
            this.btn存檔.Name = "btn存檔";
            this.btn存檔.Size = new System.Drawing.Size(167, 41);
            this.btn存檔.TabIndex = 16;
            this.btn存檔.Text = "存檔";
            this.btn存檔.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn存檔.UseVisualStyleBackColor = true;
            this.btn存檔.Click += new System.EventHandler(this.btn存檔_Click);
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.lbl總價.Location = new System.Drawing.Point(277, 32);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(133, 35);
            this.lbl總價.TabIndex = 18;
            this.lbl總價.Text = "價錢:  0元";
            // 
            // lbl日期
            // 
            this.lbl日期.AutoSize = true;
            this.lbl日期.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl日期.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.lbl日期.Location = new System.Drawing.Point(15, 113);
            this.lbl日期.Name = "lbl日期";
            this.lbl日期.Size = new System.Drawing.Size(96, 27);
            this.lbl日期.TabIndex = 19;
            this.lbl日期.Text = "訂購日期";
            this.lbl日期.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt搜尋
            // 
            this.txt搜尋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txt搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋.Location = new System.Drawing.Point(690, 111);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(176, 33);
            this.txt搜尋.TabIndex = 32;
            // 
            // dgv搜尋
            // 
            this.dgv搜尋.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.dgv搜尋.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv搜尋.Location = new System.Drawing.Point(488, 161);
            this.dgv搜尋.Name = "dgv搜尋";
            this.dgv搜尋.RowTemplate.Height = 24;
            this.dgv搜尋.Size = new System.Drawing.Size(408, 328);
            this.dgv搜尋.TabIndex = 34;
            // 
            // cbox搜尋
            // 
            this.cbox搜尋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.cbox搜尋.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox搜尋.FormattingEnabled = true;
            this.cbox搜尋.Location = new System.Drawing.Point(690, 61);
            this.cbox搜尋.Name = "cbox搜尋";
            this.cbox搜尋.Size = new System.Drawing.Size(176, 32);
            this.cbox搜尋.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(481, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "搜尋訂單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(685, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "搜尋關鍵字";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn搜尋
            // 
            this.btn搜尋.FlatAppearance.BorderSize = 0;
            this.btn搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn搜尋.Image = ((System.Drawing.Image)(resources.GetObject("btn搜尋.Image")));
            this.btn搜尋.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn搜尋.Location = new System.Drawing.Point(487, 104);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(167, 41);
            this.btn搜尋.TabIndex = 38;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(924, 501);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox搜尋);
            this.Controls.Add(this.dgv搜尋);
            this.Controls.Add(this.lbl日期);
            this.Controls.Add(this.txt搜尋);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.btn存檔);
            this.Controls.Add(this.dgv統計);
            this.Controls.Add(this.lbl統計標題);
            this.Name = "Form2";
            this.Text = "訂購單";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv統計)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv搜尋)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl統計標題;
        private System.Windows.Forms.DataGridView dgv統計;
        private System.Windows.Forms.Button btn存檔;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Label lbl日期;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.DataGridView dgv搜尋;
        private System.Windows.Forms.ComboBox cbox搜尋;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn搜尋;
    }
}