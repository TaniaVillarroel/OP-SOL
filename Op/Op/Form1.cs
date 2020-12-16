using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Op
{
    public partial class Form1 : Form
    {
        int CantCapataces;
        int CantOficiales;
        double AcumSueldo;

        public Form1()
        {
            InitializeComponent();
             CantCapataces = 0;
            CantOficiales = 0;
            AcumSueldo = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Operario o = new Operario();
            o.pDni = Convert.ToInt32(txtDni.Text);
            o.pNombre = txtNombre.Text;
            o.pCategoria=cboCategoria.SelectedIndex +1;
            o.pHsTrabajadas = Convert.ToInt32(txtHsTrabajadas.Text);
            o.pPrecioHora = Convert.ToInt32(txtPrecioHora.Text);

            //calcular sueldo//
            lblSueldo.Text = o.calcularSueldo().ToString();
            //calcular total sueldos//
           
            AcumSueldo += o.calcularSueldo();
            lblTotalSueldos.Text=AcumSueldo.ToString();


            //Cantidad de capataces-oficiales//
          
               switch (o.pCategoria)
            {
                case 1: CantOficiales++; break;
                case 2: CantCapataces++; break;
                default: break;
            }
         
            lblCantOficiales.Text = CantOficiales.ToString();
            lblCantCapataces.Text = CantCapataces.ToString();

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
