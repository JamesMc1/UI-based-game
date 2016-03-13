using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.Properties;

namespace WindowsFormsApplication5
{
    
    public partial class Form1 : Form
    {
        Game myGame = new Game();
        int lifes = 3;
       
    public Form1()
        {
            InitializeComponent();
             myGame.RND = myGame.RandomNumberGenerator();
             string RNDstr =  myGame.RND.ToString();

        }
        private void PlayerSelect_Click(object sender, EventArgs e)
        {
            
            PictureBox fakeSender = (PictureBox) sender;
                                                                                    //Takes the tag from the picture boxes and converts them tostring.
            myGame.LikenessCount = myGame.CompareCodes(fakeSender.Tag.ToString());
            
       
            if (fakeSender.Tag.ToString() == myGame.codes[myGame.RND].ToString())
            {
              //  MessageBox.Show("working");
                //Form1.ActiveForm.BackgroundImage = Resources._2VDhalf__1_;
                //Thread.Sleep(1000);                                                    //<----Still unsure why this does not work but it was meant to be a 3 frame animation to show the vault door opening.
                //Form1.ActiveForm.BackgroundImage = Resources._3VDopen__2_;
                //Thread.Sleep(1000);
                Form1.ActiveForm.BackgroundImage = Resources._4VDopen__1_; //<-- Just changes Form1's background image.
                lbxScore.Items.Add("You won with "+ lblLifes.Text +" lifes left");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(); //<-- Audio Queue 
                player.Stream = Properties.Resources.VD_Sound_Effect;
                player.Play();
                
                
             




            }
            else
            {
                lblLikeness.Text = myGame.likeness1.ToString();
                //MessageBox.Show("No Luck " + myGame.RND.ToString() + " " + fakeSender.Tag);
                //lblLifes.Text = (lifes - lostLife).ToString();
                lifes--;
                lblLifes.Text = lifes.ToString();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(); //<-- Audio Queue 
                player.Stream = Properties.Resources.Access_denied;
                player.Play();
            }
            if (lblLifes.Text == "0")
            {
                MessageBox.Show("You failed");
                lblLikeness.Text = "0";
                Form1.ActiveForm.BackgroundImage = Resources._1VDhalf__2_;
                myGame.RND = myGame.RandomNumberGenerator();
                string RNDstr = myGame.RND.ToString();
                lblLifes.Text = "3";
                lifes = 3;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(); //<-- Audio Queue 
                player.Stream = Properties.Resources.Burglar_Alarm_Sound_Effect_1_mp3cut;
                player.Play();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }


        private void btnAgain_Click(object sender, EventArgs e)
        {
            lblLikeness.Text = "0";
            myGame.RND = myGame.RandomNumberGenerator();
            string RNDstr = myGame.RND.ToString();
            Form1.ActiveForm.BackgroundImage = Resources._1VDhalf__2_;
            lblLifes.Text = "3";
            lifes = 3;
            
        }

        private void btnClearlb_Click(object sender, EventArgs e)
        {
            lbxScore.Items.Clear();
        }
    }
}
