using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
           if(gamer.BirtYear == 1992 && gamer.TC == "1234" 
              &&gamer.LastName == "kahraman" && gamer.Firstname == "Rabia" && gamer.ID ==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
