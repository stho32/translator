using translator.Common;
using translator.French.Verbs;
using Xunit;

namespace translator.French.Tests
{
    public class ConjugateParlerTest
    {
        private string conjugateVerb(PersonalPronounEnum personalPronoun)
        {
            var rule = new RegularVerbsEndingWithErVerbConjugationRule();
            return rule.Conjugate("parler", personalPronoun);
        }

        [Fact]
        public void TestConjugation() {
            Assert.Equal("parle", conjugateVerb(PersonalPronounEnum.FirstPersonSingularMasculine));
        }
    }
}