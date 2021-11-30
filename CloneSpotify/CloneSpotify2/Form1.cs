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

namespace CloneSpotify2
{
    public partial class CloneSpotify : Form
    {
        int contador = 0;
        int music1;
        int music2;
        int music3;
        int music4;

        int varLocation = 141;


        public CloneSpotify()
        {
            InitializeComponent();
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

            if (btnCurtidoSweaterWheather.Visible)
            {
                PainelSweaterWeatherCurtida.Location = new Point(21, varLocation);
                PainelSweaterWeatherCurtida.Visible = true;
                varLocation = varLocation + 58;
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int musicaAleatoria = numAleatorio.Next(1, 5);

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            //Deixando visivel todos os botoes play 
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;

            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;

            //Deixando invisivel todos os botoes de pausa
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopDoIWannaKnow.Visible = false;

            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;

            //Deixando todas as labels do nome das musicas branca
            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Caso o número aleatório for 1 toca Do I Wanna Know
            if (musicaAleatoria.ToString() == "1")
            {
                contador = 1;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
                musicDoIWannaKnow.Play();

                btnPlayDoIWannaKnow.Visible = false;
                btnStopDoIWannaKnow.Visible = true;

                btnPlayDoIWannaKnowCURTIDA.Visible = false;
                btnStopDoIWannaKnowCurtido.Visible = true;

                lblDoIWannaKnow.ForeColor = Color.FromArgb(29, 185, 84);
                lblDoIWanaKnowCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoDoIWannaKnow.Visible = true;
                lblNomeMusica.Text = ("Do I Wanna Know");
                lblArtista.Text = ("Artic Monkeys");
                lblDuracao.Text = ("4:25");
            }

            //Caso o número aleatório for 2 toca Sweater Weather
            if (musicaAleatoria.ToString() == "2")
            {
                contador = 2;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Sweater-Weather.wav");
                musicDoIWannaKnow.Play();

                btnPlaySweaterWeather.Visible = false;
                btnStopSweaterWeather.Visible = true;

                btnPlaySweaterWeatherCURTIDA.Visible = false;
                btnStopSweaterWeatherCurtido.Visible = true;

                lblSweatherWeather.ForeColor = Color.FromArgb(29, 185, 84);
                lblSweatherWeatherCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoSweaterWeather.Visible = true;
                lblNomeMusica.Text = ("Sweater Weather");
                lblArtista.Text = ("The Neighbourhood");
                lblDuracao.Text = ("3:56");
            }

            //Caso o número aleatório for 3 toca Without Me
            if (musicaAleatoria.ToString() == "3")
            {
                contador = 3;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Without-Me.wav");
                musicDoIWannaKnow.Play();

                btnPlayWithoutMe.Visible = false;
                btnStopWithoutMe.Visible = true;

                btnPlayWithoutMeCURTIDA.Visible = false;
                btnStopWithoutMeCurtido.Visible = true;

                lblWithoutMe.ForeColor = Color.FromArgb(29, 185, 84);
                lblWithoutMeCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoWithoutMe.Visible = true;
                lblNomeMusica.Text = ("Without Me");
                lblArtista.Text = ("Eminem");
                lblDuracao.Text = ("4:47");
            }

            //Caso o número aleatório for 4 toca Alive
            if (musicaAleatoria.ToString() == "4")
            {
                contador = 4;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Alive.wav");
                musicDoIWannaKnow.Play();

                btnPlayAlive.Visible = false;
                btnStopAlive.Visible = true;

                btnPlayAliveCURTIDA.Visible = false;
                btnStopAliveCurtido.Visible = true;

                lblAlive.ForeColor = Color.FromArgb(29, 185, 84);
                lblAliveCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                //Deixando visível as caracteristicas da musica na barra de baixo
                imgFotoAlive.Visible = true;
                lblNomeMusica.Text = ("Alive (It Fells Like)");
                lblArtista.Text = ("Alok");
                lblDuracao.Text = ("2:21");
            }
        }

        private void btnPlayDoIWannaKnow_Click(object sender, EventArgs e)
        {
            contador = 1;

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando a imagem invisivel
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;

            //Deixando visível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = true;
            lblNomeMusica.Text = ("Do I Wanna Know");
            lblArtista.Text = ("Artic Monkeys");
            lblDuracao.Text = ("4:25");

            //Deixando verde a label do nome
            lblDoIWannaKnow.ForeColor = Color.FromArgb(29, 185, 84);
            lblDoIWanaKnowCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
            musicDoIWannaKnow.Play();

            //Trocando para o botao de pausa
            btnPlayDoIWannaKnow.Visible = false;
            btnPlayDoIWannaKnowCURTIDA.Visible = false;
            btnStopDoIWannaKnow.Visible = true;
            btnStopDoIWannaKnowCurtido.Visible = true;

            //Deixando invisivel os botoes de pausa das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
        }

        private void btnStopDoIWannaKnow_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
            musicDoIWannaKnow.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayDoIWannaKnow.Visible = true;
            btnStopDoIWannaKnow.Visible = false;

            btnPlayDoIWannaKnowCURTIDA.Visible = true;
            btnStopDoIWannaKnowCurtido.Visible = false;
        }

