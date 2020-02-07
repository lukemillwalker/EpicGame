namespace Game_Thing
{
    partial class Game
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
            this.SnakeCanvas = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.GamerTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.lblLeaderBoard = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecondPlace = new System.Windows.Forms.Label();
            this.lblThirdPlace = new System.Windows.Forms.Label();
            this.lblFourthPlace = new System.Windows.Forms.Label();
            this.lblFifthPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeCanvas)).BeginInit();
            this.GameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SnakeCanvas
            // 
            this.SnakeCanvas.BackColor = System.Drawing.Color.DimGray;
            this.SnakeCanvas.Location = new System.Drawing.Point(46, 42);
            this.SnakeCanvas.Margin = new System.Windows.Forms.Padding(6);
            this.SnakeCanvas.Name = "SnakeCanvas";
            this.SnakeCanvas.Size = new System.Drawing.Size(882, 746);
            this.SnakeCanvas.TabIndex = 1;
            this.SnakeCanvas.TabStop = false;
            this.SnakeCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.SnakeCanvas_Paint);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(958, 42);
            this.Score.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(166, 66);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1176, 42);
            this.lblScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 66);
            this.lblScore.TabIndex = 3;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(3, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(76, 25);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "Visible";
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.Controls.Add(this.EnterButton);
            this.GameOverPanel.Controls.Add(this.NameBox);
            this.GameOverPanel.Controls.Add(this.lblGameOver);
            this.GameOverPanel.Location = new System.Drawing.Point(362, 243);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(275, 171);
            this.GameOverPanel.TabIndex = 5;
            this.GameOverPanel.Visible = false;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(88, 124);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(101, 44);
            this.EnterButton.TabIndex = 6;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(45, 77);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(177, 31);
            this.NameBox.TabIndex = 5;
            // 
            // lblLeaderBoard
            // 
            this.lblLeaderBoard.AutoSize = true;
            this.lblLeaderBoard.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderBoard.Location = new System.Drawing.Point(969, 170);
            this.lblLeaderBoard.Name = "lblLeaderBoard";
            this.lblLeaderBoard.Size = new System.Drawing.Size(296, 64);
            this.lblLeaderBoard.TabIndex = 6;
            this.lblLeaderBoard.Text = "High Scores:";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(978, 286);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(56, 53);
            this.lblFirst.TabIndex = 7;
            this.lblFirst.Text = "1.";
            // 
            // lblSecondPlace
            // 
            this.lblSecondPlace.AutoSize = true;
            this.lblSecondPlace.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlace.Location = new System.Drawing.Point(978, 378);
            this.lblSecondPlace.Name = "lblSecondPlace";
            this.lblSecondPlace.Size = new System.Drawing.Size(56, 53);
            this.lblSecondPlace.TabIndex = 8;
            this.lblSecondPlace.Text = "2.";
            // 
            // lblThirdPlace
            // 
            this.lblThirdPlace.AutoSize = true;
            this.lblThirdPlace.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPlace.Location = new System.Drawing.Point(978, 466);
            this.lblThirdPlace.Name = "lblThirdPlace";
            this.lblThirdPlace.Size = new System.Drawing.Size(56, 53);
            this.lblThirdPlace.TabIndex = 9;
            this.lblThirdPlace.Text = "3.";
            // 
            // lblFourthPlace
            // 
            this.lblFourthPlace.AutoSize = true;
            this.lblFourthPlace.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthPlace.Location = new System.Drawing.Point(978, 553);
            this.lblFourthPlace.Name = "lblFourthPlace";
            this.lblFourthPlace.Size = new System.Drawing.Size(56, 53);
            this.lblFourthPlace.TabIndex = 10;
            this.lblFourthPlace.Text = "4.";
            // 
            // lblFifthPlace
            // 
            this.lblFifthPlace.AutoSize = true;
            this.lblFifthPlace.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifthPlace.Location = new System.Drawing.Point(978, 638);
            this.lblFifthPlace.Name = "lblFifthPlace";
            this.lblFifthPlace.Size = new System.Drawing.Size(56, 53);
            this.lblFifthPlace.TabIndex = 11;
            this.lblFifthPlace.Text = "5.";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.lblFifthPlace);
            this.Controls.Add(this.lblFourthPlace);
            this.Controls.Add(this.lblThirdPlace);
            this.Controls.Add(this.lblSecondPlace);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblLeaderBoard);
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.SnakeCanvas);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeCanvas)).EndInit();
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SnakeCanvas;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GamerTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Panel GameOverPanel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label lblLeaderBoard;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecondPlace;
        private System.Windows.Forms.Label lblThirdPlace;
        private System.Windows.Forms.Label lblFourthPlace;
        private System.Windows.Forms.Label lblFifthPlace;
    }
}

