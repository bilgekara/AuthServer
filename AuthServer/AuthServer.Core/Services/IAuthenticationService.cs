using System;
using AuthServer.Core.Dtos;
using SharedLibrary.Dtos;

namespace AuthServer.Core.Services
{
	public interface IAuthenticationService
	{ 
		//kullanıcı dan login ve şifre alınacak doğruysa token dönecek
		Task<Response<TokenDto>> CreateToken(LoginDto loginDto);

		// refresh tokenla yeni bir token alabilir
		Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

		// r.t -> sonlandırma
		Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);

		// client ile beraber token oluştur
		Task<Response<ClientTokenDto>> CreateTokenByClient(ClientLoginDto clientLoginDto);
	}
}

