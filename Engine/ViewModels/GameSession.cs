using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        public GameSession()
        {

            //for now the player instantiation
            CurrentPlayer = new Player();

            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Rogue";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            //when starting a game session create a factory
            WorldFactory factory = new WorldFactory();
            //and the current world would be represented by all the location in the factory.CreateWorld()
            CurrentWorld = factory.CreateWorld();

            //set the default location when entering the game session
            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }
    }
}
