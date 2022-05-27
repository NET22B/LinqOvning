﻿using System;

namespace LinqOvning
{
    internal class Program
    {
        //Extra Övning Linq

        //Extensions
        //1. Skapa en extension metod som returnerar alla namn så att alla börjar med en stor bokstav
        //2. Skapa en extension som lägger till valfritt efternamn på en person som så deras Name består av för och efternamn separerat med mellanslag

        //Med hjälp av Linq
        //3. Ta fram alla personer med namnet Nisse
        //4. Returnera alla personers ålder
        //5. Ta fram alla personer med namnet Nisse och returnera deras sammanlagda ålder
        //6. Vilka personers namn slutar på bokstaven a
        //7. Returnera alla namn på de personer som är över 60år
        //8. Ta fram hur många unika namn det finns
        //9. Returnera alla personers ålder samt hur många bokstäver deras namn består av
        //10. Vilken person är äldst
        //11. Vilken person har längst namn
        //12. Hur många personer har ett namn som består av 4 bokstäver
        //13. Returnera alla personer som har ett dubbelnamn
        //14. Returnera en kollektion som består av alla unika namn och hur många som har det namnet
        //15. Sumera alla jämna tal i GetNumbers
        //16. Vilka personers ålder återfinns i GetNumbers kollektionen


        static void Main(string[] args)
        {
           
        }

        private static IEnumerable<int> GetNumbers()
        {
            return Enumerable.Range(0, 40).ToArray();
        }

        private static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
                {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Lisa-Olsson",   45),
                new("Sophia-Magdalena", 32),
            };
        }
    }
}
