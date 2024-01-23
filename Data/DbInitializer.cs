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
                    Name = "Super Smash Bros.",
                    ReleaseYear = 1999,
                    Image = "https://en.wikipedia.org/wiki/Super_Smash_Bros._(video_game)#/media/File:Supersmashbox.jpg"
                };
                await _context.Game.AddAsync(game1);

                Game game2 = new Game()
                {
                    Name = "Super Smash Bros. Ultimate",
                    ReleaseYear = 2015,
                    Image = "https://en.wikipedia.org/wiki/Super_Smash_Bros._Ultimate#/media/File:Super_Smash_Bros._Ultimate.jpg"
                };
                await _context.Game.AddAsync(game2);

                Game game3 = new Game()
                {
                    Name = "GoldenEye 007",
                    ReleaseYear = 1997,
                    Image = "https://en.wikipedia.org/wiki/GoldenEye_007_(1997_video_game)#/media/File:GoldenEye007box.jpg"
                };
                await _context.Game.AddAsync(game3);

                await _context.SaveChangesAsync();
            }

            if (_context.Platform.Count() == 0)
            {
                Platform ps5 = new Platform()
                {
                    Name = "PS3"
                };
                await _context.Platform.AddAsync(ps5);

                Platform xbox360 = new Platform()
                {
                    Name = "Xbox 360"
                };
                await _context.Platform.AddAsync(xbox360);

                Platform n64 = new Platform()
                {
                    Name = "N64"
                };
                await _context.Platform.AddAsync(n64);

                await _context.SaveChangesAsync();
            }

            if (_context.Purchase.Count() == 0)
            {
                Purchase purchase = new Purchase()
                {
                    
                };
                await _context.Purchase.AddAsync(purchase);

                // On va chercher les 2 premiers jeux
                Game game1 = _context.Game.First(x => x.Id == 1);
                Game game2 = _context.Game.First(x => x.Id == 2);

                // Création d'une 1ere relation avec le premier jeu
                GamePurchase gamePurchase1 = new GamePurchase()
                {
                    Game = game1,
                    Purchase = purchase
                };
                await _context.AddAsync(gamePurchase1);

                // Création d'une 2e relation avec encore le premier jeu
                GamePurchase gamePurchase2 = new GamePurchase()
                {
                    Game = game1,
                    Purchase = purchase
                };
                await _context.AddAsync(gamePurchase2);

                // Création d'une 3e relation avec le deuxième jeu
                GamePurchase gamePurchase3 = new GamePurchase()
                {
                    Game = game2,
                    Purchase = purchase
                };
                await _context.AddAsync(gamePurchase3);

                // Création d'une 4e relation avec ENCORE le premier jeu
                GamePurchase gamePurchase4 = new GamePurchase()
                {
                    Game = game1,
                    Purchase = purchase
                };
                await _context.AddAsync(gamePurchase4);

                await _context.SaveChangesAsync();
            }
        }
    }
}
