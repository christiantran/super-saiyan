using System.Collections.Generic;
using System;

namespace SuperSaiyan.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        public List<Room> Rooms = new List<Room>();
        public bool Playing;

        public void Play()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("***** IN REMEMBRANCE OF SONNY AND HIS LOVE FOR DRAGON BALL Z ***** \n");
            Console.WriteLine("This game is your typical 'choose your own adventure game' where you can decide your own path. You will be fighting side by side with characters from Dragon Ball Z to help save the Earth. Good Luck! \n");
            Console.WriteLine("Press 'enter' for game instructions \n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How to Play: \n");
            Console.WriteLine("In this fight to save the Earth you will be given multiple options that you must choose from. Once you have made a decision you will type the text that corresponds with your choice. \n");
            Console.WriteLine("If you are ever unsure about what to do next just type in one of these words at anytime:\n");
            Console.WriteLine("*    'reset' allows you to reset the game and start at the beginning");
            Console.WriteLine("*    'repeat' will repeat the instructions");
            Console.WriteLine("*    'quit' allows you to quit the game at anytime");
            Console.WriteLine("*    'help' will show you this list again \n");
            Console.WriteLine("Press 'enter' to play");
            Console.ReadLine();

            // while (Playing)
            // {
            //     UserCommand();
            // }

        }

        public void Setup()
        {
            Room gotenRoom = new Room("The Forest", "You are hiking through the beautiful forests surrounding your home when all of a sudden you hear your name. 'Sonny? Is that you Sonny?! We need your help! My name is Goten and my dad Goku sent me to find somebody to help him defeat the horrible villains Piccolo and Vegeta! They are on the otherside of these trees in the open meadow. Go! Go now! The Earth is depending on you!' Press 'enter' to accept this responsibility");
            Rooms.Add(gotenRoom);

            Room gokuRoom = new Room("The Meadow", "description");
            Rooms.Add(gokuRoom);

            Room bulmaRoom = new Room("name", "description");
            Rooms.Add(bulmaRoom);

            Room gohanRoom = new Room("name", "description");
            Rooms.Add(gohanRoom);




            Item Dragonball = new Item("dragonball", "");



            CurrentPlayer = new Player("Sonny");
            Playing = true;
            CurrentRoom = gotenRoom;




        }

        public void Help()
        {
            Console.WriteLine("*    'reset' allows you to reset the game and start at the beginning");
            Console.WriteLine("*    'quit' allows you to quit the game at anytime");
            Console.WriteLine("*    'help' will show you this list again \n");
        }

        private static void AddItem()
        {
            Item dragonball = new Item("Dragonball");
        }

        public void TakeItem(string itemName)
        {
            Item item = CurrentRoom.Items.Find(i => i.Name.ToUpper().Contains(itemName));

            if (CurrentRoom.Items.Contains(item))
            {

            }
            else
            {
                System.Console.WriteLine("There is nothing by that name in this room.");
            }
        }

        public void UseItem(string itemName)
        {
            Item item = CurrentPlayer.Inventory.Find(i => i.Name.ToUpper().Contains(itemName));
            if (item != null)
            {
                if (itemName == "dragonball") AddItem();
                {
                    CurrentPlayer.Dragonball = !CurrentPlayer.Dragonball;
                    CurrentPlayer.Inventory.Remove(item);
                }



            }
            else
            {
                System.Console.WriteLine("You don't have that item in your inventory.\n");
            }
        }

        public void Reset()
        {
            Play();
        }

        public void Quit()
        {
            Playing = false;
        }



    }
}