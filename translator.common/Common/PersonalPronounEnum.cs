namespace translator.common.Common
{
    public enum PersonalPronounEnum {
        Unidentified,

        FirstPersonSingular, 
        FirstPersonSingularMasculine, // je, me, ich
        FirstPersonSingularFeminine, // je, me, ich

        SecondPersonSingular,
        SecondPersonSingularMasculine, // tu, you, du
        SecondPersonSingularFeminine, // tu, you, du

        ThirdPersonSingularMasculine, // il, him, er
        ThirdPersonSingularFeminine, // elle, her, sie
        ThirdPersonSingularImpersonal, // on, one - people - they, man

        FirstPersonPluralMasculine, // nous, we, wir
        FirstPersonPluralFeminine, // nous, we, wir

        SecondPersonPluralMasculine, // vous, you, ihr
        SecondPersonPluralFeminine, // vous, you, ihr

        ThirdPersonPluralMasculine, // ils, they, sie
        ThirdPersonPluralFeminine, // elles, they, sie        
        FirstPersonPlural,
        SecondPersonPlural,
    }
}