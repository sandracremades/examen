class Peon : Pieza
{
    private double valor;

    public Peon(ColorAjedrez color) : base(color)
    {
        this.valor = 1;
    }

    public override string Nombre()
    {
        return "Peon";
    }

    public override double Valor()
    {
        return valor;
    }
}