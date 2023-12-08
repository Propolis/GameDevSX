//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Menu2
//{
//    internal class Collisia
//    {

//        private void Collide(string Dir)
//        {
//            foreach (var x in GameScreen.Children.OfType<Rectangle>())
//            {
//                if ((string)x.Tag == "Collide")
//                {
//                    Rect PlayerHB = new Rect(Canvas.GetLeft(Character), Canvas.GetTop(Character), Character.Width, Character.Height);
//                    Rect ToCollide = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

//                    if (PlayerHB.IntersectsWith(ToCollide))
//                    {
//                        if (Dir == "x")
//                        {
//                            Canvas.SetLeft(Character, Canvas.GetLeft(Character) - SpeedX);
//                            SpeedX = 0;
//                        }
//                        else
//                        {
//                            Canvas.SetTop(Character, Canvas.GetTop(Character) + SpeedY);
//                            SpeedY = 0;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
