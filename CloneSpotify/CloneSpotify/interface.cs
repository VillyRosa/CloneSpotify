using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CloneSpotify
{
    public partial class TelaPrincipal : Form
    {
        //Variaveis para saber se a música foi curtida ou não
        char curt1;
        char curt2;
        char curt3;
        char curt4;

        public TelaPrincipal()
        {
            InitializeComponent();  
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Deixando visivel apenas o painel de Início
            painelInicio.Visible = true;
            painelBiblioteca.Visible = false;
            painelMusicasCurtidas.Visible = false;
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            //Deixando visivel apenas o painel da Biblioteca
            painelInicio.Visible = false;
            painelBiblioteca.Visible = true;
            painelMusicasCurtidas.Visible = false;
        }

        private void btnCurtidas_Click(object sender, EventArgs e)
        {
            //Deixando visivel apenas o painel de Músicas Curtidas
            painelInicio.Visible = false;
            painelBiblioteca.Visible = false;
            painelMusicasCurtidas.Visible = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int musicaAleatoria = numAleatorio.Next(1, 5);

            //Deixando visivel todos os botoes play 
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
            btnDoIWannaKnow.Visible = true;

            //Deixando invisivel todos os botoes de pausa
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopDoIWannaKnow.Visible = false;

            //Caso o número aleatório for 1 toca Do I Wanna Know
            if (musicaAleatoria.ToString() == "1")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
                musicDoIWannaKnow.Play();

                btnDoIWannaKnow.Visible = false;
                btnStopDoIWannaKnow.Visible = true;
            }

            //Caso o número aleatório for 2 toca Sweater Weather
            if (musicaAleatoria.ToString() == "2")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Sweater-Weather.wav");
                musicDoIWannaKnow.Play();

                btnPlaySweaterWeather.Visible = false;
                btnStopSweaterWeather.Visible = true;
            }

            //Caso o número aleatório for 3 toca Without Me
            if (musicaAleatoria.ToString() == "3")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Without-Me.wav");
                musicDoIWannaKnow.Play();

                btnPlayWithoutMe.Visible = false;
                btnStopWithoutMe.Visible = true;
            }

            //Caso o número aleatório for 4 toca Alive
            if (musicaAleatoria.ToString() == "4")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Alive.wav");
                musicDoIWannaKnow.Play();

                btnPlayAlive.Visible = false;
                btnStopAlive.Visible = true;
            }
        }

        private void btnDoIWannaKnow_Click(object sender, EventArgs e)
        {
            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
            musicDoIWannaKnow.Play();           

            //Trocando para o botao de pausa
            btnDoIWannaKnow.Visible = false;
            btnStopDoIWannaKnow.Visible = true;

            //Deixando invisivel os botoes de pausa das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true; 
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
        }

        private void btnStopDoIWannaKnow_Click(object sender, EventArgs e)
        {
            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
            musicDoIWannaKnow.Stop();

            //Trocando para o botao de iniciar a música
            btnDoIWannaKnow.Visible = true;
            btnStopDoIWannaKnow.Visible = false;
        }

        private void btnPlaySweaterWeather_Click(object sender, EventArgs e)
        {
            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicSweaterWeather = new SoundPlayer(@"Sweater-Weather.wav");
            musicSweaterWeather.Play();

            //Trocando para o botao de pausa
            btnPlaySweaterWeather.Visible = false;
            btnStopSweaterWeather.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopDoIWannaKnow.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlayAlive.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnDoIWannaKnow.Visible = true;
        }

        private void btnStopSweaterWeather_Click(object sender, EventArgs e)
        {
            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicSweaterWeather = new SoundPlayer(@"Sweater-Weather.wav");
            musicSweaterWeather.Stop();

            //Trocando para o botao de iniciar a música
            btnPlaySweaterWeather.Visible = true;
            btnStopSweaterWeather.Visible = false;
        }

        private void btnPlayWithoutMe_Click(object sender, EventArgs e)
        {
            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicWithoutMe = new SoundPlayer(@"Without-Me.wav");
            musicWithoutMe.Play();

            //Trocando para o botao de pausa
            btnPlayWithoutMe.Visible = false;
            btnStopWithoutMe.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopDoIWannaKnow.Visible = false;
            btnStopAlive.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true;
            btnPlayAlive.Visible = true;
            btnDoIWannaKnow.Visible = true;
        }

        private void btnStopWithoutMe_Click(object sender, EventArgs e)
        {
            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicWithoutMe = new SoundPlayer(@"Without-Me.wav");
            musicWithoutMe.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayWithoutMe.Visible = true;
            btnStopWithoutMe.Visible = false;
        }

        private void btnPlayAlive_Click(object sender, EventArgs e)
        {
            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicAlive = new SoundPlayer(@"Alive.wav");
            musicAlive.Play();

            //Trocando para o botao de pausa
            btnPlayAlive.Visible = false;
            btnStopAlive.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopDoIWannaKnow.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnDoIWannaKnow.Visible = true;
        }

        private void btnStopAlive_Click(object sender, EventArgs e)
        {
            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicAlive = new SoundPlayer(@"Alive.wav");
            musicAlive.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayAlive.Visible = true;
            btnStopAlive.Visible = false;
        }

        private void PainelWithoutMe_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void painelInicio_Paint(object sender, PaintEventArgs e)
        {

        }
      
    }
}
