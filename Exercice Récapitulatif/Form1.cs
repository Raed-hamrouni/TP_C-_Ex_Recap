using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_Récapitulatif
{
    public partial class Form1 : Form
    {
        private string input = "";          // Current input
        private string operand1 = "";      // First operand
        private string operand2 = "";      // Second operand
        private char operation;            // Current operation
        private bool isOperationPerformed; // Flag for operation

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAffichage.Text))
            {
                double temp = Convert.ToDouble(txtAffichage.Text) / 100;
                txtAffichage.Text = temp.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = "";
            input = operand1 = operand2 = "";
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text.Length > 0)
            {
                txtAffichage.Text = txtAffichage.Text.Substring(0, txtAffichage.Text.Length - 1);
            }
        }
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAffichage.Text))
            {
                double temp = Convert.ToDouble(txtAffichage.Text);
                txtAffichage.Text = (-temp).ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btnSur_Click(object sender, EventArgs e)
        {

        }

        private void btnMplus_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btnFois_Click(object sender, EventArgs e)
        {

        }

        private void btnMmoins_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btnMoins_Click(object sender, EventArgs e)
        {

        }

        private void btnMR_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMC_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnVirgule_Click(object sender, EventArgs e)
        {
            if (!txtAffichage.Text.Contains("."))
            {
                txtAffichage.Text += ".";
            }
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                txtAffichage.Text = "";
                isOperationPerformed = false;
            }

            Button button = (Button)sender;
            input += button.Text;
            txtAffichage.Text += button.Text;
        }
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAffichage.Text))
            {
                operand1 = txtAffichage.Text;
                operation = ((Button)sender).Text[0];
                isOperationPerformed = true;
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = txtAffichage.Text;

            try
            {
                double num1 = Convert.ToDouble(operand1);
                double num2 = Convert.ToDouble(operand2);
                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            MessageBox.Show("Division by zero is not allowed!");
                            return;
                        }
                        break;
                }

                txtAffichage.Text = result.ToString();
                input = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtAffihage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
