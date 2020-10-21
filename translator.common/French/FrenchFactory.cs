using System;
using System.Collections.Generic;
using translator.common.Common;
using translator.common.French.Verbs;

namespace translator.common.French
{
    public class FrenchFactory
    {
        public IPersonalPronounInterpreter GetPersonalPronounInterpreter()
        {
            return new FrenchPersonalPronounInterpreter();
        }

        public IVerbConjugator GetVerbConjugator()
        {
            var rules = new List<IVerbConjugationRule>();
            rules.Add(new French.Verbs.RegularVerbsEndingWithErVerbConjugationRule());

            return new VerbConjugator(rules);
        }
    }
}