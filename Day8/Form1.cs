namespace Day8
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private char op;
        private double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op = '-';
            num1=double.Parse(resArea.Text);
            resArea.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resArea.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resArea.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resArea.Text += "4";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            resArea.Text += "5";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            resArea.Text += "9";

        }

        private void Dele_Click(object sender, EventArgs e)
        {
            string tex = resArea.Text;
            string re = "";
            for(int i=0; i < tex.Length - 1; i++)
            {
                re += tex[i];
            }
            resArea.Text = re;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            resArea.Text+= "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resArea.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resArea.Text += "6";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            resArea.Text += "7";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            resArea.Text += "8";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1=double.Parse(resArea.Text); ;
            resArea.Text = "";
            op = '+';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(resArea.Text); ;
            resArea.Text = "";
            op = '*';

        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(resArea.Text); ;
            resArea.Text = "";
            op = '/';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2= double.Parse(resArea.Text);
            switch(op)
            {
                case '*':
                    result = num2 * num1;
                    break;
                case'/':
                    result = num1 / num2;
                    break;
                case '-':
                    result = num2 - num1;
                    break;

                case '+':
                    result = num1 + num2;
                    break;
                case '%':
                    int x=(int)num1;
                    int y=(int)num2;
                    result= x % y;
                    break;


            }
            resArea.Text=result.ToString();
            num1= 0;    
            num2= 0;
            op = ' ';
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resArea.Text += "0";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            resArea.Text += ".";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(resArea.Text); ;
            resArea.Text = "";
            op = '%';
        }
    }
}