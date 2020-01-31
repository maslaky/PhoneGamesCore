using AutoMapper;

namespace PhoneGames.Business.Questions
{
    public class QuestionToQuestionDtoProfile : AutoMapper.Mapper
    {
        public QuestionToQuestionDtoProfile(IConfigurationProvider configurationProvider) : base(configurationProvider)
        {
        }
    }
}