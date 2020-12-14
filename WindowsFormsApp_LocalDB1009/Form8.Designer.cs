namespace WindowsFormsApp_LocalDB1009
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.lbl班級 = new System.Windows.Forms.Label();
            this.txt密碼1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt密碼2 = new System.Windows.Forms.TextBox();
            this.btn修改密碼 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl班級
            // 
            this.lbl班級.AutoSize = true;
            this.lbl班級.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl班級.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.lbl班級.Location = new System.Drawing.Point(65, 26);
            this.lbl班級.Name = "lbl班級";
            this.lbl班級.Size = new System.Drawing.Size(157, 30);
            this.lbl班級.TabIndex = 13;
            this.lbl班級.Text = "請輸入新密碼";
            // 
            // txt密碼1
            // 
            this.txt密碼1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txt密碼1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼1.Location = new System.Drawing.Point(59, 69);
            this.txt密碼1.Name = "txt密碼1";
            this.txt密碼1.Size = new System.Drawing.Size(176, 39);
            this.txt密碼1.TabIndex = 48;
            this.txt密碼1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(65, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 49;
            this.label1.Text = "請再輸入一次";
            // 
            // txt密碼2
            // 
            this.txt密碼2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.txt密碼2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼2.Location = new System.Drawing.Point(59, 164);
            this.txt密碼2.Name = "txt密碼2";
            this.txt密碼2.Size = new System.Drawing.Size(176, 39);
            this.txt密碼2.TabIndex = 50;
            this.txt密碼2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn修改密碼
            // 
            this.btn修改密碼.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn修改密碼.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn修改密碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改密碼.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn修改密碼.Image = ((System.Drawing.Image)(resources.GetObject("btn修改密碼.Image")));
            this.btn修改密碼.Location = new System.Drawing.Point(12, 226);
            this.btn修改密碼.Name = "btn修改密碼";
            this.btn修改密碼.Size = new System.Drawing.Size(270, 50);
            this.btn修改密碼.TabIndex = 51;
            this.btn修改密碼.Text = "修改密碼";
            this.btn修改密碼.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn修改密碼.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn修改密碼.UseVisualStyleBackColor = true;
            this.btn修改密碼.Click += new System.EventHandler(this.btn修改密碼_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(294, 301);
            this.Controls.Add(this.btn修改密碼);
            this.Controls.Add(this.txt密碼2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt密碼1);
            this.Controls.Add(this.lbl班級);
            this.Name = "Form8";
            this.Text = "修改密碼";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl班級;
        private System.Windows.Forms.TextBox txt密碼1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt密碼2;
        private System.Windows.Forms.Button btn修改密碼;
    }
}