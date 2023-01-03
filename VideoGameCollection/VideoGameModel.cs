using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameCollection
{
    public enum Owned
    {
        NO,
        YES,
        PSPLUS,
        GAMEPASS
    }
    public class VideoGameModel
    {
        public VideoGameModel()
        {
        
        }
        public VideoGameModel(string name, string publisher, string platform, Owned owned, double price)
        {
            Name = name;
            Publisher = publisher;
            Platform = platform;
            Owned = owned;
            Price = price;
        }

        public VideoGameModel(string name, string publisher, string platform, Owned owned, double price, int id)
        {
            Name = name;
            Publisher = publisher;
            Platform = platform;
            Owned = owned;
            Price = price;
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Publisher { get; set; }

        public string Platform { get; set; }

        public Owned Owned { get; set; }

        public double Price { get; set; }


    }

    
}
