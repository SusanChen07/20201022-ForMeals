namespace WindowsFormsApp_LocalDB1009
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label6 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btn修改密碼 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label6.Location = new System.Drawing.Point(14, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 44);
            this.label6.TabIndex = 11;
            this.label6.Text = "帳號";
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(110, 115);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(285, 54);
            this.txt帳號.TabIndex = 20;
            this.txt帳號.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt帳號.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt帳號_MouseClick);
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(110, 196);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Size = new System.Drawing.Size(285, 54);
            this.txt密碼.TabIndex = 22;
            this.txt密碼.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt密碼.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt密碼_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(14, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 44);
            this.label1.TabIndex = 21;
            this.label1.Text = "密碼";
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn登入.FlatAppearance.BorderSize = 0;
            this.btn登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.ForeColor = System.Drawing.Color.White;
            this.btn登入.Location = new System.Drawing.Point(285, 269);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(110, 48);
            this.btn登入.TabIndex = 24;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btnX
            // 
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnX.Location = new System.Drawing.Point(855, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(68, 50);
            this.btnX.TabIndex = 25;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btn修改密碼
            // 
            this.btn修改密碼.BackColor = System.Drawing.Color.Pink;
            this.btn修改密碼.FlatAppearance.BorderSize = 0;
            this.btn修改密碼.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn修改密碼.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改密碼.ForeColor = System.Drawing.Color.White;
            this.btn修改密碼.Location = new System.Drawing.Point(110, 269);
            this.btn修改密碼.Name = "btn修改密碼";
            this.btn修改密碼.Size = new System.Drawing.Size(110, 48);
            this.btn修改密碼.TabIndex = 26;
            this.btn修改密碼.Text = "修改密碼";
            this.btn修改密碼.UseVisualStyleBackColor = false;
            this.btn修改密碼.Click += new System.EventHandler(this.btn修改密碼_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 71);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(92, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 104);
            this.label2.TabIndex = 28;
            this.label2.Text = "For meals";
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(422, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn修改密碼);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "登入";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btn修改密碼;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}