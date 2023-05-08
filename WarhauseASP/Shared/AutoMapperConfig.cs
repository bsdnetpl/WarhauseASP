using AutoMapper;

namespace WarhauseASP.Shared
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<UserDTO, User>();
            CreateMap<StateDto, State>();
            CreateMap<stan, State>() // d -> destinate, s -> Source 
                .ForMember(d => d.Quantity,
                opt => opt.MapFrom(s => s.Ilosc))
                .ForMember(d => d.DifferendVatTax,
                opt => opt.MapFrom(s => s.Roznica_Vat))
                .ForMember(d => d.CourseEuro,
                opt => opt.MapFrom(s => s.Kurs_Euro))
                .ForMember(d => d.CourseUsd,
                opt => opt.MapFrom(s => s.Kurs_Usd))
                .ForMember(d => d.Daty_Bay,
                opt => opt.MapFrom(s => s.Data_Zakupu))
                .ForMember(d => d.EAN,
                opt => opt.Ignore())
                .ForMember(d => d.QuantityInBox,
                opt => opt.MapFrom(s => s.Ilosc_W_Opakowanju))
                .ForMember(d => d.CodProduct,
                opt => opt.MapFrom(s => s.Kod_Produktu))
                .ForMember(d => d.EAN,
                opt => opt.MapFrom(s => s.Kod_Kreskowy))
                .ForMember(d => d.InvoiceNumber,
                opt => opt.MapFrom(s => s.Numer_Fv))
                .ForMember(d => d.PurchasePriceNetto,
                opt => opt.MapFrom(s => s.netto_Zakup))
                .ForMember(d => d.SellePriceBrutto,
                opt => opt.MapFrom(s => s.Cena))
                .ForMember(d => d.Profit,
                opt => opt.MapFrom(s => s.Zarobek))
                .ForMember(d => d.Id,
                opt => opt.Ignore())
                .ForMember(d => d.Name,
                opt => opt.MapFrom(s => s.Nazwa))
                .ForMember(d => d.TaxVat,
                opt => opt.MapFrom(s => s.Stawka_Vat));

        }
    }
}
