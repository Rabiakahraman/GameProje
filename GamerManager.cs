using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGameServer
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("kayıt olundu");
            }
            else
            {
                Console.WriteLine("dogrulama başarısız kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayıt silindi");  
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
