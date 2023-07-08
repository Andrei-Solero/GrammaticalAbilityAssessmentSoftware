using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASBusinessLogicLibrary._Models
{
    public class FrequencyErrorCount : SubjectLevel
    {
        public int ErrorCount { get; set; }
        public decimal TransmutedError { get; set; }
    }
}
