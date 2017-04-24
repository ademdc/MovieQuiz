using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForm 
{
    class QuestionIMDB : Question
    {
        public QuestionIMDB()
        {
            question = "Name a movie that has a higher IMDB score";
        }
        public string getQuestion()
        {
            return question;
        }
    }
}
