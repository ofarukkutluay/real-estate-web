namespace real_estate_web.Models.Database
{
    public class Property : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int MahalleId { get; set; }
        public int SokakId { get; set; }
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

    }
}
