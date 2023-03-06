class SeñalConTexto : Señal
{
    protected Texto texto{get;}

    public SeñalConTexto(Dimension dimension, Forma forma, Texto texto)
    {
    }
    public override float CalculaPrecio()
    {
        return texto.Longitudtexto*2;
    }
    public override string ToString()
    {
        return base.ToString();
    }

}