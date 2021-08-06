namespace interfaceExamples{
    public class Corollo : IOtomobil
    {
        public Marka hangiMarkanınAraci()
        {
            return Marka.Toyota;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk standartRengiNe()
        {
            return Renk.Gri;
        }
    }
}