namespace interfaceExamples{
    public class Focus : IOtomobil
    {
        public Marka hangiMarkan─▒nAraci()
        {
            return Marka.Ford;
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