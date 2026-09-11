List<string> articles =new List<string>();
List<int> prices = new List<int>();
/*articles.Add("Mjölk");
articles.Add("Bröd");
articles.Add("Ost");
prices.Add(15);
prices.Add(32);
prices.Add(89);*/
bool programRun = true;

while (programRun)
{
    Console.Clear();
    for(int i = 0 ; i < prices.Count; i++)
{
    System.Console.WriteLine($"{i+1}. {articles[i], -15} {prices[i],5} kr"); //Added width paragraphs. -15 means take 15 slots and adjust to left. 5 means it take up 5 slots but adjust to the right
}
int totalCost = 0;
foreach (int p in prices)
{
    totalCost += p;
}
System.Console.WriteLine($"{"Totalt:",-12}{totalCost, 12} kr");

System.Console.WriteLine("Skriv artikelnamn för att lägga till vara. Skriv ett artikelnummer för att ta bort en vara:");
string? input = Console.ReadLine();
//Determines if user types a word or number

if (int.TryParse(input, out int number)) //If its a int-number
    {
        if(number <= articles.Count && number > 0) // If typed number exists as an articlenumber
        {
            articles.RemoveAt(number-1);
            prices.RemoveAt(number-1);
        }
        else
        {
            System.Console.WriteLine("Det artikelnumret finns inte!");
            System.Console.WriteLine("Tryck valfri knapp för att fortsätta!");
            Console.ReadKey();
        }
    }
else
    {
        if(input.Length <= 15) // Checks length of input so it doesnt go over the 15 slots maximum length (otherwise list would not look good)
        {
            System.Console.WriteLine("Ange priset för " + (input));
            string? priceInput = Console.ReadLine();
            if(int.TryParse(priceInput, out int price))
            {
                articles.Add(input);
                prices.Add(price);
            }
            
        }
        else
        {
            System.Console.WriteLine("Maximalt 15 tecken är tillåtna för artiklar!");
            System.Console.WriteLine("Tryck valfri knapp för att fortsätta!");
            Console.ReadKey();
        }

    }

}

