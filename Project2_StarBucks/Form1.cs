namespace Project2_StarBucks
{
    public partial class Form1 : Form
    {
        private double[] priceBySequence = { 2.49, 3.29, 2.69, 2.29, 1.79, 2.79, 2.89 };
        private double total = 0, taxTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);
            if (temp > 0)
            {
                temp--;
                textBox1.Text = Convert.ToString(temp);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text) + 1;
            textBox1.Text = Convert.ToString(temp);
        }
        private void abortTransc()
        {
            total = 0;
            taxTotal = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            listBox1.Items.Clear();
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int converted = Convert.ToInt32(textBox1.Text);
            if (converted > 0)
            {
                if (radioButton1.Checked == true)
                {
                    total = (converted * priceBySequence[0]) + total;
                    listBox1.Items.Add(radioButton1.Text + "     -  " + converted + " x     " + Convert.ToString(priceBySequence[0]));
                }
                if (radioButton2.Checked == true)
                {
                    total = (converted * priceBySequence[1]) + total;
                    listBox1.Items.Add(radioButton2.Text + "     -  " + converted + " x     " + Convert.ToString(priceBySequence[1]));
                }
                if (radioButton3.Checked == true)
                {
                    total = (converted * priceBySequence[2]) + total;
                    listBox1.Items.Add(radioButton3.Text + "     -  " + converted + " x     " + Convert.ToString(priceBySequence[2]));
                }
                if (radioButton4.Checked == true)
                {
                    total = (converted * priceBySequence[3]) + total;
                    listBox1.Items.Add(radioButton4.Text + "     -  " + converted + " x     " + Convert.ToString(priceBySequence[3]));
                }
                if (radioButton5.Checked == true)
                {
                    total = (converted * priceBySequence[4]) + total;
                    listBox1.Items.Add(radioButton5.Text + "     -  " + converted + " x     " + Convert.ToString(priceBySequence[4]));
                }
                if (checkBox1.Checked == true)
                {
                    total = priceBySequence[5] + total;
                    listBox1.Items.Add(checkBox1.Text + "     -  " + converted + " x     " + Convert.ToString(priceBySequence[5]));
                }
                if (checkBox2.Checked == true)
                {
                    total = priceBySequence[6] + total;
                    listBox1.Items.Add(checkBox2.Text + "     -  " + converted + " x     " + Convert.ToString(priceBySequence[6]));
                }
            }
            taxTotal = total + (0.07 * total);
            textBox2.Text = Convert.ToString(taxTotal);
            textBox1.Text = "0";
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abortTransc();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            abortTransc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
    }
}