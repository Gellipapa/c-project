using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCBevezetoListString.controller;
using System.Diagnostics;

namespace MVCBevezetoListString
{
    public partial class Form1 : Form
    {
        private Controller cl;
        public Form1()
        {
            cl = new Controller();
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elrejt();
        }
        private void elrejt()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            textBoxTaj.Focus();
        }
        private void megjelenit()
        {
            panel1.Visible = true;
            panel2.Visible = true;
           
        }

        private void textBoxTaj_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
           


        }

        private void button1Hozzadas_Click(object sender, EventArgs e)
        {

            try
            {
                cl.addNumber(textBoxTaj.Text);
                listBox1Lista.DataSource = cl.getNumbers();
                textBoxTaj.Text = string.Empty;
                textBoxTaj.Focus();
            }
            catch(ControllerException ce)
            {
                errorProvider1.SetError(button1Hozzadas, ce.Message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            if (listBox1Lista.Items.Count > 0)
            {
                megjelenit();
            }
            else
            {
                elrejt();
            }
            
            
        }

        private void button2Torol_Click(object sender, EventArgs e)
        {

            try
            {
                int index = listBox1Lista.SelectedIndex;
                cl.deleteNumber(index);
                listBox1Lista.DataSource = null;
                listBox1Lista.DataSource = cl.getNumbers();
                if (listBox1Lista.Items.Count == 0)

                    textBoxTaj.Text = string.Empty;
            }

            catch (ControllerException ce)
            {
                errorProvider1.SetError(button2Torol, ce.Message);
            }

            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
               


        }

        private void button3Modosit_Click(object sender, EventArgs e)
        {

            try
            {
                int index = listBox1Lista.SelectedIndex;
                cl.modifyNumber(index, textBoxTaj.Text);
                listBox1Lista.DataSource = null;
                listBox1Lista.DataSource = cl.getNumbers();
            }
            catch(ControllerException ce)
            {
                errorProvider1.SetError(button3Modosit, ce.Message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            if (listBox1Lista.Items.Count > 0)
            {
                megjelenit();
            }
            else
            {
                elrejt();
            }


            
        }

        private void button4Kiszamol_Click(object sender, EventArgs e)
        {
            textBox2.Text = cl.computeAverage();
        }

        private void listBox1Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1Lista.SelectedIndex;
            if (index < 0)
            
                return;
            textBoxTaj.Text = listBox1Lista.SelectedItem.ToString();            
        }

        private void button5Kilep_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
