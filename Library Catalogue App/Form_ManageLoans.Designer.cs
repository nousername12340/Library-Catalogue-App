namespace Library_Catalogue_App
{
    partial class Form_ManageLoan
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
            this.lbl_manageloan = new System.Windows.Forms.Label();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.lbl_borrowdate = new System.Windows.Forms.Label();
            this.lbl_booktitle = new System.Windows.Forms.Label();
            this.dgv_loanlist = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.dtp_borrow = new System.Windows.Forms.DateTimePicker();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txtbox_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_returndate = new System.Windows.Forms.Label();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loanlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_manageloan
            // 
            this.lbl_manageloan.AutoSize = true;
            this.lbl_manageloan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manageloan.Location = new System.Drawing.Point(25, 18);
            this.lbl_manageloan.Name = "lbl_manageloan";
            this.lbl_manageloan.Size = new System.Drawing.Size(178, 31);
            this.lbl_manageloan.TabIndex = 0;
            this.lbl_manageloan.Text = "Manage Loan";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_username.Location = new System.Drawing.Point(31, 121);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(217, 24);
            this.txtbox_username.TabIndex = 25;
            // 
            // lbl_borrowdate
            // 
            this.lbl_borrowdate.AutoSize = true;
            this.lbl_borrowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_borrowdate.Location = new System.Drawing.Point(26, 223);
            this.lbl_borrowdate.Name = "lbl_borrowdate";
            this.lbl_borrowdate.Size = new System.Drawing.Size(151, 25);
            this.lbl_borrowdate.TabIndex = 19;
            this.lbl_borrowdate.Text = "Borrowing Date:";
            // 
            // lbl_booktitle
            // 
            this.lbl_booktitle.AutoSize = true;
            this.lbl_booktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_booktitle.Location = new System.Drawing.Point(30, 93);
            this.lbl_booktitle.Name = "lbl_booktitle";
            this.lbl_booktitle.Size = new System.Drawing.Size(108, 25);
            this.lbl_booktitle.TabIndex = 17;
            this.lbl_booktitle.Text = "Username:";
            this.lbl_booktitle.Click += new System.EventHandler(this.lbl_booktitle_Click);
            // 
            // dgv_loanlist
            // 
            this.dgv_loanlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loanlist.Location = new System.Drawing.Point(280, 79);
            this.dgv_loanlist.Name = "dgv_loanlist";
            this.dgv_loanlist.RowHeadersWidth = 51;
            this.dgv_loanlist.RowTemplate.Height = 24;
            this.dgv_loanlist.Size = new System.Drawing.Size(584, 423);
            this.dgv_loanlist.TabIndex = 16;
            this.dgv_loanlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loanlist_CellClick);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(781, 18);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(83, 36);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dtp_borrow
            // 
            this.dtp_borrow.Location = new System.Drawing.Point(31, 251);
            this.dtp_borrow.Name = "dtp_borrow";
            this.dtp_borrow.Size = new System.Drawing.Size(200, 22);
            this.dtp_borrow.TabIndex = 30;
            this.dtp_borrow.ValueChanged += new System.EventHandler(this.dtp_borrow_ValueChanged);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(39, 414);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 29);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(39, 449);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(86, 29);
            this.btn_del.TabIndex = 35;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(39, 379);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 29);
            this.btn_add.TabIndex = 34;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(135, 396);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 29);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(135, 431);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 29);
            this.btn_clear.TabIndex = 37;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txtbox_title
            // 
            this.txtbox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_title.Location = new System.Drawing.Point(31, 185);
            this.txtbox_title.Name = "txtbox_title";
            this.txtbox_title.Size = new System.Drawing.Size(217, 24);
            this.txtbox_title.TabIndex = 39;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(30, 157);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(106, 25);
            this.lbl_title.TabIndex = 38;
            this.lbl_title.Text = "Book TItle:";
            // 
            // lbl_returndate
            // 
            this.lbl_returndate.AutoSize = true;
            this.lbl_returndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_returndate.Location = new System.Drawing.Point(28, 301);
            this.lbl_returndate.Name = "lbl_returndate";
            this.lbl_returndate.Size = new System.Drawing.Size(121, 25);
            this.lbl_returndate.TabIndex = 20;
            this.lbl_returndate.Text = "Return Date:";
            // 
            // dtp_return
            // 
            this.dtp_return.Location = new System.Drawing.Point(33, 329);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(200, 22);
            this.dtp_return.TabIndex = 32;
            this.dtp_return.Value = new System.DateTime(2026, 1, 11, 3, 46, 31, 0);
            this.dtp_return.ValueChanged += new System.EventHandler(this.dtp_return_ValueChanged);
            // 
            // Form_ManageLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 522);
            this.Controls.Add(this.txtbox_title);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dtp_return);
            this.Controls.Add(this.dtp_borrow);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.lbl_returndate);
            this.Controls.Add(this.lbl_borrowdate);
            this.Controls.Add(this.lbl_booktitle);
            this.Controls.Add(this.dgv_loanlist);
            this.Controls.Add(this.lbl_manageloan);
            this.Name = "Form_ManageLoan";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loanlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_manageloan;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Label lbl_borrowdate;
        private System.Windows.Forms.Label lbl_booktitle;
        private System.Windows.Forms.DataGridView dgv_loanlist;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DateTimePicker dtp_borrow;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txtbox_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_returndate;
        private System.Windows.Forms.DateTimePicker dtp_return;
    }
}