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
//Zadanie 3
Console.Write("Ile jest racji żywności w Twoim ekwipunku? ");
int rations = Convert.ToInt32(Console.ReadLine());
Console.Write("Ile jest członków drużyny? ");
int teamMembers = Convert.ToInt32(Console.ReadLine());
Console.Write("Ile jest dni wyprawy?");
int expeditionDays = Convert.ToInt32(Console.ReadLine());
double totalrations = rations / teamMembers * expeditionDays;
Console.WriteLine($"Łączna ilość racji żywności na wyprawę: {totalrations}");
//Zadanie 4
Console.Write("Ile masz punktów życia? ");
int healthPoints = Convert.ToInt32(Console.ReadLine());
Console.Write("Ile masz mikstur? ");
int potions = Convert.ToInt32(Console.ReadLine());
Console.Write("Czy masz klucz? (true/false) ");
bool hasKey = Convert.ToBoolean(Console.ReadLine());
Console.Write("Czy masz mapę? (true/false) ");
bool hasMap = Convert.ToBoolean(Console.ReadLine());
bool alive = healthPoints > 0;
bool hasFullHealth = healthPoints == 100;
bool haveequipment = potions > 0;
bool navigationItem = hasKey || hasMap;
bool readyForAdventure = alive && hasFullHealth && haveequipment && navigationItem;
Console.WriteLine($"Czy jesteś gotowy na przygodę? {readyForAdventure}");
//Zadanie 5
Console.Write("Podaj liczbę: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number % 2 == 0)
{
    Console.WriteLine("Liczba jest parzysta.");
}
else
{
    Console.WriteLine("Liczba jest nieparzysta.");
}