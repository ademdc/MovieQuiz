using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForm
{
    class QuestionOlder : Question
    {
        public QuestionOlder()
        {
            question = "Name a movie that is older";
        }
        public string getQuestion()
        {
            return question;
        }
    }
}
