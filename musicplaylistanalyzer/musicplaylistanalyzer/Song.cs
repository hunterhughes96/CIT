using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicplaylistanalyzer
{
    public class Song
    {
        private string _name;
        private string _artist;
        private string _album;
        private string _genre;
        private int _size;
        private int _time;
        private int _year;
        private int _plays;

        public Song(string name, string artist, string album, string genre, int size, int time, int year, int plays)
        {
            Name = name;
            Artist = artist;
            Album = album;
            Genre = genre;
            Size = size;
            Time = time;
            Year = year;
            Plays = plays;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string Artist
        {
            get { return _artist; }
            set
            {
                _artist = value;
            }
        }

        public string Album
        {
            get { return _album; }
            set
            {
                _album = value;
            }
        }

        public string Genre
        {
            get { return _genre; }
            set
            {
                _genre = value;
            }
        }

        public int Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }

        public int Time
        {
            get { return _time; }
            set
            {
                _time = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
            }
        }

        public int Plays
        {
            get { return _plays; }
            set
            {
                _plays = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Artist: {1}, Album: {2}, Genre: {3}, Size: {4}, Time: {5}, Year: {6}, Plays: {7}", Name, Artist, Album, Genre, Size, Time, Year, Plays);
        }






    }
}
