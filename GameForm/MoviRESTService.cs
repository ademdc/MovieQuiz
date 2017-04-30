using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForm
{
    class MoviRESTService
    {
        private WebClient client;
        private string jsonString;
        private JObject json;
        private string movieTitle;
        private double imdbRating;
        private double imdbVotes;
        private double movieLength;
        private string imageURL;
        private double oscarNo;
        private double year;
        private string genre;

public string getActors()
        {
            return genre = (String)json["Actors"];
        }        public MoviRESTService() {
        }

        public MoviRESTService(string title)
        {
            client = new WebClient();
            jsonString = client.DownloadString("http://www.omdbapi.com/?t=" + title);
            json = JObject.Parse(jsonString);

        }


        public string getTitle()
        {
            movieTitle = (String)json["Title"];
            return movieTitle;
        }
        public double getRating()
        {
            return imdbRating = (Double)json["imdbRating"];
        }

        public double getVotes()
        {
            return imdbVotes = (Double)json["imdbVotes"];
        }

        public double getlength()
        {
            return movieLength = Convert.ToDouble(((String)json["Runtime"]).Replace(" min", ""));
        }

        public string getImageURL()
        {
            return imageURL = (String)json["Poster"];
        }
        public double getOscarNo()
        {
            string oscarNoString = (String)json["Awards"];
            if (oscarNoString[0]!='W' && oscarNoString[0] != 'w')
                return 0;
            else
            {
                Regex r = new Regex("Won(.*?)Oscar");
                var res = r.Match(oscarNoString);

                oscarNoString = Convert.ToString(res);
                oscarNoString = oscarNoString.Replace("Won", "");
                oscarNoString = oscarNoString.Replace("Oscar", "");
                oscarNoString = oscarNoString.Replace("Oscars", "");

               oscarNo = Convert.ToDouble(oscarNoString);
                
            }
            return oscarNo;
        }
        public double getYear()
        {
            return year = (Double)json["Year"];
        }

        public string getGenre()
        {
            return genre = (String)json["Genre"];
        }
        public string getActors()
        {
            return genre = (String)json["Actors"];
        }
    }
}
