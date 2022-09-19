internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("____________________________________");
        Console.WriteLine();
        Console.WriteLine("Välkommen till TOBACCO & SALT MUSEUM");
        Console.WriteLine("____________________________________");
        Console.WriteLine("Du går genom korridoren...");
        Thread.Sleep(2000);
        Console.WriteLine("Stamp stamp ... ");
        Thread.Sleep(1000);
        Console.WriteLine("Oh slutet av korridoren!");
        Console.WriteLine();

        while(true)
        {
          
           ReadMeny();

        }
    }

    static void EnterExhibitionhall2()
    {
        var key = ConsoleKey.A;
        Console.Clear();
    do
    {
      
      Console.WriteLine("Vill du titta på pipor: tryck [A]");
      Console.WriteLine("Vill du titta bilder på Himalaya: tryck [B]");
      Console.WriteLine("För att lämna: tryck [E]");
      key = Console.ReadKey().Key;

      switch(key)
      {
        case ConsoleKey.A:
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("pipa");
        Console.WriteLine();
        break;

        case ConsoleKey.B:
        Console.Clear();
        Console.WriteLine("   // \\");
        Console.WriteLine(" //     \\");
        Console.WriteLine("//        \\");
        break;

        case ConsoleKey.E:
        ReadMeny();
        break;
        
        
      }
        }while(key != ConsoleKey.E);
      

            
    }

     static void EnterExhibitionhall1()
    {
        var key = ConsoleKey.UpArrow;
        
       
         Console.Clear();
         Console.WriteLine("E X H I B I T I O N S H A L L  1");

         do
         {
         Console.WriteLine();
         Console.WriteLine("Se Saltwater Evaporate: tryck [A]");
         Console.WriteLine("Cafét: tryck [B]");
         Console.WriteLine("Lämna: tryck [E]");

         key = Console.ReadKey().Key;
          
            switch(key)
            {
              case ConsoleKey.A:
            //   Console.Clear();
              Console.WriteLine();
              Console.WriteLine("När havets saltvatten avdunstar blir salt kvar i vattnet.");
              Console.WriteLine("Saltvattnet blir så saltigt.");
              Console.WriteLine("Vattnet blir så tungt.");
              Console.WriteLine("Så en del av saltet hamnar på botten av havet.");
              Console.WriteLine();

              break;

              case ConsoleKey.B:
              EnterCafe();
              break;

              case ConsoleKey.E:
              ReadMeny();
              break;
            }
         }while(key != ConsoleKey.E);
         
       
    }

    static void EnterCafe()
    {
        var key = ConsoleKey.UpArrow;
        Console.Clear();
        while(true)
        {
        Console.WriteLine("C A F É");
        Console.WriteLine("ÅH Vill du fika? TRYCK [A]");
        Console.WriteLine("Vill du gå till giftshop? TRYCK pil höger ");
        Console.WriteLine("Vill du gå till Exhibitionshall 1? TRYCK pil vänster");
        Console.WriteLine("Eller för att lämna? TRYCK [E]");

        key = Console.ReadKey().Key;
        
            switch(key)
            {
              case ConsoleKey.A:
              Console.Clear();
              Console.WriteLine("O []  Här fick du en kaka och en saft!");
              Thread.Sleep(3000);
              Console.WriteLine("Slut på fikat");
              Thread.Sleep(1000);
             
              break;

              case ConsoleKey.RightArrow:
                
              EnterGiftShop();
              break;

              case ConsoleKey.LeftArrow:
              EnterExhibitionhall1();
              break;

              case ConsoleKey.E:
              ReadMeny();
              break;
            }
        }
       

    }

    static void EnterGiftShop()
    {
        Console.Clear();
        Console.WriteLine("G I F T S H O P");
        Console.WriteLine("__________");
        Console.WriteLine("[1] Pipa - 1000 kr ");
        Console.WriteLine("[2] Himalaya statyett - 5000 kr");
        Console.WriteLine("[3] Avdunstningsapparat - 3000 kr ");
        Console.Write("Vad vill du köpa?: ");
        var key = Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("OJ, giftshop stänger! Vänta ska jag kolla med personalen...");
        Thread.Sleep(3000);
        Console.WriteLine("Personalen skickar ut dig till cafeet igen, attans!");
        EnterCafe();
        
    }
    static void ReadMeny()
    {
         Console.Clear();
         Console.WriteLine("Exhibitionshall 1: TRYCK pil rakt fram");
         Console.WriteLine("Exhibitionshall 2: TRYCK pil vänster");
         Console.WriteLine("Cafét: TRYCK pil höger");
         Console.WriteLine("Lämna byggnaden: TRYCK pil bak");
        var key = Console.ReadKey().Key;
            
            
            if(key == ConsoleKey.UpArrow)
                {
                     EnterExhibitionhall1();
                }
                else if(key == ConsoleKey.LeftArrow)
                {
                    EnterExhibitionhall2();
                }
                else if(key == ConsoleKey.RightArrow)
                {
                    EnterCafe();
                }
                else if(key == ConsoleKey.DownArrow)
                {
                    Environment.Exit(0);
                }

    }
}