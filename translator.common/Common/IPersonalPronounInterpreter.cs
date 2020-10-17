namespace translator.common.Common
{
    public interface IPersonalPronounInterpreter
    {
        PersonalPronounEnum GetFromString(string pronounInput);
    }
}