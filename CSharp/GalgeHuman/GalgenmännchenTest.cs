using Xunit;

namespace GalgeHuman
{
    public class Galgenm�nnchenTest
    {
        [Fact]
        public void RateBuchstabe_input_null_expected_ArgumentNullException()
        {
            const string ein1 = "a";
            const string ein2 = "A";
            if (ein1 == ein2)
            {
                
            }

            if (ein1.Equals(ein2,StringComparison.InvariantCultureIgnoreCase))
            {
                
            }

            if (string.Equals(ein1,ein2,StringComparison.InvariantCultureIgnoreCase))
            {
                
            }

            //arrange

            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => new Galgenm�nnchen(null));
        }

        [Fact]
        public void RateBuchstabe_input_stringEmpty_expected_ArgumentException()
        {
            //arrange

            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Galgenm�nnchen(string.Empty));

        }

        [Fact]
        public void RateBuchstabe_input_EinLeerzeichen_expected_ArgumentException()
        {
            //arrange

            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Galgenm�nnchen(" "));
        }

        [Fact]
        public void RateBuchstabe_input_VariableAnzahlBuchstabenAberNurLeerzeichen_expected_ArgumentException()
        {
            //arrange

            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Galgenm�nnchen("          "));
        }

        [Fact]
        public void RateBuchstabe_input_WortMeierhofer_BuchstabeNothing_expected_DefaultListe()
        {
            //arrange
            const string gesuchtesWort = "Meierhofer";

            //act
            var galgenm�nnchen = new Galgenm�nnchen(gesuchtesWort);
            var result = galgenm�nnchen.RateBuchstabe(new char());

            //assert
            Assert.Equal("".PadLeft(gesuchtesWort.Length,'_'),result);
        }

        [Fact]
        public void RateBuchstabe_input_WortMeierhofer_BuchstabeI_expected_IG�ltigerBuchstabe()
        {
            //arrange
            const string gesuchtesWort = "Meierhofer";

            //act
            var galgenm�nnchen = new Galgenm�nnchen(gesuchtesWort);
            var result = galgenm�nnchen.RateBuchstabe('i');

            //assert
            Assert.Equal("__i_______", result);
        }

        [Fact]
        public void RateBuchstabe_input_WortMeierhofer_Buchstabegro�esI_expected_IG�ltigerBuchstabe()
        {
            //arrange
            const string gesuchtesWort = "Meierhofer";

            //act
            var galgenm�nnchen = new Galgenm�nnchen(gesuchtesWort);
            var result = galgenm�nnchen.RateBuchstabe('I');

            //assert
            Assert.Equal("__i_______", result);
        }
    }
}