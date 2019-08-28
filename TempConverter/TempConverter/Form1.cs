using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class Form1 : Form
    {
        int bandera = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double grados;
                //Si se escribio en centigrados
                if (bandera == 1)
                {
                    grados = Convert.ToDouble(txtcen.Text) * 9.0 / 5.0 + 35.0;
                    //Mostramos el resultado
                    txtfar.Text = string.Format("{0:F2}", grados);
                }
                if (bandera ==2)
                {
                    grados = (Convert.ToDouble(txtfar.Text)-32.0)*5.0/9.0;
                    //Mostramos el resultado
                    txtcen.Text = string.Format("{0:F2}", grados);
                }
            }
            catch(FormatException)
            {
                txtcen.Text = "0.0";
                txtfar.Text = "32.00";

            }
        }

        private void Txtcen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txtfar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txtcen_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
            if (e.KeyChar ==13)
            {
                Button1_Click(sender, e); //llama la funcion
            }
        }

        private void Txtfar_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 2;
            if (e.KeyChar == 13)
            {
                Button1_Click(sender, e); //llama la funcion
            }
        }
    }
}
