using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Snake
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
            ReadScore();
        }




        private void Snake_title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void ReadScore()
        {
            String line;
            String output = "";
            
            try
            {
                StreamReader sr = new StreamReader("..\\..\\score.txt");
                line = sr.ReadLine();
                if (line != null)
                {
                    string[] words = line.Split(',');
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        output += (words.Length - i).ToString() + ": " + words[i] + "\n";

                    }
                }
                score.Text = output;

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
        }

        public void SaveScore(int currentScore)
        {
            String line;
            String output = "";
            int[] topScore = new int[5];

            try
            {
                StreamReader sr = new StreamReader("..\\..\\score.txt");
                line = sr.ReadLine();
                sr.Close();
                if (line != null)
                {
                    string[] words = line.Split(',');
                    for (int i = 0; i < words.Length; i++)
                    {
                        topScore[i] = Int32.Parse(words[i]);
                    }
                    
                    if (topScore.Min() < currentScore)
                    {
                        int min = (topScore.ToList().IndexOf(topScore.Min()));
                        topScore[min] = currentScore;
                    }
                    Array.Sort(topScore);

                    for (int i = 0; i < words.Length; i++)
                    {
                        
                        output += topScore[i].ToString();
                        if(i < words.Length - 1)
                            output += ",";
                    }
                    
                }
                StreamWriter sw = new StreamWriter("..\\..\\score.txt");
                sw.WriteLine(output);

                sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
