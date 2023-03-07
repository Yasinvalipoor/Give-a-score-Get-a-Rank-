
//  T5 

/* محمد یاسین ولی پور */

/* mohamad yasin valipor */

ConsoleKeyInfo click;
bool process = false;
string YN;


do
{
    Console.Write("\nHello My Frinds \nPlease enter your score , to check your status !!  ");


    double val = 0;
    string score = "";

    do
    {
        click = Console.ReadKey(true);
        if (click.Key != ConsoleKey.Backspace)
        {

            bool control = double.TryParse(click.KeyChar.ToString(), out val);

            if (control)
            {
                score += click.KeyChar;
                Console.Write(click.KeyChar);
            }
            else if (click.KeyChar == '.')
            {
                score = score + '.';
                Console.Write(score);

            }

        }

        else

        {

            if (click.Key == ConsoleKey.Backspace && score.Length > 0)
            {
                score = score.Substring(0, (score.Length - 1));
                Console.Write("\b \b");
            }

        }
    } while (click.Key != ConsoleKey.Enter);


    double score2 = double.Parse(score);



    if (score2 >= 0 && score2 <= 20)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n\n your score from 20 is " + score2);
        Console.WriteLine();
        Console.WriteLine(" your score from 100 is " + score2 * 5);
        Console.WriteLine();
        Console.ResetColor();


        do
        {

            switch (score2)
            {
                case <= 10:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" REJECTED , next term see you :)");
                    Console.ResetColor();
                    break;

                case > 10 and <= 15:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Your score is RANK C ");
                    Console.ResetColor();
                    break;

                case > 15 and <= 17:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Good , Your score is RANK B ");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" WELL-DONE , Your score is RANK A");
                    Console.ResetColor();

                    break;
            }
        } while (click.Key != ConsoleKey.Enter);

    }
    else
    {
        Console.WriteLine("\n\n your input number is invalid... !");
    }

    Console.WriteLine("\n Do you continue (y/n) ?? ");

    LOCK_Continue_YN();


} while (YN.ToLower() == "y");

Console.WriteLine();
Console.WriteLine("---------");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n Thanks For Using The Program \n The Program is over \n God-bye");
Console.ResetColor();



////////////////// Method //////////////////////


void LOCK_Continue_YN()
{
    do
    {
        YN = Console.ReadKey(true).KeyChar.ToString();

    } while (YN.ToLower() != "y" && YN.ToLower() != "n");
}

