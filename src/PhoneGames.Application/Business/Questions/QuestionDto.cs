using Abp.Application.Services.Dto;
using Abp.Domain.Entities;

namespace PhoneGames.Business.Questions
{
    public class QuestionDto : FullAuditedEntityDto<int>
    {
        public string Text { get; set; }
    }
}