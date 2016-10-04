using System;

namespace ConsoleApplication
{
    public class Program
    {
        // //Return A Random Integer Array
        // public static int[] randomArr() {
        //     int Min = 5;
        //     int Max = 25;
        //     int[] randArr = new int[10]; 
        //     Random randNum = new Random();
        //     for (int i = 0; i < randArr.Length; i++){
        //         randArr[i] = randNum.Next(Min, Max);
        //         Console.WriteLine(randArr[i]);
        //     }
        //     return randArr;
        // }

        //Coin Toss Game
        // public static string coinToss(int num){
        //     int headToss = 0;
        //     int totalToss = 0;
        //     Random rand = new Random();
        //     for(int i = 1; i < num; i++) {
        //         Console.WriteLine("Tossing A Coin...");
        //         int result = rand.Next(1,3);
        //         if(result == 1) {
        //             totalToss += 1;
        //             Console.WriteLine("You Got Tails!");
        //         }
        //         if(result == 2) {
        //             headToss += 1;
        //             totalToss += 1;
        //             Console.WriteLine("You Got Heads!");
        //         }
        //     }
        //     var ratio = ((double)headToss / totalToss);
            
        //     Console.WriteLine("Total # of tosses: " + totalToss + " - # of heads tosses: " + headToss + " - Ratio: " + ratio);
        //     return("coin toss done");
        // }

        //Shuffling An Array of Names
        //Return Only Names Longer Than 6 Chars
        public static void Names() {
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string[] shuffled = new string[5];
            Random random = new Random();
            for(int i = 0; i < names.Length; i++) {
                bool flag = true;
                while(flag) {
                    int idx = random.Next(0,5);
                    if(shuffled[idx] == null){
                        shuffled[idx] = names[i];
                        flag = false;
                    }
                }
            }
            for(int k = 0; k < shuffled.Length; k++) {
                if(shuffled[k].Length < 6) {
                    shuffled[k] = null;
                }
                Console.WriteLine(shuffled[k]);
            }
        }

        public static void Main(string[] args)
        {
            // randomArr();
            // coinToss(6);
            Names();
        }
    }
}
