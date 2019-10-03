using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        private List<Cuenta> accounts=new List<Cuenta>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource=(Enum.GetNames(typeof(TipoCuenta)));
            comboBox1.SelectedIndex = 3;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Porfavor inserte un nombre");
            }
            else
            {
                TipoCuenta t;
                Enum.TryParse<TipoCuenta>(comboBox1.SelectedText, out t);
                switch (comboBox1.SelectedIndex)
                {
                    case 3:
                        t = TipoCuenta.Basic;
                        break;
                    case 2:
                        t = TipoCuenta.Black;
                        break;
                    case 1:
                        t = TipoCuenta.Platinum;
                        break;
                    case 0:
                        t = TipoCuenta.Gold;
                        break;
                    default:
                        t = TipoCuenta.Basic;
                        break;
                }

                Cuenta acc = CuentaBuilder.Crear(t)
                    .SetTasa(Convert.ToDouble(numericUpDown2.Value))
                    .SetNumero(Convert.ToDouble(numericUpDown1.Value))
                    .SetNumero(Convert.ToDouble(numericUpDown1.Value))
                    .SetPropietario(textBox1.Text)
                    .Crear();
                accounts.Add(acc);
                StringBuilder text = new StringBuilder();
                foreach (var account in accounts)
                {
                    text.AppendLine(account.ToString());;
                }

                textBox2.Text = text.ToString();
                textBox1.Text = "";
            }
        }
    }
}
