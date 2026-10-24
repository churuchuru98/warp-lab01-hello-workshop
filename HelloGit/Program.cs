//Zadanie 1
Console.Write("Witaj w grze RPG!");
Console.Write(" Wprowadź swoje imię: ");
string name = Console.ReadLine();
Console.Write($@"Wybierz symbol reprezentujący Twoją postać! 
@ - Mag
# - Wojownik
$ - Złodziej
");
char symbol = Console.ReadLine()[0];
int exp = 1;
Console.Write("Otrzymujesz 10 sztuk złota na start!");
int goldbars = 10;
double weight = 12.5;
bool havemap = false;

Console.WriteLine($@"
 + E k w i p u n e k +
Imię(string): {name}
Symbol(char): {symbol}
Doświadczenie(int): {exp}
Złoto(int): {goldbars}
Waga(double): {weight}
Czy ma mapę(bool): {havemap}"
);
//Zadanie 2
int training = 0;
Console.WriteLine("Witaj na arenie! Rozpoczynamy trening.");
goldbars += 15;// Nagroda za wygraną
// Przed treningiem
goldbars -= 8; // Koszt wejścia na arenę
Console.WriteLine($@"
Przed treningiem:
Doświadczenie: {exp}
Złoto: {goldbars}
Trening: {training}");
exp += 25;
exp *= 2;
training++;
Console.WriteLine($@"
Po treningu:
Doświadczenie: {exp}
Złoto: {goldbars}
Trening: {training}");