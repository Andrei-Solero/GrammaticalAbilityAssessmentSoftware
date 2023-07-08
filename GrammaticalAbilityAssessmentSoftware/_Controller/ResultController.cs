using GAASBusinessLogicLibrary;
using GAASBusinessLogicLibrary._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace GrammaticalAbilityAssessmentSoftware._Controller
{
    public class ResultController
    {
        ResultRepo resultRepo;

        public List<FrequencyErrorCount> FreqErrorCount()
        {
            resultRepo = new ResultRepo();
            return resultRepo.FreqErrorsCount();
        }

        public List<FrequencyErrorCount> FreqErrorCountByRespondent(Respondent respondent)
        {
            resultRepo = new ResultRepo();
            return resultRepo.GetFreqOfErrorByRespondent(respondent);
        }

        public RespondentResult RespondentResult(Respondent respondent, SubjectLevel subject)
        {
            resultRepo = new ResultRepo();
            return resultRepo.GetRespondentResultByRespondent(respondent, subject);
        }

        public List<RespondentResult_Computation> GetRespondentsByResults()
        {
            resultRepo = new ResultRepo();
            return resultRepo.GetRespondentsResults(null);
        }

        public RespondentResult_Computation FinalResult(Respondent respondent, out string QuestionCount)
        {
            resultRepo = new ResultRepo();
            return resultRepo.GetGrammarProficiencyResult(respondent, out QuestionCount);
        }
    }
}
