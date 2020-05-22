using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

//class DefRoom : Room {
//    public DefRoom() {
//        this.name = "Biblioteca";
//    }

//    public override void onEnter() {
//        base.onEnter();
//    }

//    public override bool onCommand(string command) {
//        switch (command) {
//            default:
//                return false;
//        }
//        return true;
//    }

//    public override void onExit() {
//        base.onExit();
//    }
//}

namespace TextStory {
    class CafeteriaRoom : Room {
        public CafeteriaRoom() {
            this.name = "Cafeteria";
        }

        public override void onEnter() {
            Print("You are standing in the school cafeteria,\nthere is a bunch of tables in the room and most people are already leaving for classes.\nYou can try the staircase or go through the schools biblioteca.");
        }

        public override bool onCommand(string command) {
            switch (command) {
                case "sit down":
                    Print("You sit down, but get bored, so you stand up again");
                    break;
                case "go through the biblioteca":
                case "go through biblioteca":
                case "go to the biblioteca":
                case "go to biblioteca":
                    Print("You go to the biblioteca");
                    gm.gotoRoom(2);
                    break;
                case "go up the staircase":
                case "go up staircase":
                case "go to the staircase":
                case "go to staircase":
                    Print("You go up the staircase");
                    gm.gotoRoom(1);
                    break;
                default:
                    return false;
            }
            return true;
        }

        public override void onExit() {
            base.onExit();
        }
    }

    class StaircaseRoom : Room {
        public StaircaseRoom() {
            this.name = "Staircase";
        }

        public override void onEnter() {
            Print("The stairs that leads to an outside area. You know you do not have to leave the building, right?");
        }

        public override bool onCommand(string command) {
            switch (command) {
                case "go back":
                case "go to cafeteria":
                case "go to the cafeteria":
                case "go back to cafeteria":
                case "go back to the cafeteria":
                case "return to cafeteria":
                case "return to the cafeteria":
                case "go back inside":
                    Print("You go back to the Cafeteria");
                    gm.gotoRoom(0);
                    break;
                case "go outside":
                    Print("You go outside, but it is cold, so you return to the staircase");
                    break;
                case "jump off staircase":
                case "jump off the staircase":
                case "make a suicide":
                case "suicide":
                case "do suicide":
                    Print("You jump of the staircase and kill yourself... Dumbass!");
                    Thread.Sleep(2000);
                    gm.die();
                    break;
                default:
                    return false;
            }
            return true;
        }

        public override void onExit() {
            base.onExit();
        }
    }

    class BibliotecaRoom : Room {
        public BibliotecaRoom() {
            this.name = "Biblioteca";
        }

        public override void onEnter() {
            Print("The library is quite large, but you can see towards the other end and there is a sign that says, “Hallway G”");
        }

        public override bool onCommand(string command) {
            switch (command) {
                case "go back":
                case "go to cafeteria":
                case "go to the cafeteria":
                case "go back to cafeteria":
                case "go back to the cafeteria":
                case "return to cafeteria":
                case "return to the cafeteria":
                    Print("You go back to the Cafeteria");
                    gm.gotoRoom(0);
                    break;
                case "read a book":
                case "read book":
                    Print("Naarh... That is boring!");
                    break;
                case "go to sign":
                case "go to the sign":
                case "go to hallway":
                case "go to the hallway":
                case "go to hallway g":
                    Print("You go to the sign that says “Hallway G”");
                    gm.gotoRoom(3);
                    break;
                default:
                    return false;
            }
            return true;
        }

        public override void onExit() {
            base.onExit();
        }
    }

    class HallwayGRoom : Room {
        public HallwayGRoom() {
            this.name = "Hallway G";
        }

        public override void onEnter() {
            Print("You look down the hallway, there is another sign a few meters down that says, “Hallway F”");
        }

        public override bool onCommand(string command) {
            switch (command) {
                case "go back":
                case "go to biblioteca":
                case "go to the biblioteca":
                case "go back to biblioteca":
                case "go back to the biblioteca":
                case "return to biblioteca":
                case "return to the biblioteca":
                    Print("You go back to the Biblioteca");
                    gm.gotoRoom(2);
                    break;
                case "go to sign":
                case "go to the sign":
                case "go to hallway":
                case "go to the hallway":
                case "go to next sign":
                case "go to the next sign":
                case "go to next hallway":
                case "go to the next hallway":
                case "go to hallway f":
                    Print("You go to the sign that says “Hallway F”");
                    gm.gotoRoom(4);
                    break;
                default:
                    return false;
            }
            return true;
        }

        public override void onExit() {
            base.onExit();
        }
    }

    class HallwayFRoom : Room {
        public HallwayFRoom() {
            this.name = "Hallway F";
        }

        public override void onEnter() {
            Print("As you look down the hallway you see a bunch of doors. One of them says, “F28”");
        }

        public override bool onCommand(string command) {
            switch (command) {
                case "go back":
                case "go to hallway g":
                case "go back to hallway g":
                case "return to hallway g":
                    Print("You go back to hallway g");
                    gm.gotoRoom(3);
                    break;
                case "go to door f28":
                case "go to the door f28":
                case "go to f28":
                case "open f28":
                case "open door f28":
                case "open the door f28":
                case "open door to f28":
                case "open the door to f28":
                    Print("You open the door that says “F28”");
                    gm.gotoRoom(5);
                    break;
                case var s0 when new Regex(@"go to door f[0-9]+").IsMatch(s0):
                case var s1 when new Regex(@"go to the door f[0-9]+").IsMatch(s1):
                case var s2 when new Regex(@"go to f[0-9]+").IsMatch(s2):
                case var s3 when new Regex(@"open f[0-9]+").IsMatch(s3):
                case var s4 when new Regex(@"open door f[0-9]+").IsMatch(s4):
                case var s5 when new Regex(@"open the door f[0-9]+").IsMatch(s5):
                case var s6 when new Regex(@"open door to f[0-9]+").IsMatch(s6):
                case var s7 when new Regex(@"open the door to f[0-9]+").IsMatch(s7):
                    checkDoor(command);
                    break;
                default:
                    return false;
            }
            return true;
        }

        void checkDoor(string str) {
            int num = int.Parse(new Regex(@"[0-9]+").Matches(str)[0].ToString());
            switch (num) {
                case 1:
                case 2:
                case 4:
                case 5:
                case 7:
                case 16:
                case 20:
                case 22:
                case 24:
                    Print("You open the door. A lot of people are looking at you, and you die of embarrassment");
                    Print("You had one job!");
                    gm.die();
                    break;
                default:
                    Print("You do not see that door anywhere");
                    break;
            }
        }

        public override void onExit() {
            base.onExit();
        }
    }

    class F28Room : Room {
        public F28Room() {
            this.name = "F28";
        }

        public override void onEnter() {
            Print("You reached Programming class, congratulations buddy!");
            gm.win();
        }
    }
}
