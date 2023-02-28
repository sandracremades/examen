class Caballo : Pieza
{
    private double valor;

    public Caballo(ColorAjedrez color) : base(color)
    {
        this.valor = 3;
    }

    public override string Nombre()
    {
        return "Caballo";
    }

    public override double Valor()
    {
        return valor;
    }
}