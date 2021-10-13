using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandBioXp
{
    public class Films
    {
        public string Title { get; set; }
        public string Sal { get; set; }
        public TimeSpan Duration { get; set; }
        public List<DateTime> PlayDates { get; set; }

        public Films(string title, string sal, TimeSpan duration, List<DateTime> playDates)
        {
            Title = title;
            Sal = sal;
            Duration = duration;
            PlayDates = playDates;
        }

        public Films()
        {
            
        }

        private static List<Films> AllFilms = new List<Films>()
        {
            new Films("film 1", "1", TimeSpan.FromHours(1.5), new List<DateTime>() { DateTime.Today, DateTime.Today.AddDays(2) }),
            new Films("film 2", "2", TimeSpan.FromHours(1), new List<DateTime>() { DateTime.Today, DateTime.Today.AddDays(5) }),
            new Films("film 3", "3", TimeSpan.FromHours(2), new List<DateTime>() { DateTime.Today, DateTime.Today.AddDays(7) })
        };
        

        public List<Films> GetAll()
        {
            return AllFilms;
        }

        public List<Films> GetFromDate(DateTime date)
        {
            List<Films> tempFilms = new List<Films>();
            foreach (var film in AllFilms)
            {
                foreach (var x in film.PlayDates)
                {
                    if (x == date)
                    {
                        tempFilms.Add(film);
                    }
                }
            }

            return tempFilms;
        }

        public List<DateTime> CheckDates(string DT)
        {
            List<DateTime> dateFilms = new List<DateTime>();
            foreach (var films in AllFilms)
            {
                if (DT == films.Title)
                {
                    foreach (var date in films.PlayDates)
                    {
                        dateFilms.Add(date);
                    }
                }
            }

            return dateFilms;
        }

        public bool Create(Films film)
        {
            int counter = AllFilms.Count;
            AllFilms.Add(film);
            if (counter + 1 == AllFilms.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public Films Delete(string title)
        {
            foreach (var film in AllFilms)
            {
                if (film.Title == title)
                {
                    Films savedFilm = film;
                    AllFilms.Remove(film);
                    return savedFilm;
                }
            }

            return null;
        }
    }
}
