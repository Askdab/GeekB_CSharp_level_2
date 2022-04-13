using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lesson1HW_Asteroids
{
    class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        public static BaseObject[] _objs;
        public static BaseObject[] _galaxy;

        public static void Load()
        {
            _objs = new BaseObject[40];
            for (int i = 0; i < _objs.Length / 2; i++)
            {
                _objs[i] = new BaseObject(new Point(500, i * 20), new Point(-i-1, -i), new Size(10, 10));
            }
            for (int i = _objs.Length / 2; i < _objs.Length; i++)
            { 
                _objs[i] = new Star(new Point(600, i * 10), new Point(-i, 0), new Size(5, 5));
            }

            _galaxy = new BaseObject[10];
            for (int i = 0; i < _galaxy.Length; i++)
            {
                _galaxy[i] = new Galaxy(new Point(400, (i + 2) * 40), new Point(-i - 35, -i), new Size(1, 1));
            }
        }

        // Свойства
        // Ширина и высота игрового поля
        public static int Width { get; set; }
        public static int Height { get; set; }

        //Статический конструктор по умолчанию
        static Game()
        {

        }

        public static void Init (Form form)
        {
            // Графическое устройство для вывода графики
            Graphics g;

            // Предоставляет доступ к главному буферу графического контекста для текущего приложения
            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();

            // Создаем объект (поверхность рисования) и связываем его с формой
            // Запоминаем размеры формы
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;

            // Связываем буфер в памяти с графическим объектом, чтобы рисовать в  буфере
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));

            Load();

            Timer timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_tick;
        }

        //Обработчик таймера
        public static void Timer_tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }

        public static void Draw()
        {
            // Проверяем вывод графики
            Buffer.Graphics.Clear(Color.Black);
            //Buffer.Graphics.DrawRectangle(Pens.White, new Rectangle(100, 100, 200, 200));
            //Buffer.Graphics.FillEllipse(Brushes.Wheat, new Rectangle(100, 100, 200, 200));
            //Buffer.Render();

            Buffer.Graphics.Clear(Color.Black);
            foreach (BaseObject obj in _objs) { obj.Draw(); }
            foreach (BaseObject obj_1 in _galaxy) { obj_1.Draw(); }

            Buffer.Render();
        }

        //Метод для изменения состояния объектов
        public static void Update()
        {
            foreach (BaseObject obj in _objs) { obj.Update(); }
            foreach (BaseObject obj_1 in _galaxy) { obj_1.Update(); }
        }
    }
}
