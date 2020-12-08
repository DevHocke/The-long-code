using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Net;
using System.IO;

namespace Metoder_Benny_och_Nicklas
{
    /*
    class Program
    {
        // ----------------------------------------------------------------------------------------------------------------
        // ******************************************* BENNYS LEKTION. ****************************************************
        // ----------------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    //Programmet körs igång och kallar på koden som ligger i metoden KörProgram().
        //    KörProgram();
        //}
        //static void KörProgram()
        //{
        //    //Initierar en Lista av typen int som vi döper till "totalaSumman"
        //    List<int> totalaSumman = new List<int>();
        //    //Forloopens syfte är att köra det som finns i scopet 5 gånger
        //    for (int i = 0; i < 5; i++)
        //    {
        //        //Slumpar fram två tal (en ingrediens per variabel)
        //        Random rand = new Random();
        //        double slump1 = rand.Next(0, 11);
        //        double slump2 = rand.Next(0, 11);
        //        //Skriver ut vad vi har att arbeta med (ingredienserna)
        //        Console.WriteLine("-------- Beräkning {0} --------", i + 1);
        //        Console.WriteLine("Tal 1: {0}", slump1);
        //        Console.WriteLine("Tal 2: {0}", slump2);
        //        //Nu ska vi lägga ihop allt och då måste vi kalla på metoden Addera (se det som bunken som du rör ihop allt i)
        //        double totalSumma = Addera(slump1, slump2);
        //        Console.WriteLine("Uträkningen leder till resultatet: {0}", totalSumma);
        //        Console.WriteLine("-----------------------------");
        //        Console.WriteLine(Environment.NewLine);
        //    }
        //}
        //static double Addera(double tal1, double tal2)
        //{
        //    //Rör ihop alla ingredienser och skickar in dom i nästa metod (ugnen)
        //    return Dividera(tal1 + tal2);
        //}
        //static double Dividera(double summa)
        //{
        //    //Returnerar resultatet (en färdig kaka)
        //    return summa / 2;
        //}
        //------------------------------------------------------------------------------------------------------------------
        // ********************************************** NICKLAS LEKTION **************************************************
        //------------------------------------------------------------------------------------------------------------------
        // Console.WriteLine($"Hej {myArray.Lenght} Så här kan jag skriva för att göra allt kortare och snyggare myArray kan även skrivas {myArray[2]}");
        //static void Main(string[] args)
        //{
        //    //Deklarerade variabler
        //    int nummer1 = 5;
        //    int nummer2 = 12;
        //    //Kallar på en metod som enbart skriver ut text i console
        //    PrintMethod();
        //    //2 siffror in, ut kommer en WriteLine
        //    //Siffrorna kan vara vad som helst
        //    Input2NumbersAdded(4, 10);
        //    Input2NumbersAdded(nummer1, nummer2); //Här skickas nummer1 och nummer2 in, deklarerades ovan
        //    //Om vi vill spara summan in i en variabel
        //    int summa = NewInput2NumbersAdded(4, 10);
        //    Console.WriteLine(summa); //Testar skriva ut summan vi fick tillbaka från metoden.
        //    int myInt = Metodraketen(5, 95);
        //    Console.WriteLine(myInt);
        //    int minSumma = DividedMethod(10, 33);
        //}
        //// static         void       /    int/string/bool osv.        Metodnamn      (int x) / (string namn, int age)  
        ////   ^              ^                      ^                      ^            ^                ^
        //// Alltid     Ger inget tbx       En variabel ges tbx         Metodnamn      Parameter som skickas in till metoden när den kallas
        //static void PrintMethod() //Returnerar inget till användaren därav "void", den utför bara sin kod. 
        //{
        //    Console.WriteLine("Hello! This method only contains a \"WriteLine();\"");
        //}
        ////Denna metod tar in 2 variabler > kör sin kod > skriver ut till console
        //static void Input2NumbersAdded(int x, int y)
        //{
        //    //x och y är nummer 1 och nummer 2 som vi skickar in när vi anropar vår metod
        //    //variablerna får såklart döpas till vad man vill
        //    int sum = x + y;
        //    Console.WriteLine($"The sum of your addition is: {sum}");
        //}
        ////Samma metod som ovan.Men denna returnerar en int tillbaka till main
        //static int NewInput2NumbersAdded(int x, int y)
        //{
        //    int sum = x + y;
        //    return (sum); //Vi sparar värdet/variablen tillbaka till main, där vi sparar den som int summa;
        //}
        //static int Metodraketen(int myNumber1, int myNumber2)
        //{
        //    int myNewNumber = myNumber1 + myNumber2;
        //    return Metodraketen2(myNewNumber);
        //}
        //static int Metodraketen2(int myNewNumber)
        //{
        //    int sum = myNewNumber * 2;
        //    return sum;
        //}
        //static int DividedMethod(int x, int y)
        //{
        //    int sum = x / y;
        //    return sum;
        //}
        //---------------------------------------------------------------------------------------------------------------------
        // MINA ÖVNINGAR: EGEN
        //---------------------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    StartProgram();
        //    Console.ReadLine();
        //}
        //static void StartProgram()
        //{
        //    bool keepGoing = false;
        //    do
        //    {
        //        Console.WriteLine("Hej och välkommen till lek med metoder! ");
        //        Console.WriteLine("1. Gör en enkel beräkning ");
        //        Console.WriteLine("2. Slumpa ett nytt efternamn ");
        //        Console.WriteLine("3. Gissa talet ");
        //        Console.WriteLine("4. Loopa igenom en lista ");
        //        Console.WriteLine("5. Bada en arg katt ");
        //        Console.WriteLine("6. Gör allting ");
        //        Console.WriteLine("7. Mixa ditt telefonnummer ");
        //        Console.WriteLine("8. EXIT");
        //        int choice = Convert.ToInt32(Console.ReadLine());
        //        if (choice == 1)
        //        {
        //            // Låter användaren skriva in två int tal som sedan skickar de två värdena till metoden SimpleCalculator,
        //            // i metoden SimpleCalculator adderas talen ihop och svaret returneras till metoden StartProgram och skriver ut det i konsolen.
        //            Console.WriteLine("Skriv ditt första tal: ");
        //            int numb1 = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Skriv ditt andra tal: ");
        //            int numb2 = Convert.ToInt32(Console.ReadLine());
        //            int answer = SimpleCalculator(numb1, numb2);
        //            Console.WriteLine("Talet är: " + answer);
        //        }
        //        else if (choice == 2)
        //        {
        //            // Låter användaren skriva in sitt förnamn och får ett svar med ett random efternamn
        //            // som skrivs ut i consolen i metoden som är satt till void.
        //            RandomLastname();
        //        }
        //        else if (choice == 3)
        //        {
        //            // Låter användaren skriva in ett tal mellan 1 och 7 i metoden GuessNumber.
        //            // användarens tal och det slumpade talet lagras i en array som skickas tillbaks
        //            // till metoden StartProgram där en if sats styr vad som skrivs ut till användaren.
        //            int[] answer = GuessNumber();
        //             if (answer[0] == 1)
        //             {
        //                Console.WriteLine("Grattis du valde rätt nummer!");
        //             }
        //             else if (answer[1] == 0)
        //             {
        //                Console.WriteLine("Otur, du valde fel nummer bättre lycka nästa gång!");
        //             }
        //            Console.ReadLine();
        //            Console.Clear();
        //        }
        //        else if (choice == 4)
        //        {
        //            // Låter användaren skriva in 10 heltal i metoden loopThroughList.
        //            // Listan skrivs sedan ut i en forloop i metoden som är satt till void.
        //            LoopThroughList();
        //        }
        //        else if (choice == 5)
        //        {
        //            // Användaren får skriva ett tal mellan 0 och 10, talet skickas in i metoden DippThekitty där det jämförs mot två arrayer.
        //            // Om talet är ojämnt så returneras värdet 1 och så kastas den stackars katten i sjön. 
        //            // Är talet jämt så vinner katten.
        //            Console.WriteLine("Skriv ett nummer mellan 0 och 10.");
        //            int numbIn = Convert.ToInt32(Console.ReadLine());
        //            int wetDry = DippTheKitty(numbIn);
        //            Console.Clear();
        //            Console.WriteLine($"Du valde nummer {numbIn}");
        //            if (wetDry == 1)
        //            {
        //                Console.WriteLine("Fel nummer: Katten vann!");
        //            }
        //            else if (wetDry == 2)
        //            {
        //                Console.WriteLine("Rätt nummer: Du kastade den stackars katten i sjön!");
        //                Console.WriteLine("Inte konstigt att den är så arg... ;) ");
        //            }
        //            else if (wetDry == 3)
        //            {
        //                Console.WriteLine("Felaktig inmatning pappskalle!");
        //            }
        //            Thread.Sleep(3000);
        //            Console.Clear();
        //        }
        //        else if (choice == 6)
        //        {
        //            break;
        //        }
        //        else if (choice == 7)
        //        {
        //            break;
        //        }
        //        else if (choice == 8)
        //        {
        //            Console.WriteLine("Slipp då jäkla tråkmåns!");
        //            Thread.Sleep(3000);
        //            Console.Clear();
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Fel val pappskalle, skärp dig!");
        //        }
        //        Console.WriteLine("Do you want to try again? ");
        //        Console.WriteLine("1. Yes ");
        //        Console.WriteLine("2. No ");
        //        int yesNo = Convert.ToInt32(Console.ReadLine());
        //        if (yesNo == 1)
        //            keepGoing = true;
        //        else if (yesNo == 2)
        //        {
        //            Console.WriteLine("Tack för ditt deltagande, välkommen åter!");
        //            keepGoing = false;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Felaktig inmatning.");
        //            keepGoing = true;
        //        }
        //    } while (keepGoing == true);
        //}
        //static int SimpleCalculator(int a, int b)
        //{
        //    int sum = a + b;
        //    return sum;
        //}
        //static void RandomLastname()
        //{
        //    Console.WriteLine("Vad heter du?: ");
        //    string name = Console.ReadLine();
        //    Random rand = new Random();
        //    string[] lastNames = new string[4] {"Saxbacke", "Laengstjaert", "Pjuttgjen", "Stolpskott"};
        //    lastNames[0] = "Saxbacke";
        //    lastNames[1] = "Laengstjaert";
        //    lastNames[2] = "Pjuttgren";
        //    lastNames[3] = "Stolpskott";
        //    int mixed = rand.Next(lastNames.Length);
        //    Console.WriteLine("Hej " + name + " " + lastNames[mixed]);
        //}
        //static int[] GuessNumber()
        //{
        //    int[] lucky7 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        //    int[] returnNumb = new int[2];
        //    Random rand = new Random();
        //    Console.WriteLine("Skriv ett tal mellan 1 och 7");
        //    int numb = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < lucky7.Length; i++)
        //    {
        //        int win = rand.Next(lucky7[i]);
        //        if (win == numb)
        //        {
        //            returnNumb[0] = 1;
        //        }
        //        else
        //        {
        //            returnNumb[1] = 0;
        //        }
        //    }
        //    return returnNumb;
        //}
        //static void LoopThroughList()
        //{
        //    List<int> loopThrough = new List<int>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{i} Skriv ett heltal"); 
        //        int numbIn = Convert.ToInt32(Console.ReadLine());
        //        loopThrough.Add(numbIn);
        //    }
        //    Console.Clear();
        //    foreach(var item in loopThrough)
        //    {
        //        Console.WriteLine($"Du valde nummer {item}");
        //    }
        //    Console.ReadLine();
        //    Console.Clear();
        //}
        //static int DippTheKitty(int x)
        //{
        //    int numbOut = 0;
        //    int[] even = new int[5] {2, 4, 6, 8, 10};
        //    int[] unEven = new int[5] {1, 3, 5, 7, 9};
        //    for (int i = 0; i < even.Length; i++)
        //    {
        //        if (even[i] == x)
        //        {
        //            numbOut = 1;
        //        }
        //    }
        //    for (int j = 0; j < unEven.Length; j++)
        //    {
        //        if (unEven[j] == x)
        //        {
        //            numbOut = 2;
        //        }
        //    }    
        //    if (numbOut == 1 || numbOut == 2)
        //    {
        //        return numbOut;
        //    }
        //    else
        //    {
        //        return 3;
        //    }
        //}
        // --------------------------------------------------------------------------------------------------------------------
        // ***************************************** ÖVNINGAR 5 V 3 ***********************************************************
        // --------------------------------------------------------------------------------------------------------------------
        //1.Skapa ett program som har en en array eller lista för strängar som du du kalla kompisLista.
        //2.Fyll den med minst tre namn.T.ex.Robin, Björn B, Björn S.
        //3.Skriv en foreach-loop för varje sträng kompis i kompisLista.
        //4.I din loop skriv ut "Hej " + namnet på en kompis så att alla kompisar har blivit hälsade på när loopen körts klart.
        //5.Skriv en metod static void HälsaPå(string kompis)
        //6.Flytta innehållet i forloop från uppgift 3.till din metod. 
        //7.I ditt huvudprogram(Main) gör så att loopen kallar på HälsaPå(kompis) istället för att skriva ut själv. 
        //    Bonusuppgift: För att göra hälsningen lite mindre stel testa att använda Random rnd = new Random(); och en
        //    string array med olika hälsningsfraser för att blanda vilka fraser du använder för att hälsa på dina kompisar*/
    /*
class program
{
    static void Main(string[] args)
    {
    }
}
  */

