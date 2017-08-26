using InputManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YFBot
{
    class Strategy
    {
        public async Task<bool> attackLogic(bool fwd)
        {
            //Keyboard.KeyDown(Keys.D1);
            if (fwd)
            {
                Keyboard.KeyUp(Keys.S);
                Keyboard.KeyDown(Keys.W);
            }
            else
            {
                Keyboard.KeyUp(Keys.W);
                Keyboard.KeyDown(Keys.S);
            }

            await Task.Delay(3000);
            //Keyboard.KeyUp(Keys.D1);
            await Task.Delay(1000);
            return !fwd;
        }

        public async Task<bool> defendLogic(bool rgt)
        {
            Keyboard.KeyDown(Keys.D1);
            if (rgt)
            {
                Keyboard.KeyUp(Keys.S);
                Keyboard.KeyUp(Keys.A);
                Keyboard.KeyDown(Keys.W);
                Keyboard.KeyDown(Keys.D);
            }
            else
            {
                Keyboard.KeyUp(Keys.W);
                Keyboard.KeyUp(Keys.D);
                Keyboard.KeyDown(Keys.S);
                Keyboard.KeyDown(Keys.A);
            }

            await Task.Delay(3000);
            Keyboard.KeyUp(Keys.D1);
            await Task.Delay(1000);
            return !rgt;
        }
    }
}
