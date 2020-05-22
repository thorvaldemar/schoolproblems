using System;
using System.Collections.Generic;
using System.Text;

namespace TextStory {
    abstract class Room {
        public string name { get; set; }
        public GameManager gm;

        public virtual void onEnter() { Print("You've entered the room '" + name + "'"); }
        public virtual bool onCommand(string command) { return false; }
        public virtual void onExit() { /*Print("You've exited the room '" + name + "'");*/ }

        public void Print(object str) {
            GameManager.Print(str);
        }
    }
}
