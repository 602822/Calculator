using System.Linq.Expressions;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputField.Text.Contains('+'))
            {
                String text = inputField.Text;
                String[] tall = text.Split('+');
                int tall1 = int.Parse(tall[0].Trim());
                int tall2 = int.Parse(tall[1].Trim());

                inputField.Text = add(tall1, tall2).ToString();
            }

            if (inputField.Text.Contains('*'))
            {
                String text = inputField.Text;
                String[] tall = text.Split('*');
                int tall1 = int.Parse(tall[0].Trim());
                int tall2 = int.Parse(tall[1].Trim());

                inputField.Text = multiplication(tall1, tall2).ToString();
            }

            if (inputField.Text.Contains('-'))
            {
                String text = inputField.Text;
                String[] tall = text.Split('-');
                int tall1 = int.Parse(tall[0].Trim());
                int tall2 = int.Parse(tall[1].Trim());

                inputField.Text = subtract(tall1, tall2).ToString();
            }

            if (inputField.Text.Contains('/'))
            {
                String text = inputField.Text;
                String[] tall = text.Split('/');
                int tall1 = int.Parse(tall[0].Trim());
                int tall2 = int.Parse(tall[1].Trim());

                inputField.Text = division(tall1, tall2).ToString();
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int add(int tall1, int tall2)
        {
            return tall1 + tall2;

        }

        private int subtract(int tall1, int tall2)
        {
            return tall1 - tall2;
        }

        private int multiplication(int tall1, int tall2)
        {
            return tall1 * tall2;
        }

        private int division(int tall1, int tall2)
        {
            return tall1 / tall2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}