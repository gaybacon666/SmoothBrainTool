using System;
using System.Net;
using System.Net.NetworkInformation;


//   _________________________________   ______________________
//  | Smooth      |                   | |            |         |
//  |  Brain      | Date:10/9 / 2025| | | DAYS:4     | YEARS:0 |
//  |-------------|-------------------| |            |_________|
//  | VERSION     | Author            | | WEEKS:0    |_________| 
//  | 0.1.0       |                   | |            |         | 
//  |  C#         | -m0use            | | MONTHS:0   |  =UWU=  | 
//  |_____________|___________________| |____________|_________| 
// ______________________________________________________________

_main.Home();

public class _main {
    public static int Home()
    {
        Console.SetWindowSize(110, 25);

        //Cwean Da Scween//
        Console.Clear();

        //Call banner
        _banners.HomeBanner();

        //Pwease choose one
        _banners.choiceBanner();

        _input.HomeInput();

        return 0;
    }
}

public class _input {
    public static int HomeInput()
    {
        string _Maininput = Console.ReadLine();

        switch (_Maininput)
        {

            case "1":
                _calc.ShitCalc();
                break;  //Shitty calculator

            case "2":
                _memeSay.meme();
                break;  //MemeSay // cowsay but not

            case "3":
                _anyoneHome.ipPing();
                break; //WIP

            case "4":
                _shitJack.blackjack();
                break;  //Blackjack[WIP]

            case "q":
                Environment.Exit(0);
                break;  //quit

            //secrets
            case "69":
                _secrets.uwu();
                break;  //secret1

            case "uwu":
                _secrets.uwu();
                break;  //Secret2

            case "420":
                _secrets.weed();
                break; //Secret3
        }
        return 0;

    }
}

public class _calc {
    public static int ShitCalc()
    {

        //sqwueky cwean
        Console.Clear();

        //set Window Size
        Console.SetWindowSize(50, 17);

        //Call Banner
        _banners.shitcalcBanner();


        Console.WriteLine("Gimme da Numbas");

        // get Numbers
        string _numb1 = Console.ReadLine();

        switch (_numb1)
        {
            case "q":
                _main.Home();
                break;

            case "weed":
                _secrets.weed();
                break;

            case "uwu":
                _secrets.uwu();
                break;

        }

        string _numb2 = Console.ReadLine(); // number 2

        //cwean da scwean
        Console.Clear();
        _banners.shitcalcBanner();

        //Add numbers
        decimal _total = Convert.ToDecimal(_numb1) + Convert.ToDecimal(_numb2); // stupid baby math

        //Subtract numbers
        decimal _difference = Convert.ToDecimal(_numb1) - Convert.ToDecimal(_numb2); // stupid baby math but backwards

        //Multiply numbers
        decimal _sum = Convert.ToDecimal(_numb1) * Convert.ToDecimal(_numb2);   // smooth brain idiot juice

        //Divide numbers
        decimal _div = Convert.ToDecimal(_numb1) / Convert.ToDecimal(_numb2); //smooth brain fungus math

        //Write numbers to console
        Console.WriteLine("");
        Console.WriteLine("number 1: " + _numb1);
        Console.WriteLine("number 2: " + _numb2);
        Console.WriteLine("----------------------------------");

        //give it some space damn
        Console.WriteLine("--AnSwErS FoR dA WeTaRdS--");
        Console.WriteLine("");

        //Stupid smooth brain math answers
        Console.WriteLine("Total: " + _total);
        Console.WriteLine("Difference: " + _difference);
        Console.WriteLine("Sum: " + _sum);
        Console.WriteLine("Quotient: " + _div);

        //Be patient//
        string _n = Console.ReadLine();

        switch (_n) {
            case "q":
                _main.Home();
                break;
        }

        _utils.boofer();
        //string _continue = Console.Read();

        //switch (_continue) {
        // case "q":
        //  Home();
        //    break;
        //}
        //
        //return to home pg
        _main.Home();

        return 0;
    } //Shitcalc
}

