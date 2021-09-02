namespace PokePot
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.title = new System.Windows.Forms.PictureBox();
            this.nada1 = new System.Windows.Forms.PictureBox();
            this.nada3 = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nada1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nada3)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(-1, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(883, 116);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.title.TabIndex = 24;
            this.title.TabStop = false;
            // 
            // nada1
            // 
            this.nada1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.nada1.Image = ((System.Drawing.Image)(resources.GetObject("nada1.Image")));
            this.nada1.Location = new System.Drawing.Point(-1, 3);
            this.nada1.Name = "nada1";
            this.nada1.Size = new System.Drawing.Size(146, 116);
            this.nada1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nada1.TabIndex = 25;
            this.nada1.TabStop = false;
            // 
            // nada3
            // 
            this.nada3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.nada3.Image = ((System.Drawing.Image)(resources.GetObject("nada3.Image")));
            this.nada3.Location = new System.Drawing.Point(736, 3);
            this.nada3.Name = "nada3";
            this.nada3.Size = new System.Drawing.Size(146, 116);
            this.nada3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nada3.TabIndex = 27;
            this.nada3.TabStop = false;
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(24)))), ((int)(((byte)(23)))));
            this.play.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(242, 383);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(402, 69);
            this.play.TabIndex = 28;
            this.play.Text = "Lançar Pokebola";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokePot.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.play);
            this.Controls.Add(this.nada3);
            this.Controls.Add(this.nada1);
            this.Controls.Add(this.title);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokePot";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nada1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nada3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox nada1;
        private System.Windows.Forms.PictureBox nada3;
        private System.Windows.Forms.Label play;
    }
}