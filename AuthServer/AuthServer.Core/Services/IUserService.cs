
using System;
using AuthServer.Core.Dtos;
using SharedLibrary.Dtos;

namespace AuthServer.Core.Services
{
	public interface IUserService
    { 
        // response var çünkü direk apiyle haberleşeceğim  
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto userDto);

        Task<Response<UserAppDto>> GetUserByNameAsync(string username);

        // clientlar token aldıktan sonra kullanıcılar hakkında bilgi almak isteyebilir
        // sadece token göndericekler token içerisindenn user id yi bulup
        // arkadaş gerçekten v.t da varsa ilgili clienta o tokenın kime ait olduğu ile ilgili kullanıcı bilgilerini dönücem


    }
}

