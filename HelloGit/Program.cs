//Zadanie 1
Console.Write("Witaj w grze RPG!");
Console.Write("Wprowadź swoje imię: ");
string name = Console.ReadLine();
Console.Write($@"Wybierz symbol reprezentujący Twoją postać! 
@ - Mag
# - Wojownik
$ - Złodziej");
char symbol = Console.ReadLine()[0];
int exp = 1;
Console.Write("Otrzymujesz 5 sztuk złota na start!");
int goldbars = 5;
double weight = 12.5;
bool havemap = false;

Console.WriteLine($@" + E k w i p u n e k +
Imię(string): {name}
Symbol(char): {symbol}
Doświadczenie(int): {exp}
Złoto(int): {goldbars}
Waga(double): {weight}
Czy ma mapę(bool): {havemap}"
);

