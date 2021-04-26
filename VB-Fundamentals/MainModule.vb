Module MainModule
    Sub Main()
        Dim prod As New Product
        Dim SellDate As DateTime

        prod.SellStartDate = #1/1/2019#
        ' Pass sellDate by reference
        prod.CalculateSellEndDate(30, SellDate)

        Console.Write(SellDate)
    End Sub
End Module
