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
    System.Console.WriteLine($"{i+1}. {articles[i]} \t\t {prices[i]} kr");
}
foreach (int p in prices)
{
    totalCost += p;
}
System.Console.WriteLine($"Totalt:\t\t{totalCost} kr");