    /*
   static void Main(string[] args)
   {
       List<string> friendsList = new List<string>();
       friendsList.Add("Pelle");
       friendsList.Add("BennyBulaDenLillaFula");
       friendsList.Add("Kalle Stropp");
       NewMethod(friendsList);
       static void NewMethod(List<string> friendsList)
       {
           string[] myArray = new string[9];
           myArray[0] = "Du luktar så gott ";
           myArray[1] = "Imorgon är en ny dag ";
           myArray[2] = "Inga bullar för dig ";
           myArray[3] = "Massa bullar för dig ";
           myArray[4] = "Kom in i matchen ";
           myArray[5] = "Nope inte här heller ";
           myArray[6] = "Vill du ha en kaka ";
           myArray[7] = "Bussen gick för 5 min sedan ";
           myArray[8] = "Du är en pappskalle ";
           for (int i = 0; i < friendsList.Count; i++)
           {
               Random rand = new Random();
               String random = myArray[rand.Next(myArray.Length)];
               Console.WriteLine(random + friendsList[i]);     
           }
       }
   } /*
   //8.Skriv en metod sorteraTreTal som tar tre tal som paramterar och returnerar en array.
   //9.Skapa en array och placera dina tre tal i storleksordning i arrayen.
   //    Du kan återanvända kod från tidigare uppgifter för att ta reda på vilket tal som är stört, mellan och minst.
   //10.Returnera arrayen.
   //11.Testa så att metoden fungerar genom att skriva ut arrayen med hjälp av en foreach-loop i huvudprogrammet.
   // Default är en bool false.
   /*
   string enIfKontroll = default(string); // Default är en string "". Det går att kontrollera med isNullOrEmpty
   if (string.IsNullOrEmpty(enIfKontroll))
   {
   }
   int[] sortArray = new int[3];
    Console.WriteLine("Ange tal 1. ");
    sortArray[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ange tal 2. ");
    sortArray[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ange tal 3. ");
    sortArray[2] = Convert.ToInt32(Console.ReadLine());
   SorteraTreTal(sortArray);  // Kallar på metoden SorteraTreTal som tar in de tre talen från användaren och sorterar dem med Array.Sort
   foreach (var item in sortArray)
   {
       Console.WriteLine(item);
   }
   static int[] SorteraTreTal(int[] bumbiBjörnarna) // Tar in en int Array samt returnerar en int array. 
   {
       Array.Sort(bumbiBjörnarna);
   //  Array.Reverse(bumbiBjörnarna);  // Ändrar ordningen på arrayen.
       return bumbiBjörnarna;
   }
   */

