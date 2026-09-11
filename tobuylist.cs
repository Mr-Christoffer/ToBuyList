List<string> articles =new List<string>();
List<int> prices = new List<int>();
articles.Add("Mjölk");
articles.Add("Bröd");
articles.Add("Ost");
prices.Add(15);
prices.Add(32);
prices.Add(89);
int totalCost = 0;

for(int i = 0 ; i < prices.Count; i++)
{
    System.Console.WriteLine($"{i+1}. {articles[i], -15} {prices[i],5} kr"); //Added width paragraphs. -15 means take 15 slots
}
foreach (int p in prices)
{
    totalCost += p;
}
System.Console.WriteLine($"{"Totalt:",-12}{totalCost, 12} kr");