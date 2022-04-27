namespace real_estate_web.Models.Database.Dtos
{
    public class PropertyDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public double? LocationLat { get; set; }
        public double? LocationLon { get; set; }
        public string PropertyType { get; set; }
        public string Status { get; set; }
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
        public string IsitmaTipi { get; set; }
        public string InternetTipi { get; set; }
        public string Cephe { get; set; }
        public string? Manzara { get; set; }
        public bool? AkilliEvMi { get; set; }
        public bool EsyaliMi { get; set; }
        public bool SiteIcerisindeMi { get; set; }
        public string? SiteAdi { get; set; }
        public string KullanimDurumu { get; set; }
        public string TapuDurumu { get; set; }
        public double Price { get; set; }
        public double? Aidat { get; set; }
        public bool KirediyeUygunMu { get; set; }
        public string? YoutubeLink { get; set; }
        public string Agent { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int MahalleId { get; set; }
        public int SokakId { get; set; }
        public int PropertyTypeId { get; set; }
        public int StatusId { get; set; }
        public int IsitmaTipiId { get; set; }
        public int InternetTipiId { get; set; }
        public int CepheId { get; set; }
        public int KullanimDurumuId { get; set; }
        public int TapuDurumuId { get; set; }
        public int AgentId { get; set; }
        public string BasePhotoPath { get; set; }
        public int PhotoCount { get; set; }
        public string KonumIFrame { get; set; }

    }
}
