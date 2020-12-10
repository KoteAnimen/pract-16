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

namespace pract_16
{ 

    public partial class Form1 : Form
    {
        public int rocketMoveSpeed = 0;//скорость передвижения игрока
        public int meteorMoveSpeed = 0;//скорость передвижения астероида
        public double currentDistance;//текущая пройденная дистанция
        public double recordDistance;//рекордная дистанция
        public List<PictureBox> asteroids = new List<PictureBox>();//список всех астероидов
        public Random rnd = new Random();
        public Rectangle[] collisions = new Rectangle[7];//массив координат астероидов
        public Rectangle playerCollision;//координаты игрока
        

        public Form1()
        {
            InitializeComponent();            
            asteroids.Add(ast1);//добавляем астероиды в список           
            asteroids.Add(ast2);            
            asteroids.Add(ast3);            
            asteroids.Add(ast4);            
            asteroids.Add(ast5);            
            asteroids.Add(ast6);
            asteroids.Add(ast7);            
            StartGame();//старт игры
        }        
        //события нажатия и отпускания клывишь
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
        //событие обновления сцены за каждый тик таймера
        private void ObjectsMove(object sender, EventArgs e)
        {
            //контроллер персонажа
            rocket.Left += rocketMoveSpeed;
            if(meteorMoveSpeed > 0)
            {
                currentDistance += 0.1;
                currentDistance = Math.Round(currentDistance, 2);
                distance.Text = "Пройдено километров - " + currentDistance.ToString();
                record.Text = "Текущий рекорд - " + recordDistance.ToString();
                if(currentDistance >= recordDistance)
                {
                    recordDistance = currentDistance;
                }
            }            
            if (rocket.Location.X < 0)
            {
                rocket.Location = new Point(810, rocket.Location.Y);
            }
            if (rocket.Location.X > 810)
            {
                rocket.Location = new Point(0, rocket.Location.Y);
            }
            //
            //получаем координаты персонажа
            playerCollision = rocket.DisplayRectangle;
            playerCollision.Location = rocket.Location;
            
            //передвигаем астероиды
            for (int i = 0; i < asteroids.Count; i++)
            {                
                asteroids[i].Top += meteorMoveSpeed;                
            }
            
            //передвигаем астероиды, которые "упали" и меняем их размер
            for (int i = 0; i < asteroids.Count; i++)
            {
               if(asteroids[i].Location.Y > 700)
               {
                    asteroids[i].Location = new Point(rnd.Next(0, 810), rnd.Next(-500, 0));
                    asteroids[i].Size = new Size(rnd.Next(70, 100), rnd.Next(70, 100));
                }  
            }
            //реализация столкновений игрока с астероидом
            for(int i = 0; i < collisions.Length; i++)
            {
                collisions[i] = asteroids[i].DisplayRectangle;
                collisions[i].Location = asteroids[i].Location;
                //если персонаж столкнулся с астероидом, то он умирает 
                if(playerCollision.IntersectsWith(collisions[i]) == true)
                {
                    timer1.Enabled = false;
                    DeadPlayer();
                }
            }
        }
        //Загружаем главное меню при запуске главной формы
        private void LoadMainMenu(object sender, EventArgs e)
        {
            MainMenu();
        }
        //функция включения главного меню
        public void MainMenu()
        {
            meteorMoveSpeed = 0;
            MainMenu menu = new MainMenu();
            menu.ShowDialog(this);
        }
        //функция отображения взрыва
        public void ExplosionAnimation(bool start)
        {
            if (start)
            {
                explosion.Visible = true;
            }
            else
            {
                explosion.Visible = false;
            }
        }
        //функция сперти персонажа
        public void DeadPlayer()
        {
            rocket.Visible = false;
            explosion.Location = new Point(rocket.Location.X, rocket.Location.Y);
            ExplosionAnimation(true);
            RestartGame();
        }
        //функция старта игры
        public void StartGame()
        {
            try
            {
                StreamReader readRecord = new StreamReader("record.xml");
                recordDistance = Convert.ToDouble(readRecord.ReadLine());
                record.Text = "Текущий рекорд - " + recordDistance.ToString();
            }
            catch
            {
                recordDistance = 0;
                record.Text = "Текущий рекорд - " + recordDistance.ToString();
            }
            
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
        //функция рестарта игры
        public void RestartGame()
        {
            StreamWriter saveRecord = new StreamWriter("record.xml");
            saveRecord.WriteLine(recordDistance.ToString());
            saveRecord.Close();
            Restart restart = new Restart();
            restart.ShowDialog(this);            
            StartGame();
        }
        
    }
}
