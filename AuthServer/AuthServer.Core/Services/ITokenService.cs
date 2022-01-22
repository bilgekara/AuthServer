using System;
using AuthServer.Core.Configuration;
using AuthServer.Core.Models;

namespace AuthServer.Core.Services
{
	Token CreateToken(UserApp userApp);
	ClientTokenDto CreateTokenByClient(Client client);
}

