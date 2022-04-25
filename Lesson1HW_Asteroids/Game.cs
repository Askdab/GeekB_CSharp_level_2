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
        public static Galaxy[] _galaxy;
        private static Bullet _bullet;
        private static Asteroid[] _asteroids;
        private static Ship _ship = new Ship(new Point(10, 400), new Point(5, 5), new Size(10, 10));

        private static Timer _timer = new Timer();
        public static Random Rnd = new Random();

        public static void Load()
        {
            _objs = new BaseObject[30];
            //_bullet = new Bullet(new Point(0, 200), new Point(5, 0), new Size(4, 1));
            _asteroids = new Asteroid[30];

            var rnd = new Random();

            for (var i = 0; i < _objs.Length; i++)
            {
                int r = rnd.Next(5, 50);
                _objs[i] = new Star(new Point(1000, rnd.Next(0, Game.Height)), new Point(-r, r), new Size(3, 3));
            }

            for (var i = 0; i < _asteroids.Length; i++)
            {
                int r = rnd.Next(5, 50);
                _asteroids[i] = new Asteroid(new Point(1000, rnd.Next(0, Game.Height)), new Point(-r/5, r), new Size(r, r));
            }

            _galaxy = new Galaxy[8];
            for (int i = 0; i < _galaxy.Length; i++)
            {
                int r = rnd.Next(5, 50);
                _galaxy[i] = new Galaxy(new Point(1000, rnd.Next(0, Game.Height)), new Point(-r/3, r/2), new Size(1, 1));
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

            form.KeyDown += Form_KeyDown;
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

            //Timer timer = new Timer { Interval = 100 };
            _timer.Start();
            _timer.Tick += Timer_tick;

            Ship.MessageDie += Finish;
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
            //Buffer.Graphics.Clear(Color.Black);
            //Buffer.Graphics.DrawRectangle(Pens.White, new Rectangle(100, 100, 200, 200));
            //Buffer.Graphics.FillEllipse(Brushes.Wheat, new Rectangle(100, 100, 200, 200));
            //Buffer.Render();

            Buffer.Graphics.Clear(Color.Black);
            foreach (BaseObject obj in _objs) { obj.Draw(); }
            foreach (Galaxy gal in _galaxy) { gal.Draw(); }
            foreach (Asteroid aster in _asteroids) { aster?.Draw(); }
            _bullet?.Draw();
            _ship?.Draw();
            if (_ship != null) Buffer.Graphics.DrawString("Energy:" + _ship.Energy, SystemFonts.DefaultFont, Brushes.White, 0, 0);

            Buffer.Render();
        }

        //Метод для изменения состояния объектов
        public static void Update()
        {
            foreach (BaseObject obj in _objs) { obj.Update(); }
            foreach (Galaxy gal in _galaxy) { gal.Update(); }
            for (var i = 0; i < _asteroids.Length; i++)
            {
                if (_asteroids[i] == null) continue;
                _asteroids[i].Update();
                if (_bullet != null && _bullet.Collision(_asteroids[i]))
                {
                    System.Media.SystemSounds.Hand.Play();
                    _asteroids[i] = null;
                    _bullet = null;
                    continue;
                }
                if (!_ship.Collision(_asteroids[i])) continue;
                var rnd = new Random();
                _ship?.EnergyLow(rnd.Next(1, 10));
                System.Media.SystemSounds.Asterisk.Play();
                if (_ship.Energy <= 0) _ship?.Die();
            }

            _bullet?.Update();
        }

        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) _bullet = new Bullet(new Point(_ship.Rect.X + 10, _ship.Rect.Y + 4), new Point(4, 0), new Size(4, 1));
            if (e.KeyCode == Keys.Up) _ship.Up();
            if (e.KeyCode == Keys.Down) _ship.Down();
        }

        public static void Finish()
        {
            _timer.Stop();
            Buffer.Graphics.DrawString("Пизда", new Font(FontFamily.GenericSansSerif, 60, FontStyle.Underline), Brushes.White, 200, 100);
            Buffer.Render();
        }
    }
}
