using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Snake
{
    [TestFixture]
    class UnitTesting
    {
        [TestCase]
        public void NoLifeTest()
        {
            int life = 0;
            int life2 = 2;
            Snake snake = new Snake();
            bool noLife = snake.no_life(life);
            bool noLife2 = snake.no_life(life2);
            Assert.IsTrue(noLife);
            Assert.IsFalse(noLife2);
        }

        [TestCase]
        public void GenerateRandomColorTest()
        {
            Snake snake = new Snake();
            Color color = snake.generateRandomColor();
            if (color == Color.Green | color == Color.Red | color == Color.Blue) {
                Assert.IsTrue( true );
            }
        }

        [TestCase]
        public void FoodCollisionTest()
        {
            int snakeXFalse = 0;
            int snakeYFalse = 0;
            int snakeXTrue = 50;
            int snakeYTrue = 25;

            Snake snake = new Snake();
            snake.lblFood.Location = new Point(50, 25);

            Assert.IsTrue(snake.collisionFood(snakeXTrue, snakeYTrue));
            Assert.IsFalse(snake.collisionFood(snakeXFalse, snakeYFalse));
        }
    }
}
