using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForm
{
    class QuestionOscar : Question 
    {
        public QuestionOscar()
        {
            question = "Name a movie that has won more oscars";
        }
        public string getQuestion()
        {
            return question;
        }
    }
}
