using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Op
{
    class Operario
    {
        int dni;
        string nombre;
        int categoria;
        double hsTtabajadas;
        double precioHora;
       

        public Operario()
        {
            dni = 0;
            nombre = "";
            categoria = 0;
            hsTtabajadas = 0;
            precioHora = 0;
          
        }
        public Operario(int d,string nom, int categ,double hs, double preHora)
        {
            dni = d;
            nombre = nom;
            categoria = categ;
            hsTtabajadas = hs;
            precioHora = preHora;
          
        }
        public int pDni
        {
            set { dni = value; }
            get { return dni; }
        }
        public string pNombre
        {
            set { nombre= value; }
            get { return nombre; }
        }
        public int pCategoria
        {
            set { categoria = value; }
            get { return categoria; }
        }
        public double pHsTrabajadas
        {
            set { hsTtabajadas = value; }
            get { return hsTtabajadas; }
        }
        public double pPrecioHora
        {
            set { precioHora= value; }
            get { return precioHora; }
        }

        
    public string toString()
 {
          string categoriaa;
          switch (categoria)
         {
           case 1: categoriaa = "Oficial"; break;
           case 2: categoriaa = "Capataz"; break;
           default: categoriaa = "Otra"; break;
         }
          return categoriaa;

 }
           public double calcularSueldo()
          {
             return precioHora * hsTtabajadas;
          }


    }
}
