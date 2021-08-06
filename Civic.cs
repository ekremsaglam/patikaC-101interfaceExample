namespace interfaceExamples{
    public class Civic : IOtomobil
    {
        public Marka hangiMarkanınAraci()
        {
            return Marka.Honda;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk standartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}