class Texto
{
    private string texto{get;}
    private bool controTexto{get;}

    public Texto(string texto, bool controTexto)
    {
        this.texto = texto;
        this.controTexto = controTexto;
    }
    public float Longitudtexto()
    {
        return texto.Length;
    }
    public override string ToString()
    {
        return texto;
    }
}