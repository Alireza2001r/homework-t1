Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Writer or programmer : Alireza Rakodapour & Std Code : 00231085907009 .");
Console.WriteLine("in this project i get number of category and their values or children .");
Console.WriteLine("This program is such that after entering the number of the categories, the first entered value is considered its root, and then the subsequent values are considered as its children until the character n is entered. By entering this character, the second category and its values must be written.");
Console.WriteLine("*** Maximum value of 9 for each category ***");
Console.WriteLine("----------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.White;

#region get content
Console.Write("please enter the number of categories: "); int categoryNum = int.Parse(Console.ReadLine());
string[,] Myarr = new string[categoryNum, 10];
int i, j;
for (i = 0; i < Myarr.GetLength(0); i++)
{
    for (j = 0; j < Myarr.GetLength(1); j++)
    {
        if (j == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"please enter root[{i + 1}]:");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"please enter child[{j}]:");
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.ForegroundColor = ConsoleColor.Red;

        Myarr[i, j] = Console.ReadLine();
        if (Myarr[i, j] == "n")
        {
            break;
        }
    }
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine();
    Console.WriteLine("next step ... ");
    Console.WriteLine();
}

#endregion

#region main

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-------------- Answer -----------------");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;

RecursiveFun(Myarr);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Roots : ");
Console.ForegroundColor = ConsoleColor.Blue;
var roots = getRoot(Myarr, categoryNum);
foreach (var root in roots)
{
    Console.Write(root + "\t");
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------- End ------------------");
Console.ForegroundColor = ConsoleColor.White;


Console.ReadKey();
#endregion

#region Functions

// recursive function
static void RecursiveFun(string[,] arr, int i = 0, int j = 0)
{
    if (i < 0 || i >= arr.GetLength(0) || j < 0 || j >= arr.GetLength(1))
        return;

    if (j == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(arr[i, j] + " : ");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(arr[i, j] + " ");

    }

    if (j == arr.GetLength(1) - 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($" <=== Category {i + 1} ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("*********");
        Console.WriteLine();
        i++;
        j = 0;
    }
    else
    {
        j++;
    }

    RecursiveFun(arr, i, j);
}

// get root values
string[] getRoot(string[,] arr, int categoryNum)
{
    string[] root = new string[categoryNum];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        root[i] = arr[i, 0];
    }
    return root;
}

#endregion



//-------------------------------- Alireza Rakhodapour -------------------------------- 