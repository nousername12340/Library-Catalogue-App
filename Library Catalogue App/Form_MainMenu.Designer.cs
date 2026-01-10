namespace Library_Catalogue_App
{
    partial class Form_MainMenu
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
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_libcata = new System.Windows.Forms.Button();
            this.btn_managecata = new System.Windows.Forms.Button();
            this.btn_manageusers = new System.Windows.Forms.Button();
            this.btn_manageloans = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(303, 34);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(185, 39);
            this.lbl_menu.TabIndex = 0;
            this.lbl_menu.Text = "Main Menu";
            // 
            // btn_libcata
            // 
            this.btn_libcata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_libcata.Location = new System.Drawing.Point(68, 110);
            this.btn_libcata.Name = "btn_libcata";
            this.btn_libcata.Size = new System.Drawing.Size(272, 101);
            this.btn_libcata.TabIndex = 1;
            this.btn_libcata.Text = "Library Catalogue";
            this.btn_libcata.UseVisualStyleBackColor = true;
            this.btn_libcata.Click += new System.EventHandler(this.btn_libcata_Click);
            // 
            // btn_managecata
            // 
            this.btn_managecata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_managecata.Location = new System.Drawing.Point(68, 253);
            this.btn_managecata.Name = "btn_managecata";
            this.btn_managecata.Size = new System.Drawing.Size(272, 101);
            this.btn_managecata.TabIndex = 2;
            this.btn_managecata.Text = "Manage Catalogue";
            this.btn_managecata.UseVisualStyleBackColor = true;
            this.btn_managecata.Click += new System.EventHandler(this.btn_managecata_Click);
            // 
            // btn_manageusers
            // 
            this.btn_manageusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageusers.Location = new System.Drawing.Point(448, 110);
            this.btn_manageusers.Name = "btn_manageusers";
            this.btn_manageusers.Size = new System.Drawing.Size(272, 101);
            this.btn_manageusers.TabIndex = 3;
            this.btn_manageusers.Text = "Manage Users";
            this.btn_manageusers.UseVisualStyleBackColor = true;
            this.btn_manageusers.Click += new System.EventHandler(this.btn_manageusers_Click);
            // 
            // btn_manageloans
            // 
            this.btn_manageloans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageloans.Location = new System.Drawing.Point(448, 253);
            this.btn_manageloans.Name = "btn_manageloans";
            this.btn_manageloans.Size = new System.Drawing.Size(272, 101);
            this.btn_manageloans.TabIndex = 4;
            this.btn_manageloans.Text = "Manage Loans";
            this.btn_manageloans.UseVisualStyleBackColor = true;
            this.btn_manageloans.Click += new System.EventHandler(this.btn_manageloans_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(673, 23);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(101, 34);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_manageloans);
            this.Controls.Add(this.btn_manageusers);
            this.Controls.Add(this.btn_managecata);
            this.Controls.Add(this.btn_libcata);
            this.Controls.Add(this.lbl_menu);
            this.Name = "Form_MainMenu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_libcata;
        private System.Windows.Forms.Button btn_managecata;
        private System.Windows.Forms.Button btn_manageusers;
        private System.Windows.Forms.Button btn_manageloans;
        private System.Windows.Forms.Button btn_logout;
    }
}