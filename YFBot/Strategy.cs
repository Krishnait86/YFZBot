﻿using InputManager;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using YFBot.Movement;


namespace YFBot
{
    class Strategy
    {
        Move move;

        public Strategy() {
            move = new Move();
        }

        public async Task<bool> attackLogic(bool fwd)
        {
            //Keyboard.KeyDown(Keys.D1);
            if (fwd)
            {
                // Keyboard.KeyUp(Keys.S);
                // Keyboard.KeyDown(Keys.W);
                move.Go(Direction.Forward);
            }
            else
            {
                // Keyboard.KeyUp(Keys.W);
                // Keyboard.KeyDown(Keys.S);
                move.Go(Direction.Backward);
            }

            await Task.Delay(3000);
            //Keyboard.KeyUp(Keys.D1);
            await Task.Delay(1000);
            return !fwd;
        }

        public async Task<bool> defendLogic()
        {
            // Keyboard.KeyUp(Keys.A);
            // Keyboard.KeyUp(Keys.D);
            // Keyboard.KeyUp(Keys.S);
            // Keyboard.KeyDown(Keys.W);
            move.Go(Direction.Stop);
            move.Go(Direction.Forward);


            await Task.Delay(new Random().Next(3000));
            //Keyboard.KeyDown(Keys.D1);

            // вперед или назад (вперед) до 3 секунд
            if (new Random().Next(13) > 7)
            {
                // Keyboard.KeyUp(Keys.A);
                // Keyboard.KeyUp(Keys.D);
                // Keyboard.KeyUp(Keys.S);
                // Keyboard.KeyDown(Keys.W);
                move.Go(Direction.Stop);
                move.Go(Direction.Forward);

                await Task.Delay(new Random().Next(3000));

                // вперед - вправо или влево (вправо) до 2,5 секунд
                if (new Random().Next(12) > 6)
                {
                    // Keyboard.KeyUp(Keys.A);
                    // Keyboard.KeyDown(Keys.D);
                    move.Go(Direction.Right);
                }
                else
                {
                    // Keyboard.KeyUp(Keys.D);
                    // Keyboard.KeyDown(Keys.A);
                    move.Go(Direction.Left);
                }
                await Task.Delay(new Random().Next(2500));

                // Keyboard.KeyUp(Keys.A);
                // Keyboard.KeyUp(Keys.D);
                // Keyboard.KeyUp(Keys.S);
                // Keyboard.KeyDown(Keys.W);
                move.Go(Direction.Stop);
                move.Go(Direction.Forward);

                await Task.Delay(new Random().Next(2000));
            }
            else
            {
                // Keyboard.KeyUp(Keys.A);
                // Keyboard.KeyUp(Keys.D);
                // Keyboard.KeyUp(Keys.W);
                // Keyboard.KeyDown(Keys.S);
                move.Go(Direction.Stop);
                move.Go(Direction.Backward);

                if (new Random().Next(12) > 6)
                {
                    // Keyboard.KeyUp(Keys.A);
                    // Keyboard.KeyDown(Keys.D);
                    move.Go(Direction.Right);
                }
                else
                {
                    // Keyboard.KeyUp(Keys.D);
                    // Keyboard.KeyDown(Keys.A);
                    move.Go(Direction.Left);
                }
            }

            await Task.Delay(new Random().Next(4000));
            //Keyboard.KeyUp(Keys.D1);
            //await Task.Delay(1000);
            return true;
        }
    }
}
