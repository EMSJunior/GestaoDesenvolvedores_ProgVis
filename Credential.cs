using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDesenvolvedores
{
    [Table("credentials")]
    internal class Credential
    {
        public Int64 Id { get; set; }

        public const String SALT = "3D50n_";
        [Required]
        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }
        private String _password { get; set; }
        [Required]
        [StringLength(64)]
        public String Password 
        { 
            get { return _password; }
            set {   if (value.Length == 64)
                    {
                        _password = value;
                    }
                    else if(value.Length >= 8 && value.Length <=12)
                    {
                        _password = ComputeSHA256(value, SALT);
                    }
                    else
                    {
                        throw new ArgumentException("A senha tem que ter entre 8 e 12 caracteres.");
                    }
                } 
        }
        public Boolean IsActive { get; set; }
        public Boolean IsAdmin { get; set; }
        [Required]
        public Developer Developer { get; set; }

        #region Hashing
        public static String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }

        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            // 
            // https://learn.microsoft.com/en-us/dotnet/standard/security/cryptographic-services
            // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=netframework-4.8
            // https://www.techiedelight.com/generate-sha-256-hash-of-string-csharp/
            // 

            // Initialize a SHA256 hash object
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion
        public Credential()
        {
            IsActive = false;
            IsAdmin = false;
        }

        public Credential(string email, string password, Developer dev)
        {
            Email = email;
            Password = password;
            Developer = dev;
            IsActive = false;
            IsAdmin = false;
        }

        
        public override String ToString()
        {
            return Id
                + ", " + Email
                + ", " + Password
                + ", " + (IsAdmin ? "Administrador" : "Dev");
        }
    }
}
