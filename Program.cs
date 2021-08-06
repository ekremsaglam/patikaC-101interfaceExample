using System;

namespace interfaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus fordFocus = new Focus();
            Console.WriteLine(fordFocus.hangiMarkanınAraci()+" Tekerlek sayısı : " + fordFocus.kacTekerlektenOlusur() + " aracın standart rengi : " + fordFocus.standartRengiNe());
        }
    }
}