    //12.Skriv en metod static int Hexagontal som tar en int n som parameter. 
    //13.I metoden skapa en variabel för summan och sätt det till 0.
    //14.Skriv en for-loop som går från k = 0 till k < n.
    //15.I loopen öka summan med 4 * k + 1.
    //16.Returnera summan
    //17.I huvudprogrammet anropa på metoden och skriv ut returvärdet till konsolen.

    //   För att kolla om du gjort rätt så ger n = 1-> 1, n = 2-> 6, n = 3-> 15, n = 4-> 28

    //   https://sv.wikipedia.org/wiki/Hexagontal 
    /*
    Console.WriteLine(Hexagontal(2));
    static int Hexagontal(int n)
    {
        int sum = default(int); // dafault in är 0.
        for (int k = 0; k < n; k++)
        {
            sum += 4 * k + 1;  // += lägger till summan + det nya värdet. endast = ändrar värdet i sum.
        }
        return sum;
    }
    Console.ReadLine();
    */

    //Avancerad uppgift till er som vill ha lite utmaning: 


    //Triangeltal är som kan modelleras som trianglar eller trappor.T.ex. 3 = 1 + 2 eller 10 = 1 + 2 + 3 + 4.
    //19.Skapa en metod som givit ett tal testar med hjälp utav en loop ifall det talet är ett triangel tal.

    //   Så i det här fallet ska du bruteforca talet på något sätt eftersom det är programmering vi ska öva på och inte matte.
    //20.Om talet är ett triangeltal så ska metoden kalla på en annan metod som skriver ut det i trapform:

    //                  10

    //               6  9

    //           3  5  7

    //       1  2  3  4

    //   Dvs varje position i trappan ska skriva ut antalet platser till vänster och under det.

