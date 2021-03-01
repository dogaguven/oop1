using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager (IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Bilgiler Doğrulandı. Kayıt başarılı.");
            }
            else
            {
                Console.WriteLine("Bilgiler Doğrulanamadı. Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
