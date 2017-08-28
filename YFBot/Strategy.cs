using System;
using System.Threading.Tasks;
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
            if (fwd)
            {
                move.Go(Direction.Forward);
            }
            else
            {
                move.Go(Direction.Backward);
            }

            await Task.Delay(3000);
            await Task.Delay(1000);
            return !fwd;
        }

        public async Task<bool> defendLogic()
        {
            move.Go(Direction.Stop);
            move.Go(Direction.Forward);

            await Task.Delay(new Random().Next(3000));

            // вперед или назад (вперед если рандом > 7) до 3 секунд
            if (new Random().Next(9) > 7)
            {
                move.Go(Direction.Stop);
                move.Go(Direction.Forward);

                await Task.Delay(new Random().Next(3000));

                // вперед - вправо или влево (вправо если рандом больше 7) до 2,4 секунд
                if (new Random().Next(12) > 7)
                {
                    move.Go(Direction.Right);
                }
                else
                {
                    move.Go(Direction.Left);
                }
                await Task.Delay(new Random().Next(2400));

                move.Go(Direction.Stop);
                move.Go(Direction.Forward);

                await Task.Delay(new Random().Next(2000));
            }
            else
            {
                move.Go(Direction.Stop);
                move.Go(Direction.Backward);

                if (new Random().Next(12) > 6)
                {
                    move.Go(Direction.Right);
                }
                else
                {
                    move.Go(Direction.Left);
                }
            }

            await Task.Delay(new Random().Next(4000));
            return true;
        }
    }
}
