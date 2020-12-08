using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_16
{ 

    public partial class Form1 : Form
    {
        public int rocketMoveSpeed = 0;
        public int meteorMoveSpeed = 0;        
        public List<PictureBox> asteroids = new List<PictureBox>();
        public Random rnd = new Random();        

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
            for (int i = 0; i < asteroids.Count; i++)
            {
                asteroids[i].Parent = Background;
                asteroids[i].BackColor = Color.Transparent;
                asteroids[i].Location = new Point(asteroids[i].Location.X, rnd.Next(-500, 0));
            }
            rocket.Parent = Background;
            rocket.BackColor = Color.Transparent;
            explosion.Parent = Background;
            explosion.BackColor = Color.Transparent;
            ExplosionAnimation(false);
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
            for(int i = 0; i < asteroids.Count; i++)
            {                
                asteroids[i].Top += meteorMoveSpeed;                
            }
            for (int i = 0; i < asteroids.Count; i++)
            {
               if(asteroids[i].Location.Y > 580)
               {
                    asteroids[i].Location = new Point(rnd.Next(0, 810), rnd.Next(-500, 0));                                       
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
        }
        
    }
}
