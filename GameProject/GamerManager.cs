using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{   //MicroService

    class GamerManager : IGamerService
    {
        private UserValidationManager userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            this.userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
          
            Console.WriteLine("Kayit oldu");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit Silindi"); 
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit Guncellendi");
        }
    }
}
