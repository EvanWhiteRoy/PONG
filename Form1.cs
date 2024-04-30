using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PONG
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(10, 30, 10, 80);
        Rectangle player2 = new Rectangle(10, 300   , 10, 80);
        Rectangle ball = new Rectangle(295, 195, 10, 10);

        int player1Score = 0;
        int player2Score = 0;

        int playerSpeed = 4;
        int ballXSpeed = -10;
        int ballYSpeed = -10;

        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;
        int playerTurn = 1;
        bool aDown = false;
        bool rightDown = false;
        bool leftDown = false;
        bool dDown = false;
        bool playerGo = true;
        Pen borderDraw = new Pen(Color.DarkGoldenrod); 

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Crimson);
        Pen whitePen = new Pen(Color.White);
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move ball
            ball.X = ball.X + ballXSpeed;
            ball.Y = ball.Y + ballYSpeed;

            //check if ball hits wall
            if(ball.Y <= 0 || ball.Y >= this.Height - ball.Height)
            {
                ballYSpeed = -ballYSpeed;
            }
            if(ball.X <= 0)
            {
                //ballXSpeed = -ballXSpeed;
            }

            //Move player 1
            if(wPressed == true && player1.Y >0)
            {
                player1.Y = player1.Y - playerSpeed;
            }

            if(sPressed == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y = player1.Y + playerSpeed;
            }
            if (dDown == true && player1.X < this.Height - player1.Height)
            {
                player1.X = player1.X + playerSpeed;
            }
            if (aDown == true && player1.X < this.Height - player1.Height)
            {
                player1.X = player1.X - playerSpeed;
            }

            //Move player 2

            if (upPressed == true && player2.Y > 0)
            {
                player2.Y = player2.Y - playerSpeed;
            }

            if (downPressed == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y = player2.Y + playerSpeed;
            }
            if (leftDown == true && player2.X < this.Height - player2.Height)
            {
                player2.X = player2.X - playerSpeed;
            }
            if (rightDown == true && player2.X < this.Height - player2.Height)
            {
                player2.X = player2.X + playerSpeed;
            }

            //check if ball hits player 1
            if (ballXSpeed < 0 && player1.IntersectsWith(ball) && playerGo == true)
            {
                ballXSpeed = -ballXSpeed;
                ball.X = player1.X + player1.Width;
                playerGo = false;
            }
            //check if ball hits player 2
            if (ballXSpeed < 0 && player2.IntersectsWith(ball) && playerGo ==false)
            {
                ballXSpeed = -ballXSpeed;
                ball.X = player2.X + player2.Width;
                playerGo = true;
                
            }

            //Check if ball goes off left side of screen

            if(ball.X <= 0)
            {
                if (playerGo == true)
                {
                    player1Score++;
                    p1scorelabel.Text = $"{player1Score}";
                    player1.X = 10;
                }
                else
                {
                    player2Score++;
                    p2scoreLabel.Text = $"{player2Score}";
                }

                ball.X = 295;
                ball.Y = 195;
                ballXSpeed = -6;

                player1.X = 10;
                player1.Y = 30;
                player2.X = 10;
                player2.Y = 300;







            }

            //Check if ball goes off right side of screen

            if (ball.X >= this.Width)
            {
                ballXSpeed = -ballXSpeed;
            }
                
                

            //check for winner

            if(player1Score == 5)
            {
                winnerLabel.Text = "Player 1 Wins";
                gameTimer.Stop();
                //ball.Visible = false;
            }
            if (player2Score == 5)
            {
                winnerLabel.Text = "Player 2 Wins";
                gameTimer.Stop();
            }
            

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(redBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, ball);
            if(playerGo == true)
            {
                e.Graphics.FillRectangle(whiteBrush, player1);
            }
            else
            {
                e.Graphics.FillRectangle(whiteBrush, player2);
            }


        }
//        








    }
}
