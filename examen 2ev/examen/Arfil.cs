class Alfil : Pieza 
{
    private double valor;

    public Alfil(ColorAjedrez color) : base(color)
    {
        this.valor = 3.5;
    }

    public override string Nombre()
    {
        return "Alfil";
    }

    public override double Valor()
    {
        return valor;
    }
}