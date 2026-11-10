
namespace TowerDefence
{
    partial class MainMenu
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Brown;
            this.labelTitle.Location = new System.Drawing.Point(54, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(694, 53);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "THE ULTIMATE TOWER DEFENCE";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Brown;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnStart.Location = new System.Drawing.Point(311, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 85);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.Color.Brown;
            this.btnHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHowToPlay.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnHowToPlay.Location = new System.Drawing.Point(311, 220);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(151, 82);
            this.btnHowToPlay.TabIndex = 2;
            this.btnHowToPlay.Text = "How To Play";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.BtnHowToPlay_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.BackColor = System.Drawing.Color.Brown;
            this.btnHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHighScores.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnHighScores.Location = new System.Drawing.Point(311, 318);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(151, 85);
            this.btnHighScores.TabIndex = 3;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = false;
            this.btnHighScores.Click += new System.EventHandler(this.BtnHighScores_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Brown;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnQuit.Location = new System.Drawing.Point(694, 402);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 48);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnQuit;
    }
}