using DataAccessLibrary;
using GAASBusinessLogicLibrary._Models;

namespace GAASBusinessLogicLibrary
{
    public class SubjectLevelRepo : Repository
    {
        public List<SubjectLevel> Get()
        {
            List<SubjectLevel> subjectLevel = new List<SubjectLevel>();
            this._Query = "select * from SubjectLevel order by [Level] asc";

            var data = FetchData();

            while (data.Read())
            {
                subjectLevel.Add(new SubjectLevel
                {
                    LevelID = int.Parse(data["LevelID"].ToString()),
                    Level = data["Level"].ToString(),
                    Parts = data["Parts"].ToString(),
                    Code = data["Code"].ToString(),
                    Weight = decimal.Parse(data["Weight"].ToString()),
                    Instruction = data["Instruction"].ToString()
                });
            }

            this.ResetConnections();

            return subjectLevel;
        }

        public void AddSubject(SubjectLevel subject)
        {
            this._Query = "insert into [SubjectLevel]([Level], [Parts], [Code], [Weight], [Instruction])Values" +
                "(@Level, @Parts, @Code, @Weight, @Instruction)";

            this.Parameters.Add(subject.Level.ToString());
            this.Parameters.Add(subject.Parts.ToString());
            this.Parameters.Add(subject.Code.ToString());
            this.Parameters.Add(subject.Weight.ToString());
            this.Parameters.Add(subject.Instruction.ToString());

            this.ModifyData();
            this.ResetConnections();
        }

        public void EditSubject(SubjectLevel subject)
        {
            this._Query = "update [SubjectLevel] set " +
                "[Level]=@Level, [Parts]=@Parts, [Code]=@Code, Weight=@Weight, [Instruction]=@Instruction " +
                "where [LevelID]=@LevelID";

            this.Parameters.Add(subject.Level.ToString());
            this.Parameters.Add(subject.Parts.ToString());
            this.Parameters.Add(subject.Code.ToString());
            this.Parameters.Add(subject.Weight.ToString());
            this.Parameters.Add(subject.Instruction.ToString());
            this.Parameters.Add(subject.LevelID.ToString());

            this.ModifyData();
            this.ResetConnections();
        }

        public void DeleteSubjectsAndQuestions(SubjectLevel subjectData)
        {
            this._Query = "delete from SubjectLevel where [LevelID] = @LevelID";
            this.Parameters.Add(subjectData.LevelID.ToString());

            this.ModifyData();
            this.ResetConnections();


            this._Query = "delete from QAKeys where [SubjectLevelID] = @LevelID";
            this.Parameters.Add(subjectData.LevelID.ToString());

            this.ModifyData();
            this.ResetConnections();
        }

        public void DeleteSubjectQuestions(SubjectLevel subject)
        {
            this._Query = "delete from QAKeys where [SubjectLevelID] = @LevelID";
            this.Parameters.Add(subject.LevelID.ToString());

            this.ModifyData();
            this.ResetConnections();
        }


    }
}