public class _anyoneHome {
    public static int ipPing()
    {
        _errors.WIP();
        
        Console.Clear();
        _banners.HomeBanner();


        Console.WriteLine("                 ^_______________________________________^ ");
        Console.WriteLine("                 |                                       | ");
        Console.WriteLine("                 | 1:ping                  _  _          | "); //Ping
        Console.WriteLine("                 | 2:whois                / / /          | "); //nmap-type/whois look-up
        Console.WriteLine("                 |                       _L_|_L_         | ");
        Console.WriteLine("                 |                       ( U _ U)        | ");
        Console.WriteLine("                 |                                       | ");
        Console.WriteLine("                 | q: Home                               | "); // Return home
        Console.WriteLine("                 |_______________________________________| ");

        string _pingtype = Console.ReadLine();

        switch (_pingtype)
        {

            case "1":
                Ping();
                break;

            case "2":
                whois();
                break;

            case "q":
                _main.Home();
                break;
                
        }
        //Nmap type ping

        //WIP();

        return 0;
    } //anyoneHome

    public static int whois() {
        Console.WriteLine("Fuck You");
        Thread.Sleep(2500);
        ipPing();
        return 0;
    } //whois lookup

    public static int Ping() {

        Console.Clear();
        _banners.HomeBanner();

        Console.WriteLine("                 ^_______________________________________^ ");
        Console.WriteLine("                 |  q: quit                              | ");
        Console.WriteLine("                 |                         _  _          | "); //Ping
        Console.WriteLine("                 |                        / / /          | "); //nmap-type/whois look-up
        Console.WriteLine("                 |                       _L_|_L_         | ");
        Console.WriteLine("                 |                       ( U _ U)        | ");
        Console.WriteLine("                 |                                       | ");
        Console.WriteLine("                 |  Ip to Ping:                            "); // Return home
        Console.WriteLine("                 |_______________________________________| ");

        string _ip = Console.ReadLine();

        switch (_ip) {
            case "q":
                _main.Home();
                break;
        }

        Console.Clear();
        _banners.HomeBanner();

        Console.WriteLine("                 ^_______________________________________^ ");
        Console.WriteLine("                 |  q: quit                              | ");
        Console.WriteLine("                 |                         _  _          | "); //Ping
        Console.WriteLine("                 |                        / / /          | "); //nmap-type/whois look-up
        Console.WriteLine("                 |                       _L_|_L_         | ");
        Console.WriteLine("                 |                       ( U _ U)        | ");
        Console.WriteLine("                 |                                       | ");
        Console.WriteLine("                 |  Ip to Ping: " + _ip + " **Pinging**    "); // Return home
        Console.WriteLine("                 |_______________________________________| ");


        Thread.Sleep(2500);

        ipPing();
        return 0;
    } //ping ip 
}

public class _shitJack {
    public static int blackjack() {
        _errors.WIP();

        //player
        int _hand = 0;

        //dealer
        int _dealerHand = 0;

        //cards
        int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        //turn // 0=dealer, 1=player

        //generate random card

        Console.WriteLine();

        //first 20 cards
        //give player 2 cards
        //give dealer 2 cards

        //player choice
        string _pChoice = Console.ReadLine();

        switch (_pChoice)
        {

            case "h":
                //hit
                break;

            case "s":
                //stand
                break;

            case "f":
                blackjack(); //forfiet
                break;
        }



        //stand
        //forfeit

        //display scores
        Console.WriteLine("Hand: " + _hand);
        Console.WriteLine("Dealer: " + _dealerHand);


        return 0;

    } //Blackjack
}

