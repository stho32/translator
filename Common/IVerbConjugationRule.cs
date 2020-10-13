namespace translator.Common
{
    public interface IVerbConjugationRule
    {
        string Conjugate(string verb, PersonalPronounEnum personalPronoun);
    }
}