using DataAccessLibrary;
using GAASBusinessLogicLibrary._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASBusinessLogicLibrary
{
    public class RespondentRepo : Repository
    {
        public int Add(Respondent user)
        {
            this._Query = "insert into [Respondents]([RespondentName])values" +
                "(@Name)";

            this.Parameters.Add(user.Name);

            this.ModifyData();
            this.ResetConnections();

            return this.NewID;
        }

        public void Delete(Respondent respondent)
        {
            this._Query = "delete from Respondents where [RespondentsID] = @respondent";
            this.Parameters.Add(respondent.ID.ToString());

            this.ModifyData();
            this.ResetConnections();

            this._Query = "delete from RespondentsAnswer where [RespondentID] = @respondent";
            this.Parameters.Add(respondent.ID.ToString());

            this.ModifyData();
            this.ResetConnections();

            this._Query = "delete from RespondentsFreqOfError where [RespondentID] = @respondent";
            this.Parameters.Add(respondent.ID.ToString());

            this.ModifyData();
            this.ResetConnections();

            this._Query = "delete from GrammarProficiencyResult where [RespondentID] = @respondent";
            this.Parameters.Add(respondent.ID.ToString());

            this.ModifyData();
            this.ResetConnections();
        }

        public List<Respondent> Get()
        {
            List<Respondent> respondents = new List<Respondent>();
            this._Query = "select * from Respondents";

            var data = this.FetchData();

            while (data.Read())
            {
                respondents.Add(new Respondent
                {
                    ID = (int)data["RespondentsID"],
                    Name = data["RespondentName"].ToString()
                });
            }

            this.ResetConnections();
            return respondents;
        }


        public void SaveAnswers(Respondent user, SubjectLevel subject, string result, int questionCounter)
        {
            this._Query = "insert into [RespondentsAnswer]([RespondentID], [QAKeysID], [UserAnswer], [Result])values" +
                "(@RespondentID, @QAKeysID, @UserAnswer, Result)";

            this.Parameters.Add(user.ID.ToString());
            this.Parameters.Add(subject.QuestionAnswer[questionCounter].ID.ToString());
            this.Parameters.Add(user.UserAnswer.Answer);
            this.Parameters.Add(result);

            this.ModifyData();
            this.ResetConnections();
        }

        public void SaveFrequencyOfErrors(Respondent user, SubjectLevel subject, int FrequenceOfError)
        {
            this._Query = "insert into [RespondentsFreqOfError]([RespondentID], [SubjectID], [FrequencyOfError])values" +
                "(@RespondentID, @SubjectID, @FrequencyOfError)";

            this.Parameters.Add(user.ID.ToString());
            this.Parameters.Add(subject.LevelID.ToString());
            this.Parameters.Add(FrequenceOfError.ToString());

            this.ModifyData();
            this.ResetConnections();
        }
    }
}