    // }
    // ------------------------------------------------------------------------------------------------------------------
    // ************************************ START ÖVNINGAR 6 v 3 EXERCISES 6 ********************************************
    // ------------------------------------------------------------------------------------------------------------------
    //                                  Metoder
    //1. Skapa en metod som tar in två argument, int a, int b och returnera a + b
    //2. Skapa en metod som tar in två argument, int a, int b och returnera a - b
    //3. Skapa en metod som tar in två argument, int a, int b och returnera a / b
    //4. Skapa en metod som tar in två argument, int a, int b och returnera a* b
    //5. Ge alla dessa beskrivande namn
    /*
   static void Main(string[] args)
   {
       bool keepGoing = false;
       do
       {
           Console.WriteLine("Hej och välkommen till övningar 6");
           Console.WriteLine("1. Gör en + beräkning ");
           Console.WriteLine("2. Gör en - beräkning ");
           Console.WriteLine("3. Gör en / beräkning ");
           Console.WriteLine("4. Gör en * beräkning ");
           Console.WriteLine("5. EXIT");
           int choice = Convert.ToInt32(Console.ReadLine());
           if (choice == 1)
           {
               Console.WriteLine("Skriv in heltal 1: ");
               int numb1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Skriv in heltal 2: ");
               int numb2 = Convert.ToInt32(Console.ReadLine());
               int sumPlus = PlusCalc(numb1, numb2);
               Console.WriteLine($"The sum is: {sumPlus}");                   
           }
           else if (choice == 2)
           {
               Console.WriteLine("Skriv in heltal 1: ");
               int numb1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Skriv in heltal 2: ");
               int numb2 = Convert.ToInt32(Console.ReadLine());
               int sumPlus = MinusCalc(numb1, numb2);
               Console.WriteLine($"The sum is: {sumPlus}");                  
           }
           else if (choice == 3)
           {
               Console.WriteLine("Skriv in heltal 1: ");
               int numb1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Skriv in heltal 2: ");
               int numb2 = Convert.ToInt32(Console.ReadLine());
               int sumPlus = DividedCalc(numb1, numb2);
               Console.WriteLine($"The sum is: {sumPlus}");  
           }
           else if (choice == 4)
           {
               Console.WriteLine("Skriv in heltal 1: ");
               int numb1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Skriv in heltal 2: ");
               int numb2 = Convert.ToInt32(Console.ReadLine());
               int sumPlus = MultCalc(numb1, numb2);
               Console.WriteLine($"The sum is: {sumPlus}");                    
           }
           else if (choice == 5)
           {
               Console.WriteLine("Program EXIT");
               break;
           }
           Console.WriteLine("do you want to do any other calculation?");
           Console.WriteLine("1. Yes.");
           Console.WriteLine("2. No.");
           int answer = Convert.ToInt32(Console.ReadLine());
           if (answer == 1)
           {
               keepGoing = true;
           }
           else if (answer == 2)
           {
               keepGoing = false;
           }
           else
           {
               break;
           }
       } while(keepGoing == true);
       Console.WriteLine("Thank you for playing!");
       Console.ReadLine();
   }
   static int PlusCalc(int a, int b)
   {
       int sum = a + b;
       return sum;
   }
   static int MinusCalc(int a, int b)
   {
       int sum = a - b;
       return sum;
   }
   static int DividedCalc(int a, int b)
   {
       int sum = a / b;
       return sum;
   }
   static int MultCalc(int a, int b)
   {
       int sum = a * b;
       return sum;
   }
   */
    // ---------------------------------------------------------------------------------------------------------------------------
    //6. Skapa en metod som tar in basen och höjden av en triangel och returnera arean.
    //7. Skapa en metod som tar in en bool och returnera det motsatta.
    //8. Skapa en metod som tar in en lista och returnerar det sista elementet.
    //9. Skapa en metod som tar in ett heltal och multiplicera talet med 10. Kalla sedan på en annan metod från första metoden och returnera det talet delat på 5.
    /*
     static void Main(string[] args)
     {
         float width = 13;
         float height = 8;
         float answerTriangel = Triangel(width, height);
         Console.WriteLine($"The area of the triangel is = {answerTriangel}");
         bool sendOut = true;
         bool answerBool = BoolOut(sendOut);
         Console.WriteLine($"The bool was {sendOut} and is now {answerBool}");
         List<float> myList = new List<float>() { 1, 4, 6, 5, 89, 432, 5, 98 };
         float lastNumb = LastNumbInList(myList);
         Console.WriteLine($"The last number in the list is {lastNumb}");
         int finalnumb =  UserNumbIn();
         Console.WriteLine($"Ditt tal * 10 / 5 är: {finalnumb}");
         Console.ReadLine();
     }
     static float Triangel(float a, float b)
     {
         float calculation = a * b / 2;
         return calculation;
     }
     static bool BoolOut(bool a)
     {
         bool boolIn = a;
         if (boolIn == true)
         {
             boolIn = false;
         }
         else if (boolIn == false)
         {
             boolIn = true;
         }
         return boolIn;
     }
     static float LastNumbInList(List<float> x)
     {            
         float answer = x[x.Count -1]; // Or use float answer = x.Last(); men måste ha using Linq!
         return answer;
     }
     static int UserNumbIn()
     {
         Console.WriteLine("Skriv ett heltal: ");
         int numb = Convert.ToInt32(Console.ReadLine());
         int sendIt = (numb * 10);
         return DivideNumb(sendIt);
     }
     static int DivideNumb(int sendIt)
     {
         int finalnumb = (sendIt / 5);
         return finalnumb;
     }
    */
    // ------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
    //10. Skapa en lista av strings med fyra element "Det" "var" "en" "gång..."
    //11. Ta listan av strings och skicka in den i en kedja av metoder.
    //12. För varje metod lägg till en string i listan
    //13. När det finns 10 element i listan, skriv ut allt på en rad separerat med,
    /*
    static void Main(string[] args)
    {
        List<string> myList = new List<string>() {"Det ", "var ", "en ", "gång " };
        List<string> start = ChainOne(myList);
        Console.Write(string.Join(",", myList);
        Console.ReadLine();
    }
    static List<string> ChainOne(List<string> start)
    {
        start.Add("en ");
        return ChainTwo(start);
    }
    static List<string> ChainTwo(List<string> start)
    {
        start.Add("liten ");
        return ChainThree(start);
    }
    static List<string> ChainThree(List<string> start)
    {
        start.Add("prutt ");
        return ChainFour(start);
    }
    static List<string> ChainFour(List<string> start)
    {
        start.Add("som ");
        return ChainFive(start);
    }
    static List<string> ChainFive(List<string> start)
    {
        start.Add("hette ");
        return ChainSix(start);
    }
    static List<string> ChainSix(List<string> start)
    {
        start.Add("Benny ");
        return start;
    }
    */
    //14. Skapa ett program som ber användaren mata in ett tal 10 gånger. Spara undan dessa i en lista
    //15. Skicka in listan i en metod som heter SortEven.
    //16. För varje element i listan: Kolla om talet är jämt
    //17. Om talet är jämt skicka in talet till en annan metod som lägger till det i en lista.
    //18. Gör likadant med ojämna tal
    //19. Skriv sedan ut de båda listorna med antalet jämna och ojämna tal
    /*
    static List<int> oddNumbs = new List<int>();
    static List<int> evenNumbs = new List<int>();
    static void Main(string[] args)
    {
        StartProgram();
    }
    private static void StartProgram()
    {
        List<int> listOfNumbers = new List<int>();
        Console.WriteLine("Hej. Skriv in tio tal.");
         for (int i = 0; i < 10; i++)
         {
             Console.Write($"Tal {i}: ");
             listOfNumbers.Add(Convert.ToInt32(Console.ReadLine()));
         }
         Sort(listOfNumbers);
         Console.WriteLine(" ");
         Console.WriteLine("Even numbers:");
         Console.Write(string.Join(", ", evenNumbs));
         Console.WriteLine(" ");
         Console.WriteLine("------------------");
         Console.WriteLine("Odd numbers:");
         Console.Write(string.Join(", ", oddNumbs));
    }
    static void Sort(List<int> listOfNumbers)
    {
        foreach (var item in listOfNumbers)
        {
            if (item % 2 == 0)
            {
                EvenNumbers(item);
            }
            else
            {
                OddNumbers(item);
            }
        }
    }
    static int EvenNumbers(int even)
    {
        evenNumbs.Add(even);
        return even;
    }
    static int OddNumbers(int odd)
    {
        oddNumbs.Add(odd);
        return odd;
    }
    */
    // ------------------------------------------------------------------------------------------------------------
    //20. Skriv en metod som konverterar timmar till minuter
    //21. Använd sedan minuterna som argument till en annan metod som konverterar minuter till sekunder. 
    //22. Skriv sedan ut vad timmar blir i minuter och hur många sekunder det är totalt
    /*
    class Program{
        static void Main(string[] args)
        {
            int minutes = (HourToMinutes(1));
            int sek = MinutesToSec(minutes);
            Console.WriteLine($"En timme är {minutes} minuter och  {sek} sekunder.");
        }
        static int HourToMinutes(int time)
        {
            return time * 60;
        }
        static int MinutesToSec(int time)
        {
            time = time * 60;
            return time;
        }
    }
    */
    //23. Hur mycket är sant? Skriv en metod som kollar en array av bool statements och retunera antalet true/false
    //24. Om antalet true är mer än false skriv ut "In wine there is potatos!" annars skriv ut "lies lies lies..."
    /*
    static void Main(string[] args)
    {
        bool[] yesNo = new bool[10];
        yesNo[0] = true;
        yesNo[1] = true;
        yesNo[2] = false;
        yesNo[3] = false;
        yesNo[4] = true;
        yesNo[5] = false;
        yesNo[6] = true;
        yesNo[7] = false;
        yesNo[8] = true;
        yesNo[9] = true;
        Fixa(yesNo);
        static void Fixa(bool[] yesNo)
        {
            int sant = 0;
            int falskt = 0;
            for (int i = 0; i < yesNo.Length; i++)
            {
                if (yesNo[i] == false)
                {
                    falskt ++;
                }
                else if (yesNo[i] == true)
                {
                    sant ++;
                }
            }
            Console.WriteLine($"False var {falskt} st. True var {sant} st.");
            Console.WriteLine("------------------------------");
             if (sant > falskt)
             {
                Console.WriteLine($"In wine there is potatoes?!? ");
             }
             else if (sant < falskt)
             {
                Console.WriteLine($"lies lies lies...");
             }
        }*/
    /* } */ // <---- TA BORT DETTA ÄR CLASS PROGRAMS AVSLUT


