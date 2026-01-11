namespace Library_Catalogue_App
{
    partial class Form_LibraryCatalogue
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
            this.lbl_catalogue = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.dgv_booklist = new System.Windows.Forms.DataGridView();
            this.lbl_booktitle = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtbox_year = new System.Windows.Forms.TextBox();
            this.txtbox_author = new System.Windows.Forms.TextBox();
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booklist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_catalogue
            // 
            this.lbl_catalogue.AutoSize = true;
            this.lbl_catalogue.Location = new System.Drawing.Point(15, 18);
            this.lbl_catalogue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_catalogue.Name = "lbl_catalogue";
            this.lbl_catalogue.Size = new System.Drawing.Size(228, 31);
            this.lbl_catalogue.TabIndex = 0;
            this.lbl_catalogue.Text = "Library Catalogue";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(751, 18);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 36);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_booklist
            // 
            this.dgv_booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_booklist.Location = new System.Drawing.Point(287, 87);
            this.dgv_booklist.Name = "dgv_booklist";
            this.dgv_booklist.RowHeadersWidth = 51;
            this.dgv_booklist.RowTemplate.Height = 24;
            this.dgv_booklist.Size = new System.Drawing.Size(564, 362);
            this.dgv_booklist.TabIndex = 18;
            this.dgv_booklist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_booklist_CellClick);
            // 
            // lbl_booktitle
            // 
            this.lbl_booktitle.AutoSize = true;
            this.lbl_booktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booktitle.Location = new System.Drawing.Point(25, 96);
            this.lbl_booktitle.Name = "lbl_booktitle";
            this.lbl_booktitle.Size = new System.Drawing.Size(55, 25);
            this.lbl_booktitle.TabIndex = 19;
            this.lbl_booktitle.Text = "Title:";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(25, 230);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(59, 25);
            this.lbl_year.TabIndex = 20;
            this.lbl_year.Text = "Year:";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.Location = new System.Drawing.Point(25, 165);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(76, 25);
            this.lbl_Author.TabIndex = 21;
            this.lbl_Author.Text = "Author:";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(26, 306);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 38);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtbox_year
            // 
            this.txtbox_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_year.Location = new System.Drawing.Point(26, 258);
            this.txtbox_year.Name = "txtbox_year";
            this.txtbox_year.Size = new System.Drawing.Size(217, 24);
            this.txtbox_year.TabIndex = 25;
            // 
            // txtbox_author
            // 
            this.txtbox_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_author.Location = new System.Drawing.Point(26, 193);
            this.txtbox_author.Name = "txtbox_author";
            this.txtbox_author.Size = new System.Drawing.Size(217, 24);
            this.txtbox_author.TabIndex = 26;
            // 
            // txtbox_title
            // 
            this.txtbox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_title.Location = new System.Drawing.Point(26, 124);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(217, 24);
            this.txtbox_title.TabIndex = 27;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(149, 306);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 38);
            this.btn_clear.TabIndex = 32;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form_LibraryCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 476);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txtbox_title);
            this.Controls.Add(this.txtbox_author);
            this.Controls.Add(this.txtbox_year);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_booktitle);
            this.Controls.Add(this.dgv_booklist);
            this.Controls.Add(this.lbl_catalogue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_LibraryCatalogue";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_catalogue;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_booklist;
        private System.Windows.Forms.Label lbl_booktitle;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtbox_year;
        private System.Windows.Forms.TextBox txtbox_author;
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.Button btn_clear;
    }
}