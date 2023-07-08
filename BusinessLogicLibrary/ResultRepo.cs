using DataAccessLibrary;
using GAASBusinessLogicLibrary._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASBusinessLogicLibrary
{
    public class ResultRepo : Repository
    {
        public List<FrequencyErrorCount> FreqErrorsCount()
        {
            List<FrequencyErrorCount> subjects = new List<FrequencyErrorCount>();
            this._Query = "select * from [FrequencyErrorSumCountByParts] order by [SumOfFrequencyOfError] desc";

            var data = this.FetchData();

            while (data.Read())
            {
                subjects.Add(new FrequencyErrorCount
                {
                    LevelID = int.Parse(data["LevelID"].ToString()),
                    Parts = data["Parts"].ToString(),
                    Code = data["Code"].ToString(),
                    Weight = decimal.Parse(data["Weight"].ToString()),
                    Level = data["Level"].ToString(),
                    ErrorCount = Convert.ToInt32(data["SumOfFrequencyOfError"].ToString())
                });
            }

            this.ResetConnections();
            return subjects;
        }

        public RespondentResult_Computation GetGrammarProficiencyResult(Respondent respondent, out string QuestionCount)
        {
            RespondentResult_Computation respComputation = new RespondentResult_Computation();

            this._Query = "select * from [FinalComputation] where RespondentsID = @RespondentID order by GPRID desc";
            this.Parameters.Add(respondent.ID.ToString());

            var data = this.FetchData();
            var qCount = "";

            if (data.Read())
            {
                respComputation = new RespondentResult_Computation
                {
                    ID = int.Parse(data["RespondentsID"].ToString()),
                    Name = data["RespondentName"].ToString(),
                    GrammarProficiencyScore = data["GrammarProficiencyScore"].ToString(),
                    GrammarProficiencyAverage = data["GrammarProficiencyAverage"].ToString(),
                    GrammarProficiencyLevel = data["GrammarProficiencyLevel"].ToString(),
                };

                qCount = data["QuestionCount"].ToString();
            }

            QuestionCount = qCount;
            this.ResetConnections();
            return respComputation;
        }

        public List<RespondentResult_Computation> GetRespondentsResults(Respondent respondentID)
        {
            List<RespondentResult_Computation> respResult = new List<RespondentResult_Computation>();
            if (respondentID == null)
            {
                this._Query = "select * from [TotalFrequencyOfError]";
            }
            else
            {
                this._Query = "select * from [TotalFrequencyOfError] where [RespondentsID] = @RespondentID";

                this.Parameters.Add(respondentID.ID.ToString());
            }

            var data = this.FetchData();

            while (data.Read())
            {
                respResult.Add(new RespondentResult_Computation
                {
                    ID = int.Parse(data["RespondentsID"].ToString()),
                    Name = data["RespondentName"].ToString(),
                    TotalFrequencyOfError = int.Parse(data["TotalFrequencyOfError"].ToString()),
                    TransmutedError = data["TotalTransmutedError"] == null ? 0 : Convert.ToDecimal(data["TotalTransmutedError"].ToString())
                });
            }

            this.ResetConnections();
            return respResult;
        }

        public List<FrequencyErrorCount> GetFreqOfErrorByRespondent(Respondent respondent)
        {
            List<FrequencyErrorCount> subjects = new List<FrequencyErrorCount>();
            this._Query = "select * from [RespondentFrequencyOfError] where [RespondentsID] = @RespondentsID order by [Level] asc";
            this.Parameters.Add(respondent.ID.ToString());

            var data = this.FetchData();

            while (data.Read())
            {
                subjects.Add(new FrequencyErrorCount
                {
                    LevelID = int.Parse(data["LevelID"].ToString()),
                    Level = data["Level"].ToString(),
                    Parts = data["Parts"].ToString(),
                    Code = data["Code"].ToString(),
                    Weight = Convert.ToDecimal(data["Weight"].ToString()),
                    ErrorCount = Convert.ToInt32(data["FrequencyOfError"].ToString()),
                    TransmutedError = Convert.ToDecimal(data["TransmutedError"].ToString())
                });
            }

            this.ResetConnections();
            return subjects;
        }


        public RespondentResult GetRespondentResultByRespondent(Respondent respondent, SubjectLevel subject)
        {
            RespondentResult result = new RespondentResult();
            result.Subject = new SubjectLevel();
            this._Query = "select * from [RespondentAnswersResult] where [RespondentsID] = @RespondentsID and [LevelID] = @LevelID";
            this.Parameters.Add(respondent.ID.ToString());
            this.Parameters.Add(subject.LevelID.ToString());

            var data = this.FetchData();

            while (data.Read())
            {
                QA qa = new QA
                {
                    ID = int.Parse(data["QAID"].ToString()),
                    Question = data["Question"].ToString(),
                    Answer = data["UserAnswer"].ToString(),
                    CorrectAnswer = data["Answer"].ToString(),
                    Result = data["Result"].ToString()
                };

                result.Subject.QuestionAnswer.Add(qa);
            }

            if (data.Read())
            {
                result.Respondent = new Respondent
                {
                    ID = int.Parse(data["RespondentsID"].ToString()),
                    Name = data["RespondentName"].ToString()
                };

                result.Subject.LevelID = int.Parse(data["LevelID"].ToString());
                result.Subject.Level = data["Level"].ToString();
                result.Subject.Parts = data["Parts"].ToString();
                result.Subject.Code = data["Code"].ToString();
                result.Subject.Weight = int.Parse(data["Weight"].ToString());
            }

            this.ResetConnections();
            return result;
        }
    }
}
