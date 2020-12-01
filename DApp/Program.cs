using Algorand;
using Algorand.Algod.Api;
using System;

namespace DApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            var a = "YTZVLL4XHBHMMZ2YOFNYFICMRVKTQAYHGOKEPNIA35HACBNVHNOOCYTN6I";
            if (Address.IsValid(a))
            {
                Console.WriteLine("Address is Valid");
            }
            else
                Console.WriteLine("Address is not Valid");
            AlgodApi algodApiInstance = new AlgodApi("https://testnet-algorand.api.purestake.io/ps1", "B3SU4KcVKi94Jap2VXkK83xx38bsv95K5UZm2lab");
            var accountInfo = algodApiInstance.AccountInformation(a.ToString());
            Console.WriteLine($"Acccount Balance of {a} is {accountInfo.Amount}");
        }
    }
}
