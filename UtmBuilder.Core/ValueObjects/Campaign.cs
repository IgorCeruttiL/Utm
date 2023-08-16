
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign : ValueObject
    {

        /// <summary>
        /// Gera uma nova campanha para a URL
        /// </summary>
        /// <param name="source">A referência</param>
        /// <param name="medium">Marketing medium</param>
        /// <param name="name">Produto, codigo da promoçao, ou slogan</param>
        /// <param name="id">Adiciona um Id a campanha</param>
        /// <param name="term">Identifica as chaves</param>
        /// <param name="content">Usa para diferenciar os ads</param>

        public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;

            InvalidCampaignException.ThrowIfNull(source, "Source is invalid");
            InvalidCampaignException.ThrowIfNull(medium, "Medium is invalid");
            InvalidCampaignException.ThrowIfNull(name, "Name is invalid");
        }

        public string Source { get; }
        public string Medium { get; }
        public string Name { get; }
        public string? Id { get; }
        public string? Term { get; }
        public string? Content { get; }
    }
}
