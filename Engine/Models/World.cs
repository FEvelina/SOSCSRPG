using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        //method for adding a new Location in the list
        internal void AddLocation(int xCoordinates, int yCoordinate, string name, string description, string imageName)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordinates;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _locations.Add(loc);

        }

        //returning the Location based on coordinates, from out list of locations
        public Location LocationAt(int xCoordinates, int yCoordinates)
        {
            foreach (Location loc in _locations) { 
                if(loc.XCoordinate == xCoordinates && loc.YCoordinate == yCoordinates) return loc;
            }
            return null;
        }
    }
}
