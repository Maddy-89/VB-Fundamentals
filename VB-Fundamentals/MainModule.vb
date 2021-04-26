Module MainModule
    Sub Main()
        Dim prod As New Product
        Dim SellDate As DateTime

        prod.SellStartDate = #5/1/2019#

        SellDate = prod.CalculateSellEndDate(30)

        Console.Write(SellDate)

        Console.ReadKey()
    End Sub
End Module
