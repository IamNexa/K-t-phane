using System.Windows.Forms;

namespace Kütüphane
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.dgw_show = new System.Windows.Forms.DataGridView();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_deleteAuthor = new System.Windows.Forms.Button();
            this.btn_deleteBook = new System.Windows.Forms.Button();
            this.btn_addAuthor = new System.Windows.Forms.Button();
            this.btn_addBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_show)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_show
            // 
            this.dgw_show.AllowUserToAddRows = false;
            this.dgw_show.AllowUserToDeleteRows = false;
            this.dgw_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_show.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgw_show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_show.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgw_show.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_show.GridColor = System.Drawing.Color.LightGray;
            this.dgw_show.Location = new System.Drawing.Point(-1, 0);
            this.dgw_show.Name = "dgw_show";
            this.dgw_show.ReadOnly = true;
            this.dgw_show.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgw_show.RowHeadersVisible = false;
            this.dgw_show.RowHeadersWidth = 10;
            this.dgw_show.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgw_show.RowTemplate.Height = 40;
            this.dgw_show.RowTemplate.ReadOnly = true;
            this.dgw_show.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgw_show.Size = new System.Drawing.Size(730, 491);
            this.dgw_show.TabIndex = 99;
            // 
            // txt_find
            // 
            this.txt_find.BackColor = System.Drawing.SystemColors.Window;
            this.txt_find.Enabled = false;
            this.txt_find.Location = new System.Drawing.Point(3, 50);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(247, 20);
            this.txt_find.TabIndex = 1;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // cb_filter
            // 
            this.cb_filter.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Kitap numarasına göre",
            "Kitap adına göre",
            "Sayfa sayısına göre",
            "Yazar numarasına göre",
            "Yazara göre",
            "Kitap kayıt tarihine göre"});
            this.cb_filter.Location = new System.Drawing.Point(3, 23);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(247, 21);
            this.cb_filter.TabIndex = 3;
            this.cb_filter.Text = "Lütfen bir filtreleme türü seçin...";
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_listele_SelectedIndexChanged);
            this.cb_filter.Enter += new System.EventHandler(this.cb_listele_Enter);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(116, 5);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(28, 15);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "BUL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.btn_deleteAuthor);
            this.panel1.Controls.Add(this.btn_deleteBook);
            this.panel1.Controls.Add(this.btn_addAuthor);
            this.panel1.Controls.Add(this.btn_addBook);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.cb_filter);
            this.panel1.Controls.Add(this.txt_find);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(732, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 491);
            this.panel1.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(99, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 15);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "İŞLEMLER";
            // 
            // btn_deleteAuthor
            // 
            this.btn_deleteAuthor.Location = new System.Drawing.Point(4, 201);
            this.btn_deleteAuthor.Name = "btn_deleteAuthor";
            this.btn_deleteAuthor.Size = new System.Drawing.Size(246, 23);
            this.btn_deleteAuthor.TabIndex = 7;
            this.btn_deleteAuthor.Text = "YAZAR SİL";
            this.btn_deleteAuthor.UseVisualStyleBackColor = true;
            this.btn_deleteAuthor.Click += new System.EventHandler(this.btn_deleteAuthor_Click);
            // 
            // btn_deleteBook
            // 
            this.btn_deleteBook.Location = new System.Drawing.Point(4, 172);
            this.btn_deleteBook.Name = "btn_deleteBook";
            this.btn_deleteBook.Size = new System.Drawing.Size(246, 23);
            this.btn_deleteBook.TabIndex = 6;
            this.btn_deleteBook.Text = "KİTAP SİL";
            this.btn_deleteBook.UseVisualStyleBackColor = true;
            this.btn_deleteBook.Click += new System.EventHandler(this.btn_deleteBook_Click);
            // 
            // btn_addAuthor
            // 
            this.btn_addAuthor.Location = new System.Drawing.Point(4, 143);
            this.btn_addAuthor.Name = "btn_addAuthor";
            this.btn_addAuthor.Size = new System.Drawing.Size(246, 23);
            this.btn_addAuthor.TabIndex = 5;
            this.btn_addAuthor.Text = "YAZAR EKLE";
            this.btn_addAuthor.UseVisualStyleBackColor = true;
            this.btn_addAuthor.Click += new System.EventHandler(this.btn_addAuthor_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(4, 114);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(246, 23);
            this.btn_addBook.TabIndex = 4;
            this.btn_addBook.Text = "KİTAP EKLE";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kütüphane.Properties.Resources.main_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgw_show);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_show;
        private TextBox txt_find;
        private ComboBox cb_filter;
        private Label lbl1;
        private Panel panel1;
        private Label lbl2;
        private Button btn_deleteAuthor;
        private Button btn_deleteBook;
        private Button btn_addAuthor;
        private Button btn_addBook;
    }
}

