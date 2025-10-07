using System;
using System.Net;
using System.Net.NetworkInformation;

Home();

int Home()
{
    Console.SetWindowSize(110, 25);

    //Cwean Da Scween//
    Console.Clear();

    //Call banner
    HomeBanner();

    //Welcome To Hell UwU//
    Console.WriteLine("");
    Console.WriteLine("                                 Welcome To stupid smooth brain land");
    Console.WriteLine("                                  you have stupid idiot Brain fungus");

    //Pwease choose one
    Console.WriteLine("                 ^________________________________________________________________^ ");
    Console.WriteLine("                 |                                                                | ");
    Console.WriteLine("                 | 1:ShitCalc                   --shitty calculator               | "); //Shitty Calculator
    Console.WriteLine("                 | 2:memeSay                    --just try it                     | ");//Meme Cowsay
    Console.WriteLine("                 | 3:IP Pinger[WIP]             --ping IP/whois lookup : -p : -W  | "); //IP ping/ Display Whois lookup // -p Ping: Ping ip // -W Whois lookup
    Console.WriteLine("                 | 4:           [WIP]                                             | ");
    Console.WriteLine("                 |                                                                | ");
    Console.WriteLine("                 | Q: quit       --only people with stupid baby disease use this  | "); // quit application
    Console.WriteLine("                 |________________________________________________________________| ");

    input1();

    return 0;
}

int input1()
{
    string _Maininput = Console.ReadLine();

    switch (_Maininput)
    {

        case "1":
            ShitCalc();
            break;  //Shitty calculator

        case "2":
            meme();
            break;  //WIP

        case "3":
            ipPing();
            break; //WIP

        case "4":
            WIP();
            break;  //Minesweeper[WIP]

        case "q":
            Environment.Exit(0);
            break;  //quit

        case "69":
            uwu();
            break;  //secret1

        case "uwu":
            uwu();
            break;  //Secret2

        case "420":
            weed();
            break; //Secret3
    }

    return 0;
}

int HomeBanner()
{

    Console.WriteLine("   _______  __   __  _______  _______  _______  __   __    _______  ______    _______  ___   __    _    ");  //Banner
    Console.WriteLine("  |       ||  |_|  ||       ||       ||       ||  | |  |  |  _    ||    _ |  |   _   ||   | |  |  | |   ");
    Console.WriteLine("  |  _____||       ||   _   ||   _   ||_     _||  |_|  |  | |_|   ||   | ||  |  |_|  ||   | |   |_| |   ");
    Console.WriteLine("  | |_____ |       ||  | |  ||  | |  |  |   |  |       |  |       ||   |_||_ |       ||   | |       |   ");
    Console.WriteLine("  |_____  ||       ||  |_|  ||  |_|  |  |   |  |       |  |  _   | |    __  ||       ||   | |  _    |   ");
    Console.WriteLine("  ______| || ||_|| ||       ||       |  |   |  |   _   |  | |_|   ||   |  | ||   _   ||   | | | |   |   ");
    Console.WriteLine(" |________||_|   |_||_______||_______|  |___|  |__| |__|  |_______||___|  |_||__| |__||___| |_|  |__|   ");
    Console.WriteLine("                                                                                 -m0us3                 ");

    return 0;
}

int shitcalcBanner()
{
    Console.WriteLine("     ___ _    _ _    ____      _        ");
    Console.WriteLine("    | __| |_ (_) |_ / ___|__ _| |___    ");
    Console.WriteLine("    |__ | ' || |  _| (___/ _` | / _ |   ");
    Console.WriteLine("    |___|_||_|_|__||__ ||___,|_|___|    ");

    return 0;
}

int ShitCalc()
{

    //sqwueky cwean
    Console.Clear();

    //set Window Size
    Console.SetWindowSize(50, 17);

    //Call Banner
    shitcalcBanner();


    Console.WriteLine("Gimme da Numbas");

    // get Numbers
    string _numb1 = Console.ReadLine(); // number Uno

    switch (_numb1)
    {
        case "q":
            Home();
            break;

    }

    string _numb2 = Console.ReadLine(); // number 2

    //cwean 
    Console.Clear();
    shitcalcBanner();

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
    Thread.Sleep(500);
    boofer();

    //return to home pg
    Home();

    return 0;
}

