using System;

internal class Program
{
    private static void Main(string[] args)
    {
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
            Console.WriteLine("                     Welcome To stupid smooth brain land");
            Console.WriteLine("                         U stupid idiot Brain fungus");

            //Pwease choose one
            Console.WriteLine("       ^________________________________________________________________^  ");
            Console.WriteLine("       |                                                                | ");
            Console.WriteLine("       | 1: ShitCalc   --shitty calculator                              | "); //Shitty Calculator
            Console.WriteLine("       | 2:WIP                                                          | ");
            Console.WriteLine("       | 3:WIP                                                          | ");
            Console.WriteLine("       | 4:WIP                                                          | ");
            Console.WriteLine("       |                                                                | ");
            Console.WriteLine("       | Q: quit       --only people with stupid baby  disease use this | "); // quit application
            Console.WriteLine("       |________________________________________________________________| ");

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

                    break;  //WIP

                case "3":

                    break; //WIP

                case "q":   
                    Environment.Exit(0);
                    break;  //quit

                case "69": 
                    uwu();
                    break;  //secret

                case "uwu":
                    uwu();
                    break;  //also secret
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

            decimal _div = Convert.ToDecimal(_numb1) / Convert.ToDecimal(_numb2);

            //Write numbers to console
            Console.WriteLine("");
            Console.WriteLine("number 1: " + _numb1);
            Console.WriteLine("number 2: " + _numb2);
            Console.WriteLine("");

            //give it some space damn
            Console.WriteLine("--Answers for da wetard--");
            Console.WriteLine("");

            //Stupid smooth brain math answers
            Console.WriteLine("Total: " + _total);
            Console.WriteLine("Difference: " + _difference);
            Console.WriteLine("Sum: " + _sum);
            Console.WriteLine("Quotient: " + _div);

            //Be patient//
            boofer();

            //return to home pg
            Home();

            return 0;
        }

        int boofer()
        {

            //scuffed smooth brain wait//
            Console.WriteLine(" ");
            Console.WriteLine("Press ENTER to continue...");
            Console.Read();

            return 0;
        } // smooth brain buffer

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
    }
}