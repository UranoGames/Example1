using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica__2_testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void BotonesDefault()
        {
            try
            {


                uno.Enabled = false; uno.BackColor = System.Drawing.Color.White;
                dos.Enabled = false; dos.BackColor = System.Drawing.Color.White;
                tres.Enabled = false; tres.BackColor = System.Drawing.Color.White;
                cuatro.Enabled = false; cuatro.BackColor = System.Drawing.Color.White;
                cinco.Enabled = false; cinco.BackColor = System.Drawing.Color.White;
                seis.Enabled = false; seis.BackColor = System.Drawing.Color.White;
                siete.Enabled = false; siete.BackColor = System.Drawing.Color.White;
                ocho.Enabled = false; ocho.BackColor = System.Drawing.Color.White;
                nueve.Enabled = false; nueve.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                MessageBox.Show("No se pueden bloquear los botones ni cambiar color");
            }
        }
        public void DeshabilitarBotones(string element) //en esta funcion deshabilito todos los botones excepto el que le paso por parametro
        {
            try
            {


                if (Color.SelectedIndex == 1) //color igual a verde
                {
                    BotonesDefault();
                    if (element == "uno")
                    {
                        uno.Enabled = true;
                        uno.BackColor = System.Drawing.Color.Green;
                    }
                    else if (element == "dos")
                    {
                        dos.Enabled = true;
                        dos.BackColor = System.Drawing.Color.Green;
                    }
                    else if (element == "tres")
                    {
                        tres.Enabled = true;
                        tres.BackColor = System.Drawing.Color.Green;
                    }
                    else if (element == "cuatro")
                    {
                        cuatro.Enabled = true;
                        cuatro.BackColor = System.Drawing.Color.Green;
                    }
                    else if (element == "cinco")
                    {
                        cinco.Enabled = true;
                        cinco.BackColor = System.Drawing.Color.Green;
                    }
                    else if (element == "seis")
                    {
                        seis.Enabled = true;
                        seis.BackColor = System.Drawing.Color.Green;
                    }
                    else if (element == "siete")
                    {
                        siete.Enabled = true;
                        siete.BackColor = System.Drawing.Color.Green;
                    }
                    else if (element == "ocho")
                    {
                        ocho.Enabled = true;
                        ocho.BackColor = System.Drawing.Color.Green;
                    }
                    else if (element == "nueve")
                    {
                        nueve.Enabled = true;
                        nueve.BackColor = System.Drawing.Color.Green;
                    }
                }
                else if (Color.SelectedIndex == 0) //color igual a rojo
                {
                    BotonesDefault();
                    if (element == "uno")
                    {
                        uno.Enabled = true;
                        uno.BackColor = System.Drawing.Color.Red;
                    }
                    else if (element == "dos")
                    {
                        dos.Enabled = true;
                        dos.BackColor = System.Drawing.Color.Red;
                    }
                    else if (element == "tres")
                    {
                        tres.Enabled = true;
                        tres.BackColor = System.Drawing.Color.Red;
                    }
                    else if (element == "cuatro")
                    {
                        cuatro.Enabled = true;
                        cuatro.BackColor = System.Drawing.Color.Red;
                    }
                    else if (element == "cinco")
                    {
                        cinco.Enabled = true;
                        cinco.BackColor = System.Drawing.Color.Red;
                    }
                    else if (element == "seis")
                    {
                        seis.Enabled = true;
                        seis.BackColor = System.Drawing.Color.Red;
                    }
                    else if (element == "siete")
                    {
                        siete.Enabled = true;
                        siete.BackColor = System.Drawing.Color.Red;
                    }
                    else if (element == "ocho")
                    {
                        ocho.Enabled = true;
                        ocho.BackColor = System.Drawing.Color.Red;
                    }
                    else if (element == "nueve")
                    {
                        nueve.Enabled = true;
                        nueve.BackColor = System.Drawing.Color.Red;
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pueden deshabilitar los botones");
            }
            
        }
        public void SeleccionBotones()
        {
            try
            {


                if (CoordX.SelectedIndex == 0 && CoordY.SelectedIndex == 0) //coord 0,0
                {
                    DeshabilitarBotones("uno");
                }
                else if (CoordX.SelectedIndex == 0 && CoordY.SelectedIndex == 1) //coord 0,1
                {
                    DeshabilitarBotones("dos");
                }
                else if (CoordX.SelectedIndex == 0 && CoordY.SelectedIndex == 2)// coord 0,2
                {
                    DeshabilitarBotones("tres");
                }
                //----------------------------------------------------------------
                if (CoordY.SelectedIndex == 1 && CoordY.SelectedIndex == 0) //coord 1,0
                {
                    DeshabilitarBotones("cuatro");
                }
                else if (CoordX.SelectedIndex == 1 && CoordY.SelectedIndex == 1) //coord 1,1
                {
                    DeshabilitarBotones("cinco");
                }
                else if (CoordX.SelectedIndex == 1 && CoordY.SelectedIndex == 2)// coord 1,2
                {
                    DeshabilitarBotones("seis");
                }
                //----------------------------------------------------------------
                if (CoordX.SelectedIndex == 2 && CoordY.SelectedIndex == 0) //coord 2,0
                {
                    DeshabilitarBotones("siete");
                }
                else if (CoordX.SelectedIndex == 2 && CoordY.SelectedIndex == 1) //coord 2,1
                {
                    DeshabilitarBotones("ocho");
                }
                else if (CoordX.SelectedIndex == 2 && CoordY.SelectedIndex == 2)// coord 2,2
                {
                    DeshabilitarBotones("nueve");
                }
            }
            catch
            {
                MessageBox.Show("Error en los indices");
            }
            //capturamos cualquier error
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {


                SeleccionBotones();
            }
            catch
            {
                MessageBox.Show("No se puede implementar el metodo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
