// Demander nom et âge

/*
Console.WriteLine("Entrez votre nom: ");
var nom = Console.ReadLine();

Console.WriteLine("Entrez votre âge: ");
var age = Console.ReadLine();

Console.WriteLine($"Bonjour, vous vous appelez {nom} et vous avez {age} ans");

Console.ReadKey();
*/


// Calcul arithmétique

/*
var a = 6;
var b = 2;

Console.WriteLine($"Si a vaut {a} et b vaut {b}: ");
Console.WriteLine($"La somme des variables vaut {a+b}");
Console.WriteLine($"La différence des variables vaut {a-b}");
Console.WriteLine($"Le produit des variables vaut {a*b}");
Console.WriteLine($"Le quotient des variables vaut {a/b}");

Console.ReadKey();
*/


// Décimales

/*Console.WriteLine("Entrez une valeur décimale: ");
var a = Console.ReadLine();

Console.WriteLine($"{a}");*/


// Cours 21/09: Conversions

// Convertir int en string

/*Console.WriteLine("Entrez un nombre entier: ");
string nbStr = Console.ReadLine();
int nb;
int.TryParse(nbStr, out nb);
Console.WriteLine($"Le double de {nb} est {nb * 2}.");*/

// Convertir float en int

/*Console.WriteLine("Entrez un nombre décimal: ");
string nbStr = Console.ReadLine();
decimal nb;
decimal.TryParse(nbStr, out nb);
int nbInt = Convert.ToInt32(nb);
Console.WriteLine($"L'entier de {nbStr} est {nbInt}.");*/

// Conditionelles

// Pair ou impair

/*Console.WriteLine("Entrez un nombre entier: ");
var nb = Console.ReadLine();
var parseResult = int.TryParse(nb, out int nbInt);
if (parseResult == false)
{
    Console.WriteLine($"{nb} n'est pas un nombre.");
}
else if (nbInt == 0)
{
    Console.WriteLine($"{nb} est zéro.");
}
else if (nbInt % 2 != 0)
{
    Console.WriteLine($"{nb} est un nombre impair.");
}
else
{
    Console.WriteLine($"{nb} est un nombre pair.");
}*/

// Calc

//V1
/*Console.WriteLine("Entrez un nombre: ");
var nb1 = Console.ReadLine();
var parseResult1 = decimal.TryParse(nb1, out decimal n1);
Console.WriteLine("Entrez un opérateur: ");
var op = Console.ReadLine();
Console.WriteLine("Entrez un nombre: ");
var nb2 = Console.ReadLine();
var parseResult2 = decimal.TryParse(nb2, out decimal n2);
if (parseResult1 == false || parseResult2 == false)
{
    Console.WriteLine("Veuillez entrer des nombres.");
}
else
{
    switch (op)
    {
        case "+":
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            break;
        case "-":
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            break;
        case "*":
            Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
            break;
        case "/":
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            break;
        default:
            Console.WriteLine("Veuillez entrer un opérateur valide.");
            break;
    }
}*/

//V2
/*Console.WriteLine("Entrez les nombres à calculer en les séparant avec Enter: ");
if (int.TryParse(Console.ReadLine(), out var a)
    && int.TryParse(Console.ReadLine(), out var b))
{
    Console.WriteLine("Entrez un opérateur ( + - * / ): ");
    string? op = Console.ReadLine();
    var result = op switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" => a / b,
        _ => throw new InvalidOperationException()
    };
    Console.WriteLine($"{a} {op} {b} = {result}");
}
else
{
    Console.WriteLine("Nombre invalide.");
}*/

// Compte bancaire

Console.WriteLine("Entrez un numéro de compte belge: ");
var bban = Console.ReadLine();
if (long.TryParse(bban, out long rc))
{
    if (bban.Length != 12)
    {
        Console.WriteLine("Veuillez introduire un numéro de compte à 12 chiffres.");
    }
    else
    {
        var tenFirst = bban[0..10];
        var parseResult1 = long.TryParse(tenFirst, out long a);
        var twoLast = bban[10..12];
        var parseResult2 = int.TryParse(twoLast, out int b);
        var chkSum = a % 97;
        bool result = chkSum == b;
        if (result)
        {
            Console.WriteLine($"{bban} est un numéro de compte valide.");
        }
        else
        {
            Console.WriteLine($"Numéro de compte invalide (tenFirst = {tenFirst}; twoLast = {twoLast}; chkSum = {chkSum}; result = {result}).");
        }
    }
}
else
{
    Console.WriteLine("Veuillez introduire uniquement des chiffres.");
}