using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Doğa" && gamer.LastName == "Güven" && gamer.TcNo == "58658987550")
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
