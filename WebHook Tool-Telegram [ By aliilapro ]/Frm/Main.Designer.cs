namespace WebHook_Tool_Telegram___By_aliilapro__.Frm
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txt_token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.h_token = new System.Windows.Forms.CheckBox();
            this.h_url = new System.Windows.Forms.CheckBox();
            this.r_set = new System.Windows.Forms.RadioButton();
            this.r_del = new System.Windows.Forms.RadioButton();
            this.r_info = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.txtlog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_token
            // 
            this.txt_token.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_token.Location = new System.Drawing.Point(4, 22);
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(401, 22);
            this.txt_token.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL :";
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Location = new System.Drawing.Point(4, 70);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(401, 22);
            this.txt_url.TabIndex = 2;
            // 
            // h_token
            // 
            this.h_token.AutoSize = true;
            this.h_token.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h_token.Location = new System.Drawing.Point(357, 2);
            this.h_token.Name = "h_token";
            this.h_token.Size = new System.Drawing.Size(49, 18);
            this.h_token.TabIndex = 4;
            this.h_token.Text = "Hide";
            this.h_token.UseVisualStyleBackColor = true;
            this.h_token.CheckedChanged += new System.EventHandler(this.h_token_CheckedChanged);
            // 
            // h_url
            // 
            this.h_url.AutoSize = true;
            this.h_url.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h_url.Location = new System.Drawing.Point(357, 52);
            this.h_url.Name = "h_url";
            this.h_url.Size = new System.Drawing.Size(49, 18);
            this.h_url.TabIndex = 5;
            this.h_url.Text = "Hide";
            this.h_url.UseVisualStyleBackColor = true;
            this.h_url.CheckedChanged += new System.EventHandler(this.h_url_CheckedChanged);
            // 
            // r_set
            // 
            this.r_set.AutoSize = true;
            this.r_set.Checked = true;
            this.r_set.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_set.Location = new System.Drawing.Point(12, 98);
            this.r_set.Name = "r_set";
            this.r_set.Size = new System.Drawing.Size(106, 21);
            this.r_set.TabIndex = 6;
            this.r_set.TabStop = true;
            this.r_set.Text = "Set WebHook";
            this.r_set.UseVisualStyleBackColor = true;
            this.r_set.CheckedChanged += new System.EventHandler(this.r_set_CheckedChanged);
            // 
            // r_del
            // 
            this.r_del.AutoSize = true;
            this.r_del.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_del.Location = new System.Drawing.Point(150, 98);
            this.r_del.Name = "r_del";
            this.r_del.Size = new System.Drawing.Size(125, 21);
            this.r_del.TabIndex = 7;
            this.r_del.Text = "Delete WebHook";
            this.r_del.UseVisualStyleBackColor = true;
            // 
            // r_info
            // 
            this.r_info.AutoSize = true;
            this.r_info.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_info.Location = new System.Drawing.Point(310, 98);
            this.r_info.Name = "r_info";
            this.r_info.Size = new System.Drawing.Size(87, 21);
            this.r_info.TabIndex = 8;
            this.r_info.Text = "Token Info";
            this.r_info.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(58, 125);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(294, 31);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txtlog
            // 
            this.txtlog.BackColor = System.Drawing.Color.Black;
            this.txtlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlog.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlog.ForeColor = System.Drawing.Color.Lime;
            this.txtlog.Location = new System.Drawing.Point(4, 162);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(401, 164);
            this.txtlog.TabIndex = 0;
            this.txtlog.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 332);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.r_info);
            this.Controls.Add(this.r_del);
            this.Controls.Add(this.r_set);
            this.Controls.Add(this.h_url);
            this.Controls.Add(this.h_token);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_token);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebHook Tool-Telegram [ By aliilapro ]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.CheckBox h_token;
        private System.Windows.Forms.CheckBox h_url;
        private System.Windows.Forms.RadioButton r_set;
        private System.Windows.Forms.RadioButton r_del;
        private System.Windows.Forms.RadioButton r_info;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.RichTextBox txtlog;
    }
}