using PokemonBattleApi.Models;
using PokemonBattleApi.Enums;

namespace PokemonBattleApi.Data;


public static class FakeDatabase
{
    public static List<Pokemon> AvailablePokemons { get; } = new()
    {
        // Bulbasaur line
        new Pokemon(1, "Bulbasaur", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 200, 80),
        new Pokemon(2, "Ivysaur", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 280, 150),
        new Pokemon(3, "Venusaur", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 320, 300),

        // Charmander line
        new Pokemon(4, "Charmander", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 210, 80),
        new Pokemon(5, "Charmeleon", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 260, 150),
        new Pokemon(6, "Charizard", new List<EPokemonTypes>{ EPokemonTypes.Fire, EPokemonTypes.Flying }, 330, 300),

        // Squirtle line
        new Pokemon(7, "Squirtle", new List<EPokemonTypes>{ EPokemonTypes.Water }, 200, 80),
        new Pokemon(8, "Wartortle", new List<EPokemonTypes>{ EPokemonTypes.Water }, 280, 150),
        new Pokemon(9, "Blastoise", new List<EPokemonTypes>{ EPokemonTypes.Water }, 320, 300),

        // Caterpie line
        new Pokemon(10, "Caterpie", new List<EPokemonTypes>{ EPokemonTypes.Bug }, 100, 40),
        new Pokemon(11, "Metapod", new List<EPokemonTypes>{ EPokemonTypes.Bug }, 150, 60),
        new Pokemon(12, "Butterfree", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Flying }, 250, 200),

