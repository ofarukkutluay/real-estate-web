using real_estate_web.Models.Database.Dtos;

namespace real_estate_web.Models.ViewModel
{
    public class PropertyVM
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
        public bool AkilliEvMi { get; set; }
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
        public string KonumIFrame { get; set; } = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d192697.79327595135!2d28.8720964464606!3d41.00549580940238!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caa7040068086b%3A0xe1ccfe98bc01b0d0!2zxLBzdGFuYnVs!5e0!3m2!1str!2str!4v1651089326725!5m2!1str!2str";

        public int PhotoCount { get; set; }
        public string BasePhotoPath { get; set; }
        public IEnumerable<string> PropertyPhotoPaths { get; set; }
        public AgentDto AgentDto { get; set; }
        public bool BasePhoto { get; set; }
        public List<IFormFile> PropertyPhotos { get; set; }

    }
}
