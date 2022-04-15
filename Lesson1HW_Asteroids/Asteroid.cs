using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lesson1HW_Asteroids
{
    class Asteroid : BaseObject
    {
        public int Power { get; set; }
        public Asteroid(Point pos, Point dir, Size size) : base(pos,dir,size)
        {
            Power = 1;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.FillEllipse(Brushes.White, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
