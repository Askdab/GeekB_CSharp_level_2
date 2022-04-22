using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lesson1HW_Asteroids
{
    class Asteroid : BaseObject, ICloneable
    {
        public int Power { get; set; } = 3;
        public Asteroid(Point pos, Point dir, Size size) : base(pos,dir,size)
        {
            Power = 1;
        }

        public object Clone()
        {
            Asteroid asteroid = new Asteroid(new Point(Pos.X, Pos.Y), new Point(Dir.X, Dir.Y), new Size(Size.Width, Size.Height)) { Power = Power };
            return asteroid;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.FillEllipse(Brushes.White, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            if (Pos.X < 0) Pos.X = Game.Width + Game.Height;
        }
    }
}
