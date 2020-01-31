using Abp.Application.Services;
using Abp.Domain.Repositories;


namespace PhoneGames.Business.Questions
{
    public class QuestionAppService : CrudAppService<Question, QuestionDto>
    {
        public QuestionAppService(IRepository<Question, int> repository) : base(repository)
        {
        }
    }
}