using System;
using System.IO;
using System.Collections.Generic;

namespace atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = "";
            string[] linhaseparada = null;
            int i = 0;
            StreamReader reader = new StreamReader("dados.csv");
            List<Movies> moviesList = new List<Movies>();

            while (true)
            {
                if(i == 0) {
                    i++;
                    continue;
                }

                linha = reader.ReadLine();

                if (linha == null) break;

                linhaseparada = linha.Split(';');

                Movies movies = new Movies();
                movies.color = linhaseparada[0];
                movies.director_name = linhaseparada[1];
                movies.num_critic_for_reviews = linhaseparada[2];

                if (! Int32.TryParse(linhaseparada[3], out movies.duration)) {
                    movies.duration = 0;
                }

                movies.director_facebook_likes = linhaseparada[4];
                movies.actor_3_facebook_likes = linhaseparada[5];
                movies.actor_2_name = linhaseparada[6];
                movies.actor_1_facebook_likes = linhaseparada[7];
                movies.gross = linhaseparada[8];
                movies.genres = linhaseparada[9];
                movies.actor_1_name = linhaseparada[10];
                movies.movie_title = linhaseparada[11];
                movies.num_voted_users = linhaseparada[12];
                movies.cast_total_facebook_likes = linhaseparada[12];
                movies.actor_3_name = linhaseparada[13];
                movies.facenumber_in_poster = linhaseparada[14];
                movies.plot_keywords = linhaseparada[15];
                movies.movie_imdb_link = linhaseparada[16];
                movies.num_user_for_reviews = linhaseparada[17];
                movies.language = linhaseparada[18];
                movies.country = linhaseparada[19];
                movies.content_rating = linhaseparada[20];
                movies.budget = linhaseparada[21];
                movies.title_year = linhaseparada[22];
                movies.actor_2_facebook_likes = linhaseparada[23];
                movies.imdb_score = linhaseparada[24];
                movies.aspect_ratio = linhaseparada[25];
                movies.movie_facebook_likes = linhaseparada[26];

                moviesList.Add(movies);
            }

            i = 0;

            int blackWhite = 0, maiorDuracao = 0, menorDuracao = 0;
            String nomeMaiorDuracao = "";
            String nomeMenorDuracao = "";

            foreach(Movies m in moviesList) {
                if(i == 0) {
                    maiorDuracao = m.duration;
                    menorDuracao = m.duration;
                }

                System.Console.WriteLine(menorDuracao);

                if(m.color.Trim() == "Black and White") {
                    blackWhite++;
                }

                if(maiorDuracao < m.duration) {
                    maiorDuracao = m.duration;
                    nomeMaiorDuracao = m.movie_title;
                }

                if(menorDuracao > m.duration) {
                    menorDuracao = m.duration;
                    nomeMenorDuracao = m.movie_title;
                }

                i++;
            }

            Console.WriteLine("Preto e branco: " + blackWhite);
            System.Console.WriteLine("Maior duração: " + nomeMaiorDuracao);
            System.Console.WriteLine("Menor duração: " + nomeMenorDuracao);

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
        public string num_voted_users;
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
