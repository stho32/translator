using System;
using translator.common.Common;

namespace translator.common.French
{
    internal class FrenchPersonalPronounInterpreter : IPersonalPronounInterpreter
    {
        public PersonalPronounEnum GetFromString(string pronounInput)
        {
            var pronounWithoutCasing = pronounInput.ToLower();

            switch (pronounWithoutCasing) {
                case "je" : 
                    return PersonalPronounEnum.FirstPersonSingular;
                case "tu" : 
                    return PersonalPronounEnum.SecondPersonSingular;
                case "il" : 
                    return PersonalPronounEnum.ThirdPersonSingularMasculine;
                case "elle" :
                    return PersonalPronounEnum.ThirdPersonSingularFeminine;
                case "nous" : 
                    return PersonalPronounEnum.FirstPersonPlural;
                case "vous" : 
                    return PersonalPronounEnum.SecondPersonPlural;
                case "ils" : 
                    return PersonalPronounEnum.ThirdPersonPluralMasculine;
                case "elles" : 
                    return PersonalPronounEnum.ThirdPersonPluralFeminine;
            }

            throw new Exception("Sorry, but I could not find out which pronoun you mean.");
        }
    }
}