using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Text.RegularExpressions;


namespace TowerDefence
{
    public partial class frmTowerDefence : Form
    {
        SpawnManager spawnManage;
        CollisionManager collisionManage;
        EnemyMovement movementManage;
        PictureBox picture = new PictureBox();
        public int coins = 20;
        public int buildingHealth = 100; // sets main buildings health to 100
        public int mouseX, mouseY, CoinPosLeft, CoinPosTop, TempX, TempY, clickX, clickY;
        bool dragging;
        public string TowerChoice = "";
        Random randomSpawn = new Random();
        List<PictureBox> Coins = new List<PictureBox>(); //creates a new list for Coins to be added to
        Timer CoinSpawnTimer = new Timer(); //Creates a new timer for coin spawning
        Timer LevelTimer = new Timer();
        Timer ChangeTimer = new Timer();
        Timer RemoveTimer = new Timer();
        PictureBox CoinSpawn = new PictureBox();
        int TimeDecrease = 40;
        int Level = 1;
        int playerScore = 0;
        int levelPassed = 0;
        public int enemies = 0;
        Label nextLevel = new Label();
        Label nextLevel3 = new Label();
        bool changed = false;
        TextBox txtPlayerName = new TextBox(); //creates a new textbox 
        string playerName = "";
        Label lblerror = new Label();
        Label lblNameLength = new Label();
        Label lblNoUser = new Label();
        bool UserEntered = false;
        bool PlayerDead = false;

        public SpawnManager SpawnManage { get => spawnManage; set => spawnManage = value; }
        public CollisionManager CollisionManage { get => collisionManage; set => collisionManage = value; }
        public EnemyMovement MovementManage { get => movementManage; set => movementManage = value; }

        public frmTowerDefence()
        {

            SpawnManage = new SpawnManager(this);  //creates an instance of SpawnManager in form
            CollisionManage = new CollisionManager(this); //creates an instance of CollisionManager in the form
            movementManage = new EnemyMovement(this); //creates an instance of EnemyMovement in form

            InitializeComponent();

            //BigTower.AllowDrop = true;
            healthBar.BringToFront();
            labelCoins.BringToFront();
            labelCoins.BackColor = System.Drawing.Color.Transparent;

            labelCoins.Text = "Coins: " + coins;
            labelCoins.BackColor = Color.SaddleBrown;

            CoinSpawnTimer.Interval = 2000;
            CoinSpawnTimer.Tick += new EventHandler(CoinSpawnTick);
            CoinSpawnTimer.Start();

            btnStart.BringToFront();
            lblLevelTime.Visible = false;
            LevelTimer.Interval = 1000;
            LevelTimer.Tick += new EventHandler(LevelTimerTick);

            ChangeTimer.Interval = 1000;
            ChangeTimer.Tick += new EventHandler(ChangeTimerTick);
            //Obstacle bush = new Obstacle(this, 200, 100, 30, 30);

            RemoveTimer.Interval = 2000;
            RemoveTimer.Tick += new EventHandler(RemoveTimerTick);
        }

        public void GameTick(object sender, EventArgs e)
        {

            mainBuilding.BringToFront();
            IsBuildingAlive(); //runs this codde every game tick

            collisionManage.DetectSight();
            CollisionManage.DetectCollision(); //runs this code every gametick
            movementManage.moveBigEnemy(); //runs the moveBigEnemy code every game tick
            movementManage.moveSmallEnemy(); //runs the moveSmallEnemy code every game tick
            Levels();

            playerScore =levelPassed + collisionManage.incScore; // increases players score
            lblScore.Text = " Score : " + playerScore;

        }
        public void frmTowerDefence_Click(object sender, EventArgs e)
        {
            MouseEventArgs e2 = (MouseEventArgs)e; //as its a click cant have MouseEventArgs in parameters so have to declare here
            clickX = e2.X; //sets clickX to x coordinate of players click
            clickY = e2.Y; //sets clickY to y coordinate of players click

        }

