namespace translator.Common
{
    public interface IVerbConjugationRule
    {
        bool IsMatchingRule(string verb);
        string Conjugate(string verb, PersonalPronounEnum personalPronoun);
    }
}