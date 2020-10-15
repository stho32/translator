using System;
using System.Collections.Generic;
using translator.Common;

namespace translator.French
{
    public class FrenchFactory
    {
        internal IPersonalPronounInterpreter GetPersonalPronounInterpreter()
        {
            return new FrenchPersonalPronounInterpreter();
        }

        internal IVerbConjugator GetVerbConjugator()
        {
            var rules = new List<IVerbConjugationRule>();
            rules.Add(new French.Verbs.RegularVerbsEndingWithErVerbConjugationRule());

            return new VerbConjugator(rules);
        }
    }
}