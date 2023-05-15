class Program{
     static void Main(string[] args){
        Console.Write("city : ");
            string city =  (Console.ReadLine());
            
            Console.Write("contact :");
            int contact = int.Parse(Console.ReadLine());

            Console.Write("x :");
            string  p =(Console.ReadLine());



        
        if (contact == 0) {
            Console.WriteLine("Prontera");
       } else if (contact == 1) {
            Console.WriteLine("Geffen");
       } else if (contact == 2) {
            Console.WriteLine("Morroc");
       } else if (contact == 3) {
            Console.WriteLine("Payon");
       } else if (contact == 4) {
            Console.WriteLine("Alberta");
       } else if (contact == 5) {
            Console.WriteLine("Al De Baran");
       } else if (contact == 6) {
            Console.WriteLine("Yuno");
       } else if (contact == 7) {
            Console.WriteLine("Izude");
            
        } 
        else {
            Console.WriteLine("Invalid ID");



            }
         }

           
     }


