using Control_de_Invetario_de_TecnoPunto;

class Program
    {

    static void Main()
        {
        
        Console.WriteLine("       CONTROL DE INVENTARIO");
        Console.WriteLine("             TECNO PUNTO");
        Console.WriteLine();

        string codigo1, nombre1;
        decimal precio1;
        int cantidad1;
        Producto producto1 = null;

        do
            {
            try
                {
                Console.WriteLine("       REGISTRO DEL PRODUCTO 1");
                

                Console.Write("Ingrese el codigo: ");
                codigo1 = Console.ReadLine();

                Console.Write("Ingrese el nombre: ");
                nombre1 = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                precio1 = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad: ");
                cantidad1 = int.Parse(Console.ReadLine());

                producto1 = new Producto(codigo1, nombre1, precio1, cantidad1);
                }
            catch (Exception error)
                {
                Console.WriteLine(error.Message);
                }

            } while (producto1 == null);

        string codigo2, nombre2;
        decimal precio2;
        int cantidad2;
        Producto producto2 = null;

        do
            {
            try

                {
                Console.WriteLine();
                Console.WriteLine("       REGISTRO DEL PRODUCTO 2");

                Console.Write("Ingrese el codigo: ");
                codigo2 = Console.ReadLine();

                Console.Write("Ingrese el nombre: ");
                nombre2 = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                precio2 = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad: ");
                cantidad2 = int.Parse(Console.ReadLine());

                producto2 = new Producto(codigo2, nombre2, precio2, cantidad2);
                }
            catch (Exception error)
                {
                Console.WriteLine(error.Message);
                }

            } while (producto2 == null);

        string codigo3, nombre3;
        decimal precio3;
        int cantidad3;
        Producto producto3 = null;

        do
            {
            try
                {
                Console.WriteLine();
                Console.WriteLine("       REGISTRO DEL PRODUCTO 3"); 

                Console.Write("Ingrese el codigo: ");
                codigo3 = Console.ReadLine();

                Console.Write("Ingrese el nombre: ");
                nombre3 = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                precio3 = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad: ");
                cantidad3 = int.Parse(Console.ReadLine());

                producto3 = new Producto(codigo3, nombre3, precio3, cantidad3);
                }
            catch (Exception error)
                {
                Console.WriteLine(error.Message);
                }

            } while (producto3 == null);

        Console.WriteLine();
        Console.WriteLine("       INFORMACION DE PRODUCTOS");
        Console.WriteLine();

        Console.WriteLine("     PRODUCTO 1");
        producto1.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine("     PRODUCTO 2");
        producto2.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine("     PRODUCTO 3");
        producto3.MostrarInfo();

        Console.WriteLine();
        Console.WriteLine("       FIN DEL REGISTRO");



        }


    }
