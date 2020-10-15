namespace translator.Common
{
    public interface IPersonalPronounInterpreter
    {
        PersonalPronounEnum GetFromString(string pronounInput);
    }
}