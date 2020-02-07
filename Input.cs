using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Thing
{
    class Input
    {
        //cool data structure thing for storing key values
        private static Hashtable keyTable = new Hashtable();

        //checks if a registered key has been pressed
        public static bool keyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        //changes the state to positive or negative for a key
        public static void changeState(Keys k, bool state)
        {
            keyTable[k] = state;
        }


    }
}
