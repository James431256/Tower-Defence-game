
namespace TowerDefence
{
    partial class HighScores
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
            this.lblHighScores = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pctPlayerData = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNamesList = new System.Windows.Forms.Label();
            this.lblScoresList = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHighScores
            // 
            this.lblHighScores.BackColor = System.Drawing.Color.Brown;
            this.lblHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHighScores.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScores.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblHighScores.Location = new System.Drawing.Point(107, 9);
            this.lblHighScores.Name = "lblHighScores";
            this.lblHighScores.Size = new System.Drawing.Size(570, 71);
            this.lblHighScores.TabIndex = 1;
            this.lblHighScores.Text = "HIGH SCORES";
            this.lblHighScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Brown;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnBack.Location = new System.Drawing.Point(0, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 48);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_click);
            // 
            // pctPlayerData
            // 
            this.pctPlayerData.BackColor = System.Drawing.Color.SandyBrown;
            this.pctPlayerData.Location = new System.Drawing.Point(119, 83);
            this.pctPlayerData.Name = "pctPlayerData";
            this.pctPlayerData.Size = new System.Drawing.Size(551, 304);
            this.pctPlayerData.TabIndex = 29;
            this.pctPlayerData.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.SandyBrown;
            this.lblName.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblName.Location = new System.Drawing.Point(252, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 30);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.SandyBrown;
            this.lblScore.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblScore.Location = new System.Drawing.Point(428, 83);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 30);
            this.lblScore.TabIndex = 31;
            this.lblScore.Text = "SCORE";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNamesList
            // 
            this.lblNamesList.BackColor = System.Drawing.Color.SandyBrown;
            this.lblNamesList.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamesList.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblNamesList.Location = new System.Drawing.Point(263, 113);
            this.lblNamesList.Name = "lblNamesList";
            this.lblNamesList.Size = new System.Drawing.Size(145, 274);
            this.lblNamesList.TabIndex = 32;
            // 
            // lblScoresList
            // 
            this.lblScoresList.BackColor = System.Drawing.Color.SandyBrown;
            this.lblScoresList.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoresList.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblScoresList.Location = new System.Drawing.Point(428, 113);
            this.lblScoresList.Name = "lblScoresList";
            this.lblScoresList.Size = new System.Drawing.Size(185, 274);
            this.lblScoresList.TabIndex = 33;
            // 
            // lblPos
            // 
            this.lblPos.BackColor = System.Drawing.Color.SandyBrown;
            this.lblPos.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPos.Location = new System.Drawing.Point(127, 113);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(76, 274);
            this.lblPos.TabIndex = 34;
            this.lblPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblScoresList);
            this.Controls.Add(this.lblNamesList);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pctPlayerData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHighScores);
            this.Name = "HighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScores";
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHighScores;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pctPlayerData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNamesList;
        private System.Windows.Forms.Label lblScoresList;
        private System.Windows.Forms.Label lblPos;
    }
}