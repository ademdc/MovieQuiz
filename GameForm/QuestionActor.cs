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
        private int numOfActor = 10;

        private string actor;
        public QuestionActor()
        {
            rnd = new Random();
            random = rnd.Next(1, numOfActor);

            switch (random)
            {
                case 1:
                    actor = "Leonardo Di Caprio";
                    break;
                case 2:
                    actor = "Morgan Freeman";
                    break;
                case 3:
                    actor = "Angelina Jolie";
                    break;
                case 4:
                    actor = "Nicole Kidman";
                    break;
                case 5:
                    actor = "Mat Deamon";
                    break;
                case 6:
                    actor = "Mila Kunis";
                    break;
                case 7:
                    actor = "Russel Crow";
                    break;
                case 8:
                    actor = "Dominic Purcel";
                    break;
                case 9:
                    actor = "Emilia Clark";
                    break;
                case 10:
                    actor = "Emma Watson";
                    break;
                default:
                    actor = "An error occured";
                    break;
            }
            question = "Name a movie in which " + actor + " plays one of the leading roles";

        }
        public string getQuestion()
        {
            return question;
        }
        public string getActor()
        {
            return actor;
        }
    }
}
