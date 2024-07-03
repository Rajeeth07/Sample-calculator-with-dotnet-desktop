using System.CodeDom;
using System.Diagnostics.Eventing.Reader;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int Sum(int _num1, int _num2)
        {
            return _num1 + _num2;
        }
        private static int Sub(int _num1, int _num2)
        {
            return _num1 - _num2;
        }
        private static int Mult(int _num1, int _num2)
        {
            return _num1 * _num2;
        }
        private static int Divi(int _num1, int _num2)
        {
            return _num1 / _num2;
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 _num1 = Convert.ToInt32(txtNum1.Text);
                Int32 _num2 = Convert.ToInt32(txtNum2.Text);
                txtOut.Text = Calculate(_num1, _num2, "+").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        private static int Calculate(int num1, int num2, String Operator)
        {
            int result = 0;
            /*
            if (Operator== "+"){
                result = Sum(num1,num2);
            }
            else if (Operator== "-"){
                result = Sub(num1, num2);
            }
            else if (Operator== "*"){
                result = Mult(num1, num2);
            }
            else if(Operator== "/"){
                result = Divi(num1, num2);
             
            }
            */
            switch (Operator)
            {
                case "+": result = Sum(num1,num2); 
                    break;
                case "-":
                    result = Sub(num1, num2);
                    break;
                case "*":
                    result = Mult(num1, num2);
                    break;
                case "/":
                    result = Divi(num1, num2);
                    break;
                default: break;
            }
            return result;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 _num1 = Convert.ToInt32(txtNum1.Text);
                Int32 _num2 = Convert.ToInt32(txtNum2.Text);
                txtOut.Text = Calculate(_num1, _num2, "-").ToString();
            }
            catch (Exception) 
            { 
           
                throw;
            }
            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 _num1 = Convert.ToInt32(txtNum1.Text);
                Int32 _num2 = Convert.ToInt32(txtNum2.Text);
                txtOut.Text = Calculate(_num1, _num2, "*").ToString();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 _num1 = Convert.ToInt32(txtNum1.Text);
                Int32 _num2 = Convert.ToInt32(txtNum2.Text);
                txtOut.Text = Calculate(_num1, _num2, "/").ToString();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        
    }
}
