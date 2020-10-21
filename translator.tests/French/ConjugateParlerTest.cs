using translator.common.Common;
using translator.common.French.Verbs;
using Xunit;

namespace translator.tests.French
{
    public class ConjugateParlerTest
    {
        private string conjugateVerb(PersonalPronounEnum personalPronoun)
        {
            var rule = new RegularVerbsEndingWithErPresentTenseVerbConjugationRule();
            return rule.Conjugate("parler", personalPronoun);
        }

        [Fact]
        public void TestConjugation() {
            Assert.Equal("parle", conjugateVerb(PersonalPronounEnum.FirstPersonSingularMasculine));
        }
    }
}