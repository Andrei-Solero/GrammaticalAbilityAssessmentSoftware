using DataAccessLibrary;
using GAASBusinessLogicLibrary._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASBusinessLogicLibrary
{
    public class SubjectQuestionRepo : Repository
    {
        public int GetTotalNumberOfQuestion()
        {
            this._Query = "select count(Question) as TotalQuestions from QAKeys";

            var data = this.FetchData();
            int totalQuestions = 0;

            if (data.Read())
            {
                totalQuestions = int.Parse(data["TotalQuestions"].ToString());
            }

            this.ResetConnections();

            return totalQuestions;
        }

        public SubjectLevel GetQuestions(SubjectLevel subject, bool Sorted)
        {
            SubjectLevel subjectLevel = new SubjectLevel();

            if (Sorted == true)
            {
                this._Query = $"select * from [QASubjectDetails] where [LevelID] = @LevelID order by [Level] asc, [QuestionNumber] asc";
            }
            else
            {
                this._Query = $"select * from [QASubjectDetails] where [LevelID] = @LevelID";
            }
            
            this.Parameters.Add(subject.LevelID.ToString());

            var data = this.FetchData();

            while (data.Read())
            {
                QA qa = new QA
                {
                    ID = int.Parse(data["QAID"].ToString()),
                    Question = data["Question"].ToString(),
                    Answer = data["Answer"].ToString(),
                    QuestionNumber = int.Parse(data["QuestionNumber"].ToString())
                };

                subjectLevel.QuestionAnswer.Add(qa);
            }

            if (data.Read())
            {
                subjectLevel.LevelID = int.Parse(data["LevelID"].ToString());
                subjectLevel.Parts = data["Parts"].ToString();
                subjectLevel.Code = data["Code"].ToString();
                subjectLevel.Level = data["Level"].ToString();
                subjectLevel.Instruction = data["Instruction"].ToString();
            }

            this.ResetConnections();
            return subjectLevel;
        }

        public void AddQuestion(SubjectLevel subject)
        {
            this._Query = "insert into [QAKeys]([SubjectLevelID], [Question], [Answer])Values" +
                "(@SubjectLeveID, @Question, @Answer)";

            this.Parameters.Add(subject.LevelID.ToString());
            this.Parameters.Add(subject.QuestionAnswer[0].Question);
            this.Parameters.Add(subject.QuestionAnswer[0].Answer);

            this.ModifyData();
            this.ResetConnections();
        }

        public void UpdateQuestion(QA questionAsnwer)
        {
            this._Query = "update [QAKeys] set [QuestionNumber]=@QuestionNumber, [Question]=@Question, [Answer]=@Answer " +
                "where QAID=@ID";

            this.Parameters.Add(questionAsnwer.QuestionNumber.ToString());
            this.Parameters.Add(questionAsnwer.Question);
            this.Parameters.Add(questionAsnwer.Answer);
            this.Parameters.Add(questionAsnwer.ID.ToString());

            this.ModifyData();
            this.ResetConnections();
        }

        public void DeleteQuestion(QA questionAnswer)
        {
            this._Query = "delete from [QAKeys] where [QAID] = @QAID";
            this.Parameters.Add(questionAnswer.ID.ToString());

            this.ModifyData();
            this.ResetConnections();
        }

        public bool CheckAnswer(QA answer)
        {
            bool result = false;
            this._Query = "select * from [QASubjectDetails] where [QAID] = @QAID and [Answer] = @Answer";
            this.Parameters.Add(answer.ID.ToString());
            this.Parameters.Add(answer.Answer.ToString());

            var data = this.FetchData();
            if (data.Read() == true)
            {
                string correctAnswer = data["Answer"].ToString();
                string givenAnswer = answer.Answer.ToString();

                bool IsCorrect = string.Equals(correctAnswer, givenAnswer, StringComparison.Ordinal);

                result = IsCorrect == true ? true : false;
            }

            this.ResetConnections();
            return result;
        }

    }
}
