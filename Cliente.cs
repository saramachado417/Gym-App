public class Cliente : Persona
{
    private double membresia;
    public string TipoMembresia = "";
    public double Membresia
    {
        get { return membresia; }
        set {
            if(value >= 0)
            {
                membresia = value;
            } else {
                Console.WriteLine("La membresía no puede ser negativa!");
            }
        }
    }

    public Cliente(
            string nombre,
            string documento,
            string correo,
            int edad,
            double membresia,
            string tipoMembresia
        )
        :base(nombre, documento, correo, edad)
        {
            this.membresia = membresia;
            this.TipoMembresia = tipoMembresia;
        }

    public Cliente(
            string nombre,
            string documento,
            string correo,
            int edad,
            double membresia
        )
        :base(nombre, documento, correo, edad)
        {
            this.membresia = membresia;
        }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine("Tipo de Membresía: " + TipoMembresia);
        Console.WriteLine("Membresía: $" + Membresia.ToString("N0"));
    }

    public void CalcularMembresia(string tipo)
    {
        Console.WriteLine(this.membresia);
    }

    public void CalcularMembresia(double descuento)
    {
        Console.WriteLine(this.membresia * descuento);
    }
}