﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimetable {
    public class MovieShow: IEquatable<MovieShow> {
        public Movie Movie { get; }
        public int Hall { get; }

        public TimeSpan TimeOfDay { get; }
        public DayOfWeek DayOfWeek { get; }
         

        public MovieShow(Movie movie, TimeSpan timeOfDay, DayOfWeek dayOfWeek, int hall) {
            Movie = movie;
            TimeOfDay = timeOfDay;
            DayOfWeek = dayOfWeek;
            Hall = hall;
        }

        public bool Equals(MovieShow second) {
            if (second == null) {
                return false;
            }

            return 
                Movie == second.Movie && 
                TimeOfDay == second.TimeOfDay && 
                DayOfWeek == second.DayOfWeek && 
                Hall == second.Hall;
        }
    }
}
