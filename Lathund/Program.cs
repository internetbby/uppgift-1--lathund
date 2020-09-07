using System;

namespace Lathund
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title= "Synergy";
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Hello Dr. Menton! Wonderful to see you again");
            Console.ReadLine(); 
            System.Console.WriteLine("...");
            Console.ReadLine();
            System.Console.WriteLine("You're not Dr.Menton, are you?"); 
            
            System.Console.WriteLine("Tell me, what's your name stranger?");
            string nameAnswer = Console.ReadLine();
            string name = nameAnswer.ToUpper();

            while ( name == "DR.MENTON"){
                System.Console.WriteLine("you're a prankster huh? tell me your real name");
                nameAnswer = Console.ReadLine();
                name = nameAnswer.ToUpper();
            } // checkar om man skriver in Dr.menton så man inte kopierar namnet 

            while (name == ""){
                System.Console.WriteLine("don't be shy, tell me your name");
                nameAnswer = Console.ReadLine();
                name = nameAnswer.ToUpper();
            }
            // checkar om texten är tom, borde göra det lite snyggare 

            /*name = ConsoleColor.Cyan; */ 

            System.Console.Write("oh it's ");
            // byter färg för namnet, 
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write(name);
            //byter tbx färg
            Console.ForegroundColor=ConsoleColor.White;
            Console.Write(" is it? What a pretty name");
            Console.ReadLine();

            System.Console.WriteLine("So stranger, since you're obviously not Dr.Menton, do you mind me asking how did you access his computer");
            System.Console.WriteLine(" [A] I don't know   [B] I found it laying around   [C] wait.. why is his computer asking me questions?");
            string firstQuestionAnswer = Console.ReadLine();

            string firstQuestion = firstQuestionAnswer.ToUpper();

            while ( firstQuestion != "A" && firstQuestion!="B" && firstQuestion != "C")
            {
                System.Console.WriteLine("invalid select, please try again");
                firstQuestionAnswer = Console.ReadLine();
                firstQuestion = firstQuestionAnswer.ToUpper();
            }// checkar om spelaren valde annat än a b c 


            if (firstQuestion == "A" || firstQuestion == "B")
            {
                System.Console.WriteLine("well... that's concerning. Dr.Menton isn't the type of person to leave his personal belongings in the hands of strangers");
            }

            //spelaren valde c
            else if(firstQuestion == "C")
            {
                System.Console.WriteLine("I'm the personal AI Dr.Menton developed, tasked with making his life easier. Now tell me, how did you find me?");
              
                //repeterar första frågan men tar bort c alternativet
                System.Console.WriteLine(" [A] I don't know   [B] I found it laying around");
                string secondQuestionAnswer = Console.ReadLine();
                string secondQuestion = secondQuestionAnswer.ToUpper();

                while (secondQuestion != "A" && secondQuestion != "B")
                {
                    System.Console.WriteLine("invalid selection, please try again");
                    secondQuestionAnswer = Console.ReadLine();
                    secondQuestion = secondQuestionAnswer.ToUpper();
                }
                
                if (secondQuestion == "A" || secondQuestion == "B")
                {
                System.Console.WriteLine("well... that's concerning. Dr.Menton isn't the type of person to leave his personal belongings in the hands of strangers");
                Console.ReadLine();
                }
            }
            //rensar skärmen
            Console.Clear();

            System.Console.WriteLine("I know this may be a lot to ask of a stranger, but could you please help finding Dr.Menton?");
            System.Console.WriteLine("I'm sure some of his files may reveal where he is");
            System.Console.WriteLine(" [A] Yes, i'll help   [B] no, i wont help");

            string helpingOutAnswer = Console.ReadLine();
            string helpingOut = helpingOutAnswer.ToUpper();

            //lägg till så man bara kan välja A eller B

            while (helpingOut != "A" && helpingOut != "B"){
                System.Console.WriteLine("invalid answer, please try again");
                helpingOutAnswer = Console.ReadLine();
                helpingOut = helpingOutAnswer.ToUpper();
            }

            if  (helpingOut == "B")
            {
                System.Console.WriteLine("oh i see.. Thanks anyway");
            }
            else if (helpingOut == "A")
            {
                System.Console.WriteLine("Thank you so much! I'll give you access to his files, maybe you can find something");
                Console.ReadLine();

                

                
            }

            
            if (helpingOut == "A")
            {
                System.Console.WriteLine("[1] pictures");
                System.Console.WriteLine("[2] documents");
                System.Console.WriteLine("[3] Log-in Dates");
                System.Console.WriteLine("[4] xxxxx ");
                System.Console.WriteLine("");
                System.Console.WriteLine("how strange... I can't seem to access his last files. Maybe if you look into his other documents you'll find the key to access them");
            }
            

            Console.ReadLine();

        }
    }
}
