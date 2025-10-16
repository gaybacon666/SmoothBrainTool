using System;
using System.Net;
using System.Net.NetworkInformation;


//   _________________________________   ______________________
//  | Smooth      |                   | |            |         |
//  |  Brain      | Date:10/9 /2025   | | DAYS:5     |  =420=  |
//  |-------------|-------------------| |            |_________|
//  | VERSION     | Author            | | WEEKS:0    |_________| 
//  | 0.1.0       |                   | |            |         | 
//  | LANG: C#    | -m0use            | | MONTHS:0   |  =UWU=  | 
//  |_____________|___________________| |____________|_________| 
// ______________________________________________________________

Console.Clear();
Main.Home();

public class Main {
    public static int Home()
    {
        Console.SetWindowSize(110, 25);

        //Cwean Da Scween//
        Console.Clear();

        //Call banner
        Banners.HomeBanner();

        //Pwease choose one
        Banners.ChoiceBanner();

        Input.HomeInput();

        return 0;
    }
}

public class Input {
    public static int HomeInput()
    {
        string? _Maininput = Console.ReadLine();

        switch (_Maininput)
        {

            case "1":
                Calc.ShitCalc();
                break;  //Shitty calculator

            case "2":
                MemeSay.Meme();
                break;  //MemeSay // cowsay but not

            case "3":
                AnyoneHome.IpPing();
                break; //WIP

            case "4":
                ShitJack.Blackjack();
                break;  //Blackjack[WIP]

            case "q":
                Environment.Exit(0);
                break;  //quit

            //secrets
            case "69":
                Secrets.Uwu();
                break;  //secret1

            case "uwu":
                Secrets.Uwu();
                break;  //Secret2

            case "420":
                Secrets.Weed();
                break; //Secret3
        }
        return 0;

    }
}

public class Calc {
    public static int ShitCalc()
    {
        Errors.WIP();
        /*
        Console.WriteLine("test");
        Console.ReadLine();
        */

        
       //get equation
       //define number 1
       //define number 2
       //deffine opperand
       //return answer
       
       
       

       
   
       

        return 0;
    } //Shitcalc
}

public class AnyoneHome {
    public static int IpPing()
    {
        Errors.WIP();
        
        Console.Clear();
        Banners.HomeBanner();


        Console.WriteLine("                 ^_______________________________________^ ");
        Console.WriteLine("                 |                                       | ");
        Console.WriteLine("                 | 1:ping                  _  _          | "); //Ping
        Console.WriteLine("                 | 2:whois                / / /          | "); //nmap-type/whois look-up
        Console.WriteLine("                 |                       _L_|_L_         | ");
        Console.WriteLine("                 |                       ( U _ U)        | ");
        Console.WriteLine("                 |                                       | ");
        Console.WriteLine("                 | q: Home                               | "); // Return home
        Console.WriteLine("                 |_______________________________________| ");

        string? _pingtype = Console.ReadLine();

        switch (_pingtype)
        {

            case "1":
                Ping();
                break;

            case "2":
                Whois();
                break;

            case "q":
                Main.Home();
                break;
                
        }
        //Nmap type ping

        //WIP();

        return 0;
    } //anyoneHome

    public static int Whois() {
        Console.WriteLine("Fuck You");
        Thread.Sleep(2500);
        IpPing();
        return 0;
    } //whois lookup

    public static int Ping() {

        Console.Clear();
        Banners.HomeBanner();

        Console.WriteLine("                 ^_______________________________________^ ");
        Console.WriteLine("                 |  q: quit                              | ");
        Console.WriteLine("                 |                         _  _          | "); //Ping
        Console.WriteLine("                 |                        / / /          | "); //nmap-type/whois look-up
        Console.WriteLine("                 |                       _L_|_L_         | ");
        Console.WriteLine("                 |                       ( U _ U)        | ");
        Console.WriteLine("                 |                                       | ");
        Console.WriteLine("                 |  Ip to Ping:                            "); // Return home
        Console.WriteLine("                 |_______________________________________| ");

        string? _ip = Console.ReadLine();

        switch (_ip) {
            case "q":
                Main.Home();
                break;
        }

        Console.Clear();
        Banners.HomeBanner();

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

        IpPing();
        return 0;
    } //ping ip 
}

public class ShitJack {

    public static int Blackjack() {

        // card count
        int _player = 0;
        int _dealer = 0;
        int _playerTotal = _player + 0;
        int _dealerTotal = _dealer + 0;

        //display scores
        BlackJackBoard();
      
        //Dealer hand
        //first 20 cards
        //give player 2 cards
        //give dealer 2 cards

        //player choice
        string? Choice()
        {
            string? _pChoice = Console.ReadLine();

            switch (_pChoice)
            {

                case "h":
                    //hit
                    _RandCard();
                    break;

                case "s":
                    //stand
                    break;

                case "f":
                    Blackjack(); //forfiet
                    break;
            }

            return _pChoice;
        }

        //start//hit


        //stand

        int _RandCard()
        {

            Random _Card = new Random();
            int _CardInt = Convert.ToInt32(_Card.Next(1, 12));

            return _CardInt;
        } //Random Card

         int BlackJackBoard()
        {
            Console.Clear();
            Banners.HomeBanner();

            Console.WriteLine("                                   -----------------    ");
            Console.WriteLine("                                  |     Dealer      |  ");
            Console.WriteLine("                                          "+ _dealerTotal +"  ");
            Console.WriteLine("                                  |_________________|  ");
            Console.WriteLine("                                  |     Player      |  ");
            Console.WriteLine("                                          " + _playerTotal +"  ");
            Console.WriteLine("                                  |                 |    ");
            Console.WriteLine("                                   -----------------   ");

            Choice();

            return 0;
        } //Blackjack Board

        return 0;

    } //Blackjack
}

public class MemeSay {
    public static void Meme()
    {
        Console.Clear();
        Console.SetWindowSize(15, 5);
        Console.WriteLine("INPUT TEXT: ");

        string? _say = Console.ReadLine();


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

        Main.Home();
    }  //Wojak Cowsay
}

public class Secrets {
    public static void Weed()
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
        Main.Home();
    } //Secret of the weed

    public static void Uwu()
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
        Main.Home();
    } // SHHHH!!!! its a secret
}

public class Banners {
   
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

    public static void ChoiceBanner()
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

    public static void ShitcalcBanner()
    {
        Console.WriteLine("     ___ _    _ _    ____      _        ");
        Console.WriteLine("    | __| |_ (_) |_ / ___|__ _| |___    ");
        Console.WriteLine("    |__ | ' || |  _| (___/ _` | / _ |   ");
        Console.WriteLine("    |___|_||_|_|__||__ ||___,|_|___|    ");


    }
}

public class Utils {
    public static void Boofer()
    {

        //scuffed smooth brain buffer//
        Console.WriteLine(" ");
        Console.WriteLine("Press ENTER to continue...");

    } // smooth brain buffer
}

public class Errors {
    public static int WIP()
    {
        Console.Clear();
        
        Banners.HomeBanner();

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("                  _________________________________________");
        Console.WriteLine("                 | Hey Dumb Dumb, did you not see the [WIP]|     _  _  ");
        Console.WriteLine("                 | This isnt done yet fuck off.___________ /    / / /  ");
        Console.WriteLine("                                                         |/  X _L_|_L_  ");
        Console.WriteLine("                                                              ( x _ x)  ");

        Thread.Sleep(5000);
        Main.Home();

        return 0;
    } //WIP ERROR

}