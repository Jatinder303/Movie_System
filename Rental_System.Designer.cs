
namespace Movie_System
{
    partial class Rental_System
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
            this.Tab_Cont_Data = new System.Windows.Forms.TabControl();
            this.tab_Customer = new System.Windows.Forms.TabPage();
            this.tab_Movie = new System.Windows.Forms.TabPage();
            this.tab_Rental = new System.Windows.Forms.TabPage();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.DGV_Movie = new System.Windows.Forms.DataGridView();
            this.DGV_Rental = new System.Windows.Forms.DataGridView();
            this.Tab_Cont_Data.SuspendLayout();
            this.tab_Customer.SuspendLayout();
            this.tab_Movie.SuspendLayout();
            this.tab_Rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_Cont_Data
            // 
            this.Tab_Cont_Data.Controls.Add(this.tab_Customer);
            this.Tab_Cont_Data.Controls.Add(this.tab_Movie);
            this.Tab_Cont_Data.Controls.Add(this.tab_Rental);
            this.Tab_Cont_Data.Location = new System.Drawing.Point(12, 12);
            this.Tab_Cont_Data.Name = "Tab_Cont_Data";
            this.Tab_Cont_Data.SelectedIndex = 0;
            this.Tab_Cont_Data.Size = new System.Drawing.Size(544, 291);
            this.Tab_Cont_Data.TabIndex = 0;
            // 
            // tab_Customer
            // 
            this.tab_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab_Customer.Controls.Add(this.DGV_Customer);
            this.tab_Customer.Location = new System.Drawing.Point(4, 22);
            this.tab_Customer.Name = "tab_Customer";
            this.tab_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customer.Size = new System.Drawing.Size(536, 265);
            this.tab_Customer.TabIndex = 0;
            this.tab_Customer.Text = "Customer";
            // 
            // tab_Movie
            // 
            this.tab_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tab_Movie.Controls.Add(this.DGV_Movie);
            this.tab_Movie.Location = new System.Drawing.Point(4, 22);
            this.tab_Movie.Name = "tab_Movie";
            this.tab_Movie.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Movie.Size = new System.Drawing.Size(536, 265);
            this.tab_Movie.TabIndex = 1;
            this.tab_Movie.Text = "Movie";
            // 
            // tab_Rental
            // 
            this.tab_Rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_Rental.Controls.Add(this.DGV_Rental);
            this.tab_Rental.Location = new System.Drawing.Point(4, 22);
            this.tab_Rental.Name = "tab_Rental";
            this.tab_Rental.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rental.Size = new System.Drawing.Size(536, 265);
            this.tab_Rental.TabIndex = 2;
            this.tab_Rental.Text = "Rental";
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(6, 6);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.Size = new System.Drawing.Size(524, 253);
            this.DGV_Customer.TabIndex = 0;
            // 
            // DGV_Movie
            // 
            this.DGV_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Movie.Location = new System.Drawing.Point(7, 7);
            this.DGV_Movie.Name = "DGV_Movie";
            this.DGV_Movie.Size = new System.Drawing.Size(523, 252);
            this.DGV_Movie.TabIndex = 0;
            // 
            // DGV_Rental
            // 
            this.DGV_Rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rental.Location = new System.Drawing.Point(7, 7);
            this.DGV_Rental.Name = "DGV_Rental";
            this.DGV_Rental.Size = new System.Drawing.Size(523, 252);
            this.DGV_Rental.TabIndex = 0;
            // 
            // Rental_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tab_Cont_Data);
            this.Name = "Rental_System";
            this.Text = "Video Rental System";
            this.Tab_Cont_Data.ResumeLayout(false);
            this.tab_Customer.ResumeLayout(false);
            this.tab_Movie.ResumeLayout(false);
            this.tab_Rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Cont_Data;
        private System.Windows.Forms.TabPage tab_Customer;
        private System.Windows.Forms.TabPage tab_Movie;
        private System.Windows.Forms.TabPage tab_Rental;
        private System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.DataGridView DGV_Movie;
        private System.Windows.Forms.DataGridView DGV_Rental;
    }
}

