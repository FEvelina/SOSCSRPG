using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }    
        public int YCoordinate { get; set; }
        public string? Name {  get; set; }
        public string? Description { get; set; }
        public string? ImageName { get; set; }
        
        public List<Quest> QuestAvailableHere { get; set; } = new List<Quest>();
        public List<MonsterEncounter> MonsterEncounterHere { get; set;} = new List<MonsterEncounter>();

        public void AddMonster(int monsterID, int chanceOfEncountering)
        {
            if (MonsterEncounterHere.Exists( m => m.MonsterID == monsterID))
            {
                //if a monster already exists at the location, overwrite the encounter
                MonsterEncounterHere.First(m => m.MonsterID == monsterID).ChanceOfEncountering = chanceOfEncountering;
            }
            else
            {
                //no monster there, add a new one
                MonsterEncounterHere.Add(new MonsterEncounter(monsterID, chanceOfEncountering));
            }
        }

        public Monster GetMonster()
        {
            if(!MonsterEncounterHere.Any())
            { return null; }
            //total encounter percentage of all monsters at this location
            int totalChances = MonsterEncounterHere.Sum(m => m.ChanceOfEncountering);

            int randomNumber = RandomNrGenerator.NumberBetween(1, totalChances);

            int runningTotal = 0;

            //loop through the list of monsters that can be encountered here, and check which's chances fit the randomNumber check, 
            // and we return the instance of the monster matching that id
            foreach(MonsterEncounter enemy in MonsterEncounterHere)
            {
                runningTotal += enemy.ChanceOfEncountering;
                if(randomNumber <= runningTotal)
                {
                    return MonsterFactory.GetMonster(MonsterEncounterHere.Last().MonsterID);
                }
            }
            //if problem, return last monster in the list
            return MonsterFactory.GetMonster(MonsterEncounterHere.Last().MonsterID);
        }
    }
}
