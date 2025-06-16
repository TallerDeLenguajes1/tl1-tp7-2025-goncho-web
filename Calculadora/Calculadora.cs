namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
         
        public double Resultado{
            get => dato;  
        }
        public void Sumar(double valor){
            dato += valor;
        }
        public void Restar(double valor){
            dato -= valor;
        }
        public void Multiplicar(double valor){
            dato *= valor;
        }
        public void Dividir(double valor){
            if(valor != 0){
                dato /= valor;
            }        
        }
        public void Limpiar(){
            dato = 0;
        }    
    }
}