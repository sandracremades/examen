class Torre : Pieza 
{
    private double valor;

    public Torre(ColorAjedrez color) : base(color)
    {
        this.valor = 5.5;
    }

    public override string Nombre()
    {
        return "Torre";
    }

    public override double Valor()
    {
        return valor;
    }
}