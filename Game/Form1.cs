using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int car_speed = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            move_line(car_speed);
            enemy(car_speed);
            gameOver();
            countScore();
            coins(car_speed);

        }
        int point = 0;
        private void countScore()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds) ||
                car.Bounds.IntersectsWith(coin2.Bounds) ||
                car.Bounds.IntersectsWith(coin3.Bounds) ||
                car.Bounds.IntersectsWith(coin4.Bounds) ||
                car.Bounds.IntersectsWith(coin5.Bounds)
                )
            {
                point++;
                scoreLabel.Text = "Score: " + point;
                Random r = new Random();
                int x, y;
                y = 0;
                if (car.Bounds.IntersectsWith(coin1.Bounds))
                {
                    x = r.Next(0, 100);
                    coin1.Location = new Point(x, y);
                }
                if (car.Bounds.IntersectsWith(coin2.Bounds))
                {
                    x = r.Next(150, 200);
                    coin2.Location = new Point(x, y);
                }
                if (car.Bounds.IntersectsWith(coin3.Bounds))
                {
                    x = r.Next(210, 250);
                    coin3.Location = new Point(x, y);
                }
                if (car.Bounds.IntersectsWith(coin4.Bounds))
                {
                    x = r.Next(250, 300);
                    coin4.Location = new Point(x, y);
                }
                if (car.Bounds.IntersectsWith(coin5.Bounds))
                {
                    x = r.Next(300, 450);
                    coin5.Location = new Point(x, y);
                }
            }
        }
        private void gameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds) ||
                car.Bounds.IntersectsWith(enemy2.Bounds) || 
                car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer.Enabled = false;
                gaveOverText.Visible = true;
            }
        }

        private void coins(int speed)
        {
            Random r = new Random();
            int x, y;
            y = 0;
            if (coin1.Top > 500)
            {
                x = r.Next(0, 100);
                coin1.Location = new Point(x, y);

            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top > 500)
            {
                x = r.Next(110, 220);
                coin2.Location = new Point(x, y);

            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top > 500)
            {
                x = r.Next(250, 350);
                coin3.Location = new Point(x, y);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top > 500)
            {
                x = r.Next(350, 400);
                coin4.Location = new Point(x, y);
            }
            else
            {
                coin4.Top += speed;
            }

            if (coin5.Top > 500)
            {
                x = r.Next(400, 550);
                coin5.Location = new Point(x, y);
            }
            else
            {
                coin5.Top += speed;
            }

        }
        private void enemy(int speed)
        {
            Random r = new Random();
            int x, y;
            y = 0;
            if (enemy1.Top > 500)
            {
                x = r.Next(0,180);
                enemy1.Location = new Point(x,y);

            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top > 500)
            {
                x = r.Next(200, 380);
                enemy2.Location = new Point(x, y);
  
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top > 500)
            {
                x = r.Next(400, 550);
                enemy3.Location = new Point(x, y);
            }
            else
            {
                enemy3.Top += speed;
            }

        }
        public void move_line(int speed)
        {
            if (divider1.Top > 550)
            {
                divider1.Top = 0;
            }
            else
            {
                divider1.Top += speed;
            }

            if (divider2.Top > 550)
            {
                divider2.Top = 0;
            }
            else
            {
                divider2.Top += speed;
            }


            if (divider3.Top > 550)
            {
                divider3.Top = 0;
            }
            else
            {
                divider3.Top += speed;
            }

            if (divider4.Top > 550)
            {
                divider4.Top = 0;
            }
            else
            {
                divider4.Top += speed;
            }
        }

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                if(car_speed<10)
                   car_speed += 1;
               
            }

            if(e.KeyCode == Keys.Space)
            {
                car_speed = 0;
            }
            if(e.KeyCode == Keys.Left)
            {
                if(car.Left>20)
                  car.Left -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 610)
                    car.Left += 10;
            }
        }

   
    }
}
