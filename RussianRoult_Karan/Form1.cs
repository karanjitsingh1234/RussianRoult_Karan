using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoult_Karan
{
    public partial class Form1 : Form
    {
        //instance object of the class that have all the method to find winner or looser 
        method obj_instance = new method();
        // global variable to perform the task
        int count_Triger = 0,sound=0,chance=0;
        int fire = 0,Count_fire=0;
        public Form1()
        {
            InitializeComponent();
            //get the random no from method class to fire the bullet 
            sound = obj_instance.fire();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // when we click on the fire buton code is used to count the trigger 
            count_Triger++;
            // pass the image location using resource folder 
            pictureBox1.Image = Properties.Resources.gun;
            // when the triiiger and sound value is equal then gererate the sound of bullet
            if (count_Triger ==sound )
            {
                System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Properties.Resources.Gun_Luger);
                obj.Play();
                // after that find the winner using win method of the another c# class if the condition is true then the winner message will generate 
                if (obj_instance.Win() == 1)
                {
                    pictureBox1.Image = Properties.Resources.shhot;

                    label1.Text = "Congrats you win the game click here to play again ";
                    button4.Enabled = false;
                    
                }
                else {
                    //otherwise the looser message will be show 
                    label1.Text = "Sorry you Lose the game click here to play again";
                }


            }
            else {
                //if the triiger not equal to the sound then the empty trigger sound will generate 
                pictureBox1.Image = Properties.Resources.gun;
                System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Properties.Resources.Gun_Cock);
                obj.Play();
            }
            // when the six trigger is used then the game over message will display 
            if (count_Triger==6) {
                label1.Text = "Game is Over Now Click  Here to Get another Chance ";
                button4.Enabled = false;
            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //this code is used to call the spin method of the class 
            String Spin= obj_instance.Spin();
            // load the image of the spin
            pictureBox1.Image = Properties.Resources.spin;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //update the label to generate the required message
            label1.Text = "Welcome to the fire Game you have one bullet to shoot";
            button2.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fire++;
            if (fire == sound)
            {
                System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Properties.Resources.Gun_Luger);
                obj.Play();
                Count_fire++;
                fire = 0;
                MessageBox.Show("Great SHoot ");
            }
            else
            {
                //if the triiger not equal to the sound then the empty trigger sound will generate 
                pictureBox1.Image = Properties.Resources.gun;
                System.Media.SoundPlayer obj = new System.Media.SoundPlayer(Properties.Resources.Gun_Cock);
                obj.Play();
            }
            if (Count_fire==2) {
                button5.Enabled = false;
                MessageBox.Show("chances are over ");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // label to perform the required meessage and perform the suitable task 
            count_Triger = 0;
            chance++;
            fire = 0;
            Count_fire = 0;
            label1.Text = "Chances are reloaded";
            sound = obj_instance.fire();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ///   the load message is used to load the 
            String img = obj_instance.load();

            pictureBox1.Image = Properties.Resources.load;
            button2.Enabled =false;
            button3.Enabled = true;

        }
    }
}
