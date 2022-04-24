using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajoprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        

        private void btcargar_Click(object sender, EventArgs e)
        {
            int dia;

            dia = 7;
            dia = System.Convert.ToInt32(txtdia.Text);

            switch (dia)
            {
                case 1:
                    MessageBox.Show("lunes");
                    break;
                case 2:
                    MessageBox.Show("martes");
                    break;
                case 3:
                    MessageBox.Show("miercoles");
                    break;
                case 4:
                    MessageBox.Show("jueves");
                    break;
                case 5:
                    MessageBox.Show("viernes");
                    break;
                case 6:
                    MessageBox.Show("sabado");
                    break;
                case 7:
                    MessageBox.Show("domingo");
                    break;
            }
        }

        private void bttaño_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtaño.Text);
        }

        private void bttmes_Click(object sender, EventArgs e)
        {
            int mes;
            mes = System.Convert.ToInt32(txtmess.Text);

            if (mes >= 0 && mes <= 12)

                if (mes == 1)
                    MessageBox.Show("enero");
            if (mes == 2)
                MessageBox.Show("febrero");
            if (mes == 3)
                MessageBox.Show("marzo");
            if (mes == 4)
                MessageBox.Show("abril");
            if (mes == 5)
                MessageBox.Show("mayo");
            if (mes == 6)
                MessageBox.Show("junio");
            if (mes == 7)
                MessageBox.Show("julio");
            if (mes == 8)
                MessageBox.Show("agosto");
            if (mes == 9)
                MessageBox.Show("septiembre");
            if (mes == 10)
                MessageBox.Show("octubre");
            if (mes == 11)
                MessageBox.Show("noviembre");
            if (mes == 12)
                MessageBox.Show("diciembre");
        }
    }  }   

