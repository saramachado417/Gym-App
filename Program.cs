﻿public class Program 
{
    static void Main()
    {
        
        Empleado emp1 = new Empleado(
            "Juan",
            "11110001",
            "juan@mail.com",
            22,
            1000.0,
            "Jefe de personal"
        );



    Cliente cli1 = new Cliente(
           "Diana",
            "10215436",
            "diana201@gmail.com",
            36,
            150000,
            "Bonos"
    );

   cli1.MostrarInfo();
    }
}