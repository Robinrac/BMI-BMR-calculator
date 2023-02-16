using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //välkomstmeddelande
            Console.WriteLine("Hej och välkommen!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Det här är ett program som kommer att\nberäkna din BMI (body mass index) och BMR \n(basal metabolic rate)");
            Console.WriteLine("-----------------------------------");
 
            //user input ålder
            //store user input value
            Console.Write("Hur gammal är du? Skriv det här: ");
            double age = Convert.ToDouble(Console.ReadLine());

            //ram för ålder (max och min)
            if (age < 18 || age > 70)
            {
                //om värdet är utanför ramen
                Console.WriteLine("Den här kalkylatorn fungerar endast för dig som är mellan 18 och 70 år gammal\nTryck på vilken knapp som helst för att gå tillbaka...");
            }else
            {

            Console.WriteLine("För att räkna ut din BMI samt BMR så \nbehöver jag veta din längd, vikt och kön.\nVar snäll och skriv respektive enhet nedan:");

                //user input längd
                //store user input value
                    Console.Write("Längd (cm): ");
                    double heightCm = Convert.ToDouble(Console.ReadLine());

                //ram för längd (max och min)
                if (heightCm < 50 || heightCm > 220)
                {
                    //om värdet är utanför ramen
                    Console.WriteLine("Den här kalkylatorn fungerar endast för dig som är mellan 50cm och 220cm\nTryck på vilken knapp som helst för att gå tillbaka...");
                }
                else
                {
                    //user input vikt
                    //store user input value
                    Console.Write("Vikt (kg): ");
                    double weight = Convert.ToDouble(Console.ReadLine());

                    //ram för vikt (max och min)
                    if (weight < 10 || weight > 250)
                    {
                        //om värdet är utanför ramen 
                        Console.WriteLine("Den här kalkylatorn fungerar endast för dig som är mellan 10kg och 250kg\nTryck på vilken knapp som helst för att gå tillbaka...");
                    }
                    else
                    {
                        //user input kön
                        //store user input value
                        Console.Write("Är du man eller kvinna?");
                    string gender = Console.ReadLine();

                        //filtrera ut de värderna som inte är "man" eller "kvinna"
                    if (gender == "man" || gender == "kvinna")
                    {
                    //formel för BMI
                    //visar användare BMI värde
                    double heightM = heightCm / 100;
                    double BMI = (1.3 * weight) / (Math.Pow((heightM), 2.5));
                    Console.WriteLine("Din BMI är {0:f}", BMI);

                          //placera ut BMI värde i tabellen
                          //Visar användare BMI skala från tabell
                    if (BMI >= 40)
                    {
                        Console.WriteLine("Du är extremt överviktig");
                    }
                    else if (BMI >= 30 && BMI < 40)
                    {
                        Console.WriteLine("Du är kraftigt Överviktig");
                    }
                    else if (BMI >= 25 && BMI < 30)
                    {
                        Console.WriteLine("Du är överviktig");
                    }
                    else if (BMI >= 18.5 && BMI < 25)
                    {
                        Console.WriteLine("Du är sund och normal vikt");
                    }
                    else if (BMI < 18.5)
                        Console.WriteLine("Du är underviktig");

                        //räkna ut BMR
                        //separera manlig formel med kvinlig formel
                        //utgå från "gender" double
                    if (gender == "man")
                    {
                        //räkna manlig BMR formel
                        //Visa BMR värde (man)
                        double BMRman = (66.47 + (13.75 * weight ) + (5.003 * heightCm) - (6.755 * age));
                        Console.WriteLine("Din BMR som man är: {0:f}", BMRman);
                                //föra vidare koden till en ny "static void" / "method" för att undvika att skriva avslutande meddelande två gånger
                                Goodbye();
                    }
                    else if (gender == "kvinna")
                    {
                        //räkna ut kvinlig BMR formel
                        //Visa BMR värde (kvinna)
                        double BMRwoman = (655.1 + (9.563 * weight) + (1.85 * heightCm) - (4.676 * age));
                        Console.WriteLine("Din BMR som kvinna är: {0:f}", BMRwoman);
                                //föra vidare koden till en ny "static void" / "method" för att undvika att skriva avslutande meddelande två gånger
                                Goodbye();
                    }


                }
                else
                {
                            //om user input inte är "man" eller "kvinna" för kön
                    Console.Write("Du behöver välja ett giltigt kön!\nTryck på vilken knapp som helst för att gå tillbaka...");
                    
                }
                }
                    }

                static void Goodbye()
                {
                    //ny "static void" / "method" med hejdå meddelande
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Tack för att du använde den här BMI (body mass index) och BMR (basal metabolic rate) kalkylatorn.\nHejdå och ha det så bra!");
                }
                
            }
            // Console.ReadLine(); för att hålla text borta från consolen tills den avslutas
            Console.ReadLine();
        }
    }
}