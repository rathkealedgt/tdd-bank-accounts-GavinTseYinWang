Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestContructors()

        ' Arrange
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        ' Act 
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, CountryOfOrigin)
        Dim Account2 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, InterestRate, Balance)
        Dim Account3 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, InterestRate)

        ' Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)
    End Sub

    <TestMethod()> Public Sub TestGetAccountHolder()

        ' Arrange
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, CountryOfOrigin)

        ' Act
        Dim Name As String = Account1.GetAccountHolder()

        ' Assert
        Assert.AreEqual(Name, "Ms I. N. Cognito")

    End Sub

    <TestMethod()> Public Sub TestGetInterestRate()

        ' Arrange
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        ' Act
        Dim IR = Account1.GetInterestRate()

        ' Assert
        Assert.AreEqual(4.3, IR)

    End Sub

    <TestMethod()> Public Sub TestGetCountryOfOrigin()

        ' Arrange
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, CountryOfOrigin)

        ' Act
        Dim Country = Account1.GetCountryOfOrigin()

        ' Assert
        Assert.AreEqual(Country, "Isle of Man")

    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()
        'Arrange 
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act 
        Account1.SetInterestRate(5.1)

        'Assert
        Assert.AreEqual(5.1, Account1.GetInterestRate())


    End Sub

    <TestMethod()> Public Sub TestApplyInterestRate()
        'p x r x t = i=> 37.07+10343.82 = 10380.89

        'Arrange 
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act 
        Account1.ApplyInterest()

        'Assert
        Assert.AreEqual(Account1.GetBalance(), 10380.89)


    End Sub

    Private Function NewAccount() As BankAccounts.BankAccount
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"
        Return New BankAccounts.BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, CountryOfOrigin)
    End Function
End Class

