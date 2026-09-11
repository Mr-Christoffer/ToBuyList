List<string> articles =new List<string>();
List<int> prices = new List<int>();
articles.Add("Hefj");
articles.Add("He65j");
articles.Add("He234j");
prices.Add(25);
prices.Add(54);
prices.Add(65);

for(int i = 0 ; i < prices.Count; i++)
{
    System.Console.WriteLine($"{articles[i]} \t {prices[i]}");
}