using Part3;
using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        TVShow show1 = new TVShow
        {
            Name = "Simpsons",
            ChannelNumber = 36
        };

        TVShow show2 = new TVShow
        {
            Name = "Adams Family",
            ChannelNumber = 69
            
        };

        Person person1 = new Person
        {
            Name = "Tom",
            Surname = "Riddle",
            FavoriteTVShow = show2,
        };

        Person person2 = new Person
        {
            Name = "Maria",
            Surname = "Magdalena",
            FavoriteTVShow = show1,

        };

        // Print out TVshow info of both persons
        person1.PrintShowInfo();
        person2.PrintShowInfo();

        // One day Maria was tired of Simpsons and started to watch Adams Family as well as Tom.
        person2.SetFavoriteShow(show2);

        // Print out Maria's favorite TVshow
        person2.PrintShowInfo();

        // She set 68 for her favorite TVShow, which was Adams Family
        Console.WriteLine("\nMaria set 68 for her favorite TVShow, which was Adams Family\n");
        person2.SetChannel(68);

        // Print out Maria's favorite TVshow - should be 68
        person2.PrintShowInfo();

        // Maria was very nervous that Tom could not guess that the channel was changed.
        // And she asked Tom to show his TVshow info. She was very happy when she saw
        // that he still watched his favorite show on channel 69
        person1.PrintShowInfo();
    }
}
