namespace translator.common.Common
{
    public interface IVerbConjugationRule
    {
        bool IsMatchingRule(string verb, TenseEnum tense);
        string Conjugate(string verb, PersonalPronounEnum personalPronoun);
    }
}