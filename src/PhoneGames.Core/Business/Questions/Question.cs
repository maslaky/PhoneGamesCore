using Abp.Domain.Entities.Auditing;

namespace PhoneGames.Business.Questions
{
    public class Question : FullAuditedEntity<long>
    {
        public string Text { get; set; }
    }
}