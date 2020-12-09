using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


//Нужно написать функцию для подсчета расстояния выживания и отображения его на экране
//Нужно написать функцию для записи рекордного расстояния и отображения его на экране

namespace pract_16
{ 

    public partial class Form1 : Form
    {
        public int rocketMoveSpeed = 0;
        public int meteorMoveSpeed = 0;        
        public List<PictureBox> asteroids = new List<PictureBox>();
        public Random rnd = new Random();
        public Rectangle[] collisions = new Rectangle[7];
        public Rectangle playerCollision;
        public float currentDistance;
        public float recordDistance;

        public Form1()
        {
            InitializeComponent();            
            asteroids.Add(ast1);            
            asteroids.Add(ast2);            
            asteroids.Add(ast3);            
            asteroids.Add(ast4);            
            asteroids.Add(ast5);            
            asteroids.Add(ast6);
            asteroids.Add(ast7);            
            StartGame();
        }        
        
        private void Rocket_KeyUp(object sender, KeyEventArgs e)
        {
            rocketMoveSpeed = 0;            
        }

        private void Rocket_KeyDown(object sender, KeyEventArgs e)
        {
            meteorMoveSpeed = 5;
            if (e.KeyData == Keys.Left)
            {
                rocketMoveSpeed = -10;
            }
            if(e.KeyData == Keys.Right)
            {
                rocketMoveSpeed = 10;
            }
            if(e.KeyData == Keys.Escape)
            {
                MainMenu();
            }
        }

        private void ObjectsMove(object sender, EventArgs e)
        {
            
            rocket.Left += rocketMoveSpeed;
            if(meteorMoveSpeed > 0)
            {
                currentDistance += 0.1f;
                distance.Text = "Пройдено километров - " + currentDistance.ToString();
            }            
            if (rocket.Location.X < 0)
            {
                rocket.Location = new Point(810, rocket.Location.Y);
            }
            if (rocket.Location.X > 810)
            {
                rocket.Location = new Point(0, rocket.Location.Y);
            }

            playerCollision = rocket.DisplayRectangle;
            playerCollision.Location = rocket.Location;
            for (int i = 0; i < asteroids.Count; i++)
            {                
                asteroids[i].Top += meteorMoveSpeed;                
            }
            for (int i = 0; i < asteroids.Count; i++)
            {
               if(asteroids[i].Location.Y > 700)
               {
                    asteroids[i].Location = new Point(rnd.Next(0, 810), rnd.Next(-500, 0));
                    asteroids[i].Size = new Size(rnd.Next(70, 100), rnd.Next(70, 100));
                }  
            }
            for(int i = 0; i < collisions.Length; i++)
            {
                collisions[i] = asteroids[i].DisplayRectangle;
                collisions[i].Location = asteroids[i].Location;
                if(playerCollision.IntersectsWith(collisions[i]) == true)
                {
                    timer1.Enabled = false;
                    DeadPlayer();
                }
            }
        }

        private void LoadMainMenu(object sender, EventArgs e)
        {
            MainMenu();
        }
        public void MainMenu()
        {
            meteorMoveSpeed = 0;
            MainMenu menu = new MainMenu();
            menu.ShowDialog(this);
        }
        public void ExplosionAnimation(bool start)
        {
            if (start)
            {
                explosion.Image = Image.FromFile("./Resources/explosing.gif");
            }
            else
            {
                explosion.Image = null;
            }
        }
        public void DeadPlayer()
        {
            rocket.Visible = false;
            explosion.Location = new Point(rocket.Location.X, rocket.Location.Y);
            ExplosionAnimation(true);
            RestartGame();
        }

        public void StartGame()
        {
            rocket.Visible = true;
            for (int i = 0; i < asteroids.Count; i++)
            {
                asteroids[i].Parent = Background;
                asteroids[i].BackColor = Color.Transparent;
                asteroids[i].Location = new Point(asteroids[i].Location.X, rnd.Next(-500, 0));
                asteroids[i].Size = new Size(rnd.Next(70, 100), rnd.Next(70, 100));
            }
            meteorMoveSpeed = 0;
            rocketMoveSpeed = 0;
            rocket.Parent = Background;
            rocket.BackColor = Color.Transparent;
            explosion.Parent = Background;
            explosion.BackColor = Color.Transparent;            
            ExplosionAnimation(false);
            currentDistance = 0;
            distance.Text = "Пройдено километров - " + currentDistance.ToString();
            timer1.Enabled = true;
        }

        public void RestartGame()
        {
            Restart restart = new Restart();
            restart.ShowDialog(this);            
            StartGame();
        }
        
    }
}
