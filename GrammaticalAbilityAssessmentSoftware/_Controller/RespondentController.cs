using GAASBusinessLogicLibrary;
using GAASBusinessLogicLibrary._Models;

namespace GrammaticalAbilityAssessmentSoftware._Controller
{
    public class RespondentController
    {
        RespondentRepo respondents;
        public int NewCreatedRespondentID { get; set; }

        public void AddRespondent(Respondent user)
        {
            respondents = new RespondentRepo();
            NewCreatedRespondentID = respondents.Add(user);
        }

        public void RemoveRespondent(Respondent user)
        {
            respondents = new RespondentRepo();
            respondents.Delete(user);
        }

        public void SubmitAnswers(Respondent user, SubjectLevel subject, string result, int counter)
        {
            respondents = new RespondentRepo();
            respondents.SaveAnswers(user, subject, result, counter);
        }

        public List<Respondent> GetRespondents()
        {
            respondents = new RespondentRepo();
            return respondents.Get();
        }

        public void SubmitFrequencyOfError(Respondent user, SubjectLevel subject, int FrequencyOfError)
        {
            respondents = new RespondentRepo();
            respondents.SaveFrequencyOfErrors(user, subject, FrequencyOfError);
        }

    }
}
