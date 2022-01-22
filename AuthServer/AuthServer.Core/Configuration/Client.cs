using System;
namespace AuthServer.Core.Configuration
{
	public class Client
	{
        public string Id { get; set; }

        public int Secret { get; set; }

        public List<String> Audiences { get; set; }
        /* bu client api'lerimden hangilerine erişecek
         * iki üyelik sistemi gerektirmeyen api var 
         * mesela mobil app token aldığı zaman iki api ye erişebilsin
         * * * *
         * client bana data gönderirken onunla ilgili client login dto tasarlamadım
         * dto nesnesi olsaydı clientların görebileceği bir nesne olcaktı
         * kendi projemizde kullanacağımız için dto değil
         * * * *
         * www.myapi1.com www.myapi2.com
         * bu client iistek yaptığında dönen token da iki api yede erişebilir
         * 
         */
    }
}

