using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                ID = 1,
                BirtYear = 1992,
                LastName = "kahraman",
                Firstname = "Rabia",
                TC ="1234",

            });
            
           
        }
    }
}
