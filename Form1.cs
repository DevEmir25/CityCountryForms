using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CityCountryDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StackUsingLinkedlist obj1 = new StackUsingLinkedlist();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmb_country.Items.Add(obj1.push("Türkiye"));
            cmb_country.Items.Add(obj1.push("ABD"));
            cmb_country.Items.Add(obj1.push("Almanya"));
            cmb_country.Items.Add(obj1.push("Çin"));
        }
        StackUsingLinkedlist obj2 = new StackUsingLinkedlist();
        private void cmb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmb_country.Text == "Türkiye")
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add(obj2.push("Bursa"));
                cmb_city.Items.Add(obj2.push("İstanbul"));
                cmb_city.Items.Add(obj2.push("Balıkesir"));
            }
            else if (cmb_country.Text == "ABD")
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add(obj2.push("Chicago"));
                cmb_city.Items.Add(obj2.push("NewYork"));
                cmb_city.Items.Add(obj2.push("Miami"));
            }
            else if (cmb_country.Text == "Almanya")
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add(obj2.push("Stockholm"));
                cmb_city.Items.Add(obj2.push("Berlin"));
                cmb_city.Items.Add(obj2.push("Düsseldorf"));
            }
            else if (cmb_country.Text == "Çin")
            {
                cmb_city.Items.Clear();
                cmb_city.Items.Add(obj2.push("Şangay"));
                cmb_city.Items.Add(obj2.push("Hong Kong"));
                cmb_city.Items.Add(obj2.push("Wuhan"));
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            lst_Added.Items.Add(cmb_country.Text);
            lst_Added.Items.Add(cmb_city.Text);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lst_Added.Items.Remove(lst_Added.SelectedItem);
        }

        private void btn_txt_Click(object sender, EventArgs e)
        {
            StreamWriter yaz = new StreamWriter(@"D:\City_Country.txt", true);
            foreach (string yazi in lst_Added.Items)
            {
                yaz.WriteLine(yazi);
            }
            yaz.Close();
        }
    }
}
