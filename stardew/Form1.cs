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

namespace stardew
{
    public partial class Form1 : Form
    {

        static List<Shipped> shippedlist;
        

        public void LabelUpdate()
        {
            label1.Text = $"shipped items: {Shipped.counter}/{shippedlist.Count}";
            savebutton.Text = "save";
        }

        public Form1()
        {
            InitializeComponent();
            listbox.CheckOnClick = true;
            shippedlist = Shipped.Read();
            
            foreach (Shipped s in shippedlist)
            {
                if (s.check == true) listbox.Items.Add($"{s.id}, {s.name}", true);
                else listbox.Items.Add($"{s.id}, {s.name}", false);

            }
            
            LabelUpdate();


        }
        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            
            int lineid = Convert.ToInt32(listbox.SelectedIndex.ToString());
            

                if (listbox.GetItemCheckState(lineid) == CheckState.Checked)
                {
                    Shipped.counter++;
               
                    LabelUpdate();
                    

                }
                else
                {
                    Shipped.counter--;
                
                LabelUpdate();
                }
            
            
                
            
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
           // StreamWriter sw = new StreamWriter();
           // string lineid = listbox.SelectedIndex.ToString();
            
            
            
            try
            {
                StreamWriter sw = new StreamWriter(Shipped.file);
                foreach (Shipped s in shippedlist)
                {
                    if (listbox.GetItemCheckState(s.id - 1) == CheckState.Checked)
                    {
                        s.check = true;

                    }
                    else s.check = false;
                    
                    sw.WriteLine($"{s.check};{s.name}");
                }
                sw.Close();
                savebutton.Text = "saving successful! :)";
            }
            catch
            {
                savebutton.Text = "error";
            }
        }


        //https://www.youtube.com/watch?v=UiMyTCt5jEY&ab_channel=C-TinNistor
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            foreach (Shipped s in shippedlist)
            {
                string name = s.name;
                if (name.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    if (s.check == true) listbox.Items.Add($"{s.id}, {s.name}", true);
                    else listbox.Items.Add($"{s.id}, {s.name}", false);

                }
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
