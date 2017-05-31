using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            textBox2.Text += "0";
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string clave = Properties.Settings.Default.Clave;
            string nombre = Properties.Settings.Default.Nombre;

            if (textBox2.Text == clave) 
            {
                tabControl1.SelectTab(1);
                MessageBox.Show("Bienvenido a Banreservas su banco fuera del banco Sr. "+nombre);
            }
            else
            {
                MessageBox.Show("Lo sentimos Sr/a. " +nombre + " Su clave es incorrecta", "validacion");
                textBox2.Text="";
            
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por utilizar nuestros servicios hasta la proxima");
            Application.Exit();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            lbnumBalance.Text = Properties.Settings.Default.Balance;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            textBox2.Text = "";

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            FormUsuarios obj = new FormUsuarios();
            obj.ShowDialog();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            string nombre = Properties.Settings.Default.Nombre;
            string request = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad que desea retirar", "Retiro");
            double money = double.Parse(request);
            MessageBox.Show("Se han retirado RD$"+money+" exitosamente de su cuenta Sr/a. "+nombre);
            aux.Text = Properties.Settings.Default.Balance;
            retiro(money);

        }
        private void retiro(double cantidad){
            double balance = double.Parse(aux.Text);  
            //validacion
            if (balance >= cantidad)
            {
                double b = balance - cantidad;
                Properties.Settings.Default.Balance = Convert.ToString(b);
                Properties.Settings.Default.Save();
            }
            else 
            {
                MessageBox.Show("Balance insuficiente", "**Fallo en al transferencia**");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            string nombre = Properties.Settings.Default.Nombre;
            string into = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad que desea Depositar", "Deposito");
            double money2 = double.Parse(into);
            MessageBox.Show("Se han Depositado RD$"+money2+" exitosamente a su cuenta Sr. "+nombre);
            aux2.Text = Properties.Settings.Default.Balance;
            deposito(money2);
        }
        private void deposito(double monto)
        {
            double balance = double.Parse(aux2.Text);
            //validacion
            if (balance >= monto)
            {
                double d = balance + monto;
                Properties.Settings.Default.Balance = Convert.ToString(d);
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Fallo en la transferencia", "Transferencia de Deposito");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
