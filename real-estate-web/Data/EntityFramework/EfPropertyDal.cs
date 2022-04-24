using real_estate_web.Data.Abstract;
using real_estate_web.Data.EntityFramework.Common;
using real_estate_web.Models.Database;
using real_estate_web.Models.Database.Dtos;

namespace real_estate_web.Data.EntityFramework
{
    public class EfPropertyDal : EfEntityRepositoryBase<Property,RealEstateDbContext>,IPropertyRepository
    {
        public EfPropertyDal(RealEstateDbContext context) : base(context)
        {
        }

        public IEnumerable<PropertyDto> GetListPropertyDto(){
            var result = from p in Context.Properties 
                            join c in Context.Cities on p.IlId equals c.Id 
                            join d in Context.Districts on p.IlceId equals d.Id 
                            join nb in Context.Neighborhoods on p.MahalleId equals nb.Id
                            join s in Context.Streets on p.SokakId equals s.Id
                            join pt in Context.PropertyTypes on p.PropertyTypeId equals pt.Id
                            join a in Context.Agents on p.AgentId equals a.Id
                            join st in Context.Statuses on p.StatusId equals st.Id
                            join ht in Context.HeatingTypes on p.IsitmaTipiId equals ht.Id
                            join it in Context.InternetTypes on p.InternetTipiId equals it.Id
                            join cep in Context.Fronts on p.CepheId equals cep.Id
                            join us in Context.UseCases on p.KullanimDurumuId equals us.Id
                            join ds in Context.DeedStatuses on p.TapuDurumuId equals ds.Id
                            select new PropertyDto(){
                                Id = p.Id,
                                Il = c.Name,
                                IlId = p.IlId,
                                Ilce = d.Name,
                                IlceId = p.IlceId,
                                Mahalle = nb.Name,
                                MahalleId = p.MahalleId,
                                Sokak = s.Name,
                                SokakId = p.SokakId,
                                Title = p.Title,
                                Description = p.Description,
                                LocationLat = p.LocationLat,
                                LocationLon = p.LocationLon,
                                PropertyType = pt.Name,
                                PropertyTypeId = p.PropertyTypeId,
                                Status = st.Name,
                                StatusId = p.StatusId,
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
                                IsitmaTipi = ht.Name,
                                IsitmaTipiId = p.IsitmaTipiId,
                                InternetTipi = it.Name,
                                InternetTipiId = p.InternetTipiId,
                                Cephe = cep.Name,
                                CepheId = p.CepheId,
                                Manzara = p.Manzara,
                                AkilliEvMi = p.AkilliEvMi,
                                EsyaliMi = p.EsyaliMi,
                                SiteIcerisindeMi = p.SiteIcerisindeMi,
                                SiteAdi = p.SiteAdi,
                                KullanimDurumu = us.Name,
                                KullanimDurumuId = p.KullanimDurumuId,
                                TapuDurumu = ds.Name,
                                TapuDurumuId = p.TapuDurumuId,
                                Price = p.Price,
                                Aidat = p.Aidat,
                                KirediyeUygunMu = p.KirediyeUygunMu,
                                YoutubeLink = p.YoutubeLink,
                                Agent = $"{a.FirstName} {a.LastName}",
                                AgentId = p.AgentId
                            };

            return result;
        }