        public void IsBuildingAlive()
        {
            if (buildingHealth > 0) //Checks if the buildings health is above 1
            {
                healthBar.Value = buildingHealth; //sets the healthBars value to whatever the builidngs health is 
            }
            else
            {
                GameTimer.Stop(); //if the building has lost all health then the GameTimer stops and game ends
                PlayerDead = true;
                EndGame();
            }
        }
        public void EndGame()
        {
            playerScore = levelPassed + collisionManage.incScore;
            this.Controls.Remove(CoinSpawn);
            int i = 0;
            while (i != 5)
            {
                RemoveObject();
                i = i + 1;
            }
            //removes all objects from screen 
            this.BackColor = Color.Black;
            PictureBox Win = new PictureBox();
            Win.Image = Properties.Resources.YouLose;
            Win.SizeMode = PictureBoxSizeMode.AutoSize;
            Win.Location = new System.Drawing.Point(220, 50);
            this.Controls.Add(Win);

            lblScore.ForeColor = Color.Red;
            lblScore.Text = "Your Score :" + playerScore;
            lblScore.BackColor = Color.Black;
            lblScore.Location = new System.Drawing.Point(220, 250);
            lblScore.Font = (new Font("Britannic", 25, FontStyle.Bold));

            Label lblPlayerName = new Label();
            lblPlayerName.Text = "Name : ";
            lblPlayerName.BackColor = Color.Black;
            lblPlayerName.Location = new System.Drawing.Point(230, 180);
            lblPlayerName.Font = (new Font("Britannic", 25, FontStyle.Bold));
            this.Controls.Add(lblPlayerName);
            lblPlayerName.AutoSize = true;
            lblPlayerName.ForeColor = Color.Red;

            txtPlayerName.BackColor = Color.Silver;
            txtPlayerName.Location = new System.Drawing.Point(360, 185);
            this.Controls.Add(txtPlayerName);
            txtPlayerName.AutoSize = false;
            txtPlayerName.Size = new System.Drawing.Size(150, 35);
            txtPlayerName.Font = (new Font("Britannic", 17, FontStyle.Bold));
            txtPlayerName.ForeColor = Color.Red; ;
            txtPlayerName.BorderStyle = BorderStyle.FixedSingle;
            txtPlayerName.BringToFront();
            txtPlayerName.KeyPress += new KeyPressEventHandler(txtPlayerName_changed);
            //sets all its attributes

            Button btnHomeScreen = new Button();
            btnHomeScreen.BackColor = Color.Silver;
            btnHomeScreen.Location = new System.Drawing.Point(200, 350);
            btnHomeScreen.Font = (new Font("Britannic", 22, FontStyle.Bold));
            this.Controls.Add(btnHomeScreen);
            btnHomeScreen.AutoSize = false;
            btnHomeScreen.Size = new System.Drawing.Size(400, 70);
            btnHomeScreen.ForeColor = Color.Red;
            btnHomeScreen.FlatStyle = FlatStyle.Popup;
            btnHomeScreen.Text = "RETURN TO MAIN MENU";
            btnHomeScreen.TextAlign = ContentAlignment.MiddleCenter;
            btnHomeScreen.Click += new EventHandler(btnHomeScreen_Click);

        }


        public void SpawnCoin()
        {
            
            CoinSpawn.Image = Properties.Resources.coin; //sets the image of the coin to CoinSpawn
            CoinSpawn.SizeMode = PictureBoxSizeMode.StretchImage; //sets the size of the picturebox
            CoinSpawn.Size = new System.Drawing.Size(40, 40);
            CoinSpawn.Tag = "coin"; //calls the coin "coin"
            CoinSpawn.Left = CoinPosLeft;
            CoinSpawn.Top = CoinPosTop;
            CoinSpawn.Click += new EventHandler(ClickCoin); //creates a new subroutine for when the coins clicked
            Coins.Add(CoinSpawn); //Adds the coin to the list Coins once its been added to the form
            this.Controls.Add(CoinSpawn); //adds the picture box to the form
            CoinSpawn.BringToFront();
            CoinSpawn.Visible = true;
            CoinSpawn.Left = randomSpawn.Next(70, 400);
            CoinSpawn.Top = randomSpawn.Next(70, 420);
        }



