using System;

namespace Program
{

    class Program
    {

        static void MandaPedidoAFabrica(Pedido pedido) => FabricaSeñales.RecibePedido(pedido);

        static void ConfirmaPedidosAFrabrica()
        {
            try
            {

                FabricaSeñales.Fabrica();

            }
            catch (FabricaSeñales.TextoMalFormadoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FabricaSeñales.ImagenErroneaException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {

            Señal[] señalesPedido1 ={
                new SeñalConImagen(new Señal.Dimension(50,50),Señal.Forma.Circulo,new Imagen(Imagen.Color.Negro,"Auto")),
                new SeñalConImagen(new Señal.Dimension(20,60),Señal.Forma.Rectangulo,new Imagen(Imagen.Color.Blanco,"flecha")),
                new SeñalConTexto(new Señal.Dimension(50,50),Señal.Forma.Circulo,new Texto("60", false)),
                new SeñalConTexto(new Señal.Dimension(50,50),Señal.Forma.Octogono,new Texto("STOP", true)),
                new SeñalConTexto(new Señal.Dimension(20,70),Señal.Forma.Flecha,new Texto("BURGOS 8",false)),
                new SeñalMixta(new Señal.Dimension(30,30),Señal.Forma.Rectangulo)
                                     .AñadeTexto(new Texto("cv-80", true))
                                     .AñadeTexto(new Texto("CASTALLA 2", false)) };

            Console.ReadLine();

            Pedido pedido1 = new Pedido(señalesPedido1);
            pedido1.AñadeProductoPedido(new SeñalConImagen(new Señal.Dimension(50, 50), Señal.Forma.Triangulo, new Imagen(Imagen.Color.Negro, "tren")));
            pedido1.AñadeProductoPedido(new SeñalConImagen(new Señal.Dimension(50, 50), Señal.Forma.Triangulo, new Imagen(Imagen.Color.Negro, "tren")));

            Console.WriteLine("El pedido1 incluye los siguientes elementos:");
            Console.WriteLine(pedido1);
           
            MandaPedidoAFabrica(pedido1);


            Señal[] señalesPedido2 ={
                new SeñalConImagen(new Señal.Dimension(50,50),Señal.Forma.Rectangulo,new Imagen(Imagen.Color.Azul,"Ciervo")),
                new SeñalConTexto(new Señal.Dimension(30,30),Señal.Forma.Rectangulo,new Texto("PX-2", true))};

            Pedido pedido2 = new Pedido(señalesPedido2);
            MandaPedidoAFabrica(pedido2);

            ConfirmaPedidosAFrabrica();

        
            Pedido pedido3 = new Pedido();
            pedido3.AñadeProductoPedido(new SeñalConImagen(new Señal.Dimension(50, 50), Señal.Forma.Triangulo, new Imagen(Imagen.Color.Negro, "tran")));
           
            MandaPedidoAFabrica(pedido3);
            ConfirmaPedidosAFrabrica();

            Console.ReadLine();
        }
    }
}