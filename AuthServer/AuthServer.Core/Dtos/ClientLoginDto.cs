using System;
namespace AuthServer.Core.Dtos
{
	public class ClientLoginDto
	{
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }
    }
}
/* client tarafında;
 * clientId -> userName
 * clientSecret -> Passw
 */

