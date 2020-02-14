using System;
using System.IO;
using System.Collections.Generic;
using System.ServiceModel;

namespace atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            string[] lineSplit = null;
            int i = 0;
            StreamReader reader = new StreamReader("dados.csv");
            List<Movies> moviesList = new List<Movies>();

            while (true)
            {
                if(i == 0) {
                    i++;
                    continue;
                }

                line = reader.ReadLine();

                if (line == null) break;

                lineSplit = line.Split(';');

                Movies movies = new Movies();
                movies.color = lineSplit[0];
                movies.director_name = lineSplit[1];
                movies.num_critic_for_reviews = lineSplit[2];

                if (! Int32.TryParse(lineSplit[3], out movies.duration)) {
                    //removido para não atrapalhar nas comparações
                    continue;
                }

                movies.director_facebook_likes = lineSplit[4];
                movies.actor_3_facebook_likes = lineSplit[5];
                movies.actor_2_name = lineSplit[6];
                movies.actor_1_facebook_likes = lineSplit[7];
                movies.gross = lineSplit[8];
                movies.genres = lineSplit[9];
                movies.actor_1_name = lineSplit[10];
                movies.movie_title = lineSplit[11];

                if(! Int32.TryParse(lineSplit[12], out movies.num_voted_users)) {
                    movies.num_voted_users = 0;
                }

                movies.cast_total_facebook_likes = lineSplit[12];
                movies.actor_3_name = lineSplit[13];
                movies.facenumber_in_poster = lineSplit[14];
                movies.plot_keywords = lineSplit[15];
                movies.movie_imdb_link = lineSplit[16];
                movies.num_user_for_reviews = lineSplit[17];
                movies.language = lineSplit[18];
                movies.country = lineSplit[19];
                movies.content_rating = lineSplit[20];
                movies.budget = lineSplit[21];
                movies.title_year = lineSplit[22];
                movies.actor_2_facebook_likes = lineSplit[23];
                movies.imdb_score = lineSplit[24];
                movies.aspect_ratio = lineSplit[25];
                movies.movie_facebook_likes = lineSplit[26];

                moviesList.Add(movies);
            }

            i = 0;

            int blackWhite = 0, count =0; maxDuration, minDuration, maxVotes, minVotes;
            String nameMaxDuration, nameMinDuration, nameMaxVotes, nameMinVotes;

            //Dictionary<string, int> directors = new Dictionary<string, int>();



            minDuration = moviesList[0].duration;
            maxDuration = moviesList[0].duration;
            nameMaxDuration = moviesList[0].movie_title;
            nameMinDuration = moviesList[0].movie_title;
            maxVotes = moviesList[0].num_voted_users;
            minVotes = moviesList[0].num_voted_users;
            nameMaxVotes = moviesList[0].movie_title;
            nameMinVotes = moviesList[0].movie_title;


            foreach (Movies m in moviesList) {
                if (m.color.Trim() == "Black and White") {
                    blackWhite++;
                }

                if (maxDuration < m.duration) {
                    maxDuration = m.duration;
                    nameMaxDuration = m.movie_title;
                }

                if (minDuration > m.duration) {
                    minDuration = m.duration;
                    nameMinDuration = m.movie_title;
                }

                if (maxVotes < m.num_voted_users) {
                    maxVotes = m.num_voted_users;
                    nameMaxVotes = m.movie_title;
                }

                if (minVotes > m.num_voted_users) {
                    minVotes = m.num_voted_users;
                    nameMinVotes = m.movie_title;
                }

            }

            Console.WriteLine("Preto e branco: " + blackWhite);
            System.Console.WriteLine("Maior duração: " + nameMaxDuration);
            System.Console.WriteLine("Menor duração: " + nameMinDuration);
            System.Console.WriteLine("Mais votos: " + nameMaxVotes);
            System.Console.WriteLine("Menos votos: " + nameMinVotes);

            Console.ReadKey();
        }
    }

    public struct Movies {
        public string color;
        public string director_name;
        public string num_critic_for_reviews;
        public int duration;
        public string director_facebook_likes;
        public string actor_3_facebook_likes;
        public string actor_2_name;
        public string actor_1_facebook_likes;
        public string gross;
        public string genres;
        public string actor_1_name;
        public string movie_title;
        public int num_voted_users;
        public string cast_total_facebook_likes;
        public string actor_3_name;
        public string facenumber_in_poster;
        public string plot_keywords;
        public string movie_imdb_link;
        public string num_user_for_reviews;
        public string language;
        public string country;
        public string content_rating;
        public string budget;
        public string title_year;
        public string actor_2_facebook_likes;
        public string imdb_score;
        public string aspect_ratio;
        public string movie_facebook_likes;
    }
}
