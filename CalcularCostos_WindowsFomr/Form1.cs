namespace CalcularCostos_WindowsFomr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CalcularEnvio_Click(object sender, EventArgs e)
        {

            int total = 0;

            ////// if por secuencia ///////

            if (radioButton1.Checked == true)
            {
                total = total + 50;

            }
            else if (radioButton2.Checked == true)
            {
                total = total + 100;
            }
            else if (radioButton3.Checked == true)
            {
                total = total + 150;
            }
            //////////////////// Son if independientes ////////////

            if (this.checkBox1.Checked == true)
            {
                total = total + 5;
            }
             if (this.checkBox2.Checked == true)
            {
                total = total + 15;
            }
             if (this.checkBox3.Checked == true)
            {
                total = total + 20;
            }

            MessageBox.Show(" El total de gastos de envio es " + total);

        }
    }
}