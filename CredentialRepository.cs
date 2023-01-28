using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDesenvolvedores
{
    internal class CredentialRepository
    {
        public static Developer Auth(string email, string senha)
        {
            Developer dev = DeveloperRepository.FindByEmailWCredential(email);
            if (dev == null)
            {
                return null;
            }
            senha = Credential.ComputeSHA256(senha, Credential.SALT);

            if (dev.Credential.Password == senha)
            {
                return dev;
            }
            else 
            {
                return null;
            }

        }
    }
}
