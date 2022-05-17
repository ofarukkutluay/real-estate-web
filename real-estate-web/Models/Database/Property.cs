using System.ComponentModel.DataAnnotations;

namespace real_estate_web.Models.Database
{
    public class Property : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int MahalleId { get; set; }
        public int? SokakId { get; set; }
        public double? LocationLat { get; set; }
        public double? LocationLon { get; set; }
        public int PropertyTypeId { get; set; }
        public int StatusId { get; set; }
        public int BrutMetre { get; set; }
        public int NetMetre { get; set; }
        public ushort ToplamKat { get; set; }
        public ushort BulunduguKat { get; set; }
        public ushort BinaYasi { get; set; }
        public ushort OdaSayisi { get; set; }
        public ushort SalonSayisi { get; set; }
        public ushort? BanyoSayisi { get; set; }
        public ushort? OtoparkSayisi { get; set; }
        public ushort? BalkonSayisi { get; set; }
        public int IsitmaTipiId { get; set; }
        public int InternetTipiId { get; set; }
        public int CepheId { get; set; }
        public string? Manzara { get; set; }
        public bool? AkilliEvMi { get; set; }
        public bool EsyaliMi { get; set; }
        public bool SiteIcerisindeMi { get; set; }
        public string? SiteAdi { get; set; }
        public int KullanimDurumuId { get; set; }
        public int TapuDurumuId { get; set; }

        public double Price { get; set; }
        public double? Aidat { get; set; }
        public bool KirediyeUygunMu { get; set; }
        public string? YoutubeLink { get; set; }
        public int AgentId { get; set; }
        public string KonumIFrame { get; set; } = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d192697.79327595135!2d28.8720964464606!3d41.00549580940238!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caa7040068086b%3A0xe1ccfe98bc01b0d0!2zxLBzdGFuYnVs!5e0!3m2!1str!2str!4v1651089326725!5m2!1str!2str";

    }
}