        public void ClickCoin(object sender, EventArgs e)
        {
            PictureBox temporaryCoin = sender as PictureBox; //gives whatever coin has been clicked the variable temporaryCoin
            Coins.Remove(temporaryCoin); //removes clicked coin from list
            this.Controls.Remove(temporaryCoin); //removes clicked coin from screen
            coins += 5; //adds 5 to the points
            labelCoins.BackColor = Color.SaddleBrown;
            labelCoins.Text = "Coins: " + coins; //shows the updated points on the screen            
        }
        public void CoinSpawnTick(object sender, EventArgs e)
        {
            if (randomSpawn.Next(0, 700) < 200 && GameTimer.Enabled)// when a random number between 0 and 200 is below 100 code is executed
            {
                SpawnCoin();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
            btnStart.Visible = false;
            lblLevelTime.BringToFront();
            lblLevelTime.Visible = true;
        }

        private void PathFindingTower_Click(object sender, EventArgs e)
        {
            TowerChoice = "ClickTower";
            pctTowerSelect.Image = pctPathFindingTower.Image;

        }

        private void pctLightningTower_Click(object sender, EventArgs e)
        {
            TowerChoice = "LightningTower";
            pctTowerSelect.Image = pctLightningTower.Image;
        }

        private void BasicTowerChoice_Click(object sender, EventArgs e)
        {
            TowerChoice = "BasicTower";
            pctTowerSelect.Image = pctBasicTower.Image;
        }

        public void SelectedMouseMove(object sender, MouseEventArgs e)
        {

            PictureBox Selected = sender as PictureBox; //sets sender to Selected
            if (!dragging) return; //if dragging isnt true then returns the pictureBox
            pctTowerSelect.Visible = true;
            Selected.Top = e.Y + Selected.Top - mouseY; //sets the Y coord of the dragged picturebox to the mouse Y coord
            Selected.Left = e.X + Selected.Left - mouseX; //sets the X coord of the dragged picturebox to the mouse X coord
            TempY = Selected.Top;
            TempX = Selected.Left;
            pctTowerSelect.BackColor = Color.Transparent;

        }
        public void SelectedMouseUp(object sender, MouseEventArgs e)
        {

            mouseX = TempX;
            mouseY = TempY;

            bool Notempty = false; //Is the location vacant?

            foreach (Control T in this.Controls) //checks all the objects
            {
                if (T.Bounds.IntersectsWith(pctTowerSelect.Bounds) && (T.Tag != pctTowerSelect.Tag))
                {
                    Notempty = true; //the location  is vacant
                }
            }

            if ((Notempty == false) && (TowerChoice != ""))
            {

                if (TowerChoice == "BasicTower" && coins >= 10) //checks selected tower and its price
                {

                    Tower tower = new BasicTower(); //creates a new instance of the tower
                    tower.SpawnTower(this, mouseX, mouseY);
                    dragging = false; //moving has stopped so set to false
                    pctTowerSelect.Left = 709; //puts TowerSelect back intp original position
                    pctTowerSelect.Top = 43;
                    coins = coins - 10;
                    labelCoins.Text = "Coins: " + coins; //updates the Coins label
                    pctTowerSelect.BackColor = Color.Black;


                }

                if (TowerChoice == "ClickTower" && coins >= 20) //checks selected tower and its price
                {

                    Tower tower = new ClickTower(); //creates a new instance of the tower
                    tower.SpawnTower(this, mouseX, mouseY);
                    dragging = false; //moving has stopped so set to false
                    pctTowerSelect.Left = 709; //puts TowerSelect back into original position
                    pctTowerSelect.Top = 43;
                    coins = coins - 20;
                    labelCoins.Text = "Coins: " + coins; //updates the Coins label
                    pctTowerSelect.BackColor = Color.Black;

                }

                if (TowerChoice == "LightningTower" && coins >= 70) //checks selected tower and its price
                {

                    Tower tower = new LightningTower(); //creates a new instance of the tower
                    tower.SpawnTower(this, mouseX, mouseY);
                    dragging = false; //moving has stopped so set to false
                    pctTowerSelect.Left = 706; //puts TowerSelect back into original position
                    pctTowerSelect.Top = 43;
                    coins = coins - 70;
                    labelCoins.Text = "Coins: " + coins; //updates the Coins label
                    pctTowerSelect.BackColor = Color.Black;

                }
                else
                {
                    dragging = false;
                    pctTowerSelect.Left = 709;
                    pctTowerSelect.Top = 43;
                    pctTowerSelect.BackColor = Color.Black;
                }

            }
            else
            {
                dragging = false;
                pctTowerSelect.Left = 709;
                pctTowerSelect.Top = 43;
                pctTowerSelect.BackColor = Color.Black;
            }
        }
        public void SelectedMouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
        public void Levels()
        {
            if (GameTimer.Enabled) // only runs if player has clicked the start game button
            {
                LevelTimer.Start();
                if (TimeDecrease == 0) // runs until timer hits 0
                {
                    LevelTimer.Stop();
                    GameTimer.Stop();
                    Level = Level + 1;
                    NextLevel();
                }

            }
        }
        public void LevelTimerTick(object sender, EventArgs e)
        {

            TimeDecrease = TimeDecrease - 1;
            lblLevelTime.Text = "Time Left : " + TimeDecrease;

        }
        public void NextLevel()
        {
            if (Level == 2)
            {

                if (changed == false)
                {
                    ChangeTimer.Start(); //starts the timer changeTimer 
                }
                else
                {
                    levelPassed += 200;
                    playerScore = levelPassed + collisionManage.incScore;
                    lblScore.Text = " Score : " + playerScore;
                    this.BackColor = Color.DarkRed;
                    TowerSelector.BackColor = Color.DimGray;
                    lblLevelTime.BackColor = Color.DimGray;
                    pctSelectedTowerHolder.BackColor = Color.Gray;
                    labelCoins.BackColor = Color.DimGray;
                    labelSelected.BackColor = Color.Gray;
                    lblBasicTower.BackColor = Color.DimGray;
                    lblScore.BackColor = Color.DarkRed;
                    lblClickTower.BackColor = Color.DimGray;
                    lblMortar.BackColor = Color.DimGray;
                    //changes the colours to indicate change in level
                    //TowerSelector.Visible = false;
                    lblLevelTime.Visible = true;
                    pctSelectedTowerHolder.Visible = true;
                    pctTowerSelect.Visible = true;
                    pctBasicTower.Visible = true;
                    pctLightningTower.Visible = true;
                    pctPathFindingTower.Visible = true;
                    labelHealth.Visible = true;
                    healthBar.Visible = true;
                    labelCoins.Visible = true;
                    labelSelected.Visible = true;
                    lblBasicTower.Visible = true;
                    mainBuilding.Visible = true;
                    lblScore.Visible = true;
                    lblClickTower.Visible = true;
                    lblMortar.Visible = true;
                    pctBasicTower.BackColor = Color.DimGray;
                    pctLightningTower.BackColor = Color.DimGray;
                    pctPathFindingTower.BackColor = Color.DimGray;

                    nextLevel.Visible = false;
                    mainBuilding.Image = Properties.Resources.New_Piskel_2_png;
                    //makes them all visible again

                    lblLevelTime.Visible = false;
                    btnStart.Visible = true;
                    btnStart.ForeColor = Color.DimGray;
                    btnStart.BringToFront(); 
                    TimeDecrease = 40;
                    lblLevelTime.Text = "Time Left : " + TimeDecrease;
                    changed = false;
                    //allows user to click button again to start game and restarts the timer

                }

            }
            if (Level == 3)
            {

                if (changed == false)
                {
                    ChangeTimer.Start(); //starts the timer changeTimer 
                }
                else
                {
                    levelPassed += 200;
                    playerScore = levelPassed + collisionManage.incScore;
                    lblScore.Text = " Score : " + playerScore;
                    this.BackColor = Color.Gray;
                    TowerSelector.BackColor = Color.Sienna;
                    lblLevelTime.BackColor = Color.Sienna;
                    pctSelectedTowerHolder.BackColor = Color.Sienna;
                    labelCoins.BackColor = Color.Sienna;
                    labelSelected.BackColor = Color.Sienna;
                    lblBasicTower.BackColor = Color.Sienna;
                    mainBuilding.Image = Properties.Resources.New_Piskel__2_;
                    lblScore.BackColor = Color.Gray;
                    lblClickTower.BackColor = Color.Sienna;
                    lblMortar.BackColor = Color.Sienna;
                    //changes the colours to indicate change in level
                    lblLevelTime.Visible = true;
                    pctSelectedTowerHolder.Visible = true;
                    pctTowerSelect.Visible = true;
                    pctBasicTower.Visible = true;
                    pctLightningTower.Visible = true;
                    pctPathFindingTower.Visible = true;
                    labelHealth.Visible = true;
                    healthBar.Visible = true;
                    labelCoins.Visible = true;
                    labelSelected.Visible = true;
                    lblBasicTower.Visible = true;
                    mainBuilding.Visible = true;
                    lblScore.Visible = true;
                    lblClickTower.Visible = true;
                    lblMortar.Visible = true;
                    nextLevel.Visible = false;
                    pctBasicTower.BackColor = Color.Sienna;
                    pctLightningTower.BackColor = Color.Sienna;
                    pctPathFindingTower.BackColor = Color.Sienna;

                    nextLevel3.Dispose();
                    nextLevel.Dispose();
                    
                    //makes them all visible again

                    lblLevelTime.Visible = false;
                    btnStart.Visible = true;
                    btnStart.ForeColor = Color.DimGray;
                    btnStart.BringToFront();
                    TimeDecrease = 40;
                    lblLevelTime.Text = "Time Left : " + TimeDecrease;
                    
                    //allows user to click button again to start game and restarts the timer

                }
            }
            if (Level == 4)
                //Not actually a level will be a win screen 
            {
                levelPassed += 200;
                playerScore = levelPassed + collisionManage.incScore;
                this.Controls.Remove(CoinSpawn);
                int i = 0;
                while (i != 5)
                {
                    RemoveObject();
                    i = i + 1;
                }
                //removes all objects from screen 
                this.BackColor = Color.Goldenrod;
                PictureBox Win = new PictureBox();
                Win.Image = Properties.Resources.YouWin;
                Win.SizeMode = PictureBoxSizeMode.AutoSize;
                Win.Location = new System.Drawing.Point(220, 30);
                this.Controls.Add(Win);
                
                lblScore.ForeColor = Color.Yellow;
                lblScore.Text = "Your Score : " + playerScore;
                lblScore.BackColor = Color.Goldenrod;
                lblScore.Location = new System.Drawing.Point(220, 250);
                lblScore.Font = (new Font("Britannic", 25, FontStyle.Bold));

                Label lblPlayerName = new Label();
                lblPlayerName.Text = "Name : ";
                lblPlayerName.BackColor = Color.Goldenrod;
                lblPlayerName.Location = new System.Drawing.Point(230, 180);
                lblPlayerName.Font = (new Font("Britannic", 25, FontStyle.Bold));
                this.Controls.Add(lblPlayerName);
                lblPlayerName.AutoSize = true;
                lblPlayerName.ForeColor = Color.Yellow;
                               
                txtPlayerName.BackColor = Color.Yellow;
                txtPlayerName.Location = new System.Drawing.Point(360, 185);
                this.Controls.Add(txtPlayerName);
                txtPlayerName.AutoSize = false;
                txtPlayerName.Size = new System.Drawing.Size(150, 35);
                txtPlayerName.Font = (new Font("Britannic", 17, FontStyle.Bold));
                txtPlayerName.ForeColor = Color.DarkGoldenrod; ;
                txtPlayerName.BorderStyle = BorderStyle.FixedSingle;
                txtPlayerName.BringToFront();
                txtPlayerName.KeyPress += new KeyPressEventHandler(txtPlayerName_changed);
                //sets all its attributes

                Button btnHomeScreen = new Button();
                btnHomeScreen.BackColor = Color.Yellow;
                btnHomeScreen.Location = new System.Drawing.Point(200, 350);
                btnHomeScreen.Font = (new Font("Britannic", 22, FontStyle.Bold));
                this.Controls.Add(btnHomeScreen);
                btnHomeScreen.AutoSize = false;
                btnHomeScreen.Size = new System.Drawing.Size(400, 70);
                btnHomeScreen.ForeColor = Color.Goldenrod;
                btnHomeScreen.FlatStyle = FlatStyle.Popup;
                btnHomeScreen.Text = "RETURN TO MAIN MENU";
                btnHomeScreen.TextAlign = ContentAlignment.MiddleCenter;
                btnHomeScreen.Click += new EventHandler(btnHomeScreen_Click);

            }


        }
        public async void ChangeTimerTick(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            TowerSelector.BackColor = Color.Black;
            lblLevelTime.Visible = false;
            pctSelectedTowerHolder.Visible = false;
            pctTowerSelect.Visible = false;
            pctBasicTower.Visible = false;
            pctLightningTower.Visible = false;
            pctPathFindingTower.Visible = false;
            labelHealth.Visible = false;
            healthBar.Visible = false;
            labelCoins.Visible = false;
            labelSelected.Visible = false;
            lblBasicTower.Visible = false;
            mainBuilding.Visible = false;
            lblScore.Visible = false;
            lblClickTower.Visible = false;
            lblMortar.Visible = false;
            // makes all labels and pictureboxes invisible 
            this.Controls.Remove(CoinSpawn);
            int i = 0;
            while (i != 5)
            {
                RemoveObject();
                i = i + 1;
            }
            if (Level == 2)
            {
                nextLevel.Text = "LEVEL 2";
                nextLevel.Location = new System.Drawing.Point(250, 170);
                nextLevel.ForeColor = Color.Purple;
                nextLevel.Font = (new Font("Britannic", 40, FontStyle.Bold));
                nextLevel.BringToFront();
                nextLevel.AutoSize = true;
                this.Controls.Add(nextLevel);
                ChangeTimer.Stop();
                await Task.Delay(2000);
                changed = true;
                NextLevel();
            }
            if (Level == 3)
            {

                nextLevel3.Visible = true;
                nextLevel3.Text = "LEVEL 3";
                nextLevel3.Location = new System.Drawing.Point(250, 170);
                nextLevel3.ForeColor = Color.Purple;
                nextLevel3.Font = (new Font("Britannic", 40, FontStyle.Bold));
                nextLevel3.BringToFront();
                nextLevel3.AutoSize = true;
                this.Controls.Add(nextLevel3);
                ChangeTimer.Stop();
                await Task.Delay(2000);
                changed = true;
                NextLevel();
            }


        }
        public void RemovExplosion()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "LightningTowerBullet")
                {
                    this.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                }
            }
        }
        public void RemoveTimerTick(object sender, EventArgs e)
        {
            RemovExplosion();
        }
        public void RemoveObject()
        {
            if (Level == 4 || PlayerDead == true)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox)
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                    if (x is Label && x != lblScore)
                    {
                        this.Controls.Remove(x);
                        ((Label)x).Dispose();
                    }
                    if (x is ProgressBar)
                    {
                        this.Controls.Remove(x);
                        ((ProgressBar)x).Dispose();
                    }
                }
            }
            else
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "LightningTowerBullet" || x is PictureBox && (string)x.Tag == "LightningTower" || x is PictureBox && (string)x.Tag == "BigEnemy" || x is PictureBox && (string)x.Tag == "SmallEnemy" || x is PictureBox && (string)x.Tag == "tower" || x is PictureBox && (string)x.Tag == "BasicTowerBullet" || x is PictureBox && (string)x.Tag == "ClickedBullet")
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                    //removes all remaining enemies and towers from map
                }
            }
        }
        private void txtPlayerName_changed(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                var pattern = "^[a-zA-Z0-9-]+$";
                if (txtPlayerName.Text.Length <= 5)
                {
                    if (Regex.IsMatch(txtPlayerName.Text, pattern, RegexOptions.IgnoreCase))
                    {
                        //if the username doesnt contain any banned characters
                        playerName = txtPlayerName.Text;
                        ReadStats();
                        lblerror.Visible = false;
                        lblNameLength.Visible = false;
                        lblNoUser.Visible = false;
                        UserEntered = true;
                    }
                    else
                    {
                        //creates an error
                        lblNoUser.Visible = false;
                        lblNameLength.Visible = false;
                        lblerror.Visible = true;
                        lblerror.Text = ("error : no special characters allowed");
                        lblerror.BackColor = Color.Goldenrod;
                        lblerror.Location = new System.Drawing.Point(185, 220);
                        lblerror.Font = (new Font("Britannic", 15, FontStyle.Bold));
                        this.Controls.Add(lblerror);
                        lblerror.AutoSize = true;
                        lblerror.ForeColor = Color.Red;
                        txtPlayerName.Text = "";
                    }
                }
                else
                {
                    //creates an error
                    lblNoUser.Visible = false;
                    lblNameLength.Visible = true;
                    lblerror.Visible = false;
                    lblNameLength.Visible = true;
                    lblNameLength.Text = ("error : username has to be than 5 characters or less");
                    lblNameLength.BackColor = Color.Goldenrod;
                    lblNameLength.Location = new System.Drawing.Point(160, 220);
                    lblNameLength.Font = (new Font("Britannic", 15, FontStyle.Bold));
                    this.Controls.Add(lblNameLength);
                    lblNameLength.AutoSize = true;
                    lblNameLength.ForeColor = Color.Red;
                    txtPlayerName.Text = "";
                }
            }
        }
        private void btnHomeScreen_Click(object sender, EventArgs e)
        {
            if (UserEntered == true)
            {
                this.Close();
            }
            else
            {
                lblNameLength.Visible = false;
                lblerror.Visible = false;
                lblNoUser.Visible = true;
                lblNoUser.Text = ("No name has been entered");
                lblNoUser.BackColor = Color.Goldenrod;
                lblNoUser.Location = new System.Drawing.Point(240, 220);
                lblNoUser.Font = (new Font("Britannic", 15, FontStyle.Bold));
                this.Controls.Add(lblNoUser);
                lblNoUser.AutoSize = true;
                lblNoUser.ForeColor = Color.Red;
            }

        }



        public void ReadStats()
        {
            string FileName =  @"Player Stats.csv";
            TextWriter TextFile = new StreamWriter(FileName,true);
            TextFile.WriteLine(playerName +","+ playerScore);
            //creates a new textfile to store players name and score
            TextFile.Close();

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }





    }



}