        // Weedle line
        new Pokemon(13, "Weedle", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Poison }, 100, 40),
        new Pokemon(14, "Kakuna", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Poison }, 150, 60),
        new Pokemon(15, "Beedrill", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Poison }, 250, 200),

        // Pidgey line
        new Pokemon(16, "Pidgey", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Flying }, 180, 70),
        new Pokemon(17, "Pidgeotto", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Flying }, 240, 140),
        new Pokemon(18, "Pidgeot", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Flying }, 300, 280),

        // Rattata line
        new Pokemon(19, "Rattata", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 120, 50),
        new Pokemon(20, "Raticate", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 220, 180),

        // Spearow line
        new Pokemon(21, "Spearow", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Flying }, 160, 70),
        new Pokemon(22, "Fearow", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Flying }, 270, 220),

        // Ekans line
        new Pokemon(23, "Ekans", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 180, 80),
        new Pokemon(24, "Arbok", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 290, 230),

        // Pikachu line
        new Pokemon(25, "Pikachu", new List<EPokemonTypes>{ EPokemonTypes.Electric }, 250, 120),
        new Pokemon(26, "Raichu", new List<EPokemonTypes>{ EPokemonTypes.Electric }, 310, 250),

        // Sandshrew line
        new Pokemon(27, "Sandshrew", new List<EPokemonTypes>{ EPokemonTypes.Ground }, 190, 90),
        new Pokemon(28, "Sandslash", new List<EPokemonTypes>{ EPokemonTypes.Ground }, 290, 240),

        // Nidoran♀ line
        new Pokemon(29, "Nidoran♀", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 200, 80),
        new Pokemon(30, "Nidorina", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 270, 150),
        new Pokemon(31, "Nidoqueen", new List<EPokemonTypes>{ EPokemonTypes.Poison, EPokemonTypes.Ground }, 330, 300),

        // Nidoran♂ line
        new Pokemon(32, "Nidoran♂", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 200, 80),
        new Pokemon(33, "Nidorino", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 270, 150),
        new Pokemon(34, "Nidoking", new List<EPokemonTypes>{ EPokemonTypes.Poison, EPokemonTypes.Ground }, 330, 300),

        // Clefairy line
        new Pokemon(35, "Clefairy", new List<EPokemonTypes>{ EPokemonTypes.Fairy }, 220, 100),
        new Pokemon(36, "Clefable", new List<EPokemonTypes>{ EPokemonTypes.Fairy }, 300, 260),

        // Vulpix line
        new Pokemon(37, "Vulpix", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 210, 90),
        new Pokemon(38, "Ninetales", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 310, 250),

        // Jigglypuff line
        new Pokemon(39, "Jigglypuff", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Fairy }, 230, 110),
        new Pokemon(40, "Wigglytuff", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Fairy }, 320, 280),

        // Zubat line
        new Pokemon(41, "Zubat", new List<EPokemonTypes>{ EPokemonTypes.Poison, EPokemonTypes.Flying }, 150, 60),
        new Pokemon(42, "Golbat", new List<EPokemonTypes>{ EPokemonTypes.Poison, EPokemonTypes.Flying }, 260, 220),

        // Oddish line
        new Pokemon(43, "Oddish", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 170, 70),
        new Pokemon(44, "Gloom", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 240, 140),
        new Pokemon(45, "Vileplume", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 310, 270),

        // Paras line
        new Pokemon(46, "Paras", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Grass }, 160, 70),
        new Pokemon(47, "Parasect", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Grass }, 250, 210),

        // Venonat line
        new Pokemon(48, "Venonat", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Poison }, 180, 80),
        new Pokemon(49, "Venomoth", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Poison }, 280, 230),

        // Diglett line
        new Pokemon(50, "Diglett", new List<EPokemonTypes>{ EPokemonTypes.Ground }, 190, 90),
        new Pokemon(51, "Dugtrio", new List<EPokemonTypes>{ EPokemonTypes.Ground }, 290, 240),

        // Meowth line
        new Pokemon(52, "Meowth", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 220, 90),
        new Pokemon(53, "Persian", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 310, 240),

        // Psyduck line
        new Pokemon(54, "Psyduck", new List<EPokemonTypes>{ EPokemonTypes.Water }, 210, 85),
        new Pokemon(55, "Golduck", new List<EPokemonTypes>{ EPokemonTypes.Water }, 300, 250),

        // Mankey line
        new Pokemon(56, "Mankey", new List<EPokemonTypes>{ EPokemonTypes.Fighting }, 200, 95),
        new Pokemon(57, "Primeape", new List<EPokemonTypes>{ EPokemonTypes.Fighting }, 290, 230),

        // Growlithe line
        new Pokemon(58, "Growlithe", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 230, 100),
        new Pokemon(59, "Arcanine", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 350, 280),

        // Poliwag line
        new Pokemon(60, "Poliwag", new List<EPokemonTypes>{ EPokemonTypes.Water }, 180, 75),
        new Pokemon(61, "Poliwhirl", new List<EPokemonTypes>{ EPokemonTypes.Water }, 260, 140),
        new Pokemon(62, "Poliwrath", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Fighting }, 320, 290),

        // Abra line
        new Pokemon(63, "Abra", new List<EPokemonTypes>{ EPokemonTypes.Psychic }, 190, 40),
        new Pokemon(64, "Kadabra", new List<EPokemonTypes>{ EPokemonTypes.Psychic }, 280, 160),
        new Pokemon(65, "Alakazam", new List<EPokemonTypes>{ EPokemonTypes.Psychic }, 340, 310),

        // Machop line
        new Pokemon(66, "Machop", new List<EPokemonTypes>{ EPokemonTypes.Fighting }, 200, 100),
        new Pokemon(67, "Machoke", new List<EPokemonTypes>{ EPokemonTypes.Fighting }, 290, 200),
        new Pokemon(68, "Machamp", new List<EPokemonTypes>{ EPokemonTypes.Fighting }, 350, 300),

        // Bellsprout line
        new Pokemon(69, "Bellsprout", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 180, 80),
        new Pokemon(70, "Weepinbell", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 250, 150),
        new Pokemon(71, "Victreebel", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Poison }, 310, 270),

        // Tentacool line
        new Pokemon(72, "Tentacool", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Poison }, 160, 70),
        new Pokemon(73, "Tentacruel", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Poison }, 280, 240),

        // Geodude line
        new Pokemon(74, "Geodude", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Ground }, 190, 90),
        new Pokemon(75, "Graveler", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Ground }, 270, 160),
        new Pokemon(76, "Golem", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Ground }, 330, 290),

        // Ponyta line
        new Pokemon(77, "Ponyta", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 230, 110),
        new Pokemon(78, "Rapidash", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 320, 260),

        // Slowpoke line
        new Pokemon(79, "Slowpoke", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Psychic }, 210, 80),
        new Pokemon(80, "Slowbro", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Psychic }, 300, 250),

        // Magnemite line
        new Pokemon(81, "Magnemite", new List<EPokemonTypes>{ EPokemonTypes.Electric, EPokemonTypes.Steel }, 220, 95),
        new Pokemon(82, "Magneton", new List<EPokemonTypes>{ EPokemonTypes.Electric, EPokemonTypes.Steel }, 310, 240),

        // Farfetch'd line
        new Pokemon(83, "Farfetch'd", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Flying }, 250, 130),

        // Doduo line
        new Pokemon(84, "Doduo", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Flying }, 200, 100),
        new Pokemon(85, "Dodrio", new List<EPokemonTypes>{ EPokemonTypes.Normal, EPokemonTypes.Flying }, 310, 260),

        // Seel line
        new Pokemon(86, "Seel", new List<EPokemonTypes>{ EPokemonTypes.Water }, 210, 85),
        new Pokemon(87, "Dewgong", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Ice }, 300, 250),

        // Grimeer line
        new Pokemon(88, "Grimer", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 180, 90),
        new Pokemon(89, "Muk", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 290, 240),

        // Shellder line
        new Pokemon(90, "Shellder", new List<EPokemonTypes>{ EPokemonTypes.Water }, 190, 80),
        new Pokemon(91, "Cloyster", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Ice }, 310, 270),

        // Gastly line
        new Pokemon(92, "Gastly", new List<EPokemonTypes>{ EPokemonTypes.Ghost, EPokemonTypes.Poison }, 200, 70),
        new Pokemon(93, "Haunter", new List<EPokemonTypes>{ EPokemonTypes.Ghost, EPokemonTypes.Poison }, 270, 160),
        new Pokemon(94, "Gengar", new List<EPokemonTypes>{ EPokemonTypes.Ghost, EPokemonTypes.Poison }, 340, 310),

        // Onix line
        new Pokemon(95, "Onix", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Ground }, 290, 100),

        // Drowzee line
        new Pokemon(96, "Drowzee", new List<EPokemonTypes>{ EPokemonTypes.Psychic }, 210, 85),
        new Pokemon(97, "Hypno", new List<EPokemonTypes>{ EPokemonTypes.Psychic }, 300, 240),

        // Krabby line
        new Pokemon(98, "Krabby", new List<EPokemonTypes>{ EPokemonTypes.Water }, 190, 95),
        new Pokemon(99, "Kingler", new List<EPokemonTypes>{ EPokemonTypes.Water }, 300, 260),

        // Voltorb line
        new Pokemon(100, "Voltorb", new List<EPokemonTypes>{ EPokemonTypes.Electric }, 200, 80),
        new Pokemon(101, "Electrode", new List<EPokemonTypes>{ EPokemonTypes.Electric }, 290, 230),

        // Exeggcute line
        new Pokemon(102, "Exeggcute", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Psychic }, 210, 90),
        new Pokemon(103, "Exeggutor", new List<EPokemonTypes>{ EPokemonTypes.Grass, EPokemonTypes.Psychic }, 320, 280),

        // Cubone line
        new Pokemon(104, "Cubone", new List<EPokemonTypes>{ EPokemonTypes.Ground }, 200, 95),
        new Pokemon(105, "Marowak", new List<EPokemonTypes>{ EPokemonTypes.Ground }, 300, 250),

        // Hitmon line
        new Pokemon(106, "Hitmonlee", new List<EPokemonTypes>{ EPokemonTypes.Fighting }, 330, 270),
        new Pokemon(107, "Hitmonchan", new List<EPokemonTypes>{ EPokemonTypes.Fighting }, 330, 270),

        // Lickitung line
        new Pokemon(108, "Lickitung", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 260, 120),

        // Koffing line
        new Pokemon(109, "Koffing", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 190, 85),
        new Pokemon(110, "Weezing", new List<EPokemonTypes>{ EPokemonTypes.Poison }, 300, 240),

        // Rhyhorn line
        new Pokemon(111, "Rhyhorn", new List<EPokemonTypes>{ EPokemonTypes.Ground, EPokemonTypes.Rock }, 230, 100),
        new Pokemon(112, "Rhydon", new List<EPokemonTypes>{ EPokemonTypes.Ground, EPokemonTypes.Rock }, 350, 290),

        // Chansey line
        new Pokemon(113, "Chansey", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 300, 60),

        // Tangela line
        new Pokemon(114, "Tangela", new List<EPokemonTypes>{ EPokemonTypes.Grass }, 250, 130),

        // Kangaskhan line
        new Pokemon(115, "Kangaskhan", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 350, 270),

        // Horsea line
        new Pokemon(116, "Horsea", new List<EPokemonTypes>{ EPokemonTypes.Water }, 180, 80),
        new Pokemon(117, "Seadra", new List<EPokemonTypes>{ EPokemonTypes.Water }, 280, 190),

        // Goldeen line
        new Pokemon(118, "Goldeen", new List<EPokemonTypes>{ EPokemonTypes.Water }, 160, 75),
        new Pokemon(119, "Seaking", new List<EPokemonTypes>{ EPokemonTypes.Water }, 260, 200),

        // Staryu line
        new Pokemon(120, "Staryu", new List<EPokemonTypes>{ EPokemonTypes.Water }, 200, 85),
        new Pokemon(121, "Starmie", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Psychic }, 310, 260),

        // Mr. Mime line
        new Pokemon(122, "Mr. Mime", new List<EPokemonTypes>{ EPokemonTypes.Psychic, EPokemonTypes.Fairy }, 300, 240),

        // Scyther line
        new Pokemon(123, "Scyther", new List<EPokemonTypes>{ EPokemonTypes.Bug, EPokemonTypes.Flying }, 340, 280),

        // Jynx line
        new Pokemon(124, "Jynx", new List<EPokemonTypes>{ EPokemonTypes.Ice, EPokemonTypes.Psychic }, 310, 250),

        // Electabuzz line
        new Pokemon(125, "Electabuzz", new List<EPokemonTypes>{ EPokemonTypes.Electric }, 330, 270),

        // Magmar line
        new Pokemon(126, "Magmar", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 330, 270),

        // Pinsir line
        new Pokemon(127, "Pinsir", new List<EPokemonTypes>{ EPokemonTypes.Bug }, 320, 260),

        // Tauros line
        new Pokemon(128, "Tauros", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 340, 270),

        // Magikarp line
        new Pokemon(129, "Magikarp", new List<EPokemonTypes>{ EPokemonTypes.Water }, 50, 20), // weakest in the game
        new Pokemon(130, "Gyarados", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Flying }, 400, 320),

        // Lapras line
        new Pokemon(131, "Lapras", new List<EPokemonTypes>{ EPokemonTypes.Water, EPokemonTypes.Ice }, 380, 300),

        // Ditto line
        new Pokemon(132, "Ditto", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 200, 50),

        // Eevee line
        new Pokemon(133, "Eevee", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 250, 100),
        new Pokemon(134, "Vaporeon", new List<EPokemonTypes>{ EPokemonTypes.Water }, 350, 290),
        new Pokemon(135, "Jolteon", new List<EPokemonTypes>{ EPokemonTypes.Electric }, 350, 290),
        new Pokemon(136, "Flareon", new List<EPokemonTypes>{ EPokemonTypes.Fire }, 350, 290),

        // Porygon line
        new Pokemon(137, "Porygon", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 300, 120),

        // Omanyte line
        new Pokemon(138, "Omanyte", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Water }, 240, 90),
        new Pokemon(139, "Omastar", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Water }, 360, 280),

        // Kabuto line
        new Pokemon(140, "Kabuto", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Water }, 230, 100),
        new Pokemon(141, "Kabutops", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Water }, 360, 290),

        // Aerodactyl line
        new Pokemon(142, "Aerodactyl", new List<EPokemonTypes>{ EPokemonTypes.Rock, EPokemonTypes.Flying }, 380, 300),

        // Snorlax line
        new Pokemon(143, "Snorlax", new List<EPokemonTypes>{ EPokemonTypes.Normal }, 400, 280),

        // Articuno
        new Pokemon(144, "Articuno", new List<EPokemonTypes>{ EPokemonTypes.Ice, EPokemonTypes.Flying }, 500, 400),

        // Zapdos
        new Pokemon(145, "Zapdos", new List<EPokemonTypes>{ EPokemonTypes.Electric, EPokemonTypes.Flying }, 500, 400),

        // Moltres
        new Pokemon(146, "Moltres", new List<EPokemonTypes>{ EPokemonTypes.Fire, EPokemonTypes.Flying }, 500, 400),

        // Dratini line
        new Pokemon(147, "Dratini", new List<EPokemonTypes>{ EPokemonTypes.Dragon }, 250, 100),
        new Pokemon(148, "Dragonair", new List<EPokemonTypes>{ EPokemonTypes.Dragon }, 320, 180),
        new Pokemon(149, "Dragonite", new List<EPokemonTypes>{ EPokemonTypes.Dragon, EPokemonTypes.Flying }, 450, 350), // Max power

        // Mewtwo
        new Pokemon(150, "Mewtwo", new List<EPokemonTypes>{ EPokemonTypes.Psychic }, 600, 450),

        // Mew
        new Pokemon(151, "Mew", new List<EPokemonTypes>{ EPokemonTypes.Psychic }, 550, 420)
    };

    public static List<Player> Players { get; } = new();
}