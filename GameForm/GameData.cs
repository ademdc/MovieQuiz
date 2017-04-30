
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForm
{
    class GameData
    {
       public const int NUM_OF_QUESTIONS = 10;
        public static final int NUM_OF_PLAYERS = 4;
       private Random rnd;
       private int randomNo;
        private int point1;
        private int point2;
        private MoviRESTService title1;
        private MoviRESTService title2;
        private QuestionIMDB imdbQ;
        private QuestionActor actorQ;
        private QuestionOlder olderQ;
        private QuestionOscar oscarQ;
        private QuestionLength lengthQ;
        private QuestionGenre genreQ;
        private LinkedList<string> list = new LinkedList<string>();

        public GameData()
        {
            rnd = new Random();
            point1 = 0;
            point2 = 0;
            imdbQ = new QuestionIMDB();
            actorQ = new QuestionActor();
            olderQ = new QuestionOlder();
            oscarQ = new QuestionOscar();
            lengthQ = new QuestionLength();
        }

        public string generateQuestion()
        {
            randomNo = rnd.Next(1, 7);

            string question="";
            switch (randomNo)
            {
                case 1:
                    question = imdbQ.getQuestion();
                    break;
                case 2:
                    question = lengthQ.getQuestion();
                    break;
                case 3:
                    question = olderQ.getQuestion();
                    break;
                case 4:
                    question = oscarQ.getQuestion();
                    break;
                case 5:
                    question = actorQ.getQuestion();
                    break;
                case 6:
                    genreQ = new QuestionGenre();
                    question = genreQ.getQuestion();
                    break;
                default:
                    question = "An error occured";
                    break;

            }
            return question;
        }

        public int getRandomNo()
        {
            return randomNo;
        }

        public int addPoint1()
        {
            return point1++;
        }

        public int addPoint2()
        {
            return point2++;
        }

        public string evaluateIMDB(string movie1, string movie2)
        {
            string result = "";
            title1 = new MoviRESTService(movie1);
            title2 = new MoviRESTService(movie2);

            double imdb1, imdb2;
            imdb1 = title1.getRating();
            imdb2 = title2.getRating();

            if (imdb1 > imdb2) {
                result = "Player 1 wins" + ", imdb score of his movie " + movie1 + " is " + imdb1;
                addPoint1();
            }

            else {
                result = "Player 2 wins" + ", imdb score of his movie is " + movie2 + " is " + imdb2;
                addPoint2();
            }
 
            return result;
        }

        public string evaluateOlder(string movie1, string movie2)
        {
            string result = "";
            title1 = new MoviRESTService(movie1);
            title2 = new MoviRESTService(movie2);

            double year1, year2;
            year1 = title1.getYear();
            year2 = title2.getYear();

            if (year1 < year2)
            {
                result = "Player 1 wins" + ", year when his movie " + movie1 + " was released is " + year1;
                addPoint1();
            }

            else {
                result = "Player 1 wins" + ", year when his movie " + movie2 + " was released is " + year2;
                addPoint2();
            }
            return result;
        }

        public string evaluateLenght(string movie1, string movie2)
        {
            
            string result = "";
            title1 = new MoviRESTService(movie1);
            title2 = new MoviRESTService(movie2);

            double length1, length2;
            length1 = title1.getlength();
            length2 = title2.getlength();

            if (length1 > length2)
            {
                result = "Player 1 wins" + ", movie length of his movie " + movie1 + " is " + length1;
                addPoint1();
            }

            else {
                result = "Player 2 wins" + ", movie length of his movie is " + movie2 + " is " + length2;
                addPoint2();
            }
            return result;
        }

        public string evaluateOscar(string movie1, string movie2)
        {
            string result = "";
            title1 = new MoviRESTService(movie1);
            title2 = new MoviRESTService(movie2);

            double oscar1, oscar2;
            oscar1 = title1.getOscarNo();
            oscar2 = title2.getOscarNo();

            if (oscar1 > oscar2)
            {
                result = "Player 1 wins" + ", his movie " + movie1 + " has won more oscars: " + oscar1;
                addPoint1();
            }

            else if (oscar1<oscar2)
            {
                result = "Player 2 wins" + ", his movie " + movie2 + " has won more oscars " + oscar2;
                addPoint2();
            }
            else
            {
                result = "Both movies have " + oscar1+" oscars, no points";
            }
     
            return result;
        }

        public string evaluateActor(string movie1, string movie2)
        {
            string result = "";
            title1 = new MoviRESTService(movie1);
            title2 = new MoviRESTService(movie2);

            string actor1, actor2;
            actor1 = title1.getActors();
            actor2 = title2.getActors();

            if (actor1.Contains(actorQ.getActor()) && actor2.Contains(actorQ.getActor())
            {
                result = "Both players movies " + movie1 + " and "+movie2+", have the actor " + actorQ.getActor();
                addPoint1();
                addPoint2();
            }
            else if (actor2.Contains(actorQ.getActor()))
            {
                result = "Player 1's movie " + movie1 + ", has the actor " + actorQ.getActor();
                addPoint1();
            }

            else if (actor1.Contains(actorQ.getActor()))
            {
                result = "Player 2's movie " + movie1 + ", has the actor " + actorQ.getActor();
                addPoint2();
            }

            return result;
        }

        public string evaluateGenre(string movie1, string movie2)
        {
            string result = "";
            title1 = new MoviRESTService(movie1);
            title2 = new MoviRESTService(movie2);

            string genre1, genre2;
            genre1 = title1.getGenre();
            genre2 = title2.getGenre();

            if (title1.getGenre().Contains(genreQ.getGenre()) && title2.getGenre().Contains(genreQ.getGenre()))
            {
                result = "Both player's movies:" + movie1 +" and "+movie2+ ", are of the genre " + genreQ.getGenre();
                addPoint1();
                addPoint2();
            }
            else if (title1.getGenre().Contains(genreQ.getGenre()))
            {
                result = "Player 1's movie " + movie1 + ", is of the genre " + genreQ.getGenre();
                addPoint1();
            }
            else if (title2.getGenre().Contains(genreQ.getGenre()))
            {
                result = "Player 2's movie " + movie2 + ", is of the genre " + genreQ.getGenre();
                addPoint2();
            }
            

            return result;
        }

        public int getPoint1()
        {
            return point1;
        }

        public int getPoint2()
        {
            return point2;
        }
        /*
        public void fetchPhoto1(PictureBox p1)
        {
            string url = title1.getImageURL();
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())

            using (var stream = response.GetResponseStream())

            {
             // p1.Image = Bitmap.FromStream(stream);
            }
        }

        public void fetchPhoto2(PictureBox p1)
        {
           string url = title2.getImageURL();
            var request = WebRequest.Create(url);
            using (var response = request.GetResponse())

            using (var stream = response.GetResponseStream())

            {
                //p1.Image = Bitmap.FromStream(stream);
            }
        }
        */
        public bool isEnd()
        {
            if ((getPoint1() + getPoint2()) > NUM_OF_QUESTIONS)
                return true;

            return false;
        }

        public bool checkSameMovie(string movie1, string movie2)
        {
            if (list.Contains(movie1) || list.Contains(movie2))
                return true;
            else
            {
                list.AddFirst(movie1);
                list.AddFirst(movie2);
            }
            return false;
        }
    }
}
