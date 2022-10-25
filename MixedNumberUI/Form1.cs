using Algorithms;

namespace MixedNumberUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNumber1.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text)
                || string.IsNullOrEmpty(txtNumber2.Text)
                || string.IsNullOrEmpty(txtNum1.Text)
                || string.IsNullOrEmpty(txtNum2.Text)
                || string.IsNullOrEmpty(txtDen1.Text)
                || string.IsNullOrEmpty(txtDen2.Text))
            {
                MessageBox.Show(@"Por favor ingrese todos los datos");
                ClearAll();
                return;
            }

            var n1 = int.Parse(txtNumber1.Text);
            var n2 = int.Parse(txtNumber2.Text);
            var numerador1 = int.Parse(txtNum1.Text);
            var numerador2 = int.Parse(txtNum2.Text);
            var denominador1 = int.Parse(txtDen1.Text);
            var denominador2 = int.Parse(txtDen2.Text);

            if (denominador1 ==  0 || denominador2 == 0)
            {
                MessageBox.Show(@"Division entre 0");
                ClearAll();
                return;
            }
            if (numerador1 > denominador1 || numerador2 > denominador2)
            {
                MessageBox.Show(@"Fraccion impropia");
                ClearAll();
                return;
            }

            try
            {
                var numeroMixto1 = new MixedFraction(n1, new Fraction(numerador1, denominador1));
                var numeroMixto2 = new MixedFraction(n2, new Fraction(numerador2, denominador2));

                var sum = numeroMixto1.Addition(numeroMixto2);
                var rest = numeroMixto1.Sub(numeroMixto2);
                var mul = numeroMixto1.Mul(numeroMixto2);
                var div = numeroMixto1.Div(numeroMixto2);

                labelsum.Text = sum.ConvertToFraction().ToString();
                labelsum.Text += @" = "+ sum;

                labelrest.Text = rest.ConvertToFraction().ToString();
                labelrest.Text += @" = "+ rest;

                labelmult.Text = mul.ConvertToFraction().ToString();
                labelmult.Text += @" = "+ mul;

                labeldiv.Text = div.ConvertToFraction().ToString();
                labeldiv.Text += @" = "+ div;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           ClearAll();
        }

        private void ClearAll()
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtNum1.Clear();
            txtNum2.Clear();
            txtDen1.Clear();
            txtDen2.Clear();
            labelsum.Text = "";
            labelrest.Text = "";
            labelmult.Text = "";
            labeldiv.Text = "";
        }
    }
}