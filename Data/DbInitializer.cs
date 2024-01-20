using RelationsNaN.Models;

namespace RelationsNaN.Data
{
    public class DbInitializer
    {
        protected RelationsNaNContext _context;

        public DbInitializer(RelationsNaNContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            if(_context.Game.Count() == 0)
            {
                Game game1 = new Game()
                {
                    Id = 1,
                    Name = "Super Smash Bros.",
                    ReleaseYear = 1999,
                    Image = "https://en.wikipedia.org/wiki/Super_Smash_Bros._(video_game)#/media/File:Supersmashbox.jpg"
                };
                _context.Game.Add(game1);

                Game game2 = new Game()
                {
                    Id = 2,
                    Name = "Super Smash Bros. Ultimate",
                    ReleaseYear = 2015,
                    Image = "https://en.wikipedia.org/wiki/Super_Smash_Bros._Ultimate#/media/File:Super_Smash_Bros._Ultimate.jpg"
                };
                _context.Game.Add(game2);

                Game game3 = new Game()
                {
                    Id = 2,
                    Name = "Super Smash Bros. Ultimate",
                    ReleaseYear = 2015,
                    Image = "https://en.wikipedia.org/wiki/Super_Smash_Bros._Ultimate#/media/File:Super_Smash_Bros._Ultimate.jpg"
                };
                _context.Game.Add(game3);

                Game game4 = new Game()
                {
                    Id = 3,
                    Name = "GoldenEye 007",
                    ReleaseYear = 1997,
                    Image = "https://en.wikipedia.org/wiki/GoldenEye_007_(1997_video_game)#/media/File:GoldenEye007box.jpg"
                };
                _context.Game.Add(game4);

                Game game5 = new Game()
                {
                    Id = 3,
                    Name = "GoldenEye 007",
                    ReleaseYear = 1997,
                    Image = "https://en.wikipedia.org/wiki/GoldenEye_007_(1997_video_game)#/media/File:GoldenEye007box.jpg"
                };
                _context.Game.Add(game5);
            }
        }
    }
}
