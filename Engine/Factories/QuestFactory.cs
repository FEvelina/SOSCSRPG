using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory() 
        {
        //declare items needed to complete the quest and the rewards
        List<ItemQuantity> neededItem = new List<ItemQuantity>();
        List<ItemQuantity> rewardCompItem = new List<ItemQuantity>();

            neededItem.Add(new ItemQuantity(9001, 3));
            rewardCompItem.Add(new ItemQuantity(1002, 1));

            _quests.Add(new Quest(01, "Kill the RATS!", "SPARTAAAAA", neededItem, 10, 7, rewardCompItem));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
