﻿Public Class Product
    Public Property ProductID As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property StandardCost As Decimal
    Public Property ListPrice As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime
    Function CalculateSellEndDate(ByVal days As Integer) As DateTime
        SellEndDate = SellStartDate.AddDays(days)

        Return SellEndDate
    End Function
    Function CalculateProfit(Optional ByVal newCost As Decimal = 0) As Decimal
        If newCost <> 0 Then
            StandardCost = newCost
        End If

        Return ListPrice - StandardCost
    End Function

End Class
