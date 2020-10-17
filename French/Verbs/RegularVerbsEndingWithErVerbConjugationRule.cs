using translator.Common;

namespace translator.French.Verbs
{
    public class RegularVerbsEndingWithErVerbConjugationRule : IVerbConjugationRule
    {
        public string Conjugate(string verb, PersonalPronounEnum personalPronoun) {
            var stem = verb.Remove(verb.Length -2);

            switch (personalPronoun) {
                case PersonalPronounEnum.FirstPersonSingular:
                    return stem + "e";
                case PersonalPronounEnum.FirstPersonSingularMasculine :
                    return stem + "e";
                case PersonalPronounEnum.FirstPersonSingularFeminine : 
                    return stem + "e";

                case PersonalPronounEnum.SecondPersonSingular:
                    return stem + "es";
                case PersonalPronounEnum.SecondPersonSingularMasculine : 
                    return stem + "es";
                case PersonalPronounEnum.SecondPersonSingularFeminine :
                    return stem + "es";

                case PersonalPronounEnum.ThirdPersonSingularMasculine :
                    return stem + "e";
                case PersonalPronounEnum.ThirdPersonSingularFeminine :
                    return stem + "e";
                case PersonalPronounEnum.ThirdPersonSingularImpersonal :
                    return stem + "e";

                case PersonalPronounEnum.FirstPersonPluralMasculine :
                    return stem + "ons";
                case PersonalPronounEnum.FirstPersonPluralFeminine :
                    return stem + "ons";

                case PersonalPronounEnum.SecondPersonPluralMasculine :
                    return stem + "ez";
                case PersonalPronounEnum.SecondPersonPluralFeminine :
                    return stem + "ez";

                case PersonalPronounEnum.ThirdPersonPluralMasculine :
                    return stem + "ent";
                case PersonalPronounEnum.ThirdPersonPluralFeminine :
                    return stem + "ent";

                case PersonalPronounEnum.FirstPersonPlural :
                    return stem + "ons";
                
                case PersonalPronounEnum.SecondPersonPlural :
                    return stem + "ez";
            }

            throw new System.Exception("Unknown conjugation: " + personalPronoun + " , " + verb);
        }

        public bool IsMatchingRule(string verb)
        {
            return (verb.EndsWith("er"));
        }
    }
}