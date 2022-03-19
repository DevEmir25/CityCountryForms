
namespace CityCountryDemo
{
    partial class Form1
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
            this.cmb_country = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lst_Added = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_txt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_country
            // 
            this.cmb_country.FormattingEnabled = true;
            this.cmb_country.Location = new System.Drawing.Point(126, 41);
            this.cmb_country.Name = "cmb_country";
            this.cmb_country.Size = new System.Drawing.Size(121, 21);
            this.cmb_country.TabIndex = 0;
            this.cmb_country.SelectedIndexChanged += new System.EventHandler(this.cmb_country_SelectedIndexChanged);
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(126, 92);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(121, 21);
            this.cmb_city.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ülke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şehir";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(84, 149);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "KAYDET";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lst_Added
            // 
            this.lst_Added.FormattingEnabled = true;
            this.lst_Added.Location = new System.Drawing.Point(309, 26);
            this.lst_Added.Name = "lst_Added";
            this.lst_Added.Size = new System.Drawing.Size(97, 134);
            this.lst_Added.TabIndex = 5;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(193, 149);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "KALDIR";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_txt
            // 
            this.btn_txt.Location = new System.Drawing.Point(309, 181);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(97, 23);
            this.btn_txt.TabIndex = 7;
            this.btn_txt.Text = "TXT ye KAYDET";
            this.btn_txt.UseVisualStyleBackColor = true;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 244);
            this.Controls.Add(this.btn_txt);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lst_Added);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.cmb_country);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_country;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox lst_Added;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_txt;
    }
}

