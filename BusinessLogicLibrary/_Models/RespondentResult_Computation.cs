using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASBusinessLogicLibrary._Models
{
    public class RespondentResult_Computation : Respondent
    {
        public decimal TransmutedError { get; set; }
        public int TotalFrequencyOfError { get; set; }
        public string GrammarProficiencyScore { get; set; }
        public string GrammarProficiencyAverage { get; set; }
        public string GrammarProficiencyLevel { get; set; }
    }
}
