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

        public void Setup()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Loop()
        {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("***** IN REMEMBRANCE OF SONNY AND HIS LOVE FOR DRAGON BALL Z ***** \n");
        Console.WriteLine("This game is your typical 'choose your own adventure game' where you can decide your own path. You will be fighting side by side with characters from Dragon Ball Z to help save the Earth. Good Luck! \n");
        Console.WriteLine("Press 'enter' for game instructions \n");
        Console.ReadLine();
        Console.WriteLine("How to Play: \n");
        Console.WriteLine("In this fight to save the Earth you will be given multiple options that you must choose from. Once you have made a decision you will type the text that corresponds with your choice. \n");
        Console.WriteLine("If you are ever unsure about what to do next just type in one of these words at anytime:\n");
        Console.WriteLine("*    'reset' allows you to reset the game and start at the beginning");
        Console.WriteLine("*    'repeat' will repeat the instructions");
        Console.WriteLine("*    'quit' allows you to quit the game at anytime");
        Console.WriteLine("*    'help' will show you this list again \n");
        Console.WriteLine("Press 'enter' to play");
        Console.ReadLine();





        }

        public void Help()
        {
        Console.WriteLine("*    'reset' allows you to reset the game and start at the beginning");
        Console.WriteLine("*    'repeat' will repeat the instructions");
        Console.WriteLine("*    'quit' allows you to quit the game at anytime");
        Console.WriteLine("*    'help' will show you this list again \n");
        }

        public void Reset()
        {
            Playing = false;
            Console.Clear();
            Playing = true;
            Setup();
            Loop();
        }

        public void Repeat()
        {

        }

        public void UseItem(string name)
        {

        }

        // public string GetUserInput()
        // {

        // }

        public void Go(string direction)
        {

        }

        public void AddRooms()
        {
            var gotenRoom = new Room(string name);

            // Console.WriteLine("Sonny? Is that you Sonny?! Can you please help us! My name is Goten and my dad Goku sent me to find somebody to help him defeat the horrible villains Piccolo and Vegeta! Go! Go now! The Earth is depending on you! \n");
            // Console.WriteLine("Press 'enter' to accept this responsibility");
            // Console.ReadLine();
            // Console.Clear();

            Rooms.Add(gotenRoom);
        }

    }
}