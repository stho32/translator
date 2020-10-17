namespace translator.common.Common
{
    public interface IVerbConjugator
    {
        string GetConjugatedForm(PersonalPronounEnum pronoun, string verb);
    }
}