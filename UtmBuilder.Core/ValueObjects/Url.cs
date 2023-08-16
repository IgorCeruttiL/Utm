
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {

        /// <summary>
        /// Cria um novo URL
        /// </summary>
        /// <param name="adress">Endereço da url (website link)</param>
        public Url(string adress)
        {
            Adress = adress;
            InvalidUrlException.ThrowIfInvalid(adress);
            
        }

        /// <summary>
        /// Endereço da url (website link)
        /// </summary>

        public string Adress { get; }


    }
}
