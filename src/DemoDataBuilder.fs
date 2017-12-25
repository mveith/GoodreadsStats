module DemoDataBuilder

open Model
open System

let random = new Random()
let randomReadData()=
    let year = random.Next(DateTime.Today.Year - 5, DateTime.Today.Year)
    let month = random.Next(1, 12)
    let day = random.Next(1, 28)
    let start = new DateTime(year,month,day)
    let length = random.Next(1,100)
    {StartedAt = start; ReadAt =start.AddDays(float length) }

let randomShelves() = 
    match random.Next(1,5) with
    | 1 -> [|"owned"|]
    | 2 -> [|"owned"; "favorites"|]
    | 3 -> [|"kindle"|]
    | 4 -> [|"wtf"|]
    | 5 -> [|"favorites"|]
    | _ -> [||]

let randomLanguage() = 
    match random.Next(1,100) with
    | i when i < 20 -> "Czech"
    | i when i < 30 -> "Slovak"
    | i when i < 40 -> "Spanish"
    | _ -> "English"

let readBooks()=
    [|
        {ReadData = None;
        NumPages = 374;
        BookTitle = "The Hunger Games (The Hunger Games, #1)";
        AuthorName = "Suzanne Collins";
        ReviewId = 2767052;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1447303603s/2767052.jpg";
        BookId = 2767052;}
        {ReadData = None;
        NumPages = 197;
        BookTitle = "The Alchemist";
        AuthorName = "Paulo Coelho";
        ReviewId = 865;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1483412266s/865.jpg";
        BookId = 865;}
        {ReadData = None;
        NumPages = 325;
        BookTitle = "The Girl on the Train";
        AuthorName = "Paula Hawkins";
        ReviewId = 22557272;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1490903702s/22557272.jpg";
        BookId = 22557272;}
        {ReadData = None;
        NumPages = 1463;
        BookTitle = "Les Misérables";
        AuthorName = "Victor Hugo";
        ReviewId = 24280;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1411852091s/24280.jpg";
        BookId = 24280;}
        {ReadData = None;
        NumPages = 530;
        BookTitle = "All the Light We Cannot See";
        AuthorName = "Anthony Doerr";
        ReviewId = 18143977;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1451445646s/18143977.jpg";
        BookId = 18143977;}
        {ReadData = None;
        NumPages = 387;
        BookTitle = "Cinder (The Lunar Chronicles, #1)";
        AuthorName = "Marissa Meyer";
        ReviewId = 11235712;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1470056948s/11235712.jpg";
        BookId = 11235712;}
        {ReadData = None;
        NumPages = 398;
        BookTitle = "The Princess Bride ";
        AuthorName = "William Goldman";
        ReviewId = 21787;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327903636s/21787.jpg";
        BookId = 21787;}
        {ReadData = None;
        NumPages = 227;
        BookTitle = "Fahrenheit 451";
        AuthorName = "Ray Bradbury";
        ReviewId = 17470674;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1469704347s/17470674.jpg";
        BookId = 17470674;}
        {ReadData = None;
        NumPages = 964;
        BookTitle = "Anna Karenina";
        AuthorName = "Leo Tolstoy";
        ReviewId = 15823480;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1352422904s/15823480.jpg";
        BookId = 15823480;}
        {ReadData = None;
        NumPages = 457;
        BookTitle = "One Hundred Years of Solitude";
        AuthorName = "Gabriel García Márquez";
        ReviewId = 320;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327881361s/320.jpg";
        BookId = 320;}
        {ReadData = None;
        NumPages = 182;
        BookTitle = "Lord of the Flies";
        AuthorName = "William Golding";
        ReviewId = 7624;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327869409s/7624.jpg";
        BookId = 7624;}
        {ReadData = None;
        NumPages = 489;
        BookTitle = "A Tale of Two Cities";
        AuthorName = "Charles Dickens";
        ReviewId = 1953;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1344922523s/1953.jpg";
        BookId = 1953;}
        {ReadData = None;
        NumPages = 384;
        BookTitle = "The Maze Runner (Maze Runner, #1)";
        AuthorName = "James Dashner";
        ReviewId = 6186357;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1375596592s/6186357.jpg";
        BookId = 6186357;}
        {ReadData = None;
        NumPages = 201;
        BookTitle = "If I Stay (If I Stay, #1)";
        AuthorName = "Gayle Forman";
        ReviewId = 4374400;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1347462970s/4374400.jpg";
        BookId = 4374400;}
        {ReadData = None;
        NumPages = 482;
        BookTitle = "Clockwork Angel (The Infernal Devices, #1)";
        AuthorName = "Cassandra Clare";
        ReviewId = 7171637;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1454962884s/7171637.jpg";
        BookId = 7171637;}
        {ReadData = None;
        NumPages = 1276;
        BookTitle = "The Count of Monte Cristo";
        AuthorName = "Alexandre Dumas";
        ReviewId = 7126;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1309203605s/7126.jpg";
        BookId = 7126;}
        {ReadData = None;
        NumPages = 449;
        BookTitle = "Little Women (Little Women, #1)";
        AuthorName = "Louisa May Alcott";
        ReviewId = 1934;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 1934;}
        {ReadData = None;
        NumPages = 409;
        BookTitle = "Sense and Sensibility";
        AuthorName = "Jane Austen";
        ReviewId = 14935;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1397245675s/14935.jpg";
        BookId = 14935;}
        {ReadData = None;
        NumPages = 283;
        BookTitle = "Bossypants";
        AuthorName = "Tina Fey";
        ReviewId = 9418327;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1481509554s/9418327.jpg";
        BookId = 9418327;}
        {ReadData = None;
        NumPages = 325;
        BookTitle = "One Flew Over the Cuckoo's Nest";
        AuthorName = "Ken Kesey";
        ReviewId = 332613;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1485308778s/332613.jpg";
        BookId = 332613;}
        {ReadData = None;
        NumPages = 529;
        BookTitle = "Middlesex";
        AuthorName = "Jeffrey Eugenides";
        ReviewId = 2187;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1437029776s/2187.jpg";
        BookId = 2187;}
        {ReadData = None;
        NumPages = 329;
        BookTitle = "Yes Please";
        AuthorName = "Amy Poehler";
        ReviewId = 20910157;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1402815435s/20910157.jpg";
        BookId = 20910157;}
        {ReadData = None;
        NumPages = 473;
        BookTitle =
        "Unbroken: A World War II Story of Survival, Resilience, and Redemption";
        AuthorName = "Laura Hillenbrand";
        ReviewId = 8664353;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327861115s/8664353.jpg";
        BookId = 8664353;}
        {ReadData = None;
        NumPages = 336;
        BookTitle = "The Secret Life of Bees";
        AuthorName = "Sue Monk Kidd";
        ReviewId = 37435;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1473454532s/37435.jpg";
        BookId = 37435;}
        {ReadData = None;
        NumPages = 488;
        BookTitle = "Dracula";
        AuthorName = "Bram Stoker";
        ReviewId = 17245;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1387151694s/17245.jpg";
        BookId = 17245;}
        {ReadData = None;
        NumPages = 545;
        BookTitle = "Crime and Punishment";
        AuthorName = "Fyodor Dostoyevsky";
        ReviewId = 7144;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1382846449s/7144.jpg";
        BookId = 7144;}
        {ReadData = None;
        NumPages = 404;
        BookTitle = "Throne of Glass (Throne of Glass, #1)";
        AuthorName = "Sarah J. Maas";
        ReviewId = 7896527;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1335819760s/7896527.jpg";
        BookId = 7896527;}
        {ReadData = None;
        NumPages = 283;
        BookTitle = "Romeo and Juliet";
        AuthorName = "William Shakespeare";
        ReviewId = 18135;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327872146s/18135.jpg";
        BookId = 18135;}
        {ReadData = None;
        NumPages = 399;
        BookTitle = "The Golden Compass (His Dark Materials, #1)";
        AuthorName = "Philip Pullman";
        ReviewId = 119322;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1451271747s/119322.jpg";
        BookId = 119322;}
        {ReadData = None;
        NumPages = 457;
        BookTitle = "The 5th Wave (The 5th Wave, #1)";
        AuthorName = "Rick Yancey";
        ReviewId = 16101128;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1359853842s/16101128.jpg";
        BookId = 16101128;}
        {ReadData = None;
        NumPages = 662;
        BookTitle = "The Name of the Wind (The Kingkiller Chronicle, #1)";
        AuthorName = "Patrick Rothfuss";
        ReviewId = 186074;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1472068073s/186074.jpg";
        BookId = 186074;}
        {ReadData = None;
        NumPages = 332;
        BookTitle = "Vampire Academy (Vampire Academy, #1)";
        AuthorName = "Richelle Mead";
        ReviewId = 345627;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1361098973s/345627.jpg";
        BookId = 345627;}
        {ReadData = None;
        NumPages = 422;
        BookTitle = "Daughter of Smoke & Bone (Daughter of Smoke & Bone, #1)";
        AuthorName = "Laini Taylor";
        ReviewId = 8490112;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1461353773s/8490112.jpg";
        BookId = 8490112;}
        {ReadData = None;
        NumPages = 315;
        BookTitle = "Wild: From Lost to Found on the Pacific Crest Trail";
        AuthorName = "Cheryl Strayed";
        ReviewId = 12262741;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1453189881s/12262741.jpg";
        BookId = 12262741;}
        {ReadData = None;
        NumPages = 206;
        BookTitle = "The Lion, the Witch, and the Wardrobe (Chronicles of Narnia, #1)";
        AuthorName = "C.S. Lewis";
        ReviewId = 100915;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1353029077s/100915.jpg";
        BookId = 100915;}
        {ReadData = None;
        NumPages = 272;
        BookTitle = "Me Talk Pretty One Day";
        AuthorName = "David Sedaris";
        ReviewId = 4137;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 4137;}
        {ReadData = None;
        NumPages = 429;
        BookTitle = "In the Woods (Dublin Murder Squad, #1)";
        AuthorName = "Tana French";
        ReviewId = 237209;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1348442606s/237209.jpg";
        BookId = 237209;}
        {ReadData = None;
        NumPages = 369;
        BookTitle = "The Martian";
        AuthorName = "Andy Weir";
        ReviewId = 18007564;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1413706054s/18007564.jpg";
        BookId = 18007564;}
        {ReadData = None;
        NumPages = 229;
        BookTitle = "An Abundance of Katherines";
        AuthorName = "John Green";
        ReviewId = 49750;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1360206426s/49750.jpg";
        BookId = 49750;}
        {ReadData = None;
        NumPages = 222;
        BookTitle = "Is Everyone Hanging Out Without Me? (And Other Concerns)";
        AuthorName = "Mindy Kaling";
        ReviewId = 10335308;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1443264638s/10335308.jpg";
        BookId = 10335308;}
        {ReadData = None;
        NumPages = 455;
        BookTitle = "The Cuckoo's Calling (Cormoran Strike, #1)";
        AuthorName = "Robert Galbraith";
        ReviewId = 16160797;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1358716559s/16160797.jpg";
        BookId = 16160797;}
        {ReadData = None;
        NumPages = 474;
        BookTitle = "Emma";
        AuthorName = "Jane Austen";
        ReviewId = 6969;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1373627931s/6969.jpg";
        BookId = 6969;}
        {ReadData = None;
        NumPages = 541;
        BookTitle = "The Odyssey";
        AuthorName = "Homer";
        ReviewId = 1381;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1390173285s/1381.jpg";
        BookId = 1381;}
        {ReadData = None;
        NumPages = 604;
        BookTitle = "Dune";
        AuthorName = "Frank Herbert";
        ReviewId = 234225;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1434908555s/234225.jpg";
        BookId = 234225;}
        {ReadData = None;
        NumPages = 374;
        BookTitle = "Ready Player One";
        AuthorName = "Ernest Cline";
        ReviewId = 9969571;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1489368740s/9969571.jpg";
        BookId = 9969571;}
        {ReadData = None;
        NumPages = 505;
        BookTitle = "Great Expectations";
        AuthorName = "Charles Dickens";
        ReviewId = 2623;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327920219s/2623.jpg";
        BookId = 2623;}
        {ReadData = None;
        NumPages = 312;
        BookTitle = "The Graveyard Book";
        AuthorName = "Neil Gaiman";
        ReviewId = 2213661;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1303859949s/2213661.jpg";
        BookId = 2213661;}
        {ReadData = None;
        NumPages = 496;
        BookTitle = "A Tree Grows in Brooklyn";
        AuthorName = "Betty  Smith";
        ReviewId = 14891;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327883484s/14891.jpg";
        BookId = 14891;}
        {ReadData = None;
        NumPages = 249;
        BookTitle = "Persuasion";
        AuthorName = "Jane Austen";
        ReviewId = 2156;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 2156;}
        {ReadData = None;
        NumPages = 331;
        BookTitle = "The Secret Garden";
        AuthorName = "Frances Hodgson Burnett";
        ReviewId = 2998;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327873635s/2998.jpg";
        BookId = 2998;}
        {ReadData = None;
        NumPages = 399;
        BookTitle = "Across the Universe (Across the Universe, #1)";
        AuthorName = "Beth Revis";
        ReviewId = 8235178;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 8235178;}
        {ReadData = None;
        NumPages = 132;
        BookTitle = "The Old Man and the Sea";
        AuthorName = "Ernest Hemingway";
        ReviewId = 2165;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1329189714s/2165.jpg";
        BookId = 2165;}
        {ReadData = None;
        NumPages = 973;
        BookTitle = "The Pillars of the Earth";
        AuthorName = "Ken Follett";
        ReviewId = 5043;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 5043;}
        {ReadData = None;
        NumPages = 368;
        BookTitle = "Perfect Chemistry (Perfect Chemistry, #1)";
        AuthorName = "Simone Elkeles";
        ReviewId = 4268157;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1439792475s/4268157.jpg";
        BookId = 4268157;}
        {ReadData = None;
        NumPages = 123;
        BookTitle = "The Stranger";
        AuthorName = "Albert Camus";
        ReviewId = 49552;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1349927872s/49552.jpg";
        BookId = 49552;}
        {ReadData = None;
        NumPages = 310;
        BookTitle = "Will Grayson, Will Grayson";
        AuthorName = "John Green";
        ReviewId = 6567017;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1368393890s/6567017.jpg";
        BookId = 6567017;}
        {ReadData = None;
        NumPages = 444;
        BookTitle = "It's Kind of a Funny Story";
        AuthorName = "Ned Vizzini";
        ReviewId = 248704;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1420629730s/248704.jpg";
        BookId = 248704;}
        {ReadData = None;
        NumPages = 409;
        BookTitle = "The Raven Boys (The Raven Cycle, #1)";
        AuthorName = "Maggie Stiefvater";
        ReviewId = 17675462;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1477103737s/17675462.jpg";
        BookId = 17675462;}
        {ReadData = None;
        NumPages = 795;
        BookTitle = "The Brothers Karamazov";
        AuthorName = "Fyodor Dostoyevsky";
        ReviewId = 4934;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1427728126s/4934.jpg";
        BookId = 4934;}
        {ReadData = None;
        NumPages = 1116;
        BookTitle = "It";
        AuthorName = "Stephen King";
        ReviewId = 830502;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1334416842s/830502.jpg";
        BookId = 830502;}
        {ReadData = None;
        NumPages = 423;
        BookTitle = "My Sister's Keeper";
        AuthorName = "Jodi Picoult";
        ReviewId = 10917;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1369504683s/10917.jpg";
        BookId = 10917;}
        {ReadData = None;
        NumPages = 579;
        BookTitle = "A Discovery of Witches (All Souls Trilogy, #1)";
        AuthorName = "Deborah Harkness";
        ReviewId = 8667848;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1322168805s/8667848.jpg";
        BookId = 8667848;}
        {ReadData = None;
        NumPages = 382;
        BookTitle = "Red Rising (Red Rising, #1)";
        AuthorName = "Pierce Brown";
        ReviewId = 15839976;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1461354651s/15839976.jpg";
        BookId = 15839976;}
        {ReadData = None;
        NumPages = 335;
        BookTitle = "Unwind (Unwind, #1)";
        AuthorName = "Neal Shusterman";
        ReviewId = 764347;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1297677706s/764347.jpg";
        BookId = 764347;}
        {ReadData = None;
        NumPages = 184;
        BookTitle = "Man's Search for Meaning";
        AuthorName = "Viktor E. Frankl";
        ReviewId = 4069;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1467136625s/4069.jpg";
        BookId = 4069;}
        {ReadData = None;
        NumPages = 273;
        BookTitle = "The Art of War";
        AuthorName = "Sun Tzu";
        ReviewId = 10534;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1453417993s/10534.jpg";
        BookId = 10534;}
        {ReadData = None;
        NumPages = 784;
        BookTitle = "Harry Potter and the Deathly Hallows (Harry Potter, #7)";
        AuthorName = "J.K. Rowling";
        ReviewId = 136251;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1474171184s/136251.jpg";
        BookId = 136251;}
        {ReadData = None;
        NumPages = 415;
        BookTitle = "Truly Madly Guilty";
        AuthorName = "Liane Moriarty";
        ReviewId = 26247008;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1491249206s/26247008.jpg";
        BookId = 26247008;}
        {ReadData = None;
        NumPages = 462;
        BookTitle = "Six of Crows (Six of Crows, #1)";
        AuthorName = "Leigh Bardugo";
        ReviewId = 23437156;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1459349344s/23437156.jpg";
        BookId = 23437156;}
        {ReadData = None;
        NumPages = 224;
        BookTitle = "The Boy in the Striped Pajamas";
        AuthorName = "John Boyne";
        ReviewId = 39999;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1366228171s/39999.jpg";
        BookId = 39999;}
        {ReadData = None;
        NumPages = 421;
        BookTitle = "A Court of Thorns and Roses (A Court of Thorns and Roses, #1)";
        AuthorName = "Sarah J. Maas";
        ReviewId = 16096824;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1491595796s/16096824.jpg";
        BookId = 16096824;}
        {ReadData = None;
        NumPages = 208;
        BookTitle = "Speak";
        AuthorName = "Laurie Halse Anderson";
        ReviewId = 439288;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1310121762s/439288.jpg";
        BookId = 439288;}
        {ReadData = None;
        NumPages = 64;
        BookTitle = "The Giving Tree";
        AuthorName = "Shel Silverstein";
        ReviewId = 370493;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1174210942s/370493.jpg";
        BookId = 370493;}
        {ReadData = None;
        NumPages = 432;
        BookTitle = "The Devil Wears Prada (The Devil Wears Prada, #1)";
        AuthorName = "Lauren Weisberger";
        ReviewId = 5139;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 5139;}
        {ReadData = None;
        NumPages = 233;
        BookTitle = "Girl with a Pearl Earring";
        AuthorName = "Tracy Chevalier";
        ReviewId = 2865;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327197580s/2865.jpg";
        BookId = 2865;}
        {ReadData = None;
        NumPages = 256;
        BookTitle = "The Sun Also Rises";
        AuthorName = "Ernest Hemingway";
        ReviewId = 3876;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1331828228s/3876.jpg";
        BookId = 3876;}
        {ReadData = None;
        NumPages = 266;
        BookTitle = "Stardust";
        AuthorName = "Neil Gaiman";
        ReviewId = 16793;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1459127484s/16793.jpg";
        BookId = 16793;}
        {ReadData = None;
        NumPages = 336;
        BookTitle = "Easy (Contours of the Heart, #1)";
        AuthorName = "Tammara Webber";
        ReviewId = 16056408;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1349370267s/16056408.jpg";
        BookId = 16056408;}
        {ReadData = None;
        NumPages = 400;
        BookTitle = "A Darker Shade of Magic (Shades of Magic, #1)";
        AuthorName = "V.E. Schwab";
        ReviewId = 22055262;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1400322851s/22055262.jpg";
        BookId = 22055262;}
        {ReadData = None;
        NumPages = 751;
        BookTitle = "John Adams";
        AuthorName = "David McCullough";
        ReviewId = 2203;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1478144278s/2203.jpg";
        BookId = 2203;}
        {ReadData = None;
        NumPages = 320;
        BookTitle = "The Unbearable Lightness of Being";
        AuthorName = "Milan Kundera";
        ReviewId = 9717;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1265401884s/9717.jpg";
        BookId = 9717;}
        {ReadData = None;
        NumPages = 323;
        BookTitle = "Attachments";
        AuthorName = "Rainbow Rowell";
        ReviewId = 8909152;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1398982892s/8909152.jpg";
        BookId = 8909152;}
        {ReadData = None;
        NumPages = 471;
        BookTitle = "For Whom the Bell Tolls";
        AuthorName = "Ernest Hemingway";
        ReviewId = 46170;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1170314772s/46170.jpg";
        BookId = 46170;}
        {ReadData = None;
        NumPages = 1153;
        BookTitle = "The Stand";
        AuthorName = "Stephen King";
        ReviewId = 149267;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1213131305s/149267.jpg";
        BookId = 149267;}
        {ReadData = None;
        NumPages = 652;
        BookTitle = "Harry Potter and the Half-Blood Prince (Harry Potter, #6)";
        AuthorName = "J.K. Rowling";
        ReviewId = 1;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1361039191s/1.jpg";
        BookId = 1;}
        {ReadData = None;
        NumPages = 1125;
        BookTitle = "A Dance with Dragons (A Song of Ice and Fire, #5)";
        AuthorName = "George R.R. Martin";
        ReviewId = 10664113;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327885335s/10664113.jpg";
        BookId = 10664113;}
        {ReadData = None;
        NumPages = 394;
        BookTitle = "My Life Next Door";
        AuthorName = "Huntley Fitzpatrick";
        ReviewId = 12294652;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1394240144s/12294652.jpg";
        BookId = 12294652;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "A People's History of the United States";
        AuthorName = "Howard Zinn";
        ReviewId = 2767;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1407105086s/2767.jpg";
        BookId = 2767;}
        {ReadData = None;
        NumPages = 306;
        BookTitle = "Cat's Cradle";
        AuthorName = "Kurt Vonnegut";
        ReviewId = 135479;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327867150s/135479.jpg";
        BookId = 135479;}
        {ReadData = None;
        NumPages = 276;
        BookTitle = "Dear John";
        AuthorName = "Nicholas Sparks";
        ReviewId = 5526;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1397749854s/5526.jpg";
        BookId = 5526;}
        {ReadData = None;
        NumPages = 461;
        BookTitle = "Inferno (Robert Langdon, #4)";
        AuthorName = "Dan Brown";
        ReviewId = 17212231;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1397093185s/17212231.jpg";
        BookId = 17212231;}
        {ReadData = None;
        NumPages = 925;
        BookTitle = "1Q84";
        AuthorName = "Haruki Murakami";
        ReviewId = 10357575;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1483103331s/10357575.jpg";
        BookId = 10357575;}
        {ReadData = None;
        NumPages = 310;
        BookTitle = "Everything, Everything";
        AuthorName = "Nicola Yoon";
        ReviewId = 18692431;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1450515891s/18692431.jpg";
        BookId = 18692431;}
        {ReadData = None;
        NumPages = 535;
        BookTitle = "City of Lost Souls (The Mortal Instruments, #5)";
        AuthorName = "Cassandra Clare";
        ReviewId = 8755776;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1460477703s/8755776.jpg";
        BookId = 8755776;}
        {ReadData = None;
        NumPages = 705;
        BookTitle = "House of Leaves";
        AuthorName = "Mark Z. Danielewski";
        ReviewId = 24800;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1403889034s/24800.jpg";
        BookId = 24800;}
        {ReadData = None;
        NumPages = 225;
        BookTitle = "The Adventures of Tom Sawyer";
        AuthorName = "Mark Twain";
        ReviewId = 24583;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1404811979s/24583.jpg";
        BookId = 24583;}
        {ReadData = None;
        NumPages = 307;
        BookTitle = "On the Road";
        AuthorName = "Jack Kerouac";
        ReviewId = 70401;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1413588576s/70401.jpg";
        BookId = 70401;}
        {ReadData = None;
        NumPages = 359;
        BookTitle =
        "Aristotle and Dante Discover the Secrets of the Universe (Aristotle and Dante Discover the Secrets of the Universe, #1)";
        AuthorName = "Benjamin Alire Sáenz";
        ReviewId = 12000020;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1328320260s/12000020.jpg";
        BookId = 12000020;}
        {ReadData = None;
        NumPages = 698;
        BookTitle = "Lady Midnight (The Dark Artifices, #1)";
        AuthorName = "Cassandra Clare";
        ReviewId = 25494343;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1460477682s/25494343.jpg";
        BookId = 25494343;}
        {ReadData = None;
        NumPages = 1023;
        BookTitle = "Don Quixote";
        AuthorName = "Miguel de Cervantes Saavedra";
        ReviewId = 3836;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1364958765s/3836.jpg";
        BookId = 3836;}
        {ReadData = None;
        NumPages = 118;
        BookTitle = "The Time Machine";
        AuthorName = "H.G. Wells";
        ReviewId = 2493;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327942880s/2493.jpg";
        BookId = 2493;}
        {ReadData = None;
        NumPages = 453;
        BookTitle = "City of Ashes (The Mortal Instruments, #2)";
        AuthorName = "Cassandra Clare";
        ReviewId = 1582996;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1432730356s/1582996.jpg";
        BookId = 1582996;}
        {ReadData = None;
        NumPages = 337;
        BookTitle = "A Man Called Ove";
        AuthorName = "Fredrik Backman";
        ReviewId = 18774964;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1405259930s/18774964.jpg";
        BookId = 18774964;}
        {ReadData = None;
        NumPages = 256;
        BookTitle = "Foundation (Foundation #1)";
        AuthorName = "Isaac Asimov";
        ReviewId = 29579;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1417900846s/29579.jpg";
        BookId = 29579;}
        {ReadData = None;
        NumPages = 315;
        BookTitle = "Running with Scissors";
        AuthorName = "Augusten Burroughs";
        ReviewId = 242006;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 242006;}
        {ReadData = None;
        NumPages = 446;
        BookTitle = "An Ember in the Ashes (An Ember in the Ashes, #1)";
        AuthorName = "Sabaa Tahir";
        ReviewId = 27774758;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1449158871s/27774758.jpg";
        BookId = 27774758;}
        {ReadData = None;
        NumPages = 334;
        BookTitle = "Bared to You (Crossfire, #1)";
        AuthorName = "Sylvia Day";
        ReviewId = 20448515;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1433411511s/20448515.jpg";
        BookId = 20448515;}
        {ReadData = None;
        NumPages = 393;
        BookTitle = "Dark Lover (Black Dagger Brotherhood, #1)";
        AuthorName = "J.R. Ward";
        ReviewId = 42899;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1429676285s/42899.jpg";
        BookId = 42899;}
        {ReadData = None;
        NumPages = 320;
        BookTitle = "Anna Dressed in Blood (Anna, #1)";
        AuthorName = "Kendare Blake";
        ReviewId = 9378297;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1398637405s/9378297.jpg";
        BookId = 9378297;}
        {ReadData = None;
        NumPages = 374;
        BookTitle = "The God Delusion";
        AuthorName = "Richard Dawkins";
        ReviewId = 14743;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1347220693s/14743.jpg";
        BookId = 14743;}
        {ReadData = None;
        NumPages = 278;
        BookTitle = "Orphan Train";
        AuthorName = "Christina Baker Kline";
        ReviewId = 15818107;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1362409483s/15818107.jpg";
        BookId = 15818107;}
        {ReadData = None;
        NumPages = 240;
        BookTitle = "Why Not Me?";
        AuthorName = "Mindy Kaling";
        ReviewId = 30268522;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1473956249s/30268522.jpg";
        BookId = 30268522;}
        {ReadData = None;
        NumPages = 470;
        BookTitle = "P.S. I Love You";
        AuthorName = "Cecelia Ahern";
        ReviewId = 366522;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 366522;}
        {ReadData = None;
        NumPages = 92;
        BookTitle = "Alice in Wonderland (Alice's Adventures in Wonderland, #1)";
        AuthorName = "Jane Carruth";
        ReviewId = 13023;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 13023;}
        {ReadData = None;
        NumPages = 314;
        BookTitle = "The Paris Wife";
        AuthorName = "Paula McLain";
        ReviewId = 8683812;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1320545874s/8683812.jpg";
        BookId = 8683812;}
        {ReadData = None;
        NumPages = 399;
        BookTitle = "Jurassic Park";
        AuthorName = "Michael Crichton";
        ReviewId = 6424171;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1344371661s/6424171.jpg";
        BookId = 6424171;}
        {ReadData = None;
        NumPages = 1061;
        BookTitle = "A Feast for Crows (A Song of Ice and Fire, #4)";
        AuthorName = "George R.R. Martin";
        ReviewId = 13497;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1429538615s/13497.jpg";
        BookId = 13497;}
        {ReadData = None;
        NumPages = 424;
        BookTitle = "City of Fallen Angels (The Mortal Instruments, #4)";
        AuthorName = "Cassandra Clare";
        ReviewId = 6752378;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1369452302s/6752378.jpg";
        BookId = 6752378;}
        {ReadData = None;
        NumPages = 346;
        BookTitle = "All the Ugly and Wonderful Things";
        AuthorName = "Bryn Greenwood";
        ReviewId = 26114135;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1485510210s/26114135.jpg";
        BookId = 26114135;}
        {ReadData = None;
        NumPages = 608;
        BookTitle = "Oliver Twist";
        AuthorName = "Charles Dickens";
        ReviewId = 18254;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327868529s/18254.jpg";
        BookId = 18254;}
        {ReadData = None;
        NumPages = 493;
        BookTitle = "Benjamin Franklin: An American Life";
        AuthorName = "Walter Isaacson";
        ReviewId = 10883;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1397772877s/10883.jpg";
        BookId = 10883;}
        {ReadData = None;
        NumPages = 289;
        BookTitle = "Hamlet";
        AuthorName = "William Shakespeare";
        ReviewId = 1420;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1351051208s/1420.jpg";
        BookId = 1420;}
        {ReadData = None;
        NumPages = 269;
        BookTitle = "Snow Flower and the Secret Fan";
        AuthorName = "Lisa See";
        ReviewId = 1103;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327880508s/1103.jpg";
        BookId = 1103;}
        {ReadData = None;
        NumPages = 210;
        BookTitle = "Tuesdays with Morrie";
        AuthorName = "Mitch Albom";
        ReviewId = 6900;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1423763749s/6900.jpg";
        BookId = 6900;}
        {ReadData = None;
        NumPages = 320;
        BookTitle = "Confess";
        AuthorName = "Colleen Hoover";
        ReviewId = 34324605;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1490524804s/34324605.jpg";
        BookId = 34324605;}
        {ReadData = None;
        NumPages = 252;
        BookTitle = "The Shack";
        AuthorName = "William Paul Young";
        ReviewId = 1812457;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1344270232s/1812457.jpg";
        BookId = 1812457;}
        {ReadData = None;
        NumPages = 478;
        BookTitle = "Watership Down (Watership Down #1)";
        AuthorName = "Richard Adams";
        ReviewId = 76620;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1405136931s/76620.jpg";
        BookId = 76620;}
        {ReadData = None;
        NumPages = 371;
        BookTitle =
        "Hyperbole and a Half: Unfortunate Situations, Flawed Coping Mechanisms, Mayhem, and Other Things That Happened";
        AuthorName = "Allie Brosh";
        ReviewId = 17571564;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1409522492s/17571564.jpg";
        BookId = 17571564;}
        {ReadData = None;
        NumPages = 109;
        BookTitle = "The Tales of Beedle the Bard";
        AuthorName = "J.K. Rowling";
        ReviewId = 3950967;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1373467575s/3950967.jpg";
        BookId = 3950967;}
        {ReadData = None;
        NumPages = 320;
        BookTitle = "Anne of Green Gables (Anne of Green Gables, #1)";
        AuthorName = "L.M. Montgomery";
        ReviewId = 8127;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 8127;}
        {ReadData = None;
        NumPages = 410;
        BookTitle = "Hopeless (Hopeless, #1)";
        AuthorName = "Colleen Hoover";
        ReviewId = 15717943;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1353489892s/15717943.jpg";
        BookId = 15717943;}
        {ReadData = None;
        NumPages = 207;
        BookTitle = "Into the Wild";
        AuthorName = "Jon Krakauer";
        ReviewId = 1845;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1403173986s/1845.jpg";
        BookId = 1845;}
        {ReadData = None;
        NumPages = 467;
        BookTitle = "Kafka on the Shore";
        AuthorName = "Haruki Murakami";
        ReviewId = 4929;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 4929;}
        {ReadData = None;
        NumPages = 294;
        BookTitle = "Sarah's Key";
        AuthorName = "Tatiana de Rosnay";
        ReviewId = 556602;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 556602;}
        {ReadData = None;
        NumPages = 37;
        BookTitle = "Where the Wild Things Are";
        AuthorName = "Maurice Sendak";
        ReviewId = 19543;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1384434560s/19543.jpg";
        BookId = 19543;}
        {ReadData = None;
        NumPages = 144;
        BookTitle = "The Strange Case of Dr. Jekyll and Mr. Hyde";
        AuthorName = "Robert Louis Stevenson";
        ReviewId = 51496;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1318116526s/51496.jpg";
        BookId = 51496;}
        {ReadData = None;
        NumPages = 201;
        BookTitle = "The Metamorphosis";
        AuthorName = "Franz Kafka";
        ReviewId = 485894;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1359061917s/485894.jpg";
        BookId = 485894;}
        {ReadData = None;
        NumPages = 223;
        BookTitle = "The Screwtape Letters";
        AuthorName = "C.S. Lewis";
        ReviewId = 17383917;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1414551641s/17383917.jpg";
        BookId = 17383917;}
        {ReadData = None;
        NumPages = 0;
        BookTitle =
        "Steal Like an Artist: 10 Things Nobody Told You About Being Creative";
        AuthorName = "Austin Kleon";
        ReviewId = 13099738;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1404576602s/13099738.jpg";
        BookId = 13099738;}
        {ReadData = None;
        NumPages = 563;
        BookTitle = "The Girl Who Kicked the Hornet's Nest (Millennium, #3)";
        AuthorName = "Stieg Larsson";
        ReviewId = 6892870;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327708260s/6892870.jpg";
        BookId = 6892870;}
        {ReadData = None;
        NumPages = 217;
        BookTitle = "Lean In: Women, Work, and the Will to Lead";
        AuthorName = "Sheryl Sandberg";
        ReviewId = 16071764;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1364250803s/16071764.jpg";
        BookId = 16071764;}
        {ReadData = None;
        NumPages = 1177;
        BookTitle = "A Storm of Swords (A Song of Ice and Fire, #3)";
        AuthorName = "George R.R. Martin";
        ReviewId = 62291;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1471637043s/62291.jpg";
        BookId = 62291;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "The Fountainhead";
        AuthorName = "Ayn Rand";
        ReviewId = 2122;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1491163636s/2122.jpg";
        BookId = 2122;}
        {ReadData = None;
        NumPages = 477;
        BookTitle = "Americanah";
        AuthorName = "Chimamanda Ngozi Adichie";
        ReviewId = 15796700;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1356654499s/15796700.jpg";
        BookId = 15796700;}
        {ReadData = None;
        NumPages = 321;
        BookTitle = "Room";
        AuthorName = "Emma Donoghue";
        ReviewId = 7937843;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1344265419s/7937843.jpg";
        BookId = 7937843;}
        {ReadData = None;
        NumPages = 324;
        BookTitle = "Beloved";
        AuthorName = "Toni Morrison";
        ReviewId = 6149;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 6149;}
        {ReadData = None;
        NumPages = 399;
        BookTitle = "American Psycho";
        AuthorName = "Bret Easton Ellis";
        ReviewId = 28676;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1436934349s/28676.jpg";
        BookId = 28676;}
        {ReadData = None;
        NumPages = 392;
        BookTitle = "Pushing the Limits (Pushing the Limits, #1)";
        AuthorName = "Katie McGarry";
        ReviewId = 10194514;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1322770025s/10194514.jpg";
        BookId = 10194514;}
        {ReadData = None;
        NumPages = 397;
        BookTitle =
        "A Walk in the Woods: Rediscovering America on the Appalachian Trail";
        AuthorName = "Bill Bryson";
        ReviewId = 9791;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 9791;}
        {ReadData = None;
        NumPages = 251;
        BookTitle = "Northanger Abbey";
        AuthorName = "Jane Austen";
        ReviewId = 50398;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 50398;}
        {ReadData = None;
        NumPages = 304;
        BookTitle = "Under the Tuscan Sun";
        AuthorName = "Frances Mayes";
        ReviewId = 480479;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1320524083s/480479.jpg";
        BookId = 480479;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "It Ends with Us";
        AuthorName = "Colleen Hoover";
        ReviewId = 27362503;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1470427482s/27362503.jpg";
        BookId = 27362503;}
        {ReadData = None;
        NumPages = 320;
        BookTitle = "Stiff: The Curious Lives of Human Cadavers";
        AuthorName = "Mary Roach";
        ReviewId = 32145;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1347656489s/32145.jpg";
        BookId = 32145;}
        {ReadData = None;
        NumPages = 369;
        BookTitle = "Just One Day (Just One Day, #1)";
        AuthorName = "Gayle Forman";
        ReviewId = 17623975;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1368722144s/17623975.jpg";
        BookId = 17623975;}
        {ReadData = None;
        NumPages = 154;
        BookTitle = "The Wonderful Wizard of Oz (Oz, #1)";
        AuthorName = "L. Frank Baum";
        ReviewId = 236093;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1398003737s/236093.jpg";
        BookId = 236093;}
        {ReadData = None;
        NumPages = 293;
        BookTitle = "A Farewell to Arms";
        AuthorName = "Ernest Hemingway";
        ReviewId = 10799;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1313714836s/10799.jpg";
        BookId = 10799;}
        {ReadData = None;
        NumPages = 188;
        BookTitle = "Heart of Darkness";
        AuthorName = "Joseph Conrad";
        ReviewId = 4900;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1392799983s/4900.jpg";
        BookId = 4900;}
        {ReadData = None;
        NumPages = 1006;
        BookTitle = "Jonathan Strange & Mr Norrell";
        AuthorName = "Susanna Clarke";
        ReviewId = 14201;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1357027589s/14201.jpg";
        BookId = 14201;}
        {ReadData = None;
        NumPages = 376;
        BookTitle = "Good in Bed (Cannie Shapiro, #1)";
        AuthorName = "Jennifer Weiner";
        ReviewId = 14748;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327936464s/14748.jpg";
        BookId = 14748;}
        {ReadData = None;
        NumPages = 250;
        BookTitle = "Brain on Fire: My Month of Madness";
        AuthorName = "Susannah Cahalan";
        ReviewId = 13547180;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1353173297s/13547180.jpg";
        BookId = 13547180;}
        {ReadData = None;
        NumPages = 490;
        BookTitle = "The Return of the King (The Lord of the Rings, #3)";
        AuthorName = "J.R.R. Tolkien";
        ReviewId = 18512;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1389977161s/18512.jpg";
        BookId = 18512;}
        {ReadData = None;
        NumPages = 541;
        BookTitle = "Cutting for Stone";
        AuthorName = "Abraham Verghese";
        ReviewId = 3591262;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327931601s/3591262.jpg";
        BookId = 3591262;}
        {ReadData = None;
        NumPages = 451;
        BookTitle = "The Omnivore's Dilemma: A Natural History of Four Meals";
        AuthorName = "Michael Pollan";
        ReviewId = 3109;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1393804353s/3109.jpg";
        BookId = 3109;}
        {ReadData = None;
        NumPages = 1216;
        BookTitle = "The Lord of the Rings (The Lord of the Rings, #1-3)";
        AuthorName = "J.R.R. Tolkien";
        ReviewId = 33;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1411114164s/33.jpg";
        BookId = 33;}
        {ReadData = None;
        NumPages = 338;
        BookTitle = "The Silence of the Lambs  (Hannibal Lecter, #2)";
        AuthorName = "Thomas Harris";
        ReviewId = 23807;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1390426249s/23807.jpg";
        BookId = 23807;}
        {ReadData = None;
        NumPages = 340;
        BookTitle = "Safe Haven";
        AuthorName = "Nicholas Sparks";
        ReviewId = 7812659;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1344268800s/7812659.jpg";
        BookId = 7812659;}
        {ReadData = None;
        NumPages = 329;
        BookTitle = "Madame Bovary";
        AuthorName = "Gustave Flaubert";
        ReviewId = 2175;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1335676143s/2175.jpg";
        BookId = 2175;}
        {ReadData = None;
        NumPages = 255;
        BookTitle = "The Trial";
        AuthorName = "Franz Kafka";
        ReviewId = 17690;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1320399438s/17690.jpg";
        BookId = 17690;}
        {ReadData = None;
        NumPages = 374;
        BookTitle = "The Truth About Forever";
        AuthorName = "Sarah Dessen";
        ReviewId = 51737;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1362767907s/51737.jpg";
        BookId = 51737;}
        {ReadData = None;
        NumPages = 240;
        BookTitle = "Wall and Piece";
        AuthorName = "Banksy";
        ReviewId = 114683;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327904853s/114683.jpg";
        BookId = 114683;}
        {ReadData = None;
        NumPages = 375;
        BookTitle = "The Audacity of Hope: Thoughts on Reclaiming the American Dream";
        AuthorName = "Barack Obama";
        ReviewId = 9742;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 9742;}
        {ReadData = None;
        NumPages = 322;
        BookTitle = "The Two Towers (The Lord of the Rings, #2)";
        AuthorName = "J.R.R. Tolkien";
        ReviewId = 15241;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1298415523s/15241.jpg";
        BookId = 15241;}
        {ReadData = None;
        NumPages = 560;
        BookTitle = "Mansfield Park";
        AuthorName = "Jane Austen";
        ReviewId = 45032;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1397063295s/45032.jpg";
        BookId = 45032;}
        {ReadData = None;
        NumPages = 510;
        BookTitle = "The Hunchback of Notre-Dame";
        AuthorName = "Victor Hugo";
        ReviewId = 30597;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 30597;}
        {ReadData = None;
        NumPages = 896;
        BookTitle = "Doors of Stone (The Kingkiller Chronicle, #3)";
        AuthorName = "Patrick Rothfuss";
        ReviewId = 21032488;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 21032488;}
        {ReadData = None;
        NumPages = 388;
        BookTitle = "The Wrath & the Dawn (The Wrath & the Dawn, #1)";
        AuthorName = "Renee Ahdieh";
        ReviewId = 18798983;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1417956963s/18798983.jpg";
        BookId = 18798983;}
        {ReadData = None;
        NumPages = 386;
        BookTitle = "1776";
        AuthorName = "David McCullough";
        ReviewId = 1067;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1306787560s/1067.jpg";
        BookId = 1067;}
        {ReadData = None;
        NumPages = 256;
        BookTitle = "Their Eyes Were Watching God";
        AuthorName = "Zora Neale Hurston";
        ReviewId = 37415;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1368072803s/37415.jpg";
        BookId = 37415;}
        {ReadData = None;
        NumPages = 566;
        BookTitle = "The Bourne Identity (Jason Bourne, #1)";
        AuthorName = "Robert Ludlum";
        ReviewId = 7869;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1335860740s/7869.jpg";
        BookId = 7869;}
        {ReadData = None;
        NumPages = 703;
        BookTitle = "The Origin of Species";
        AuthorName = "Charles Darwin";
        ReviewId = 22463;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 22463;}
        {ReadData = None;
        NumPages = 432;
        BookTitle = "Angela's Ashes (Frank McCourt, #1)";
        AuthorName = "Frank McCourt";
        ReviewId = 252577;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 252577;}
        {ReadData = None;
        NumPages = 199;
        BookTitle = "The Secret (The Secret, #1)";
        AuthorName = "Rhonda Byrne";
        ReviewId = 52529;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1482865039s/52529.jpg";
        BookId = 52529;}
        {ReadData = None;
        NumPages = 578;
        BookTitle = "The Diviners (The Diviners, #1)";
        AuthorName = "Libba Bray";
        ReviewId = 7728889;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1336424966s/7728889.jpg";
        BookId = 7728889;}
        {ReadData = None;
        NumPages = 104;
        BookTitle = "A Christmas Carol";
        AuthorName = "Charles Dickens";
        ReviewId = 5326;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1406512317s/5326.jpg";
        BookId = 5326;}
        {ReadData = None;
        NumPages = 178;
        BookTitle = "Breakfast at Tiffany's";
        AuthorName = "Truman Capote";
        ReviewId = 251688;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1477015353s/251688.jpg";
        BookId = 251688;}
        {ReadData = None;
        NumPages = 528;
        BookTitle = "Stranger in a Strange Land";
        AuthorName = "Robert A. Heinlein";
        ReviewId = 350;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1156897088s/350.jpg";
        BookId = 350;}
        {ReadData = None;
        NumPages = 550;
        BookTitle = "Cress (The Lunar Chronicles, #3)";
        AuthorName = "Marissa Meyer";
        ReviewId = 13206828;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1470057005s/13206828.jpg";
        BookId = 13206828;}
        {ReadData = None;
        NumPages = 416;
        BookTitle = "The Republic";
        AuthorName = "Plato";
        ReviewId = 30289;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 30289;}
        {ReadData = None;
        NumPages = 311;
        BookTitle = "Treasure Island";
        AuthorName = "Robert Louis Stevenson";
        ReviewId = 295;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1485248909s/295.jpg";
        BookId = 295;}
        {ReadData = None;
        NumPages = 1614;
        BookTitle = "The Rise and Fall of the Third Reich: A History of Nazi Germany";
        AuthorName = "William L. Shirer";
        ReviewId = 767171;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1331223772s/767171.jpg";
        BookId = 767171;}
        {ReadData = None;
        NumPages = 400;
        BookTitle = "The Night Circus";
        AuthorName = "Erin Morgenstern";
        ReviewId = 9361589;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1387124618s/9361589.jpg";
        BookId = 9361589;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "The Importance of Being Earnest";
        AuthorName = "Oscar Wilde";
        ReviewId = 92303;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 92303;}
        {ReadData = None;
        NumPages = 1007;
        BookTitle = "The Way of Kings (The Stormlight Archive, #1)";
        AuthorName = "Brandon Sanderson";
        ReviewId = 7235533;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1489368762s/7235533.jpg";
        BookId = 7235533;}
        {ReadData = None;
        NumPages = 429;
        BookTitle = "Schindler's List";
        AuthorName = "Thomas Keneally";
        ReviewId = 375013;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1348163457s/375013.jpg";
        BookId = 375013;}
        {ReadData = None;
        NumPages = 344;
        BookTitle = "Amy & Roger's Epic Detour";
        AuthorName = "Morgan Matson";
        ReviewId = 7664334;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327989202s/7664334.jpg";
        BookId = 7664334;}
        {ReadData = None;
        NumPages = 263;
        BookTitle = "Perfume: The Story of a Murderer";
        AuthorName = "Patrick Süskind";
        ReviewId = 343;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1409112276s/343.jpg";
        BookId = 343;}
        {ReadData = None;
        NumPages = 340;
        BookTitle = "The God of Small Things";
        AuthorName = "Arundhati Roy";
        ReviewId = 9777;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1436217001s/9777.jpg";
        BookId = 9777;}
        {ReadData = None;
        NumPages = 390;
        BookTitle = "Fates and Furies";
        AuthorName = "Lauren Groff";
        ReviewId = 24612118;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1434750235s/24612118.jpg";
        BookId = 24612118;}
        {ReadData = None;
        NumPages = 228;
        BookTitle = "The Color of Magic (Discworld, #1; Rincewind #1)";
        AuthorName = "Terry Pratchett";
        ReviewId = 34497;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1407111017s/34497.jpg";
        BookId = 34497;}
        {ReadData = None;
        NumPages = 672;
        BookTitle = "The Woman in White";
        AuthorName = "Wilkie Collins";
        ReviewId = 5890;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1295661017s/5890.jpg";
        BookId = 5890;}
        {ReadData = None;
        NumPages = 407;
        BookTitle = "The Master and Margarita";
        AuthorName = "Mikhail Bulgakov";
        ReviewId = 117833;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327867963s/117833.jpg";
        BookId = 117833;}
        {ReadData = None;
        NumPages = 370;
        BookTitle = "Misery";
        AuthorName = "Stephen King";
        ReviewId = 10614;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1270545451s/10614.jpg";
        BookId = 10614;}
        {ReadData = None;
        NumPages = 499;
        BookTitle = "Thinking, Fast and Slow";
        AuthorName = "Daniel Kahneman";
        ReviewId = 11468377;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1317793965s/11468377.jpg";
        BookId = 11468377;}
        {ReadData = None;
        NumPages = 275;
        BookTitle = "The Psychopath Test: A Journey Through the Madness Industry";
        AuthorName = "Jon Ronson";
        ReviewId = 12391521;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1364166270s/12391521.jpg";
        BookId = 12391521;}
        {ReadData = None;
        NumPages = 360;
        BookTitle = "I Am the Messenger";
        AuthorName = "Markus Zusak";
        ReviewId = 19057;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1398483261s/19057.jpg";
        BookId = 19057;}
        {ReadData = None;
        NumPages = 814;
        BookTitle = "The Eye of the World (Wheel of Time, #1)";
        AuthorName = "Robert Jordan";
        ReviewId = 228665;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1337818095s/228665.jpg";
        BookId = 228665;}
        {ReadData = None;
        NumPages = 340;
        BookTitle = "The Woman in Cabin 10";
        AuthorName = "Ruth Ware";
        ReviewId = 28187230;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1465878007s/28187230.jpg";
        BookId = 28187230;}
        {ReadData = None;
        NumPages = 296;
        BookTitle = "All Quiet on the Western Front";
        AuthorName = "Erich Maria Remarque";
        ReviewId = 355697;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1441227765s/355697.jpg";
        BookId = 355697;}
        {ReadData = None;
        NumPages = 360;
        BookTitle = "The Phantom of the Opera";
        AuthorName = "Gaston Leroux";
        ReviewId = 480204;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327867727s/480204.jpg";
        BookId = 480204;}
        {ReadData = None;
        NumPages = 515;
        BookTitle = "The Art Book";
        AuthorName = "Phaidon Press";
        ReviewId = 567616;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1411210646s/567616.jpg";
        BookId = 567616;}
        {ReadData = None;
        NumPages = 518;
        BookTitle = "Tess of the D'Urbervilles";
        AuthorName = "Thomas Hardy";
        ReviewId = 32261;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1434302708s/32261.jpg";
        BookId = 32261;}
        {ReadData = None;
        NumPages = 447;
        BookTitle = "Sweet Evil (Sweet, #1)";
        AuthorName = "Wendy Higgins";
        ReviewId = 11808950;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1337613719s/11808950.jpg";
        BookId = 11808950;}
        {ReadData = None;
        NumPages = 276;
        BookTitle = "The Summer I Turned Pretty (Summer, #1)";
        AuthorName = "Jenny Han";
        ReviewId = 5821978;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1361666855s/5821978.jpg";
        BookId = 5821978;}
        {ReadData = None;
        NumPages = 530;
        BookTitle = "Thoughtless (Thoughtless, #1)";
        AuthorName = "S.C. Stephens";
        ReviewId = 13517535;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1331254339s/13517535.jpg";
        BookId = 13517535;}
        {ReadData = None;
        NumPages = 213;
        BookTitle =
        "The Life-Changing Magic of Tidying Up: The Japanese Art of Decluttering and Organizing";
        AuthorName = "Marie Kondō";
        ReviewId = 22318578;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1418767178s/22318578.jpg";
        BookId = 22318578;}
        {ReadData = None;
        NumPages = 492;
        BookTitle = "The Kiss of Deception (The Remnant Chronicles, #1)";
        AuthorName = "Mary E. Pearson";
        ReviewId = 16429619;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1389804901s/16429619.jpg";
        BookId = 16429619;}
        {ReadData = None;
        NumPages = 361;
        BookTitle =
        "The Battle of the Labyrinth (Percy Jackson and the Olympians, #4)";
        AuthorName = "Rick Riordan";
        ReviewId = 2120932;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1443142158s/2120932.jpg";
        BookId = 2120932;}
        {ReadData = None;
        NumPages = 305;
        BookTitle = "The Age of Innocence";
        AuthorName = "Edith Wharton";
        ReviewId = 53835;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 53835;}
        {ReadData = None;
        NumPages = 320;
        BookTitle = "On Writing: A Memoir of the Craft";
        AuthorName = "Stephen King";
        ReviewId = 10569;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1436735207s/10569.jpg";
        BookId = 10569;}
        {ReadData = None;
        NumPages = 270;
        BookTitle = "I Was Here";
        AuthorName = "Gayle Forman";
        ReviewId = 18879761;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1405960366s/18879761.jpg";
        BookId = 18879761;}
        {ReadData = None;
        NumPages = 435;
        BookTitle = "Uprooted";
        AuthorName = "Naomi Novik";
        ReviewId = 22544764;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1480121122s/22544764.jpg";
        BookId = 22544764;}
        {ReadData = None;
        NumPages = 848;
        BookTitle = "The Luminaries";
        AuthorName = "Eleanor Catton";
        ReviewId = 17333230;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1410524246s/17333230.jpg";
        BookId = 17333230;}
        {ReadData = None;
        NumPages = 438;
        BookTitle = "Uncle Tom's Cabin";
        AuthorName = "Harriet Beecher Stowe";
        ReviewId = 46787;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1414349231s/46787.jpg";
        BookId = 46787;}
        {ReadData = None;
        NumPages = 470;
        BookTitle = "Snow Crash";
        AuthorName = "Neal Stephenson";
        ReviewId = 830;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1477624625s/830.jpg";
        BookId = 830;}
        {ReadData = None;
        NumPages = 453;
        BookTitle = "Heartless";
        AuthorName = "Marissa Meyer";
        ReviewId = 18584855;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1477740245s/18584855.jpg";
        BookId = 18584855;}
        {ReadData = None;
        NumPages = 460;
        BookTitle = "The Storyteller";
        AuthorName = "Jodi Picoult";
        ReviewId = 15753740;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1356328634s/15753740.jpg";
        BookId = 15753740;}
        {ReadData = None;
        NumPages = 499;
        BookTitle = "Seraphina (Seraphina, #1)";
        AuthorName = "Rachel Hartman";
        ReviewId = 19549841;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1387577872s/19549841.jpg";
        BookId = 19549841;}
        {ReadData = None;
        NumPages = 289;
        BookTitle = "The Silver Linings Playbook";
        AuthorName = "Matthew Quick";
        ReviewId = 13539044;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1358277412s/13539044.jpg";
        BookId = 13539044;}
        {ReadData = None;
        NumPages = 258;
        BookTitle = "The Remains of the Day";
        AuthorName = "Kazuo Ishiguro";
        ReviewId = 28921;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327128714s/28921.jpg";
        BookId = 28921;}
        {ReadData = None;
        NumPages = 230;
        BookTitle = "The Absolutely True Diary of a Part-Time Indian";
        AuthorName = "Sherman Alexie";
        ReviewId = 693208;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327908992s/693208.jpg";
        BookId = 693208;}
        {ReadData = None;
        NumPages = 667;
        BookTitle = "The Idiot";
        AuthorName = "Fyodor Dostoyevsky";
        ReviewId = 12505;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327865902s/12505.jpg";
        BookId = 12505;}
        {ReadData = None;
        NumPages = 506;
        BookTitle = "The Demon King (Seven Realms, #1)";
        AuthorName = "Cinda Williams Chima";
        ReviewId = 6342491;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1379482652s/6342491.jpg";
        BookId = 6342491;}
        {ReadData = None;
        NumPages = 400;
        BookTitle = "We Need to Talk About Kevin";
        AuthorName = "Lionel Shriver";
        ReviewId = 80660;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327865017s/80660.jpg";
        BookId = 80660;}
        {ReadData = None;
        NumPages = 127;
        BookTitle = "The Prophet";
        AuthorName = "Kahlil Gibran";
        ReviewId = 2547;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1355046521s/2547.jpg";
        BookId = 2547;}
        {ReadData = None;
        NumPages = 661;
        BookTitle = "The Other Boleyn Girl (The Plantagenet and Tudor Novels, #9)";
        AuthorName = "Philippa Gregory";
        ReviewId = 37470;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1355932638s/37470.jpg";
        BookId = 37470;}
        {ReadData = None;
        NumPages = 267;
        BookTitle = "As I Lay Dying";
        AuthorName = "William Faulkner";
        ReviewId = 77013;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1451810782s/77013.jpg";
        BookId = 77013;}
        {ReadData = None;
        NumPages = 648;
        BookTitle = "A Court of Wings and Ruin (A Court of Thorns and Roses, #3)";
        AuthorName = "Sarah J. Maas";
        ReviewId = 23766634;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1485528243s/23766634.jpg";
        BookId = 23766634;}
        {ReadData = None;
        NumPages = 259;
        BookTitle = "Enclave (Razorland, #1)";
        AuthorName = "Ann Aguirre";
        ReviewId = 7137327;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327877657s/7137327.jpg";
        BookId = 7137327;}
        {ReadData = None;
        NumPages = 302;
        BookTitle = "Breakfast of Champions";
        AuthorName = "Kurt Vonnegut";
        ReviewId = 4980;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327934446s/4980.jpg";
        BookId = 4980;}
        {ReadData = None;
        NumPages = 298;
        BookTitle = "A Midsummer Night's Dream";
        AuthorName = "William Shakespeare";
        ReviewId = 1622;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327874534s/1622.jpg";
        BookId = 1622;}
        {ReadData = None;
        NumPages = 464;
        BookTitle = "Library of Souls (Miss Peregrine's Peculiar Children, #3)";
        AuthorName = "Ransom Riggs";
        ReviewId = 24120519;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1472783347s/24120519.jpg";
        BookId = 24120519;}
        {ReadData = None;
        NumPages = 367;
        BookTitle = "Crossed (Matched, #2)";
        AuthorName = "Ally Condie";
        ReviewId = 15812814;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1374335939s/15812814.jpg";
        BookId = 15812814;}
        {ReadData = None;
        NumPages = 426;
        BookTitle = "The Edge of Never (The Edge of Never, #1)";
        AuthorName = "J.A. Redmerski";
        ReviewId = 16081272;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1358810128s/16081272.jpg";
        BookId = 16081272;}
        {ReadData = None;
        NumPages = 448;
        BookTitle = "The Queen of the Tearling (The Queen of the Tearling, #1)";
        AuthorName = "Erika Johansen";
        ReviewId = 18712886;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1417685148s/18712886.jpg";
        BookId = 18712886;}
        {ReadData = None;
        NumPages = 412;
        BookTitle = "Falling Kingdoms (Falling Kingdoms, #1)";
        AuthorName = "Morgan Rhodes";
        ReviewId = 12954620;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1337026387s/12954620.jpg";
        BookId = 12954620;}
        {ReadData = None;
        NumPages = 484;
        BookTitle = "Salt: A World History";
        AuthorName = "Mark Kurlansky";
        ReviewId = 2715;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1414608893s/2715.jpg";
        BookId = 2715;}
        {ReadData = None;
        NumPages = 382;
        BookTitle = "Reconstructing Amelia";
        AuthorName = "Kimberly McCreight";
        ReviewId = 15776309;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1350193583s/15776309.jpg";
        BookId = 15776309;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "The Zombie Room";
        AuthorName = "R.D. Ronald";
        ReviewId = 29908754;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 29908754;}
        {ReadData = None;
        NumPages = 280;
        BookTitle = "The Thief (The Queen's Thief, #1)";
        AuthorName = "Megan Whalen Turner";
        ReviewId = 448873;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 448873;}
        {ReadData = None;
        NumPages = 490;
        BookTitle = "Inferno (The Divine Comedy #1)";
        AuthorName = "Dante Alighieri";
        ReviewId = 15645;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1333579470s/15645.jpg";
        BookId = 15645;}
        {ReadData = None;
        NumPages = 229;
        BookTitle = "A Long Way Gone: Memoirs of a Boy Soldier";
        AuthorName = "Ishmael Beah";
        ReviewId = 43015;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 43015;}
        {ReadData = None;
        NumPages = 821;
        BookTitle = "The Complete Stories and Poems";
        AuthorName = "Edgar Allan Poe";
        ReviewId = 23919;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327942676s/23919.jpg";
        BookId = 23919;}
        {ReadData = None;
        NumPages = 317;
        BookTitle = "Tender Is the Night";
        AuthorName = "F. Scott Fitzgerald";
        ReviewId = 46164;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1438797669s/46164.jpg";
        BookId = 46164;}
        {ReadData = None;
        NumPages = 361;
        BookTitle = "Birthmarked (Birthmarked, #1)";
        AuthorName = "Caragh M. O'Brien";
        ReviewId = 6909544;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 6909544;}
        {ReadData = None;
        NumPages = 159;
        BookTitle = "Maus I: A Survivor's Tale: My Father Bleeds History (Maus, #1)";
        AuthorName = "Art Spiegelman";
        ReviewId = 15196;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327884972s/15196.jpg";
        BookId = 15196;}
        {ReadData = None;
        NumPages = 452;
        BookTitle = "Nightshade (Nightshade #1; Nightshade World #4)";
        AuthorName = "Andrea Cremer";
        ReviewId = 7402393;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1333400218s/7402393.jpg";
        BookId = 7402393;}
        {ReadData = None;
        NumPages = 176;
        BookTitle = "A Light in the Attic";
        AuthorName = "Shel Silverstein";
        ReviewId = 30118;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1427169918s/30118.jpg";
        BookId = 30118;}
        {ReadData = None;
        NumPages = 301;
        BookTitle = "The Tipping Point: How Little Things Can Make a Big Difference";
        AuthorName = "Malcolm Gladwell";
        ReviewId = 2612;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1473396980s/2612.jpg";
        BookId = 2612;}
        {ReadData = None;
        NumPages = 279;
        BookTitle = "The Sea of Monsters (Percy Jackson and the Olympians, #2)";
        AuthorName = "Rick Riordan";
        ReviewId = 28186;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1400602661s/28186.jpg";
        BookId = 28186;}
        {ReadData = None;
        NumPages = 486;
        BookTitle = "Passenger (Passenger, #1)";
        AuthorName = "Alexandra Bracken";
        ReviewId = 20983362;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1446749751s/20983362.jpg";
        BookId = 20983362;}
        {ReadData = None;
        NumPages = 242;
        BookTitle = "A Little Princess";
        AuthorName = "Frances Hodgson Burnett";
        ReviewId = 3008;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327868556s/3008.jpg";
        BookId = 3008;}
        {ReadData = None;
        NumPages = 62;
        BookTitle = "Green Eggs and Ham";
        AuthorName = "Dr. Seuss";
        ReviewId = 23772;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1468680100s/23772.jpg";
        BookId = 23772;}
        {ReadData = None;
        NumPages = 195;
        BookTitle = "Rich Dad, Poor Dad";
        AuthorName = "Robert T. Kiyosaki";
        ReviewId = 69571;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 69571;}
        {ReadData = None;
        NumPages = 299;
        BookTitle =
        "The Lean Startup: How Today's Entrepreneurs Use Continuous Innovation to Create Radically Successful Businesses";
        AuthorName = "Eric Ries";
        ReviewId = 10127019;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1333576876s/10127019.jpg";
        BookId = 10127019;}
        {ReadData = None;
        NumPages = 626;
        BookTitle = "A Court of Mist and Fury (A Court of Thorns and Roses, #2)";
        AuthorName = "Sarah J. Maas";
        ReviewId = 17927395;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1485259138s/17927395.jpg";
        BookId = 17927395;}
        {ReadData = None;
        NumPages = 208;
        BookTitle = "The Opposite of Loneliness: Essays and Stories";
        AuthorName = "Marina Keegan";
        ReviewId = 18143905;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1401056149s/18143905.jpg";
        BookId = 18143905;}
        {ReadData = None;
        NumPages = 26;
        BookTitle = "The Very Hungry Caterpillar";
        AuthorName = "Eric Carle";
        ReviewId = 4948;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327878225s/4948.jpg";
        BookId = 4948;}
        {ReadData = None;
        NumPages = 599;
        BookTitle = "Feed (Newsflesh Trilogy, #1)";
        AuthorName = "Mira Grant";
        ReviewId = 7094569;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1408500437s/7094569.jpg";
        BookId = 7094569;}
        {ReadData = None;
        NumPages = 517;
        BookTitle = "The Blade Itself (The First Law #1)";
        AuthorName = "Joe Abercrombie";
        ReviewId = 944073;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1284167912s/944073.jpg";
        BookId = 944073;}
        {ReadData = None;
        NumPages = 337;
        BookTitle = "Beautiful Ruins";
        AuthorName = "Jess Walter";
        ReviewId = 11447921;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1338161553s/11447921.jpg";
        BookId = 11447921;}
        {ReadData = None;
        NumPages = 337;
        BookTitle = "Life As We Knew It (Last Survivors, #1)";
        AuthorName = "Susan Beth Pfeffer";
        ReviewId = 213753;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1328012816s/213753.jpg";
        BookId = 213753;}
        {ReadData = None;
        NumPages = 435;
        BookTitle = "Along Came a Spider (Alex Cross, #1)";
        AuthorName = "James Patterson";
        ReviewId = 13145;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 13145;}
        {ReadData = None;
        NumPages = 302;
        BookTitle = "My Heart and Other Black Holes";
        AuthorName = "Jasmine Warga";
        ReviewId = 18336965;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1415056175s/18336965.jpg";
        BookId = 18336965;}
        {ReadData = None;
        NumPages = 332;
        BookTitle = "Wait for You (Wait for You, #1)";
        AuthorName = "J. Lynn";
        ReviewId = 17314430;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1363819713s/17314430.jpg";
        BookId = 17314430;}
        {ReadData = None;
        NumPages = 408;
        BookTitle = "The White Queen (The Plantagenet and Tudor Novels, #2)";
        AuthorName = "Philippa Gregory";
        ReviewId = 5971165;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 5971165;}
        {ReadData = None;
        NumPages = 1796;
        BookTitle = "The Complete Sherlock Holmes";
        AuthorName = "Arthur Conan Doyle";
        ReviewId = 188572;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1465539139s/188572.jpg";
        BookId = 188572;}
        {ReadData = None;
        NumPages = 468;
        BookTitle = "Partials (Partials Sequence, #1)";
        AuthorName = "Dan Wells";
        ReviewId = 12476820;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1337468746s/12476820.jpg";
        BookId = 12476820;}
        {ReadData = None;
        NumPages = 462;
        BookTitle = "1st to Die (Women's Murder Club, #1)";
        AuthorName = "James Patterson";
        ReviewId = 13137;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 13137;}
        {ReadData = None;
        NumPages = 416;
        BookTitle =
        "The Boys in the Boat: Nine Americans and Their Epic Quest for Gold at the 1936 Berlin Olympics";
        AuthorName = "Daniel James Brown";
        ReviewId = 16158542;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1354683116s/16158542.jpg";
        BookId = 16158542;}
        {ReadData = None;
        NumPages = 259;
        BookTitle = "The Man in the High Castle";
        AuthorName = "Philip K. Dick";
        ReviewId = 216363;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1448756803s/216363.jpg";
        BookId = 216363;}
        {ReadData = None;
        NumPages = 422;
        BookTitle = "A Tale for the Time Being";
        AuthorName = "Ruth Ozeki";
        ReviewId = 15811545;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1463767452s/15811545.jpg";
        BookId = 15811545;}
        {ReadData = None;
        NumPages = 217;
        BookTitle = "This Is How You Lose Her";
        AuthorName = "Junot Díaz";
        ReviewId = 13503109;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1342596676s/13503109.jpg";
        BookId = 13503109;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "The Winds of Winter (A Song of Ice and Fire, #6)";
        AuthorName = "George R.R. Martin";
        ReviewId = 12111823;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1465341854s/12111823.jpg";
        BookId = 12111823;}
        {ReadData = None;
        NumPages = 693;
        BookTitle = "Empire of Storms (Throne of Glass, #5)";
        AuthorName = "Sarah J. Maas";
        ReviewId = 28260587;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1463107108s/28260587.jpg";
        BookId = 28260587;}
        {ReadData = None;
        NumPages = 306;
        BookTitle = "Gulliver's Travels";
        AuthorName = "Jonathan Swift";
        ReviewId = 7733;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1427829692s/7733.jpg";
        BookId = 7733;}
        {ReadData = None;
        NumPages = 341;
        BookTitle = "Die for Me (Revenants, #1)";
        AuthorName = "Amy Plum";
        ReviewId = 9462812;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1358427893s/9462812.jpg";
        BookId = 9462812;}
        {ReadData = None;
        NumPages = 304;
        BookTitle = "Naked";
        AuthorName = "David Sedaris";
        ReviewId = 4138;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1394178867s/4138.jpg";
        BookId = 4138;}
        {ReadData = None;
        NumPages = 525;
        BookTitle = "Killing Floor (Jack Reacher, #1)";
        AuthorName = "Lee Child";
        ReviewId = 78129;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1399313258s/78129.jpg";
        BookId = 78129;}
        {ReadData = None;
        NumPages = 288;
        BookTitle = "A Visit from the Goon Squad";
        AuthorName = "Jennifer Egan";
        ReviewId = 7331435;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1356844046s/7331435.jpg";
        BookId = 7331435;}
        {ReadData = None;
        NumPages = 396;
        BookTitle = "The Neverending Story";
        AuthorName = "Michael Ende";
        ReviewId = 27712;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327871159s/27712.jpg";
        BookId = 27712;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "Men Are from Mars, Women Are from Venus";
        AuthorName = "John Gray";
        ReviewId = 1274;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 1274;}
        {ReadData = None;
        NumPages = 186;
        BookTitle = "Stargirl (Stargirl, #1)";
        AuthorName = "Jerry Spinelli";
        ReviewId = 22232;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1335947642s/22232.jpg";
        BookId = 22232;}
        {ReadData = None;
        NumPages = 563;
        BookTitle = "New Moon (Twilight, #2)";
        AuthorName = "Stephenie Meyer";
        ReviewId = 49041;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1361039440s/49041.jpg";
        BookId = 49041;}
        {ReadData = None;
        NumPages = 357;
        BookTitle = "Soulless (Parasol Protectorate, #1)";
        AuthorName = "Gail Carriger";
        ReviewId = 6381205;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1314020848s/6381205.jpg";
        BookId = 6381205;}
        {ReadData = None;
        NumPages = 446;
        BookTitle = "White Oleander";
        AuthorName = "Janet Fitch";
        ReviewId = 32234;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 32234;}
        {ReadData = None;
        NumPages = 252;
        BookTitle = "The Elephant Tree";
        AuthorName = "R.D. Ronald";
        ReviewId = 9293020;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327248026s/9293020.jpg";
        BookId = 9293020;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "The Sandman, Vol. 1: Preludes and Nocturnes";
        AuthorName = "Neil Gaiman";
        ReviewId = 23754;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1411609637s/23754.jpg";
        BookId = 23754;}
        {ReadData = None;
        NumPages = 391;
        BookTitle =
        "Surely You're Joking, Mr. Feynman!: Adventures of a Curious Character";
        AuthorName = "Richard Feynman";
        ReviewId = 5544;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1348445281s/5544.jpg";
        BookId = 5544;}
        {ReadData = None;
        NumPages = 468;
        BookTitle = "Carve the Mark (Carve the Mark, #1)";
        AuthorName = "Veronica Roth";
        ReviewId = 30117284;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 30117284;}
        {ReadData = None;
        NumPages = 430;
        BookTitle = "Golden Son (Red Rising, #2)";
        AuthorName = "Pierce Brown";
        ReviewId = 18966819;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1394684475s/18966819.jpg";
        BookId = 18966819;}
        {ReadData = None;
        NumPages = 549;
        BookTitle = "James Potter and the Hall of Elders' Crossing (James Potter, #1)";
        AuthorName = "G. Norman Lippert";
        ReviewId = 2548866;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1369410178s/2548866.jpg";
        BookId = 2548866;}
        {ReadData = None;
        NumPages = 880;
        BookTitle = "The Complete Grimm's Fairy Tales";
        AuthorName = "Jacob Grimm";
        ReviewId = 22917;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1369540060s/22917.jpg";
        BookId = 22917;}
        {ReadData = None;
        NumPages = 181;
        BookTitle = "A Moveable Feast";
        AuthorName = "Ernest Hemingway";
        ReviewId = 4631;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1427463201s/4631.jpg";
        BookId = 4631;}
        {ReadData = None;
        NumPages = 565;
        BookTitle = "Heir of Fire (Throne of Glass, #3)";
        AuthorName = "Sarah J. Maas";
        ReviewId = 20613470;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1460846511s/20613470.jpg";
        BookId = 20613470;}
        {ReadData = None;
        NumPages = 452;
        BookTitle = "Dorothy Must Die (Dorothy Must Die, #1)";
        AuthorName = "Danielle  Paige";
        ReviewId = 18053060;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1381437107s/18053060.jpg";
        BookId = 18053060;}
        {ReadData = None;
        NumPages = 407;
        BookTitle = "Caraval (Caraval, #1)";
        AuthorName = "Stephanie Garber";
        ReviewId = 27883214;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1465563623s/27883214.jpg";
        BookId = 27883214;}
        {ReadData = None;
        NumPages = 327;
        BookTitle = "The Body Finder (The Body Finder, #1)";
        AuthorName = "Kimberly Derting";
        ReviewId = 6261522;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1358266631s/6261522.jpg";
        BookId = 6261522;}
        {ReadData = None;
        NumPages = 369;
        BookTitle = "Champion (Legend, #3)";
        AuthorName = "Marie Lu";
        ReviewId = 14290364;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1382652310s/14290364.jpg";
        BookId = 14290364;}
        {ReadData = None;
        NumPages = 489;
        BookTitle = "The Tenant of Wildfell Hall";
        AuthorName = "Anne Brontë";
        ReviewId = 337113;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1479652419s/337113.jpg";
        BookId = 337113;}
        {ReadData = None;
        NumPages = 459;
        BookTitle = "Blood Red Road (Dust Lands, #1)";
        AuthorName = "Moira Young";
        ReviewId = 9917938;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1293651959s/9917938.jpg";
        BookId = 9917938;}
        {ReadData = None;
        NumPages = 384;
        BookTitle = "All the Missing Girls";
        AuthorName = "Megan Miranda";
        ReviewId = 23212667;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1452098621s/23212667.jpg";
        BookId = 23212667;}
        {ReadData = None;
        NumPages = 994;
        BookTitle = "The Wise Man's Fear (The Kingkiller Chronicle, #2)";
        AuthorName = "Patrick Rothfuss";
        ReviewId = 1215032;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1452624392s/1215032.jpg";
        BookId = 1215032;}
        {ReadData = None;
        NumPages = 317;
        BookTitle = "I Am Legend and Other Stories";
        AuthorName = "Richard Matheson";
        ReviewId = 547094;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1317791583s/547094.jpg";
        BookId = 547094;}
        {ReadData = None;
        NumPages = 406;
        BookTitle = "The Marriage Plot";
        AuthorName = "Jeffrey Eugenides";
        ReviewId = 10964693;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1328736940s/10964693.jpg";
        BookId = 10964693;}
        {ReadData = None;
        NumPages = 224;
        BookTitle = "Smile";
        AuthorName = "Raina Telgemeier";
        ReviewId = 6393631;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1438206850s/6393631.jpg";
        BookId = 6393631;}
        {ReadData = None;
        NumPages = 467;
        BookTitle = "The History of the Hobbit, Part One: Mr. Baggins";
        AuthorName = "John D. Rateliff";
        ReviewId = 1081560;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 1081560;}
        {ReadData = None;
        NumPages = 815;
        BookTitle =
        "The Ultimate Hitchhiker's Guide to the Galaxy (Hitchhiker's Guide to the Galaxy #1-5)";
        AuthorName = "Douglas Adams";
        ReviewId = 13;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1404613595s/13.jpg";
        BookId = 13;}
        {ReadData = None;
        NumPages = 309;
        BookTitle = "Darkfever (Fever, #1)";
        AuthorName = "Karen Marie Moning";
        ReviewId = 112750;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1392579949s/112750.jpg";
        BookId = 112750;}
        {ReadData = None;
        NumPages = 466;
        BookTitle = "The Bone Season (The Bone Season, #1)";
        AuthorName = "Samantha Shannon";
        ReviewId = 17199504;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1421412990s/17199504.jpg";
        BookId = 17199504;}
        {ReadData = None;
        NumPages = 643;
        BookTitle = "The Six Wives of Henry VIII";
        AuthorName = "Alison Weir";
        ReviewId = 10104;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 10104;}
        {ReadData = None;
        NumPages = 322;
        BookTitle = "Something Borrowed (Darcy & Rachel, #1)";
        AuthorName = "Emily Giffin";
        ReviewId = 42156;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1305063535s/42156.jpg";
        BookId = 42156;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "A Heartbreaking Work of Staggering Genius";
        AuthorName = "Dave Eggers";
        ReviewId = 4953;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327714834s/4953.jpg";
        BookId = 4953;}
        {ReadData = None;
        NumPages = 391;
        BookTitle = "Requiem (Delirium, #3)";
        AuthorName = "Lauren Oliver";
        ReviewId = 9593913;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1340992438s/9593913.jpg";
        BookId = 9593913;}
        {ReadData = None;
        NumPages = 337;
        BookTitle = "P.S. I Still Love You (To All the Boys I've Loved Before, #2)";
        AuthorName = "Jenny Han";
        ReviewId = 20698530;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1422881430s/20698530.jpg";
        BookId = 20698530;}
        {ReadData = None;
        NumPages = 517;
        BookTitle = "Days of Blood & Starlight (Daughter of Smoke & Bone, #2)";
        AuthorName = "Laini Taylor";
        ReviewId = 12812550;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1461353798s/12812550.jpg";
        BookId = 12812550;}
        {ReadData = None;
        NumPages = 272;
        BookTitle = "Hillbilly Elegy: A Memoir of a Family and Culture in Crisis";
        AuthorName = "J.D. Vance";
        ReviewId = 27161156;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1463569814s/27161156.jpg";
        BookId = 27161156;}
        {ReadData = None;
        NumPages = 287;
        BookTitle =
        "Daring Greatly: How the Courage to Be Vulnerable Transforms the Way We Live, Love, Parent, and Lead";
        AuthorName = "Brené Brown";
        ReviewId = 13588356;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1337110319s/13588356.jpg";
        BookId = 13588356;}
        {ReadData = None;
        NumPages = 495;
        BookTitle = "The Lake House";
        AuthorName = "Kate Morton";
        ReviewId = 21104828;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1455089249s/21104828.jpg";
        BookId = 21104828;}
        {ReadData = None;
        NumPages = 208;
        BookTitle = "The Witches";
        AuthorName = "Roald Dahl";
        ReviewId = 6327;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1351707720s/6327.jpg";
        BookId = 6327;}
        {ReadData = None;
        NumPages = 146;
        BookTitle = "James and the Giant Peach";
        AuthorName = "Roald Dahl";
        ReviewId = 6689;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1320412586s/6689.jpg";
        BookId = 6689;}
        {ReadData = None;
        NumPages = 302;
        BookTitle = "Blue Bloods (Blue Bloods, #1)";
        AuthorName = "Melissa de la Cruz";
        ReviewId = 872333;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1322281515s/872333.jpg";
        BookId = 872333;}
        {ReadData = None;
        NumPages = 416;
        BookTitle = "Fried Green Tomatoes at the Whistle Stop Cafe";
        AuthorName = "Fannie Flagg";
        ReviewId = 9375;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 9375;}
        {ReadData = None;
        NumPages = 462;
        BookTitle = "A Gentleman in Moscow";
        AuthorName = "Amor Towles";
        ReviewId = 29430012;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1459524472s/29430012.jpg";
        BookId = 29430012;}
        {ReadData = None;
        NumPages = 825;
        BookTitle = "Written in My Own Heart's Blood (Outlander, #8)";
        AuthorName = "Diana Gabaldon";
        ReviewId = 11710373;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1365173799s/11710373.jpg";
        BookId = 11710373;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "The Guardian";
        AuthorName = "Nicholas Sparks";
        ReviewId = 15925;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1388195339s/15925.jpg";
        BookId = 15925;}
        {ReadData = None;
        NumPages = 430;
        BookTitle = "Trainspotting";
        AuthorName = "Irvine Welsh";
        ReviewId = 135836;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1353033083s/135836.jpg";
        BookId = 135836;}
        {ReadData = None;
        NumPages = 160;
        BookTitle = "We Have Always Lived in the Castle";
        AuthorName = "Shirley Jackson";
        ReviewId = 89724;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1415357189s/89724.jpg";
        BookId = 89724;}
        {ReadData = None;
        NumPages = 435;
        BookTitle = "Unearthly (Unearthly, #1)";
        AuthorName = "Cynthia Hand";
        ReviewId = 7488244;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1324782984s/7488244.jpg";
        BookId = 7488244;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "The Purpose Driven Life: What on Earth Am I Here for?";
        AuthorName = "Rick Warren";
        ReviewId = 56495;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 56495;}
        {ReadData = None;
        NumPages = 370;
        BookTitle = "Everneath (Everneath, #1)";
        AuthorName = "Brodi Ashton";
        ReviewId = 9413044;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1340210035s/9413044.jpg";
        BookId = 9413044;}
        {ReadData = None;
        NumPages = 287;
        BookTitle = "Heist Society (Heist Society, #1)";
        AuthorName = "Ally Carter";
        ReviewId = 6574102;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1359254479s/6574102.jpg";
        BookId = 6574102;}
        {ReadData = None;
        NumPages = 159;
        BookTitle = "Never Never (Never Never, #1)";
        AuthorName = "Colleen Hoover";
        ReviewId = 24378015;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 24378015;}
        {ReadData = None;
        NumPages = 182;
        BookTitle = "The Martian Chronicles";
        AuthorName = "Ray Bradbury";
        ReviewId = 76778;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1374049948s/76778.jpg";
        BookId = 76778;}
        {ReadData = None;
        NumPages = 421;
        BookTitle = "Bloodlines (Bloodlines, #1)";
        AuthorName = "Richelle Mead";
        ReviewId = 8709527;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1297199431s/8709527.jpg";
        BookId = 8709527;}
        {ReadData = None;
        NumPages = 405;
        BookTitle = "Moloka'i";
        AuthorName = "Alan Brennert";
        ReviewId = 3273;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 3273;}
        {ReadData = None;
        NumPages = 320;
        BookTitle = "Robinson Crusoe";
        AuthorName = "Daniel Defoe";
        ReviewId = 2932;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1403180114s/2932.jpg";
        BookId = 2932;}
        {ReadData = None;
        NumPages = 352;
        BookTitle = "The Song of Achilles";
        AuthorName = "Madeline Miller";
        ReviewId = 11250317;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1331154660s/11250317.jpg";
        BookId = 11250317;}
        {ReadData = None;
        NumPages = 384;
        BookTitle = "Anansi Boys (American Gods, #2)";
        AuthorName = "Neil Gaiman";
        ReviewId = 2744;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1479778049s/2744.jpg";
        BookId = 2744;}
        {ReadData = None;
        NumPages = 702;
        BookTitle = "Untitled (Throne of Glass, #7)";
        AuthorName = "Sarah J. Maas";
        ReviewId = 33590260;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1488914165s/33590260.jpg";
        BookId = 33590260;}
        {ReadData = None;
        NumPages = 432;
        BookTitle = "History of Beauty";
        AuthorName = "Umberto Eco";
        ReviewId = 10505;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 10505;}
        {ReadData = None;
        NumPages = 552;
        BookTitle = "The Book Thief";
        AuthorName = "Markus Zusak";
        ReviewId = 19063;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1390053681s/19063.jpg";
        BookId = 19063;}
        {ReadData = None;
        NumPages = 320;
        BookTitle = "The Boston Girl";
        AuthorName = "Anita Diamant";
        ReviewId = 22450859;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1418103945s/22450859.jpg";
        BookId = 22450859;}
        {ReadData = None;
        NumPages = 381;
        BookTitle =
        "The Romanov Sisters: The Lost Lives of the Daughters of Nicholas and Alexandra";
        AuthorName = "Helen Rappaport";
        ReviewId = 18404173;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1396818138s/18404173.jpg";
        BookId = 18404173;}
        {ReadData = None;
        NumPages = 384;
        BookTitle = "Prince of Thorns (The Broken Empire, #1)";
        AuthorName = "Mark  Lawrence";
        ReviewId = 9579634;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327917754s/9579634.jpg";
        BookId = 9579634;}
        {ReadData = None;
        NumPages = 215;
        BookTitle = "Understanding Comics: The Invisible Art";
        AuthorName = "Scott McCloud";
        ReviewId = 102920;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1328408101s/102920.jpg";
        BookId = 102920;}
        {ReadData = None;
        NumPages = 201;
        BookTitle = "Franny and Zooey";
        AuthorName = "J.D. Salinger";
        ReviewId = 5113;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1355037988s/5113.jpg";
        BookId = 5113;}
        {ReadData = None;
        NumPages = 314;
        BookTitle = "Othello";
        AuthorName = "William Shakespeare";
        ReviewId = 12996;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1459795105s/12996.jpg";
        BookId = 12996;}
        {ReadData = None;
        NumPages = 328;
        BookTitle = "Eleanor & Park";
        AuthorName = "Rainbow Rowell";
        ReviewId = 15745753;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1341952742s/15745753.jpg";
        BookId = 15745753;}
        {ReadData = None;
        NumPages = 368;
        BookTitle = "Every Last Word";
        AuthorName = "Tamara Ireland Stone";
        ReviewId = 23341894;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1431016937s/23341894.jpg";
        BookId = 23341894;}
        {ReadData = None;
        NumPages = 223;
        BookTitle = "Boy Meets Boy";
        AuthorName = "David Levithan";
        ReviewId = 23228;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1356335082s/23228.jpg";
        BookId = 23228;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "Shantaram";
        AuthorName = "Gregory David Roberts";
        ReviewId = 33600;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1333482282s/33600.jpg";
        BookId = 33600;}
        {ReadData = None;
        NumPages = 501;
        BookTitle = "The Signature of All Things";
        AuthorName = "Elizabeth Gilbert";
        ReviewId = 17465453;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1364277893s/17465453.jpg";
        BookId = 17465453;}
        {ReadData = None;
        NumPages = 107;
        BookTitle = "A Streetcar Named Desire";
        AuthorName = "Tennessee Williams";
        ReviewId = 12220;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 12220;}
        {ReadData = None;
        NumPages = 432;
        BookTitle = "End of Watch (Bill Hodges Trilogy, #3)";
        AuthorName = "Stephen King";
        ReviewId = 25526965;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1468705472s/25526965.jpg";
        BookId = 25526965;}
        {ReadData = None;
        NumPages = 391;
        BookTitle = "Before the Fall";
        AuthorName = "Noah Hawley";
        ReviewId = 26245850;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1462515889s/26245850.jpg";
        BookId = 26245850;}
        {ReadData = None;
        NumPages = 401;
        BookTitle = "The Black Swan: The Impact of the Highly Improbable";
        AuthorName = "Nassim Nicholas Taleb";
        ReviewId = 242472;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 242472;}
        {ReadData = None;
        NumPages = 427;
        BookTitle = "Crescendo (Hush, Hush, #2)";
        AuthorName = "Becca Fitzpatrick";
        ReviewId = 7791997;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1362408146s/7791997.jpg";
        BookId = 7791997;}
        {ReadData = None;
        NumPages = 452;
        BookTitle = "Torment (Fallen, #2)";
        AuthorName = "Lauren Kate";
        ReviewId = 7740152;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1362339749s/7740152.jpg";
        BookId = 7740152;}
        {ReadData = None;
        NumPages = 406;
        BookTitle = "The Thirteenth Tale";
        AuthorName = "Diane Setterfield";
        ReviewId = 40440;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1346267826s/40440.jpg";
        BookId = 40440;}
        {ReadData = None;
        NumPages = 960;
        BookTitle = "How to Cook Everything: Simple Recipes for Great Food";
        AuthorName = "Mark Bittman";
        ReviewId = 603204;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 603204;}
        {ReadData = None;
        NumPages = 374;
        BookTitle = "Incarnate (Newsoul, #1)";
        AuthorName = "Jodi Meadows";
        ReviewId = 8573642;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1358271343s/8573642.jpg";
        BookId = 8573642;}
        {ReadData = None;
        NumPages = 264;
        BookTitle = "Midnight Sun (Twilight, #1.5)";
        AuthorName = "Stephenie Meyer";
        ReviewId = 4502877;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 4502877;}
        {ReadData = None;
        NumPages = 224;
        BookTitle = "The Time Keeper";
        AuthorName = "Mitch Albom";
        ReviewId = 13624688;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1340478576s/13624688.jpg";
        BookId = 13624688;}
        {ReadData = None;
        NumPages = 295;
        BookTitle = "The Iron Trial (Magisterium, #1)";
        AuthorName = "Cassandra Clare";
        ReviewId = 20578940;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1396560808s/20578940.jpg";
        BookId = 20578940;}
        {ReadData = None;
        NumPages = 483;
        BookTitle = "'Salem's Lot";
        AuthorName = "Stephen King";
        ReviewId = 11590;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1327891565s/11590.jpg";
        BookId = 11590;}
        {ReadData = None;
        NumPages = 0;
        BookTitle = "Scott Pilgrim, Volume 1: Scott Pilgrim's Precious Little Life";
        AuthorName = "Bryan Lee O'Malley";
        ReviewId = 29800;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 29800;}
        {ReadData = None;
        NumPages = 364;
        BookTitle = "Vicious (Vicious, #1)";
        AuthorName = "V.E. Schwab";
        ReviewId = 13638125;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1362495700s/13638125.jpg";
        BookId = 13638125;}
        {ReadData = None;
        NumPages = 292;
        BookTitle = "The Best of Me";
        AuthorName = "Nicholas Sparks";
        ReviewId = 10766509;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1301685366s/10766509.jpg";
        BookId = 10766509;}
        {ReadData = None;
        NumPages = 352;
        BookTitle = "Bel Canto";
        AuthorName = "Ann Patchett";
        ReviewId = 5826;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1352997328s/5826.jpg";
        BookId = 5826;}
        {ReadData = None;
        NumPages = 160;
        BookTitle = "The Marriage Bargain (Marriage to a Billionaire, #1)";
        AuthorName = "Jennifer Probst";
        ReviewId = 13486122;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1329319988s/13486122.jpg";
        BookId = 13486122;}
        {ReadData = None;
        NumPages = 272;
        BookTitle = "Dress Your Family in Corduroy and Denim";
        AuthorName = "David Sedaris";
        ReviewId = 10176;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1352983006s/10176.jpg";
        BookId = 10176;}
        {ReadData = None;
        NumPages = 256;
        BookTitle = "The Wind in the Willows";
        AuthorName = "Kenneth Grahame";
        ReviewId = 5659;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1423183570s/5659.jpg";
        BookId = 5659;}
        {ReadData = None;
        NumPages = 372;
        BookTitle = "Under the Banner of Heaven: A Story of Violent Faith";
        AuthorName = "Jon Krakauer";
        ReviewId = 10847;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1356441391s/10847.jpg";
        BookId = 10847;}
        {ReadData = None;
        NumPages = 534;
        BookTitle = "The Invention of Hugo Cabret";
        AuthorName = "Brian Selznick";
        ReviewId = 9673436;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1422312376s/9673436.jpg";
        BookId = 9673436;}
        {ReadData = None;
        NumPages = 160;
        BookTitle = "Saga, Vol. 1";
        AuthorName = "Brian K. Vaughan";
        ReviewId = 15704307;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1486028947s/15704307.jpg";
        BookId = 15704307;}
        {ReadData = None;
        NumPages = 420;
        BookTitle = "The Madman’s Daughter (The Madman’s Daughter, #1)";
        AuthorName = "Megan Shepherd";
        ReviewId = 12291438;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1354155885s/12291438.jpg";
        BookId = 12291438;}
        {ReadData = None;
        NumPages = 296;
        BookTitle = "The Diary of Frida Kahlo: An Intimate Self-Portrait";
        AuthorName = "Frida Kahlo";
        ReviewId = 91760;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1407009131s/91760.jpg";
        BookId = 91760;}
        {ReadData = None;
        NumPages = 345;
        BookTitle = "Rebel Belle (Rebel Belle, #1)";
        AuthorName = "Rachel Hawkins";
        ReviewId = 8475505;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1371650817s/8475505.jpg";
        BookId = 8475505;}
        {ReadData = None;
        NumPages = 460;
        BookTitle =
        "A History of God: The 4,000-Year Quest of Judaism, Christianity, and Islam";
        AuthorName = "Karen Armstrong";
        ReviewId = 3873;
        Shelves = [||];
        SmallImageUrl =
        "https://s.gr-assets.com/assets/nophoto/book/50x75-a91bf249278a81aabab721ef782c4a74.png";
        BookId = 3873;}
        {ReadData = None;
        NumPages = 260;
        BookTitle = "Magic Bites (Kate Daniels, #1)";
        AuthorName = "Ilona Andrews";
        ReviewId = 38619;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1331612872s/38619.jpg";
        BookId = 38619;}
        {ReadData = None;
        NumPages = 468;
        BookTitle = "Swann's Way (In Search of Lost Time, #1)";
        AuthorName = "Marcel Proust";
        ReviewId = 12749;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1452956236s/12749.jpg";
        BookId = 12749;}
        {ReadData = None;
        NumPages = 369;
        BookTitle = "Matched (Matched, #1)";
        AuthorName = "Ally Condie";
        ReviewId = 7735333;
        Shelves = [||];
        SmallImageUrl = "https://images.gr-assets.com/books/1367706191s/7735333.jpg";
        BookId = 7735333;}

    |] |> Array.map (fun b -> { b with ReadData = Some (randomReadData()); Shelves = randomShelves()})

