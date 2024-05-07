namespace Kütüphane
{
    partial class frm_addBookReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addBookReg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.cb_authors = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_pages = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayfa sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kayıt tarihi:";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(188, 139);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "ONAYLA";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(107, 139);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "IPTAL ET";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_bookName
            // 
            this.txt_bookName.Location = new System.Drawing.Point(91, 12);
            this.txt_bookName.MaxLength = 50;
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(172, 20);
            this.txt_bookName.TabIndex = 6;
            // 
            // cb_authors
            // 
            this.cb_authors.FormattingEnabled = true;
            this.cb_authors.Location = new System.Drawing.Point(91, 64);
            this.cb_authors.Name = "cb_authors";
            this.cb_authors.Size = new System.Drawing.Size(172, 21);
            this.cb_authors.TabIndex = 8;
            this.cb_authors.SelectedIndexChanged += new System.EventHandler(this.cb_authors_SelectedIndexChanged);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(91, 92);
            this.dtp_date.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtp_date.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(172, 20);
            this.dtp_date.TabIndex = 9;
            // 
            // txt_pages
            // 
            this.txt_pages.Location = new System.Drawing.Point(91, 38);
            this.txt_pages.Mask = "0000";
            this.txt_pages.Name = "txt_pages";
            this.txt_pages.Size = new System.Drawing.Size(172, 20);
            this.txt_pages.TabIndex = 10;
            // 
            // frm_addBookReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(275, 174);
            this.Controls.Add(this.txt_pages);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cb_authors);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_addBookReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addBookReg";
            this.Load += new System.EventHandler(this.frm_addBookReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.ComboBox cb_authors;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.MaskedTextBox txt_pages;
    }
}