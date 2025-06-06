﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster:BaseNotificationClass
    {
        private int _hitPoints;
       public string Name { get; private set; }
       public string ImageName  { get; set; }
        public int MaximumHitPoints { get; private set; }
        public int HitPoints
        {
            get { return _hitPoints; }
            set 
            { 
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));

            }
        }

       public int RewardExperiencePoints    { get; private set; }
        public int RewardGold {  get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get;set; }

        public Monster(string name, string imagaName, int maxHitPoints, int hitPoints, int rewardExpPoints, int rewardGold) 
        {
        Name = name;
            ImageName = imagaName;
            MaximumHitPoints = maxHitPoints;
            HitPoints = hitPoints;
            RewardExperiencePoints = rewardExpPoints;
            RewardGold = rewardGold;
            Inventory = new ObservableCollection<ItemQuantity>();
        }

    }
}