let bookDetails()=
    [|
        {Id = 2767052;
        Genres =
        [|"action"; "adventure"; "coming-of-age"; "contemporary"; "drama"; "dystopia";
            "fantasy"; "fiction"; "futuristic"; "love"; "novels"; "post-apocalyptic";
            "romance"; "science-fiction"; "speculative-fiction"; "survival"; "suspense";
            "teen"; "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2008;
        Language = None;}
        {Id = 865;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "africa"; "brazil";
            "classics"; "contemporary"; "drama"; "fantasy"; "fiction";
            "historical-fiction"; "inspirational"; "latin-american"; "literary-fiction";
            "literature"; "magical-realism"; "modern-classics"; "non-fiction"; "novels";
            "personal-development"; "philosophy"; "read-for-school"; "religion";
            "romance"; "school"; "self-help"; "spain"; "spirituality"; "travel";
            "young-adult"|];
        OriginalPublicationYear = Some 1988;
        Language = None;}
        {Id = 22557272;
        Genres =
        [|"adult"; "adult-fiction"; "contemporary"; "crime"; "dark"; "drama";
            "fiction"; "murder-mystery"; "mystery"; "mystery-thriller"; "novels";
            "psychological-thriller"; "realistic-fiction"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 24280;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "classic-literature"; "classics";
            "drama"; "epic"; "fiction"; "france"; "french-literature";
            "french-revolution"; "high-school"; "historical"; "historical-fiction";
            "history"; "literary-fiction"; "literature"; "movies"; "novels"; "plays";
            "read-for-school"; "romance"; "school"; "war"|];
        OriginalPublicationYear = Some 1862;
        Language = None;}
        {Id = 18143977;
        Genres =
        [|"adult"; "adult-fiction"; "coming-of-age"; "contemporary"; "drama"; "family";
            "fiction"; "france"; "germany"; "historical"; "historical-fiction";
            "history"; "holocaust"; "literary-fiction"; "literature"; "novels"; "war";
            "world-war-ii"; "young-adult"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 11235712;
        Genres =
        [|"adventure"; "aliens"; "cinderella"; "dystopia"; "fairy-tale-retellings";
            "fairy-tales"; "fantasy"; "fiction"; "futuristic"; "magic"; "paranormal";
            "retellings"; "romance"; "science-fiction"; "steampunk"; "teen";
            "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 21787;
        Genres =
        [|"20th-century"; "action"; "adult"; "adult-fiction"; "adventure";
            "children-s"; "childrens"; "classics"; "comedy"; "fairy-tales"; "fantasy";
            "fiction"; "funny"; "high-fantasy"; "historical"; "historical-fiction";
            "historical-romance"; "humor"; "literature"; "love"; "magic"; "movies";
            "novels"; "pirates"; "romance"; "science-fiction-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 1973;
        Language = Some "English (United States)";}
        {Id = 17470674;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "banned-books";
            "books-about-books"; "classic-literature"; "classics"; "dystopia"; "fantasy";
            "fiction"; "futuristic"; "high-school"; "literary-fiction"; "literature";
            "modern-classics"; "novels"; "philosophy"; "politics"; "read-for-school";
            "school"; "science"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "young-adult"|];
        OriginalPublicationYear = Some 1953;
        Language = None;}
        {Id = 15823480;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "classic-literature"; "classics";
            "drama"; "fiction"; "historical"; "historical-fiction"; "history";
            "literary-fiction"; "literature"; "love"; "novels"; "romance"; "russia";
            "russian-literature"; "school"|];
        OriginalPublicationYear = Some 1877;
        Language = None;}
        {Id = 320;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "classic-literature"; "classics";
            "contemporary"; "drama"; "family"; "fantasy"; "fiction"; "historical";
            "historical-fiction"; "latin-american"; "latin-american-literature";
            "literary-fiction"; "literature"; "magical-realism"; "modern-classics";
            "novels"; "romance"; "school"; "spanish-literature"|];
        OriginalPublicationYear = Some 1967;
        Language = None;}
        {Id = 7624;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "banned-books";
            "british-literature"; "childrens"; "classic-literature"; "classics";
            "coming-of-age"; "contemporary"; "dark"; "drama"; "dystopia";
            "english-literature"; "fantasy"; "fiction"; "high-school";
            "historical-fiction"; "horror"; "literary-fiction"; "literature";
            "modern-classics"; "novels"; "philosophy"; "psychology"; "read-for-school";
            "realistic-fiction"; "school"; "science-fiction"; "survival"; "teen";
            "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 1954;
        Language = None;}
        {Id = 1953;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "drama"; "english-literature"; "fiction";
            "france"; "french-revolution"; "high-school"; "historical";
            "historical-fiction"; "history"; "literary-fiction"; "literature"; "novels";
            "read-for-school"; "romance"; "school"; "victorian"; "war"; "young-adult"|];
        OriginalPublicationYear = Some 1859;
        Language = None;}
        {Id = 6186357;
        Genres =
        [|"action"; "adventure"; "apocalyptic"; "dystopia"; "fantasy"; "fiction";
            "futuristic"; "mystery"; "novels"; "post-apocalyptic"; "romance";
            "science-fiction"; "survival"; "suspense"; "teen"; "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2009;
        Language = None;}
        {Id = 4374400;
        Genres =
        [|"chick-lit"; "coming-of-age"; "contemporary"; "contemporary-romance";
            "death"; "drama"; "family"; "fantasy"; "fiction"; "high-school"; "love";
            "music"; "new-adult"; "novels"; "paranormal"; "realistic-fiction"; "romance";
            "teen"; "tragedy"; "young-adult"|];
        OriginalPublicationYear = Some 2009;
        Language = Some "English (United States)";}
        {Id = 7171637;
        Genres =
        [|"action"; "adventure"; "angels"; "demons"; "fantasy"; "fiction";
            "historical"; "historical-fiction"; "love"; "magic"; "mystery"; "paranormal";
            "paranormal-romance"; "romance"; "science-fiction"; "steampunk";
            "supernatural"; "teen"; "urban-fantasy"; "vampires"; "victorian";
            "werewolves"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 7126;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "adventure"; "classic-literature";
            "classics"; "crime"; "drama"; "epic"; "fantasy"; "fiction"; "france";
            "french-literature"; "high-school"; "historical"; "historical-fiction";
            "history"; "literary-fiction"; "literature"; "mystery"; "novels";
            "read-for-school"; "romance"; "school"; "thriller"|];
        OriginalPublicationYear = Some 1844;
        Language = None;}
        {Id = 1934;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "american"; "chick-lit";
            "children-s"; "childrens"; "civil-war"; "classic-literature"; "classics";
            "coming-of-age"; "drama"; "family"; "fiction"; "historical";
            "historical-fiction"; "history"; "juvenile"; "literary-fiction";
            "literature"; "middle-grade"; "novels"; "realistic-fiction"; "romance";
            "school"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 1868;
        Language = Some "English (United States)";}
        {Id = 14935;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature"; "chick-lit";
            "classic-literature"; "classics"; "drama"; "english-literature"; "family";
            "fiction"; "historical"; "historical-fiction"; "historical-romance";
            "history"; "literary-fiction"; "literature"; "love"; "novels"; "regency";
            "romance"; "romantic"; "school"; "victorian"|];
        OriginalPublicationYear = Some 1811;
        Language = None;}
        {Id = 9418327;
        Genres =
        [|"adult"; "american"; "autobiography"; "biography"; "biography-memoir";
            "chick-lit"; "comedy"; "contemporary"; "essays"; "feminism"; "fiction";
            "funny"; "humor"; "memoir"; "non-fiction"; "pop-culture"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 332613;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "banned-books";
            "classic-literature"; "classics"; "contemporary"; "drama"; "fiction";
            "high-school"; "historical-fiction"; "humor"; "literary-fiction";
            "literature"; "medical"; "mental-health"; "mental-illness"; "modern";
            "modern-classics"; "movies"; "novels"; "psychology"; "read-for-school";
            "realistic-fiction"; "school"|];
        OriginalPublicationYear = Some 1962;
        Language = None;}
        {Id = 2187;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "classics";
            "coming-of-age"; "contemporary"; "drama"; "family"; "fiction"; "gender";
            "glbt"; "greece"; "historical"; "historical-fiction"; "history";
            "literary-fiction"; "literature"; "novels"; "queer"; "realistic-fiction";
            "sexuality"|];
        OriginalPublicationYear = Some 2002;
        Language = Some "English (United States)";}
        {Id = 20910157;
        Genres =
        [|"adult"; "american"; "autobiography"; "biography"; "biography-memoir";
            "chick-lit"; "comedy"; "contemporary"; "essays"; "feminism"; "funny";
            "humor"; "memoir"; "non-fiction"; "pop-culture"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 8664353;
        Genres =
        [|"adult"; "adventure"; "american"; "american-history"; "asia";
            "autobiography"; "biography"; "biography-memoir"; "christian"; "fiction";
            "historical"; "historical-fiction"; "history"; "inspirational"; "japan";
            "memoir"; "military"; "military-history"; "non-fiction"; "sports";
            "survival"; "true-story"; "war"; "world-war-ii"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 37435;
        Genres =
        [|"adult"; "adult-fiction"; "african-american"; "american"; "chick-lit";
            "classics"; "coming-of-age"; "contemporary"; "drama"; "family"; "feminism";
            "fiction"; "high-school"; "historical"; "historical-fiction";
            "literary-fiction"; "literature"; "movies"; "novels"; "race";
            "read-for-school"; "realistic-fiction"; "romance"; "school"; "southern";
            "young-adult"|];
        OriginalPublicationYear = Some 2001;
        Language = Some "English (United States)";}
        {Id = 17245;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "classic-literature"; "classics"; "dark"; "english-literature"; "fantasy";
            "fiction"; "gothic"; "gothic-horror"; "historical"; "historical-fiction";
            "horror"; "literature"; "mystery"; "novels"; "paranormal"; "read-for-school";
            "romance"; "school"; "science-fiction"; "supernatural"; "suspense";
            "thriller"; "vampires"; "victorian"|];
        OriginalPublicationYear = Some 1897;
        Language = None;}
        {Id = 7144;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "classic-literature"; "classics";
            "crime"; "drama"; "fiction"; "high-school"; "historical";
            "historical-fiction"; "history"; "literary-fiction"; "literature"; "mystery";
            "novels"; "philosophy"; "psychology"; "read-for-school"; "russia";
            "russian-literature"; "school"|];
        OriginalPublicationYear = Some 1866;
        Language = None;}
        {Id = 7896527;
        Genres =
        [|"action"; "adventure"; "demons"; "dystopia"; "epic-fantasy"; "fae";
            "fantasy"; "fiction"; "high-fantasy"; "love"; "magic"; "mystery";
            "paranormal"; "romance"; "supernatural"; "teen"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 18135;
        Genres =
        [|"16th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "death"; "drama"; "english-literature";
            "fiction"; "high-school"; "historical"; "historical-fiction";
            "historical-romance"; "history"; "italy"; "literary-fiction"; "literature";
            "love"; "movies"; "novels"; "plays"; "poetry"; "read-for-school"; "romance";
            "romantic"; "school"; "theatre"; "tragedy"; "young-adult"|];
        OriginalPublicationYear = Some 1595;
        Language = None;}
        {Id = 119322;
        Genres =
        [|"20th-century"; "adventure"; "animals"; "banned-books"; "children-s";
            "childrens"; "classics"; "coming-of-age"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "juvenile"; "literature"; "magic"; "middle-grade";
            "mystery"; "novels"; "paranormal"; "religion"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "steampunk";
            "supernatural"; "teen"; "urban-fantasy"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 1995;
        Language = Some "English (United States)";}
        {Id = 16101128;
        Genres =
        [|"action"; "adventure"; "aliens"; "apocalyptic"; "dystopia"; "fantasy";
            "fiction"; "horror"; "mystery"; "paranormal"; "post-apocalyptic"; "romance";
            "science-fiction"; "survival"; "suspense"; "teen"; "thriller"; "war";
            "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 186074;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "coming-of-age"; "dragons"; "epic";
            "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy"; "magic"; "novels";
            "romance"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 345627;
        Genres =
        [|"action"; "adventure"; "boarding-school"; "contemporary"; "fantasy";
            "fiction"; "high-school"; "horror"; "love"; "magic"; "mystery"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "teen"; "urban-fantasy";
            "vampires"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = Some "English (United States)";}
        {Id = 8490112;
        Genres =
        [|"action"; "adventure"; "angels"; "contemporary"; "demons"; "dystopia";
            "fantasy"; "fiction"; "love"; "magic"; "mystery"; "mythology"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "teen"; "urban-fantasy";
            "war"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 12262741;
        Genres =
        [|"adult"; "adventure"; "american"; "autobiography"; "biography";
            "biography-memoir"; "chick-lit"; "contemporary"; "family"; "feminism";
            "fiction"; "inspirational"; "memoir"; "nature"; "non-fiction"; "outdoors";
            "survival"; "travel"; "wilderness"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 100915;
        Genres =
        [|"20th-century"; "adventure"; "animals"; "children-s"; "childrens";
            "christian"; "christian-fiction"; "christianity"; "classic-literature";
            "classics"; "epic-fantasy"; "family"; "fantasy"; "fiction"; "high-fantasy";
            "juvenile"; "literature"; "magic"; "middle-grade"; "novels";
            "read-for-school"; "religion"; "school"; "science-fiction";
            "science-fiction-fantasy"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 1950;
        Language = Some "English (United States)";}
        {Id = 4137;
        Genres =
        [|"adult"; "adult-fiction"; "american"; "autobiography"; "biography";
            "biography-memoir"; "comedy"; "contemporary"; "essays"; "family"; "fiction";
            "france"; "funny"; "gay"; "glbt"; "humor"; "literature"; "memoir";
            "non-fiction"; "novels"; "queer"; "short-stories"|];
        OriginalPublicationYear = Some 2000;
        Language = None;}
        {Id = 237209;
        Genres =
        [|"adult"; "adult-fiction"; "contemporary"; "crime"; "dark"; "detective";
            "fiction"; "horror"; "ireland"; "murder-mystery"; "mystery";
            "mystery-thriller"; "novels"; "psychological-thriller"; "suspense";
            "thriller"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 18007564;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "american"; "contemporary";
            "drama"; "fantasy"; "fiction"; "funny"; "humor"; "movies"; "novels";
            "science"; "science-fiction"; "science-fiction-fantasy"; "space";
            "speculative-fiction"; "survival"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 49750;
        Genres =
        [|"adventure"; "comedy"; "coming-of-age"; "contemporary"; "fiction"; "funny";
            "high-school"; "humor"; "love"; "novels"; "realistic-fiction";
            "relationships"; "road-trip"; "romance"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = Some "English (United States)";}
        {Id = 10335308;
        Genres =
        [|"adult"; "american"; "autobiography"; "biography"; "biography-memoir";
            "chick-lit"; "comedy"; "contemporary"; "essays"; "feminism"; "funny";
            "humor"; "memoir"; "non-fiction"; "pop-culture"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 16160797;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "contemporary"; "crime";
            "detective"; "fiction"; "murder-mystery"; "mystery"; "mystery-thriller";
            "novels"; "realistic-fiction"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 2013;
        Language = Some "English (United States)";}
        {Id = 6969;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature"; "chick-lit";
            "classic-literature"; "classics"; "drama"; "english-literature"; "fiction";
            "historical"; "historical-fiction"; "historical-romance"; "history"; "humor";
            "literary-fiction"; "literature"; "love"; "novels"; "regency"; "romance";
            "romantic"; "school"; "victorian"|];
        OriginalPublicationYear = Some 1815;
        Language = None;}
        {Id = 1381;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "ancient"; "ancient-history";
            "classic-literature"; "classics"; "college"; "drama"; "epic"; "epic-poetry";
            "fantasy"; "fiction"; "greece"; "greek-mythology"; "high-school";
            "historical"; "historical-fiction"; "history"; "literary-fiction";
            "literature"; "mythology"; "non-fiction"; "novels"; "philosophy"; "plays";
            "poetry"; "read-for-school"; "school"; "travel"; "war"|];
        OriginalPublicationYear = Some -800;
        Language = None;}
        {Id = 234225;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "american";
            "classics"; "dystopia"; "epic"; "fantasy"; "fiction"; "literature"; "novels";
            "philosophy"; "politics"; "religion"; "science"; "science-fiction";
            "science-fiction-fantasy"; "space"; "space-opera"; "speculative-fiction";
            "war"|];
        OriginalPublicationYear = Some 1965;
        Language = None;}
        {Id = 9969571;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "coming-of-age";
            "contemporary"; "cyberpunk"; "dystopia"; "fantasy"; "fiction"; "futuristic";
            "games"; "gaming"; "humor"; "mystery"; "novels"; "pop-culture";
            "post-apocalyptic"; "romance"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "technology"; "teen"; "thriller"; "video-games";
            "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 2623;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "coming-of-age"; "drama";
            "english-literature"; "fiction"; "high-school"; "historical";
            "historical-fiction"; "literary-fiction"; "literature"; "novels";
            "read-for-school"; "romance"; "school"; "victorian"; "young-adult"|];
        OriginalPublicationYear = Some 1860;
        Language = None;}
        {Id = 2213661;
        Genres =
        [|"adventure"; "children-s"; "childrens"; "coming-of-age"; "contemporary";
            "dark"; "dark-fantasy"; "death"; "family"; "fantasy"; "fiction";
            "ghost-stories"; "ghosts"; "gothic"; "horror"; "juvenile"; "magic";
            "magical-realism"; "middle-grade"; "mystery"; "novels"; "paranormal";
            "science-fiction"; "science-fiction-fantasy"; "supernatural"; "teen";
            "urban-fantasy"; "vampires"; "young-adult"|];
        OriginalPublicationYear = Some 2008;
        Language = Some "English (United States)";}
        {Id = 14891;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "childrens";
            "classic-literature"; "classics"; "coming-of-age"; "contemporary"; "drama";
            "family"; "fiction"; "high-school"; "historical"; "historical-fiction";
            "history"; "literary-fiction"; "literature"; "memoir"; "modern-classics";
            "new-york"; "novels"; "poverty"; "read-for-school"; "realistic-fiction";
            "school"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 1943;
        Language = None;}
        {Id = 2156;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature"; "chick-lit";
            "classic-literature"; "classics"; "drama"; "english-literature"; "fiction";
            "historical"; "historical-fiction"; "historical-romance"; "history";
            "literary-fiction"; "literature"; "love"; "novels"; "regency"; "romance";
            "romantic"; "school"; "victorian"|];
        OriginalPublicationYear = Some 1817;
        Language = None;}
        {Id = 2998;
        Genres =
        [|"20th-century"; "adventure"; "british-literature"; "children-s"; "childrens";
            "childrens-classics"; "classic-literature"; "classics"; "coming-of-age";
            "family"; "fantasy"; "fiction"; "historical"; "historical-fiction";
            "juvenile"; "literature"; "middle-grade"; "mystery"; "novels";
            "realistic-fiction"; "school"; "young-adult"|];
        OriginalPublicationYear = Some 1911;
        Language = None;}
        {Id = 8235178;
        Genres =
        [|"adventure"; "dystopia"; "fantasy"; "fiction"; "futuristic"; "love";
            "mystery"; "paranormal"; "post-apocalyptic"; "romance"; "science-fiction";
            "space"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 2165;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "american";
            "american-classics"; "classic-literature"; "classics"; "drama"; "fiction";
            "high-school"; "historical-fiction"; "literary-fiction"; "literature";
            "modern-classics"; "novella"; "novels"; "read-for-school";
            "realistic-fiction"; "school"; "short-stories"; "young-adult"|];
        OriginalPublicationYear = Some 1952;
        Language = None;}
        {Id = 5043;
        Genres =
        [|"12th-century"; "20th-century"; "adult"; "adult-fiction"; "adventure";
            "architecture"; "british-literature"; "classics"; "contemporary"; "drama";
            "epic"; "fantasy"; "fiction"; "historical"; "historical-fiction"; "history";
            "literary-fiction"; "literature"; "medieval"; "middle-ages"; "mystery";
            "novels"; "religion"; "romance"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1989;
        Language = None;}
        {Id = 4268157;
        Genres =
        [|"chick-lit"; "coming-of-age"; "contemporary"; "contemporary-romance";
            "crime"; "drama"; "family"; "fiction"; "high-school"; "love"; "new-adult";
            "realistic-fiction"; "romance"; "romantic"; "school"; "teen"; "young-adult";
            "young-adult-romance"|];
        OriginalPublicationYear = Some 2008;
        Language = None;}
        {Id = 49552;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "africa"; "classic-literature";
            "classics"; "college"; "contemporary"; "crime"; "drama"; "fiction"; "france";
            "french-literature"; "high-school"; "literary-fiction"; "literature";
            "modern"; "modern-classics"; "novella"; "novels"; "philosophy"; "psychology";
            "read-for-school"; "roman"; "school"|];
        OriginalPublicationYear = Some 1942;
        Language = None;}
        {Id = 6567017;
        Genres =
        [|"coming-of-age"; "contemporary"; "fiction"; "funny"; "gay"; "glbt";
            "high-school"; "humor"; "love"; "novels"; "queer"; "realistic-fiction";
            "relationships"; "romance"; "school"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 248704;
        Genres =
        [|"21st-century"; "american"; "coming-of-age"; "contemporary"; "drama";
            "fiction"; "funny"; "high-school"; "humor"; "love"; "mental-health";
            "mental-illness"; "movies"; "new-york"; "novels"; "psychology";
            "realistic-fiction"; "romance"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = Some "English (United States)";}
        {Id = 17675462;
        Genres =
        [|"adventure"; "contemporary"; "fantasy"; "fiction"; "ghosts"; "high-school";
            "magic"; "magical-realism"; "mystery"; "mythology"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "teen"; "urban-fantasy";
            "witches"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 4934;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "christianity";
            "classic-literature"; "classics"; "crime"; "drama"; "family"; "fiction";
            "historical"; "historical-fiction"; "literary-fiction"; "literature";
            "mystery"; "novels"; "philosophy"; "psychology"; "religion"; "romance";
            "russia"; "russian-literature"; "school"|];
        OriginalPublicationYear = Some 1880;
        Language = None;}
        {Id = 830502;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "classics";
            "coming-of-age"; "contemporary"; "dark"; "fantasy"; "fiction"; "horror";
            "movies"; "mystery"; "mystery-thriller"; "novels"; "paranormal";
            "science-fiction"; "supernatural"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1986;
        Language = Some "English (United Kingdom)";}
        {Id = 10917;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "coming-of-age"; "contemporary";
            "death"; "drama"; "family"; "fiction"; "high-school"; "illness";
            "literary-fiction"; "literature"; "medical"; "movies"; "novels";
            "realistic-fiction"; "relationships"; "romance"; "womens-fiction";
            "young-adult"|];
        OriginalPublicationYear = Some 2004;
        Language = None;}
        {Id = 8667848;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "alchemy"; "books-about-books";
            "chick-lit"; "contemporary"; "demons"; "fantasy"; "fiction"; "ghosts";
            "historical"; "historical-fiction"; "history"; "horror"; "magic";
            "magical-realism"; "mystery"; "novels"; "paranormal"; "paranormal-romance";
            "romance"; "science-fiction"; "supernatural"; "time-travel"; "urban-fantasy";
            "vampires"; "witchcraft"; "witches"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 15839976;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "dystopia"; "fantasy";
            "fiction"; "futuristic"; "mythology"; "novels"; "romance"; "science-fiction";
            "science-fiction-fantasy"; "space"; "space-opera"; "speculative-fiction";
            "teen"; "thriller"; "war"; "young-adult"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 764347;
        Genres =
        [|"action"; "adventure"; "coming-of-age"; "dark"; "death"; "dystopia";
            "fantasy"; "fiction"; "futuristic"; "horror"; "mystery"; "post-apocalyptic";
            "romance"; "school"; "science-fiction"; "speculative-fiction"; "survival";
            "suspense"; "teen"; "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 4069;
        Genres =
        [|"20th-century"; "adult"; "autobiography"; "biography"; "biography-memoir";
            "business"; "classics"; "faith"; "fiction"; "germany"; "historical";
            "history"; "holocaust"; "inspirational"; "jewish"; "leadership";
            "literature"; "memoir"; "mental-health"; "non-fiction";
            "personal-development"; "philosophy"; "psychology"; "religion"; "school";
            "science"; "self-help"; "sociology"; "spirituality"; "theology"; "war";
            "world-war-ii"|];
        OriginalPublicationYear = Some 1946;
        Language = None;}
        {Id = 10534;
        Genres =
        [|"adult"; "ancient"; "asia"; "business"; "china"; "chinese-literature";
            "classic-literature"; "classics"; "eastern-philosophy"; "fiction";
            "historical"; "history"; "leadership"; "literature"; "management";
            "military"; "military-history"; "non-fiction"; "novels";
            "personal-development"; "philosophy"; "political-science"; "politics";
            "psychology"; "reference"; "research"; "science"; "self-help"; "war"|];
        OriginalPublicationYear = Some -450;
        Language = None;}
        {Id = 136251;
        Genres =
        [|"adventure"; "children-s"; "childrens"; "classics"; "coming-of-age";
            "contemporary"; "dragons"; "fantasy"; "fiction"; "juvenile"; "magic";
            "middle-grade"; "mystery"; "novels"; "paranormal"; "romance";
            "science-fiction-fantasy"; "supernatural"; "teen"; "urban-fantasy";
            "witches"; "wizards"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 26247008;
        Genres =
        [|"adult"; "adult-fiction"; "australia"; "chick-lit"; "contemporary"; "drama";
            "family"; "fiction"; "literary-fiction"; "marriage"; "mystery";
            "mystery-thriller"; "novels"; "realistic-fiction"; "romance"; "suspense";
            "thriller"; "womens-fiction"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 23437156;
        Genres =
        [|"action"; "adventure"; "crime"; "dark"; "fantasy"; "fiction"; "high-fantasy";
            "magic"; "mystery"; "paranormal"; "romance"; "teen"; "thriller";
            "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 39999;
        Genres =
        [|"adult"; "children-s"; "childrens"; "classics"; "contemporary"; "drama";
            "family"; "fiction"; "germany"; "historical"; "historical-fiction";
            "history"; "holocaust"; "jewish"; "juvenile"; "literature"; "middle-grade";
            "movies"; "novels"; "poland"; "read-for-school"; "realistic-fiction";
            "school"; "teen"; "war"; "world-war-ii"; "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = None;}
        {Id = 16096824;
        Genres =
        [|"action"; "adult"; "adventure"; "beauty-and-the-beast"; "fae"; "fairies";
            "fairy-tale-retellings"; "fairy-tales"; "fantasy"; "fantasy-romance";
            "fiction"; "high-fantasy"; "love"; "magic"; "new-adult"; "paranormal";
            "paranormal-romance"; "retellings"; "romance"; "supernatural"; "teen";
            "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 439288;
        Genres =
        [|"abuse"; "adult"; "banned-books"; "classics"; "coming-of-age";
            "contemporary"; "dark"; "drama"; "feminism"; "fiction"; "high-school";
            "mental-health"; "mental-illness"; "novels"; "psychology"; "read-for-school";
            "realistic-fiction"; "school"; "social-issues"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 1999;
        Language = None;}
        {Id = 370493;
        Genres =
        [|"20th-century"; "children-s"; "childrens"; "classics"; "fantasy"; "fiction";
            "inspirational"; "juvenile"; "literature"; "love"; "nature"; "philosophy";
            "picture-books"; "poetry"; "school"; "short-stories"; "young-adult";
            "young-readers"|];
        OriginalPublicationYear = Some 1964;
        Language = None;}
        {Id = 5139;
        Genres =
        [|"adult"; "adult-fiction"; "american"; "chick-lit"; "classics"; "comedy";
            "contemporary"; "contemporary-romance"; "drama"; "fiction"; "funny"; "humor";
            "literature"; "modern"; "movies"; "new-york"; "novels"; "realistic-fiction";
            "romance"; "womens-fiction"; "young-adult"|];
        OriginalPublicationYear = Some 2003;
        Language = None;}
        {Id = 2865;
        Genres =
        [|"17th-century"; "20th-century"; "adult"; "adult-fiction"; "american"; "art";
            "art-history"; "chick-lit"; "classics"; "coming-of-age"; "contemporary";
            "drama"; "fiction"; "high-school"; "historical"; "historical-fiction";
            "historical-romance"; "history"; "holland"; "literary-fiction"; "literature";
            "movies"; "novels"; "read-for-school"; "romance"; "school"; "young-adult"|];
        OriginalPublicationYear = Some 1999;
        Language = None;}
        {Id = 3876;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "american-classics";
            "banned-books"; "classic-literature"; "classics"; "college"; "drama";
            "fiction"; "france"; "high-school"; "historical"; "historical-fiction";
            "history"; "literary-fiction"; "literature"; "modern-classics"; "novels";
            "read-for-school"; "romance"; "school"; "spain"; "travel"; "war"|];
        OriginalPublicationYear = Some 1926;
        Language = Some "English (United States)";}
        {Id = 16793;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "classics"; "comics";
            "coming-of-age"; "contemporary"; "fairy-tales"; "fantasy"; "fiction";
            "graphic-novels"; "high-fantasy"; "historical"; "humor"; "love"; "magic";
            "magical-realism"; "movies"; "novels"; "paranormal"; "romance";
            "science-fiction"; "science-fiction-fantasy"; "speculative-fiction";
            "supernatural"; "urban-fantasy"; "witches"; "young-adult"|];
        OriginalPublicationYear = Some 1999;
        Language = None;}
        {Id = 16056408;
        Genres =
        [|"abuse"; "adult"; "chick-lit"; "college"; "contemporary";
            "contemporary-romance"; "drama"; "fiction"; "love"; "love-story";
            "new-adult"; "realistic-fiction"; "romance"; "romantic"; "teen";
            "young-adult"; "young-adult-romance"|];
        OriginalPublicationYear = Some 2012;
        Language = Some "English (Canada)";}
        {Id = 22055262;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "alternate-history"; "fantasy";
            "fiction"; "high-fantasy"; "historical"; "historical-fantasy";
            "historical-fiction"; "magic"; "novels"; "paranormal"; "romance";
            "science-fiction"; "supernatural"; "time-travel"; "urban-fantasy";
            "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 2203;
        Genres =
        [|"18th-century"; "adult"; "american"; "american-history"; "autobiography";
            "biography"; "biography-memoir"; "government"; "historical";
            "historical-fiction"; "history"; "leadership"; "non-fiction"; "politics";
            "presidents"; "united-states"; "us-presidents"; "war"|];
        OriginalPublicationYear = Some 2001;
        Language = Some "English (United States)";}
        {Id = 9717;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "classic-literature"; "classics";
            "contemporary"; "czech-literature"; "drama"; "european-literature";
            "fiction"; "historical"; "historical-fiction"; "history"; "literary-fiction";
            "literature"; "love"; "modern"; "modern-classics"; "novels"; "philosophy";
            "roman"; "romance"; "school"|];
        OriginalPublicationYear = Some 1984;
        Language = None;}
        {Id = 8909152;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "comedy"; "contemporary";
            "contemporary-romance"; "fiction"; "funny"; "humor"; "love"; "new-adult";
            "novels"; "realistic-fiction"; "romance"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 46170;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "american";
            "american-classics"; "american-fiction"; "banned-books";
            "classic-literature"; "classics"; "drama"; "fiction"; "high-school";
            "historical"; "historical-fiction"; "history"; "literary-fiction";
            "literature"; "military"; "modern-classics"; "novels"; "romance"; "school";
            "spain"; "war"|];
        OriginalPublicationYear = Some 1940;
        Language = None;}
        {Id = 149267;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "american";
            "apocalyptic"; "classics"; "contemporary"; "dark"; "dystopia"; "epic";
            "fantasy"; "fiction"; "horror"; "literature"; "mystery"; "mystery-thriller";
            "novels"; "paranormal"; "post-apocalyptic"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "supernatural"; "survival";
            "suspense"; "thriller"; "urban-fantasy"|];
        OriginalPublicationYear = Some 1978;
        Language = Some "English (United States)";}
        {Id = 1;
        Genres =
        [|"adventure"; "children-s"; "childrens"; "classics"; "coming-of-age";
            "contemporary"; "fantasy"; "fiction"; "juvenile"; "magic"; "middle-grade";
            "mystery"; "novels"; "paranormal"; "romance"; "science-fiction-fantasy";
            "supernatural"; "teen"; "urban-fantasy"; "witches"; "wizards"; "young-adult"|];
        OriginalPublicationYear = Some 2005;
        Language = None;}
        {Id = 10664113;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "american"; "contemporary";
            "dark-fantasy"; "dragons"; "drama"; "epic"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "historical-fiction"; "magic"; "medieval";
            "novels"; "politics"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "war"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 12294652;
        Genres =
        [|"chick-lit"; "coming-of-age"; "contemporary"; "contemporary-romance";
            "drama"; "family"; "fiction"; "funny"; "high-school"; "love"; "new-adult";
            "realistic-fiction"; "romance"; "teen"; "young-adult"; "young-adult-romance"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 2767;
        Genres =
        [|"20th-century"; "academic"; "activism"; "adult"; "american";
            "american-history"; "americana"; "classics"; "economics"; "education";
            "high-school"; "historical"; "history"; "non-fiction"; "philosophy";
            "political-science"; "politics"; "race"; "read-for-school"; "reference";
            "school"; "science"; "social"; "social-justice"; "social-science"; "society";
            "sociology"; "teaching"; "united-states"; "war"|];
        OriginalPublicationYear = Some 1980;
        Language = Some "English (United States)";}
        {Id = 135479;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "apocalyptic";
            "banned-books"; "classic-literature"; "classics"; "comedy"; "contemporary";
            "dystopia"; "fantasy"; "fiction"; "funny"; "high-school"; "humor";
            "literary-fiction"; "literature"; "modern-classics"; "novels"; "philosophy";
            "post-apocalyptic"; "religion"; "school"; "science"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"|];
        OriginalPublicationYear = Some 1963;
        Language = None;}
        {Id = 5526;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "drama"; "fiction"; "love"; "love-story"; "military";
            "movies"; "novels"; "realistic-fiction"; "relationships"; "romance";
            "romantic"; "war"; "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = Some "English (United States)";}
        {Id = 17212231;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "american"; "art";
            "contemporary"; "crime"; "detective"; "drama"; "fantasy"; "fiction";
            "historical"; "historical-fiction"; "history"; "italy"; "literature";
            "mystery"; "mystery-thriller"; "novels"; "religion"; "science-fiction";
            "suspense"; "thriller"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 10357575;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "asia"; "asian-literature";
            "classics"; "contemporary"; "cultural"; "dystopia"; "fantasy"; "fiction";
            "japan"; "japanese-literature"; "literary-fiction"; "literature";
            "magical-realism"; "mystery"; "novels"; "romance"; "science-fiction";
            "speculative-fiction"|];
        OriginalPublicationYear = Some 2009;
        Language = None;}
        {Id = 18692431;
        Genres =
        [|"chick-lit"; "coming-of-age"; "contemporary"; "contemporary-romance";
            "drama"; "family"; "fiction"; "high-school"; "illness"; "love";
            "mental-health"; "mental-illness"; "realistic-fiction"; "romance"; "teen";
            "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 8755776;
        Genres =
        [|"action"; "adventure"; "angels"; "contemporary"; "demons"; "fae"; "fairies";
            "fantasy"; "fiction"; "love"; "magic"; "paranormal"; "paranormal-romance";
            "romance"; "supernatural"; "teen"; "urban-fantasy"; "vampires"; "werewolves";
            "witches"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 24800;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "books-about-books";
            "classics"; "contemporary"; "dark"; "fantasy"; "fiction"; "gothic";
            "halloween"; "horror"; "literary-fiction"; "literature"; "magical-realism";
            "mystery"; "mystery-thriller"; "novels"; "paranormal"; "science-fiction";
            "speculative-fiction"; "supernatural"; "surreal"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 2000;
        Language = None;}
        {Id = 24583;
        Genres =
        [|"19th-century"; "adult"; "adventure"; "american"; "american-classics";
            "americana"; "banned-books"; "children-s"; "childrens"; "classic-literature";
            "classics"; "coming-of-age"; "fiction"; "high-school"; "historical";
            "historical-fiction"; "history"; "humor"; "juvenile"; "literary-fiction";
            "literature"; "middle-grade"; "novels"; "read-for-school";
            "realistic-fiction"; "school"; "southern"; "young-adult"|];
        OriginalPublicationYear = Some 1876;
        Language = None;}
        {Id = 70401;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "american";
            "american-classics"; "americana"; "autobiography"; "biography";
            "classic-literature"; "classics"; "contemporary"; "fiction";
            "literary-fiction"; "literature"; "memoir"; "modern"; "modern-classics";
            "non-fiction"; "novels"; "philosophy"; "poetry"; "road-trip"; "school";
            "travel"|];
        OriginalPublicationYear = Some 1957;
        Language = None;}
        {Id = 12000020;
        Genres =
        [|"coming-of-age"; "contemporary"; "family"; "fiction"; "gay"; "glbt";
            "high-school"; "historical-fiction"; "love"; "m-m-romance"; "novels";
            "queer"; "realistic-fiction"; "romance"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 25494343;
        Genres =
        [|"action"; "adventure"; "angels"; "contemporary"; "demons"; "fae"; "fairies";
            "fantasy"; "fiction"; "love"; "magic"; "mystery"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "teen"; "urban-fantasy";
            "vampires"; "werewolves"; "young-adult"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 3836;
        Genres =
        [|"17th-century"; "adult"; "adult-fiction"; "adventure"; "classic-literature";
            "classics"; "college"; "comedy"; "fantasy"; "fiction"; "high-school";
            "historical"; "historical-fiction"; "history"; "humor"; "literary-fiction";
            "literature"; "novels"; "read-for-school"; "romance"; "school"; "spain";
            "spanish-literature"|];
        OriginalPublicationYear = Some 1605;
        Language = None;}
        {Id = 2493;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "classic-literature"; "classics"; "dystopia"; "english-literature";
            "fantasy"; "fiction"; "historical"; "historical-fiction"; "horror";
            "literature"; "novella"; "novels"; "post-apocalyptic"; "read-for-school";
            "school"; "science"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "steampunk"; "time-travel"; "travel"; "victorian";
            "young-adult"|];
        OriginalPublicationYear = Some 1895;
        Language = None;}
        {Id = 1582996;
        Genres =
        [|"action"; "adventure"; "angels"; "contemporary"; "demons"; "fae"; "fairies";
            "fantasy"; "fiction"; "love"; "magic"; "mystery"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "teen"; "urban-fantasy";
            "vampires"; "werewolves"; "witches"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2008;
        Language = None;}
        {Id = 18774964;
        Genres =
        [|"adult"; "adult-fiction"; "comedy"; "contemporary"; "death"; "drama";
            "family"; "fiction"; "funny"; "humor"; "literary-fiction"; "literature";
            "novels"; "realistic-fiction"; "relationships"; "sweden"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 29579;
        Genres =
        [|"20th-century"; "adult"; "adventure"; "american"; "classics"; "dystopia";
            "epic"; "fantasy"; "fiction"; "literature"; "novels"; "philosophy";
            "planets"; "politics"; "science"; "science-fiction";
            "science-fiction-fantasy"; "short-stories"; "space"; "space-opera";
            "speculative-fiction"|];
        OriginalPublicationYear = Some 1951;
        Language = None;}
        {Id = 242006;
        Genres =
        [|"abuse"; "adult"; "adult-fiction"; "american"; "autobiography"; "biography";
            "biography-memoir"; "comedy"; "coming-of-age"; "contemporary"; "drama";
            "family"; "fiction"; "funny"; "gay"; "glbt"; "humor"; "literature"; "memoir";
            "mental-health"; "mental-illness"; "non-fiction"; "novels"; "psychology";
            "queer"; "young-adult"|];
        OriginalPublicationYear = Some 2002;
        Language = Some "English (United States)";}
        {Id = 27774758;
        Genres =
        [|"action"; "adventure"; "dark"; "dystopia"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "historical"; "historical-fiction"; "love";
            "magic"; "paranormal"; "romance"; "science-fiction"; "supernatural"; "teen";
            "war"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 20448515;
        Genres =
        [|"abuse"; "adult"; "adult-fiction"; "bdsm"; "chick-lit"; "contemporary";
            "contemporary-romance"; "dark"; "drama"; "erotic-romance"; "erotica";
            "fiction"; "love"; "new-adult"; "romance"; "romantic"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 42899;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "dark"; "erotic-romance"; "erotica"; "fantasy";
            "fantasy-romance"; "fiction"; "horror"; "new-adult"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "suspense"; "urban-fantasy";
            "vampires"|];
        OriginalPublicationYear = Some 2005;
        Language = Some "English (United States)";}
        {Id = 9378297;
        Genres =
        [|"action"; "contemporary"; "dark"; "death"; "demons"; "fantasy"; "fiction";
            "ghost-stories"; "ghosts"; "gothic"; "high-school"; "horror"; "magic";
            "mystery"; "paranormal"; "paranormal-romance"; "romance"; "supernatural";
            "suspense"; "teen"; "thriller"; "urban-fantasy"; "witches"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = Some "English (United States)";}
        {Id = 14743;
        Genres =
        [|"21st-century"; "adult"; "atheism"; "biology"; "christianity";
            "contemporary"; "evolution"; "fiction"; "god"; "history"; "non-fiction";
            "philosophy"; "politics"; "popular-science"; "psychology"; "reference";
            "religion"; "science"; "skepticism"; "social-science"; "society";
            "sociology"; "spirituality"; "theology"|];
        OriginalPublicationYear = Some 2006;
        Language = Some "English (United States)";}
        {Id = 15818107;
        Genres =
        [|"adoption"; "adult"; "adult-fiction"; "coming-of-age"; "contemporary";
            "drama"; "family"; "fiction"; "historical"; "historical-fiction"; "history";
            "literary-fiction"; "literature"; "novels"; "realistic-fiction";
            "relationships"; "survival"; "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 30268522;
        Genres =
        [|"adult"; "american"; "autobiography"; "biography"; "biography-memoir";
            "chick-lit"; "comedy"; "contemporary"; "essays"; "feminism"; "funny";
            "humor"; "memoir"; "non-fiction"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 366522;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "death"; "drama"; "family"; "fiction"; "humor";
            "ireland"; "love"; "love-story"; "modern"; "movies"; "novels";
            "realistic-fiction"; "romance"; "romantic"; "womens-fiction"; "young-adult"|];
        OriginalPublicationYear = Some 2003;
        Language = Some "English (United States)";}
        {Id = 13023;
        Genres =
        [|"19th-century"; "adventure"; "british-literature"; "children-s"; "childrens";
            "classic-literature"; "classics"; "english-literature"; "fairy-tales";
            "fantasy"; "fiction"; "humor"; "juvenile"; "literature"; "magic";
            "middle-grade"; "movies"; "novels"; "school"; "victorian"; "young-adult"|];
        OriginalPublicationYear = Some 1865;
        Language = None;}
        {Id = 8683812;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "biography";
            "chick-lit"; "contemporary"; "drama"; "fiction"; "france"; "historical";
            "historical-fiction"; "history"; "literary-fiction"; "literature"; "love";
            "love-story"; "marriage"; "memoir"; "non-fiction"; "novels"; "relationships";
            "romance"; "travel"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 6424171;
        Genres =
        [|"20th-century"; "action"; "adult"; "adult-fiction"; "adventure"; "american";
            "animals"; "classics"; "contemporary"; "dinosaurs"; "fantasy"; "fiction";
            "high-school"; "horror"; "literature"; "modern"; "movies"; "mystery";
            "mystery-thriller"; "novels"; "science"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "survival"; "suspense";
            "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 1991;
        Language = None;}
        {Id = 13497;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "american"; "contemporary";
            "dark-fantasy"; "dragons"; "drama"; "epic"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "historical"; "historical-fiction"; "magic";
            "medieval"; "novels"; "politics"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "war"|];
        OriginalPublicationYear = Some 2005;
        Language = Some "English (United States)";}
        {Id = 6752378;
        Genres =
        [|"action"; "adventure"; "angels"; "contemporary"; "demons"; "fae"; "fairies";
            "fantasy"; "fiction"; "love"; "magic"; "mystery"; "paranormal";
            "paranormal-romance"; "romance"; "shapeshifters"; "supernatural"; "teen";
            "urban-fantasy"; "vampires"; "werewolves"; "witches"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = Some "English (United States)";}
        {Id = 26114135;
        Genres =
        [|"abuse"; "adult"; "adult-fiction"; "coming-of-age"; "contemporary";
            "contemporary-romance"; "crime"; "dark"; "drama"; "family"; "fiction";
            "literary-fiction"; "love"; "new-adult"; "novels"; "realistic-fiction";
            "romance"; "young-adult"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 18254;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "children-s"; "childrens"; "classic-literature"; "classics"; "coming-of-age";
            "crime"; "drama"; "english-literature"; "fiction"; "historical";
            "historical-fiction"; "history"; "literary-fiction"; "literature"; "novels";
            "read-for-school"; "school"; "victorian"; "young-adult"|];
        OriginalPublicationYear = Some 1838;
        Language = None;}
        {Id = 10883;
        Genres =
        [|"18th-century"; "american"; "american-history"; "autobiography"; "biography";
            "biography-memoir"; "business"; "classics"; "france"; "historical";
            "history"; "leadership"; "memoir"; "non-fiction"; "philosophy"; "politics";
            "science"; "war"|];
        OriginalPublicationYear = Some 2003;
        Language = None;}
        {Id = 1420;
        Genres =
        [|"17th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "college"; "death"; "denmark"; "drama";
            "english-literature"; "fantasy"; "fiction"; "ghosts"; "high-school";
            "historical"; "historical-fiction"; "literature"; "novels"; "plays";
            "poetry"; "read-for-school"; "romance"; "school"; "theatre"; "tragedy"|];
        OriginalPublicationYear = Some 1600;
        Language = None;}
        {Id = 1103;
        Genres =
        [|"19th-century"; "21st-century"; "adult"; "adult-fiction"; "asia";
            "asian-literature"; "chick-lit"; "china"; "coming-of-age"; "contemporary";
            "cultural"; "drama"; "family"; "fiction"; "historical"; "historical-fiction";
            "history"; "international"; "literary-fiction"; "literature"; "novels";
            "relationships"; "romance"; "school"; "young-adult"|];
        OriginalPublicationYear = Some 2005;
        Language = None;}
        {Id = 6900;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "autobiography";
            "biography"; "biography-memoir"; "classics"; "contemporary"; "death";
            "drama"; "fiction"; "high-school"; "inspirational"; "literature"; "memoir";
            "non-fiction"; "novels"; "personal-development"; "philosophy"; "psychology";
            "read-for-school"; "realistic-fiction"; "relationships"; "religion";
            "school"; "self-help"; "spirituality"; "young-adult"|];
        OriginalPublicationYear = Some 1997;
        Language = None;}
        {Id = 34324605;
        Genres =
        [|"abuse"; "adult"; "adult-fiction"; "art"; "chick-lit"; "contemporary";
            "contemporary-romance"; "death"; "drama"; "fiction"; "love"; "new-adult";
            "novels"; "realistic-fiction"; "romance"; "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 1812457;
        Genres =
        [|"adult"; "adult-fiction"; "christian"; "christian-fiction"; "christianity";
            "contemporary"; "drama"; "faith"; "family"; "fantasy"; "fiction"; "god";
            "inspirational"; "literature"; "mystery"; "non-fiction"; "novels";
            "philosophy"; "religion"; "self-help"; "spirituality"; "suspense";
            "theology"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 76620;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "animal-fiction";
            "animals"; "british-literature"; "children-s"; "childrens";
            "classic-literature"; "classics"; "fantasy"; "fiction"; "high-school";
            "literary-fiction"; "literature"; "middle-grade"; "modern-classics";
            "nature"; "novels"; "rabbits"; "school"; "speculative-fiction"; "survival";
            "young-adult"|];
        OriginalPublicationYear = Some 1972;
        Language = None;}
        {Id = 17571564;
        Genres =
        [|"adult"; "american"; "animals"; "art"; "autobiography"; "biography";
            "biography-memoir"; "comedy"; "comics"; "contemporary"; "dogs"; "essays";
            "fiction"; "funny"; "graphic-novels"; "graphic-novels-comics"; "humor";
            "memoir"; "mental-health"; "mental-illness"; "non-fiction"; "psychology";
            "short-stories"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 3950967;
        Genres =
        [|"21st-century"; "adventure"; "british-literature"; "children-s"; "childrens";
            "classics"; "fairy-tales"; "fantasy"; "fiction"; "juvenile"; "magic";
            "middle-grade"; "novels"; "paranormal"; "short-stories"; "supernatural";
            "teen"; "witches"; "wizards"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = Some "English (United States)";}
        {Id = 8127;
        Genres =
        [|"20th-century"; "canada"; "canadian-literature"; "chick-lit"; "children-s";
            "childrens"; "childrens-classics"; "classic-literature"; "classics";
            "coming-of-age"; "family"; "fiction"; "historical"; "historical-fiction";
            "juvenile"; "literature"; "middle-grade"; "novels"; "realistic-fiction";
            "romance"; "school"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 1908;
        Language = None;}
        {Id = 15717943;
        Genres =
        [|"abuse"; "adult"; "chick-lit"; "coming-of-age"; "contemporary";
            "contemporary-romance"; "dark"; "drama"; "fiction"; "high-school"; "love";
            "mystery"; "new-adult"; "realistic-fiction"; "romance"; "teen";
            "young-adult"; "young-adult-romance"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 1845;
        Genres =
        [|"20th-century"; "adult"; "adventure"; "american"; "autobiography";
            "biography"; "biography-memoir"; "classics"; "coming-of-age"; "contemporary";
            "death"; "drama"; "environment"; "fiction"; "high-school"; "history";
            "inspirational"; "journalism"; "literature"; "memoir"; "movies"; "nature";
            "non-fiction"; "novels"; "outdoors"; "philosophy"; "read-for-school";
            "school"; "survival"; "travel"; "true-story"; "wilderness"; "young-adult"|];
        OriginalPublicationYear = Some 1996;
        Language = None;}
        {Id = 4929;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "adventure"; "asia";
            "asian-literature"; "cats"; "classics"; "coming-of-age"; "contemporary";
            "drama"; "fantasy"; "fiction"; "japan"; "japanese-literature";
            "literary-fiction"; "literature"; "magical-realism"; "modern"; "mystery";
            "novels"; "philosophy"; "romance"; "speculative-fiction"; "surreal"|];
        OriginalPublicationYear = Some 2002;
        Language = Some "English (United States)";}
        {Id = 556602;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "contemporary"; "cultural"; "death";
            "drama"; "family"; "fiction"; "france"; "historical"; "historical-fiction";
            "history"; "holocaust"; "jewish"; "literary-fiction"; "literature";
            "mystery"; "novels"; "realistic-fiction"; "roman"; "school"; "tragedy";
            "war"; "world-war-ii"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 19543;
        Genres =
        [|"20th-century"; "adventure"; "american"; "animals"; "art"; "children-s";
            "childrens"; "classics"; "family"; "fantasy"; "fiction"; "humor"; "juvenile";
            "picture-books"; "school"; "storytime"; "young-adult"|];
        OriginalPublicationYear = Some 1963;
        Language = None;}
        {Id = 51496;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "crime"; "dark"; "english-literature";
            "fantasy"; "fiction"; "gothic"; "gothic-horror"; "high-school"; "historical";
            "historical-fiction"; "horror"; "literary-fiction"; "literature"; "mystery";
            "mystery-thriller"; "novella"; "novels"; "paranormal"; "psychology";
            "read-for-school"; "school"; "science-fiction"; "short-stories";
            "supernatural"; "suspense"; "thriller"; "victorian"|];
        OriginalPublicationYear = Some 1886;
        Language = None;}
        {Id = 485894;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "classic-literature"; "classics";
            "college"; "drama"; "european-literature"; "fantasy"; "fiction";
            "german-literature"; "germany"; "high-school"; "horror"; "literary-fiction";
            "literature"; "magical-realism"; "modern-classics"; "novella"; "novels";
            "philosophy"; "read-for-school"; "school"; "science-fiction";
            "short-stories"; "surreal"|];
        OriginalPublicationYear = Some 1912;
        Language = Some "English (United States)";}
        {Id = 17383917;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "british-literature"; "catholic";
            "christian"; "christian-fiction"; "christian-non-fiction"; "christianity";
            "church"; "classic-literature"; "classics"; "faith"; "fantasy"; "fiction";
            "humor"; "inspirational"; "literary-fiction"; "literature"; "non-fiction";
            "novels"; "philosophy"; "religion"; "school"; "spirituality"; "supernatural";
            "theology"|];
        OriginalPublicationYear = Some 1942;
        Language = None;}
        {Id = 13099738;
        Genres =
        [|"adult"; "art"; "art-design"; "business"; "design"; "education"; "essays";
            "graphic-novels"; "how-to"; "humor"; "inspirational"; "non-fiction";
            "personal-development"; "philosophy"; "photography"; "productivity";
            "psychology"; "reference"; "self-help"; "writing"|];
        OriginalPublicationYear = Some 2010;
        Language = Some "English (United States)";}
        {Id = 6892870;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "contemporary"; "crime";
            "detective"; "drama"; "fiction"; "journalism"; "literature";
            "murder-mystery"; "mystery"; "mystery-thriller"; "nordic-noir"; "novels";
            "realistic-fiction"; "suspense"; "sweden"; "thriller"|];
        OriginalPublicationYear = Some 2007;
        Language = Some "English (United States)";}
        {Id = 16071764;
        Genres =
        [|"adult"; "autobiography"; "biography"; "biography-memoir"; "business";
            "contemporary"; "entrepreneurship"; "feminism"; "gender"; "gender-roles";
            "gender-studies"; "inspirational"; "leadership"; "management"; "memoir";
            "non-fiction"; "personal-development"; "politics"; "psychology"; "self-help";
            "sociology"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 62291;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "american"; "contemporary";
            "dark-fantasy"; "dragons"; "drama"; "epic"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "historical"; "historical-fiction"; "magic";
            "medieval"; "novels"; "politics"; "romance"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "supernatural"; "war"|];
        OriginalPublicationYear = Some 2000;
        Language = Some "English (United States)";}
        {Id = 2122;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "architecture";
            "business"; "classic-literature"; "classics"; "contemporary"; "drama";
            "dystopia"; "economics"; "fiction"; "high-school"; "historical-fiction";
            "literary-fiction"; "literature"; "modern-classics"; "non-fiction"; "novels";
            "philosophy"; "politics"; "romance"; "school"; "science-fiction"|];
        OriginalPublicationYear = Some 1943;
        Language = None;}
        {Id = 15796700;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "africa"; "african-american";
            "african-literature"; "american"; "coming-of-age"; "contemporary";
            "cultural"; "feminism"; "fiction"; "historical-fiction"; "international";
            "literary-fiction"; "literature"; "novels"; "race"; "realistic-fiction";
            "relationships"; "romance"; "social-justice"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 7937843;
        Genres =
        [|"abuse"; "adult"; "adult-fiction"; "contemporary"; "crime"; "dark"; "drama";
            "family"; "fiction"; "horror"; "literary-fiction"; "literature";
            "mental-health"; "mystery"; "novels"; "psychology"; "realistic-fiction";
            "survival"; "suspense"; "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = Some "English (United States)";}
        {Id = 6149;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "african-american";
            "african-american-literature"; "american"; "banned-books";
            "classic-literature"; "classics"; "college"; "contemporary"; "drama";
            "fantasy"; "feminism"; "fiction"; "ghosts"; "high-school"; "historical";
            "historical-fiction"; "history"; "horror"; "literary-fiction"; "literature";
            "magical-realism"; "modern-classics"; "novels"; "paranormal"; "race";
            "read-for-school"; "school"; "southern"; "supernatural"|];
        OriginalPublicationYear = Some 1987;
        Language = None;}
        {Id = 28676;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "banned-books";
            "classics"; "contemporary"; "crime"; "dark"; "drama"; "fiction"; "horror";
            "humor"; "literary-fiction"; "literature"; "mental-illness"; "modern";
            "modern-classics"; "movies"; "mystery"; "mystery-thriller"; "new-york";
            "novels"; "psychology"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1991;
        Language = None;}
        {Id = 10194514;
        Genres =
        [|"abuse"; "chick-lit"; "contemporary"; "contemporary-romance"; "drama";
            "family"; "fiction"; "high-school"; "love"; "mental-illness"; "mystery";
            "new-adult"; "realistic-fiction"; "romance"; "teen"; "young-adult";
            "young-adult-romance"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 9791;
        Genres =
        [|"20th-century"; "adult"; "adventure"; "american"; "autobiography";
            "biography"; "biography-memoir"; "comedy"; "contemporary"; "environment";
            "essays"; "fiction"; "funny"; "history"; "humor"; "memoir"; "nature";
            "non-fiction"; "outdoors"; "science"; "travel"; "travelogue"; "walking";
            "wilderness"|];
        OriginalPublicationYear = Some 1997;
        Language = Some "English (United States)";}
        {Id = 50398;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature"; "chick-lit";
            "classic-literature"; "classics"; "coming-of-age"; "drama";
            "english-literature"; "fiction"; "gothic"; "historical";
            "historical-fiction"; "historical-romance"; "history"; "humor";
            "literary-fiction"; "literature"; "mystery"; "novels"; "read-for-school";
            "regency"; "romance"; "romantic"; "school"; "victorian"|];
        OriginalPublicationYear = Some 1817;
        Language = None;}
        {Id = 480479;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "autobiography"; "biography";
            "biography-memoir"; "chick-lit"; "classics"; "contemporary";
            "contemporary-romance"; "cookbooks"; "cooking"; "cultural"; "drama";
            "fiction"; "food"; "food-and-drink"; "foodie"; "humor"; "italy";
            "literature"; "memoir"; "movies"; "non-fiction"; "novels"; "romance";
            "travel"; "travelogue"|];
        OriginalPublicationYear = Some 1996;
        Language = None;}
        {Id = 27362503;
        Genres =
        [|"abuse"; "adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "dark"; "drama"; "family"; "fiction"; "love";
            "new-adult"; "realistic-fiction"; "romance"; "young-adult"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 32145;
        Genres =
        [|"adult"; "anthropology"; "biology"; "comedy"; "death"; "essays"; "fiction";
            "funny"; "health"; "history"; "humor"; "journalism"; "medical"; "medicine";
            "memoir"; "microhistory"; "non-fiction"; "popular-science"; "psychology";
            "reference"; "research"; "school"; "science"; "sociology"|];
        OriginalPublicationYear = Some 2003;
        Language = None;}
        {Id = 17623975;
        Genres =
        [|"adventure"; "chick-lit"; "college"; "coming-of-age"; "contemporary";
            "contemporary-romance"; "drama"; "family"; "fiction"; "france"; "love";
            "new-adult"; "realistic-fiction"; "road-trip"; "romance"; "teen"; "travel";
            "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 236093;
        Genres =
        [|"20th-century"; "adventure"; "american"; "chapter-books"; "children-s";
            "childrens"; "childrens-classics"; "classic-literature"; "classics";
            "fairy-tales"; "fantasy"; "fiction"; "juvenile"; "literature"; "magic";
            "middle-grade"; "movies"; "novels"; "school"; "witches"; "young-adult"|];
        OriginalPublicationYear = Some 1900;
        Language = None;}
        {Id = 10799;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "american-classics";
            "american-fiction"; "banned-books"; "classic-literature"; "classics";
            "college"; "drama"; "fiction"; "high-school"; "historical";
            "historical-fiction"; "history"; "italy"; "literary-fiction"; "literature";
            "military"; "modern-classics"; "novels"; "read-for-school"; "romance";
            "school"; "war"; "world-war-i"|];
        OriginalPublicationYear = Some 1929;
        Language = Some "English (United States)";}
        {Id = 4900;
        Genres =
        [|"19th-century"; "20th-century"; "adult"; "adult-fiction"; "adventure";
            "africa"; "british-literature"; "classic-literature"; "classics"; "college";
            "dark"; "drama"; "english-literature"; "fiction"; "high-school";
            "historical"; "historical-fiction"; "history"; "horror"; "literary-fiction";
            "literature"; "novella"; "novels"; "philosophy"; "read-for-school"; "school";
            "travel"; "victorian"|];
        OriginalPublicationYear = Some 1899;
        Language = None;}
        {Id = 14201;
        Genres =
        [|"19th-century"; "21st-century"; "adult"; "adult-fiction"; "adventure";
            "alternate-history"; "british-literature"; "classics"; "contemporary";
            "fairies"; "fantasy"; "fiction"; "gothic"; "historical";
            "historical-fantasy"; "historical-fiction"; "history"; "literary-fiction";
            "literature"; "magic"; "magical-realism"; "mystery"; "novels"; "paranormal";
            "regency"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "supernatural"; "urban-fantasy"; "victorian"|];
        OriginalPublicationYear = Some 2004;
        Language = None;}
        {Id = 14748;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "comedy"; "contemporary";
            "contemporary-romance"; "drama"; "family"; "fiction"; "funny"; "humor";
            "novels"; "realistic-fiction"; "relationships"; "romance"; "womens-fiction"|];
        OriginalPublicationYear = Some 2001;
        Language = Some "English (United States)";}
        {Id = 13547180;
        Genres =
        [|"adult"; "american"; "autobiography"; "biography"; "biography-memoir";
            "brain"; "contemporary"; "fiction"; "health"; "illness"; "journalism";
            "medical"; "medicine"; "memoir"; "mental-health"; "mental-illness";
            "mystery"; "neuroscience"; "new-york"; "non-fiction"; "psychology";
            "science"; "true-story"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 18512;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "classic-literature"; "classics"; "epic"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "literature"; "magic"; "modern-classics";
            "movies"; "novels"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "war"; "wizards"; "young-adult"|];
        OriginalPublicationYear = Some 1955;
        Language = Some "English (United States)";}
        {Id = 3591262;
        Genres =
        [|"adult"; "adult-fiction"; "africa"; "coming-of-age"; "contemporary";
            "cultural"; "drama"; "family"; "fiction"; "historical"; "historical-fiction";
            "history"; "india"; "international"; "literary-fiction"; "literature";
            "medical"; "medicine"; "non-fiction"; "novels"; "realistic-fiction";
            "relationships"|];
        OriginalPublicationYear = Some 2009;
        Language = None;}
        {Id = 3109;
        Genres =
        [|"adult"; "agriculture"; "anthropology"; "biology"; "cookbooks"; "cooking";
            "culinary"; "ecology"; "economics"; "environment"; "fitness"; "food";
            "food-and-drink"; "food-writing"; "foodie"; "health"; "history";
            "journalism"; "medical"; "memoir"; "nature"; "non-fiction"; "nutrition";
            "philosophy"; "politics"; "reference"; "school"; "science"; "social";
            "social-issues"; "social-science"; "society"; "sociology"; "sustainability";
            "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = None;}
        {Id = 33;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "classic-literature"; "classics"; "english-literature"; "epic";
            "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy"; "literature"; "magic";
            "modern-classics"; "movies"; "mythology"; "novels"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "war"; "young-adult"|];
        OriginalPublicationYear = Some 1955;
        Language = Some "English (United States)";}
        {Id = 23807;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "classics";
            "contemporary"; "crime"; "dark"; "detective"; "drama"; "fiction"; "horror";
            "literature"; "movies"; "murder-mystery"; "mystery"; "mystery-thriller";
            "novels"; "psychological-thriller"; "psychology"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1988;
        Language = None;}
        {Id = 7812659;
        Genres =
        [|"abuse"; "adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "drama"; "family"; "fiction"; "love"; "love-story";
            "movies"; "mystery"; "novels"; "realistic-fiction"; "relationships";
            "romance"; "romantic"; "suspense"; "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 2175;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "banned-books";
            "classic-literature"; "classics"; "college"; "drama"; "feminism"; "fiction";
            "france"; "french-literature"; "high-school"; "historical";
            "historical-fiction"; "literary-fiction"; "literature"; "love"; "novels";
            "read-for-school"; "romance"; "school"; "victorian"|];
        OriginalPublicationYear = Some 1856;
        Language = None;}
        {Id = 17690;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "classic-literature"; "classics";
            "crime"; "czech-literature"; "drama"; "dystopia"; "european-literature";
            "fantasy"; "fiction"; "german-literature"; "germany"; "horror"; "law";
            "literary-fiction"; "literature"; "modern"; "modern-classics"; "mystery";
            "novels"; "philosophy"; "politics"; "psychology"; "read-for-school"; "roman";
            "school"; "science-fiction"|];
        OriginalPublicationYear = Some 1925;
        Language = None;}
        {Id = 51737;
        Genres =
        [|"chick-lit"; "coming-of-age"; "contemporary"; "contemporary-romance";
            "death"; "drama"; "family"; "fiction"; "high-school"; "love"; "novels";
            "realistic-fiction"; "romance"; "romantic"; "teen"; "young-adult";
            "young-adult-romance"|];
        OriginalPublicationYear = Some 2004;
        Language = Some "English (United States)";}
        {Id = 114683;
        Genres =
        [|"activism"; "adult"; "art"; "art-design"; "art-history"; "biography";
            "contemporary"; "design"; "funny"; "graffiti"; "graphic-novels"; "humor";
            "memoir"; "modern"; "non-fiction"; "philosophy"; "photography"; "poetry";
            "politics"; "pop-culture"; "reference"; "street-art"; "visual-art"|];
        OriginalPublicationYear = Some 1988;
        Language = None;}
        {Id = 9742;
        Genres =
        [|"adult"; "african-american"; "american"; "american-history"; "autobiography";
            "biography"; "biography-memoir"; "contemporary"; "essays"; "ethnic";
            "government"; "historical"; "history"; "inspirational"; "international";
            "leadership"; "memoir"; "non-fiction"; "philosophy"; "political-science";
            "politics"; "presidents"; "race"; "science"; "social"|];
        OriginalPublicationYear = Some 2006;
        Language = Some "English (United States)";}
        {Id = 15241;
        Genres =
        [|"20th-century"; "action"; "adult"; "adult-fiction"; "adventure";
            "british-literature"; "classic-literature"; "classics"; "epic";
            "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy"; "literature"; "magic";
            "modern-classics"; "movies"; "novels"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "war"; "wizards";
            "young-adult"|];
        OriginalPublicationYear = Some 1954;
        Language = Some "English (United States)";}
        {Id = 45032;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature"; "chick-lit";
            "classic-literature"; "classics"; "drama"; "english-literature"; "fiction";
            "historical"; "historical-fiction"; "historical-romance"; "literary-fiction";
            "literature"; "love"; "novels"; "regency"; "romance"; "romantic"; "school";
            "victorian"|];
        OriginalPublicationYear = Some 1814;
        Language = None;}
        {Id = 30597;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "adventure"; "classic-literature";
            "classics"; "drama"; "fantasy"; "fiction"; "france"; "french-literature";
            "gothic"; "historical"; "historical-fiction"; "history"; "horror";
            "literary-fiction"; "literature"; "love"; "medieval"; "movies"; "novels";
            "romance"; "school"; "tragedy"|];
        OriginalPublicationYear = Some 1831;
        Language = None;}
        {Id = 21032488;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "epic"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "magic"; "novels"; "science-fiction";
            "science-fiction-fantasy"|];
        OriginalPublicationYear = None;
        Language = None;}
        {Id = 18798983;
        Genres =
        [|"adventure"; "fairy-tale-retellings"; "fairy-tales"; "fantasy"; "fiction";
            "high-fantasy"; "historical"; "historical-fiction"; "magic"; "mystery";
            "mythology"; "paranormal"; "retellings"; "romance"; "teen"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 1067;
        Genres =
        [|"18th-century"; "adult"; "american"; "american-history"; "biography";
            "classics"; "fiction"; "historical"; "historical-fiction"; "history";
            "military"; "military-history"; "non-fiction"; "politics"; "presidents";
            "school"; "united-states"; "war"|];
        OriginalPublicationYear = Some 2005;
        Language = None;}
        {Id = 37415;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "african-american";
            "african-american-literature"; "american"; "banned-books";
            "classic-literature"; "classics"; "college"; "contemporary"; "cultural";
            "feminism"; "fiction"; "high-school"; "historical"; "historical-fiction";
            "history"; "literary-fiction"; "literature"; "love"; "modern-classics";
            "novels"; "race"; "read-for-school"; "realistic-fiction"; "romance";
            "school"; "southern"; "young-adult"|];
        OriginalPublicationYear = Some 1937;
        Language = None;}
        {Id = 7869;
        Genres =
        [|"20th-century"; "action"; "adult"; "adult-fiction"; "adventure"; "american";
            "classics"; "contemporary"; "crime"; "drama"; "espionage"; "fiction";
            "military"; "movies"; "mystery"; "mystery-thriller"; "novels";
            "spy-thriller"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1980;
        Language = None;}
        {Id = 22463;
        Genres =
        [|"19th-century"; "academic"; "adult"; "animals"; "anthropology";
            "banned-books"; "biology"; "classic-literature"; "classics"; "college";
            "ecology"; "environment"; "essays"; "evolution"; "fiction"; "historical";
            "history"; "history-of-science"; "literature"; "natural-history"; "nature";
            "non-fiction"; "philosophy"; "popular-science"; "read-for-school";
            "reference"; "religion"; "school"; "science"; "science-nature"; "theory"|];
        OriginalPublicationYear = Some 1859;
        Language = None;}
        {Id = 252577;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "autobiography"; "biography";
            "biography-memoir"; "classics"; "coming-of-age"; "contemporary"; "cultural";
            "drama"; "family"; "fiction"; "high-school"; "historical";
            "historical-fiction"; "history"; "ireland"; "irish-literature"; "literature";
            "memoir"; "non-fiction"; "novels"; "poverty"; "read-for-school"; "school";
            "true-story"|];
        OriginalPublicationYear = Some 1996;
        Language = None;}
        {Id = 52529;
        Genres =
        [|"adult"; "business"; "fiction"; "inspirational"; "metaphysics"; "new-age";
            "non-fiction"; "novels"; "personal-development"; "philosophy"; "psychology";
            "reference"; "religion"; "self-help"; "spirituality"|];
        OriginalPublicationYear = Some 2006;
        Language = None;}
        {Id = 7728889;
        Genres =
        [|"adventure"; "crime"; "fantasy"; "fiction"; "ghosts"; "gothic"; "historical";
            "historical-fantasy"; "historical-fiction"; "history"; "horror"; "magic";
            "magical-realism"; "mystery"; "mystery-thriller"; "new-york"; "paranormal";
            "romance"; "science-fiction"; "supernatural"; "suspense"; "teen"; "thriller";
            "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = Some "English (United States)";}
        {Id = 5326;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature"; "children-s";
            "childrens"; "christmas"; "classic-literature"; "classics"; "drama";
            "english-literature"; "fantasy"; "fiction"; "ghosts"; "historical";
            "historical-fiction"; "holiday"; "literary-fiction"; "literature"; "novella";
            "novels"; "paranormal"; "read-for-school"; "school"; "short-stories";
            "supernatural"; "time-travel"; "victorian"; "young-adult"|];
        OriginalPublicationYear = Some 1843;
        Language = None;}
        {Id = 251688;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "american-classics";
            "chick-lit"; "classic-literature"; "classics"; "contemporary"; "drama";
            "fiction"; "historical-fiction"; "literary-fiction"; "literature"; "love";
            "modern"; "modern-classics"; "movies"; "new-york"; "novella"; "novels";
            "romance"; "short-stories"|];
        OriginalPublicationYear = Some 1958;
        Language = None;}
        {Id = 350;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "aliens"; "american"; "classics";
            "dystopia"; "fantasy"; "fiction"; "literature"; "novels"; "philosophy";
            "religion"; "science"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"|];
        OriginalPublicationYear = Some 1961;
        Language = None;}
        {Id = 13206828;
        Genres =
        [|"action"; "adventure"; "aliens"; "dystopia"; "fairy-tale-retellings";
            "fairy-tales"; "fantasy"; "fiction"; "funny"; "futuristic"; "magic";
            "paranormal"; "retellings"; "romance"; "science-fiction"; "space";
            "steampunk"; "teen"; "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 30289;
        Genres =
        [|"academic"; "ancient"; "ancient-history"; "classic-literature";
            "classical-studies"; "classics"; "college"; "education"; "fiction"; "greece";
            "historical"; "history"; "literature"; "non-fiction"; "philosophy";
            "political-science"; "politics"; "psychology"; "read-for-school";
            "reference"; "religion"; "school"; "science"; "society"; "sociology";
            "theory"|];
        OriginalPublicationYear = Some -380;
        Language = None;}
        {Id = 295;
        Genres =
        [|"19th-century"; "action"; "adventure"; "british-literature"; "children-s";
            "childrens"; "childrens-classics"; "classic-literature"; "classics";
            "english-literature"; "fantasy"; "fiction"; "historical";
            "historical-fiction"; "history"; "juvenile"; "literary-fiction";
            "literature"; "middle-grade"; "novels"; "pirates"; "read-for-school";
            "school"; "victorian"; "young-adult"|];
        OriginalPublicationYear = Some 1882;
        Language = None;}
        {Id = 767171;
        Genres =
        [|"20th-century"; "biography"; "classics"; "european-history"; "germany";
            "historical"; "history"; "holocaust"; "military"; "military-history";
            "non-fiction"; "political-science"; "politics"; "reference"; "war";
            "world-history"; "world-war-ii"|];
        OriginalPublicationYear = Some 1960;
        Language = None;}
        {Id = 9361589;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "contemporary"; "fantasy"; "fiction";
            "historical"; "historical-fantasy"; "historical-fiction"; "literary-fiction";
            "literature"; "love"; "magic"; "magical-realism"; "mystery"; "novels";
            "paranormal"; "romance"; "supernatural"; "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 92303;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "college"; "comedy"; "drama";
            "english-literature"; "fiction"; "funny"; "high-school"; "historical";
            "historical-fiction"; "humor"; "ireland"; "irish-literature";
            "literary-fiction"; "literature"; "novels"; "plays"; "read-for-school";
            "romance"; "school"; "short-stories"; "theatre"; "victorian"|];
        OriginalPublicationYear = Some 1899;
        Language = None;}
        {Id = 7235533;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "epic"; "epic-fantasy";
            "fantasy"; "fiction"; "high-fantasy"; "magic"; "novels"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "war"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 375013;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "australia"; "banned-books";
            "biography"; "biography-memoir"; "classics"; "contemporary"; "drama";
            "european-history"; "fiction"; "film"; "germany"; "historical";
            "historical-fiction"; "history"; "holocaust"; "jewish"; "literature";
            "memoir"; "modern-classics"; "movies"; "non-fiction"; "novels"; "poland";
            "survival"; "true-story"; "war"; "world-war-ii"|];
        OriginalPublicationYear = Some 1982;
        Language = None;}
        {Id = 7664334;
        Genres =
        [|"adventure"; "chick-lit"; "coming-of-age"; "contemporary";
            "contemporary-romance"; "death"; "family"; "fiction"; "funny"; "high-school";
            "love"; "music"; "new-adult"; "realistic-fiction"; "road-trip"; "romance";
            "teen"; "travel"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 343;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "classics"; "contemporary";
            "crime"; "dark"; "drama"; "european-literature"; "fantasy"; "fiction";
            "france"; "german-literature"; "germany"; "gothic"; "historical";
            "historical-fiction"; "history"; "horror"; "literary-fiction"; "literature";
            "magical-realism"; "modern-classics"; "movies"; "mystery";
            "mystery-thriller"; "novels"; "read-for-school"; "roman"; "school";
            "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1985;
        Language = None;}
        {Id = 9777;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "asia"; "asian-literature";
            "classics"; "contemporary"; "cultural"; "drama"; "family"; "fiction";
            "historical"; "historical-fiction"; "india"; "indian-literature";
            "international"; "literary-fiction"; "literature"; "love"; "magical-realism";
            "modern-classics"; "novels"; "read-for-school"; "romance"; "school"|];
        OriginalPublicationYear = Some 1997;
        Language = Some "English (United States)";}
        {Id = 24612118;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "contemporary";
            "drama"; "family"; "fiction"; "literary-fiction"; "literature"; "love";
            "marriage"; "new-york"; "novels"; "realistic-fiction"; "relationships";
            "romance"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 34497;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "classics"; "comedy"; "dragons"; "epic-fantasy"; "fantasy"; "fiction";
            "funny"; "high-fantasy"; "humor"; "magic"; "novels"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "wizards"; "young-adult"|];
        OriginalPublicationYear = Some 1983;
        Language = None;}
        {Id = 5890;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "crime"; "detective"; "english-literature";
            "fiction"; "gothic"; "historical"; "historical-fiction"; "horror";
            "literary-fiction"; "literature"; "mystery"; "mystery-thriller"; "novels";
            "romance"; "school"; "suspense"; "thriller"; "victorian"|];
        OriginalPublicationYear = Some 1859;
        Language = None;}
        {Id = 117833;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "classic-literature"; "classics";
            "contemporary"; "fantasy"; "fiction"; "historical"; "historical-fiction";
            "history"; "horror"; "humor"; "literary-fiction"; "literature"; "magic";
            "magical-realism"; "modern"; "modern-classics"; "mystery"; "novels";
            "philosophy"; "politics"; "religion"; "romance"; "russia";
            "russian-literature"; "school"; "supernatural"|];
        OriginalPublicationYear = Some 1966;
        Language = None;}
        {Id = 10614;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "classics";
            "contemporary"; "crime"; "dark"; "drama"; "fantasy"; "fiction"; "horror";
            "movies"; "mystery"; "mystery-thriller"; "novels"; "psychological-thriller";
            "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1987;
        Language = Some "English (United Kingdom)";}
        {Id = 11468377;
        Genres =
        [|"academic"; "brain"; "business"; "design"; "economics"; "education";
            "finance"; "leadership"; "management"; "neuroscience"; "non-fiction";
            "personal-development"; "philosophy"; "popular-science"; "productivity";
            "psychology"; "science"; "self-help"; "social-science"; "sociology"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 12391521;
        Genres =
        [|"adult"; "biography"; "contemporary"; "crime"; "essays"; "fiction"; "funny";
            "health"; "history"; "humor"; "journalism"; "medical"; "medicine"; "memoir";
            "mental-health"; "mental-illness"; "mystery"; "neuroscience"; "non-fiction";
            "philosophy"; "politics"; "popular-science"; "psychology"; "reference";
            "science"; "self-help"; "social-science"; "society"; "sociology";
            "true-crime"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 19057;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "australia"; "coming-of-age";
            "contemporary"; "drama"; "fantasy"; "fiction"; "funny"; "high-school";
            "humor"; "inspirational"; "literature"; "mystery"; "mystery-thriller";
            "new-adult"; "novels"; "realistic-fiction"; "romance"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2002;
        Language = Some "English (United States)";}
        {Id = 228665;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "american"; "classics"; "epic";
            "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy"; "magic"; "novels";
            "science-fiction"; "science-fiction-fantasy"; "speculative-fiction";
            "young-adult"|];
        OriginalPublicationYear = Some 1990;
        Language = None;}
        {Id = 28187230;
        Genres =
        [|"adult"; "adult-fiction"; "contemporary"; "crime"; "drama"; "fiction";
            "horror"; "murder-mystery"; "mystery"; "mystery-thriller"; "novels";
            "psychological-thriller"; "suspense"; "thriller"; "travel"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 355697;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "banned-books";
            "classic-literature"; "classics"; "college"; "drama"; "fiction"; "france";
            "german-literature"; "germany"; "high-school"; "historical";
            "historical-fiction"; "history"; "literary-fiction"; "literature";
            "military"; "modern-classics"; "non-fiction"; "novels"; "read-for-school";
            "realistic-fiction"; "school"; "war"; "world-war-i"; "young-adult"|];
        OriginalPublicationYear = Some 1929;
        Language = Some "English (United States)";}
        {Id = 480204;
        Genres =
        [|"19th-century"; "20th-century"; "adult"; "adult-fiction"; "adventure";
            "classic-literature"; "classics"; "crime"; "dark"; "drama"; "fantasy";
            "fiction"; "france"; "french-literature"; "gothic"; "gothic-horror";
            "historical"; "historical-fiction"; "historical-romance"; "history";
            "horror"; "literary-fiction"; "literature"; "love"; "movies"; "music";
            "mystery"; "novels"; "paranormal"; "plays"; "romance"; "supernatural";
            "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1909;
        Language = None;}
        {Id = 567616;
        Genres =
        [|"art"; "art-and-photography"; "art-design"; "art-history"; "design";
            "graphic-novels"; "historical"; "history"; "non-fiction"; "photography";
            "reference"; "visual-art"|];
        OriginalPublicationYear = Some 1997;
        Language = None;}
        {Id = 32261;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "drama"; "english-literature"; "feminism";
            "fiction"; "high-school"; "historical"; "historical-fiction";
            "historical-romance"; "literary-fiction"; "literature"; "love"; "novels";
            "read-for-school"; "romance"; "school"; "tragedy"; "victorian"|];
        OriginalPublicationYear = Some 1891;
        Language = None;}
        {Id = 11808950;
        Genres =
        [|"angels"; "contemporary"; "demons"; "fantasy"; "fiction"; "high-school";
            "love"; "magic"; "mythology"; "new-adult"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "teen"; "urban-fantasy";
            "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 5821978;
        Genres =
        [|"chick-lit"; "coming-of-age"; "contemporary"; "contemporary-romance";
            "drama"; "family"; "fiction"; "high-school"; "love"; "realistic-fiction";
            "romance"; "teen"; "young-adult"; "young-adult-romance"|];
        OriginalPublicationYear = Some 2009;
        Language = Some "English (United States)";}
        {Id = 13517535;
        Genres =
        [|"adult"; "chick-lit"; "college"; "contemporary"; "contemporary-romance";
            "drama"; "erotic-romance"; "erotica"; "fiction"; "love"; "music";
            "musicians"; "new-adult"; "realistic-fiction"; "romance"; "young-adult"|];
        OriginalPublicationYear = Some 2009;
        Language = None;}
        {Id = 22318578;
        Genres =
        [|"adult"; "asia"; "health"; "how-to"; "inspirational"; "japan"; "non-fiction";
            "personal-development"; "philosophy"; "productivity"; "psychology";
            "reference"; "self-help"; "spirituality"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 16429619;
        Genres =
        [|"adventure"; "dystopia"; "fantasy"; "fiction"; "high-fantasy"; "historical";
            "historical-fiction"; "magic"; "mystery"; "paranormal"; "romance"; "teen";
            "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 2120932;
        Genres =
        [|"action"; "adventure"; "children-s"; "childrens"; "contemporary"; "fantasy";
            "fiction"; "funny"; "gods"; "greek-mythology"; "humor"; "juvenile"; "magic";
            "middle-grade"; "mystery"; "mythology"; "novels"; "paranormal"; "romance";
            "supernatural"; "teen"; "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2008;
        Language = Some "English (United States)";}
        {Id = 53835;
        Genres =
        [|"19th-century"; "20th-century"; "adult"; "adult-fiction"; "american";
            "american-classics"; "classic-literature"; "classics"; "drama"; "feminism";
            "fiction"; "historical"; "historical-fiction"; "history"; "literary-fiction";
            "literature"; "love"; "new-york"; "novels"; "romance"; "school"; "victorian"|];
        OriginalPublicationYear = Some 1920;
        Language = None;}
        {Id = 10569;
        Genres =
        [|"adult"; "american"; "art"; "autobiography"; "biography"; "biography-memoir";
            "books-about-books"; "contemporary"; "education"; "essays"; "fiction";
            "horror"; "how-to"; "language"; "literature"; "memoir"; "non-fiction";
            "reference"; "research"; "school"; "self-help"; "writing"|];
        OriginalPublicationYear = Some 1999;
        Language = None;}
        {Id = 18879761;
        Genres =
        [|"chick-lit"; "college"; "coming-of-age"; "contemporary"; "death"; "drama";
            "family"; "fiction"; "high-school"; "mental-health"; "mental-illness";
            "mystery"; "new-adult"; "novels"; "realistic-fiction"; "road-trip";
            "romance"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 22544764;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "coming-of-age"; "dark"; "dragons";
            "epic-fantasy"; "fairy-tales"; "fantasy"; "fantasy-romance"; "fiction";
            "folklore"; "high-fantasy"; "historical"; "magic"; "mythology"; "new-adult";
            "novels"; "paranormal"; "retellings"; "romance"; "science-fiction";
            "science-fiction-fantasy"; "supernatural"; "teen"; "witches"; "wizards";
            "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 17333230;
        Genres =
        [|"19th-century"; "21st-century"; "adult"; "adult-fiction"; "australia";
            "contemporary"; "crime"; "fiction"; "historical"; "historical-fiction";
            "history"; "literary-fiction"; "literature"; "mystery"; "mystery-thriller";
            "novels"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 46787;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "adventure"; "african-american";
            "american"; "american-classics"; "american-history"; "banned-books";
            "christian"; "civil-war"; "classic-literature"; "classics"; "college";
            "drama"; "fiction"; "high-school"; "historical"; "historical-fiction";
            "history"; "literary-fiction"; "literature"; "novels"; "politics"; "race";
            "read-for-school"; "religion"; "school"; "southern"; "young-adult"|];
        OriginalPublicationYear = Some 1852;
        Language = None;}
        {Id = 830;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "american";
            "classics"; "contemporary"; "cyberpunk"; "dystopia"; "fantasy"; "fiction";
            "humor"; "literature"; "mystery"; "mythology"; "novels"; "religion";
            "science"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "technology"; "thriller"|];
        OriginalPublicationYear = Some 1992;
        Language = None;}
        {Id = 18584855;
        Genres =
        [|"adventure"; "fairy-tale-retellings"; "fairy-tales"; "fantasy"; "fiction";
            "high-fantasy"; "magic"; "novels"; "retellings"; "romance"; "teen";
            "young-adult"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 15753740;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "contemporary"; "drama"; "family";
            "fiction"; "historical"; "historical-fiction"; "history"; "holocaust";
            "literary-fiction"; "literature"; "mystery"; "novels"; "realistic-fiction";
            "romance"; "survival"; "war"; "world-war-ii"; "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 19549841;
        Genres =
        [|"adventure"; "coming-of-age"; "dragons"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "historical"; "magic"; "medieval"; "music";
            "mystery"; "paranormal"; "romance"; "science-fiction"; "shapeshifters";
            "supernatural"; "teen"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 13539044;
        Genres =
        [|"adult"; "adult-fiction"; "american"; "contemporary"; "contemporary-romance";
            "drama"; "family"; "fiction"; "funny"; "humor"; "literary-fiction";
            "literature"; "love"; "mental-health"; "mental-illness"; "movies"; "novels";
            "psychology"; "realistic-fiction"; "relationships"; "romance"; "sports";
            "young-adult"|];
        OriginalPublicationYear = Some 2008;
        Language = Some "English (United States)";}
        {Id = 28921;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "british-literature"; "classics";
            "contemporary"; "drama"; "english-literature"; "fiction"; "historical";
            "historical-fiction"; "history"; "japan"; "japanese-literature";
            "literary-fiction"; "literature"; "modern"; "modern-classics"; "novels";
            "romance"; "school"; "war"; "world-war-ii"|];
        OriginalPublicationYear = Some 1989;
        Language = None;}
        {Id = 693208;
        Genres =
        [|"american"; "banned-books"; "biography"; "childrens"; "classics"; "comedy";
            "coming-of-age"; "contemporary"; "cultural"; "death"; "family"; "fiction";
            "funny"; "high-school"; "humor"; "literature"; "memoir"; "middle-grade";
            "native-americans"; "non-fiction"; "novels"; "race"; "read-for-school";
            "realistic-fiction"; "school"; "sports"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 12505;
        Genres =
        [|"19th-century"; "classic-literature"; "classics"; "drama"; "fiction";
            "historical"; "historical-fiction"; "literary-fiction"; "literature";
            "novels"; "philosophy"; "psychology"; "romance"; "russia";
            "russian-literature"; "social"|];
        OriginalPublicationYear = Some 1868;
        Language = None;}
        {Id = 6342491;
        Genres =
        [|"action"; "adventure"; "demons"; "epic"; "epic-fantasy"; "fantasy";
            "fiction"; "high-fantasy"; "magic"; "medieval"; "mystery"; "paranormal";
            "romance"; "supernatural"; "teen"; "witches"; "wizards"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2009;
        Language = Some "English (United States)";}
        {Id = 80660;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "contemporary";
            "crime"; "dark"; "drama"; "family"; "fiction"; "horror"; "literary-fiction";
            "literature"; "mental-health"; "mental-illness"; "modern"; "mystery";
            "mystery-thriller"; "novels"; "parenting"; "psychology"; "realistic-fiction";
            "relationships"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 2003;
        Language = None;}
        {Id = 2547;
        Genres =
        [|"20th-century"; "adult"; "classic-literature"; "classics";
            "eastern-philosophy"; "essays"; "faith"; "fiction"; "inspirational"; "islam";
            "lebanon"; "literature"; "love"; "modern-classics"; "mysticism";
            "non-fiction"; "novels"; "personal-development"; "philosophy"; "poetry";
            "psychology"; "religion"; "self-help"; "spirituality"; "theology"|];
        OriginalPublicationYear = Some 1923;
        Language = None;}
        {Id = 37470;
        Genres =
        [|"16th-century"; "21st-century"; "adult"; "adult-fiction"; "chick-lit";
            "classics"; "contemporary"; "drama"; "fiction"; "historical";
            "historical-fiction"; "historical-romance"; "history"; "literature";
            "movies"; "novels"; "romance"; "tudor"; "young-adult"|];
        OriginalPublicationYear = Some 2001;
        Language = Some "English (United States)";}
        {Id = 77013;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "american-classics";
            "americana"; "banned-books"; "classic-literature"; "classics"; "college";
            "death"; "drama"; "family"; "fiction"; "gothic"; "high-school"; "historical";
            "historical-fiction"; "literary-fiction"; "literature"; "modern-classics";
            "novels"; "read-for-school"; "school"; "southern"; "southern-gothic"|];
        OriginalPublicationYear = Some 1930;
        Language = Some "English (United States)";}
        {Id = 23766634;
        Genres =
        [|"fae"; "fairies"; "fairy-tales"; "fantasy"; "fiction"; "high-fantasy";
            "magic"; "new-adult"; "paranormal"; "retellings"; "romance"; "young-adult"|];
        OriginalPublicationYear = Some 2017;
        Language = None;}
        {Id = 7137327;
        Genres =
        [|"action"; "adventure"; "apocalyptic"; "dystopia"; "fantasy"; "fiction";
            "futuristic"; "horror"; "paranormal"; "post-apocalyptic"; "romance";
            "science-fiction"; "supernatural"; "survival"; "teen"; "urban-fantasy";
            "young-adult"; "zombies"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 4980;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "classic-literature";
            "classics"; "comedy"; "contemporary"; "fantasy"; "fiction"; "funny";
            "high-school"; "humor"; "literary-fiction"; "literature"; "modern";
            "modern-classics"; "novels"; "philosophy"; "science"; "science-fiction";
            "speculative-fiction"|];
        OriginalPublicationYear = Some 1973;
        Language = None;}
        {Id = 1622;
        Genres =
        [|"16th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "college"; "comedy"; "drama";
            "english-literature"; "fae"; "fairies"; "fantasy"; "fiction"; "funny";
            "high-school"; "historical"; "historical-fiction"; "humor"; "literature";
            "love"; "magic"; "mythology"; "novels"; "plays"; "poetry"; "read-for-school";
            "romance"; "school"; "theatre"|];
        OriginalPublicationYear = Some 1595;
        Language = None;}
        {Id = 24120519;
        Genres =
        [|"adventure"; "childrens"; "coming-of-age"; "contemporary"; "fantasy";
            "fiction"; "historical"; "historical-fiction"; "horror"; "magic"; "mystery";
            "paranormal"; "romance"; "science-fiction"; "supernatural"; "suspense";
            "teen"; "thriller"; "time-travel"; "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 15812814;
        Genres =
        [|"action"; "adventure"; "dystopia"; "fantasy"; "fiction"; "futuristic";
            "love"; "post-apocalyptic"; "romance"; "science-fiction"; "survival"; "teen";
            "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 16081272;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "drama"; "erotica"; "fiction"; "love"; "love-story";
            "music"; "new-adult"; "realistic-fiction"; "road-trip"; "romance"; "travel";
            "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = Some "English (United States)";}
        {Id = 18712886;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "coming-of-age"; "dystopia";
            "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy"; "historical";
            "historical-fiction"; "magic"; "new-adult"; "post-apocalyptic"; "romance";
            "science-fiction"; "teen"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 12954620;
        Genres =
        [|"action"; "adventure"; "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy";
            "historical"; "magic"; "medieval"; "paranormal"; "romance"; "teen"; "war";
            "witches"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 2715;
        Genres =
        [|"adult"; "anthropology"; "biography"; "business"; "cookbooks"; "cooking";
            "culinary"; "economics"; "food"; "food-and-drink"; "food-history";
            "food-writing"; "foodie"; "historical"; "history"; "microhistory";
            "natural-history"; "nature"; "non-fiction"; "politics"; "popular-science";
            "reference"; "school"; "science"; "sociology"; "travel"; "world-history"|];
        OriginalPublicationYear = Some 2002;
        Language = None;}
        {Id = 15776309;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "coming-of-age"; "contemporary";
            "crime"; "death"; "drama"; "family"; "fiction"; "high-school";
            "murder-mystery"; "mystery"; "mystery-thriller"; "new-york"; "novels";
            "psychological-thriller"; "realistic-fiction"; "suspense"; "thriller";
            "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 29908754;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "adventure"; "contemporary";
            "crime"; "dark"; "drama"; "fiction"; "horror"; "literary-fiction";
            "literature"; "modern"; "mystery"; "mystery-thriller"; "new-adult"; "noir";
            "novels"; "psychological-thriller"; "psychology"; "realistic-fiction";
            "sociology"; "speculative-fiction"; "supernatural"; "suspense"; "teen";
            "thriller"; "young-adult"; "zombies"|];
        OriginalPublicationYear = Some 2012;
        Language = Some "English (United Kingdom)";}
        {Id = 448873;
        Genres =
        [|"action"; "adventure"; "children-s"; "childrens"; "epic-fantasy"; "fantasy";
            "fiction"; "folklore"; "high-fantasy"; "historical"; "historical-fantasy";
            "historical-fiction"; "juvenile"; "magic"; "medieval"; "middle-grade";
            "mystery"; "mythology"; "novels"; "romance"; "speculative-fiction"; "teen";
            "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 1996;
        Language = None;}
        {Id = 15645;
        Genres =
        [|"14th-century"; "adult"; "adult-fiction"; "adventure"; "christian";
            "christianity"; "classic-literature"; "classics"; "college"; "epic";
            "epic-poetry"; "european-literature"; "fantasy"; "fiction"; "high-school";
            "historical"; "historical-fiction"; "history"; "horror";
            "italian-literature"; "italy"; "literary-fiction"; "literature"; "medieval";
            "mythology"; "novels"; "philosophy"; "poetry"; "read-for-school"; "religion";
            "school"; "spirituality"; "theology"|];
        OriginalPublicationYear = Some 1320;
        Language = None;}
        {Id = 43015;
        Genres =
        [|"adult"; "africa"; "african-literature"; "autobiography"; "biography";
            "biography-memoir"; "civil-war"; "coming-of-age"; "contemporary"; "cultural";
            "fiction"; "high-school"; "historical"; "historical-fiction"; "history";
            "inspirational"; "international"; "memoir"; "military"; "non-fiction";
            "novels"; "politics"; "read-for-school"; "school"; "social-justice";
            "survival"; "true-story"; "war"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = Some "English (United States)";}
        {Id = 23919;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "american"; "anthologies";
            "classic-literature"; "classics"; "collections"; "crime"; "dark"; "fantasy";
            "fiction"; "gothic"; "gothic-horror"; "halloween"; "historical-fiction";
            "horror"; "literary-fiction"; "literature"; "mystery"; "mystery-thriller";
            "novels"; "paranormal"; "poetry"; "school"; "science-fiction";
            "short-stories"; "supernatural"; "suspense"; "thriller"; "victorian"|];
        OriginalPublicationYear = Some 1849;
        Language = Some "English (United States)";}
        {Id = 46164;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "american-classics";
            "americana"; "classic-literature"; "classics"; "contemporary"; "fiction";
            "france"; "historical"; "historical-fiction"; "literary-fiction";
            "literature"; "mental-illness"; "modern"; "modern-classics"; "novels";
            "psychology"; "romance"; "school"|];
        OriginalPublicationYear = Some 1934;
        Language = Some "English (United States)";}
        {Id = 6909544;
        Genres =
        [|"action"; "adventure"; "apocalyptic"; "dystopia"; "family"; "fantasy";
            "fiction"; "futuristic"; "love"; "mystery"; "paranormal"; "post-apocalyptic";
            "romance"; "science-fiction"; "survival"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = Some "English (United States)";}
        {Id = 15196;
        Genres =
        [|"20th-century"; "adult"; "american"; "animals"; "art"; "autobiography";
            "biography"; "biography-memoir"; "classics"; "college"; "comics";
            "comics-manga"; "comix"; "family"; "fiction"; "germany"; "graphic-novels";
            "graphic-novels-comics"; "graphic-novels-manga"; "high-school"; "historical";
            "historical-fiction"; "history"; "holocaust"; "horror"; "jewish"; "judaism";
            "literature"; "manga"; "memoir"; "non-fiction"; "poland"; "politics";
            "read-for-school"; "religion"; "school"; "sequential-art"; "survival";
            "teen"; "war"; "world-war-ii"; "young-adult"|];
        OriginalPublicationYear = Some 1985;
        Language = None;}
        {Id = 7402393;
        Genres =
        [|"action"; "adventure"; "fantasy"; "fiction"; "love"; "magic"; "mystery";
            "paranormal"; "paranormal-romance"; "romance"; "shapeshifters";
            "supernatural"; "teen"; "urban-fantasy"; "werewolves"; "witches"; "wolves";
            "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 30118;
        Genres =
        [|"20th-century"; "american"; "banned-books"; "children-s"; "childrens";
            "classics"; "comedy"; "fantasy"; "fiction"; "funny"; "humor"; "juvenile";
            "literature"; "middle-grade"; "non-fiction"; "picture-books"; "poetry";
            "school"; "young-adult"; "young-readers"|];
        OriginalPublicationYear = Some 1981;
        Language = None;}
        {Id = 2612;
        Genres =
        [|"adult"; "business"; "communication"; "contemporary"; "economics";
            "education"; "entrepreneurship"; "essays"; "fiction"; "history";
            "inspirational"; "journalism"; "leadership"; "management"; "non-fiction";
            "personal-development"; "philosophy"; "politics"; "popular-science";
            "psychology"; "school"; "science"; "self-help"; "social"; "social-science";
            "society"; "sociology"|];
        OriginalPublicationYear = Some 2000;
        Language = None;}
        {Id = 28186;
        Genres =
        [|"action"; "adventure"; "children-s"; "childrens"; "contemporary"; "fantasy";
            "fiction"; "funny"; "gods"; "greek-mythology"; "humor"; "juvenile"; "magic";
            "middle-grade"; "mythology"; "novels"; "paranormal"; "romance";
            "supernatural"; "teen"; "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = Some "English (United States)";}
        {Id = 20983362;
        Genres =
        [|"adventure"; "fantasy"; "fiction"; "historical"; "historical-fiction";
            "mystery"; "paranormal"; "pirates"; "romance"; "science-fiction"; "teen";
            "time-travel"; "young-adult"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 3008;
        Genres =
        [|"19th-century"; "20th-century"; "boarding-school"; "british-literature";
            "chapter-books"; "children-s"; "childrens"; "childrens-classics";
            "classic-literature"; "classics"; "coming-of-age"; "drama"; "fantasy";
            "fiction"; "historical"; "historical-fiction"; "juvenile"; "literature";
            "middle-grade"; "novels"; "realistic-fiction"; "school"; "victorian";
            "young-adult"|];
        OriginalPublicationYear = Some 1902;
        Language = None;}
        {Id = 23772;
        Genres =
        [|"20th-century"; "children-s"; "childrens"; "classics"; "comedy"; "fantasy";
            "fiction"; "food"; "funny"; "humor"; "juvenile"; "literature";
            "picture-books"; "poetry"; "school"; "young-adult"|];
        OriginalPublicationYear = Some 1960;
        Language = Some "English (United States)";}
        {Id = 69571;
        Genres =
        [|"adult"; "biography"; "business"; "economics"; "education";
            "entrepreneurship"; "fiction"; "finance"; "how-to"; "inspirational";
            "leadership"; "management"; "money"; "money-management"; "non-fiction";
            "parenting"; "personal-development"; "personal-finance"; "philosophy";
            "productivity"; "psychology"; "reference"; "self-help"|];
        OriginalPublicationYear = Some 1998;
        Language = None;}
        {Id = 10127019;
        Genres =
        [|"business"; "design"; "economics"; "entrepreneurship"; "how-to";
            "leadership"; "management"; "non-fiction"; "personal-development";
            "productivity"; "programming"; "reference"; "self-help"; "software";
            "technology"|];
        OriginalPublicationYear = Some 2011;
        Language = Some "English (United States)";}
        {Id = 17927395;
        Genres =
        [|"action"; "adult"; "adventure"; "epic-fantasy"; "fae"; "fairies";
            "fairy-tales"; "fantasy"; "fantasy-romance"; "fiction"; "high-fantasy";
            "love"; "magic"; "new-adult"; "paranormal"; "paranormal-romance";
            "retellings"; "romance"; "supernatural"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 18143905;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "autobiography";
            "biography"; "biography-memoir"; "coming-of-age"; "contemporary"; "essays";
            "fiction"; "literature"; "memoir"; "non-fiction"; "short-stories";
            "short-story-collection"; "young-adult"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 4948;
        Genres =
        [|"animals"; "children-s"; "childrens"; "classics"; "fantasy"; "fiction";
            "food"; "juvenile"; "nature"; "picture-books"; "school"; "science";
            "storytime"|];
        OriginalPublicationYear = Some 1969;
        Language = None;}
        {Id = 7094569;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "apocalyptic"; "dystopia";
            "fantasy"; "fiction"; "futuristic"; "horror"; "mystery"; "novels";
            "paranormal"; "politics"; "post-apocalyptic"; "science"; "science-fiction";
            "speculative-fiction"; "supernatural"; "survival"; "suspense"; "thriller";
            "urban-fantasy"; "young-adult"; "zombies"|];
        OriginalPublicationYear = Some 2010;
        Language = Some "English (United States)";}
        {Id = 944073;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "dark"; "dark-fantasy";
            "epic"; "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy"; "low-fantasy";
            "magic"; "novels"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "sword-and-sorcery"; "war"|];
        OriginalPublicationYear = Some 2006;
        Language = None;}
        {Id = 11447921;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "chick-lit";
            "contemporary"; "drama"; "family"; "fiction"; "historical";
            "historical-fiction"; "humor"; "italy"; "literary-fiction"; "literature";
            "novels"; "realistic-fiction"; "relationships"; "romance"; "travel"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 213753;
        Genres =
        [|"adventure"; "apocalyptic"; "coming-of-age"; "contemporary"; "diary";
            "dystopia"; "family"; "fantasy"; "fiction"; "futuristic"; "high-school";
            "novels"; "post-apocalyptic"; "realistic-fiction"; "school"; "science";
            "science-fiction"; "speculative-fiction"; "survival"; "suspense"; "teen";
            "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = None;}
        {Id = 13145;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "american"; "contemporary"; "crime";
            "detective"; "fiction"; "horror"; "movies"; "murder-mystery"; "mystery";
            "mystery-thriller"; "novels"; "police"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 1993;
        Language = None;}
        {Id = 18336965;
        Genres =
        [|"coming-of-age"; "contemporary"; "dark"; "death"; "drama"; "family";
            "fiction"; "high-school"; "love"; "mental-health"; "mental-illness";
            "novels"; "psychology"; "realistic-fiction"; "romance"; "teen";
            "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 17314430;
        Genres =
        [|"abuse"; "adult"; "chick-lit"; "college"; "contemporary";
            "contemporary-romance"; "drama"; "erotica"; "fiction"; "funny"; "love";
            "new-adult"; "realistic-fiction"; "romance"; "romantic"; "young-adult";
            "young-adult-romance"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 5971165;
        Genres =
        [|"15th-century"; "adult"; "adult-fiction"; "chick-lit"; "drama"; "fantasy";
            "fiction"; "historical"; "historical-fiction"; "historical-romance";
            "history"; "magic"; "medieval"; "novels"; "plantagenet"; "romance"; "tudor";
            "war"|];
        OriginalPublicationYear = Some 2009;
        Language = None;}
        {Id = 188572;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "classic-literature"; "classics"; "collections"; "crime"; "detective";
            "english-literature"; "fiction"; "historical"; "historical-fiction";
            "literature"; "mystery"; "mystery-thriller"; "novels"; "short-stories";
            "suspense"; "thriller"; "victorian"|];
        OriginalPublicationYear = Some 1894;
        Language = None;}
        {Id = 12476820;
        Genres =
        [|"action"; "adventure"; "apocalyptic"; "dystopia"; "fantasy"; "fiction";
            "futuristic"; "mystery"; "paranormal"; "post-apocalyptic"; "romance";
            "science-fiction"; "survival"; "teen"; "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = Some "English (United States)";}
        {Id = 13137;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "classics"; "contemporary"; "crime";
            "detective"; "fiction"; "murder-mystery"; "mystery"; "mystery-thriller";
            "novels"; "romance"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 2001;
        Language = Some "English (United States)";}
        {Id = 16158542;
        Genres =
        [|"adult"; "adventure"; "american"; "american-history"; "biography";
            "biography-memoir"; "fiction"; "germany"; "historical"; "historical-fiction";
            "history"; "inspirational"; "memoir"; "non-fiction"; "sports"; "war";
            "world-war-ii"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 216363;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "alternate-history"; "american";
            "classics"; "dystopia"; "fantasy"; "fiction"; "historical";
            "historical-fiction"; "history"; "literature"; "modern-classics"; "novels";
            "politics"; "science"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "war"; "world-war-ii"|];
        OriginalPublicationYear = Some 1962;
        Language = None;}
        {Id = 15811545;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "asia";
            "asian-literature"; "buddhism"; "canada"; "coming-of-age"; "contemporary";
            "cultural"; "death"; "family"; "fantasy"; "fiction"; "historical";
            "historical-fiction"; "history"; "japan"; "japanese-literature";
            "literary-fiction"; "literature"; "magical-realism"; "mystery"; "novels";
            "philosophy"; "realistic-fiction"; "religion"; "war"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 13503109;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "contemporary";
            "drama"; "fiction"; "latin-american"; "literary-fiction"; "literature";
            "love"; "novels"; "realistic-fiction"; "relationships"; "romance";
            "short-stories"; "short-story-collection"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 12111823;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "dark-fantasy"; "dragons"; "epic";
            "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy"; "historical-fiction";
            "magic"; "novels"; "science-fiction"|];
        OriginalPublicationYear = None;
        Language = None;}
        {Id = 28260587;
        Genres =
        [|"action"; "adult"; "adventure"; "demons"; "dragons"; "epic-fantasy"; "fae";
            "fairies"; "fantasy"; "fiction"; "high-fantasy"; "magic"; "new-adult";
            "paranormal"; "romance"; "shapeshifters"; "supernatural"; "teen"; "war";
            "witches"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 7733;
        Genres =
        [|"18th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "children-s"; "childrens"; "classic-literature"; "classics"; "college";
            "english-literature"; "fantasy"; "fiction"; "high-school"; "historical";
            "historical-fiction"; "humor"; "ireland"; "irish-literature";
            "literary-fiction"; "literature"; "novels"; "philosophy"; "politics";
            "read-for-school"; "school"; "science-fiction"; "travel"; "young-adult"|];
        OriginalPublicationYear = Some 1726;
        Language = None;}
        {Id = 9462812;
        Genres =
        [|"angels"; "contemporary"; "death"; "fantasy"; "fiction"; "france"; "ghosts";
            "horror"; "love"; "magic"; "paranormal"; "paranormal-romance"; "romance";
            "supernatural"; "teen"; "urban-fantasy"; "young-adult"; "zombies"|];
        OriginalPublicationYear = Some 2011;
        Language = Some "English (United States)";}
        {Id = 4138;
        Genres =
        [|"20th-century"; "adult"; "american"; "autobiography"; "biography";
            "biography-memoir"; "comedy"; "coming-of-age"; "contemporary"; "essays";
            "family"; "fiction"; "funny"; "gay"; "glbt"; "humor"; "literature"; "memoir";
            "non-fiction"; "novels"; "queer"; "short-stories"|];
        OriginalPublicationYear = Some 1997;
        Language = Some "English (United States)";}
        {Id = 78129;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "contemporary"; "crime";
            "detective"; "fiction"; "government"; "hard-boiled"; "military";
            "murder-mystery"; "mystery"; "mystery-thriller"; "novels"; "suspense";
            "thriller"|];
        OriginalPublicationYear = Some 1997;
        Language = None;}
        {Id = 7331435;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "contemporary";
            "drama"; "fiction"; "literary-fiction"; "literature"; "music"; "new-york";
            "novels"; "realistic-fiction"; "relationships"; "short-stories"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 27712;
        Genres =
        [|"20th-century"; "adventure"; "books-about-books"; "children-s"; "childrens";
            "classics"; "coming-of-age"; "dragons"; "epic-fantasy"; "fairy-tales";
            "fantasy"; "fiction"; "german-literature"; "germany"; "high-fantasy";
            "juvenile"; "literature"; "magic"; "middle-grade"; "movies"; "novels";
            "teen"; "young-adult"|];
        OriginalPublicationYear = Some 1979;
        Language = None;}
        {Id = 1274;
        Genres =
        [|"adult"; "american"; "chick-lit"; "classics"; "communication";
            "contemporary"; "family"; "fiction"; "gender"; "health"; "inspirational";
            "love"; "marriage"; "non-fiction"; "novels"; "personal-development";
            "philosophy"; "psychology"; "reference"; "relationships"; "romance";
            "self-help"; "social"; "sociology"|];
        OriginalPublicationYear = Some 1992;
        Language = Some "English (United States)";}
        {Id = 22232;
        Genres =
        [|"chapter-books"; "chick-lit"; "children-s"; "childrens"; "classics";
            "coming-of-age"; "contemporary"; "fiction"; "high-school"; "juvenile";
            "love"; "middle-grade"; "novels"; "read-for-school"; "realistic-fiction";
            "romance"; "school"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2000;
        Language = None;}
        {Id = 49041;
        Genres =
        [|"chick-lit"; "contemporary"; "drama"; "fantasy"; "fiction"; "high-school";
            "horror"; "love"; "movies"; "novels"; "paranormal"; "paranormal-romance";
            "romance"; "science-fiction"; "shapeshifters"; "supernatural"; "teen";
            "urban-fantasy"; "vampires"; "werewolves"; "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = None;}
        {Id = 6381205;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "alternate-history"; "chick-lit";
            "comedy"; "fantasy"; "fiction"; "funny"; "ghosts"; "historical";
            "historical-fantasy"; "historical-fiction"; "historical-romance"; "horror";
            "humor"; "magic"; "mystery"; "paranormal"; "paranormal-romance"; "romance";
            "science-fiction"; "shapeshifters"; "speculative-fiction"; "steampunk";
            "supernatural"; "urban-fantasy"; "vampires"; "victorian"; "werewolves";
            "young-adult"|];
        OriginalPublicationYear = Some 2009;
        Language = None;}
        {Id = 32234;
        Genres =
        [|"20th-century"; "abuse"; "adult"; "adult-fiction"; "american"; "chick-lit";
            "classics"; "coming-of-age"; "contemporary"; "crime"; "dark"; "drama";
            "family"; "fiction"; "literary-fiction"; "literature"; "mental-health";
            "mental-illness"; "movies"; "novels"; "realistic-fiction"; "relationships";
            "womens-fiction"; "young-adult"|];
        OriginalPublicationYear = Some 1999;
        Language = None;}
        {Id = 9293020;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "adventure"; "contemporary";
            "crime"; "dark"; "drama"; "fiction"; "horror"; "literary-fiction";
            "literature"; "modern"; "mystery"; "mystery-thriller"; "new-adult"; "noir";
            "novels"; "psychology"; "realistic-fiction"; "sociology";
            "speculative-fiction"; "suspense"; "teen"; "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 23754;
        Genres =
        [|"20th-century"; "adult"; "art"; "classics"; "comic-book"; "comics";
            "comics-manga"; "comix"; "contemporary"; "dark"; "dark-fantasy"; "dc-comics";
            "fantasy"; "fiction"; "gothic"; "graphic-novels"; "graphic-novels-comics";
            "graphic-novels-manga"; "horror"; "magic"; "mythology"; "paranormal";
            "science-fiction"; "sequential-art"; "speculative-fiction"; "supernatural";
            "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 1989;
        Language = None;}
        {Id = 5544;
        Genres =
        [|"20th-century"; "american"; "autobiography"; "biography"; "biography-memoir";
            "classics"; "comedy"; "essays"; "fiction"; "funny"; "history"; "humor";
            "inspirational"; "mathematics"; "memoir"; "non-fiction"; "philosophy";
            "physics"; "popular-science"; "science"; "science-nature"; "short-stories";
            "technology"|];
        OriginalPublicationYear = Some 1984;
        Language = Some "English (United States)";}
        {Id = 30117284;
        Genres =
        [|"adventure"; "dystopia"; "fantasy"; "fiction"; "magic"; "romance";
            "science-fiction"; "space"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2017;
        Language = None;}
        {Id = 18966819;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "dystopia"; "epic";
            "fantasy"; "fiction"; "futuristic"; "military"; "mythology"; "novels";
            "politics"; "romance"; "science-fiction"; "science-fiction-fantasy"; "space";
            "space-opera"; "speculative-fiction"; "thriller"; "war"; "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 2548866;
        Genres =
        [|"adventure"; "children-s"; "childrens"; "fantasy"; "fiction"; "juvenile";
            "magic"; "middle-grade"; "mystery"; "novels"; "paranormal"; "school"; "teen";
            "urban-fantasy"; "witches"; "wizards"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 22917;
        Genres =
        [|"19th-century"; "adventure"; "anthologies"; "children-s"; "childrens";
            "classic-literature"; "classics"; "collections"; "fairy-tales"; "fantasy";
            "fiction"; "folklore"; "german-literature"; "germany"; "horror"; "juvenile";
            "literature"; "magic"; "mythology"; "novels"; "reference"; "romance";
            "short-stories"; "young-adult"|];
        OriginalPublicationYear = Some 1812;
        Language = Some "English (United States)";}
        {Id = 4631;
        Genres =
        [|"20th-century"; "adult"; "american"; "american-classics"; "autobiography";
            "biography"; "biography-memoir"; "classic-literature"; "classics"; "essays";
            "fiction"; "france"; "historical"; "historical-fiction"; "history";
            "literary-fiction"; "literature"; "memoir"; "modern-classics"; "non-fiction";
            "novels"; "short-stories"; "travel"; "writing"|];
        OriginalPublicationYear = Some 1964;
        Language = None;}
        {Id = 20613470;
        Genres =
        [|"action"; "adventure"; "demons"; "dragons"; "epic-fantasy"; "fae"; "fairies";
            "fantasy"; "fiction"; "high-fantasy"; "magic"; "mystery"; "paranormal";
            "romance"; "supernatural"; "teen"; "witches"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 18053060;
        Genres =
        [|"action"; "adventure"; "dystopia"; "fairy-tale-retellings"; "fairy-tales";
            "fantasy"; "fiction"; "horror"; "magic"; "mystery"; "paranormal";
            "retellings"; "romance"; "teen"; "witches"; "young-adult"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 27883214;
        Genres =
        [|"adventure"; "family"; "fantasy"; "fiction"; "high-fantasy"; "magic";
            "magical-realism"; "mystery"; "paranormal"; "romance"; "teen"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2017;
        Language = None;}
        {Id = 6261522;
        Genres =
        [|"contemporary"; "crime"; "death"; "fantasy"; "fiction"; "ghosts";
            "high-school"; "horror"; "magic"; "murder-mystery"; "mystery";
            "mystery-thriller"; "paranormal"; "paranormal-romance"; "romance";
            "supernatural"; "suspense"; "teen"; "thriller"; "urban-fantasy";
            "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = Some "English (United States)";}
        {Id = 14290364;
        Genres =
        [|"action"; "adventure"; "dystopia"; "fantasy"; "fiction"; "futuristic";
            "love"; "novels"; "post-apocalyptic"; "romance"; "science-fiction"; "teen";
            "thriller"; "war"; "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 337113;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "british-literature";
            "classic-literature"; "classics"; "drama"; "english-literature"; "feminism";
            "fiction"; "gothic"; "historical"; "historical-fiction";
            "historical-romance"; "literary-fiction"; "literature"; "mystery"; "novels";
            "romance"; "school"; "victorian"|];
        OriginalPublicationYear = Some 1848;
        Language = None;}
        {Id = 9917938;
        Genres =
        [|"action"; "adventure"; "apocalyptic"; "coming-of-age"; "dystopia"; "family";
            "fantasy"; "fiction"; "futuristic"; "post-apocalyptic"; "romance";
            "science-fiction"; "speculative-fiction"; "survival"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 23212667;
        Genres =
        [|"adult"; "adult-fiction"; "contemporary"; "crime"; "fiction"; "mystery";
            "mystery-thriller"; "novels"; "psychological-thriller"; "suspense";
            "thriller"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 1215032;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "coming-of-age"; "epic";
            "epic-fantasy"; "fantasy"; "fiction"; "high-fantasy"; "magic"; "novels";
            "romance"; "science-fiction"; "science-fiction-fantasy";
            "speculative-fiction"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 547094;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "anthologies";
            "apocalyptic"; "classics"; "dark"; "dystopia"; "fantasy"; "fiction";
            "horror"; "literature"; "movies"; "novels"; "occult"; "paranormal";
            "post-apocalyptic"; "science"; "science-fiction"; "science-fiction-fantasy";
            "short-stories"; "speculative-fiction"; "supernatural"; "survival";
            "suspense"; "thriller"; "urban-fantasy"; "vampires"; "zombies"|];
        OriginalPublicationYear = Some 1954;
        Language = None;}
        {Id = 10964693;
        Genres =
        [|"21st-century"; "academia"; "adult"; "adult-fiction"; "american";
            "books-about-books"; "chick-lit"; "college"; "coming-of-age"; "contemporary";
            "drama"; "fiction"; "historical-fiction"; "literary-fiction"; "literature";
            "love"; "marriage"; "mental-health"; "mental-illness"; "novels";
            "realistic-fiction"; "relationships"; "religion"; "romance"; "spirituality"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 6393631;
        Genres =
        [|"autobiography"; "biography"; "biography-memoir"; "children-s"; "childrens";
            "comics"; "coming-of-age"; "contemporary"; "family"; "fiction"; "funny";
            "graphic-novels"; "graphic-novels-comics"; "graphic-novels-manga";
            "high-school"; "humor"; "juvenile"; "manga"; "memoir"; "middle-grade";
            "non-fiction"; "realistic-fiction"; "school"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2009;
        Language = None;}
        {Id = 1081560;
        Genres =
        [|"academic"; "adventure"; "biography"; "books-about-books"; "classics";
            "criticism"; "fantasy"; "fiction"; "high-fantasy"; "history"; "literature";
            "magic"; "non-fiction"; "novels"; "reference"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 13;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "aliens";
            "british-literature"; "classics"; "comedy"; "contemporary"; "fantasy";
            "fiction"; "funny"; "humor"; "literature"; "novels"; "science";
            "science-fiction"; "science-fiction-fantasy"; "space"; "space-opera";
            "speculative-fiction"; "time-travel"; "young-adult"|];
        OriginalPublicationYear = Some 1996;
        Language = Some "English (United States)";}
        {Id = 112750;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "contemporary"; "dark";
            "fae"; "fairies"; "fantasy"; "fantasy-romance"; "fiction"; "horror";
            "ireland"; "magic"; "mystery"; "mythology"; "new-adult"; "paranormal";
            "paranormal-romance"; "paranormal-urban-fantasy"; "romance"; "supernatural";
            "suspense"; "urban"; "urban-fantasy"; "vampires"; "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = None;}
        {Id = 17199504;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "aliens";
            "alternate-history"; "dystopia"; "fantasy"; "fiction"; "futuristic";
            "ghosts"; "magic"; "mystery"; "new-adult"; "paranormal"; "romance";
            "science-fiction"; "science-fiction-fantasy"; "supernatural"; "thriller";
            "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 10104;
        Genres =
        [|"16th-century"; "20th-century"; "adult"; "biography"; "biography-memoir";
            "classics"; "european-history"; "fiction"; "historical";
            "historical-fiction"; "history"; "medieval"; "non-fiction"; "politics";
            "religion"; "tudor"; "world-history"|];
        OriginalPublicationYear = Some 1980;
        Language = Some "English (United States)";}
        {Id = 42156;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "drama"; "fiction"; "funny"; "humor"; "love";
            "movies"; "new-york"; "novels"; "realistic-fiction"; "relationships";
            "romance"; "romantic"; "womens-fiction"; "young-adult"|];
        OriginalPublicationYear = Some 2004;
        Language = None;}
        {Id = 4953;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "autobiography";
            "biography"; "biography-memoir"; "classics"; "coming-of-age"; "contemporary";
            "death"; "family"; "fiction"; "funny"; "humor"; "literary-fiction";
            "literature"; "memoir"; "non-fiction"; "novels"|];
        OriginalPublicationYear = Some 2000;
        Language = Some "English (United States)";}
        {Id = 9593913;
        Genres =
        [|"action"; "adventure"; "coming-of-age"; "dystopia"; "fantasy"; "fiction";
            "futuristic"; "love"; "post-apocalyptic"; "romance"; "science-fiction";
            "survival"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 20698530;
        Genres =
        [|"chick-lit"; "coming-of-age"; "contemporary"; "contemporary-romance";
            "drama"; "family"; "fiction"; "funny"; "high-school"; "love";
            "realistic-fiction"; "romance"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 12812550;
        Genres =
        [|"action"; "adventure"; "angels"; "contemporary"; "dark"; "demons";
            "dystopia"; "fantasy"; "fiction"; "high-fantasy"; "love"; "magic";
            "mythology"; "paranormal"; "paranormal-romance"; "romance"; "supernatural";
            "teen"; "urban-fantasy"; "war"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2012;
        Language = Some "English (Canada)";}
        {Id = 27161156;
        Genres =
        [|"21st-century"; "adult"; "american"; "american-history"; "americana";
            "anthropology"; "autobiography"; "biography"; "biography-memoir";
            "contemporary"; "economics"; "education"; "family"; "fiction"; "historical";
            "history"; "memoir"; "non-fiction"; "politics"; "poverty"; "psychology";
            "race"; "social-issues"; "social-justice"; "social-science"; "society";
            "sociology"; "southern"; "united-states"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 13588356;
        Genres =
        [|"adult"; "business"; "education"; "family"; "health"; "inspirational";
            "leadership"; "mental-health"; "non-fiction"; "parenting";
            "personal-development"; "philosophy"; "psychology"; "relationships";
            "science"; "self-help"; "sociology"; "spirituality"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 21104828;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "crime"; "drama"; "family"; "fiction"; "gothic"; "historical";
            "historical-fiction"; "historical-mystery"; "history"; "literary-fiction";
            "literature"; "mystery"; "mystery-thriller"; "novels"; "romance"; "suspense";
            "thriller"; "war"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 6327;
        Genres =
        [|"20th-century"; "adventure"; "banned-books"; "chapter-books"; "children-s";
            "childrens"; "classics"; "comedy"; "fantasy"; "fiction"; "funny"; "horror";
            "humor"; "juvenile"; "magic"; "middle-grade"; "novels"; "paranormal";
            "school"; "supernatural"; "witches"; "young-adult"; "young-readers"|];
        OriginalPublicationYear = Some 1983;
        Language = Some "English (United States)";}
        {Id = 6689;
        Genres =
        [|"20th-century"; "adventure"; "animals"; "banned-books"; "chapter-books";
            "children-s"; "childrens"; "childrens-classics"; "classics"; "fantasy";
            "fiction"; "funny"; "humor"; "juvenile"; "literature"; "magic";
            "middle-grade"; "movies"; "novels"; "school"; "young-adult"; "young-readers"|];
        OriginalPublicationYear = Some 1961;
        Language = None;}
        {Id = 872333;
        Genres =
        [|"angels"; "chick-lit"; "contemporary"; "fantasy"; "fiction"; "high-school";
            "horror"; "magic"; "mystery"; "paranormal"; "paranormal-romance"; "romance";
            "supernatural"; "teen"; "urban-fantasy"; "vampires"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2006;
        Language = Some "English (United States)";}
        {Id = 9375;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "chick-lit";
            "classics"; "coming-of-age"; "contemporary"; "drama"; "family"; "feminism";
            "fiction"; "food"; "funny"; "glbt"; "historical"; "historical-fiction";
            "history"; "humor"; "lesbian"; "literary-fiction"; "literature"; "movies";
            "mystery"; "novels"; "queer"; "realistic-fiction"; "romance"; "southern";
            "womens-fiction"|];
        OriginalPublicationYear = Some 1987;
        Language = None;}
        {Id = 29430012;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "contemporary";
            "cultural"; "drama"; "fiction"; "historical"; "historical-fiction";
            "history"; "literary-fiction"; "literature"; "novels"; "russia"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 11710373;
        Genres =
        [|"18th-century"; "adult"; "adult-fiction"; "adventure"; "american-history";
            "chick-lit"; "drama"; "epic"; "fantasy"; "fiction"; "historical";
            "historical-fantasy"; "historical-fiction"; "historical-romance"; "history";
            "novels"; "paranormal"; "romance"; "romantic"; "science-fiction"; "scotland";
            "time-travel"; "war"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 15925;
        Genres =
        [|"adult"; "adult-fiction"; "animals"; "chick-lit"; "contemporary";
            "contemporary-romance"; "death"; "drama"; "fiction"; "love"; "love-story";
            "mystery"; "novels"; "realistic-fiction"; "relationships"; "romance";
            "romantic"; "romantic-suspense"; "southern"; "suspense"; "thriller";
            "young-adult"|];
        OriginalPublicationYear = Some 2003;
        Language = Some "English (United States)";}
        {Id = 135836;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "british-literature"; "classics";
            "comedy"; "contemporary"; "crime"; "dark"; "drama"; "english-literature";
            "fiction"; "film"; "funny"; "humor"; "literary-fiction"; "literature";
            "modern"; "modern-classics"; "movies"; "mystery"; "novels"; "scotland";
            "thriller"|];
        OriginalPublicationYear = Some 1993;
        Language = None;}
        {Id = 89724;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "classics";
            "contemporary"; "crime"; "dark"; "death"; "drama"; "family"; "fantasy";
            "fiction"; "gothic"; "gothic-horror"; "halloween"; "horror";
            "literary-fiction"; "literature"; "mental-illness"; "modern-classics";
            "mystery"; "mystery-thriller"; "novella"; "novels"; "short-stories";
            "suspense"; "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 1962;
        Language = None;}
        {Id = 7488244;
        Genres =
        [|"angels"; "contemporary"; "demons"; "fantasy"; "fiction"; "high-school";
            "love"; "magic"; "mystery"; "mythology"; "paranormal"; "paranormal-romance";
            "romance"; "supernatural"; "teen"; "urban-fantasy"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2011;
        Language = Some "English (United States)";}
        {Id = 56495;
        Genres =
        [|"adult"; "business"; "christian"; "christian-non-fiction"; "christianity";
            "church"; "discipleship"; "faith"; "fiction"; "god"; "inspirational";
            "leadership"; "non-fiction"; "personal-development"; "philosophy";
            "psychology"; "reference"; "religion"; "self-help"; "spirituality";
            "theology"|];
        OriginalPublicationYear = Some 2002;
        Language = Some "English (United States)";}
        {Id = 9413044;
        Genres =
        [|"adventure"; "contemporary"; "demons"; "fantasy"; "fiction";
            "greek-mythology"; "magic"; "mystery"; "mythology"; "paranormal";
            "paranormal-romance"; "retellings"; "romance"; "supernatural"; "teen";
            "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = Some "English (United States)";}
        {Id = 6574102;
        Genres =
        [|"action"; "adventure"; "art"; "chick-lit"; "contemporary"; "crime";
            "espionage"; "family"; "fiction"; "funny"; "high-school"; "humor"; "mystery";
            "mystery-thriller"; "realistic-fiction"; "romance"; "suspense"; "teen";
            "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = Some "English (United States)";}
        {Id = 24378015;
        Genres =
        [|"chick-lit"; "contemporary"; "contemporary-romance"; "drama"; "fantasy";
            "fiction"; "high-school"; "love"; "mystery"; "mystery-thriller"; "new-adult";
            "novella"; "paranormal"; "paranormal-romance"; "romance"; "short-stories";
            "supernatural"; "suspense"; "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = Some "English (United States)";}
        {Id = 76778;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "adventure"; "aliens"; "american";
            "classic-literature"; "classics"; "dystopia"; "fantasy"; "fiction";
            "high-school"; "horror"; "literature"; "novels"; "post-apocalyptic";
            "school"; "science"; "science-fiction"; "science-fiction-fantasy";
            "short-stories"; "short-story-collection"; "space"; "speculative-fiction";
            "young-adult"|];
        OriginalPublicationYear = Some 1949;
        Language = Some "English (United States)";}
        {Id = 8709527;
        Genres =
        [|"adventure"; "boarding-school"; "contemporary"; "fantasy"; "fiction";
            "high-school"; "love"; "magic"; "mystery"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "teen"; "urban-fantasy";
            "vampires"; "witches"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = Some "English (United States)";}
        {Id = 3273;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "american-history";
            "coming-of-age"; "contemporary"; "cultural"; "drama"; "family"; "fiction";
            "historical"; "historical-fiction"; "history"; "literary-fiction";
            "literature"; "medical"; "novels"; "realistic-fiction"; "relationships";
            "romance"; "travel"; "young-adult"|];
        OriginalPublicationYear = Some 2003;
        Language = Some "English (United States)";}
        {Id = 2932;
        Genres =
        [|"18th-century"; "adult"; "adult-fiction"; "adventure"; "british-literature";
            "children-s"; "childrens"; "classic-literature"; "classics"; "college";
            "english-literature"; "fantasy"; "fiction"; "historical";
            "historical-fiction"; "history"; "literary-fiction"; "literature"; "novels";
            "read-for-school"; "school"; "survival"; "travel"; "young-adult"|];
        OriginalPublicationYear = Some 1719;
        Language = None;}
        {Id = 11250317;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "ancient-history"; "classics";
            "contemporary"; "fantasy"; "fiction"; "gay"; "glbt"; "greece";
            "greek-mythology"; "historical"; "historical-fantasy"; "historical-fiction";
            "historical-romance"; "history"; "literary-fiction"; "literature"; "love";
            "m-m-romance"; "mythology"; "novels"; "queer"; "queer-lit"; "retellings";
            "romance"; "war"; "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 2744;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "comedy"; "contemporary";
            "dark-fantasy"; "family"; "fantasy"; "fiction"; "folklore"; "funny"; "gods";
            "horror"; "humor"; "literature"; "magic"; "magical-realism"; "mythology";
            "novels"; "paranormal"; "religion"; "science-fiction";
            "science-fiction-fantasy"; "speculative-fiction"; "supernatural";
            "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2005;
        Language = Some "English (United States)";}
        {Id = 33590260;
        Genres =
        [|"fae"; "fantasy"; "fiction"; "high-fantasy"; "magic"; "new-adult";
            "paranormal"; "romance"; "young-adult"|];
        OriginalPublicationYear = Some 2018;
        Language = None;}
        {Id = 10505;
        Genres =
        [|"21st-century"; "academic"; "art"; "art-design"; "art-history"; "classics";
            "contemporary"; "criticism"; "design"; "essays"; "fiction"; "historical";
            "historical-fiction"; "history"; "italian-literature"; "italy";
            "literary-criticism"; "literature"; "microhistory"; "non-fiction";
            "philosophy"; "psychology"; "reference"; "sociology"; "theory"; "visual-art"|];
        OriginalPublicationYear = Some 2004;
        Language = None;}
        {Id = 19063;
        Genres =
        [|"adult"; "books-about-books"; "classics"; "coming-of-age"; "contemporary";
            "death"; "drama"; "family"; "fantasy"; "fiction"; "germany"; "historical";
            "historical-fiction"; "history"; "holocaust"; "literary-fiction";
            "literature"; "novels"; "realistic-fiction"; "school"; "teen"; "war";
            "world-war-ii"; "young-adult"|];
        OriginalPublicationYear = Some 2005;
        Language = Some "English (United States)";}
        {Id = 22450859;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "chick-lit";
            "coming-of-age"; "contemporary"; "family"; "feminism"; "fiction";
            "historical"; "historical-fiction"; "history"; "jewish"; "judaism";
            "literary-fiction"; "literature"; "memoir"; "novels"; "relationships";
            "romance"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 18404173;
        Genres =
        [|"20th-century"; "adult"; "biography"; "biography-memoir"; "cultural";
            "european-history"; "family"; "historical"; "historical-fiction"; "history";
            "memoir"; "non-fiction"; "romanovs"; "russia"; "russian-history"; "war"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 9579634;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "apocalyptic"; "dark";
            "dark-fantasy"; "dystopia"; "epic"; "epic-fantasy"; "fantasy"; "fiction";
            "high-fantasy"; "horror"; "low-fantasy"; "magic"; "novels";
            "post-apocalyptic"; "science-fiction"; "science-fiction-fantasy"; "war";
            "young-adult"|];
        OriginalPublicationYear = Some 2011;
        Language = None;}
        {Id = 102920;
        Genres =
        [|"20th-century"; "adult"; "american"; "art"; "art-design";
            "books-about-books"; "classics"; "college"; "comic-book"; "comics";
            "comics-manga"; "comix"; "criticism"; "design"; "drawing"; "education";
            "essays"; "fiction"; "game-design"; "graphic-novels";
            "graphic-novels-comics"; "graphic-novels-manga"; "history"; "how-to";
            "language"; "literary-criticism"; "literature"; "manga"; "non-fiction";
            "philosophy"; "pop-culture"; "psychology"; "read-for-school"; "reference";
            "research"; "school"; "sequential-art"; "teaching"; "textbooks"; "theory";
            "writing"; "young-adult"|];
        OriginalPublicationYear = Some 1993;
        Language = Some "English (United States)";}
        {Id = 5113;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "americana";
            "classic-literature"; "classics"; "college"; "coming-of-age"; "contemporary";
            "family"; "fiction"; "high-school"; "literary-fiction"; "literature";
            "modern-classics"; "new-york"; "novella"; "novels"; "philosophy";
            "realistic-fiction"; "religion"; "short-stories"; "young-adult"|];
        OriginalPublicationYear = Some 1957;
        Language = Some "English (United States)";}
        {Id = 12996;
        Genres =
        [|"17th-century"; "adult"; "british-literature"; "classic-literature";
            "classics"; "college"; "drama"; "english-literature"; "fiction";
            "high-school"; "historical"; "historical-fiction"; "italy"; "literature";
            "novels"; "plays"; "poetry"; "race"; "read-for-school"; "romance"; "school";
            "theatre"; "tragedy"|];
        OriginalPublicationYear = Some 1603;
        Language = Some "English (United States)";}
        {Id = 15745753;
        Genres =
        [|"abuse"; "chick-lit"; "coming-of-age"; "contemporary";
            "contemporary-romance"; "drama"; "family"; "fiction"; "high-school";
            "historical-fiction"; "love"; "love-story"; "music"; "novels";
            "realistic-fiction"; "relationships"; "romance"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 23341894;
        Genres =
        [|"chick-lit"; "coming-of-age"; "contemporary"; "contemporary-romance";
            "drama"; "fiction"; "high-school"; "love"; "mental-health"; "mental-illness";
            "poetry"; "psychology"; "realistic-fiction"; "romance"; "teen";
            "young-adult"|];
        OriginalPublicationYear = Some 2015;
        Language = None;}
        {Id = 23228;
        Genres =
        [|"american"; "coming-of-age"; "contemporary"; "fantasy"; "fiction"; "funny";
            "gay"; "glbt"; "high-school"; "humor"; "love"; "m-m-romance"; "novels";
            "queer"; "queer-lit"; "realistic-fiction"; "relationships"; "romance";
            "school"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2003;
        Language = None;}
        {Id = 33600;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "asia"; "australia"; "autobiography";
            "biography"; "biography-memoir"; "classics"; "contemporary"; "crime";
            "cultural"; "drama"; "fiction"; "historical-fiction"; "india";
            "literary-fiction"; "literature"; "memoir"; "modern"; "mystery";
            "non-fiction"; "novels"; "philosophy"; "romance"; "thriller"; "travel"|];
        OriginalPublicationYear = Some 2003;
        Language = None;}
        {Id = 17465453;
        Genres =
        [|"19th-century"; "adult"; "adult-fiction"; "adventure"; "american";
            "contemporary"; "evolution"; "family"; "fiction"; "historical";
            "historical-fiction"; "history"; "literary-fiction"; "literature"; "nature";
            "novels"; "romance"; "science"; "spirituality"; "travel"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 12220;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "american-classics";
            "class"; "classic-literature"; "classics"; "college"; "contemporary";
            "drama"; "fiction"; "high-school"; "historical"; "historical-fiction";
            "literary-fiction"; "literature"; "mental-illness"; "modern-classics";
            "novels"; "plays"; "read-for-school"; "realistic-fiction"; "romance";
            "school"; "southern"; "southern-gothic"; "theatre"; "tragedy"|];
        OriginalPublicationYear = Some 1947;
        Language = None;}
        {Id = 25526965;
        Genres =
        [|"adult"; "adult-fiction"; "contemporary"; "crime"; "detective"; "fantasy";
            "fiction"; "horror"; "mystery"; "mystery-thriller"; "novels"; "paranormal";
            "science-fiction"; "supernatural"; "suspense"; "thriller"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 26245850;
        Genres =
        [|"adult"; "adult-fiction"; "american"; "contemporary"; "crime"; "death";
            "drama"; "fiction"; "literary-fiction"; "mystery"; "mystery-thriller";
            "new-york"; "novels"; "realistic-fiction"; "survival"; "suspense";
            "thriller"|];
        OriginalPublicationYear = Some 2016;
        Language = None;}
        {Id = 242472;
        Genres =
        [|"academic"; "business"; "economics"; "entrepreneurship"; "fiction";
            "finance"; "history"; "leadership"; "management"; "mathematics";
            "non-fiction"; "personal-development"; "philosophy"; "politics";
            "popular-science"; "psychology"; "science"; "self-help"; "social-science";
            "society"; "sociology"; "theory"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 7791997;
        Genres =
        [|"action"; "angels"; "contemporary"; "fantasy"; "fiction"; "high-school";
            "love"; "mystery"; "paranormal"; "paranormal-romance"; "romance";
            "supernatural"; "teen"; "urban-fantasy"; "young-adult";
            "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2010;
        Language = Some "English (United States)";}
        {Id = 7740152;
        Genres =
        [|"angels"; "boarding-school"; "contemporary"; "demons"; "fantasy"; "fiction";
            "high-school"; "love"; "magic"; "mystery"; "paranormal";
            "paranormal-romance"; "romance"; "supernatural"; "teen"; "urban-fantasy";
            "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
        {Id = 40440;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "books-about-books";
            "british-literature"; "chick-lit"; "contemporary"; "drama"; "family";
            "fantasy"; "fiction"; "ghosts"; "gothic"; "historical"; "historical-fiction";
            "historical-mystery"; "horror"; "literary-fiction"; "literature"; "mystery";
            "mystery-thriller"; "novels"; "paranormal"; "romance"; "suspense";
            "thriller"; "young-adult"|];
        OriginalPublicationYear = Some 2006;
        Language = Some "English (United States)";}
        {Id = 603204;
        Genres =
        [|"adult"; "american"; "cookbooks"; "cooking"; "cuisine"; "culinary"; "food";
            "food-and-drink"; "food-writing"; "foodie"; "health"; "how-to";
            "non-fiction"; "reference"; "self-help"|];
        OriginalPublicationYear = Some 1998;
        Language = Some "English (United States)";}
        {Id = 8573642;
        Genres =
        [|"adventure"; "dragons"; "dystopia"; "fantasy"; "fiction"; "futuristic";
            "high-fantasy"; "magic"; "paranormal"; "paranormal-romance"; "romance";
            "science-fiction"; "supernatural"; "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = Some "English (United States)";}
        {Id = 4502877;
        Genres =
        [|"chick-lit"; "contemporary"; "fantasy"; "fantasy-romance"; "fiction";
            "high-school"; "love"; "love-story"; "novella"; "novels"; "paranormal";
            "paranormal-romance"; "romance"; "romantic"; "science-fiction";
            "short-stories"; "supernatural"; "teen"; "urban-fantasy"; "vampires";
            "werewolves"; "young-adult"; "young-adult-fantasy"|];
        OriginalPublicationYear = Some 2008;
        Language = None;}
        {Id = 13624688;
        Genres =
        [|"adult"; "adult-fiction"; "adventure"; "christian"; "christian-fiction";
            "classics"; "contemporary"; "death"; "drama"; "fantasy"; "fiction";
            "historical-fiction"; "inspirational"; "literature"; "love";
            "magical-realism"; "novels"; "philosophy"; "science-fiction"; "self-help";
            "spirituality"; "time-travel"; "young-adult"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 20578940;
        Genres =
        [|"action"; "adventure"; "boarding-school"; "children-s"; "childrens";
            "fantasy"; "fiction"; "juvenile"; "magic"; "middle-grade"; "mystery";
            "paranormal"; "school"; "supernatural"; "teen"; "urban-fantasy"; "witches";
            "wizards"; "young-adult"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 11590;
        Genres =
        [|"20th-century"; "adult"; "adult-fiction"; "american"; "classics";
            "contemporary"; "dark"; "fantasy"; "fiction"; "gothic"; "halloween";
            "horror"; "mystery"; "mystery-thriller"; "paranormal"; "science-fiction";
            "supernatural"; "suspense"; "thriller"; "urban-fantasy"; "vampires"|];
        OriginalPublicationYear = Some 1975;
        Language = Some "English (United Kingdom)";}
        {Id = 29800;
        Genres =
        [|"21st-century"; "action"; "adult"; "adventure"; "canada"; "comedy";
            "comic-book"; "comics"; "comics-manga"; "comix"; "contemporary"; "fantasy";
            "fiction"; "funny"; "graphic-novels"; "graphic-novels-comics";
            "graphic-novels-manga"; "humor"; "manga"; "music"; "romance";
            "science-fiction"; "sequential-art"; "teen"; "video-games"; "young-adult"|];
        OriginalPublicationYear = Some 2004;
        Language = None;}
        {Id = 13638125;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "contemporary"; "crime";
            "dark"; "fantasy"; "fiction"; "magic"; "mystery"; "new-adult"; "novels";
            "paranormal"; "science-fiction"; "superheroes"; "supernatural"; "thriller";
            "urban-fantasy"; "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 10766509;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "drama"; "family"; "fiction"; "love"; "love-story";
            "movies"; "novels"; "realistic-fiction"; "relationships"; "romance";
            "romantic"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = Some "English (United States)";}
        {Id = 5826;
        Genres =
        [|"adult"; "adult-fiction"; "american"; "classics"; "contemporary"; "drama";
            "fiction"; "historical-fiction"; "literary-fiction"; "literature"; "love";
            "magical-realism"; "music"; "mystery"; "novels"; "realistic-fiction";
            "relationships"; "romance"; "suspense"; "terrorism"|];
        OriginalPublicationYear = Some 2001;
        Language = None;}
        {Id = 13486122;
        Genres =
        [|"adult"; "adult-fiction"; "chick-lit"; "contemporary";
            "contemporary-romance"; "drama"; "erotic-romance"; "erotica"; "fiction";
            "funny"; "humor"; "love"; "marriage"; "new-adult"; "realistic-fiction";
            "romance"; "romantic"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 10176;
        Genres =
        [|"21st-century"; "adult"; "adult-fiction"; "american"; "autobiography";
            "biography"; "biography-memoir"; "collections"; "comedy"; "contemporary";
            "essays"; "family"; "fiction"; "funny"; "gay"; "glbt"; "humor"; "literature";
            "memoir"; "non-fiction"; "queer"; "short-stories"|];
        OriginalPublicationYear = Some 2004;
        Language = None;}
        {Id = 5659;
        Genres =
        [|"20th-century"; "adventure"; "animals"; "british-literature";
            "chapter-books"; "children-s"; "childrens"; "childrens-classics";
            "classic-literature"; "classics"; "english-literature"; "fantasy"; "fiction";
            "humor"; "juvenile"; "literature"; "middle-grade"; "novels"; "school";
            "young-adult"|];
        OriginalPublicationYear = Some 1908;
        Language = None;}
        {Id = 10847;
        Genres =
        [|"adult"; "american"; "american-history"; "biography"; "christianity";
            "crime"; "cults"; "faith"; "fiction"; "historical"; "history"; "journalism";
            "lds"; "memoir"; "mormonism"; "mystery"; "non-fiction"; "philosophy";
            "politics"; "psychology"; "religion"; "sociology"; "spirituality";
            "true-crime"|];
        OriginalPublicationYear = Some 2003;
        Language = None;}
        {Id = 9673436;
        Genres =
        [|"adventure"; "art"; "chapter-books"; "children-s"; "childrens"; "classics";
            "comics"; "family"; "fantasy"; "fiction"; "film"; "france"; "graphic-novels";
            "historical"; "historical-fiction"; "history"; "juvenile"; "middle-grade";
            "movies"; "mystery"; "novels"; "picture-books"; "realistic-fiction";
            "school"; "science-fiction"; "steampunk"; "young-adult"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 15704307;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "aliens"; "comic-book";
            "comics"; "comics-manga"; "comix"; "dystopia"; "family"; "fantasy";
            "fiction"; "funny"; "ghosts"; "graphic-novels"; "graphic-novels-comics";
            "graphic-novels-comics-manga"; "graphic-novels-manga"; "magic"; "manga";
            "romance"; "science-fiction"; "sequential-art"; "space"; "space-opera";
            "speculative-fiction"; "war"|];
        OriginalPublicationYear = Some 2012;
        Language = None;}
        {Id = 12291438;
        Genres =
        [|"adventure"; "dark"; "death"; "fantasy"; "fiction"; "gothic";
            "gothic-horror"; "historical"; "historical-fiction"; "history"; "horror";
            "mystery"; "mystery-thriller"; "paranormal"; "retellings"; "romance";
            "science-fiction"; "steampunk"; "supernatural"; "suspense"; "teen";
            "thriller"; "victorian"; "young-adult"|];
        OriginalPublicationYear = Some 2013;
        Language = None;}
        {Id = 91760;
        Genres =
        [|"20th-century"; "adult"; "art"; "art-and-photography"; "art-history";
            "autobiography"; "biography"; "biography-memoir"; "classics"; "contemporary";
            "diary"; "feminism"; "historical"; "history"; "memoir"; "non-fiction";
            "poetry"|];
        OriginalPublicationYear = Some 1995;
        Language = None;}
        {Id = 8475505;
        Genres =
        [|"action"; "adventure"; "chick-lit"; "contemporary"; "fantasy"; "fiction";
            "funny"; "high-school"; "humor"; "magic"; "mystery"; "mythology";
            "paranormal"; "paranormal-romance"; "romance"; "southern"; "supernatural";
            "teen"; "urban-fantasy"; "witches"; "young-adult"|];
        OriginalPublicationYear = Some 2014;
        Language = None;}
        {Id = 3873;
        Genres =
        [|"20th-century"; "academic"; "ancient-history"; "atheism"; "christian";
            "christianity"; "church-history"; "faith"; "god"; "historical"; "history";
            "islam"; "jewish"; "judaism"; "mythology"; "non-fiction"; "philosophy";
            "politics"; "reference"; "religion"; "science"; "sociology"; "spirituality";
            "theology"; "world-history"|];
        OriginalPublicationYear = Some 1975;
        Language = None;}
        {Id = 38619;
        Genres =
        [|"action"; "adult"; "adult-fiction"; "adventure"; "contemporary"; "dystopia";
            "fantasy"; "fiction"; "funny"; "horror"; "humor"; "magic"; "mystery";
            "mythology"; "paranormal"; "paranormal-romance"; "paranormal-urban-fantasy";
            "post-apocalyptic"; "romance"; "shapeshifters"; "supernatural"; "urban";
            "urban-fantasy"; "vampires"; "werewolves"; "witches"; "young-adult";
            "zombies"|];
        OriginalPublicationYear = Some 2007;
        Language = None;}
        {Id = 12749;
        Genres =
        [|"20th-century"; "classic-literature"; "classics"; "european-literature";
            "fiction"; "france"; "french-literature"; "historical-fiction";
            "literary-fiction"; "literature"; "memoir"; "modern-classics"; "novels";
            "philosophy"; "roman"; "romance"; "school"|];
        OriginalPublicationYear = Some 1913;
        Language = None;}
        {Id = 7735333;
        Genres =
        [|"adventure"; "chick-lit"; "coming-of-age"; "dystopia"; "fantasy"; "fiction";
            "futuristic"; "love"; "post-apocalyptic"; "romance"; "science-fiction";
            "teen"; "young-adult"|];
        OriginalPublicationYear = Some 2010;
        Language = None;}
    |] |> Array.map (fun d -> { d with Language = Some (randomLanguage())})