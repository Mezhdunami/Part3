using Part3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public struct Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public TVShow FavoriteTVShow;




        public void SetFavoriteTVShow(TVShow showName)
        {
            FavoriteTVShow = showName;
            
        }

        public void SetChannel(int channel)
        {
            FavoriteTVShow.Channel = channel;
        }

        public void PrintShowInfo()
        {
            Console.WriteLine($"{Name}'s favorite TV show is {FavoriteTVShow.Name} on channel {FavoriteTVShow.Channel}");
        }


    }
}

