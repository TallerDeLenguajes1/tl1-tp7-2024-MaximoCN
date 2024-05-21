namespace EspacioCalculadora;

public class Calculadora
{
   private double dato;


    public double RESULTADO { get => dato; }

    public void Sumar(double param){
        dato= dato+param;
    }

 public void Restar(double param){
    dato=dato-param;
 }
 public void Multiplicar(double param){
    dato= dato*param;
 }
 public void Dividir(double param){
    dato=dato/param;
 }
public void Limpiar(double param){
    dato=0;
}



}