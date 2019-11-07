using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoult_Karan
{

    public class method
    {
        //object of the random class 
        Random obj_instance = new Random();
        int winner = 0;

        //method to load the image 
        public String load() {
            return Properties.Resources.load.ToString();
        }
        // method to spin the image 
        public String Spin()
        {
            return Properties.Resources.spin.ToString();
        }
        // generate the reandom no to fire 
        public int fire()
        {
            winner= obj_instance.Next(1, 6);
            return winner;
        }

        //method to find the winner of  the game by using the random method of the class
        public int Win() {
            Random obj = new Random();
            if (winner == obj.Next(1, 6))
            {
                return 1;
            }
            else {
                return 0;
            }
        }

    }
}
