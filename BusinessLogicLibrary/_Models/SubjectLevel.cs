using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASBusinessLogicLibrary._Models
{
    public class SubjectLevel
    {
        public int LevelID { get; set; }
        public string? Level { get; set; }
        public string? Parts { get; set; }
        public string? Code { get; set; }
        public List<QA>? QuestionAnswer { get; set; } = new List<QA>();
        public decimal Weight { get; set; }
        public string Instruction { get; set; }
    }
}
