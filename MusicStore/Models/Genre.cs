﻿namespace MusicStore.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        ICollection<Album> Albums { get; set; }
    }
}
