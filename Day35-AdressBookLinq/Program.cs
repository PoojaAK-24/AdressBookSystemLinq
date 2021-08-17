using System;

namespace Day35_AdressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_AddressBookSystem_Linq");
            AddrssBookModel model = new AddrssBookModel();
            AddressBookDataTable dataTable = new AddressBookDataTable();
            dataTable.CreateTable(model);
        } 
    }
}
