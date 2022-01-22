using System;
namespace AuthServer.Core.Dtos
{
    public class LoginDto
    {
        public string Email { get; set; }

        public struct Password { get; set; }
        // bu bilgiler requestten gelecek, eşleşirse token dönülecek
    }
}

