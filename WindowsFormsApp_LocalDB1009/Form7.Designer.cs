namespace WindowsFormsApp_LocalDB1009
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.lbl班級 = new System.Windows.Forms.Label();
            this.btn取消管理員 = new System.Windows.Forms.Button();
            this.btn設為管理員 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox管理員 = new System.Windows.Forms.ComboBox();
            this.cbox學生 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbl班級.TabIndex = 12;
            this.lbl班級.Text = "班級";
            // 
            // btn取消管理員
            // 
            this.btn取消管理員.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn取消管理員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn取消管理員.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消管理員.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn取消管理員.Image = ((System.Drawing.Image)(resources.GetObject("btn取消管理員.Image")));
            this.btn取消管理員.Location = new System.Drawing.Point(12, 231);
            this.btn取消管理員.Name = "btn取消管理員";
            this.btn取消管理員.Size = new System.Drawing.Size(270, 50);
            this.btn取消管理員.TabIndex = 32;
            this.btn取消管理員.Text = "取消管理員";
            this.btn取消管理員.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn取消管理員.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn取消管理員.UseVisualStyleBackColor = true;
            this.btn取消管理員.Click += new System.EventHandler(this.btn取消管理員_Click);
            // 
            // btn設為管理員
            // 
            this.btn設為管理員.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn設為管理員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn設為管理員.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn設為管理員.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btn設為管理員.Image = ((System.Drawing.Image)(resources.GetObject("btn設為管理員.Image")));
            this.btn設為管理員.Location = new System.Drawing.Point(12, 175);
            this.btn設為管理員.Name = "btn設為管理員";
            this.btn設為管理員.Size = new System.Drawing.Size(270, 50);
            this.btn設為管理員.TabIndex = 31;
            this.btn設為管理員.Text = "設為管理員";
            this.btn設為管理員.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn設為管理員.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn設為管理員.UseVisualStyleBackColor = true;
            this.btn設為管理員.Click += new System.EventHandler(this.btn設為管理員_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "查看管理員";
            // 
            // cbox管理員
            // 
            this.cbox管理員.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cbox管理員.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox管理員.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox管理員.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.cbox管理員.FormattingEnabled = true;
            this.cbox管理員.Location = new System.Drawing.Point(121, 122);
            this.cbox管理員.Name = "cbox管理員";
            this.cbox管理員.Size = new System.Drawing.Size(161, 32);
            this.cbox管理員.TabIndex = 29;
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
            this.cbox學生.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "學生：";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(294, 301);
            this.Controls.Add(this.btn取消管理員);
            this.Controls.Add(this.btn設為管理員);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox管理員);
            this.Controls.Add(this.cbox學生);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl班級);
            this.Name = "Form7";
            this.Text = "設定管理員";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl班級;
        private System.Windows.Forms.Button btn取消管理員;
        private System.Windows.Forms.Button btn設為管理員;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox管理員;
        private System.Windows.Forms.ComboBox cbox學生;
        private System.Windows.Forms.Label label2;
    }
}