using DataAccessLibrary;
using GAASBusinessLogicLibrary._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GAASBusinessLogicLibrary
{
    public class ComputationRepo : Repository
    {
        public void Compute(int respondentID, bool IsForTotal, SubjectLevel currentSubject)
        {
            SubjectLevelRepo subjectRepo = new SubjectLevelRepo();

            if (IsForTotal == true)
            {
                var listSubjectWithWeights = subjectRepo.Get();
                foreach (var subject in listSubjectWithWeights)
                {
                    this._Query = "update [RespondentsFreqOfError] set [TransmutedError] = [FrequencyOfError] * @TransmutedError where RespondentID = @RespondentID and SubjectID = @SubjectID";
                    this.Parameters.Add(subject.Weight.ToString());
                    this.Parameters.Add(respondentID.ToString());
                    this.Parameters.Add(subject.LevelID.ToString());

                    this.ModifyData();
                    this.ResetConnections();
                }
            }
            else
            {
                this._Query = "update [RespondentsFreqOfError] set [TransmutedError] = [FrequencyOfError] * @TransmutedError where RespondentID = @RespondentID and SubjectID = @SubjectID";
                this.Parameters.Add(currentSubject.Weight.ToString());
                this.Parameters.Add(respondentID.ToString());
                this.Parameters.Add(currentSubject.LevelID.ToString());

                this.ModifyData();
                this.ResetConnections();
            }
        }

        public void ComputeProficiencyResult(RespondentResult_Computation resComputation)
        {
            this._Query = "insert into [GrammarProficiencyResult]" +
                "([RespondentID], [GrammarProficiencyScore], [GrammarProficiencyAverage], [GrammarProficiencyLevel])" +
                "values(@RespondentID, @GrammarProficiencyScore, @GrammarProficiencyAverage, @GrammarProficiencyLevel)";

            this.Parameters.Add(resComputation.ID.ToString());
            this.Parameters.Add(resComputation.GrammarProficiencyScore.ToString());
            this.Parameters.Add(resComputation.GrammarProficiencyAverage.ToString());
            this.Parameters.Add(resComputation.GrammarProficiencyLevel.ToString());

            this.ModifyData();
            this.ResetConnections();
        }

    }
}
