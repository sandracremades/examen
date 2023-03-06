class SeñalConImagen : Señal
{
    private Imagen imagen{get; }

    public SeñalConImagen(Dimension dimension, Forma forma, Imagen imagen)
    {
    }
    public override float CalculaPrecio()
    {
        return ;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}