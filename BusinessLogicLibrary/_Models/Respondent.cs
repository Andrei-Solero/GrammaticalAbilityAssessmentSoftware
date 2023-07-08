using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAASBusinessLogicLibrary._Models
{
    public class Respondent
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public QA? UserAnswer { get; set; }
    }
}
