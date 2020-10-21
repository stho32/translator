using System;
using translator.common.Common;
using translator.common.French.Verbs;
using translator.common.French;

namespace translator
{
    class Program
    {
        static void Main(string[] args)
        {
            var french = new FrenchFactory();
            var verbConjugator = french.GetVerbConjugator();
            var personalPronounInterpreter = french.GetPersonalPronounInterpreter();

            var pronounInput = "";
            while (true)
            {
                Console.WriteLine("");
                PersonalPronounEnum pronoun = PersonalPronounEnum.Unidentified;
                do {
                    Console.Write("Enter personal pronoun:");
                    try
                    {
                        pronounInput = System.Console.ReadLine();
                        pronoun = personalPronounInterpreter.GetFromString(pronounInput);
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } 
                while ( pronoun == PersonalPronounEnum.Unidentified );
                Console.WriteLine("You selected " + pronoun.ToString());

                Console.Write("Enter verb:");
                var verb = System.Console.ReadLine();

                try
                {
                    Console.WriteLine("");
                    Console.WriteLine(pronounInput + " " + verbConjugator.GetConjugatedForm(pronoun, verb, TenseEnum.Present));
                    Console.WriteLine("");
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
