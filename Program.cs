
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;

string[] questions = new string [10] {
    "What is the capital of Azerbaijan ?",
    "What is the capital of Turkey ?",
    "What is the capital of Georgia ?",
    "What is national emblem of USA ?",
    "What is national emblem of Russia ?",
    "Origin of 'Ancient Country' - Medes ?",
    "How many stars are there on American flag ?",
    "Who was Julieta's boyfriend ?",
    "There is one of the oldest civilization in the world ?",
    "Azerbaijan's best friend ?",

};

string [][] variants = new string[10][]{
    new string[] {"Baku","Ankara","Moscow"},
    new string[] {"Irevan","Istanbul","Ankara"},
    new string[] {"Salkazani","Tbilisi","Borjomi"},
    new string[] {"Bear","Eagle","Frog"},
    new string[] {"Sheep","Chicken","Bear"},
    new string[] {"Kurdish Origin","Turkic Origin","Slavic Origin"},
    new string[] {"51","49","50"},
    new string[] {"Fazil","Cebrayil","Romeo"},
    new string[] {"Kurdish Civilization","Turkic Civilazition","Indian Civilazition"},
    new string[] {"Pakistan","Israel","Turkey"}
};

string[] correct_answers = new string[10]
{
    "Baku",
    "Ankara",
    "Tbilisi",
    "Eagle",
    "Bear",
    "Kurdish Origin",
    "51",
    "Romeo",
    "Kurdish Civilization",
    "Turkey",
};



string[] GetRandomVariants(string[] variants)
{
    while (true)
    {
        var variant1 = new Random().Next(0, 3);
        var variant2 = new Random().Next(0, 3);
        var variant3 = new Random().Next(0, 3);
        if (variant1 != variant2 && variant1 != variant3 && variant2 != variant3)
        {
            string[] random_variants = new string[]
            {
                variants[variant1],variants[variant2],variants[variant3],
            };
            return random_variants;
        }
        continue;
    }
}

int c = 0;
    int score = 0;
void ShowQuestions()
{
    score = 0;
    c = 0;
    for (int i = 0; i < questions.Length; i++)
    {
        Console.Clear();
        Console.WriteLine($"\t\t\t\t{i + 1}.{questions[i]}");
        Console.WriteLine();
        Console.WriteLine();
        string[] randomVariants = GetRandomVariants(variants[i]);
        Console.WriteLine($"\t\t    A){randomVariants[0]}\t\t    B){randomVariants[1]}\t\t    C){randomVariants[2]}");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write($"\t\t\t\tAnswer ( A or B or C )  : ");
       
        var result = Console.ReadKey();

        if(result.Key == ConsoleKey.A)
        {
            if (randomVariants[0] == correct_answers[i])
            {
                score += 10;
                c++;
                Console.Clear();
                Console.WriteLine($"\t\t\t\t{i + 1}.{questions[i]}");
                Console.WriteLine();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write($"\t\t    A){randomVariants[0]}\t\t");
                Console.ResetColor();
                Console.WriteLine($"B){randomVariants[1]}\t\t    C){randomVariants[2]}");
                Console.ReadKey();

            }

            else
            {
                if (score >= 10) score -= 10;
                Console.Clear();
                Console.WriteLine($"\t\t\t\t{i + 1}.{questions[i]}");
                Console.WriteLine();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write($"\t\t    A){randomVariants[0]}\t\t");
                Console.ResetColor();
                Console.WriteLine($"    B){randomVariants[1]}\t\t    C){randomVariants[2]}");
                Console.ReadKey();
            }
        }

        else if(result.Key == ConsoleKey.B)
        {
            if (randomVariants[1] == correct_answers[i])
            {
                c++;
                score += 10;
                Console.Clear();
                Console.WriteLine($"\t\t\t\t{i + 1}.{questions[i]}");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"\t\t    A){randomVariants[0]}\t\t");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write($"    B){randomVariants[1]}\t\t");
                Console.ResetColor();
                Console.WriteLine($"    C){randomVariants[2]}");
                Console.ReadKey();

            }

            else
            {
                if (score >= 10) score -= 10;
                Console.Clear();
                Console.WriteLine($"\t\t\t\t{i + 1}.{questions[i]}");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"\t\t    A){randomVariants[0]}\t\t");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write($"    B){randomVariants[1]}\t\t");
                Console.ResetColor();
                Console.WriteLine($"    C){randomVariants[2]}");
                Console.ReadKey();
            }
        }

        else if(result.Key == ConsoleKey.C)
        {
            if (randomVariants[2] == correct_answers[i])
            {
                c++;
                score += 10;
                Console.Clear();
                Console.WriteLine($"\t\t\t\t{i + 1}.{questions[i]}");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"\t\t    A){randomVariants[0]}\t\t");
                Console.Write($"    B){randomVariants[1]}\t\t");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"    C){randomVariants[2]}");
                Console.ResetColor();
                Console.ReadKey();
            }

            else
            {
                if (score >= 10) score -= 10;
                Console.Clear();
                Console.WriteLine($"\t\t\t\t{i + 1}.{questions[i]}");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"\t\t    A){randomVariants[0]}\t\t");
                Console.Write($"    B){randomVariants[1]}\t\t");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"    C){randomVariants[2]}");
                Console.ResetColor();
                Console.ReadKey();
            }
        }

        else
        {
            i--;
            continue;
        }
       

    }
}

void StartGame()
{
    int  count = 0;
    while (true)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t\t\tW E L C O M E   T O   M Y   Q U I Z   G A M E ! ! ! ");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine();
        switch (count)
        {
            case -1:
                count = 1;
                continue;
            case 0:
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t\t\t\t\tS T A R T ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\tQ U I T ");
                break;
            case 1:
                Console.WriteLine("\t\t\t\t\t\tS T A R T ");
                Console.WriteLine();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t\t\t\t\tQ U I T ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();
                break;
             case 2:
                count = 0;
                continue;
        }

        var result = Console.ReadKey();

        if(result.Key == ConsoleKey.UpArrow)
        {
            count--;
            continue;
        }

        else if(result.Key == ConsoleKey.DownArrow)
        {
            count++;
            continue;
        }

        else  if(result.Key == ConsoleKey.Enter)
        {
            if(count == 0) {
                ShowQuestions();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"\t\t\t\tT O T A L   A N S W E R S   :   1 0  ");
                Console.WriteLine($"\t\t\t\tW R O N G   A N S W E R S   : {10 - c} ");
                Console.WriteLine($"\t\t\t\tT R U E   A N S W E R S   : {c} ");
                if(score == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\t\t\t\tS C O R E : {score} pts ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\t\t\t\tS C O R E : {score} pts ");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\tEnter Any Key To Continue If You Wanna Exit Please Enter Escape Button : ");
                var resultt = Console.ReadKey();
                if(resultt.Key == ConsoleKey.Escape) {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\t\t\t\t\t\tE X I T E D ! ");
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    continue;
                }
            }

            else  if(count == 1)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\t\t\t\t\tE X I T E D ! ");
                Thread.Sleep(1000);
                break;
            }
        }
    }

}

StartGame();