    // -------------------------------------------------------------------------------------------
    // **************************** ÖVNINGAR del 7 KLASSER ***************************************
    // -------------------------------------------------------------------------------------------
    // 1.Skapa en class som heter Fordon!
    // 2. Ge denna klass generella egenskaper hos ett fordon!
    // 3. Skapa ett object som skall efterlikna ett flygplan!
    // 4. Skapa ett object som skall efterlinkna en pansarvagn!
    // 5. Skapa ett object som skall efterlikna en elstyrd scooter!
    // 6. Ge klassen en Describe metod som skriver ut de olika delarna!
    // 7. Ge alla klasser en GoForward metod som beskriver hur ett sådant fordon rör på sig!
    /*
    class Vehicle // Klassen Vehicle är föräldern och representerar blueprinten som används i klasserna som ärver förälderns egenskaper.
    {
        private string brand;
        private string model;
        private int modelYear;
        private string color;
        private int gas;
        public string Brand 
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int ModelYear
        {
            get
            {
                return modelYear;
            }
            set
            {
                modelYear = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Gas
        {
            get
            {
                return gas;
            }
            set
            {
                gas = value;
            }
        }
        public string Describe()
        {
            string answer = ($"The vehicle is of the make {brand} and the model is {model}. It was produced {modelYear} and has the color {color} and {gas} litres of fuel.");
            return answer;
        }
    }
    class Airplane : Vehicle // Classen Airplane ärver från classen Vehicle vilket indikeras med Förälderns namn : Childs namn.
    {
        public Airplane() // TOM KONSTRUKTOR
        {
          
        }
        public Airplane(string brand, string model, int modelYear, string color, int gas) // KONSTRUKTOR som tar inparametrar. Dessa måste skrivas i rätt ordning string brand först för att den ligger först i konstruktorn och föräldern.
        {
            this.Brand = brand;
            this.Model = model;
            this.ModelYear = modelYear;
            this.Color = color;
            this.Gas = gas;
        }
        public void GoForward()
        {
            Console.WriteLine("The airplane is to old and the engine died, you will crash and die in 2 seconds.");
        }
         
    }
    class Tank : Vehicle // Classen Tank ärver från classen Vehicle vilket indikeras med Förälderns namn : Childs namn.
    {
        public Tank() // TOM KONSTRUKTOR
        {
           
        }
        public Tank(string brand, string model, int modelYear, string color, int gas) // KONSTRUKTOR som tar inparametrar. Dessa måste skrivas i rätt ordning string brand först för att den ligger först i konstruktorn och föräldern.
        {
            this.Brand = brand;
            this.Model = model;
            this.ModelYear = modelYear;
            this.Color = color;
            this.Gas = gas;
        }
        public void GoForward()
        {
            Console.WriteLine("The Tank is out of ammo and will instead try to run enemies over");
        }
    }
    class Scooter : Vehicle // Classen Scooter ärver från classen Vehicle vilket indikeras med Förälderns namn : Childs namn.
    {
        public Scooter() // TOM KONSTRUKTOR
        {
           
        }
        public Scooter(string brand, string model, int modelYear, string color, int gas) // KONSTRUKTOR som tar inparametrar. Dessa måste skrivas i rätt ordning string brand först för att den ligger först i konstruktorn och föräldern.
        {
            this.Brand = brand;
            this.Model = model;
            this.ModelYear = modelYear;
            this.Color = color;
            this.Gas = gas;
        }
        public void GoForward()
        {
            Console.WriteLine("The scooter is to slow, the zombie horde catches you and you die...");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Airplane plane = new Airplane();
            plane.Brand = "Piper"; // <--- brand cant be reached due to its protection lvl.
            plane.Model = "Cessna";
            plane.ModelYear = 1932;
            plane.Color = "White";
            plane.Gas = 500;
            Scooter myScooter = new Scooter("TeenyWeeny", "StringBikini", 2005, "Faluröd", 3);
            Tank wreckingBall = new Tank("KillerMachines", "KillYaAss", 1937, "Candy apple red", 53);
            Console.WriteLine(plane.Describe());
            plane.GoForward();
            Console.WriteLine(Environment.NewLine); 
            Console.WriteLine(myScooter.Describe());
            myScooter.GoForward();
            Console.WriteLine(Environment.NewLine);
            wreckingBall.GoForward();
            Console.WriteLine(wreckingBall.Describe());
        }    
    }
    
    
    /*
    class Program
    {
            static void Main(string[] args)
            {
                Airplane Airplane = new Airplane();
                Airplane.brand = "Saab";
                Airplane.model = "Jas 39 Gripen";
                Airplane.year = 2020;
                Airplane.color = "Militärbajsbrun";
                Airplane.damaged = true;
                Airplane.speed = 2500;
                Airplane.charge = 100;
                Console.WriteLine(Airplane.Describe());
                Airplane.GoForward();
                Console.WriteLine(Environment.NewLine);
                Tank Tank = new Tank();
                Tank.brand = "Pansarvagn 90";
                Tank.model = "Tiger";
                Tank.year = 1965;
                Tank.color = "Militärbajsgrön";
                Tank.damaged = true;
                Tank.speed = 80;
                Tank.charge = 50;
                Console.WriteLine(Tank.Describe());
                Tank.GoForward();
                Console.WriteLine(Environment.NewLine);
                Scooter Scooter = new Scooter();
                Scooter.brand = "ChingChong";
                Scooter.model = "Fjong bong";
                Scooter.year = 2018;
                Scooter.color = "GrisRosa";
                Scooter.damaged = false;
                Scooter.speed = 250;
                Scooter.charge = 100;
                Console.WriteLine(Scooter.Describe());
                Scooter.GoForward();
                Console.WriteLine(Environment.NewLine);
            }
            class Vehicle
            {
                public string brand;
                public string model;
                public int year;
                public string color;
                public bool damaged;
                public int speed;
                public int charge;
                public string Describe()
                {
                    string answer = ("This vehicle is " + brand + " " + model + " from " + year + " The color is " + color + " Damaged or used status: " + damaged + " It has the top speed of " + speed + " and comes with a full tank " + charge + "%");
                    return answer;
                }
            }
            class Airplane : Vehicle
            {
                public void GoForward()
                {
                    Console.WriteLine("Planet flyger fram");
                }
            }
            class Scooter : Vehicle
            {
                public void GoForward()
                {
                    Console.WriteLine("Scootern swishar fram...");
                }
            }
            class Tank : Vehicle
            {
                public void GoForward()
                {
                    Console.WriteLine("Tanken mosar allt i sin väg när den kör genom skogen.");
                }
            }
        }
        */
    /* 
  8. Skapa en class som heter fastigheter
  9. Ge denna klass generella egenskaper hos en fastighet (såsom rum, kök etc)
  10. Skapa ett object som skall efterlikna ett radhus
  11. Skapa ett object som skall efterlikna villa
  12. Skapa ett object som skall efterlikna ett lägenhetskomplex
  13. Ge alla klasser en passande Describe metod
  14. Skapa ett program som låter användaren välja vilken av dessa som hen vill få beskrivet till sig.
  */
    /*
   class Fastigheter
   {
      int sovrum;
      int badrum;
      int allrum;
      int klädkammare;
      int toalett;
      public Fastigheter(int Sovrum, int Badrum, int Allrum, int Klädkammare, int Toalett)
      {
          this.sovrum = Sovrum;
          this.badrum = Badrum;
          this.allrum = Allrum;
          this.klädkammare = Klädkammare;
          this.toalett = Toalett;
      }
   }
   class Villa : Fastigheter
   {
      public Villa(int Sovrum, int Badrum, int Allrum, int Klädkammare, int Toalett)
      {           
          this.sovrum = Sovrum;
          this.badrum = Badrum;
          this.allrum = Allrum;
          this.klädkammare = Klädkammare;
          this.toalett = Toalett;
      }
      public void Describe()
      {
          Console.WriteLine("Gummibralla");
      }
   }
   class Program
   {
   } 
    // 8. Skapa en class som heter fastigheter
    // 9. Ge denna klass generella egenskaper hos en fastighet(såsom rum, kök etc)
    // 10. Skapa ett object som skall efterlikna ett radhus
    // 11. Skapa ett object som skall efterlikna villa
    // 12. Skapa ett object som skall efterlikna ett lägenhetskomplex
    // 13. Ge alla klasser en passande Describe metod
    // 14. Skapa ett program som låter användaren välja vilken av dessa som hen vill få beskrivet till sig.
    /*
     public class Fastigheter //Parent -  äger Field + Property (Get och Set)
     {
        //Field
        private int sovrum;
        private int badrum;
        private int allrum;
        private int klädkammare;
        private int toalett;
        private int kök;
        //property
        public int Sovrum
        {
            get
            {
                return sovrum;
            }
            set 
            {
                sovrum = value;
            }
        }
        public int Badrum
        {
            get
            {
                return badrum;
            }
            set
            {
                badrum = value;
            }
        }
        public int Allrum
        {
            get
            {
                return allrum;
            }
            set
            {
                allrum = value;
            }
        }
        public int Klädkammare
        {
            get
            {
                return klädkammare;
            }
            set
            {
                klädkammare = value;
            }
        }
        public int Toalett
        {
            get
            {
                return toalett;
            }
            set
            {
                toalett = value;
            }
        }
        public int Kök
        {
            get
            {
                return kök;
            }
            set
            {
                kök = value;
            }
        }
     }
class Radhus : Fastigheter // Child
{
    //Construktor 
    public Radhus(int sovrum, int badrum, int allrum, int klädkammare, int toalett, int kök)
    {
        this.Sovrum = sovrum; //Säger att er property-Sovrum är samma som Parent-field's variabler
        this.Badrum = badrum;
        this.Allrum = allrum;
        this.Klädkammare = klädkammare;
        this.Toalett = toalett;
        this.Kök = kök;
    }
}
class Villa : Fastigheter // Child
{
    public Villa(int sovrum, int badrum, int allrum, int klädkammare, int toalett, int kök)
    {
        this.Sovrum = sovrum;
        this.Badrum = badrum;
        this.Allrum = allrum;
        this.Klädkammare = klädkammare;
        this.Toalett = toalett;
        this.Kök = kök;
    }    
    public void Describe()
    {
        Console.WriteLine("Gummibralla");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Radhus radhusBadhus = new Radhus(12, 4, 4, 6, 8, 1);  // Vill vi bygga en Radhus så skriver vi så här.
        Villa villaVillekulla = new Villa(5, 2, 1, 3, 2, 1);  // Vill vi bygga en villa så skriver vi så här.
        Villa villaVillekulla2 = new Villa(6, 1, 2, 4, 3, 2); // Villa nr 2.
        List<Villa> husLista = new List<Villa>() { villaVillekulla, villaVillekulla2 };
        int index = 1;
        foreach (var hus in husLista)
        {
            Console.WriteLine($"Hus{index++} har {hus.Badrum} badrum.");
        }
    }
}*/
    // 1. Börja med att välkomna användaren
    // 2. Fylla listan med uppgifter
    // 3. Visa alla uppgifter
    // 4. Samla allt hittills i en meny där man kan kalla på de andra metoderna
    //    Nästa steg är att lägga till 3 metoder och 3 nya menyalternativ. Denna gång får du pröva att hitta på dina egna metoddefinitioner!
    // 5. Flytta avklarade uppgifter från tasks till completedTasks
    // 6. Visa allt i completedTasks
    // 7. Ta bort uppgifter från tasks
    /*
class Program
{
    static List<string> tasks = new List<string>();
    static List<string> completedTasks = new List<string>();
    static void Main(string[] args)
    {
        Welcome();
    } 
    static void Welcome()
    {
        Console.WriteLine("Welcome to the ToDoList");
        StartProgram();
    }
    static void StartProgram()
    {
        bool keepGoing = true;
        int menu;
        do
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("****** Welcome to the to do list! *****");
            Console.WriteLine("******* What do you want to do? *******");
            Console.WriteLine("***************************************");
            Console.WriteLine("* 1. Add a new to do to the list.     *");
            Console.WriteLine("* 2. Check the to do list.            *");
            Console.WriteLine("* 3.  Quit                            *");
            Console.WriteLine("***************************************");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    tasks = AddToDo(); 
                    break;
                case 2:
                    CheckToDo(tasks); 
                    break;
                case 3: 
                    Exit();
                    break;
            }
        } while (menu != 3);
    }
    static List<string> AddToDo()
    {
        Console.WriteLine("Write a To Do and then press enter to save it: ");
        string toDoIn = Console.ReadLine();
        tasks.Add(toDoIn);
        Console.Clear();
        return tasks;
    }
    static void CheckToDo(List<string> tasks)
    {
        int index = 1;
        foreach (var item in tasks)
        {
            Console.WriteLine($"{index++} {item}");
        }
        Console.WriteLine("Do you want to remove any ToDo's?");
        Console.WriteLine("1. Go to main menu. ");
        Console.WriteLine("2. Remove ToDo tasks ");
        int menu = Convert.ToInt32(Console.ReadLine());
        switch (menu)
        {
            case 1:
                StartProgram();
                break;
            case 2:
                IsFinished();
                break;            
        }
    }
    static void Exit()
    {
        Environment.Exit(0);
    }
    static void IsFinished()
    {
        int index = 1;
        foreach (var item in tasks)
        {
            Console.WriteLine($"{index++} {item}");
        }
        Console.WriteLine("Wich task do you want to remove?");
        int answer = Convert.ToInt32(Console.ReadLine());
        tasks.RemoveAt(answer -1);
    }
}
    */
    // ------------------------------------------------------------------------------------------------------------
    // *************************************** ÖVNINGSUPPGIFT 8 ***************************************************
    // ------------------------------------------------------------------------------------------------------------
    //1. Skapa en publik klass som reprsenterar en kurs.
    //2. Deklarera två publika fält, en sträng för namnet på kursen och en int för antalet studenter som läser kursen (t.ex. "Objektorienterad programmering i C#" och 56)
    //3. Lägg till propertier(get och set) för ett fält i taget.
    //4. Ändra så att dina fält är privata och testa så att det endast går att uppdatera dem genom dina properties.
    //5. Ändra på ditt property för antalet studenter så att om någon försöker mata in ett negativt antal studenter så sparas 0 istället.
    /*
    class Program
    {
        static void Main(string[] args)
        {
            //  1.Skapa en publik klass som reprsenterar en kurs.!
            //  2.Deklarera två publika fält, en sträng för namnet på kursen och en int för!
            //    antalet studenter som läser kursen(t.ex. "Objektorienterad programmering i C#" och 56)
            //  3.Lägg till propertier(get och set) för ett fält i taget.
            //  4.Ändra så att dina fält är privata och testa så att det endast går att uppdatera dem genom dina
            //    properties.
            //  5.Ändra på ditt property för antalet studenter så att om någon försöker mata in ett negativt
            //    antal studenter så sparas 0 istället.
             //CourseClass hej = new CourseClass("Gummikursen", 69);
             //hej.Course = "Latexkurs";
             //hej.Students = 15;
             //Console.WriteLine(hej.Course);
             //Console.WriteLine(hej.Students);
            CourseClass Course1 = new CourseClass(".Net Utvecklare", 57);
            Teacher minLarare = new Teacher("Håkan", 44, 187, Course1);
            minLarare.TeacherInfo(Course1);
        }
    }
    // 1.
    public class CourseClass  // Skapar en class med namn CourseClass. 
    {
        // 2. 4.
        private string course; //  
        private int students;  // 
        public CourseClass() // Vi skapar ett tomt fält för att 
        {
        }
        public CourseClass(string course, int students)
        {
            Course = course;
            Students = students;
        }
        // 3.
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public int Students
        {
            get { return students; }
            set
            {
                if (value > 0)
                {
                    students = value;
                }
                else
                {
                    students = 0;
                }
            }
        }
    }
    // -----------------------------------------------------------------------------------------------------------
    // *************************************** ÖVNINGSUPPGIFT 8 del 2*********************************************
    // -----------------------------------------------------------------------------------------------------------
    // 6. Skapa en klass human, och ge dem fält för namn, ålder och längd.
    // 7. Skapa en klass teacher som ärver ifrån human. 
    // 8. Ge teacher ett fält för kursen som du skapade i deluppgifter 1-5, och skriv en property för att ändra den. 
    //9. Skriv en metod för teacher som skriver ut "Hej mitt namn är {namn} och jag undervisar {antalet studenter} 
    //   i kursen {namnet på kursen}." till terminalen. 
    // 10. Gör en egen klass för student som läser en kurs och skriv sedan en metod där den studenten introducerar sig och vilken kurs hen läser.
    // 6.
    class Human
    {
        // 6.
        private string name;
        private int age;
        private int height;
        public Human()
        {
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
    }
    // 7
    class Teacher : Human
    {
        string teacherCourse;
        public Teacher(string name, int age, int height, CourseClass Course1)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.teacherCourse = Course1.Course;
        }
        // 8.
        public string TeacherCourse
        {
            get
            {
                return teacherCourse;
            }
            set
            {
                teacherCourse = "Poopface";
            }
        }
        public void TeacherInfo(CourseClass Course1)
        {
            Console.WriteLine($"Hej mitt namn är {Name} och jag undervisar {Course1.Students} elever i kursen {TeacherCourse} ");
        }
    } */

