using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoInteligenciaArtificialV2.Clases;

namespace ProyectoInteligenciaArtificialV2
{
    public partial class FormPrincipal : Form
    {
        private Form currentChildForm;
        private List<Patron> Patrones;
        private FormMenuParametrosMulticapa formMenuParametrosMulticapa;
        private FormMenuParametrosUnicapa formMenuParametrosUnicapa;
        public FormPrincipal()
        {
            InitializeComponent();
            comboBoxEstiloDeRed.SelectedIndex = 0;
            
        }


        private void nuevoForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            this.Height = childForm.Height+35;
            this.Width = childForm.Width+20;
            panelPrincipal.Width = childForm.Width+20;
            panelPrincipal.Height= childForm.Height + 35;
            childForm.Show();
        }


        public List<string> leerPatrones(string direccionArchivo)
        {
            string textoArchivo;
            TextReader informacionArchivo = new StreamReader(direccionArchivo);
            textoArchivo = informacionArchivo.ReadToEnd();
            informacionArchivo.Close();
            List<string> patrones = new List<string>();
            patrones.AddRange(textoArchivo.Split('\n'));
            return patrones;
        }

        public Patron separarEntradasYSalidas(string patron)
        {
                List<string> entradasYSalidas = new List<string>();
                entradasYSalidas.AddRange(patron.Split('_'));
                Patron patron_ = new Patron();
                patron_.Entradas = new List<int>();
                patron_.Salidas = new List<int>();
                patron_.Entradas = entradasYSalidas[0].Split(';').Select(x => Convert.ToInt32(x)).ToList<int>();
                patron_.Salidas = entradasYSalidas[1].Split(';').Select(x => Convert.ToInt32(x)).ToList<int>();
                return patron_;   
        }

        public List<Patron> organizarPatrones(List<string> patrones)
        {
            int numeroPatrones = patrones.Count();
            List<Patron> resultadoPatrones = new List<Patron>();
            for (int i = 0; i < numeroPatrones; i++)
            {
                resultadoPatrones.Add(separarEntradasYSalidas(patrones[i]));
            }
            return resultadoPatrones;
        }

        private void buttonBuscarArchivo_Click(object sender, EventArgs e)
        {
            string rutaDeArchivo = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaDeArchivo = openFileDialog.FileName;
                    textDireccionArchivo.Text = rutaDeArchivo;
                    Patrones = organizarPatrones(leerPatrones(rutaDeArchivo));
                    buttonContinuar.Visible = true;
                    //MessageBox.Show("Entradas: "+Patrones[0].Entradas.Count+"\nSalidas: "+ Patrones[0].Salidas.Count+"\nPatrones: "+Patrones.Count);
                    labelEntradas.Text += Patrones[0].Entradas.Count;
                    labelSalidas.Text += Patrones[0].Salidas.Count;
                    labelPatrones.Text += Patrones.Count;
                }
                catch (Exception)
                {
                    MessageBox.Show("El tipo de archivo seleccionado no es compatible con el programa");
                }
            }
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (comboBoxEstiloDeRed.SelectedItem.ToString().Equals("Unicapa"))
            {
                formMenuParametrosUnicapa = new FormMenuParametrosUnicapa(Patrones);
                nuevoForm(formMenuParametrosUnicapa);
                //formMenuParametrosUnicapa.Show();
            }
            if (comboBoxEstiloDeRed.SelectedItem.ToString().Equals("Multicapa"))
            {
                formMenuParametrosMulticapa = new FormMenuParametrosMulticapa(Patrones);
                nuevoForm(formMenuParametrosMulticapa);
                
            }
        }
    }
}
