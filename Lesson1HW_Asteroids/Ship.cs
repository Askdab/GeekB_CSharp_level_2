﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lesson1HW_Asteroids
{
    class Ship : BaseObject
    {
        private int _energy = 100;
        public int Energy => _energy;
        public static event Message MessageDie;

        Image ship = Image.FromFile(@"img\ship.png");

        public void EnergyLow(int n)
        {
            _energy -= n;
        }

        public Ship(Point pos, Point dir, Size size):base(pos, dir, size)
        {

        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(ship, Pos.X, Pos.Y, Size.Width, Size.Height);

        }

        public override void Update()
        {
            
        }

        public void Up()
        {
            if (Pos.Y > 0) Pos.Y = Pos.Y - Dir.Y;
        }

        public void Down()
        {
            if (Pos.Y < Game.Height) Pos.Y = Pos.Y + Dir.Y;
        }

        public void Die() 
        {
            MessageDie?.Invoke();
        }
    }
}
