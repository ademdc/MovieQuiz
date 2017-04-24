using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForm
{
    class QuestionActor : Question
    {
        private string actor;
        public QuestionActor()
        {
            actor = "Leonardo DiCaprio";
            question = "Name a movie in which "+ actor +" plays one of the leading roles";
        }
        public string getQuestion()
        {
            return question;
        }
    }
}
