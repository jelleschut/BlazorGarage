using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Web.Utils
{
    public class X509Encryptor
    {
        private X509Certificate2 x509;
        public X509Encryptor()
        {
            x509 = LoadCertificate();
        }

        private X509Certificate2 LoadCertificate()
        {
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection certCollection = store.Certificates;
            X509Certificate2 cert = certCollection.Cast<X509Certificate2>().FirstOrDefault(c => c.Subject == "CN=localhost");

            if (cert == null)
            {
                throw new Exception("No such certificate found");
            }

            store.Close();
            return cert;
        }

        public string Encrypt(string stringToEncrypt)
        {
            if (x509 == null || string.IsNullOrEmpty(stringToEncrypt))
                throw new Exception("A x509 certificate and string for encryption must be provided");

            RSA rsa = x509.GetRSAPublicKey();

            byte[] bytestoEncrypt = Encoding.ASCII.GetBytes(stringToEncrypt);
            byte[] encryptedBytes = rsa.Encrypt(bytestoEncrypt, RSAEncryptionPadding.OaepSHA256);

            return Convert.ToBase64String(encryptedBytes);
        }

        public string Decrypt(string stringTodecrypt)
        {
            if (x509 == null || string.IsNullOrEmpty(stringTodecrypt))
                throw new Exception("A x509 certificate and string for decryption must be provided");

            if (!x509.HasPrivateKey)
                throw new Exception("x509 certicate does not contain a private key for decryption");

            RSA rsa = (RSA)x509.GetRSAPrivateKey();

            byte[] bytestodecrypt = Convert.FromBase64String(stringTodecrypt);
            byte[] plainbytes = rsa.Decrypt(bytestodecrypt, RSAEncryptionPadding.OaepSHA256);

            ASCIIEncoding enc = new ASCIIEncoding();
            return enc.GetString(plainbytes);
        }

        //public void RunEncryption()
        //{
        //    try
        //    {
        //        X509Certificate2 myCert =
        //           LoadCertificate(StoreLocation.CurrentUser,
        //           "CN=LocalHost");

        //        string myText = "This is the text I wish to encrypt";
        //        Console.WriteLine("UNENCRYPTED: " + myText);

        //        string encrypted = Encrypt(myCert, myText);

        //        Console.WriteLine("ENCRYPTED: " + encrypted);

        //        string decrypted = Decrypt(myCert, encrypted);

        //        Console.WriteLine("DECRYPTED: " + decrypted);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("EXCEPTION: {0}", e.Message);
        //    }

        //}
    }
}


