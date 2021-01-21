using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelKategori_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMenu_Click(object sender, EventArgs e)
        {

        }
        string[] Makanan = new string[20];
        string[] Minuman = new string[20];
        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxMenu.Items.Add("Mie Instan");
            Makanan[0] = "Mie Instan";
            listBoxMenu.Items.Add("Telor");
            Makanan[1] = "Telor";
            listBoxMenu.Items.Add("Susu Sapi");
            Minuman[0] = "Susu Sapi";
            listBoxMenu.Items.Add("Kopi");
            Minuman[1] = "Kopi";
            listBoxMenu.Items.Add("Roti");
            Makanan[2] = "Roti";
            listBoxMenu.Items.Add("Keju");
            Makanan[3] = "Keju";
            listBoxMenu.Items.Add("Daging Giling");
            Makanan[4] = "Daging Giling";
            listBoxMenu.Items.Add("Teh");
            Minuman[2] = "Teh";
            listBoxMenu.Items.Add("Bir");
            Minuman[3] = "Bir";
            listBoxMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            listBoxItem.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            bool A = false;
            if (textBoxNamaItem.Text == "" && radioButtonMakanan.Checked == false || textBoxNamaItem.Text == "" && radioButtonMinuman.Checked == false || radioButtonMakanan.Checked == false && radioButtonMinuman.Checked == false)
            {
                MessageBox.Show("Harap Diisi terlebih dahulu");
            }
            else  
            {
                for (int i = 0; i < listBoxMenu.Items.Count; i++)
                {
                    if (listBoxMenu.Items[i].ToString() == textBoxNamaItem.Text)
                    {
                        A = true;
                    }
                }
                if (A == false)
                {
                    listBoxMenu.Items.Add(textBoxNamaItem.Text);
                }
                radioButtonMakanan.Checked = false;
                radioButtonMinuman.Checked = false;
            }
            textBoxNamaItem.Text = "";
        }

        private void buttonINext_Click(object sender, EventArgs e)
        {
            bool A = false;
            listBoxMenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            for (int i = 0; i < listBoxMenu.SelectedItems.Count; i++)
            {
                if (listBoxItem.Items.Contains(listBoxMenu.SelectedItems[i].ToString()))
                {
                    A = true;
                }
            }
            if (A == false)
            {
                for (int i = 0; i < listBoxMenu.SelectedItems.Count; i++)
                {
                    listBoxItem.Items.Add(listBoxMenu.SelectedItems[i]);
                }
                listBoxMenu.ClearSelected();
            }
        }

        private void buttonSilang_Click(object sender, EventArgs e)
        {
            listBoxItem.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            if (listBoxItem.SelectedItems.Count == 0)
            {
                listBoxItem.Items.Clear();
            }
            else if (listBoxItem.SelectedItems.Count > 0)
            {
                for (int i = listBoxItem.SelectedIndices.Count - 1; i > -1; i--)
                {
                    listBoxItem.Items.Remove(listBoxItem.SelectedItems[i]);
                }
            }
            listBoxMenu.ClearSelected();
        }

        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 5; i < listBoxMenu.Items.Count; i++)
            {
                Makanan[i] = textBoxNamaItem.Text;
            }
        }

        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 5; i < listBoxMenu.Items.Count; i++)
            {
                Minuman[i] = textBoxNamaItem.Text;
            }
        }

        private void checkBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {
            listBoxMenu.ClearSelected();
            if (checkBoxMakanan.Checked == true)
            {
                for (int i = 0; i < Makanan.Length; i++)
                {
                    listBoxMenu.Text = Makanan[i];
                }
            }
            if (checkBoxMinuman.Checked == true)
            {
                for (int i = 0; i < Makanan.Length; i++)
                {
                    listBoxMenu.Text = Minuman[i];
                }
            }
        }

        private void checkBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {
            listBoxMenu.ClearSelected();
            if (checkBoxMakanan.Checked == true)
            {
                for (int i = 0; i < Makanan.Length; i++)
                {
                    listBoxMenu.Text = Makanan[i];
                }
            }
            if (checkBoxMinuman.Checked == true)
            {
                for (int i = 0; i < Makanan.Length; i++)
                {
                    listBoxMenu.Text = Minuman[i];
                }
            }
        }
    }
}