        public PropertyDto GetPropertyDto(int id){
            var result = from p in Context.Properties 
                            join c in Context.Cities on p.IlId equals c.Id 
                            join d in Context.Districts on p.IlceId equals d.Id 
                            join nb in Context.Neighborhoods on p.MahalleId equals nb.Id
                            join s in Context.Streets on p.SokakId equals s.Id
                            join pt in Context.PropertyTypes on p.PropertyTypeId equals pt.Id
                            join a in Context.Agents on p.AgentId equals a.Id
                            join st in Context.Statuses on p.StatusId equals st.Id
                            join ht in Context.HeatingTypes on p.IsitmaTipiId equals ht.Id
                            join it in Context.InternetTypes on p.InternetTipiId equals it.Id
                            join cep in Context.Fronts on p.CepheId equals cep.Id
                            join us in Context.UseCases on p.KullanimDurumuId equals us.Id
                            join ds in Context.DeedStatuses on p.TapuDurumuId equals ds.Id
                            where p.Id == id
                            select new PropertyDto(){
                                Id = p.Id,
                                Il = c.Name,
                                IlId = p.IlId,
                                Ilce = d.Name,
                                IlceId = p.IlceId,
                                Mahalle = nb.Name,
                                MahalleId = p.MahalleId,
                                Sokak = s.Name,
                                SokakId = p.SokakId,
                                Title = p.Title,
                                Description = p.Description,
                                LocationLat = p.LocationLat,
                                LocationLon = p.LocationLon,
                                PropertyType = pt.Name,
                                PropertyTypeId = p.PropertyTypeId,
                                Status = st.Name,
                                StatusId = p.StatusId,
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
                                IsitmaTipi = ht.Name,
                                IsitmaTipiId = p.IsitmaTipiId,
                                InternetTipi = it.Name,
                                InternetTipiId = p.InternetTipiId,
                                Cephe = cep.Name,
                                CepheId = p.CepheId,
                                Manzara = p.Manzara,
                                AkilliEvMi = p.AkilliEvMi,
                                EsyaliMi = p.EsyaliMi,
                                SiteIcerisindeMi = p.SiteIcerisindeMi,
                                SiteAdi = p.SiteAdi,
                                KullanimDurumu = us.Name,
                                KullanimDurumuId = p.KullanimDurumuId,
                                TapuDurumu = ds.Name,
                                TapuDurumuId = p.TapuDurumuId,
                                Price = p.Price,
                                Aidat = p.Aidat,
                                KirediyeUygunMu = p.KirediyeUygunMu,
                                YoutubeLink = p.YoutubeLink,
                                Agent = $"{a.FirstName} {a.LastName}",
                                AgentId = p.AgentId
                            };

            return result.FirstOrDefault();
        }

        public IEnumerable<PropertyDto> GetListAgentIdPropertyDto(int agentId){
            var result = from p in Context.Properties 
                            join c in Context.Cities on p.IlId equals c.Id 
                            join d in Context.Districts on p.IlceId equals d.Id 
                            join nb in Context.Neighborhoods on p.MahalleId equals nb.Id
                            join s in Context.Streets on p.SokakId equals s.Id
                            join pt in Context.PropertyTypes on p.PropertyTypeId equals pt.Id
                            join a in Context.Agents on p.AgentId equals a.Id
                            join st in Context.Statuses on p.StatusId equals st.Id
                            join ht in Context.HeatingTypes on p.IsitmaTipiId equals ht.Id
                            join it in Context.InternetTypes on p.InternetTipiId equals it.Id
                            join cep in Context.Fronts on p.CepheId equals cep.Id
                            join us in Context.UseCases on p.KullanimDurumuId equals us.Id
                            join ds in Context.DeedStatuses on p.TapuDurumuId equals ds.Id
                            where p.AgentId == agentId
                            select new PropertyDto(){
                                Id = p.Id,
                                Il = c.Name,
                                IlId = p.IlId,
                                Ilce = d.Name,
                                IlceId = p.IlceId,
                                Mahalle = nb.Name,
                                MahalleId = p.MahalleId,
                                Sokak = s.Name,
                                SokakId = p.SokakId,
                                Title = p.Title,
                                Description = p.Description,
                                LocationLat = p.LocationLat,
                                LocationLon = p.LocationLon,
                                PropertyType = pt.Name,
                                PropertyTypeId = p.PropertyTypeId,
                                Status = st.Name,
                                StatusId = p.StatusId,
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
                                IsitmaTipi = ht.Name,
                                IsitmaTipiId = p.IsitmaTipiId,
                                InternetTipi = it.Name,
                                InternetTipiId = p.InternetTipiId,
                                Cephe = cep.Name,
                                CepheId = p.CepheId,
                                Manzara = p.Manzara,
                                AkilliEvMi = p.AkilliEvMi,
                                EsyaliMi = p.EsyaliMi,
                                SiteIcerisindeMi = p.SiteIcerisindeMi,
                                SiteAdi = p.SiteAdi,
                                KullanimDurumu = us.Name,
                                KullanimDurumuId = p.KullanimDurumuId,
                                TapuDurumu = ds.Name,
                                TapuDurumuId = p.TapuDurumuId,
                                Price = p.Price,
                                Aidat = p.Aidat,
                                KirediyeUygunMu = p.KirediyeUygunMu,
                                YoutubeLink = p.YoutubeLink,
                                Agent = $"{a.FirstName} {a.LastName}",
                                AgentId = p.AgentId
                            };

            return result;
        }
    }
}
