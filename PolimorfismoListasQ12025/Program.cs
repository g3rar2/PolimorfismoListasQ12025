

using PolimorfismoListasQ12025;

string tipo, opcion;
double precio;
List<Edificio> lista=new List<Edificio> ();


do
{

    Console.Write("Ingrese el tipo de edificio ");
    tipo = Console.ReadLine ();

    Console.Write("Ingrese el valor de edificio ");
    precio=Convert.ToDouble (Console.ReadLine());

    Console.Write("Desea Continuar (S/N) o (s/n) ");
    opcion = Console.ReadLine();
  
    Edificio edificio = new Edificio (tipo, precio);
    lista.Add (edificio);

} while (opcion.ToUpper()!="N");

foreach (Edificio edificio in lista)
{
    edificio.Vender();
}
