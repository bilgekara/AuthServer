using System;
namespace AuthServer.Core.Dtos
{
	public class CreateUserDto
	{
        // DTO -> clientlara gidecek model
        /* yeni bir kullanıcı oluşturduklarında clientlardan
		 * en minimal şekilde username -> identity library bekliyor
		 */
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}

