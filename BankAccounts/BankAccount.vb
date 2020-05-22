'''<summary>
'''    Represents a single bank account. 
''' </summary>
''' <author>Mr M</author>
''' <date>06/05/20</date>
Public Class BankAccount

    Private AccountHolder As String
    Private AccountNumber As String
    Private InterestRate As Double
    Private Balance As Double
    Private CountryOfOrigin As String

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double, Balance As Double, CountryOfOrigin As String)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.InterestRate = InterestRate
        Me.Balance = Balance
        Me.CountryOfOrigin = CountryOfOrigin

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double, Balance As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.InterestRate = InterestRate
        Me.Balance = Balance

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, InterestRate As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.InterestRate = InterestRate

    End Sub

    Public Function GetAccountHolder() As String
        Return Me.AccountHolder

    End Function

    Public Function GetInterestRate() As Double
        Return Me.InterestRate

    End Function

    Public Function GetCountryOfOrigin() As String
        Return Me.CountryOfOrigin

    End Function

    Public Function SetInterestRate(Rate As Double)
        Me.InterestRate = Rate

        Return Nothing
    End Function

    Public Function ApplyInterest()
        Dim NewBalance As Double = Me.Balance + (Me.Balance * 0.043 * (1 / 12))

        Me.Balance = Math.Round(NewBalance, 2)

        Return Nothing
    End Function
End Class
