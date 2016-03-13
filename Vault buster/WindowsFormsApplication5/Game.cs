using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{

    class Game

    {

        public int RND;

        public int[] codes = {39835, 72835, 49162, 29585, 12653, 87350, 74783}; //Int array
     

        public int RandomNumberGenerator()
        {

            Random myRandom = new Random();

            return myRandom.Next(1, 7);
        }

        public int likeness1;
        public int LikenessCount = 0;
   
        public int CompareCodes( string personselect)
        {
            string RNDNumber = codes[RND].ToString();
                 
            char[] rndnumber = RNDNumber.ToCharArray();  //take the randoms elected one and convert it to a char array.
            char[] perNum = personselect.ToCharArray();  //takes the player selected number and also gets converted to a char array.         
            likeness1 = 1;

         
               


            foreach (char RndNum in rndnumber)             //Compares every number in the two char arrays and returns an increment which gives us the likeliness.
            {
                foreach (char Pnum in perNum) 

                    if (RndNum == Pnum)
                    {
                 
                        return likeness1 ++;
                    }
                    //else
                    //{
                    //    return likeness0;
                    //}
            }


            return 0;










            //Ignore the following.

            //for (int j = 0; j < perNum.Length; j++) //Pulls playerselected num
            //{

            //    for (int k = 0; k < rndnumber.Length; k++) //Pulls rndNum
            //    {


            //        if (perNum[j] == rndnumber[k]) //Compare two nums         

            //        {
            //            return likeness1;
            //        }

            //        else

            //        {
            //            return likeness0;
            //        }                   
                }
            }          
        }       
    

        

    










    

