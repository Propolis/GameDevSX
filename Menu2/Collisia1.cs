using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Menu2
{
    internal class Collisia
    {
        public Canvas _Canvas;
        private Rectangle _Object;
        private float _SpeedX;
        private float _SpeedY;

        public Collisia(Canvas Canvas, Rectangle object1, float SpeedX, float SpeedY)
        {
            _Canvas = Canvas;
            _Object = object1;
            _SpeedX = SpeedX;
            _SpeedY = SpeedY;
        }

        public void Collide(string Dir)
        {
            foreach (var x in _Canvas.Children.OfType<Rectangle>())
            {
                if ((string)x.Tag == "Collide")
                {
                    Rect PlayerHB = new Rect(Canvas.GetLeft(_Object), Canvas.GetTop(_Object), _Object.Width, _Object.Height);
                    Rect ToCollide = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if (PlayerHB.IntersectsWith(ToCollide))
                    {
                        if (Dir == "x")
                        {
                            Canvas.SetLeft(_Object, Canvas.GetLeft(_Object) - _SpeedX);
                            _SpeedX = 0;
                        }
                        else
                        {
                            Canvas.SetTop(_Object, Canvas.GetTop(_Object) + _SpeedY);
                            _SpeedY = 0;
                        }
                    }
                }
            }
        }
    }
}
