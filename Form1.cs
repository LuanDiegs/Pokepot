using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokePot
{
    public partial class Form1 : Form
    {
        int sort1;
        int sort2;
        int sort3;

        int ticks;

        int tentativas = 7;

        int ultraball;

        //Randomico
        Random rand = new Random();

        //Player de Som
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tentativas == 0)
            {
                tentativas = 7;
                pokebolas.Text = "Masterballs: " + tentativas.ToString();
                button1.Load("res/Imgs/play.png");

            }

            else
            {
                //Som
                tocarsommp3("pot_rand");

                //Tentativas
                tentativas--;

                pokebolas.Text = "Masterballs: " + tentativas.ToString();

                timer1.Enabled = true;

                if (timer1.Enabled == true)
                {
                    button1.Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;


            if (ticks < 50)
            {
                //Sortear
                sort1 = rand.Next(1, 9);

                //sort1 = 1;//Hack

                //Carregar imagem
                nro1.Load("res/Imgs/" + sort1 + ".png");
            }

            if (ticks < 70)
            {
                sort2 = rand.Next(1, 9);

                //sort2 = 1;

                nro2.Load("res/Imgs/" + sort2 + ".png");
            }

            if (ticks < 90)
            {

                sort3 = rand.Next(1, 9);

                //sort3 = 1;

                nro3.Load("res/Imgs/" + sort3 + ".png");

            }

            if (ticks > 90)
            {
                //Parar som
                wplayer.Ctlcontrols.stop();                

                //Parar Timer
                timer1.Enabled = false;

                //Zerar Ticks
                ticks = 0;

                //Voltar botão
                button1.Enabled = true;

                //Colocar Pontos
                if (sort1 == sort2 && sort1 == sort3 && sort1 != 7)
                {
                    ultraball += 1;
                    ultra.Text = "Ultraballs: " + ultraball.ToString();
                }

                if (sort1 == 7 && sort2 == 7 && sort3 == 7)
                {
                    tentativas += 7;
                    pokebolas.Text = "Masterballs: " + tentativas.ToString();
                }

                //Acabar jogo
                if (tentativas == 0)
                {
                    button1.Load("res/Imgs/replau.jpg");
                    pokebolas.Text = "Deseja reiniciar?";

                    nro1.Load("res/Imgs/Poke2.gif");
                    nro2.Load("res/Imgs/Poke2.gif");
                    nro3.Load("res/Imgs/Poke2.gif");

                    ultraball = 0;
                    ultra.Text = "Ultraballs: " + ultraball.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pokebolas.Text = "Masterballs: " + tentativas.ToString();

            tocarsomwav("background-music");
       
        }

        private void wplayer_Enter(object sender, EventArgs e)
        {

        }

        private void tocarsomwav(String som)
        {

            //SOM
            player.SoundLocation = "res/Aud/" + som + ".wav";
            player.Load();
            player.Play();

        }

        private void tocarsommp3(String som)
        {

            wplayer.URL = "res/Aud/"+ som +".MP3";
            wplayer.Ctlcontrols.play();
            wplayer.settings.volume = 100;

        }

        private void ultra_Click(object sender, EventArgs e)
        {

        }
    }
}
