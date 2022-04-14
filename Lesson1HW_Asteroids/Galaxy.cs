using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lesson1HW_Asteroids
{
    class Galaxy : BaseObject
    {
        //Добавляем картинку астероида
        //Image asteroid = Image.FromFile("aster.png");
        

        public Galaxy(Point pos, Point dir, Size size) : base(pos, dir, size) { }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawEllipse(Pens.Yellow, Pos.X, Pos.Y, Size.Width + 20, Size.Height + 10);
            Game.Buffer.Graphics.DrawEllipse(Pens.White, Pos.X + 10, Pos.Y + 5, Size.Width, Size.Height);
            //Выводим астероид в игру
            //Rectangle asteroidSize = new Rectangle(Pos.X, Pos.Y, 30, 30);
            //Game.Buffer.Graphics.DrawImage(asteroid, asteroidSize);
        }

        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            if (Pos.X < 0) Pos.X = Game.Width + Size.Width;
        }
    }
}
