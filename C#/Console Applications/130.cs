using System;
public class Program
{
    static void Main(string[] args)
    {
        Stock appleStock = new Stock("AAPl", 150.00m);
        appleStock.StockPriceChanged += Investor1_StockPriceChanged;
        appleStock.StockPriceChanged += Investor2_StockPriceChanged;
        appleStock.Price = 155.00m;
        appleStock.Price = 160.00m;
    }
    private static void Investor1_StockPriceChanged(object sender, StockPriceChanged(EventArgs e))
    {
        System.Console.WriteLine($"Investor1:The price of{e.StockSymbol}changed to(e.NewPrice:c}");
    }
    private static void Investor2_StockPriceChanged(object sender, StockPriceChanged(EventArgs e))
    {
        System.Console.WriteLine($"Investor2:The price of{e.StockSymbol}changed to(e.NewPrice:c}");
    }
}
