using System.Data;

namespace WinF_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
        // https://www.makeuseof.com/windows-forms-calculator-app-build/ Asagidaki funksiyani bu saytdan goturdum
        // Yoxsa hamisi ile bir bir oynamaq lazim idi

            string formattedCalculation = textBoxResult.Text.Replace("×", "*").ToString().Replace("÷", "/");

            try
            {

                double result = double.Parse(new DataTable().Compute(formattedCalculation, null).ToString()!);

                textBoxResult.Text =  result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxResult.Clear();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (((sender as Button)?.Text == "." && textBoxResult.TextLength == 0))
                textBoxResult.Text += "0.";

            else
                textBoxResult.Text += (sender as Button).Text;
                
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
        }
    }


    
}