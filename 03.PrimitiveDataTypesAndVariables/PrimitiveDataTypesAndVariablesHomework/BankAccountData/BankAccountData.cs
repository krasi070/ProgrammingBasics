using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Petyr";
        string middleNmae = "Littlefinger";
        string lastName = "Baelish";
        float balance = 13085.67f;
        string bankName = "Iron Bank";
        string iban = "GB82 WEST 1234 5698 7654 32";
        ulong fstCreditCard = 4309897194865423;
        ulong sndCreditCard = 4485073502359006;
        ulong trdCreditCard = 4929624089098294;
        Console.WriteLine("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nBalance: {3}\nBank Name: {4}\nIBAN: {5}\nFirst Card Number: {6}\nSecond Card Number: {7}\nThird Card Number: {8}", firstName, middleNmae, lastName, balance, bankName, iban, fstCreditCard, sndCreditCard, trdCreditCard);
    }
}
