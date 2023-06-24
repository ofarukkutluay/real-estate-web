using real_estate_web.Data.Abstract;
using real_estate_web.Data.EntityFramework.Common;
using real_estate_web.Models.Database;
using real_estate_web.Models.Database.Dtos;

namespace real_estate_web.Data.EntityFramework
{
    public class EfPropertyDal : EfEntityRepositoryBase<Property, RealEstateDbContext>, IPropertyRepository
    {
        public EfPropertyDal(RealEstateDbContext context) : base(context)
        {
        }

        public IEnumerable<PropertyDto> GetListPropertyDto()
        {
            var result = from p in Context.Properties
                         join c in Context.Cities on p.IlId equals c.Id
                         join d in Context.Districts on p.IlceId equals d.Id
                         join nb in Context.Neighborhoods on p.MahalleId equals nb.Id
                         join a in Context.Agents on p.AgentId equals a.Id
                         select new PropertyDto()
                         {
                             Id = p.Id,
                             Il = c.Name,
                             IlId = p.IlId,
                             Ilce = d.Name,
                             IlceId = p.IlceId,
                             Mahalle = nb.Name,
                             MahalleId = p.MahalleId,
                             Sokak = (from s in Context.Streets where p.SokakId == s.Id select s).First().Name,
                             SokakId = p.SokakId,
                             Title = p.Title,
                             Description = p.Description,
                             LocationLat = p.LocationLat,
                             LocationLon = p.LocationLon,
                             PropertyType = p.PropertyType,
                             Status = p.Status,
                             BrutMetre = p.BrutMetre,
                             NetMetre = p.NetMetre,
                             ToplamKat = p.ToplamKat,
                             BulunduguKat = p.BulunduguKat,
                             BinaYasi = p.BinaYasi,
                             OdaSayisi = p.OdaSayisi,
                             SalonSayisi = p.SalonSayisi,
                             BanyoSayisi = p.BanyoSayisi,
                             OtoparkSayisi = p.OtoparkSayisi,
                             BalkonSayisi = p.BalkonSayisi,
                             IsitmaTipi = p.IsitmaTipi,
                             InternetTipi = p.InternetTipi,
                             Cephe = p.Cephe,
                             Manzara = p.Manzara,
                             AkilliEvMi = p.AkilliEvMi,
                             EsyaliMi = p.EsyaliMi,
                             SiteIcerisindeMi = p.SiteIcerisindeMi,
                             SiteAdi = p.SiteAdi,
                             KullanimDurumu = p.KullanimDurumu,
                             TapuDurumu = p.TapuDurumu,
                             Price = p.Price,
                             Aidat = p.Aidat,
                             KirediyeUygunMu = p.KirediyeUygunMu,
                             YoutubeLink = p.YoutubeLink,
                             Agent = $"{a.FirstName} {a.LastName}",
                             AgentId = p.AgentId,
                             PropertyListiningId = p.PropertyListiningId,
                             ListingStoreName = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingStoreName,
                             ListingUserName = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingUserName,
                             ListingPhoneNumbers = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingPhoneNumbers,
                             Listinglink = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).Listinglink,
                             KonumIFrame = p.KonumIFrame,
                             CreatedDate = p.CreatedDate,
                             UpdatedDate = p.UpdatedDate,
                             BasePhotoPath = (from pp in Context.PropertyPhotos where pp.PropertyId == p.Id select pp).SingleOrDefault(x => x.BasePhoto).Path,
                             PhotoCount = (from pp in Context.PropertyPhotos where pp.PropertyId == p.Id select pp).Count()
                         };

            return result;
        }

