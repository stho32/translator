using System.Collections.Generic;

namespace translator.Common
{
    internal class VerbConjugator : IVerbConjugator
    {
        private readonly List<IVerbConjugationRule> rules;

        public VerbConjugator(List<IVerbConjugationRule> rules)
        {
            this.rules = rules;
        }

        public string GetConjugatedForm(PersonalPronounEnum pronoun, string verb)
        {
            foreach (var rule in rules) {
                if ( rule.IsMatchingRule(verb) ) {
                    return rule.Conjugate(verb, pronoun);
                }
            }

            throw new System.Exception("I do not know how to conjugate this yet. Please implement more rules.");
        }
    }
}