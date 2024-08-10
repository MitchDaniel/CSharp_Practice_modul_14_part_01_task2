using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;



namespace Task2
{
    [JsonObject]
    internal class Album 
    {
        List<Song> _songs = new List<Song>();

        public Album() {    }

        public List<Song> Songs 
        {
            get {  return _songs; }
            set { _songs = value; } 
        }

        public Album(string name, string autorName, int year, TimeOnly duration, string studio)
        {
            Name = name;
            AuthorName = autorName;
            Year = year;
            Duration = duration;
            Studio = studio;
        }

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public int Year { get; set; }

        public string Studio { get; set; }

        TimeOnly _duration;

        public TimeOnly Duration
        {
            get
            {
                _duration = new TimeOnly(0, 0, 0);
                foreach (var song in _songs)
                {
                    _duration = _duration.Add(song.Duration.ToTimeSpan());
                }
                return _duration;
            }
            set
            {
                _duration = value;
            }

        }

        public void Add(params Song[] songs)
        {
            if(songs is null) throw new ArgumentNullException(nameof(songs));
            _songs.AddRange(songs);
        }
    }
}

//1.Название альбома
//2. Название исполнителя
//3. Год выпуска
//4. Длительность
//5. Студия выпуска