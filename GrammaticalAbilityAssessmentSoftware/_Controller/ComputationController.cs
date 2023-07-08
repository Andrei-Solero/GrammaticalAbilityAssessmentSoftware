using GAASBusinessLogicLibrary;
using GAASBusinessLogicLibrary._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammaticalAbilityAssessmentSoftware._Controller
{
    public class ComputationController
    {
        private ComputationRepo computationRepo;

        public void Compute(int respondentID, bool isForTotal, SubjectLevel currentSubject)
        {
            computationRepo = new ComputationRepo();
            computationRepo.Compute(respondentID, isForTotal, currentSubject);
        }

        int counter = 0;
        int TE;
        public void ComputeProficiency(Respondent respondentID)
        {
            ResultRepo resultRepo = new ResultRepo();
            SubjectQuestionRepo questions = new SubjectQuestionRepo();
            List<RespondentResult_Computation> resps = new List<RespondentResult_Computation>();

            List<RespondentResult_Computation> results = null;

            if (respondentID != null)
            {
                results = resultRepo.GetRespondentsResults(respondentID);
            }
            else
            {
                results = resultRepo.GetRespondentsResults(null);
            }
            
            var questionCount = (decimal)questions.GetTotalNumberOfQuestion();

            foreach (var result in results)
            {
                resps.Add(new RespondentResult_Computation
                {
                    ID = result.ID,
                    Name = result.Name,
                    TotalFrequencyOfError = result.TotalFrequencyOfError,
                    TransmutedError = result.TransmutedError,
                });

                resps[counter].GrammarProficiencyScore = (questionCount - resps[counter].TransmutedError).ToString();

                decimal gps = decimal.Parse((resps[counter].GrammarProficiencyScore));
                decimal averageByZero = (gps / questionCount);
                var average = averageByZero * 100M;

                resps[counter].GrammarProficiencyAverage = average.ToString("0.00");

                var gpl = GrammarProficiencyLevel((double)average);

                resps[counter].GrammarProficiencyLevel = gpl;

                computationRepo = new ComputationRepo();
                computationRepo.ComputeProficiencyResult(resps[counter]);
                counter++;
            }

            counter = 0;
        }

        private string GrammarProficiencyLevel(double average)
        {
            string gpl = "";

            if (average <= 1 && average <= 35)
            {
                gpl = "Beginner";
            }
            else if (average >= 35.1 && average <= 60)
            {
                gpl = "Intermediate";
            }
            else if (average >= 60.1 && average <= 75)
            {
                gpl = "High";
            }
            else if (average >= 75.1 && average <= 90)
            {
                gpl = "Advanced";
            }
            else if (average >= 90.1 && average <= 100)
            {
                gpl = "Advanced High";
            }

            return gpl;
        }

    }
}