        private void btnFavoritarDoIWannaKnow_Click(object sender, EventArgs e)
        {
            btnFavoritarDoIWannaKnow.Visible = false;
            btnCurtidoDoIWannaKnow.Visible = true;

            PainelDoIWannaKnowCurtida.Location = new Point(21, varLocation);
            PainelDoIWannaKnowCurtida.Visible = true;
            varLocation = varLocation + 58;

            music1++;
        }

        private void btnCurtidoDoIWannaKnow_Click(object sender, EventArgs e)
        {
            btnFavoritarDoIWannaKnow.Visible = true;
            btnCurtidoDoIWannaKnow.Visible = false;

            music1--;
        }

        private void btnPlaySweaterWeather_Click(object sender, EventArgs e)
        {
            contador = 2;

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando a imagem invisivel
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;

            imgFotoSweaterWeather.Visible = true;
            lblNomeMusica.Text = ("Sweater Weather");
            lblArtista.Text = ("The Neighbourhood");
            lblDuracao.Text = ("3:56");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.FromArgb(29, 185, 84);
            lblSweatherWeatherCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicSweaterWeather = new SoundPlayer(@"Sweater-Weather.wav");
            musicSweaterWeather.Play();

            //Trocando para o botao de pausa
            btnPlaySweaterWeather.Visible = false;
            btnPlaySweaterWeatherCURTIDA.Visible = false;
            btnStopSweaterWeather.Visible = true;
            btnStopSweaterWeatherCurtido.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopDoIWannaKnow.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlayAlive.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;
        }

        private void btnStopSweaterWeather_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoSweaterWeather.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicSweaterWeather = new SoundPlayer(@"Sweater-Weather.wav");
            musicSweaterWeather.Stop();

            //Trocando para o botao de iniciar a música
            btnPlaySweaterWeather.Visible = true;
            btnStopSweaterWeather.Visible = false;

            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnStopSweaterWeatherCurtido.Visible = false;
        }

        private void btnFavoritarSweaterWeather_Click(object sender, EventArgs e)
        {
            btnFavoritarSweaterWeather.Visible = false;
            btnCurtidoSweaterWheather.Visible = true;

            PainelSweaterWeatherCurtida.Location = new Point(21, varLocation);
            PainelSweaterWeatherCurtida.Visible = true;
            varLocation = varLocation + 58;

            music2++;
        }

        private void btnCurtidoSweaterWheather_Click(object sender, EventArgs e)
        {
            btnFavoritarSweaterWeather.Visible = true;
            btnCurtidoSweaterWheather.Visible = false;

            music2--;
        }

        private void btnPlayWithoutMe_Click(object sender, EventArgs e)
        {
            contador = 3;

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando a imagem invisivel
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;

            imgFotoWithoutMe.Visible = true;
            lblNomeMusica.Text = ("Without Me");
            lblArtista.Text = ("Eminem");
            lblDuracao.Text = ("4:47");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.FromArgb(29, 185, 84);
            lblWithoutMeCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicWithoutMe = new SoundPlayer(@"Without-Me.wav");
            musicWithoutMe.Play();

            //Trocando para o botao de pausa
            btnPlayWithoutMe.Visible = false;
            btnStopWithoutMe.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = false;
            btnStopWithoutMeCurtido.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopDoIWannaKnow.Visible = false;
            btnStopAlive.Visible = false;
            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;
            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;
        }

