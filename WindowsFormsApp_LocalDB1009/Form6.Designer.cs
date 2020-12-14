namespace WindowsFormsApp_LocalDB1009
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lbl班級 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox學生 = new System.Windows.Forms.ComboBox();
            this.cbox值日生 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn設為值日生 = new System.Windows.Forms.Button();
            this.btn取消值日生 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl班級
            // 
            this.lbl班級.AutoSize = true;
            this.lbl班級.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl班級.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.lbl班級.Location = new System.Drawing.Point(10, 26);
            this.lbl班級.Name = "lbl班級";
            this.lbl班級.Size = new System.Drawing.Size(61, 30);
            this.lbl班級.TabIndex = 11;
            this.lbl班級.Text = "班級";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "學生：";
            // 
            // cbox學生
            // 
            this.cbox學生.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbox學生.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox學生.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox學生.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.cbox學生.FormattingEnabled = true;
            this.cbox學生.Location = new System.Drawing.Point(121, 78);
            this.cbox學生.Name = "cbox學生";
            this.cbox學生.Size = new System.Drawing.Size(161, 32);
            this.cbox學生.TabIndex = 14;
            // 
            // cbox值日生
            // 
            this.cbox值日生.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbox值日生.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox值日生.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox值日生.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.cbox值日生.FormattingEnabled = true;
            this.cbox值日生.Location = new System.Drawing.Point(121, 122);
            this.cbox值日生.Name = "cbox值日生";
            this.cbox值日生.Size = new System.Drawing.Size(161, 32);
            this.cbox值日生.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "查看值日生";
            // 
            // btn設為值日生
            // 
            this.btn設為值日生.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn設為值日生.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn設為值日生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn設為值日生.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn設為值日生.Image = ((System.Drawing.Image)(resources.GetObject("btn設為值日生.Image")));
            this.btn設為值日生.Location = new System.Drawing.Point(12, 175);
            this.btn設為值日生.Name = "btn設為值日生";
            this.btn設為值日生.Size = new System.Drawing.Size(270, 50);
            this.btn設為值日生.TabIndex = 25;
            this.btn設為值日生.Text = "設為值日生";
            this.btn設為值日生.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn設為值日生.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn設為值日生.UseVisualStyleBackColor = true;
            this.btn設為值日生.Click += new System.EventHandler(this.btn設為值日生_Click);
            // 
            // btn取消值日生
            // 
            this.btn取消值日生.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn取消值日生.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn取消值日生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消值日生.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn取消值日生.Image = ((System.Drawing.Image)(resources.GetObject("btn取消值日生.Image")));
            this.btn取消值日生.Location = new System.Drawing.Point(12, 231);
            this.btn取消值日生.Name = "btn取消值日生";
            this.btn取消值日生.Size = new System.Drawing.Size(270, 50);
            this.btn取消值日生.TabIndex = 26;
            this.btn取消值日生.Text = "取消值日生";
            this.btn取消值日生.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn取消值日生.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn取消值日生.UseVisualStyleBackColor = true;
            this.btn取消值日生.Click += new System.EventHandler(this.btn取消值日生_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(294, 301);
            this.Controls.Add(this.btn取消值日生);
            this.Controls.Add(this.btn設為值日生);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox值日生);
            this.Controls.Add(this.cbox學生);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl班級);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form6";
            this.Text = "設定值日生";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl班級;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox學生;
        private System.Windows.Forms.ComboBox cbox值日生;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn設為值日生;
        private System.Windows.Forms.Button btn取消值日生;
    }
}