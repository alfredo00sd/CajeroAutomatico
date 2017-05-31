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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnValidarReg_Click(object sender, EventArgs e)
        {
            try
            {   ///se cumple si y solo si el usuario se registro correctamente.
                Properties.Settings.Default.Nombre = textBoxRegName.Text;
                Properties.Settings.Default.Apellidos = textBox2.Text;
                Properties.Settings.Default.Clave = textBoxCuenta.Text;
                Properties.Settings.Default.Balance = textBoxBalance.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Se han Guardado correctamente sus datos Sr. " + textBoxRegName.Text);
                this.Hide();
                    
                
            }
            catch (Exception) { throw; }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
           
        }
    }
}
