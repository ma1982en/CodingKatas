namespace GalgeHuman
{
    public class Galgenmännchen
    {
        private char[] gesuchtesWort;

        public Galgenmännchen(string gesuchtesWort)
        {
            if (string.IsNullOrWhiteSpace(gesuchtesWort) || (gesuchtesWort.Length == 1))
            {
                if (gesuchtesWort== null)
                {
                    throw new ArgumentNullException();
                }

                throw new ArgumentException("Ungültige Eingabe");
            }
            this.gesuchtesWort = gesuchtesWort.ToCharArray();
        }

        public string RateBuchstabe(char buchstabe)
        {
            if (default == buchstabe) return "".PadLeft(gesuchtesWort.Length, '_');
            var resultWort = new char[this.gesuchtesWort.Length];
            for (var i = 0; i < this.gesuchtesWort.Length; i++)
            {
                if (gesuchtesWort[i].Equals(buchstabe))
                {
                    resultWort[i] = buchstabe;
                }
                else
                {
                    resultWort[i] = '_';
                }
            }

            return new string(resultWort);

        }
    }
}