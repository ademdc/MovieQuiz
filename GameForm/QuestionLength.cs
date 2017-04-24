using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForm
{
    class QuestionLength : Question
    {
        public QuestionLength()
        {
            question = "Name a movie that lasts longer";
        }
        public string getQuestion()
        {
            return question;
        }
    }
}