    //1. Skriv ett program som innehåller en klass som heter Show.
    //Denna klass ska innehålla generlla properties.
    //2. Skappa yterliggare 2 klasser, Serie och Movie och ge dessa mer
    //specifika properites.
    //1. Börja med att välkomna användaren
    //2. Börja Fylla i infomrationen för filmen/serien.
    //3. Visa en menu av alternativ.
    //4.Lista upp alla serier / filmer som man skapat.
    //5.Kunna välja en serie/film och se dess information.
    //Vill man fortsätta att utveckla programmet kan man göra ett
    //alternativ för visa enstaka kategorier eller år.Man kan även visa
    //både serier och filmer i en och samma lista.
    //6. Programmet ska repetera tills användaren väljer att avsluta.

    class Program
    {
        static List<Serie> mySeries = new List<Serie>();
        static List<Movie> myMovies = new List<Movie>();

        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            do
            {
                Console.WriteLine("Välkommen till NetFlex!");
                Console.WriteLine("Välj ett av följande alternativ för att skapa");
                Console.WriteLine("1. Serier");
                Console.WriteLine("2. Filmer");
                Console.WriteLine("3. Gå vidare");
             // Console.WriteLine("4. Pappa Robins trix");
                Console.WriteLine("4. Quit");
                int menu = Convert.ToInt32(Console.ReadLine());


                // Switch case (Sid 52 i boken)
                switch (menu)
                {
                    case 1:
                        mySeries = Serie.MakeSerie();
                        break;
                    case 2:
                        myMovies = Movie.CreateMovie();
                        break;
                    case 3:
                        ListItems();
                        break;
                    /*case 4:
                        GoWeb();
                        break;*/
                    case 4:
                        Quit();
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning PAPPSKALLE!");
                        break;

                }
                Console.ReadLine();
                Console.Clear();
            } while (true);

        }

