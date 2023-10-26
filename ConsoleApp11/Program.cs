using System;

namespace uppgift_3_2;
class Program
{
    static void Main()
    {
        Console.Write("Har du gått ut gymnasiet? (j för ja, n för nej): ");
        char harGattUtGymnasiet = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Lägg till en radbrytning för att göra utskriften snyggare.

        if (harGattUtGymnasiet == 'j' || harGattUtGymnasiet == 'J')
        {
            Console.Write("Hur gammal är du? ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
        }
        else if (harGattUtGymnasiet == 'n' || harGattUtGymnasiet == 'N')
        {
            Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
        }
        else
        {
            Console.WriteLine("Ogiltigt svar. Ange antingen 'j' för ja eller 'n' för nej.");
        }
    }
}
