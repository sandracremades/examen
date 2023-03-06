using System.Text.RegularExpressions;
static class FabricaSeñales
{
    private static Pedido[] pedidos;

    public static void RecibePedido(Pedido pedidos)
    {

    }
    private static bool QuedaPedidos()
    {

    }
    private static float CalculaPrecio(Pedido pedidos)
    {
        return pedidos += pedidos;
    }
    private static Pedido SiguientePedido()
    {
        Pedido primerPedido=pedidos[0];

        Pedido s2 = pedidos.Remove(1, 0);

        return primerPedido;
    }
    private static void ValidaTexto(string texto)
    {
        try
        {
            Regex patron1 = new Regex(@"^STOP$");
            Regex patron2 = new Regex(@"^[R]{1}-[0-9]{1}$");
            Regex patron3 = new Regex(@"^[E]{1}-[0-9]{1,2}$");
            Regex patron4 = new Regex(@"^[A, AP, N, M, LR, BI, CV, CM, EX]{1}-[0-9]{1,3}$")
            


            bool textoValido1 = patron1.IsMatch(texto);
            bool textoValido2 = patron2.IsMatch(texto);
            bool textoValido3 = patron3.IsMatch(texto);
            bool textoValido4 = patron4.IsMatch(texto);
        }
        catch
        {
            throw new TextoMalFormadoException("Texto no valido");
        }

    }
    private static void ValidaImagen(string imagen)
    {
        try
        {

        }
        catch
        {
            throw new ImagenErroneaException("Imagen erronea");
        }

    }
    private static void CompruebaDatosPedido(Pedido p)
    {

    }
    public static void Fabrica()
    {

    }

}