int boofer()
{

    //scuffed smooth brain buffer//
    Console.WriteLine(" ");
    Console.WriteLine("Press ENTER to continue...");
    Console.Read();

    return 0;
} // smooth brain buffer


int ipPing()
{

Banner:
    Console.Clear();
    HomeBanner();


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
            Home();
            break;

    }
    //Nmap type ping

    //WIP();

    return 0;
}
int whois() {
    Console.WriteLine("Fuck You");
    Thread.Sleep(2500);
    ipPing();
    return 0;
}
int  Ping() {
    Console.WriteLine("**Pinging**");
    Thread.Sleep(2500);
    ipPing();
    return 0;
}

int WIP()
{
    Console.Clear();
    HomeBanner();

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("                  _________________________________________");
    Console.WriteLine("                 | Hey Dumb Dumb, did you not see the [WIP]|     _  _  ");
    Console.WriteLine("                 | This isnt done yet fuck off.___________ /    / / /  ");
    Console.WriteLine("                                                         |/  X _L_|_L_  ");
    Console.WriteLine("                                                              ( x _ x)  ");

    Thread.Sleep(5000);
    Home();

    return 0;
}


int meme()
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

    Console.WriteLine("    ────▄▀▀░░░░░░░░░░░░░▀▄                                       ");
    Console.WriteLine("    ──▄▀░░░░░░░░░░░░░░░░░░▀▄                                     ");
    Console.WriteLine("  ──█░░░░░░░░░░░░░░░░░░░░░▀▄                                     ");
    Console.WriteLine("   ─▐▌░░░░░░░░▄▄▄▄▄▄▄░░░░░░░▐▌                                   ");
    Console.WriteLine("  ─█░░░░░░░░░░░▄▄▄▄░░▀▀▀▀▀░░█                                    ");
    Console.WriteLine("  ▐▌░░░░░░░▀▀▀▀░░░░░▀▀▀▀▀░░░▐▌          _____________________    ");
    Console.WriteLine("  █░░░░░░░░░▄▄▀▀▀▀▀░░░░▀▀▀▀▄░█         |                     |   ");
    Console.WriteLine("  █░░░░░░░░░░░░░░░░▀░░░▐░░░░░▐▌              " + _say);
    Console.WriteLine("  ▐▌░░░░░░░░░▐▀▀██▄░░░░░░▄▄▄░▐▌        |_____________________|   ");
    Console.WriteLine("  ─█░░░░░░░░░░░▀▀▀░░░░░░▀▀██░░█                                  ");
    Console.WriteLine("  ─▐▌░░░░▄░░░░░░░░░░░░░▌░░░░░░█                                  ");
    Console.WriteLine("  ──▐▌░░▐░░░░░░░░░░░░░░▀▄░░░░░█                                  ");
    Console.WriteLine("  ───█░░░▌░░░░░░░░▐▀░░░░▄▀░░░▐▌                                  ");
    Console.WriteLine(" ───▐▌░░▀▄░░░░░░░░▀░▀░▀▀░░░▄▀                                    ");
    Console.WriteLine("  ───▐▌░░▐▀▄░░░░░░░░░░░░░░░░█                                    ");
    Console.WriteLine(" ───▐▌░░░▌░▀▄░░░░▀▀▀▀▀▀░░░█                                      ");
    Console.WriteLine(" ───█░░░▀░░░░▀▄░░░░░░░░░░▄▀                                      ");
    Console.WriteLine("──▐▌░░░░░░░░░░▀▄░░░░░░▄▀                                         ");
    Console.WriteLine("  ─▄▀░░░▄▀░░░░░░░░▀▀▀▀█▀                                         ");
    Console.WriteLine("  ▀░░░▄▀░░░░░░░░░░▀░░░▀▀▀▀▄▄▄▄▄                                  ");

    //WIP();
    Thread.Sleep(5000);
    Home();

    return 0;
}



int weed()
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
    Home();

    return 0;
} //Secret of the weed

int uwu()
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
    Home();


    return 0;
} // SHHHH!!!! its a secret
