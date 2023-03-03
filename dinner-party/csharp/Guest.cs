using System;

namespace DinnerParty
{
    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }

        public Guest(string nameParam, string occupationParam, string bioParam)
        {
            Name = nameParam;
            Occupation = occupationParam;
            Bio = bioParam;
        }
    }

}