using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Menu2
{
    internal class Player
    {

        private bool _UpKeyPressed, _DownKeyPressed, _LeftKeyPressed, _RightKeyPressed;
        private float _SpeedX, _SpeedY, _Friction, _Speed;
        public Player(float SpeedY = 0, float SpeedX = 0, bool UpKeyPressed = false, bool DownKeyPressed = false, bool LeftKeyPressed = false, bool RightKeyPressed = false, float Friction = 0.77f, float Speed = 2f)
        {
            _Speed = Speed;
            _SpeedY = SpeedY;
            _SpeedX = SpeedX;
            _Friction = Friction;
            _UpKeyPressed = UpKeyPressed;
            _DownKeyPressed = DownKeyPressed;
            _LeftKeyPressed = LeftKeyPressed;
            _RightKeyPressed = RightKeyPressed;
        }

        public float X
        {
            get { return _SpeedX; }
            set { _SpeedX = value; }
        }

        public float Y
        {
            get { return _SpeedY; }
            set { _SpeedY = value; }
        }

        public void Move()
        {
            if (_UpKeyPressed)
            {
                _SpeedY += _Speed;
            }
            if (_RightKeyPressed)
            {   
                _SpeedX += _Speed;
            }
            if (_LeftKeyPressed)
            {
                _SpeedX -= _Speed;
            }
            if (_DownKeyPressed)
            {
                _SpeedY -= _Speed;
            }
            _SpeedX = _SpeedX * _Friction;
            _SpeedY = _SpeedY * _Friction;

            //Canvas.SetLeft(_Character, Canvas.GetLeft(_Character) + _SpeedX);
            //Collide("x");
            //Canvas.SetTop(_Character, Canvas.GetTop(_Character) - _SpeedY);
            //Collide("y");
        }
    }
}