public class _memeSay {
    public static void meme()
    {
        Console.Clear();
        Console.SetWindowSize(15, 5);
        Console.WriteLine("INPUT TEXT: ");

        string _say = Console.ReadLine();


        switch (_say)
        {
            case "uwu":
                _say = "Faggot";
                break;

            case "69":
                _say = "Nice";
                break;

            case "icon":
                _say = "jewishmoocow";
                break;

        }



        Console.Clear();

        Console.SetWindowSize(80, 25);

        Console.WriteLine("  ────▄▀▀░░░░░░░░░░░░░▀▄                                       ");
        Console.WriteLine("  ──▄▀░░░░░░░░░░░░░░░░░░▀▄                                     ");
        Console.WriteLine("  ──█░░░░░░░░░░░░░░░░░░░░░▀▄                                     ");
        Console.WriteLine("  ─▐▌░░░░░░░░▄▄▄▄▄▄▄░░░░░░░▐▌                                   ");
        Console.WriteLine("  ─█░░░░░░░░░░░▄▄▄▄░░▀▀▀▀▀░░█                                    ");
        Console.WriteLine("  ▐▌░░░░░░░▀▀▀▀░░░░░▀▀▀▀▀░░░▐▌          _________________________________    ");
        Console.WriteLine("  █░░░░░░░░░▄▄▀▀▀▀▀░░░░▀▀▀▀▄░█         |                                 |   ");
        Console.WriteLine("  █░░░░░░░░░░░░░░░░▀░░░▐░░░░░▐▌              " + _say);
        Console.WriteLine("  ▐▌░░░░░░░░░▐▀▀██▄░░░░░░▄▄▄░▐▌        |_________________________________|   ");
        Console.WriteLine("  ─█░░░░░░░░░░░▀▀▀░░░░░░▀▀██░░█                                  ");
        Console.WriteLine("  ─▐▌░░░░▄░░░░░░░░░░░░░▌░░░░░░█                                  ");
        Console.WriteLine("  ──▐▌░░▐░░░░░░░░░░░░░░▀▄░░░░░█                                  ");
        Console.WriteLine("  ───█░░░▌░░░░░░░░▐▀░░░░▄▀░░░▐▌                                  ");
        Console.WriteLine("  ───▐▌░░▀▄░░░░░░░░▀░▀░▀▀░░░▄▀                                    ");
        Console.WriteLine("  ───▐▌░░▐▀▄░░░░░░░░░░░░░░░░█                                    ");
        Console.WriteLine("  ───▐▌░░░▌░▀▄░░░░▀▀▀▀▀▀░░░█                                      ");
        Console.WriteLine("  ───█░░░▀░░░░▀▄░░░░░░░░░░▄▀                                      ");
        Console.WriteLine("  ──▐▌░░░░░░░░░░▀▄░░░░░░▄▀                                         ");
        Console.WriteLine("  ─▄▀░░░▄▀░░░░░░░░▀▀▀▀█▀                                         ");
        Console.WriteLine("  ▀░░░▄▀░░░░░░░░░░▀░░░▀▀▀▀▄▄▄▄▄                                  ");

        Console.ReadLine();

        _main.Home();
    }  //Wojak Cowsay
}

public class _secrets {
    public static void weed()
    {
        Console.Clear();
        Console.SetWindowSize(35, 20);

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                 W              ");
        Console.WriteLine("                WWW             ");
        Console.WriteLine("                WWW             ");
        Console.WriteLine("               WWWWW            ");
        Console.WriteLine("          W    WWWWW     W      ");
        Console.WriteLine("          WWW  WWWWW   WWW      ");
        Console.WriteLine("           WWW WWWWW  WWW       ");
        Console.WriteLine("           WWW  WWW  WWW        ");
        Console.WriteLine("            WWW WWW WWW         ");
        Console.WriteLine("              WWWWWWW           ");
        Console.WriteLine("           WWWW  |  WWWW        ");
        Console.WriteLine("                 |              ");
        Console.WriteLine("                 |              ");

        Thread.Sleep(2500);
        _main.Home();
    } //Secret of the weed

    public static void uwu()
    {
        Console.Clear();

        Console.SetWindowSize(42, 15);

        Console.WriteLine("  ▄         ▄  ▄         ▄  ▄         ▄  ");
        Console.WriteLine(" ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌ ");
        Console.WriteLine(" ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌ ");
        Console.WriteLine(" ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌ ");
        Console.WriteLine(" ▐░▌       ▐░▌▐░▌   ▄   ▐░▌▐░▌       ▐░▌ ");
        Console.WriteLine(" ▐░▌       ▐░▌▐░▌  ▐░▌  ▐░▌▐░▌       ▐░▌ ");
        Console.WriteLine(" ▐░▌       ▐░▌▐░▌ ▐░▌░▌ ▐░▌▐░▌       ▐░▌ ");
        Console.WriteLine(" ▐░▌       ▐░▌▐░▌▐░▌ ▐░▌▐░▌▐░▌       ▐░▌ ");
        Console.WriteLine(" ▐░█▄▄▄▄▄▄▄█░▌▐░▌░▌   ▐░▐░▌▐░█▄▄▄▄▄▄▄█░▌ ");
        Console.WriteLine(" ▐░░░░░░░░░░░▌▐░░▌     ▐░░▌▐░░░░░░░░░░░▌ ");
        Console.WriteLine("  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀       ▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ");
        Console.WriteLine("                                         ");
        Thread.Sleep(1500);
        _main.Home();
    } // SHHHH!!!! its a secret
}

