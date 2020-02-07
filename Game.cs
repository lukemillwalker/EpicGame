using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Game_Thing
{
    //This is the game
    //Everything the game does is run through here
    public partial class Game : Form {
        //List that contains the snake
        //contains the location of the snake
        //size of the snake is set in draw method
        private List<Circle> Snake = new List<Circle>();

        //contains the location of the food
        //when food is consumed it is reset
        private Circle food = new Circle();

        //contains the high score data
        private HighScore hs = new HighScore();
        
        //contains the size of the canvas that the snake is on
        private Size canvas_Size;

        //boolean playAgain used to determine if playing again
        private bool playAgain = false;
        public Game() {
            //code for setting up gui elements
            InitializeComponent();

            //initilize settings

            /**
             * settings class contains size of sqaures on board
             * the speed of the snake
             * whether the game is over or not
             * the current score
             */
            new Settings();

            //initilizes size of canvas to fit the squares perfectly
            canvas_Size = new Size(Settings.Width * 25, Settings.Height * 25);
            SnakeCanvas.Size = canvas_Size;

            //Set game speed and start timer
            GamerTimer.Interval = 1000 / Settings.Speed;

            //for every timer interval it calls the update screen method
            GamerTimer.Tick += UpdateScreen;
            GamerTimer.Start();

            printScore();

            //start new Game
            startGame();

        }

        private void startGame() {
            //set settings to default
            new Settings();

            //empty Snake list
            Snake.Clear();

            //create new player character
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            //set up highScore
            lblScore.Text = Settings.Score.ToString();
            GameOverPanel.Visible = false;
            playAgain = false;
            this.Focus();

            //generate the food
            GenerateFood();
        }

        //method to place food on board
        private void GenerateFood() {
            //sets the bounds for the food 
            int maxXPos = SnakeCanvas.Width / Settings.Width;
            int maxYPos = SnakeCanvas.Height / Settings.Height;

            //sets the food to a random location
            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);
        }

        //method to update the screen
        private void UpdateScreen(object sender, EventArgs e) {

            //check if game is over
            if (Settings.GameOver == true) {

                //check if exit screen is exited
                if (playAgain) {
                    startGame();
                }
            }

            //code to update screen

            //sets the direction based on the input
            else {
                if (Input.keyPressed(Keys.Right) && Settings.direction != Direction.Left) {
                    Settings.direction = Direction.Right;
                }
                else if (Input.keyPressed(Keys.Left) && Settings.direction != Direction.Right) {
                    Settings.direction = Direction.Left;
                }
                else if (Input.keyPressed(Keys.Up) && Settings.direction != Direction.Down) {
                    Settings.direction = Direction.Up;
                }
                else if (Input.keyPressed(Keys.Down) && Settings.direction != Direction.Up) {
                    Settings.direction = Direction.Down;
                }

                //calls the call player method that
                //moves the player based on the settings direction
                MovePlayer();
            }

            //very necessary makes the canvas redraw itself every time this method is called
            SnakeCanvas.Invalidate();

        }

        //Event to paint things on the canvas
        private void SnakeCanvas_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Brush snakeColor;

            //draw board so it is checkered
            Brush checkered1 = Brushes.ForestGreen;
            Brush checkered2 = Brushes.Green;
            bool drawCheckered_1 = true;
            for (int row = 0; row < SnakeCanvas.Height / Settings.Height; row++) {
                for (int col = 0; col < SnakeCanvas.Width / Settings.Width; col++) {
                    Rectangle checkered = new Rectangle(col * Settings.Width, row * Settings.Height, Settings.Width, Settings.Height);
                    if (drawCheckered_1) {
                        g.FillRectangle(checkered1, checkered);
                        drawCheckered_1 = false;
                    }
                    else {
                        g.FillRectangle(checkered2, checkered);
                        drawCheckered_1 = true;
                    }
                }
            }


            if (!Settings.GameOver) {
                for (int i = 0; i < Snake.Count; i++) {
                    if (i == 0) {
                        snakeColor = Brushes.Black;
                    }
                    else {
                        snakeColor = Brushes.Blue;
                    }

                    g.FillEllipse(snakeColor, new Rectangle(Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height, Settings.Width, Settings.Height));

                    g.FillEllipse(Brushes.Red, new Rectangle(food.X * Settings.Width,
                        food.Y * Settings.Height, Settings.Width, Settings.Height));

                }
            }
            else {
                GameOverPanel.Visible = true;
                NameBox.Enabled = true;
                String gameOver = "Game over final score is " + Settings.Score + " \n Please enter your name";
                lblGameOver.Text = gameOver;
                GameOverPanel.Location = new Point(canvas_Size.Width / 2 + SnakeCanvas.Location.X - GameOverPanel.Width / 2,
                    canvas_Size.Height / 2 + SnakeCanvas.Location.Y - GameOverPanel.Height / 2);
            }
        }

        //method to move the player
        private void MovePlayer() {
            for (int i = Snake.Count - 1; i >= 0; i--) {

                if (i == 0) {

                    switch (Settings.direction) {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }

                    //if the snake hits the edges of the game board it dies
                    int maxXPos = SnakeCanvas.Size.Width / Settings.Width;
                    int maxYPos = SnakeCanvas.Size.Height / Settings.Height;

                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos) {
                        Die();
                    }

                    //check if the snake runs into itself
                    //if the snake hits itself it dies
                    for (int k = 1; k < Snake.Count; k++) {
                        if (Snake[i].X == Snake[k].X && Snake[i].Y == Snake[k].Y) {
                            Die();
                        }
                    }

                    for (int j = 0; j < Snake.Count; j++) {
                        if (Snake[j].X == food.X && Snake[j].Y == food.Y) {
                            Eat();
                        }
                    }
                }
                else {
                    // if the snake is not the head draw it to follow the one in front of it
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        //sets game over to true
        private void Die() {
            Settings.GameOver = true;

        }

        //method to consume food
        private void Eat() {
            Circle body = new Circle();

            //draws the new body part based on the direction the snake is going
            switch (Settings.direction) {
                case Direction.Up:
                    body.Y = Snake[Snake.Count - 1].Y + Settings.Height;
                    body.X = Snake[Snake.Count - 1].X;
                    break;
                case Direction.Down:
                    body.Y = Snake[Snake.Count - 1].Y - Settings.Height;
                    body.X = Snake[Snake.Count - 1].X;
                    break;
                case Direction.Right:
                    body.Y = Snake[Snake.Count - 1].Y;
                    body.X = Snake[Snake.Count - 1].X - Settings.Width;
                    break;
                case Direction.Left:
                    body.Y = Snake[Snake.Count - 1].Y;
                    body.X = Snake[Snake.Count - 1].X + Settings.Width;
                    break;
            }
            //adds the body to the end of the list
            Snake.Add(body);
            //increments the score
            Settings.Score = Settings.Score + 1;
            lblScore.Text = Settings.Score.ToString();
            //generates food in a new location
            GenerateFood();

        }


        private void printScore() {
            Label[] labels = { lblFirst, lblSecondPlace, lblThirdPlace, lblFourthPlace, lblFifthPlace };
            String[] scoreData = hs.getHighScore();
            for (int i = 0; i < scoreData.Length; i++) {
                labels[i].Text = i + 1 + ". " + scoreData[i];
            }
        }
        private void addScore(String name, int score) {
            hs.addScore(score, name);
            printScore();
        }
        //gets the key being pressed
        private void Game_KeyDown(object sender, KeyEventArgs e) {
            Input.changeState(e.KeyCode, true);
        }

        //gets the key being released
        private void Game_KeyUp(object sender, KeyEventArgs e) {
            Input.changeState(e.KeyCode, false);
        }

        //when game is over and this button is pressed gets user data and resets board
        private void EnterButton_Click(object sender, EventArgs e) {
            String name = "";
                name = NameBox.Text;
                name = name.Trim();
                if (name.Equals("")) {
                name = "Unknown";
                }
            addScore(name, Settings.Score);
            NameBox.ResetText();
            playAgain = true;
         
        }
    }
}
