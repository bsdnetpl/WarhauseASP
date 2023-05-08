using System.ComponentModel.DataAnnotations;

namespace WarhauseASP.Shared
{
    public class stan
    {


        public int Id { get; set; }
        [Key]
        public string Nazwa { get; set; } = null!;

        public int Kod_Kreskowy { get; set; }

        public double Ilosc { get; set; }

        public double Zarobek { get; set; }

        public double netto_Zakup { get; set; }

        public double Kurs_Euro { get; set; }

        public double Kurs_Usd { get; set; }

        public double Cena { get; set; }

        public double Cena_Netto { get; set; }

        public string Stawka_Vat { get; set; } = null!;

        public string Text { get; set; } = null!;

        public float Ilosc_W_Opakowanju { get; set; }

        public string Data_Zakupu { get; set; } = null!;

        public string Numer_Fv { get; set; } = null!;

        public string Kod_Produktu { get; set; } = null!;

        public double Roznica_Vat { get; set; }

        public string Gtu { get; set; } = null!;

    }
}
