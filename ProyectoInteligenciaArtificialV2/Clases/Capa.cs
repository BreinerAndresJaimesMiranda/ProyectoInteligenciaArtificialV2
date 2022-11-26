using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInteligenciaArtificialV2.Clases
{
    public class Capa
    {

        private static Random random1 = new Random();
        private static Random random2 = new Random();
        private Random random3;
        private Random random4;
        public int NumeroDeNeuronas { get; }
        public int NumeroDeEntradas { get; }
        public string FuncionDeActivacion { get;}
        public Patron patron { set; get; }
        public List<List<double>> PesosSinapticos { set; get; }
        public List<double> Umbrales { set; get; }

        public Capa(Patron patron_, string funcionDeActivacion_)
        {
            patron = patron_;
            FuncionDeActivacion = funcionDeActivacion_;
            NumeroDeNeuronas = patron.Salidas.Count();
            NumeroDeEntradas = patron.Entradas.Count();
            llenarPesosSinapticosYUmbrales(patron.Salidas.Count());
        }

        public Capa(Patron patron_, int numeroDeNeuronas_,int numeroDeEntradas_)
        {
            NumeroDeEntradas = numeroDeEntradas_;
            patron = patron_;
            NumeroDeNeuronas = numeroDeNeuronas_;
            FuncionDeActivacion = string.Empty;
            llenarPesosSinapticosYUmbrales(numeroDeNeuronas_);
        }

        public Capa(Patron patron_, int numeroDeNeuronas_,string funcionDeActivacion_, int numeroDeEntradas_)
        {
            patron = patron_;
            NumeroDeEntradas = numeroDeEntradas_;
            NumeroDeNeuronas = numeroDeNeuronas_;
            FuncionDeActivacion = funcionDeActivacion_;
            llenarPesosSinapticosYUmbrales(numeroDeNeuronas_);
        }
        private void llenarPesosSinapticosYUmbrales(int numeroSalidas)
        {
            double valorRandom;
            random3 = new Random(random1.Next());
            random4= new Random(random2.Next()+1);
            Umbrales = new List<double>();
            PesosSinapticos = new List<List<double>>();
            for (int i = 0; i < numeroSalidas; i++)
            {
                valorRandom = random3.NextDouble();
                if (random3.Next(1, 3) == 2)
                {
                    valorRandom = valorRandom * -1;
                }
                Umbrales.Add(valorRandom);
            }

            for (int i = 0; i < NumeroDeEntradas; i++)
            {
                for (int j = 0; j < numeroSalidas; j++)
                {
                    PesosSinapticos.Add(new List<double>());
                    valorRandom = random4.NextDouble();
                    if (random4.Next(1, 3) == 2)
                    {
                        valorRandom = valorRandom * -1;
                    }
                    PesosSinapticos[i].Add(valorRandom);
                }
            }
        }

        private double generarNumeroRandomEntreUnoYMenosUno()
        {
            double resultado = random1.NextDouble();
            
                
            
            if (random2.Next(1,3)==2)
            {
                resultado = resultado * -1;
            }
            
            return resultado;
        }


    }
}
