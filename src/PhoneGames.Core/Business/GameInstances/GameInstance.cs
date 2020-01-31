using Abp.Domain.Entities.Auditing;

namespace PhoneGames.Business.GameInstances
{
    public class GameInstance : FullAuditedEntity<long>
    {
        public string Code { get; set; }
    }
}