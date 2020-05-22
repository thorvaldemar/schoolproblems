using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextStory {
    class GameManager {
        Room[] rooms = {
            new CafeteriaRoom(),
            new StaircaseRoom(),
            new BibliotecaRoom(),
            new HallwayGRoom(),
            new HallwayFRoom(),
            new F28Room()
        };

        Room currentRoom = null;

        bool running = true;

        public GameManager() {
            foreach (Room r in rooms) {
                r.gm = this;
            }

            if (rooms.Length <= 0) {
                Console.WriteLine("<Error> No rooms are assigned!");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            //Console.WriteLine("----------------School Problems----------------");

            // TODO: Print intro
            //Print("Welcome to ...");
            Print("You can type 'exit game' at any time, to quit and close the game.");

            reset();

            while (running) {
                Console.Write(Program.protocol);
                string input = Console.ReadLine().ToLower();

                if (input == "exit game") {
                    running = false;
                    Console.Write("\n\n\nGoodbye");
                    for (int i = 0; i < 10; i++) {
                        Console.Write(".");
                        Thread.Sleep(300);
                    }
                    Console.Write("\rGood luck! >:)              ");
                    Thread.Sleep(300);
                } else if (input == "even dead i'm the hero" || input == "edith") {
                    EasterEgg.Play();
                    running = false;
                } else {
                    if (!currentRoom.onCommand(input)) {
                        Print(" > Unknown command");
                    }
                }
            }
        }

        public void reset() {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();
            Print("You are a new student on current school. Therefore, you have some trouble finding the different classrooms.\nAfter your lunch break you need to locate Room F28,\nbut you do not know how to get there.");

            gotoRoom(0);
        }

        public void die() {
            Console.BackgroundColor = ConsoleColor.Red;
            Thread.Sleep(200);
            reset();
        }

        public void win() {
            running = false;
            Print("You have won the game!");
            Console.Write("Press any key to end the game...");
            Console.ReadKey();
        }

        public void gotoRoom(int index) {
            if (index < rooms.Length && index >= 0) {
                if (currentRoom != null) currentRoom.onExit();
                currentRoom = rooms[index];
                currentRoom.onEnter();
            } else {
                Console.WriteLine("<Error> rooms array out of bounds");
            }
        }

        public static void Print(object obj) {
            string str = obj.ToString();
            for (int i = 0; i < str.Length; i++) {
                Console.Write(str[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }
    }
}
