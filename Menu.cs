using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokePot
{
    public partial class Menu : Form
    {
        //Som
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //Abrir outro form Thread
        Thread nf;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "res/Aud/8bit-poke.wav";
            player.Load();
            player.PlayLooping();
        }

        private void play_Click(object sender, EventArgs e)
        {

            this.Close();
            nf = new Thread(telajogo);//Nova Thread para abrir a tela
            nf.SetApartmentState(ApartmentState.STA); //Single Thread
            nf.Start();//Iniciar a tela do jogo

            player.Stop();

        }

        //Novo Form
        private void telajogo()
        {
            Application.Run(new Form1());//Rodar a tela do jogo
        }
    }
}
