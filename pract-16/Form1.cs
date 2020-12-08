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
        public Form1()
        {
            InitializeComponent();
            ast1.Parent = Background;
            ast1.BackColor = Color.Transparent;
            asteroids.Add(ast1);
            ast2.Parent = Background;
            ast2.BackColor = Color.Transparent;
            asteroids.Add(ast2);
            ast3.Parent = Background;
            ast3.BackColor = Color.Transparent;
            asteroids.Add(ast3);
            ast4.Parent = Background;
            ast4.BackColor = Color.Transparent;
            asteroids.Add(ast4);
            ast5.Parent = Background;
            ast5.BackColor = Color.Transparent;
            asteroids.Add(ast5);
            ast6.Parent = Background;
            ast6.BackColor = Color.Transparent;
            asteroids.Add(ast6);
            rocket.Parent = Background;
            rocket.BackColor = Color.Transparent;
            meteorMoveSpeed = 5;
        }

        private void Rocket_KeyUp(object sender, KeyEventArgs e)
        {
            rocketMoveSpeed = 0;
        }

        private void Rocket_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Left)
            {
                rocketMoveSpeed = -12;
            }
            if(e.KeyData == Keys.Right)
            {
                rocketMoveSpeed = 12;
            }
        }

        private void ObjectsMove(object sender, EventArgs e)
        {
            rocket.Left += rocketMoveSpeed;
            ast1.Top += meteorMoveSpeed;
            ast2.Top += meteorMoveSpeed;
            ast3.Top += meteorMoveSpeed;
            ast4.Top += meteorMoveSpeed;
            ast5.Top += meteorMoveSpeed;
            ast6.Top += meteorMoveSpeed;
        }
    }
}
