using NUnit.Framework;
using System;
using System.IO;
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
            if (color == Color.Green | color == Color.Red | color == Color.Blue)
            {
                Assert.IsTrue(true);
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

        [TestCase]
        public void ScoreBoard()
        {
            ScoreBoard sc = new ScoreBoard();
            sc.SaveScore(99);
            sc.SaveScore(97);
            sc.SaveScore(100);
            string[] words = new string[5];
            try
            {
                String line;
               
                StreamReader sr = new StreamReader("..\\..\\score.txt");
                line = sr.ReadLine();
                words = line.Split(',');
                
                sr.Close();

            }
            catch (Exception e)
            {
                 Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                 Console.WriteLine("Executing finally block.");
            }
            Assert.AreEqual(words[0], "100");
            Assert.AreEqual(words[2], "97");
        }
    }
}
