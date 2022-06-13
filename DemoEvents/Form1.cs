namespace DemoEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //assignar la gestió d'events de button1, button2 i buttonX al mètode button_click
            button1.Click += button_click;
            button2.Click += button_click;
            button3.Click += button_click;
            button4.Click += button_click;
            button5.Click += button_click;
            button6.Click += button_click;
            button7.Click += button_click;
            button8.Click += button_click;
            button9.Click += button_click;
            button10.Click += button_click;

            textBox1.Text = "";
        }


        //mètode comú per tots els botons
        private void button_click(object? sender, EventArgs e)
        {
            var button = sender as Button;
            textBox1.Text += button.Text; //button.Tag
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Tag !="")
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: item.ForeColor = Color.Red; break;

                        case 1: item.ForeColor = Color.Green; break;

                        case 2: item.ForeColor = Color.Blue; break;
                        
                        default:
                            break;
                    }
                    
                }
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            //textBox1.Text.Substring(5,5)
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}