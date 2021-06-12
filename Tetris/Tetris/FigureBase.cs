namespace Tetris
{
    internal abstract class FigureBase
    {

        private static Direction Reverse(Direction dir)
        {
            switch (dir)
            {
                case Direction.LEFT:
                    return Direction.RIGHT;
                case Direction.RIGHT:
                    return Direction.LEFT;
                case Direction.DOWN:
                    return Direction.UP;
                case Direction.UP:
                    return Direction.DOWN;
            }
        }
    }
}