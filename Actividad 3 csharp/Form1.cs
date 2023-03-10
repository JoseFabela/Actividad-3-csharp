using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Actividad_3_csharp
{
    public partial class Form1 : Form
    {
        private int cantidadPersonas = 0;
        private int RegistradosInt = 0;
        private Contacto[] arreglo;

        public Form1()
        {
            InitializeComponent();
        }






        
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if ((RegistradosInt < cantidadPersonas))
            {
                var nuevocontacto = new Contacto();

                nuevocontacto.FechaDenacimiento = dtpFecha.Value;
                nuevocontacto.Nombre = txtNombre.Text;
                nuevocontacto.Telefono = txttelefono.Text;
                nuevocontacto.Correo = txtCorreo.Text;
                arreglo[RegistradosInt] = nuevocontacto;
                RegistradosInt = RegistradosInt + 1;
                string nuevaLinea = nuevocontacto.Nombre + ", " + nuevocontacto.Edad.ToString() + ", " + nuevocontacto.Telefono.ToString() + ", " + nuevocontacto.Correo.ToString() + Environment.NewLine;
                lblMostrar.Text = lblMostrar.Text + nuevaLinea;
            }
            else
                Interaction.MsgBox("Ya se registraron todos");
        }
        private void Cantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(txtCantidad.Text);
            cantidadPersonas = valor;
            RegistradosInt = 0;
            arreglo = new Contacto[cantidadPersonas + 1];
        }
    }
}