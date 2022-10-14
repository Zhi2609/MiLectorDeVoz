using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //Agregamos la Libreria
using System.Speech; //Agregamos la Referencia
using System.Speech.Synthesis; //Agregamos la Voz

namespace MiLectorDeVoz
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer reader = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            reader.SpeakAsync(label1.Text); //Leemos el Contenido
        }

        private void Bandeja_Click(object sender, EventArgs e)
        {
            Stream str;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if((str=openFileDialog.OpenFile())!=null)
                {
                    string fname = openFileDialog.FileName;
                    string filetext = File.ReadAllText(fname);
                    label1.Text = filetext;
                }
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if(reader != null)
            {
                reader.Pause();
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if(reader!=null)
            {
                if(reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
            }
        }
    }
}
