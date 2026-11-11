
namespace TowerDefence
{
    partial class frmTowerDefence
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.labelCoins = new System.Windows.Forms.Label();
            this.lblBasicTower = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLevelTime = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pctLightningTower = new System.Windows.Forms.PictureBox();
            this.pctPathFindingTower = new System.Windows.Forms.PictureBox();
            this.pctBasicTower = new System.Windows.Forms.PictureBox();
            this.pctTowerSelect = new System.Windows.Forms.PictureBox();
            this.pctSelectedTowerHolder = new System.Windows.Forms.PictureBox();
            this.mainBuilding = new System.Windows.Forms.PictureBox();
            this.TowerSelector = new System.Windows.Forms.PictureBox();
            this.lblClickTower = new System.Windows.Forms.Label();
            this.lblMortar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLightningTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPathFindingTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBasicTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTowerSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSelectedTowerHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TowerSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTick);
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.BackColor = System.Drawing.Color.Transparent;
            this.labelHealth.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHealth.Location = new System.Drawing.Point(-1, 500);
            this.labelHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(144, 22);
            this.labelHealth.TabIndex = 0;
            this.labelHealth.Text = "Building health";
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.Yellow;
            this.healthBar.Location = new System.Drawing.Point(3, 524);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(143, 28);
            this.healthBar.TabIndex = 1;
            this.healthBar.Value = 100;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelCoins.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoins.Location = new System.Drawing.Point(919, 11);
            this.labelCoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(136, 30);
            this.labelCoins.TabIndex = 3;
            this.labelCoins.Text = "Coins : 10";
            // 
            // lblBasicTower
            // 
            this.lblBasicTower.AutoSize = true;
            this.lblBasicTower.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblBasicTower.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicTower.Location = new System.Drawing.Point(913, 197);
            this.lblBasicTower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasicTower.Name = "lblBasicTower";
            this.lblBasicTower.Size = new System.Drawing.Size(45, 30);
            this.lblBasicTower.TabIndex = 9;
            this.lblBasicTower.Text = "10";
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.BackColor = System.Drawing.Color.Sienna;
            this.labelSelected.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelected.Location = new System.Drawing.Point(912, 126);
            this.labelSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(142, 37);
            this.labelSelected.TabIndex = 10;
            this.labelSelected.Text = "Selected";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Sienna;
            this.btnStart.Location = new System.Drawing.Point(927, 507);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 32);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLevelTime
            // 
            this.lblLevelTime.AutoSize = true;
            this.lblLevelTime.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblLevelTime.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelTime.Location = new System.Drawing.Point(909, 512);
            this.lblLevelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevelTime.Name = "lblLevelTime";
            this.lblLevelTime.Size = new System.Drawing.Size(144, 22);
            this.lblLevelTime.TabIndex = 13;
            this.lblLevelTime.Text = "Time Left : 200";
            this.lblLevelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Green;
            this.lblScore.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(-3, -2);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(121, 30);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = "Score : 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctLightningTower
            // 
            this.pctLightningTower.BackColor = System.Drawing.Color.SaddleBrown;
            this.pctLightningTower.Image = global::TowerDefence.Properties.Resources.Mortar;
            this.pctLightningTower.Location = new System.Drawing.Point(972, 364);
            this.pctLightningTower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctLightningTower.Name = "pctLightningTower";
            this.pctLightningTower.Size = new System.Drawing.Size(79, 74);
            this.pctLightningTower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLightningTower.TabIndex = 15;
            this.pctLightningTower.TabStop = false;
            this.pctLightningTower.Click += new System.EventHandler(this.pctLightningTower_Click);
            // 
            // pctPathFindingTower
            // 
            this.pctPathFindingTower.BackColor = System.Drawing.Color.SaddleBrown;
            this.pctPathFindingTower.Image = global::TowerDefence.Properties.Resources.ClickTower;
            this.pctPathFindingTower.Location = new System.Drawing.Point(969, 273);
            this.pctPathFindingTower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctPathFindingTower.Name = "pctPathFindingTower";
            this.pctPathFindingTower.Size = new System.Drawing.Size(79, 73);
            this.pctPathFindingTower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPathFindingTower.TabIndex = 11;
            this.pctPathFindingTower.TabStop = false;
            this.pctPathFindingTower.Click += new System.EventHandler(this.PathFindingTower_Click);
            // 
            // pctBasicTower
            // 
            this.pctBasicTower.BackColor = System.Drawing.Color.SaddleBrown;
            this.pctBasicTower.Image = global::TowerDefence.Properties.Resources.BasicTower;
            this.pctBasicTower.Location = new System.Drawing.Point(969, 181);
            this.pctBasicTower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctBasicTower.Name = "pctBasicTower";
            this.pctBasicTower.Size = new System.Drawing.Size(81, 69);
            this.pctBasicTower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBasicTower.TabIndex = 8;
            this.pctBasicTower.TabStop = false;
            this.pctBasicTower.Tag = "1";
            this.pctBasicTower.Click += new System.EventHandler(this.BasicTowerChoice_Click);
            // 
            // pctTowerSelect
            // 
            this.pctTowerSelect.BackColor = System.Drawing.Color.Black;
            this.pctTowerSelect.Location = new System.Drawing.Point(945, 54);
            this.pctTowerSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctTowerSelect.Name = "pctTowerSelect";
            this.pctTowerSelect.Size = new System.Drawing.Size(84, 73);
            this.pctTowerSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTowerSelect.TabIndex = 6;
            this.pctTowerSelect.TabStop = false;
            this.pctTowerSelect.Tag = "TowerSelect";
            this.pctTowerSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectedMouseDown);
            this.pctTowerSelect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectedMouseMove);
            this.pctTowerSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectedMouseUp);
            // 
            // pctSelectedTowerHolder
            // 
            this.pctSelectedTowerHolder.BackColor = System.Drawing.Color.Sienna;
            this.pctSelectedTowerHolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctSelectedTowerHolder.Location = new System.Drawing.Point(904, 49);
            this.pctSelectedTowerHolder.Margin = new System.Windows.Forms.Padding(0);
            this.pctSelectedTowerHolder.Name = "pctSelectedTowerHolder";
            this.pctSelectedTowerHolder.Size = new System.Drawing.Size(163, 113);
            this.pctSelectedTowerHolder.TabIndex = 5;
            this.pctSelectedTowerHolder.TabStop = false;
            this.pctSelectedTowerHolder.Tag = "SelectedTowerHolder";
            // 
            // mainBuilding
            // 
            this.mainBuilding.BackColor = System.Drawing.Color.Transparent;
            this.mainBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainBuilding.Image = global::TowerDefence.Properties.Resources.New_Piskel__2_;
            this.mainBuilding.Location = new System.Drawing.Point(393, 181);
            this.mainBuilding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainBuilding.Name = "mainBuilding";
            this.mainBuilding.Size = new System.Drawing.Size(160, 148);
            this.mainBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainBuilding.TabIndex = 2;
            this.mainBuilding.TabStop = false;
            this.mainBuilding.Tag = "MainBuilding";
            // 
            // TowerSelector
            // 
            this.TowerSelector.BackColor = System.Drawing.Color.SaddleBrown;
            this.TowerSelector.Location = new System.Drawing.Point(904, -14);
            this.TowerSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TowerSelector.Name = "TowerSelector";
            this.TowerSelector.Size = new System.Drawing.Size(163, 566);
            this.TowerSelector.TabIndex = 4;
            this.TowerSelector.TabStop = false;
            // 
            // lblClickTower
            // 
            this.lblClickTower.AutoSize = true;
            this.lblClickTower.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblClickTower.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickTower.Location = new System.Drawing.Point(913, 300);
            this.lblClickTower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClickTower.Name = "lblClickTower";
            this.lblClickTower.Size = new System.Drawing.Size(45, 30);
            this.lblClickTower.TabIndex = 17;
            this.lblClickTower.Text = "20";
            // 
            // lblMortar
            // 
            this.lblMortar.AutoSize = true;
            this.lblMortar.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblMortar.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMortar.Location = new System.Drawing.Point(913, 388);
            this.lblMortar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMortar.Name = "lblMortar";
            this.lblMortar.Size = new System.Drawing.Size(45, 30);
            this.lblMortar.TabIndex = 18;
            this.lblMortar.Text = "70";
            // 
            // frmTowerDefence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblMortar);
            this.Controls.Add(this.lblClickTower);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pctLightningTower);
            this.Controls.Add(this.lblLevelTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pctPathFindingTower);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.pctBasicTower);
            this.Controls.Add(this.lblBasicTower);
            this.Controls.Add(this.pctTowerSelect);
            this.Controls.Add(this.pctSelectedTowerHolder);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.mainBuilding);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.TowerSelector);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frmTowerDefence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TowerDefence";
            this.Click += new System.EventHandler(this.frmTowerDefence_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pctLightningTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPathFindingTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBasicTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTowerSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSelectedTowerHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TowerSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        public System.Windows.Forms.PictureBox mainBuilding;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.PictureBox pctSelectedTowerHolder;
        private System.Windows.Forms.PictureBox pctTowerSelect;
        private System.Windows.Forms.PictureBox pctBasicTower;
        private System.Windows.Forms.Label lblBasicTower;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.PictureBox pctPathFindingTower;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblLevelTime;
        private System.Windows.Forms.PictureBox pctLightningTower;
        public System.Windows.Forms.PictureBox TowerSelector;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblClickTower;
        private System.Windows.Forms.Label lblMortar;
    }
}

