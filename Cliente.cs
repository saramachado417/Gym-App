public class Cliente : Persona
{
    private double pago;
    public string TipoMembresia = "";
    public string FechaIngreso = "";
    public bool TieneMembresia;
    public double Pago
    {
        get { return pago; }
        set {
            if(value >= 0)
            {
                pago = value;
            } else {
                Console.WriteLine("El pago no puede ser negativo!");
            }
        }
    }

    public Cliente(
            string nombre,
            string documento,
            string correo,
            int edad,
            double pago,
            string tipoMembresia,
            bool tieneMembresia,
            string fechaIngreso
        )
        :base(nombre, documento, correo, edad)
        {
            this.pago = pago;
            this.TipoMembresia = tipoMembresia;
            this.TieneMembresia = tieneMembresia;
            this.FechaIngreso = fechaIngreso;
            
        }

    public Cliente(
            string nombre,
            string documento,
            string correo,
            int edad,
            double pago,
            bool tieneMembresia,
            string fechaIngreso
        )
        :base(nombre, documento, correo, edad)
        {
            this.pago = pago;
            this.TieneMembresia = tieneMembresia;
            this.FechaIngreso = fechaIngreso;
        }

    public override void MostrarInfo()

    {
        base.MostrarInfo();
        Console.WriteLine("Tipo de Membresía: " + TipoMembresia);
        Console.WriteLine("Pago: $" + Pago.ToString("N0"));
    }

    public void Tienemembresia()
    {
        Console.WriteLine("Tiene Membresia: " + TieneMembresia);
    }
    public void CalcularPago(string tipo)
    {
        Console.WriteLine(this.pago);
    }

    public void CalcularPago(double descuento)
    {
        Console.WriteLine(this.pago * descuento);
    }
}