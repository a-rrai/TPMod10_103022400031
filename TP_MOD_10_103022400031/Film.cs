namespace TP_MOD_10_103022400031.Models
{
    public class Film
    {
        public string Judul { get; set; }
        public string Sutradara { get; set; }
        public string Tahun { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }

        public Film() { }

        public Film(string judul, string sutradara, string tahun, string genre, string rating)
        {
            Judul = judul;
            Sutradara = sutradara;
            Tahun = tahun;
            Genre = genre;
            Rating = rating;
        }
    }
}
