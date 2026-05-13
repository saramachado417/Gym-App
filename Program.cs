﻿public class Program 
{
    static void Main()
    {
        
       Cliente cli1 = new Cliente(
             "juan",
             "2154896",
             "juann@gmail.com",
             20,
             125000,
             "PLAN",
             true,
            "15/02/2026"



        );
        Cliente cli2 = new Cliente(

             "Diana",
             "43789524",
             "Diana02@gmail.com",
             40,
             405000,
             false,
             "8/03/2026"
        );

        cli1.MostrarInfo();
        cli1.Tienemembresia();
        Console.WriteLine("===========================");
        Console.WriteLine("Cliente 2");
        cli2.Tienemembresia();
         
    }
}