        public PropertyDto GetPropertyDto(int id)
        {
            var result = from p in Context.Properties
                         join c in Context.Cities on p.IlId equals c.Id
                         join d in Context.Districts on p.IlceId equals d.Id
                         join nb in Context.Neighborhoods on p.MahalleId equals nb.Id
                         join a in Context.Agents on p.AgentId equals a.Id
                         where p.Id == id
                         select new PropertyDto()
                         {
                             Id = p.Id,
                             Il = c.Name,
                             IlId = p.IlId,
                             Ilce = d.Name,
                             IlceId = p.IlceId,
                             Mahalle = nb.Name,
                             MahalleId = p.MahalleId,
                             Sokak = (from s in Context.Streets where p.SokakId == s.Id select s).First().Name,
                             SokakId = p.SokakId,
                             Title = p.Title,
                             Description = p.Description,
                             LocationLat = p.LocationLat,
                             LocationLon = p.LocationLon,
                             PropertyType = p.PropertyType,
                             Status = p.Status,
                             BrutMetre = p.BrutMetre,
                             NetMetre = p.NetMetre,
                             ToplamKat = p.ToplamKat,
                             BulunduguKat = p.BulunduguKat,
                             BinaYasi = p.BinaYasi,
                             OdaSayisi = p.OdaSayisi,
                             SalonSayisi = p.SalonSayisi,
                             BanyoSayisi = p.BanyoSayisi,
                             OtoparkSayisi = p.OtoparkSayisi,
                             BalkonSayisi = p.BalkonSayisi,
                             IsitmaTipi = p.IsitmaTipi,
                             InternetTipi = p.InternetTipi,
                             Cephe = p.Cephe,
                             Manzara = p.Manzara,
                             AkilliEvMi = p.AkilliEvMi,
                             EsyaliMi = p.EsyaliMi,
                             SiteIcerisindeMi = p.SiteIcerisindeMi,
                             SiteAdi = p.SiteAdi,
                             KullanimDurumu = p.KullanimDurumu,
                             TapuDurumu = p.TapuDurumu,
                             Price = p.Price,
                             Aidat = p.Aidat,
                             KirediyeUygunMu = p.KirediyeUygunMu,
                             YoutubeLink = p.YoutubeLink,
                             Agent = $"{a.FirstName} {a.LastName}",
                             AgentId = p.AgentId,
                             PropertyListiningId = p.PropertyListiningId,
                             ListingStoreName = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingStoreName,
                             ListingUserName = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingUserName,
                             ListingPhoneNumbers = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingPhoneNumbers,
                             Listinglink = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).Listinglink,
                             KonumIFrame = p.KonumIFrame,
                             CreatedDate = p.CreatedDate,
                             UpdatedDate = p.UpdatedDate,
                             BasePhotoPath = (from pp in Context.PropertyPhotos where pp.PropertyId == p.Id select pp).SingleOrDefault(x => x.BasePhoto).Path,
                             PhotoCount = (from pp in Context.PropertyPhotos where pp.PropertyId == p.Id select pp).Count()
                         };

            return result.FirstOrDefault();
        }

        public IEnumerable<PropertyDto> GetListAgentIdPropertyDto(int agentId)
        {
            var result = from p in Context.Properties
                         join c in Context.Cities on p.IlId equals c.Id
                         join d in Context.Districts on p.IlceId equals d.Id
                         join nb in Context.Neighborhoods on p.MahalleId equals nb.Id
                         join a in Context.Agents on p.AgentId equals a.Id
                         where p.AgentId == agentId
                         select new PropertyDto()
                         {
                             Id = p.Id,
                             Il = c.Name,
                             IlId = p.IlId,
                             Ilce = d.Name,
                             IlceId = p.IlceId,
                             Mahalle = nb.Name,
                             MahalleId = p.MahalleId,
                             Sokak = (from s in Context.Streets where p.SokakId == s.Id select s).First().Name,
                             SokakId = p.SokakId,
                             Title = p.Title,
                             Description = p.Description,
                             LocationLat = p.LocationLat,
                             LocationLon = p.LocationLon,
                             PropertyType = p.PropertyType,
                             Status = p.Status,
                             BrutMetre = p.BrutMetre,
                             NetMetre = p.NetMetre,
                             ToplamKat = p.ToplamKat,
                             BulunduguKat = p.BulunduguKat,
                             BinaYasi = p.BinaYasi,
                             OdaSayisi = p.OdaSayisi,
                             SalonSayisi = p.SalonSayisi,
                             BanyoSayisi = p.BanyoSayisi,
                             OtoparkSayisi = p.OtoparkSayisi,
                             BalkonSayisi = p.BalkonSayisi,
                             IsitmaTipi = p.IsitmaTipi,
                             InternetTipi = p.InternetTipi,
                             Cephe = p.Cephe,
                             Manzara = p.Manzara,
                             AkilliEvMi = p.AkilliEvMi,
                             EsyaliMi = p.EsyaliMi,
                             SiteIcerisindeMi = p.SiteIcerisindeMi,
                             SiteAdi = p.SiteAdi,
                             KullanimDurumu = p.KullanimDurumu,
                             TapuDurumu = p.TapuDurumu,
                             Price = p.Price,
                             Aidat = p.Aidat,
                             KirediyeUygunMu = p.KirediyeUygunMu,
                             YoutubeLink = p.YoutubeLink,
                             Agent = $"{a.FirstName} {a.LastName}",
                             AgentId = p.AgentId,
                             PropertyListiningId = p.PropertyListiningId,
                             ListingStoreName = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingStoreName,
                             ListingUserName = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingUserName,
                             ListingPhoneNumbers = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).ListingPhoneNumbers,
                             Listinglink = Context.PropertyListingDetails.FirstOrDefault(pl => pl.Id == p.PropertyListiningId).Listinglink,
                             KonumIFrame = p.KonumIFrame,
                             CreatedDate = p.CreatedDate,
                             UpdatedDate = p.UpdatedDate,
                             BasePhotoPath = (from pp in Context.PropertyPhotos where pp.PropertyId == p.Id select pp).SingleOrDefault(x => x.BasePhoto).Path,
                             PhotoCount = (from pp in Context.PropertyPhotos where pp.PropertyId == p.Id select pp).Count()
                         };

            return result;
        }
    }
}
