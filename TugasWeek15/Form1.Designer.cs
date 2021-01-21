namespace TugasWeek15
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
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxNamaItem = new System.Windows.Forms.TextBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.panelMakananMinuman = new System.Windows.Forms.Panel();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.buttonInput = new System.Windows.Forms.Button();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.buttonINext = new System.Windows.Forms.Button();
            this.buttonSilang = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFilter = new System.Windows.Forms.Label();
            this.checkBoxMakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxMinuman = new System.Windows.Forms.CheckBox();
            this.panelMakananMinuman.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(25, 32);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(58, 13);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama Item";
            // 
            // textBoxNamaItem
            // 
            this.textBoxNamaItem.Location = new System.Drawing.Point(102, 32);
            this.textBoxNamaItem.Name = "textBoxNamaItem";
            this.textBoxNamaItem.Size = new System.Drawing.Size(100, 20);
            this.textBoxNamaItem.TabIndex = 1;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(25, 91);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(46, 13);
            this.labelKategori.TabIndex = 2;
            this.labelKategori.Text = "Kategori";
            this.labelKategori.Click += new System.EventHandler(this.labelKategori_Click);
            // 
            // panelMakananMinuman
            // 
            this.panelMakananMinuman.Controls.Add(this.radioButtonMinuman);
            this.panelMakananMinuman.Controls.Add(this.radioButtonMakanan);
            this.panelMakananMinuman.Location = new System.Drawing.Point(102, 77);
            this.panelMakananMinuman.Name = "panelMakananMinuman";
            this.panelMakananMinuman.Size = new System.Drawing.Size(174, 48);
            this.panelMakananMinuman.TabIndex = 3;
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(91, 14);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinuman.TabIndex = 1;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButtonMinuman_CheckedChanged);
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(15, 14);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakanan.TabIndex = 0;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            this.radioButtonMakanan.CheckedChanged += new System.EventHandler(this.radioButtonMakanan_CheckedChanged);
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(102, 145);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 4;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(28, 185);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(131, 212);
            this.listBoxMenu.TabIndex = 5;
            this.listBoxMenu.Click += new System.EventHandler(this.listBoxMenu_Click);
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxMenu_SelectedIndexChanged);
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.Location = new System.Drawing.Point(270, 185);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(156, 212);
            this.listBoxItem.TabIndex = 6;
            // 
            // buttonINext
            // 
            this.buttonINext.Location = new System.Drawing.Point(177, 197);
            this.buttonINext.Name = "buttonINext";
            this.buttonINext.Size = new System.Drawing.Size(75, 23);
            this.buttonINext.TabIndex = 7;
            this.buttonINext.Text = ">";
            this.buttonINext.UseVisualStyleBackColor = true;
            this.buttonINext.Click += new System.EventHandler(this.buttonINext_Click);
            // 
            // buttonSilang
            // 
            this.buttonSilang.Location = new System.Drawing.Point(177, 226);
            this.buttonSilang.Name = "buttonSilang";
            this.buttonSilang.Size = new System.Drawing.Size(75, 23);
            this.buttonSilang.TabIndex = 8;
            this.buttonSilang.Text = "X";
            this.buttonSilang.UseVisualStyleBackColor = true;
            this.buttonSilang.Click += new System.EventHandler(this.buttonSilang_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelFilter);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxMakanan);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxMinuman);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(177, 264);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(75, 70);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(3, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(29, 13);
            this.labelFilter.TabIndex = 10;
            this.labelFilter.Text = "Filter";
            // 
            // checkBoxMakanan
            // 
            this.checkBoxMakanan.AutoSize = true;
            this.checkBoxMakanan.Location = new System.Drawing.Point(3, 16);
            this.checkBoxMakanan.Name = "checkBoxMakanan";
            this.checkBoxMakanan.Size = new System.Drawing.Size(71, 17);
            this.checkBoxMakanan.TabIndex = 11;
            this.checkBoxMakanan.Text = "Makanan";
            this.checkBoxMakanan.UseVisualStyleBackColor = true;
            this.checkBoxMakanan.CheckedChanged += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            // 
            // checkBoxMinuman
            // 
            this.checkBoxMinuman.AutoSize = true;
            this.checkBoxMinuman.Location = new System.Drawing.Point(3, 39);
            this.checkBoxMinuman.Name = "checkBoxMinuman";
            this.checkBoxMinuman.Size = new System.Drawing.Size(69, 17);
            this.checkBoxMinuman.TabIndex = 12;
            this.checkBoxMinuman.Text = "Minuman";
            this.checkBoxMinuman.UseVisualStyleBackColor = true;
            this.checkBoxMinuman.CheckedChanged += new System.EventHandler(this.checkBoxMinuman_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonSilang);
            this.Controls.Add(this.buttonINext);
            this.Controls.Add(this.listBoxItem);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.panelMakananMinuman);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.textBoxNamaItem);
            this.Controls.Add(this.labelNama);
            this.Name = "Form1";
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMakananMinuman.ResumeLayout(false);
            this.panelMakananMinuman.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxNamaItem;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Panel panelMakananMinuman;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.Button buttonINext;
        private System.Windows.Forms.Button buttonSilang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.CheckBox checkBoxMakanan;
        private System.Windows.Forms.CheckBox checkBoxMinuman;
    }
}

