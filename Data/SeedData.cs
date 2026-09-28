using CSE325_GROUP.Models;
using Microsoft.EntityFrameworkCore;

namespace CSE325_GROUP.Data;

public static class SeedData
{
    public static async Task InitializeAsync(ApplicationDbContext context)
    {
        // Do not add the starter games again if games already exist
        if (await context.Games.AnyAsync())
        {
            return;
        }

        var games = new List<Game>
        {
            new Game
            {
                Title = "Dark Souls Remastered",
                Description = "Dark Souls Remastered is a 2018 action rpg game. It takes place in the ruined kingdom of Lordran, where an undead adventurer searches for a path through a decaying dark-fantasy world. Gameplay emphasizes deliberate stamina-based combat, exploration, character builds, shortcuts, and difficult boss encounters.",
                ReleaseYear = 2018,
                Platform = "PC; PS4; Xbox One; Nintendo Switch",
                Genre = "Action RPG",
                CoverImage = "/images/games/dark-souls-remastered.webp"
            },
            new Game
            {
                Title = "Dark Souls II: Scholar of the First Sin",
                Description = "Dark Souls II: Scholar of the First Sin is a 2015 action rpg game. It follows a cursed undead traveler through the kingdom of Drangleic in search of answers about the undead curse. This edition combines the base game and DLC while using deliberate combat, equipment builds, magic, exploration, and demanding bosses.",
                ReleaseYear = 2015,
                Platform = "PC; PS4; Xbox One",
                Genre = "Action RPG",
                CoverImage = "/images/games/dark-souls-2-scholar-of-the-first-sin.webp"
            },
            new Game
            {
                Title = "Bloodborne",
                Description = "Bloodborne is a 2015 action rpg game. It is set in the gothic city of Yharnam, where a mysterious illness has transformed many inhabitants into terrifying beasts. Players become a Hunter and use fast, aggressive combat built around dodging, firearms, transforming weapons, exploration, and challenging bosses.",
                ReleaseYear = 2015,
                Platform = "PS4",
                Genre = "Action RPG",
                CoverImage = "/images/games/bloodborne.webp"
            },
            new Game
            {
                Title = "The Witcher 3: Wild Hunt",
                Description = "The Witcher 3: Wild Hunt is a 2015 action rpg game. It follows monster hunter Geralt of Rivia as he searches for Ciri across a war-torn fantasy world. Players complete quests and contracts while using swords, magical Signs, alchemy, equipment, exploration, and story choices with lasting consequences.",
                ReleaseYear = 2015,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch",
                Genre = "Action RPG",
                CoverImage = "/images/games/the-witcher-3-wild-hunt.webp"
            },
            new Game
            {
                Title = "Dark Souls III",
                Description = "Dark Souls III is a 2016 action rpg game. It is set in the fading kingdom of Lothric as the Age of Fire approaches its end. Players travel to confront the Lords of Cinder using stamina-based melee combat, ranged weapons, magic, character builds, exploration, and difficult boss fights.",
                ReleaseYear = 2016,
                Platform = "PC; PS4; Xbox One",
                Genre = "Action RPG",
                CoverImage = "/images/games/dark-souls-3.webp"
            },
            new Game
            {
                Title = "Nioh",
                Description = "Nioh is a 2017 action rpg game. It follows the warrior William through a supernatural version of Japan during the early 1600s. Combat uses multiple weapon types, three stances, Ki management, loot, character progression, and battles against both human enemies and yokai.",
                ReleaseYear = 2017,
                Platform = "PC; PS4; PS5",
                Genre = "Action RPG",
                CoverImage = "/images/games/nioh.webp"
            },
            new Game
            {
                Title = "Sekiro: Shadows Die Twice",
                Description = "Sekiro: Shadows Die Twice is a 2019 action-adventure game. It follows a shinobi known as Wolf as he tries to protect and rescue a young lord in a fictionalized version of Sengoku-era Japan. Combat focuses on sword clashes, posture, precise deflections, stealth, mobility, and tools built into Wolf's prosthetic arm.",
                ReleaseYear = 2019,
                Platform = "PC; PS4; Xbox One",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/sekiro-shadows-die-twice.webp"
            },
            new Game
            {
                Title = "Death Stranding",
                Description = "Death Stranding is a 2019 action-adventure game. It follows courier Sam Porter Bridges across a fractured future America after a supernatural disaster changed the boundary between life and death. Gameplay centers on traversal, cargo management, route planning, structures, vehicles, asynchronous online connections, stealth, and occasional combat.",
                ReleaseYear = 2019,
                Platform = "PC; PS4; PS5",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/death-stranding.webp"
            },
            new Game
            {
                Title = "Resident Evil 2",
                Description = "Resident Evil 2 is a 2019 survival horror game. This remake follows Leon S. Kennedy and Claire Redfield during the zombie outbreak in Raccoon City. Players explore dangerous locations, solve puzzles, manage limited ammunition and healing items, and fight or avoid infected enemies.",
                ReleaseYear = 2019,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Survival Horror",
                CoverImage = "/images/games/resident-evil-2.webp"
            },
            new Game
            {
                Title = "Star Wars Jedi: Fallen Order",
                Description = "Star Wars Jedi: Fallen Order is a 2019 action-adventure game. It follows former Jedi Padawan Cal Kestis after the fall of the Jedi Order, when the Empire discovers his connection to the Force. Gameplay combines lightsaber combat, Force abilities, platforming, puzzles, exploration, upgrades, and travel between several planets.",
                ReleaseYear = 2019,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/star-wars-jedi-fallen-order.webp"
            },
            new Game
            {
                Title = "Control",
                Description = "Control is a 2019 action-adventure game. It follows Jesse Faden inside the shifting headquarters of the Federal Bureau of Control as she investigates a supernatural invasion and searches for her brother. Combat combines a transforming firearm with telekinetic powers, destructible environments, upgrades, exploration, and unusual supernatural encounters.",
                ReleaseYear = 2019,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/control.webp"
            },
            new Game
            {
                Title = "Devil May Cry 5",
                Description = "Devil May Cry 5 is a 2019 action game. It follows Nero, Dante, and V as they confront a major demonic invasion. Each playable character has a different fighting style, and the game rewards creative combinations of melee attacks, firearms, special abilities, and precise timing.",
                ReleaseYear = 2019,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Action",
                CoverImage = "/images/games/devil-may-cry-5.webp"
            },
            new Game
            {
                Title = "Code Vein",
                Description = "Code Vein is a 2019 action rpg game. It is set in a post-apocalyptic world where Revenants require blood to avoid becoming monsters called the Lost. Players explore with a companion and customize combat through weapons, Blood Veils, Blood Codes, Gifts, character builds, and difficult boss encounters.",
                ReleaseYear = 2019,
                Platform = "PC; PS4; Xbox One",
                Genre = "Action RPG",
                CoverImage = "/images/games/code-vein.webp"
            },
            new Game
            {
                Title = "Demon's Souls",
                Description = "Demon's Souls is a 2020 action rpg game. This remake is set in Boletaria, a kingdom consumed by a supernatural fog that has brought demons and soul-hungry creatures. Players collect souls and explore separate dangerous regions using deliberate combat, weapons, magic, equipment management, online features, and major boss fights.",
                ReleaseYear = 2020,
                Platform = "PS5",
                Genre = "Action RPG",
                CoverImage = "/images/games/demons-souls.webp"
            },
            new Game
            {
                Title = "Nioh 2",
                Description = "Nioh 2 is a 2020 action rpg game. It is set in a supernatural version of Sengoku-period Japan and follows a customizable warrior who is part human and part yokai. Combat expands the first game's systems with weapon stances, Ki management, Yokai abilities, loot, character builds, and challenging encounters.",
                ReleaseYear = 2020,
                Platform = "PC; PS4; PS5",
                Genre = "Action RPG",
                CoverImage = "/images/games/nioh-2.webp"
            },
            new Game
            {
                Title = "Mortal Shell",
                Description = "Mortal Shell is a 2020 action rpg game. It follows a mysterious Foundling that can inhabit the bodies of fallen warriors called Shells. Combat is deliberate and defensive, using different Shell abilities, weapons, dodging, parrying, and a signature hardening mechanic that temporarily turns the character to stone.",
                ReleaseYear = 2020,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch",
                Genre = "Action RPG",
                CoverImage = "/images/games/mortal-shell.webp"
            },
            new Game
            {
                Title = "Cyberpunk 2077",
                Description = "Cyberpunk 2077 is a 2020 action rpg game. It is set in Night City and follows the customizable mercenary V after a dangerous experimental biochip becomes linked to their life. Players use firearms, melee weapons, hacking, cyberware, vehicles, dialogue choices, quests, and flexible character builds across a large open world.",
                ReleaseYear = 2020,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch 2",
                Genre = "Action RPG",
                CoverImage = "/images/games/cyberpunk-2077.webp"
            },
            new Game
            {
                Title = "The Last of Us Part II",
                Description = "The Last of Us Part II is a 2020 action-adventure game. It is set several years after the first game and follows Ellie and other characters through a violent conflict shaped by loss and revenge. Gameplay combines stealth, exploration, crafting, firearms, melee combat, environmental puzzles, and encounters with infected creatures and human enemies.",
                ReleaseYear = 2020,
                Platform = "PS4; PS5; PC",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/the-last-of-us-part-2.webp"
            },
            new Game
            {
                Title = "Ghost of Tsushima",
                Description = "Ghost of Tsushima is a 2020 action-adventure game. It follows samurai Jin Sakai during the Mongol invasion of Tsushima in 1274 as he struggles between traditional samurai methods and unconventional tactics. Players explore an open world using sword stances, archery, stealth tools, duels, horseback travel, equipment, and character upgrades.",
                ReleaseYear = 2020,
                Platform = "PS4; PS5; PC",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/ghost-of-tsushima.webp"
            },
            new Game
            {
                Title = "Animal Crossing: New Horizons",
                Description = "Animal Crossing: New Horizons is a 2020 life simulation game. It begins with the player moving to a deserted island and gradually developing it into a personalized community. Players gather resources, craft and decorate, collect creatures, build relationships with animal residents, and experience events that follow real-world time and seasons.",
                ReleaseYear = 2020,
                Platform = "Nintendo Switch; Nintendo Switch 2",
                Genre = "Life Simulation",
                CoverImage = "/images/games/animal-crossing-new-horizons.webp"
            },
            new Game
            {
                Title = "DOOM Eternal",
                Description = "DOOM Eternal is a 2020 first-person shooter game. It follows the Doom Slayer as he fights a massive demonic invasion of Earth and other worlds. Combat rewards constant movement and aggressive resource management through a large weapon arsenal, equipment, glory kills, platforming, secrets, and intense enemy encounters.",
                ReleaseYear = 2020,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch",
                Genre = "First-Person Shooter",
                CoverImage = "/images/games/doom-eternal.webp"
            },
            new Game
            {
                Title = "Resident Evil Village",
                Description = "Resident Evil Village is a 2021 survival horror game. It continues Ethan Winters's story as he enters a remote European village while searching for his kidnapped daughter. Gameplay mixes first-person combat, exploration, puzzles, limited resources, weapon upgrades, merchants, and horror-focused environments.",
                ReleaseYear = 2021,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Survival Horror",
                CoverImage = "/images/games/resident-evil-village.webp"
            },
            new Game
            {
                Title = "Forza Horizon 5",
                Description = "Forza Horizon 5 is a 2021 racing game. It takes the Horizon Festival to a large open-world recreation of Mexico with cities, jungles, deserts, beaches, and a volcano. Players collect and customize hundreds of cars while completing races, expeditions, stunts, seasonal activities, exploration challenges, and online multiplayer events.",
                ReleaseYear = 2021,
                Platform = "PC; Xbox One; Xbox Series X|S; PS5",
                Genre = "Racing",
                CoverImage = "/images/games/forza-horizon-5.webp"
            },
            new Game
            {
                Title = "It Takes Two",
                Description = "It Takes Two is a 2021 co-op action-adventure game. It follows Cody and May, a struggling married couple who are magically transformed into dolls and must work together to return to their bodies. The game is designed for two players and constantly introduces new cooperative platforming, puzzles, abilities, mini-games, and action mechanics.",
                ReleaseYear = 2021,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch",
                Genre = "Co-op Action-Adventure",
                CoverImage = "/images/games/it-takes-two.webp"
            },
            new Game
            {
                Title = "Halo Infinite",
                Description = "Halo Infinite is a 2021 first-person shooter game. It continues Master Chief's story on the damaged ringworld Zeta Halo as he confronts the Banished and searches for answers about the UNSC and Cortana. The campaign combines Halo's weapons and vehicles with large outdoor areas, upgrades, objectives, and equipment such as the Grappleshot, while multiplayer provides competitive modes.",
                ReleaseYear = 2021,
                Platform = "PC; Xbox One; Xbox Series X|S",
                Genre = "First-Person Shooter",
                CoverImage = "/images/games/halo-infinite.webp"
            },
            new Game
            {
                Title = "Metroid Dread",
                Description = "Metroid Dread is a 2021 action-adventure game. It follows bounty hunter Samus Aran on planet ZDR after she investigates a mysterious transmission and becomes trapped beneath the planet's surface. Players explore an interconnected map, gain abilities that open new routes, fight enemies and bosses, and evade dangerous E.M.M.I. robots.",
                ReleaseYear = 2021,
                Platform = "Nintendo Switch; Nintendo Switch 2",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/metroid-dread.webp"
            },
            new Game
            {
                Title = "Elden Ring",
                Description = "Elden Ring is a 2022 action rpg game. It is set in the Lands Between, a realm shattered by conflict after the destruction of the Elden Ring. Players create a Tarnished warrior and freely explore the world using weapons, spells, Spirit Ashes, horseback travel, character builds, cooperative features, and challenging boss battles.",
                ReleaseYear = 2022,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch 2",
                Genre = "Action RPG",
                CoverImage = "/images/games/elden-ring.webp"
            },
            new Game
            {
                Title = "God of War Ragnarök",
                Description = "God of War Ragnarök is a 2022 action-adventure game. It continues the Norse story of Kratos and Atreus as Ragnarök approaches and they travel across the Nine Realms. Combat combines Kratos's weapons and abilities with companion skills, equipment, upgrades, exploration, puzzles, optional challenges, and large boss encounters.",
                ReleaseYear = 2022,
                Platform = "PS4; PS5; PC",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/god-of-war-ragnarok.webp"
            },
            new Game
            {
                Title = "Horizon Forbidden West",
                Description = "Horizon Forbidden West is a 2022 action rpg game. It follows Aloy as she travels into the western regions of a far-future Earth to investigate a dangerous ecological threat. Gameplay combines bows and other weapons, machine hunting, stealth, climbing, crafting, underwater exploration, machine overrides, equipment upgrades, and a large open world.",
                ReleaseYear = 2022,
                Platform = "PS4; PS5; PC",
                Genre = "Action RPG",
                CoverImage = "/images/games/horizon-forbidden-west.webp"
            },
            new Game
            {
                Title = "Pokémon Legends: Arceus",
                Description = "Pokémon Legends: Arceus is a 2022 action rpg game. It is set in the historical Hisui region, an earlier version of Sinnoh, where the player joins the Galaxy Expedition Team to help create the region's first Pokédex. Players explore large areas, observe and catch Pokémon directly, craft items, complete research tasks, and battle using Agile and Strong styles.",
                ReleaseYear = 2022,
                Platform = "Nintendo Switch",
                Genre = "Action RPG",
                CoverImage = "/images/games/pokemon-legends-arceus.webp"
            },
            new Game
            {
                Title = "Stray",
                Description = "Stray is a 2022 adventure game. It follows a lost cat trapped inside a decaying cybercity populated mainly by robots. With help from the drone B-12, players explore the city through platforming, environmental puzzles, stealth, interactions with residents, and a search for a way back outside.",
                ReleaseYear = 2022,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch",
                Genre = "Adventure",
                CoverImage = "/images/games/stray.webp"
            },
            new Game
            {
                Title = "A Plague Tale: Requiem",
                Description = "A Plague Tale: Requiem is a 2022 action-adventure game. It continues the story of siblings Amicia and Hugo as they travel through medieval France seeking help for Hugo's supernatural condition. Gameplay combines stealth, environmental puzzles, alchemy, ranged weapons, companion abilities, swarms of rats, and more direct combat options than the first game.",
                ReleaseYear = 2022,
                Platform = "PC; PS5; Xbox Series X|S; Nintendo Switch (Cloud)",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/a-plague-tale-requiem.webp"
            },
            new Game
            {
                Title = "Lies of P",
                Description = "Lies of P is a 2023 action rpg game. It reimagines Pinocchio in the ruined Belle Époque-inspired city of Krat, where puppets have turned violent and a strange disease threatens survivors. Players control the puppet P using precise guarding, dodging, weapon combinations, Legion Arms, upgrades, exploration, and difficult boss battles.",
                ReleaseYear = 2023,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/lies-of-p.webp"
            },
            new Game
            {
                Title = "Lords of the Fallen",
                Description = "Lords of the Fallen is a 2023 action rpg game. It is set in a dark fantasy world threatened by the return of the demon god Adyr. Players explore both the world of the living and the parallel realm of Umbral while using melee weapons, magic, blocking, dodging, character builds, and cooperative features.",
                ReleaseYear = 2023,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/lords-of-the-fallen.webp"
            },
            new Game
            {
                Title = "Wo Long: Fallen Dynasty",
                Description = "Wo Long: Fallen Dynasty is a 2023 action rpg game. It takes place in a dark fantasy version of China near the end of the Han dynasty and features figures inspired by the Three Kingdoms era. Combat emphasizes fast attacks, precise deflections, Spirit management, martial arts, Wizardry spells, equipment, and a Morale system.",
                ReleaseYear = 2023,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/wo-long-fallen-dynasty.webp"
            },
            new Game
            {
                Title = "Baldur's Gate 3",
                Description = "Baldur's Gate 3 is a 2023 rpg game. It is a party-based role-playing game set in the Forgotten Realms, where the player and several companions are infected with mind-flayer parasites. Gameplay uses turn-based combat, exploration, dialogue choices, dice-based skill checks, character classes, relationships, and decisions that can substantially change the story.",
                ReleaseYear = 2023,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "RPG",
                CoverImage = "/images/games/baldurs-gate-3.webp"
            },
            new Game
            {
                Title = "Hogwarts Legacy",
                Description = "Hogwarts Legacy is a 2023 action rpg game. It is set in the wizarding world during the 1800s and follows a customizable Hogwarts student who becomes connected to a mystery involving ancient magic. Players attend classes and explore Hogwarts and surrounding regions while using spell-based combat, puzzles, crafting, creatures, equipment, and character upgrades.",
                ReleaseYear = 2023,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch; Nintendo Switch 2",
                Genre = "Action RPG",
                CoverImage = "/images/games/hogwarts-legacy.webp"
            },
            new Game
            {
                Title = "Marvel's Spider-Man 2",
                Description = "Marvel's Spider-Man 2 is a 2023 action-adventure game. It follows Peter Parker and Miles Morales as they protect New York from threats including Kraven the Hunter and a dangerous symbiote. Players switch between the two heroes and use web swinging, Web Wings, different powers, gadgets, combat upgrades, missions, and open-world activities.",
                ReleaseYear = 2023,
                Platform = "PS5; PC",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/marvels-spider-man-2.webp"
            },
            new Game
            {
                Title = "Alan Wake 2",
                Description = "Alan Wake 2 is a 2023 survival horror game. It follows FBI agent Saga Anderson investigating ritual murders near Bright Falls and writer Alan Wake trying to escape the supernatural Dark Place. Gameplay combines investigation, exploration, light-based mechanics, puzzles, narrative sequences, and limited-resource combat against supernatural enemies.",
                ReleaseYear = 2023,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Survival Horror",
                CoverImage = "/images/games/alan-wake-2.webp"
            },
            new Game
            {
                Title = "Resident Evil 4",
                Description = "Resident Evil 4 is a 2023 survival horror game. This remake follows Leon S. Kennedy to a remote European village where he is sent to rescue the kidnapped daughter of the U.S. president. Gameplay combines exploration, puzzles, resource management, weapon upgrades, melee actions, and intense third-person combat while reworking the original game's environments and encounters.",
                ReleaseYear = 2023,
                Platform = "PC; PS4; PS5; Xbox Series X|S",
                Genre = "Survival Horror",
                CoverImage = "/images/games/resident-evil-4.webp"
            },
            new Game
            {
                Title = "The Legend of Zelda: Tears of the Kingdom",
                Description = "The Legend of Zelda: Tears of the Kingdom is a 2023 action-adventure game. It returns Link to Hyrule, now expanded with floating sky islands and a vast underground region, as he searches for Princess Zelda and confronts a new threat. Abilities such as Ultrahand, Fuse, Ascend, and Recall let players build machines, combine objects, explore creatively, solve puzzles, and approach combat in many ways.",
                ReleaseYear = 2023,
                Platform = "Nintendo Switch; Nintendo Switch 2",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/the-legend-of-zelda-tears-of-the-kingdom.webp"
            },
            new Game
            {
                Title = "Black Myth: Wukong",
                Description = "Black Myth: Wukong is a 2024 action rpg game. It is inspired by the Chinese novel Journey to the West and follows the Destined One through a mythological world filled with creatures from Chinese folklore. Combat uses a staff, spells, transformations, special abilities, equipment, exploration, and fast encounters with powerful bosses.",
                ReleaseYear = 2024,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/black-myth-wukong.webp"
            },
            new Game
            {
                Title = "Helldivers 2",
                Description = "Helldivers 2 is a 2024 third-person shooter game. It places squads of Helldivers in an ongoing galactic war fought in the name of Super Earth against hostile factions. Up to four players complete missions using firearms and powerful Stratagems while permanent friendly fire, objectives, reinforcements, and chaotic battles make teamwork important.",
                ReleaseYear = 2024,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Third-Person Shooter",
                CoverImage = "/images/games/helldivers-2.webp"
            },
            new Game
            {
                Title = "Silent Hill 2",
                Description = "Silent Hill 2 is a 2024 survival horror game. This remake follows James Sunderland to the fog-covered town of Silent Hill after he receives a letter from his deceased wife. Players explore unsettling environments, solve puzzles, manage combat against disturbing creatures, and uncover a psychological story built around grief, guilt, and memory.",
                ReleaseYear = 2024,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Survival Horror",
                CoverImage = "/images/games/silent-hill-2.webp"
            },
            new Game
            {
                Title = "Final Fantasy VII Rebirth",
                Description = "Final Fantasy VII Rebirth is a 2024 action rpg game. It is the second game in the Final Fantasy VII remake project and follows Cloud Strife and his companions after they leave Midgar in pursuit of Sephiroth. Combat blends real-time action with command-based abilities, party switching, character relationships, exploration, mini-games, and extensive side content.",
                ReleaseYear = 2024,
                Platform = "PC; PS5; Xbox Series X|S; Nintendo Switch 2",
                Genre = "Action RPG",
                CoverImage = "/images/games/final-fantasy-7-rebirth.webp"
            },
            new Game
            {
                Title = "Astro Bot",
                Description = "Astro Bot is a 2024 platformer game. It follows Astro on a journey across colorful worlds to rescue missing Bots and repair the PS5 mothership. Players complete 3D platforming stages filled with enemies, secrets, PlayStation references, special abilities, collectibles, and extensive use of DualSense controller features.",
                ReleaseYear = 2024,
                Platform = "PS5",
                Genre = "Platformer",
                CoverImage = "/images/games/astro-bot.webp"
            },
            new Game
            {
                Title = "Dragon Age: The Veilguard",
                Description = "Dragon Age: The Veilguard is a 2024 action rpg game. It is set in Thedas and follows a customizable hero named Rook, who leads a group of companions against powerful ancient elven gods. Gameplay combines real-time combat, character abilities, equipment, exploration, dialogue choices, companion relationships, and story decisions.",
                ReleaseYear = 2024,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/dragon-age-the-veilguard.webp"
            },
            new Game
            {
                Title = "Elden Ring Nightreign",
                Description = "Elden Ring Nightreign is a 2025 co-op action survival game. It is a standalone game set in a parallel version of the Elden Ring universe, where heroes called Nightfarers enter the changing region of Limveld. Runs combine exploration, rapid character growth, equipment collection, a shrinking danger zone, major bosses, solo play, and three-player cooperation before a final Nightlord battle.",
                ReleaseYear = 2025,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Co-op Action Survival",
                CoverImage = "/images/games/elden-ring-nightreign.webp"
            },
            new Game
            {
                Title = "The First Berserker: Khazan",
                Description = "The First Berserker: Khazan is a 2025 action rpg game. It is set in the Dungeon & Fighter universe and follows General Khazan after he is falsely accused of treason and sent into exile. Gameplay emphasizes precise melee combat, blocking and dodging, equipment, skill development, aggressive enemies, and demanding boss encounters.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/the-first-berserker-khazan.webp"
            },
            new Game
            {
                Title = "Clair Obscur: Expedition 33",
                Description = "Clair Obscur: Expedition 33 is a 2025 rpg game. It is set in a fantasy world where the Paintress marks a number each year and people of that age disappear, leading Expedition 33 to attempt to stop the cycle. Combat is turn-based but includes real-time dodging, parrying, aiming, timed inputs, party builds, equipment, and character abilities.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "RPG",
                CoverImage = "/images/games/clair-obscur-expedition-33.webp"
            },
            new Game
            {
                Title = "Kingdom Come: Deliverance II",
                Description = "Kingdom Come: Deliverance II is a 2025 action rpg game. It continues Henry of Skalitz's story in 15th-century Bohemia as he becomes involved in war, politics, personal conflicts, and historical events. Gameplay emphasizes first-person melee combat, dialogue, reputation, quests, equipment, crafting, survival systems, exploration, and multiple ways to solve problems.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/kingdom-come-deliverance-2.webp"
            },
            new Game
            {
                Title = "Monster Hunter Wilds",
                Description = "Monster Hunter Wilds is a 2025 action rpg game. It sends hunters into dynamic environments where large monsters interact with changing weather, ecosystems, and each other. Players track and hunt monsters using specialized weapon types, gather materials, craft stronger equipment, travel with a Seikret mount, and cooperate with other hunters.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/monster-hunter-wilds.webp"
            },
            new Game
            {
                Title = "Assassin's Creed Shadows",
                Description = "Assassin's Creed Shadows is a 2025 action-adventure rpg game. It is set in late Sengoku-period Japan and follows Naoe, an Iga shinobi, and Yasuke, a samurai with a very different approach to combat. Players explore an open world using stealth, parkour, tools, melee combat, character progression, and the contrasting abilities of the two protagonists.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S; macOS; Nintendo Switch 2",
                Genre = "Action-Adventure RPG",
                CoverImage = "/images/games/assassins-creed-shadows.webp"
            },
            new Game
            {
                Title = "DOOM: The Dark Ages",
                Description = "DOOM: The Dark Ages is a 2025 first-person shooter game. It is a prequel to DOOM (2016) and DOOM Eternal that follows the Doom Slayer during a medieval-style war against Hell. Combat combines heavy firearms with close-range weapons and the Shield Saw, while exploration, large battles, powerful enemies, and vehicle sequences expand the campaign's scale.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "First-Person Shooter",
                CoverImage = "/images/games/doom-the-dark-ages.webp"
            },
            new Game
            {
                Title = "Death Stranding 2: On the Beach",
                Description = "Death Stranding 2: On the Beach is a 2025 action-adventure game. It continues Sam Porter Bridges's journey as he joins allies on an expedition beyond the United Cities of America in a world still shaped by the Death Stranding. Gameplay again emphasizes traversal, cargo delivery, route planning, equipment, vehicles, asynchronous online connections, stealth, and expanded combat options.",
                ReleaseYear = 2025,
                Platform = "PS5",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/death-stranding-2-on-the-beach.webp"
            },
            new Game
            {
                Title = "Ghost of Yōtei",
                Description = "Ghost of Yōtei is a 2025 action-adventure game. It is set in northern Japan more than three centuries after Ghost of Tsushima and follows the mercenary Atsu on a revenge-driven journey. Players explore the lands around Mount Yōtei while using multiple weapons, tracking, combat, optional activities, and open-world exploration.",
                ReleaseYear = 2025,
                Platform = "PS5",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/ghost-of-yotei.webp"
            },
            new Game
            {
                Title = "Hollow Knight: Silksong",
                Description = "Hollow Knight: Silksong is a 2025 metroidvania game. It follows Hornet after she is taken to the unfamiliar kingdom of Pharloom and begins a journey toward its peak. Gameplay focuses on agile movement, melee combat, tools, interconnected exploration, secrets, quests, upgrades, and challenging bosses.",
                ReleaseYear = 2025,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; Nintendo Switch; Nintendo Switch 2",
                Genre = "Metroidvania",
                CoverImage = "/images/games/hollow-knight-silksong.webp"
            },
            new Game
            {
                Title = "Hades II",
                Description = "Hades II is a 2025 roguelike action rpg game. It follows Melinoë, Princess of the Underworld, in a mythological conflict against the Titan Chronos. Each run combines fast combat, weapons, magical abilities, changing rewards, relationships with mythological characters, and permanent progression between attempts.",
                ReleaseYear = 2025,
                Platform = "PC; Nintendo Switch; Nintendo Switch 2",
                Genre = "Roguelike Action RPG",
                CoverImage = "/images/games/hades-2.webp"
            },
            new Game
            {
                Title = "Split Fiction",
                Description = "Split Fiction is a 2025 co-op action-adventure game. It follows writers Mio and Zoe after they become trapped inside simulations based on their own science-fiction and fantasy stories. Designed for two players, the game constantly changes mechanics while mixing platforming, puzzles, action, vehicles, unusual abilities, and coordinated cooperative challenges.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S; Nintendo Switch 2",
                Genre = "Co-op Action-Adventure",
                CoverImage = "/images/games/split-fiction.webp"
            },
            new Game
            {
                Title = "Silent Hill f",
                Description = "Silent Hill f is a 2025 survival horror game. It is set in 1960s Japan and follows teenager Hinako Shimizu as her isolated town is consumed by fog and disturbing supernatural changes. Players explore the transformed town, solve puzzles, face grotesque creatures, and experience a psychological horror story centered on social pressure, fear, and difficult choices.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Survival Horror",
                CoverImage = "/images/games/silent-hill-f.webp"
            },
            new Game
            {
                Title = "The Outer Worlds 2",
                Description = "The Outer Worlds 2 is a 2025 action rpg game. It is a first-person science-fiction RPG set in the colony of Arcadia, where an Earth Directorate agent investigates dangerous rifts and conflicts between rival factions. Gameplay emphasizes dialogue choices, character skills, companions, exploration, shooting, equipment, quests, and decisions that affect relationships and outcomes.",
                ReleaseYear = 2025,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/the-outer-worlds-2.webp"
            },
            new Game
            {
                Title = "Code Vein II",
                Description = "Code Vein II is a 2026 action rpg game. It is a standalone story set in a different world from the first Code Vein, where a Revenant Hunter travels between the past and present to prevent a collapsing future. Gameplay uses customizable weapons and abilities, character progression, companions through the Partner System, exploration, and difficult action-RPG combat.",
                ReleaseYear = 2026,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/code-vein-2.webp"
            },
            new Game
            {
                Title = "Nioh 3",
                Description = "Nioh 3 is a 2026 action rpg game. It follows Tokugawa Takechiyo, who is poised to become shogun while facing supernatural threats and conflict involving his younger brother Kunimatsu. The game continues Team NINJA's dark samurai action RPG style with demanding melee combat, equipment, character progression, yokai enemies, and multiple combat approaches.",
                ReleaseYear = 2026,
                Platform = "PC; PS5",
                Genre = "Action RPG",
                CoverImage = "/images/games/nioh-3.webp"
            },
            new Game
            {
                Title = "Resident Evil Requiem",
                Description = "Resident Evil Requiem is a 2026 survival horror game. It is the ninth main Resident Evil entry and returns to Raccoon City, featuring FBI analyst Grace Ashcroft and veteran agent Leon S. Kennedy. The two protagonists provide contrasting horror and action-focused experiences built around exploration, dangerous enemies, weapons, investigation, and resource management.",
                ReleaseYear = 2026,
                Platform = "PC; PS5; Xbox Series X|S; Nintendo Switch 2",
                Genre = "Survival Horror",
                CoverImage = "/images/games/resident-evil-requiem.webp"
            },
            new Game
            {
                Title = "Marathon",
                Description = "Marathon is an upcoming extraction shooter game. It is a science-fiction PvP extraction shooter set on Tau Ceti IV, where players become cybernetic mercenaries called Runners. Players enter persistent zones alone or in crews to find valuable resources, fight threats, manage equipment, and attempt to extract successfully; Bungie currently lists no release date.",
                ReleaseYear = (int?)null,
                Platform = "PC; PS5; Xbox Series X|S",
                Genre = "Extraction Shooter",
                CoverImage = "/images/games/marathon.webp"
            },
            new Game
            {
                Title = "Crimson Desert",
                Description = "Crimson Desert is a 2026 open-world action-adventure game. It is set on the continent of Pywel and follows Kliff after an attack scatters the Greymanes, sending him on a journey to reunite them and recover what was lost. Gameplay combines open-world exploration, climbing and traversal, swords and other weapons, hand-to-hand combat, large battles, bosses, and flexible progression.",
                ReleaseYear = 2026,
                Platform = "PC; PS5; Xbox Series X|S; macOS",
                Genre = "Open-World Action-Adventure",
                CoverImage = "/images/games/crimson-desert.webp"
            },
            new Game
            {
                Title = "Pragmata",
                Description = "Pragmata is a 2026 sci-fi action-adventure game. It follows Hugh Williams and the android girl Diana after they meet at a lunar facility and must work together to return to Earth. Gameplay combines third-person action with hacking mechanics, making cooperation between Hugh's combat abilities and Diana's technological abilities central to encounters.",
                ReleaseYear = 2026,
                Platform = "PC; PS5; Xbox Series X|S; Nintendo Switch 2",
                Genre = "Sci-Fi Action-Adventure",
                CoverImage = "/images/games/pragmata.webp"
            },
            new Game
            {
                Title = "Saros",
                Description = "Saros is a 2026 action game. It follows Soltari Enforcer Arjun Devraj on the shape-shifting off-world colony of Carcosa beneath an ominous eclipse. Its fast third-person combat features projectile-heavy battles and a permanent progression system that lets Arjun improve equipment and return stronger after death.",
                ReleaseYear = 2026,
                Platform = "PS5",
                Genre = "Action",
                CoverImage = "/images/games/saros.webp"
            },
            new Game
            {
                Title = "Forza Horizon 6",
                Description = "Forza Horizon 6 is a 2026 racing game. It takes the Horizon Festival to Japan, with rural landscapes, varied biomes, and a large Tokyo urban area. Players collect hundreds of cars and progress from tourist to Horizon Legend through racing, exploration, events, challenges, customization, and online play.",
                ReleaseYear = 2026,
                Platform = "PC; Xbox Series X|S; PS5",
                Genre = "Racing",
                CoverImage = "/images/games/forza-horizon-6.webp"
            },
            new Game
            {
                Title = "007 First Light",
                Description = "007 First Light is a 2026 action-adventure game. It presents a new origin story for a young James Bond as he works toward becoming a 00 agent within MI6. Missions combine espionage, stealth, gadgets, social interactions, driving, cinematic action, and gunplay, with different approaches available in many situations.",
                ReleaseYear = 2026,
                Platform = "PC; PS5; Xbox Series X|S; Nintendo Switch 2",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/007-first-light.webp"
            },
            new Game
            {
                Title = "Phantom Blade Zero",
                Description = "Phantom Blade Zero is a 2026 action rpg game. It follows Soul, a warrior who is framed for his master's murder and left with only a limited time to live after suffering a fatal wound. The game draws on wuxia and Chinese martial arts, using fast melee combat, varied weapons, powerful enemies, exploration, and a mystery surrounding Soul's fate.",
                ReleaseYear = 2026,
                Platform = "PC; PS5",
                Genre = "Action RPG",
                CoverImage = "/images/games/phantom-blade-zero.webp"
            },
            new Game
            {
                Title = "Grand Theft Auto VI",
                Description = "Grand Theft Auto VI is a 2026 open-world action-adventure game. It is set in the fictional state of Leonida, including a modern version of Vice City, and centers on Jason Duval and Lucia Caminos. The game continues the series' open-world focus on vehicles, criminal activity, story missions, exploration, and a detailed contemporary setting; Rockstar lists November 19, 2026 as its release date.",
                ReleaseYear = 2026,
                Platform = "PS5; Xbox Series X|S",
                Genre = "Open-World Action-Adventure",
                CoverImage = "/images/games/grand-theft-auto-6.webp"
            },
            new Game
            {
                Title = "The Witcher IV",
                Description = "The Witcher IV is an upcoming action rpg game. It is an upcoming single-player open-world RPG from CD PROJEKT RED and the beginning of a new Witcher saga with Ciri as the central protagonist. Ciri is shown pursuing the path of a professional monster slayer, and the project is being developed with Unreal Engine 5; a final release date and complete platform list are not yet confirmed.",
                ReleaseYear = (int?)null,
                Platform = "TBA",
                Genre = "Action RPG",
                CoverImage = "/images/games/the-witcher-4.webp"
            },
            new Game
            {
                Title = "Horizon Zero Dawn",
                Description = "Horizon Zero Dawn is a 2017 action rpg game. It is set in a far-future Earth where animal-like machines dominate the landscape and follows Aloy as she investigates her origins and the lost civilization that came before her. Gameplay uses bows, traps, elemental ammunition, stealth, crafting, open-world exploration, and knowledge of machine components and weaknesses.",
                ReleaseYear = 2017,
                Platform = "PC; PS4; PS5",
                Genre = "Action RPG",
                CoverImage = "/images/games/horizon-zero-dawn.webp"
            },
            new Game
            {
                Title = "Assassin's Creed",
                Description = "Assassin's Creed is a 2007 action-adventure game. It is set during the Third Crusade and follows Assassin Altaïr Ibn-La'Ahad through memories experienced by modern-day protagonist Desmond Miles using the Animus. Gameplay established the series' combination of social stealth, parkour, investigation, sword combat, historical cities, and targeted assassinations.",
                ReleaseYear = 2007,
                Platform = "PC; PS3; Xbox 360",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed.webp"
            },
            new Game
            {
                Title = "Assassin's Creed II",
                Description = "Assassin's Creed II is a 2009 action-adventure game. It is set in Renaissance Italy and follows Ezio Auditore da Firenze after the betrayal and execution of members of his family. Ezio becomes involved with the Assassin Brotherhood, while gameplay expands parkour, stealth, combat, hidden weapons, economic upgrades, exploration, and assassination missions.",
                ReleaseYear = 2009,
                Platform = "PC; PS3; Xbox 360",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-2.webp"
            },
            new Game
            {
                Title = "Assassin's Creed: Brotherhood",
                Description = "Assassin's Creed: Brotherhood is a 2010 action-adventure game. It continues Ezio Auditore's story in Rome as he fights the Borgia and rebuilds the Assassin Brotherhood. Players liberate districts, recruit Assassins, renovate the city, use parkour and stealth, and take part in faster combat and assassination missions.",
                ReleaseYear = 2010,
                Platform = "PC; PS3; Xbox 360",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-brotherhood.webp"
            },
            new Game
            {
                Title = "Assassin's Creed: Revelations",
                Description = "Assassin's Creed: Revelations is a 2011 action-adventure game. It follows an older Ezio Auditore to Constantinople as he searches for knowledge connected to Altaïr and the history of the Assassins. Gameplay retains parkour, stealth, and combat while adding the Hookblade, bomb crafting, Assassin recruits, and additional traversal options.",
                ReleaseYear = 2011,
                Platform = "PC; PS3; Xbox 360",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-revelations.webp"
            },
            new Game
            {
                Title = "Assassin's Creed III",
                Description = "Assassin's Creed III is a 2012 action-adventure game. It is set around the American Revolution and follows Ratonhnhaké:ton, also known as Connor, whose personal story becomes connected to the Assassin-Templar conflict. Gameplay includes city and wilderness exploration, parkour, stealth, melee combat, hunting, naval missions, and major historical events.",
                ReleaseYear = 2012,
                Platform = "PC; PS3; PS4; Xbox 360; Xbox One; Nintendo Switch",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-3.webp"
            },
            new Game
            {
                Title = "Assassin's Creed IV: Black Flag",
                Description = "Assassin's Creed IV: Black Flag is a 2013 action-adventure game. It is set during the Golden Age of Piracy and follows pirate Edward Kenway as he becomes involved in the conflict between Assassins and Templars. The game combines parkour and stealth with Caribbean exploration, naval travel, ship combat, diving, hunting, and upgrades for Edward's ship, the Jackdaw.",
                ReleaseYear = 2013,
                Platform = "PC; PS3; PS4; Xbox 360; Xbox One; Nintendo Switch",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-4-black-flag.webp"
            },
            new Game
            {
                Title = "Assassin's Creed Rogue",
                Description = "Assassin's Creed Rogue is a 2014 action-adventure game. It is set during the Seven Years' War and follows Shay Patrick Cormac, a former Assassin who joins the Templars after losing faith in the Brotherhood. Gameplay combines naval exploration and combat with parkour, stealth, firearms, hunting, and missions across North America and the North Atlantic.",
                ReleaseYear = 2014,
                Platform = "PC; PS3; PS4; Xbox 360; Xbox One; Nintendo Switch",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-rogue.webp"
            },
            new Game
            {
                Title = "Assassin's Creed Unity",
                Description = "Assassin's Creed Unity is a 2014 action-adventure game. It is set mainly in Paris during the French Revolution and follows Arno Dorian as he joins the Assassin Brotherhood while investigating a personal tragedy. The game emphasizes dense urban parkour, large crowds, stealth, customizable equipment, melee combat, assassination missions, and cooperative missions.",
                ReleaseYear = 2014,
                Platform = "PC; PS4; Xbox One",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-unity.webp"
            },
            new Game
            {
                Title = "Assassin's Creed Syndicate",
                Description = "Assassin's Creed Syndicate is a 2015 action-adventure game. It is set in Victorian London during the Industrial Revolution and follows Assassin twins Jacob and Evie Frye as they challenge Templar control of the city. Players switch between the twins and use parkour, stealth, brawling, carriages, a rope launcher, gang activities, and missions across London.",
                ReleaseYear = 2015,
                Platform = "PC; PS4; Xbox One",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-syndicate.webp"
            },
            new Game
            {
                Title = "Assassin's Creed Origins",
                Description = "Assassin's Creed Origins is a 2017 action rpg game. It is set in Ptolemaic Egypt and follows Bayek of Siwa, whose personal tragedy leads into a political conspiracy and the origins of the Assassin Brotherhood. The game shifts the series toward RPG systems with hitbox-based combat, levels, loot, quests, exploration, stealth, and a large recreation of ancient Egypt.",
                ReleaseYear = 2017,
                Platform = "PC; PS4; Xbox One",
                Genre = "Action RPG",
                CoverImage = "/images/games/assassins-creed-origins.webp"
            },
            new Game
            {
                Title = "Assassin's Creed Odyssey",
                Description = "Assassin's Creed Odyssey is a 2018 action rpg game. It is set in ancient Greece during the Peloponnesian War and lets players choose Kassandra or Alexios as a mercenary connected to a family mystery and secretive cult. Gameplay includes dialogue choices, branching quests, melee and ranged combat, abilities, equipment builds, naval exploration, conquest battles, and a large open world.",
                ReleaseYear = 2018,
                Platform = "PC; PS4; Xbox One; Nintendo Switch (Cloud)",
                Genre = "Action RPG",
                CoverImage = "/images/games/assassins-creed-odyssey.webp"
            },
            new Game
            {
                Title = "Assassin's Creed Valhalla",
                Description = "Assassin's Creed Valhalla is a 2020 action rpg game. It follows the Viking Eivor from Norway to England during the ninth century as their clan builds a new settlement and forms regional alliances. Gameplay combines raids, melee combat, stealth, exploration, settlement upgrades, equipment, dialogue choices, and long story arcs across England.",
                ReleaseYear = 2020,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S",
                Genre = "Action RPG",
                CoverImage = "/images/games/assassins-creed-valhalla.webp"
            },
            new Game
            {
                Title = "Assassin's Creed Mirage",
                Description = "Assassin's Creed Mirage is a 2023 action-adventure game. It is set mainly in ninth-century Baghdad and follows Basim Ibn Ishaq before the events of Assassin's Creed Valhalla as he grows from street thief to member of the Hidden Ones. The game returns to a stronger focus on stealth, assassinations, investigations, parkour, tools, and a more compact city environment.",
                ReleaseYear = 2023,
                Platform = "PC; PS4; PS5; Xbox One; Xbox Series X|S; iOS",
                Genre = "Action-Adventure",
                CoverImage = "/images/games/assassins-creed-mirage.webp"
            }
        };

        context.Games.AddRange(games);
        await context.SaveChangesAsync();
    }
}