        private void btnStopWithoutMe_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            imgFotoWithoutMe.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoWithoutMe.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicWithoutMe = new SoundPlayer(@"Without-Me.wav");
            musicWithoutMe.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayWithoutMe.Visible = true;
            btnStopWithoutMe.Visible = false;

            btnPlayWithoutMeCURTIDA.Visible = true;
            btnStopWithoutMeCurtido.Visible = false;
        }

        private void btnFavoritarWithoutMe_Click(object sender, EventArgs e)
        {
            btnFavoritarWithoutMe.Visible = false;
            btnCurtidoWithoutMe.Visible = true;

            PainelWithoutMeCurtida.Location = new Point(21, varLocation);
            PainelWithoutMeCurtida.Visible = true;
            varLocation = varLocation + 58;

            music3++;
        }

        private void btnCurtidoWithoutMe_Click(object sender, EventArgs e)
        {
            btnFavoritarWithoutMe.Visible = true;
            btnCurtidoWithoutMe.Visible = false;

            music3--;
        }

        private void btnPlayAlive_Click(object sender, EventArgs e)
        {
            contador = 4;

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando a imagem invisivel
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;

            //Deixando visível as caracteristicas da musica na barra de baixo
            imgFotoAlive.Visible = true;
            lblNomeMusica.Text = ("Alive (It Fells Like)");
            lblArtista.Text = ("Alok");
            lblDuracao.Text = ("2:21");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.FromArgb(29, 185, 84);
            lblAliveCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicAlive = new SoundPlayer(@"Alive.wav");
            musicAlive.Play();

            //Trocando para o botao de pausa
            btnPlayAlive.Visible = false;
            btnStopAlive.Visible = true;
            btnPlayAliveCURTIDA.Visible = false;
            btnStopAliveCurtido.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopDoIWannaKnow.Visible = false;
            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;
            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;
        }

        private void btnStopAlive_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Deixando visível as caracteristicas da musica na barra de baixo
            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicAlive = new SoundPlayer(@"Alive.wav");
            musicAlive.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayAlive.Visible = true;
            btnStopAlive.Visible = false;

            btnPlayAliveCURTIDA.Visible = true;
            btnStopAliveCurtido.Visible = false;
        }

        private void btnFavoritarAlive_Click(object sender, EventArgs e)
        {
            btnFavoritarAlive.Visible = false;
            btnCurtidoAlive.Visible = true;

            PainelAliveCurtida.Location = new Point(21, varLocation);
            PainelAliveCurtida.Visible = true;
            varLocation = varLocation + 58;

            music4++;
        }

        private void btnCurtidoAlive_Click(object sender, EventArgs e)
        {
            btnFavoritarAlive.Visible = true;
            btnCurtidoAlive.Visible = false;

            music4--;
        }

        private void btnPlayDoIWannaKnowCURTIDA_Click(object sender, EventArgs e)
        {
            contador = 1;

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando a imagem invisivel
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;

            //Deixando visível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = true;
            lblNomeMusica.Text = ("Do I Wanna Know");
            lblArtista.Text = ("Artic Monkeys");
            lblDuracao.Text = ("4:25");

            //Deixando verde a label do nome
            lblDoIWannaKnow.ForeColor = Color.FromArgb(29, 185, 84);
            lblDoIWanaKnowCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
            musicDoIWannaKnow.Play();

            //Trocando para o botao de pausa
            btnPlayDoIWannaKnow.Visible = false;
            btnPlayDoIWannaKnowCURTIDA.Visible = false;
            btnStopDoIWannaKnow.Visible = true;
            btnStopDoIWannaKnowCurtido.Visible = true;

            //Deixando invisivel os botoes de pausa das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;           
        }

        private void btnStopDoIWannaKnowCurtido_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
            musicDoIWannaKnow.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayDoIWannaKnow.Visible = true;
            btnStopDoIWannaKnow.Visible = false;

            btnPlayDoIWannaKnowCURTIDA.Visible = true;
            btnStopDoIWannaKnowCurtido.Visible = false;
        }

        private void btnPlaySweaterWeatherCURTIDA_Click(object sender, EventArgs e)
        {
            contador = 2;

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando a imagem invisivel
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;

            imgFotoSweaterWeather.Visible = true;
            lblNomeMusica.Text = ("Sweater Weather");
            lblArtista.Text = ("The Neighbourhood");
            lblDuracao.Text = ("3:56");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.FromArgb(29, 185, 84);
            lblSweatherWeatherCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicSweaterWeather = new SoundPlayer(@"Sweater-Weather.wav");
            musicSweaterWeather.Play();

            //Trocando para o botao de pausa
            btnPlaySweaterWeather.Visible = false;
            btnPlaySweaterWeatherCURTIDA.Visible = false;
            btnStopSweaterWeather.Visible = true;
            btnStopSweaterWeatherCurtido.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopDoIWannaKnow.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlayAlive.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;
        }

        private void btnStopSweaterWeatherCurtido_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoSweaterWeather.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicSweaterWeather = new SoundPlayer(@"Sweater-Weather.wav");
            musicSweaterWeather.Stop();

            //Trocando para o botao de iniciar a música
            btnPlaySweaterWeather.Visible = true;
            btnStopSweaterWeather.Visible = false;

            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnStopSweaterWeatherCurtido.Visible = false;
        }

        private void btnPlayWithoutMeCURTIDA_Click(object sender, EventArgs e)
        {
            contador = 3;

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando a imagem invisivel
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;

            imgFotoWithoutMe.Visible = true;
            lblNomeMusica.Text = ("Without Me");
            lblArtista.Text = ("Eminem");
            lblDuracao.Text = ("4:47");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.FromArgb(29, 185, 84);
            lblWithoutMeCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicWithoutMe = new SoundPlayer(@"Without-Me.wav");
            musicWithoutMe.Play();

            //Trocando para o botao de pausa
            btnPlayWithoutMe.Visible = false;
            btnStopWithoutMe.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = false;
            btnStopWithoutMeCurtido.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopDoIWannaKnow.Visible = false;
            btnStopAlive.Visible = false;
            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;
            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;
        }

        private void btnStopWithoutMeCurtido_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            imgFotoWithoutMe.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoWithoutMe.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicWithoutMe = new SoundPlayer(@"Without-Me.wav");
            musicWithoutMe.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayWithoutMe.Visible = true;
            btnStopWithoutMe.Visible = false;

            btnPlayWithoutMeCURTIDA.Visible = true;
            btnStopWithoutMeCurtido.Visible = false;
        }

        private void btnPlayAliveCURTIDA_Click(object sender, EventArgs e)
        {
            contador = 4;

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando a imagem invisivel
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;

            //Deixando visível as caracteristicas da musica na barra de baixo
            imgFotoAlive.Visible = true;
            lblNomeMusica.Text = ("Alive (It Fells Like)");
            lblArtista.Text = ("Alok");
            lblDuracao.Text = ("2:21");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.FromArgb(29, 185, 84);
            lblAliveCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

            //Escolhendo a música e a fazendo tocar
            SoundPlayer musicAlive = new SoundPlayer(@"Alive.wav");
            musicAlive.Play();

            //Trocando para o botao de pausa
            btnPlayAlive.Visible = false;
            btnStopAlive.Visible = true;
            btnPlayAliveCURTIDA.Visible = false;
            btnStopAliveCurtido.Visible = true;

            //Deixando invisivel os botoes stop das outras músicas
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopDoIWannaKnow.Visible = false;
            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;

            //Deixando visivel os botoes play das outras músicas
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;
            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;
        }

        private void btnStopAliveCurtido_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Deixando visível as caracteristicas da musica na barra de baixo
            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer musicAlive = new SoundPlayer(@"Alive.wav");
            musicAlive.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayAlive.Visible = true;
            btnStopAlive.Visible = false;

            btnPlayAliveCURTIDA.Visible = true;
            btnStopAliveCurtido.Visible = false;
        }

        private void btnPausarBaixo_Click(object sender, EventArgs e)
        {
            btnPlayBaixo.Visible = true;
            btnPausarBaixo.Visible = false;

            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Deixando visível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Escolhendo a música e a fazendo pausar
            SoundPlayer music = new SoundPlayer(@"Alive.wav");
            music.Stop();

            //Trocando para o botao de iniciar a música
            btnPlayDoIWannaKnow.Visible = true;
            btnStopDoIWannaKnow.Visible = false;
            btnPlaySweaterWeather.Visible = true;
            btnStopSweaterWeather.Visible = false;
            btnPlayWithoutMe.Visible = true;
            btnStopWithoutMe.Visible = false;
            btnPlayAlive.Visible = true;
            btnStopAlive.Visible = false;

            btnPlayDoIWannaKnowCURTIDA.Visible = true;
            btnStopDoIWannaKnowCurtido.Visible = false;
            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnStopSweaterWeatherCurtido.Visible = false;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnStopWithoutMeCurtido.Visible = false;
            btnPlayAliveCURTIDA.Visible = true;
            btnStopAliveCurtido.Visible = false;
        }

        private void btnProximaDireita_Click(object sender, EventArgs e)
        {        
            contador++;

            if (contador > 4)
            {
                contador = 1;
            }

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            //Deixando visivel todos os botoes play 
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;

            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;

            //Deixando invisivel todos os botoes de pausa
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopDoIWannaKnow.Visible = false;

            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;

            //Deixando todas as labels do nome das musicas branca
            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Caso o número aleatório for 1 toca Do I Wanna Know
            if (contador.ToString() == "1")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
                musicDoIWannaKnow.Play();

                btnPlayDoIWannaKnow.Visible = false;
                btnStopDoIWannaKnow.Visible = true;

                btnPlayDoIWannaKnowCURTIDA.Visible = false;
                btnStopDoIWannaKnowCurtido.Visible = true;

                lblDoIWannaKnow.ForeColor = Color.FromArgb(29, 185, 84);
                lblDoIWanaKnowCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoDoIWannaKnow.Visible = true;
                lblNomeMusica.Text = ("Do I Wanna Know");
                lblArtista.Text = ("Artic Monkeys");
                lblDuracao.Text = ("4:25");
            }

            //Caso o número aleatório for 2 toca Sweater Weather
            if (contador.ToString() == "2")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Sweater-Weather.wav");
                musicDoIWannaKnow.Play();

                btnPlaySweaterWeather.Visible = false;
                btnStopSweaterWeather.Visible = true;

                btnPlaySweaterWeatherCURTIDA.Visible = false;
                btnStopSweaterWeatherCurtido.Visible = true;

                lblSweatherWeather.ForeColor = Color.FromArgb(29, 185, 84);
                lblSweatherWeatherCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoSweaterWeather.Visible = true;
                lblNomeMusica.Text = ("Sweater Weather");
                lblArtista.Text = ("The Neighbourhood");
                lblDuracao.Text = ("3:56");
            }

            //Caso o número aleatório for 3 toca Without Me
            if (contador.ToString() == "3")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Without-Me.wav");
                musicDoIWannaKnow.Play();

                btnPlayWithoutMe.Visible = false;
                btnStopWithoutMe.Visible = true;

                btnPlayWithoutMeCURTIDA.Visible = false;
                btnStopWithoutMeCurtido.Visible = true;

                lblWithoutMe.ForeColor = Color.FromArgb(29, 185, 84);
                lblWithoutMeCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoWithoutMe.Visible = true;
                lblNomeMusica.Text = ("Without Me");
                lblArtista.Text = ("Eminem");
                lblDuracao.Text = ("4:47");
            }

            //Caso o número aleatório for 4 toca Alive
            if (contador.ToString() == "4")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Alive.wav");
                musicDoIWannaKnow.Play();

                btnPlayAlive.Visible = false;
                btnStopAlive.Visible = true;

                btnPlayAliveCURTIDA.Visible = false;
                btnStopAliveCurtido.Visible = true;

                lblAlive.ForeColor = Color.FromArgb(29, 185, 84);
                lblAliveCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                //Deixando visível as caracteristicas da musica na barra de baixo
                imgFotoAlive.Visible = true;
                lblNomeMusica.Text = ("Alive (It Fells Like)");
                lblArtista.Text = ("Alok");
                lblDuracao.Text = ("2:21");
            }
        }

        private void btnProximaEsquerda_Click(object sender, EventArgs e)
        {
            contador--;

            if (contador < 1)
            {
                contador = 4;
            }

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            //Deixando visivel todos os botoes play 
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;

            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;

            //Deixando invisivel todos os botoes de pausa
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopDoIWannaKnow.Visible = false;

            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;

            //Deixando todas as labels do nome das musicas branca
            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Caso o número aleatório for 1 toca Do I Wanna Know
            if (contador.ToString() == "1")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
                musicDoIWannaKnow.Play();

                btnPlayDoIWannaKnow.Visible = false;
                btnStopDoIWannaKnow.Visible = true;

                btnPlayDoIWannaKnowCURTIDA.Visible = false;
                btnStopDoIWannaKnowCurtido.Visible = true;

                lblDoIWannaKnow.ForeColor = Color.FromArgb(29, 185, 84);
                lblDoIWanaKnowCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoDoIWannaKnow.Visible = true;
                lblNomeMusica.Text = ("Do I Wanna Know");
                lblArtista.Text = ("Artic Monkeys");
                lblDuracao.Text = ("4:25");
            }

            //Caso o número aleatório for 2 toca Sweater Weather
            if (contador.ToString() == "2")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Sweater-Weather.wav");
                musicDoIWannaKnow.Play();

                btnPlaySweaterWeather.Visible = false;
                btnStopSweaterWeather.Visible = true;

                btnPlaySweaterWeatherCURTIDA.Visible = false;
                btnStopSweaterWeatherCurtido.Visible = true;

                lblSweatherWeather.ForeColor = Color.FromArgb(29, 185, 84);
                lblSweatherWeatherCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoSweaterWeather.Visible = true;
                lblNomeMusica.Text = ("Sweater Weather");
                lblArtista.Text = ("The Neighbourhood");
                lblDuracao.Text = ("3:56");
            }

            //Caso o número aleatório for 3 toca Without Me
            if (contador.ToString() == "3")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Without-Me.wav");
                musicDoIWannaKnow.Play();

                btnPlayWithoutMe.Visible = false;
                btnStopWithoutMe.Visible = true;

                btnPlayWithoutMeCURTIDA.Visible = false;
                btnStopWithoutMeCurtido.Visible = true;

                lblWithoutMe.ForeColor = Color.FromArgb(29, 185, 84);
                lblWithoutMeCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoWithoutMe.Visible = true;
                lblNomeMusica.Text = ("Without Me");
                lblArtista.Text = ("Eminem");
                lblDuracao.Text = ("4:47");
            }

            //Caso o número aleatório for 4 toca Alive
            if (contador.ToString() == "4")
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Alive.wav");
                musicDoIWannaKnow.Play();

                btnPlayAlive.Visible = false;
                btnStopAlive.Visible = true;

                btnPlayAliveCURTIDA.Visible = false;
                btnStopAliveCurtido.Visible = true;

                lblAlive.ForeColor = Color.FromArgb(29, 185, 84);
                lblAliveCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                //Deixando visível as caracteristicas da musica na barra de baixo
                imgFotoAlive.Visible = true;
                lblNomeMusica.Text = ("Alive (It Fells Like)");
                lblArtista.Text = ("Alok");
                lblDuracao.Text = ("2:21");
            }
        }

        private void btnAleatorizar_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int musicaAleatoria = numAleatorio.Next(1, 5);

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            //Deixando visivel todos os botoes play 
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;

            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;

            //Deixando invisivel todos os botoes de pausa
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopDoIWannaKnow.Visible = false;

            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;

            //Deixando todas as labels do nome das musicas branca
            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Caso o número aleatório for 1 toca Do I Wanna Know
            if (musicaAleatoria.ToString() == "1")
            {
                contador = 1;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
                musicDoIWannaKnow.Play();

                btnPlayDoIWannaKnow.Visible = false;
                btnStopDoIWannaKnow.Visible = true;

                btnPlayDoIWannaKnowCURTIDA.Visible = false;
                btnStopDoIWannaKnowCurtido.Visible = true;

                lblDoIWannaKnow.ForeColor = Color.FromArgb(29, 185, 84);
                lblDoIWanaKnowCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoDoIWannaKnow.Visible = true;
                lblNomeMusica.Text = ("Do I Wanna Know");
                lblArtista.Text = ("Artic Monkeys");
                lblDuracao.Text = ("4:25");
            }

            //Caso o número aleatório for 2 toca Sweater Weather
            if (musicaAleatoria.ToString() == "2")
            {
                contador = 2;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Sweater-Weather.wav");
                musicDoIWannaKnow.Play();

                btnPlaySweaterWeather.Visible = false;
                btnStopSweaterWeather.Visible = true;

                btnPlaySweaterWeatherCURTIDA.Visible = false;
                btnStopSweaterWeatherCurtido.Visible = true;

                lblSweatherWeather.ForeColor = Color.FromArgb(29, 185, 84);
                lblSweatherWeatherCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoSweaterWeather.Visible = true;
                lblNomeMusica.Text = ("Sweater Weather");
                lblArtista.Text = ("The Neighbourhood");
                lblDuracao.Text = ("3:56");
            }

            //Caso o número aleatório for 3 toca Without Me
            if (musicaAleatoria.ToString() == "3")
            {
                contador = 3;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Without-Me.wav");
                musicDoIWannaKnow.Play();

                btnPlayWithoutMe.Visible = false;
                btnStopWithoutMe.Visible = true;

                btnPlayWithoutMeCURTIDA.Visible = false;
                btnStopWithoutMeCurtido.Visible = true;

                lblWithoutMe.ForeColor = Color.FromArgb(29, 185, 84);
                lblWithoutMeCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoWithoutMe.Visible = true;
                lblNomeMusica.Text = ("Without Me");
                lblArtista.Text = ("Eminem");
                lblDuracao.Text = ("4:47");
            }

            //Caso o número aleatório for 4 toca Alive
            if (musicaAleatoria.ToString() == "4")
            {
                contador = 4;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Alive.wav");
                musicDoIWannaKnow.Play();

                btnPlayAlive.Visible = false;
                btnStopAlive.Visible = true;

                btnPlayAliveCURTIDA.Visible = false;
                btnStopAliveCurtido.Visible = true;

                lblAlive.ForeColor = Color.FromArgb(29, 185, 84);
                lblAliveCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                //Deixando visível as caracteristicas da musica na barra de baixo
                imgFotoAlive.Visible = true;
                lblNomeMusica.Text = ("Alive (It Fells Like)");
                lblArtista.Text = ("Alok");
                lblDuracao.Text = ("2:21");
            }
        }

        private void btnPlayBaixo_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int musicaAleatoria = numAleatorio.Next(1, 5);

            btnPlayBaixo.Visible = false;
            btnPausarBaixo.Visible = true;

            //Deixando invisível as caracteristicas da musica na barra de baixo
            imgFotoDoIWannaKnow.Visible = false;
            imgFotoSweaterWeather.Visible = false;
            imgFotoWithoutMe.Visible = false;
            imgFotoAlive.Visible = false;
            lblNomeMusica.Text = ("");
            lblArtista.Text = ("");
            lblDuracao.Text = ("");

            //Deixando visivel todos os botoes play 
            btnPlaySweaterWeather.Visible = true;
            btnPlayWithoutMe.Visible = true;
            btnPlayAlive.Visible = true;
            btnPlayDoIWannaKnow.Visible = true;

            btnPlaySweaterWeatherCURTIDA.Visible = true;
            btnPlayWithoutMeCURTIDA.Visible = true;
            btnPlayAliveCURTIDA.Visible = true;
            btnPlayDoIWannaKnowCURTIDA.Visible = true;

            //Deixando invisivel todos os botoes de pausa
            btnStopSweaterWeather.Visible = false;
            btnStopWithoutMe.Visible = false;
            btnStopAlive.Visible = false;
            btnStopDoIWannaKnow.Visible = false;

            btnStopSweaterWeatherCurtido.Visible = false;
            btnStopWithoutMeCurtido.Visible = false;
            btnStopAliveCurtido.Visible = false;
            btnStopDoIWannaKnowCurtido.Visible = false;

            //Deixando todas as labels do nome das musicas branca
            lblDoIWannaKnow.ForeColor = Color.White;
            lblDoIWanaKnowCURTIDA.ForeColor = Color.White;
            lblSweatherWeather.ForeColor = Color.White;
            lblSweatherWeatherCURTIDA.ForeColor = Color.White;
            lblWithoutMe.ForeColor = Color.White;
            lblWithoutMeCURTIDA.ForeColor = Color.White;
            lblAlive.ForeColor = Color.White;
            lblAliveCURTIDA.ForeColor = Color.White;

            //Caso o número aleatório for 1 toca Do I Wanna Know
            if (musicaAleatoria.ToString() == "1")
            {
                contador = 1;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
                musicDoIWannaKnow.Play();

                btnPlayDoIWannaKnow.Visible = false;
                btnStopDoIWannaKnow.Visible = true;

                btnPlayDoIWannaKnowCURTIDA.Visible = false;
                btnStopDoIWannaKnowCurtido.Visible = true;

                lblDoIWannaKnow.ForeColor = Color.FromArgb(29, 185, 84);
                lblDoIWanaKnowCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoDoIWannaKnow.Visible = true;
                lblNomeMusica.Text = ("Do I Wanna Know");
                lblArtista.Text = ("Artic Monkeys");
                lblDuracao.Text = ("4:25");
            }

            //Caso o número aleatório for 2 toca Sweater Weather
            if (musicaAleatoria.ToString() == "2")
            {
                contador = 2;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Sweater-Weather.wav");
                musicDoIWannaKnow.Play();

                btnPlaySweaterWeather.Visible = false;
                btnStopSweaterWeather.Visible = true;

                btnPlaySweaterWeatherCURTIDA.Visible = false;
                btnStopSweaterWeatherCurtido.Visible = true;

                lblSweatherWeather.ForeColor = Color.FromArgb(29, 185, 84);
                lblSweatherWeatherCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoSweaterWeather.Visible = true;
                lblNomeMusica.Text = ("Sweater Weather");
                lblArtista.Text = ("The Neighbourhood");
                lblDuracao.Text = ("3:56");
            }

            //Caso o número aleatório for 3 toca Without Me
            if (musicaAleatoria.ToString() == "3")
            {
                contador = 3;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Without-Me.wav");
                musicDoIWannaKnow.Play();

                btnPlayWithoutMe.Visible = false;
                btnStopWithoutMe.Visible = true;

                btnPlayWithoutMeCURTIDA.Visible = false;
                btnStopWithoutMeCurtido.Visible = true;

                lblWithoutMe.ForeColor = Color.FromArgb(29, 185, 84);
                lblWithoutMeCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                imgFotoWithoutMe.Visible = true;
                lblNomeMusica.Text = ("Without Me");
                lblArtista.Text = ("Eminem");
                lblDuracao.Text = ("4:47");
            }

            //Caso o número aleatório for 4 toca Alive
            if (musicaAleatoria.ToString() == "4")
            {
                contador = 4;

                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Alive.wav");
                musicDoIWannaKnow.Play();

                btnPlayAlive.Visible = false;
                btnStopAlive.Visible = true;

                btnPlayAliveCURTIDA.Visible = false;
                btnStopAliveCurtido.Visible = true;

                lblAlive.ForeColor = Color.FromArgb(29, 185, 84);
                lblAliveCURTIDA.ForeColor = Color.FromArgb(29, 185, 84);

                //Deixando visível as caracteristicas da musica na barra de baixo
                imgFotoAlive.Visible = true;
                lblNomeMusica.Text = ("Alive (It Fells Like)");
                lblArtista.Text = ("Alok");
                lblDuracao.Text = ("2:21");
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                SoundPlayer musicDoIWannaKnow = new SoundPlayer(@"Do-I-Wanna-Know.wav");
                musicDoIWannaKnow.PlayLooping();
            }

            if (contador == 2)
            {
                SoundPlayer musicSweaterWheater = new SoundPlayer(@"Sweater-Weather.wav");
                musicSweaterWheater.PlayLooping();
            }

            if (contador == 3)
            {
                SoundPlayer musicWithoutMe = new SoundPlayer(@"Without-Me.wav");
                musicWithoutMe.PlayLooping();
            }

            if (contador == 4)
            {
                SoundPlayer musicAlive = new SoundPlayer(@"Alive.wav");
                musicAlive.PlayLooping();
            }
        }
    }
}
