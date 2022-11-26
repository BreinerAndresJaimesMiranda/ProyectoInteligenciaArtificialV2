using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInteligenciaArtificialV2.Clases
{
    public class RedNeuronalArtificial
    {
        public Boolean EsMulticapa { get;}
        public string AlgoritmoDeEntrenamiento { get; set; }
        public int Iteraciones { get; set; }
        public double RataDeAprendizaje { get; set; }
        public double ErrorMaximoPermitido { get; set; }
        public string TipoDeRed { get;}
        public int NumeroDeCapas { get;}
        public List<Capa> Capas { get; set; }

        public RedNeuronalArtificial(string tipoDeRed_,string algoritmoDeEntrenamiento_,List<Capa> capas_)
        {
            AlgoritmoDeEntrenamiento = algoritmoDeEntrenamiento_;
            EsMulticapa = false;
            TipoDeRed = tipoDeRed_;
            NumeroDeCapas = capas_.Count;
            Capas = capas_;
            if (NumeroDeCapas>1)
            {
                EsMulticapa = true;
            }
        }

        public RedNeuronalArtificial(string tipoDeRed_, string algoritmoDeEntrenamiento_, Capa capa)
        {
            Capas = new List<Capa>();
            AlgoritmoDeEntrenamiento = algoritmoDeEntrenamiento_;
            EsMulticapa = false;
            TipoDeRed = tipoDeRed_;
            NumeroDeCapas = 1;
            Capas.Add(capa);
        }
    }
}
