using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Rock,
            Jazz,
            HipHop,
            Rap,
            HeavyMetal
            
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string description, string length, string rating, Genre genre)
            {
                Title = title;
                Artist = description;
                Album = rating;
                Length = length;
                Genre = genre;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength" + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the song title?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempDescription = Console.ReadLine();
            Console.WriteLine("What album is it on?");
            string tempRating = Console.ReadLine();
            Console.WriteLine("What is the song length?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("A - Rock\nH - Jazz\nS - HipHop\nR - Rap\nD - Heavy Metal");
            Genre tempGenre = Genre.Rock;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'A':
                    tempGenre = Genre.Rock;
                    break;
                case 'H':
                    tempGenre = Genre.Jazz;
                    break;
                case 'S':
                    tempGenre = Genre.HipHop;
                    break;
                case 'R':
                    tempGenre = Genre.Rap;
                    break;
                case 'D':
                    tempGenre = Genre.HeavyMetal;
                    break;
            }

            Music myMusic = new Music(tempTitle, tempDescription, tempLength, tempRating, tempGenre);
            Music newMusic = myMusic;
            newMusic.setArtist("Metallica");
            newMusic.setTitle("Master Of Puppets");
            Console.WriteLine("Here's movie #2");
            Console.WriteLine($"{newMusic.Display()}");
            Console.WriteLine();
            Console.WriteLine("Here's movie #1");
            Console.WriteLine($"{myMusic.Display()}");
        }
    }
}
