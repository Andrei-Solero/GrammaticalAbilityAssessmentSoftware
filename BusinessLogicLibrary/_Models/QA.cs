using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASBusinessLogicLibrary._Models
{
    public class QA
    {
        public int ID { get; set; }
        public int QuestionNumber { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string CorrectAnswer { get; set; }
        public string? Result { get; set; }
    }
}
