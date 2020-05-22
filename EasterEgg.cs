using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextStory {
    class EasterEgg {
        public static void Play() {
            string output = "Tony Stark";

            string randRange = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int timePerLetter = 100;

            Random rand = new Random();
            string center = Center(output);

            Console.Clear();
            for (int i = 0; i < (Console.WindowHeight / 2) - 1; i++) {
                Console.WriteLine();
            }

            for (int i = 1; i <= output.Length; i++) {
                for (int t = 0; t < timePerLetter; t++) {
                    string rn = "";
                    for (int n = 0; n < i; n++) {
                        rn += output[n] != ' ' ? randRange[rand.Next(0, randRange.Length-1)].ToString() : " ";
                    }
                    Console.Write("\r" + center + rn);
                    Thread.Sleep(10);
                }
            }

            for (int i = 0; i <= output.Length; i++) {
                for (int t = 0; t < timePerLetter; t++) {
                    string rn = "";
                    for (int n = 0; n < output.Length; n++) {
                        if (n <= i) {
                            rn += output[n];
                        } else {
                            rn += output[n] != ' ' ? randRange[rand.Next(0, randRange.Length - 1)].ToString() : " ";
                        }
                    }
                    Console.Write("\r" + center + rn);
                    Thread.Sleep(10);
                }
            }
        }

        public static string Center(string str) {
            string rs = "";
            for (int i = 0; i < (Console.WindowWidth / 2) - (str.Length / 2); i++) {
                rs += " ";
            }
            return rs;
        }
    }
}