public class _banners {
   
    public static void HomeBanner()
    {

        Console.WriteLine("   _______  __   __  _______  _______  _______  __   __    _______  ______    _______  ___   __    _    ");  //Banner
        Console.WriteLine("  |       ||  |_|  ||       ||       ||       ||  | |  |  |  _    ||    _ |  |   _   ||   | |  |  | |   ");
        Console.WriteLine("  |  _____||       ||   _   ||   _   ||_     _||  |_|  |  | |_|   ||   | ||  |  |_|  ||   | |   |_| |   ");
        Console.WriteLine("  | |_____ |       ||  | |  ||  | |  |  |   |  |       |  |       ||   |_||_ |       ||   | |       |   ");
        Console.WriteLine("  |_____  ||       ||  |_|  ||  |_|  |  |   |  |       |  |  _   | |    __  ||       ||   | |  _    |   ");
        Console.WriteLine("  ______| || ||_|| ||       ||       |  |   |  |   _   |  | |_|   ||   |  | ||   _   ||   | | | |   |   ");
        Console.WriteLine(" |________||_|   |_||_______||_______|  |___|  |__| |__|  |_______||___|  |_||__| |__||___| |_|  |__|   ");
        Console.WriteLine("                                                                                 -m0us3                 ");
    }

    public static void choiceBanner()
    {
        Console.WriteLine("");
        Console.WriteLine("                                 Welcome To stupid smooth brain land");
        Console.WriteLine("                                  you have stupid idiot Brain fungus");

        Console.WriteLine("                 ^________________________________________________________________^ ");
        Console.WriteLine("                 |                                                                | ");
        Console.WriteLine("                 | 1:shitCalc                   --shitty calculator               | "); //Shitty Calculator
        Console.WriteLine("                 | 2:memeSay                    --just try it                     | "); //Meme Cowsay
        Console.WriteLine("                 | 3:anyoneHome[WIP]            --ping IP/whois lookup            | "); //Ip ping/check online [with whois lookup?] 
        Console.WriteLine("                 | 4:shitJack[WIP]              --shitty blackjack                | "); //Blackjack(21)
        Console.WriteLine("                 |                                                                | ");
        Console.WriteLine("                 | Q: quit       --only people with stupid baby disease use this  | "); // quit application
        Console.WriteLine("                 |________________________________________________________________| ");
    }

    public static void shitcalcBanner()
    {
        Console.WriteLine("     ___ _    _ _    ____      _        ");
        Console.WriteLine("    | __| |_ (_) |_ / ___|__ _| |___    ");
        Console.WriteLine("    |__ | ' || |  _| (___/ _` | / _ |   ");
        Console.WriteLine("    |___|_||_|_|__||__ ||___,|_|___|    ");


    }
}

public class _utils {
    public static void boofer()
    {

        //scuffed smooth brain buffer//
        Console.WriteLine(" ");
        Console.WriteLine("Press ENTER to continue...");

    } // smooth brain buffer
}

public class _errors {
    public static int WIP()
    {
        Console.Clear();
        
        _banners.HomeBanner();

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                  _________________________________________");
        Console.WriteLine("                 | Hey Dumb Dumb, did you not see the [WIP]|     _  _  ");
        Console.WriteLine("                 | This isnt done yet fuck off.___________ /    / / /  ");
        Console.WriteLine("                                                         |/  X _L_|_L_  ");
        Console.WriteLine("                                                              ( x _ x)  ");

        Thread.Sleep(5000);
        _main.Home();

        return 0;
    } //WIP ERROR

}