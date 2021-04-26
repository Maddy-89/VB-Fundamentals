Module MainModule
    Sub Main()
        Dim prod As New Product

        prod.SellStartDate = #1/1/2019#
        prod.CalculatedSellEndDate(20)

        Console.WriteLine(prod.SellEndDate)

        Console.ReadKey()
    End Sub
End Module
