namespace MusicStore.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        ICollection<Album> Albums { get; set; }
    }
}
