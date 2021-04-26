Module MainModule
    Sub Main()
        Dim prod As New Product
        Dim SellDate As DateTime

        prod.SellStartDate = #5/1/2019#
        prod.StandardCost = 250
        prod.ListPrice = 500

        SellDate = prod.CalculateSellEndDate(30)
        Console.WriteLine(prod.CalculateProfit())
        Console.WriteLine(prod.CalculateProfit(700))

        Console.Write(SellDate)

        Console.ReadKey()
    End Sub
End Module
