﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
          switch(monsterID)
            {
            case 1:
              Monster snake = new Monster("Snake", "pack://application:,,,/Engine;component/Images/Monsters/Snake.png", 4, 4, 5, 1);
              AddLootItem(snake, 9001, 25);
              AddLootItem(snake, 9002, 70);

                    return snake;
            case 2:
                Monster rat = new Monster("Rat", "pack://application:,,,/Engine;component/Images/Monsters/Rat.png", 5,5,5,1);
                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);
                return rat;
            case 3:
                    Monster spider = new Monster("Spider", "pack://application:,,,/Engine;component/Images/Monsters/Spider.png", 10, 10, 10, 3);
                    AddLootItem(spider, 9005, 25);
                    AddLootItem(spider, 9006, 75);
                    return spider;
                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int lootID, int percentage)
        {
            if (RandomNrGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(lootID, 1));
            }
        }
    }
}
