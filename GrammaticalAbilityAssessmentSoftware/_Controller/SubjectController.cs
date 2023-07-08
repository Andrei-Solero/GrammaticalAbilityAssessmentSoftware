using GAASBusinessLogicLibrary;
using GAASBusinessLogicLibrary._Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammaticalAbilityAssessmentSoftware._Controller
{
    public class SubjectController
    {
        SubjectLevelRepo levelRepo;
        SubjectQuestionRepo questionRepo;
        public List<SubjectLevel> GetSubjectLevel()
        {
            levelRepo = new SubjectLevelRepo();
            var levels = levelRepo.Get();

            return levels;
        }

        public void AddLevel(SubjectLevel level)
        {
            levelRepo = new SubjectLevelRepo();
            levelRepo.AddSubject(level);
        }

        public void UpdateLevel(SubjectLevel level)
        {
            levelRepo = new SubjectLevelRepo();
            levelRepo.EditSubject(level);
        }

        public SubjectLevel GetSubjectQuestions(SubjectLevel subject)
        {
            questionRepo = new SubjectQuestionRepo();
            var questions = questionRepo.GetQuestions(subject, true);

            return questions;
        }

        public SubjectLevel GetSortedSubjectQuestions(SubjectLevel subject)
        {
            questionRepo = new SubjectQuestionRepo();
            var questions = questionRepo.GetQuestions(subject, true);

            return questions;
        }

        public void AddQuestion(SubjectLevel level)
        {
            questionRepo = new SubjectQuestionRepo();
            questionRepo.AddQuestion(level);
        }

        public void ModifyQuestion(QA level)
        {
            questionRepo = new SubjectQuestionRepo();
            questionRepo.UpdateQuestion(level);
        }

        public void DeleteQuestion(QA level)
        {
            questionRepo = new SubjectQuestionRepo();
            questionRepo.DeleteQuestion(level);
        }

        public void DeleteSubjectData(SubjectLevel level)
        {
            levelRepo = new SubjectLevelRepo();
            levelRepo.DeleteSubjectsAndQuestions(level);
        }

        public bool CheckAnswer(QA answer)
        {
            questionRepo = new SubjectQuestionRepo();
            var result = questionRepo.CheckAnswer(answer);
            return result;
        }

        public void DeleteAllQuestions(SubjectLevel subject)
        {
            levelRepo = new SubjectLevelRepo();
            levelRepo.DeleteSubjectQuestions(subject);
        }

    }
}
