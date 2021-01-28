using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1985 && gamer.FirstName =="ENGIN" && gamer.LastName == "Demirog" && gamer.IdentityNumber == 123345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void IUserValidation.Validate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
