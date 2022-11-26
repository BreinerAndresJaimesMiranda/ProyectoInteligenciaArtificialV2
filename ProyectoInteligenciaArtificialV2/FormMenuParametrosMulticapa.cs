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
    public partial class FormMenuParametrosMulticapa : Form
    {
        RedNeuronalArtificial RedNeuronal;
        List<Patron> Patrones;
        public FormMenuParametrosMulticapa(List<Patron> patrones_)
        {
            Patrones = patrones_;
            InitializeComponent();
            listBoxNumeroDeCapas.SelectedIndex = 0;
            listBoxAlgoritmoDeEntrenamiento.SelectedIndex = 0;
            listBoxFuncionActivacionCapa1.SelectedIndex = 0;
            listBoxFuncionActivacionCapa2.SelectedIndex = 0;
            listBoxFuncionActivacionCapa3.SelectedIndex = 0;
            listBoxFuncionActivacionCapaSalida.SelectedIndex = 0;
            comboBoxTipoDeRed.SelectedIndex = 0;
            numeroDeNeuronasCapaSalida.Text = numeroDeNeuronasCapaSalida.Text + patrones_[0].Salidas.Count;
         
            panelCapa1.Enabled = true;
            panelCapa2.Enabled = false;
            panelCapa3.Enabled = false;
        }

        private void listBoxNumeroDeCapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNumeroDeCapas.SelectedIndex == 0)
            {
                
                panelCapa2.Enabled = false;
                panelCapa3.Enabled = false;
                
            }
            if (listBoxNumeroDeCapas.SelectedIndex == 1)
            {
                panelCapa1.Enabled = true;
                panelCapa2.Enabled = true;
                panelCapa3.Enabled = false;
               
            }
            if (listBoxNumeroDeCapas.SelectedIndex == 2)
            {
                panelCapa1.Enabled = true;
                panelCapa2.Enabled = true;
                panelCapa3.Enabled = true;

                
            }
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            Patron patron = Patrones[0];
            string textoMatrizCapa1 = "";
            string textoUmbralCapa1 = "";

            string textoMatrizCapa2 = "";
            string textoUmbralCapa2 = "";

            string textoMatrizCapa3 = "";
            string textoUmbralCapa3 = "";

            string textoMatrizCapaSalida = "";
            string textoUmbralCapaSalida = "";
            string textoUmbral = "";

            int numeroDeNeuronas = Convert.ToInt32( numericUpDownNumeroDeNeuronasCapa1.Value);
            int numeroDeEntradas = patron.Entradas.Count;
            Capa capaOculta1=new Capa(Patrones[0], numeroDeNeuronas , listBoxFuncionActivacionCapa1.SelectedItem.ToString(), numeroDeEntradas);
            List<Capa> capas = new List<Capa>();
            capas.Add(capaOculta1);
            labelPesosCapa1.Text= convertirListaDeListasDecimalesAString(capas[0].PesosSinapticos);
            labelUmbralesCapa1.Text = convertirListaDecimalAString(capas[0].Umbrales);

            textoMatrizCapa1 = ponerMatrizEnFormatoDeArchivo(capas[0].PesosSinapticos);
            textoUmbral += ponerListaEnFormatoDeArchivo(capas[0].Umbrales);
            textoUmbral += "\n";
            
            if (listBoxNumeroDeCapas.SelectedItem.ToString().Equals("1")==false)
            {
                numeroDeNeuronas = Convert.ToInt32(numericUpDownNumeroDeNeuronasCapa2.Value);
                numeroDeEntradas = capas[0].NumeroDeNeuronas;
                capas.Add(new Capa(Patrones[0], numeroDeNeuronas, listBoxFuncionActivacionCapa2.SelectedItem.ToString(), numeroDeEntradas));
                labelPesosCapa2.Text = convertirListaDeListasDecimalesAString(capas[1].PesosSinapticos);
                labelUmbralesCapa2.Text = convertirListaDecimalAString(capas[1].Umbrales);
                textoMatrizCapa2 = ponerMatrizEnFormatoDeArchivo(capas[1].PesosSinapticos);
                textoUmbral += ponerListaEnFormatoDeArchivo(capas[1].Umbrales);
                textoUmbral += "\n";
            }
            if (listBoxNumeroDeCapas.SelectedItem.ToString().Equals("3"))
            {
                numeroDeNeuronas = Convert.ToInt32(numericUpDownNumeroDeNeuronasCapa3.Value);
                numeroDeEntradas = capas[1].NumeroDeNeuronas;
                capas.Add(new Capa(Patrones[0], numeroDeNeuronas, listBoxFuncionActivacionCapa3.SelectedItem.ToString(), numeroDeEntradas));
                labelPesosCapa3.Text = convertirListaDeListasDecimalesAString(capas[2].PesosSinapticos);
                labelUmbralesCapa3.Text = convertirListaDecimalAString(capas[2].Umbrales);
                textoMatrizCapa3 = ponerMatrizEnFormatoDeArchivo(capas[2].PesosSinapticos);
                textoUmbral += ponerListaEnFormatoDeArchivo(capas[2].Umbrales);
                textoUmbral += "\n";
            }

            numeroDeNeuronas = Patrones[0].Salidas.Count;
            numeroDeEntradas = capas[capas.Count-1].NumeroDeNeuronas;
            capas.Add(new Capa(Patrones[0], numeroDeNeuronas, numeroDeEntradas));
            labelPesosCapaSalida.Text = convertirListaDeListasDecimalesAString(capas[capas.Count - 1].PesosSinapticos);
            labelUmbralesCapaSalida.Text = convertirListaDecimalAString(capas[capas.Count - 1].Umbrales);

            RedNeuronal = new RedNeuronalArtificial(comboBoxTipoDeRed.SelectedItem.ToString(),listBoxAlgoritmoDeEntrenamiento.SelectedItem.ToString(),capas);

            textoMatrizCapaSalida = ponerMatrizEnFormatoDeArchivo(capas[capas.Count - 1].PesosSinapticos);
            textoUmbral += ponerListaEnFormatoDeArchivo(capas[capas.Count - 1].Umbrales);

            string textoMatriz = "";
            

            textoMatriz = textoMatrizCapa1;
            textoMatriz += "\n@\n";
            textoMatriz += textoMatrizCapa2;
            textoMatriz += "\n@\n";
            textoMatriz += textoMatrizCapa3;
            textoMatriz += "\n@\n";
            textoMatriz += textoMatrizCapaSalida;

            TextWriter EscribirMatriz = new StreamWriter("MatricesMulticapa.txt");
            EscribirMatriz.Write(textoMatriz);
            EscribirMatriz.Close();

            
            TextWriter EscribirUmbral = new StreamWriter("umbralMulticapa.txt");
            EscribirUmbral.Write(textoUmbral);
            EscribirUmbral.Close();

        }

     

        private string convertirListaDecimalAString(List<double> lista)
        {
            string resultado = "";
            for (int i = 0; i < lista.Count; i++)
            {
                resultado = resultado + "  " + lista[i].ToString();
            }
            return resultado + "\n";
        }

        private string convertirListaDeListasDecimalesAString(List<List<double>> matriz)
        {
            string resultado = "";
            for (int i = 0; i < matriz.Count; i++)
            {
                resultado = resultado + "\n" + convertirListaDecimalAString(matriz[i]);
            }
            return resultado;
        }

        private string ponerListaEnFormatoDeArchivo(List<double> lista)
        {
            string resultado = "";
            for (int i = 0; i < lista.Count; i++)
            {
                resultado += lista[i].ToString();
                if (i < lista.Count - 1)
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

        private void comboBoxTipoDeRed_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxTipoDeRed.SelectedItem)
            {
                case "Adaline":
                    {
                        
                        
                        listBoxAlgoritmoDeEntrenamiento.Items.Clear();
                        listBoxAlgoritmoDeEntrenamiento.Items.Add("Regla delta");
                        break;
                    }
                case "Perceptron":
                    {
                        
                        listBoxAlgoritmoDeEntrenamiento.Items.Clear();
                        listBoxAlgoritmoDeEntrenamiento.Items.Add("Regla delta");
                        break;
                    }
                case "BackPropagation":
                    {
                        
                        listBoxAlgoritmoDeEntrenamiento.Items.Clear();
                        listBoxAlgoritmoDeEntrenamiento.Items.Add("Propagacion inversa");
                        break;
                    }
            }
            listBoxFuncionActivacionCapa1.SelectedIndex = 0;
            listBoxFuncionActivacionCapa2.SelectedIndex = 0;
            listBoxFuncionActivacionCapa3.SelectedIndex = 0;
            listBoxAlgoritmoDeEntrenamiento.SelectedIndex = 0;

        }
    }
}
