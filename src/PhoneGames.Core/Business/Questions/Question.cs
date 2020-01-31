using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace PhoneGames.Business.Questions
{
    public class Question : FullAuditedEntity<int>
    {
        public string Text { get; set; }
    }
}