        /*static void GoWeb()
        {

            Dictionary<string, int> håkansLåda = new Dictionary<string, int>();
            Dictionary<string, string> håkansFörråd = new Dictionary<string, string>();
            håkansLåda["Håkans strumpor"] = 10;
            håkansLåda["Knivar och pistoler"] = 200;
            håkansFörråd["verktygsbänken"] = "Yxor, massor av yxor..";

            Console.WriteLine(håkansLåda["Håkans strumpor"]);
            Console.WriteLine(håkansLåda["Knivar och pistoler"]);
            Console.WriteLine(håkansFörråd["verktygsbänken"]);

            håkansFörråd["verktygsbänken"].



            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.omdbapi.com/?t=Game+of+thrones&apikey=a1996ed6");
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            HttpWebResponse resp = request.GetResponse() as HttpWebResponse;


            Stream dataStream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string strResponse = reader.ReadToEnd();

            Console.WriteLine(strResponse);*/

            // Denna Metod skapar serier.
            // Denna metoden avslutar Consolen.

        static void Quit()
        {
            Environment.Exit(0);
        }
        public static void ListItems()
        {
            bool keepGoing = false;
            do
            {
                Console.WriteLine("Vilken lista vill du se");
                Console.WriteLine("1. Serier. ");
                Console.WriteLine("2 Filmer. ");
                Console.WriteLine("3. Tillbaks till Start.");
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Serie.showSeries(mySeries);
                        break;
                    case 2:
                        Movie.showMovies(myMovies);
                        break;
                    case 3:
                        Start();
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning PAPPSKALLE!");
                        break;
                }


            } while (keepGoing == true);
        }



    }
    // Show är Basklassen.
    class Show
    {   // Fields
        private string name;
        private int year;

        // Constructor.
        public Show()
        {

        }
        public Show(string name, int year)
        {
            this.name = name;
            this.year = year;

        }
        // Property.
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void Play() { Console.WriteLine($"Playing {Name}"); }
    }

    //----------------------------------------------------------------------------------------------------
    // Class
    // Klassen Serie ärver från classen Show.
    class Serie : Show
    {

        //----------------------------------------------------------------------------------------------------
        //Fields
        private int episodes;
        private int seasons;
        private string category;
        //----------------------------------------------------------------------------------------------------


        //----------------------------------------------------------------------------------------------------
        // Property
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public int Episodes
        {
            get { return episodes; }
            set { episodes = value; }
        }

        public int Seasons
        {
            get { return seasons; }
            set { seasons = value; }
        }
        //----------------------------------------------------------------------------------------------------



        //----------------------------------------------------------------------------------------------------
        // Constructor
        public Serie(int episodes, int seasons, string category, string name, int year) : base(name, year)
        {
            this.episodes = episodes;
            this.seasons = seasons;
            this.category = category;

        }
        // Tom Construktor, används för att användaren kanske är en retard som inte förstår något.
        public Serie()
        {

        }
        //----------------------------------------------------------------------------------------------------
        public static List<Serie> MakeSerie()
        {
            List<Serie> Series = new List<Serie>();
            Console.WriteLine("Hur många serier vill du skriva in?");
            int nrOfSeries = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nrOfSeries; i++)
            {
                Console.WriteLine("Namn:");
                string name = Console.ReadLine();
                Console.WriteLine("Årtal:");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Antal säsonger:");
                int seasons = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Antal avsnitt per säsong:");
                int episodes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kategori:");
                string category = Console.ReadLine();
                Series.Add(new Serie(seasons, episodes, category, name, year));
            }
            return Series;

        }
        public static void showSeries(List<Serie> minaSerier)
        {
            Console.WriteLine(Environment.UserName); 
          
            foreach (var serie in minaSerier)
            {
                Console.WriteLine($"{serie.Name}");
            }
            Program.ListItems();  // Skickar tillbaks användaren till metoden ListItems i klassen program.
        }

    }

    // Klassen Movie ärver från classen Show.
    class Movie : Show
    {
        private string mainActor;
        private int length;
        private string movieDirector;

        public Movie()
        {


        }

        public Movie(string Name, int Year, string MainActor, int Length, string MovieDirector)
        {
            this.Name = Name;
            this.Year = Year;
            this.MainActor = mainActor;
            this.Length = length;
            this.MovieDirector = movieDirector;
        }

        public string MainActor
        {
            get
            {
                return mainActor;
            }
            set
            {
                mainActor = value;
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public string MovieDirector
        {
            get
            {
                return movieDirector;
            }
            set
            {
                movieDirector = value;
            }
        }


        public static List<Movie> CreateMovie()
        {
            Console.WriteLine("How many movies do you want to add?");
            int amountOfMovies = Convert.ToInt32(Console.ReadLine());
            List<Movie> MyMovies = new List<Movie>();
            for (int i = 0; i < amountOfMovies; i++)
            {
                Console.Write("Name of the movie: ");
                string name = Console.ReadLine();
                Console.Write("Year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("MainActor: ");
                string mainActor = Console.ReadLine();
                Console.Write("Length of movie: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Movie director: ");
                string director = Console.ReadLine();

                MyMovies.Add(new Movie(name, year, mainActor, length, director));
            }
            return MyMovies;
        }
        public static void showMovies(List<Movie> minaFilmer)
        {
            Console.WriteLine(Environment.NewLine);
            foreach (var movie in minaFilmer)
            {
                Console.WriteLine($"{movie.Name}");
            }
            Program.ListItems();
        }

    }
}