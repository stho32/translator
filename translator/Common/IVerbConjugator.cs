namespace translator.Common
{
    public interface IVerbConjugator
    {
        string GetConjugatedForm(PersonalPronounEnum pronoun, string verb);
    }
}