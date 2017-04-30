using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForm
{
    class QuestionActor : Question
    {
        private string genre;
        private Random rnd;
        private int random;

        public QuestionGenre()
        {
            rnd = new Random();
            random = rnd.Next(1, 6);

            switch (random)
            {
                case 1:
                    genre = "Action";
                    break;
                case 2:
                    genre = "Drama";
                    break;
                case 3:
                    genre = "Horror";
                    break;
                case 4:
                    genre = "Romance";
                    break;
                case 5:
                    genre = "Comedy";
                    break;
                default:
                    question = "An error occured";
                    break;

            }
            question = "Name a movie of the following genre " + genre;
        }
        public string getQuestion()
        {
            return question;
        }
        public string getGenre()
        {
            return genre;
        }
     }
}
