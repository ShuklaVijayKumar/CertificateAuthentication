using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWCF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Press any key");
                Console.Read();
                ServiceReferenceClient.ServiceHelloClient obj = new ServiceReferenceClient.ServiceHelloClient();
                obj.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
                obj.ClientCredentials.UserName.UserName = "abc";
                obj.ClientCredentials.UserName.Password = "123";
                var response = obj.DoWork() == null ? "Access Denied !!" : obj.DoWork();

                Console.Write(response);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
            Console.Read();
        }
    }
}
