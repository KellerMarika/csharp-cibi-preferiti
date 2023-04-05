// See https://aka.ms/new-console-template for more information
//string[] cibiPreferiti = { "tortellini in brodo","zuppa inglese", "gramigna alla salsiccia", "plumcake ai 4 formaggi", "sushi", "pizza casereccia", "piadina romagnola", "fiori di zucca fritti", "patate arrosto", "ciccioli frolli" };

////- La lunghezza della classifica
//Console.WriteLine($"La classifica dei miei cibi preferiti conta {cibiPreferiti.Length} piatti:");

//for (int i = 0; i < cibiPreferiti.Length ; i++)
//{
//    //- La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
//    Console.WriteLine($" in {i+1}° poisizione: {cibiPreferiti[i]}");
//}
////- Il vostro cibo top (prima posizione della classifica)
//Console.WriteLine($"il piatto 'preferito': {cibiPreferiti[0]}!!!");

////-Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
//Console.WriteLine($"il piatto 'preferito ma non troppo': {cibiPreferiti[cibiPreferiti.Length-1]}!!!");

////**BONUS**  il/i cibo di mezza classifica,

//if (cibiPreferiti.Length % 2 == 0)
// Console.WriteLine($"i 2 cibi di mezza classifica sono: {cibiPreferiti[cibiPreferiti.Length / 2 -1]} in {cibiPreferiti.Length / 2 }° posizione & {cibiPreferiti[cibiPreferiti.Length / 2]} in {cibiPreferiti.Length / 2 + 1}° posizione"); 

//else
//Console.WriteLine($"il cibo di mezza classifica: {cibiPreferiti[cibiPreferiti.Length / 2]} in {cibiPreferiti.Length / 2 +1}° posizione");


Console.Write("da quanti piatti è composta la classifica dei tuoi piatti preferiti? scegli un numero da 1 a 10:  ");
string userLenght = Console.ReadLine();
//Console.WriteLine($"numero inserito= {userLenght} {userLenght.GetType().Name}");
int arrayLenght = Convert.ToInt16(userLenght);
//Console.WriteLine($"numero inserito tradotto= {arrayLenght.GetType().Name}");

string[] cibiPreferitiUtente = new string[arrayLenght];
Console.WriteLine($"inserisci i tuoi {arrayLenght} cibi preferiti in ordine di preferenza:");
for( int i = 0; i < arrayLenght; i++ )
{
    Console.Write($"al {i +1}° posto: ");
    cibiPreferitiUtente[i] = Console.ReadLine();
}

//- La lunghezza della classifica
Console.WriteLine($"La classifica dei tuoi cibi preferiti conta {cibiPreferitiUtente.Length} piatti:");

for (int i = 0; i < cibiPreferitiUtente.Length; i++)
{
    //- La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
    Console.WriteLine($" in {i + 1}° poisizione: {cibiPreferitiUtente[i]}");
}
//- Il vostro cibo top (prima posizione della classifica)
Console.WriteLine($"il piatto 'preferito': {cibiPreferitiUtente[0]}!!!");

//-Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Console.WriteLine($"il piatto 'preferito ma non troppo': {cibiPreferitiUtente[cibiPreferitiUtente.Length - 1]}!!!");

//**BONUS**  il/i cibo di mezza classifica,

if (cibiPreferitiUtente.Length % 2 == 0)
    Console.WriteLine($"i 2 cibi di 'mezza classifica' sono: {cibiPreferitiUtente[cibiPreferitiUtente.Length / 2 - 1]} in {cibiPreferitiUtente.Length / 2}° posizione & {cibiPreferitiUtente[cibiPreferitiUtente.Length / 2]} in {cibiPreferitiUtente.Length / 2 + 1}° posizione");

else
    Console.WriteLine($"il cibo di mezza classifica: {cibiPreferitiUtente[cibiPreferitiUtente.Length / 2]} in {cibiPreferitiUtente.Length / 2 + 1}° posizione");