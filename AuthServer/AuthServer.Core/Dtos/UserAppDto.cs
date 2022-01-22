using System;
namespace AuthServer.Core.Dtos
{
	public class UserAppDto
	{ 
        /* entitieleri dış dünayyas açmak istemiyorum
		 * clientlar entitieler hakkında bilgi sahiibi olmayacak
		 * dtolar üzerinden gerekli bilgileri alacaklar
		 */
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
    }
}

