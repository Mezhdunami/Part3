using Part3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Animal Pet { get; set; }
        public TVShow FavoriteTVShow { get; set; }




        public void SetFavoriteShow(TVShow favShow)
        {
            FavoriteTVShow = favShow;
          
        }
        public void SetChannel(int setChannel)
        {

            FavoriteTVShow.ChannelNumber = setChannel;

   
        }
        public void PrintShowInfo()
        {
            Console.WriteLine($"{Name} info:\nFavorite Show: {FavoriteTVShow.Name}\nChannel Number: {FavoriteTVShow.ChannelNumber}\n");
        }


    }
}

