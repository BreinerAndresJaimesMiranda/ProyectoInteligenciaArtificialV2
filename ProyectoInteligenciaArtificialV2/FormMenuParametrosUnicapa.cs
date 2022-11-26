using ProyectoInteligenciaArtificialV2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInteligenciaArtificialV2
{
    public partial class FormMenuParametrosUnicapa : Form
    {
        RedNeuronalArtificial RedNeuronal;
        List<Patron> Patrones;
        public FormMenuParametrosUnicapa(List<Patron> patrones_)
        {
            Patrones=patrones_;
            InitializeComponent();
            comboBoxTipoDeRed.SelectedIndex = 0;
            listBoxFuncionDeActivacion.SelectedIndex = 0;
            listBoxAlgoritmoDeEntrenamiento.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            string funcionDeActivacion = listBoxFuncionDeActivacion.SelectedItem.ToString();
            Capa capa= new Capa(Patrones[0],funcionDeActivacion);
            labelPesos.Text= convertirListaDeListasDecimalesAString(capa.PesosSinapticos,"pruebaMatrizUnicapa");
            labelUmbrales.Text = convertirListaDecimalAString(capa.Umbrales);
            string textoMatriz = "";
            string textoUmbral = "";
            textoMatriz = ponerMatrizEnFormatoDeArchivo(capa.PesosSinapticos);

            TextWriter EscribirMatriz = new StreamWriter("MatrizUnicapa.txt");
            EscribirMatriz.Write(textoMatriz);
            EscribirMatriz.Close();

            textoUmbral = ponerListaEnFormatoDeArchivo(capa.Umbrales);
            TextWriter EscribirUmbral = new StreamWriter("umbralUnicapa.txt");
            EscribirUmbral.Write(textoUmbral);
            EscribirUmbral.Close();

            RedNeuronal = new RedNeuronalArtificial(comboBoxTipoDeRed.SelectedItem.ToString(), listBoxAlgoritmoDeEntrenamiento.SelectedItem.ToString(), capa);
        }


        private string ponerListaEnFormatoDeArchivo(List<double> lista)
        {
            string resultado = "";
            for (int i = 0; i < lista.Count; i++)
            {
                resultado += lista[i].ToString();
                if (i< lista.Count-1 )
                {
                    resultado += ";";
                }
            }

            return resultado;
        }

        private string ponerMatrizEnFormatoDeArchivo(List<List<double>> lista)
        {
            string resultado = "";
            for (int i = 0; i < lista.Count; i++)
            {
                resultado += ponerListaEnFormatoDeArchivo(lista[i]);
                if (i < lista.Count - 1)
                {
                    resultado += "\n";
                }
            }
            return resultado;
        }

        private string convertirListaDecimalAString(List<double> lista)
        {
            string resultado = "";
            for(int i = 0; i < lista.Count; i++)
            {
                resultado = resultado + "  " + lista[i].ToString();
            }
            return resultado;
        }

        private string convertirListaDeListasDecimalesAString(List<List<double>> matriz,string nombreArchivo)
        {
            
            string resultado = "";
            for(int i = 0; i< matriz.Count; i++)
            {
                
                resultado = resultado + "\n" + convertirListaDecimalAString(matriz[i]);
            }
            
            return resultado;
        }

        private void comboBoxTipoDeRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoDeRed.SelectedItem)
            {
                case "Adaline":
                    {
                        listBoxFuncionDeActivacion.Items.Clear();
                        listBoxFuncionDeActivacion.Items.Add("Lineal");
                        listBoxAlgoritmoDeEntrenamiento.Items.Clear();
                        listBoxAlgoritmoDeEntrenamiento.Items.Add("Regla delta");
                        break;
                    }
                case "Perceptron":
                    {
                        listBoxFuncionDeActivacion.Items.Clear();
                        listBoxFuncionDeActivacion.Items.Add("Escalon");
                        listBoxAlgoritmoDeEntrenamiento.Items.Clear();
                        listBoxAlgoritmoDeEntrenamiento.Items.Add("Regla delta");
                        break;
                    }
                case "BackPropagation":
                    {
                        listBoxFuncionDeActivacion.Items.Clear();
                        listBoxFuncionDeActivacion.Items.Add("Sigmoide");
                        listBoxFuncionDeActivacion.Items.Add("Tangente Hiperbolica");
                        listBoxAlgoritmoDeEntrenamiento.Items.Clear();
                        listBoxAlgoritmoDeEntrenamiento.Items.Add("Propagacion inversa");
                        break;
                    }
            }
            listBoxFuncionDeActivacion.SelectedIndex = 0;
            listBoxAlgoritmoDeEntrenamiento.SelectedIndex = 0;
        }
    }
}
