namespace pruebaDeMenu
    {
        class menu{
    
        public static void Main(string [] args){
            int opc,n1,n2;
            do{
                Console.WriteLine("Selecciona una Opción");
                Console.WriteLine("1.- Sumar");
                Console.WriteLine("2.- Restar");
                Console.WriteLine("3.- Mutiplicar");
                Console.WriteLine("4.- Dividir");
                Console.WriteLine("5.- Salir");
                opc=int.Parse(Console.ReadLine());
            }while(opc != 5);
            
        }
    }
}