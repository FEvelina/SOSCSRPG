using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{  
    //personal thought, if there will be only the CreateWorld method, WorldFactory could be a struct, not a class
    internal static class WorldFactory
    {

        //creating the world with it's locations 
       internal static World CreateWorld()
        {
            World newWorld = new World();
            //added the map locations, the y coordinates are ascending
            //X==2
            newWorld.AddLocation(2, 0, "Spider Forest", "A white forest, made by the giant tarantula that's watching you", "pack://application:,,,/Engine;component/Images/Locations/SpiderForest.png");
            newWorld.LocationAt(2, 0).AddMonster(3, 100);


            //X==1
            newWorld.AddLocation(1, 0, "Town Gate", "An old gate, with missing nails", "pack://application:,,,/Engine;component/Images/Locations/TownGate.png");


            //X==0
            newWorld.AddLocation(0, 2, "Herb Garden", "A garden full of medicinal plants, but somthing is moving in the grass", "pack://application:,,,/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.LocationAt(0, 2).AddMonster(1, 100);

            newWorld.AddLocation(0, 1, "Herbalist's Hut", "Qurious hut having a nostalgic smell", "pack://application:,,,/Engine;component/Images/Locations/HerbalistsHut.png");
            newWorld.LocationAt(0,1).QuestAvailableHere.Add(QuestFactory.GetQuestByID(01));
            newWorld.AddLocation(0, 0, "Town Square", "This is the town square", "pack://application:,,,/Engine;component/Images/Locations/TownSquare.png");
            newWorld.AddLocation(0, -1, "Home", "This is your home", "pack://application:,,,/Engine;component/Images/Locations/Home.png");

            //X==-1
            newWorld.AddLocation(-1, 0, "Trading Shop", "You can sell/buy goodss", "pack://application:,,,/Engine;component/Images/Locations/Trader.png");
            newWorld.AddLocation(-1, -1, "Farmhouse", "There is something misterious here", "pack://application:,,,/Engine;component/Images/Locations/Farmhouse.png");

            //X==-2
            newWorld.AddLocation(-2, -1, "Farmer's Field", "You can see an golden ocean, and rats..", "pack://application:,,,/Engine;component/Images/Locations/FarmFields.png");

            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

        

            return newWorld; 
        }
    }
}
