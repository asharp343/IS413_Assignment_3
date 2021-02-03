using System;
using System.Collections.Generic;

namespace IS413_Assignment_3.Models
{
    public static class TempStorage
    {
        private static List<MovieInfo> movies = new List<MovieInfo>();

        public static IEnumerable<MovieInfo> Movies => movies;

        public static void AddMovie(MovieInfo movie)
        {
            movies.Add(movie);
        }
    }
}
