using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVector11
{
    class PruebaVector11
    {
        private string[] nombres;
        private float[] sueldos;


          static void Main(string[] args)
        {
            PruebaVector11 aa = new PruebaVector11();
            aa.Cargar();
            aa.MayorSueldo();
        }

        public void Cargar() 
        {
            nombres=new string[5];
            sueldos=new float[5];

            for(int h=0;h < nombres.Length;h++) 
            {
                Console.Write("Nombre del empleado:");
                nombres[h] = Console.ReadLine();


                Console.Write("Sueldo de el empleado:");
                string linea;
                linea = Console.ReadLine();
                sueldos[h]=float.Parse(linea);
            }
        }

        public void MayorSueldo() 
        {
            float mayor;
            int pos;
            mayor=sueldos[0];

            pos=0;
            for(int h=1;h < nombres.Length;h++) 
            {
                if (sueldos[h] > mayor) 
                {
                    mayor=sueldos[h];
                    pos=h;
                }
            }
            Console.WriteLine("El empleado con mayor sieldo es "+nombres[pos]);
            Console.WriteLine("El Empleado"+""+nombres[pos]+""+"tiene un sueldo:"+mayor);
            Console.ReadKey();
        }

      
    }
}