using InputManager;
using System.Windows.Forms;

namespace YFBot.Movement {
    class Move {

        public Move() { }

        public void Go(Direction direction) {

            switch (direction) {
                /// <Summary> Перемещение по осям
                /// 
                /// </Summary>
                case Direction.Forward:
                    Keyboard.KeyUp(Keys.S);
                    Keyboard.KeyDown(Keys.W);
                    break;
                case Direction.Backward:
                    Keyboard.KeyUp(Keys.W);
                    Keyboard.KeyDown(Keys.S);
                    break;
                case Direction.Right:
                    Keyboard.KeyUp(Keys.A);
                    Keyboard.KeyDown(Keys.D);
                    break;
                case Direction.Left:
                    Keyboard.KeyUp(Keys.D);
                    Keyboard.KeyDown(Keys.A);
                    break;

                ///<summary> Остановка
                /// 
                ///</summary>
                case Direction.Stop:
                    Keyboard.KeyUp(Keys.W);
                    Keyboard.KeyUp(Keys.S);
                    Keyboard.KeyUp(Keys.D);
                    Keyboard.KeyUp(Keys.A);
                    break;                
            }
        }
    }
}
