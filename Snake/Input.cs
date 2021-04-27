using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        //Load all available keyboard btn
        public static Hashtable keyTable = new Hashtable();
        
        //check if a button is pressed
        public static bool keyIsPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool) keyTable[key];
        }
        
        //look if a keyboard button is pressed
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
