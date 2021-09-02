namespace PokePot
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pokebolas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pontos = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.PictureBox();
            this.nro3 = new System.Windows.Forms.PictureBox();
            this.nro2 = new System.Windows.Forms.PictureBox();
            this.nro1 = new System.Windows.Forms.PictureBox();
            this.ultra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nro1)).BeginInit();
            this.SuspendLayout();
            // 
            // pokebolas
            // 
            this.pokebolas.AutoSize = true;
            this.pokebolas.BackColor = System.Drawing.Color.Transparent;
            this.pokebolas.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokebolas.Location = new System.Drawing.Point(694, 426);
            this.pokebolas.Name = "pokebolas";
            this.pokebolas.Size = new System.Drawing.Size(162, 26);
            this.pokebolas.TabIndex = 24;
            this.pokebolas.Text = "Masterballs:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wplayer
            // 
            this.wplayer.Enabled = true;
            this.wplayer.Location = new System.Drawing.Point(-9, -2);
            this.wplayer.Name = "wplayer";
            this.wplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayer.OcxState")));
            this.wplayer.Size = new System.Drawing.Size(238, 49);
            this.wplayer.TabIndex = 28;
            this.wplayer.Visible = false;
            this.wplayer.Enter += new System.EventHandler(this.wplayer_Enter);
            // 
            // pontos
            // 
            this.pontos.Image = ((System.Drawing.Image)(resources.GetObject("pontos.Image")));
            this.pontos.Location = new System.Drawing.Point(5, 125);
            this.pontos.Name = "pontos";
            this.pontos.Size = new System.Drawing.Size(89, 89);
            this.pontos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pontos.TabIndex = 29;
            this.pontos.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(695, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 196);
            this.button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button1.TabIndex = 26;
            this.button1.TabStop = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.Transparent;
            this.banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.banner.Image = ((System.Drawing.Image)(resources.GetObject("banner.Image")));
            this.banner.Location = new System.Drawing.Point(542, -2);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(340, 103);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.banner.TabIndex = 25;
            this.banner.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(168)))), ((int)(((byte)(157)))));
            this.title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(-71, -1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(671, 101);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.title.TabIndex = 23;
            this.title.TabStop = false;
            // 
            // nro3
            // 
            this.nro3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nro3.Image = ((System.Drawing.Image)(resources.GetObject("nro3.Image")));
            this.nro3.Location = new System.Drawing.Point(465, 220);
            this.nro3.Name = "nro3";
            this.nro3.Size = new System.Drawing.Size(224, 231);
            this.nro3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nro3.TabIndex = 22;
            this.nro3.TabStop = false;
            // 
            // nro2
            // 
            this.nro2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nro2.Image = ((System.Drawing.Image)(resources.GetObject("nro2.Image")));
            this.nro2.Location = new System.Drawing.Point(235, 220);
            this.nro2.Name = "nro2";
            this.nro2.Size = new System.Drawing.Size(224, 231);
            this.nro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nro2.TabIndex = 21;
            this.nro2.TabStop = false;
            // 
            // nro1
            // 
            this.nro1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nro1.Image = ((System.Drawing.Image)(resources.GetObject("nro1.Image")));
            this.nro1.Location = new System.Drawing.Point(5, 220);
            this.nro1.Name = "nro1";
            this.nro1.Size = new System.Drawing.Size(224, 231);
            this.nro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nro1.TabIndex = 20;
            this.nro1.TabStop = false;
            // 
            // ultra
            // 
            this.ultra.AutoSize = true;
            this.ultra.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultra.Location = new System.Drawing.Point(89, 160);
            this.ultra.Name = "ultra";
            this.ultra.Size = new System.Drawing.Size(283, 54);
            this.ultra.TabIndex = 30;
            this.ultra.Text = "Ultraballs: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ultra);
            this.Controls.Add(this.pontos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.pokebolas);
            this.Controls.Add(this.title);
            this.Controls.Add(this.nro3);
            this.Controls.Add(this.nro2);
            this.Controls.Add(this.nro1);
            this.Controls.Add(this.wplayer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poke-Pot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox button1;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Label pokebolas;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox nro3;
        private System.Windows.Forms.PictureBox nro2;
        private System.Windows.Forms.PictureBox nro1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer wplayer;
        private System.Windows.Forms.PictureBox pontos;
        private System.Windows.Forms.Label ultra;
    }
}

