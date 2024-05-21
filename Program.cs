using  EspacioCalculadora;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora miCalculadora= new Calculadora();
int bandera=1;
int opcion;
int numero1;
do{

Console.WriteLine("1_Suma");
Console.WriteLine("2_Resta");
Console.WriteLine("3_Multiplicacion");
Console.WriteLine("4_Division");
Console.WriteLine("5_Limpiar");
Console.WriteLine("Ingrese una opcion: ");
int.TryParse(Console.ReadLine(), out opcion);

Console.WriteLine("Ingrese un numero: ");
string num1 = Console.ReadLine();
if (int.TryParse(num1,out numero1))
{
    


switch (opcion){

case 1:
    miCalculadora.Sumar(numero1);
    Console.WriteLine(miCalculadora.RESULTADO);

break;
case 2:
   miCalculadora.Restar(numero1);
   Console.WriteLine(miCalculadora.RESULTADO);

break;

case 3:
    miCalculadora.Multiplicar(numero1);
    Console.WriteLine(miCalculadora.RESULTADO);


break;
case 4:
miCalculadora.Dividir(numero1);
Console.WriteLine(miCalculadora.RESULTADO);

break;
case 5:
  miCalculadora.Limpiar(numero1);
  Console.WriteLine(miCalculadora.RESULTADO);

break;

}
}
Console.WriteLine("DESEA SEGUUIR? ");
string bandera2= Console.ReadLine();
if (int.TryParse(bandera2, out bandera))
{
    if (bandera==0)
    {
        break;
    }
}

} while (bandera!=0);


Console.WriteLine(miCalculadora.RESULTADO);