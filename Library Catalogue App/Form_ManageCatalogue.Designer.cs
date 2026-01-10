namespace Library_Catalogue_App
{
    partial class Form_ManageCatalogue
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
            this.lbl_ManageCatalogue = new System.Windows.Forms.Label();
            this.dgv_booklist = new System.Windows.Forms.DataGridView();
            this.lbl_booktitle = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtbox_qty = new System.Windows.Forms.TextBox();
            this.txtbox_year = new System.Windows.Forms.TextBox();
            this.txtbox_author = new System.Windows.Forms.TextBox();
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booklist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ManageCatalogue
            // 
            this.lbl_ManageCatalogue.AutoSize = true;
            this.lbl_ManageCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManageCatalogue.Location = new System.Drawing.Point(15, 9);
            this.lbl_ManageCatalogue.Name = "lbl_ManageCatalogue";
            this.lbl_ManageCatalogue.Size = new System.Drawing.Size(242, 31);
            this.lbl_ManageCatalogue.TabIndex = 0;
            this.lbl_ManageCatalogue.Text = "Manage Catalogue";
            // 
            // dgv_booklist
            // 
            this.dgv_booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_booklist.Location = new System.Drawing.Point(265, 66);
            this.dgv_booklist.Name = "dgv_booklist";
            this.dgv_booklist.RowHeadersWidth = 51;
            this.dgv_booklist.RowTemplate.Height = 24;
            this.dgv_booklist.Size = new System.Drawing.Size(564, 398);
            this.dgv_booklist.TabIndex = 1;
            this.dgv_booklist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_booklist_CellClick);
            this.dgv_booklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_booklist_CellContentClick);
            // 
            // lbl_booktitle
            // 
            this.lbl_booktitle.AutoSize = true;
            this.lbl_booktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booktitle.Location = new System.Drawing.Point(16, 87);
            this.lbl_booktitle.Name = "lbl_booktitle";
            this.lbl_booktitle.Size = new System.Drawing.Size(55, 25);
            this.lbl_booktitle.TabIndex = 2;
            this.lbl_booktitle.Text = "Title:";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(16, 221);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(59, 25);
            this.lbl_year.TabIndex = 3;
            this.lbl_year.Text = "Year:";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.Location = new System.Drawing.Point(16, 156);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(76, 25);
            this.lbl_Author.TabIndex = 4;
            this.lbl_Author.Text = "Author:";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(16, 293);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(91, 25);
            this.lbl_qty.TabIndex = 5;
            this.lbl_qty.Text = "Quantity:";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(133, 384);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 29);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtbox_qty
            // 
            this.txtbox_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_qty.Location = new System.Drawing.Point(17, 321);
            this.txtbox_qty.Name = "txtbox_qty";
            this.txtbox_qty.Size = new System.Drawing.Size(217, 24);
            this.txtbox_qty.TabIndex = 9;
            this.txtbox_qty.TextChanged += new System.EventHandler(this.txtbox_qty_TextChanged);
            this.txtbox_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_qty_KeyPress);
            // 
            // txtbox_year
            // 
            this.txtbox_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_year.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.txtbox_year.Location = new System.Drawing.Point(17, 249);
            this.txtbox_year.Name = "txtbox_year";
            this.txtbox_year.Size = new System.Drawing.Size(217, 24);
            this.txtbox_year.TabIndex = 10;
            this.txtbox_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_year_KeyPress);
            // 
            // txtbox_author
            // 
            this.txtbox_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_author.Location = new System.Drawing.Point(17, 184);
            this.txtbox_author.Name = "txtbox_author";
            this.txtbox_author.Size = new System.Drawing.Size(217, 24);
            this.txtbox_author.TabIndex = 11;
            // 
            // txtbox_title
            // 
            this.txtbox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_title.Location = new System.Drawing.Point(17, 115);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(217, 24);
            this.txtbox_title.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(37, 365);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 29);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(37, 435);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(86, 29);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(37, 400);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 29);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(729, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 36);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(133, 419);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 29);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form_ManageCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 487);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtbox_title);
            this.Controls.Add(this.txtbox_author);
            this.Controls.Add(this.txtbox_year);
            this.Controls.Add(this.txtbox_qty);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_booktitle);
            this.Controls.Add(this.dgv_booklist);
            this.Controls.Add(this.lbl_ManageCatalogue);
            this.Name = "Form_ManageCatalogue";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ManageCatalogue;
        private System.Windows.Forms.DataGridView dgv_booklist;
        private System.Windows.Forms.Label lbl_booktitle;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtbox_qty;
        private System.Windows.Forms.TextBox txtbox_year;
        private System.Windows.Forms.TextBox txtbox_author;
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
    }
}