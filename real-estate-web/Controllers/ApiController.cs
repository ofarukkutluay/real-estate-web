using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using real_estate_web.Data.EntityFramework;
using real_estate_web.Models.Database;
using real_estate_web.Models.ViewModel;
using real_estate_web.Tools.Hashing;
using real_estate_web.Tools.Scraping;
using real_estate_web.Tools.TokenOperations;
using real_estate_web.Tools.TokenOperations.Models;
using System.Globalization;
using System.Net;
using System.Security.Claims;

namespace real_estate_web.Controllers
{
    [Route("api")]
    [ApiController]

    public class ApiController : Controller
    {
        private readonly ScrapingService _scrapingService;
        private readonly RealEstateDbContext _dbContext;
        private readonly IConfiguration _configuration;
        public ApiController(ScrapingService scrapingService, RealEstateDbContext dbContext, IConfiguration configuration)
        {
            _scrapingService = scrapingService;
            _dbContext = dbContext;
            _configuration = configuration;
        }

        [HttpPost("shscrap")]
        [Authorize]
        public async Task<IActionResult> ShScrapAsync([FromBody] ScrapVM scrapVM)
        {
            PropertyListingDetail listingDetail = await _scrapingService.GetSHListingDetail(scrapVM.Url, scrapVM.OuterHtml, "Outsource");
            if (!await _dbContext.PropertyListingDetails.AnyAsync(x => x.Id == listingDetail.Id))
            {
                await _dbContext.PropertyListingDetails.AddAsync(listingDetail);
                await _dbContext.SaveChangesAsync();
            }
            if (await _dbContext.Properties.AnyAsync(x => x.PropertyListiningId == listingDetail.Id))
            {
                return BadRequest(new Response
                {
                    Message = "Bu id de kayıt bulunmaktadır.",
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest
                });
            }

            var tmpNeigh = listingDetail.Neighborhood.Trim();
            listingDetail.Neighborhood = tmpNeigh.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR"));
            int userId = int.Parse(HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            City? city = await _dbContext.Cities.SingleOrDefaultAsync(x => x.Name.Trim() == listingDetail.City.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
            if (city is null)
            {
                int newCityKey = _dbContext.Cities.OrderBy(x => x.Key).Last().Key + 1;
                var resCity = await _dbContext.Cities.AddAsync(new City { Name = listingDetail.City.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")), Key = newCityKey });
                await _dbContext.SaveChangesAsync();
                city = resCity.Entity;
            }
            District? district = await _dbContext.Districts.SingleOrDefaultAsync(x => x.IlKey == city.Key && x.Name.Trim() == listingDetail.District.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
            if (district is null)
            {
                int newDistrictKey = _dbContext.Districts.OrderBy(x => x.Key).Last().Key + 1;
                var resDist = await _dbContext.Districts.AddAsync(new District { Name = listingDetail.District.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")), IlKey = city.Key, Key = newDistrictKey });
                await _dbContext.SaveChangesAsync();
                district = resDist.Entity;
            }
            Neighborhood? neighborhood = await _dbContext.Neighborhoods.SingleOrDefaultAsync(x => x.IlceKey == district.Key && x.Name.Trim() == listingDetail.Neighborhood);
            if (neighborhood is null)
            {
                int newNeighborhoodKey = _dbContext.Neighborhoods.OrderBy(x => x.Key).Last().Key + 1;
                var resNeigh = await _dbContext.Neighborhoods.AddAsync(new Neighborhood { Name = listingDetail.Neighborhood.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")), IlceKey = district.Key, Key = newNeighborhoodKey });
                await _dbContext.SaveChangesAsync();
                neighborhood = resNeigh.Entity;
            }

            var property = await _dbContext.Properties.AddAsync(new Property
            {
                PropertyListiningId = listingDetail.Id,
                AgentId = userId,
                Aidat = listingDetail.Fees,
                BalkonSayisi = (ushort)(listingDetail.IsThereBalcony ? 1 : 0),
                BanyoSayisi = (ushort)listingDetail.BathroomCount,
                BinaYasi = listingDetail.BuildingAge,
                BrutMetre = listingDetail.GrossSquareMeter,
                BulunduguKat = listingDetail.Floor,
                Cephe = "Belirtilmemiş",
                Description = listingDetail.DescriptionHtml,
                EsyaliMi = listingDetail.IsFurnished,
                IlceId = district.Id,
                IlId = city.Id,
                InternetTipi = "Belirtilmemiş",
                IsitmaTipi = listingDetail.HeatingType,
                KirediyeUygunMu = listingDetail.IsAvailableLoan,
                LocationLat = listingDetail.LocationLat,
                LocationLon = listingDetail.LocationLon,
                KullanimDurumu = listingDetail.UsingStatus,
                MahalleId = neighborhood.Id,
                NetMetre = listingDetail.UsableSquareMeter,
                OdaSayisi = (ushort)listingDetail.RoomCount,
                Price = listingDetail.Price,
                PropertyType = listingDetail.Type,
                SalonSayisi = (ushort)listingDetail.LivingRoomCount,
                SiteAdi = listingDetail.SiteName,
                SiteIcerisindeMi = listingDetail.IsOnSite,
                Status = listingDetail.Status,
                TapuDurumu = listingDetail.DeedStatus,
                Title = listingDetail.Title,
                ToplamKat = listingDetail.BuildingTotalFloor,
                IsActive = false
            });

            await _dbContext.SaveChangesAsync();

            foreach (var item in listingDetail.PropertyPhotos)
            {
                item.PropertyId = property.Entity.Id;
                if (item.SortIndex == 0)
                    item.BasePhoto = true;
                await _dbContext.PropertyPhotos.AddAsync(item);
            }
            await _dbContext.SaveChangesAsync();

            return Ok(new Response
            {
                Message = "Başarılı",
                Success = true,
                StatusCode = (int)HttpStatusCode.OK,
            });
        }


        [HttpPost("hescrap")]
        [Authorize]
        public async Task<IActionResult> HeScrapAsync([FromBody] ScrapVM scrapVM)
        {
            PropertyListingDetail listingDetail = await _scrapingService.GetHEListingDetail(scrapVM.Url, scrapVM.OuterHtml, "Outsource");
            if (!await _dbContext.PropertyListingDetails.AnyAsync(x => x.Id == listingDetail.Id))
            {
                await _dbContext.PropertyListingDetails.AddAsync(listingDetail);
                await _dbContext.SaveChangesAsync();
            }
            if (await _dbContext.Properties.AnyAsync(x => x.PropertyListiningId == listingDetail.Id))
            {
                return BadRequest(new Response
                {
                    Message = "Bu id de kayıt bulunmaktadır.",
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest
                });
            }

            var tmpNeigh = listingDetail.Neighborhood.Trim();
            listingDetail.Neighborhood = listingDetail.Neighborhood.Trim().ToUpper(CultureInfo.CreateSpecificCulture("tr-TR"));
            int userId = int.Parse(HttpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier)?.Value);
            City? city = await _dbContext.Cities.SingleOrDefaultAsync(x => x.Name.Trim() == listingDetail.City.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
            if (city is null)
            {
                int newCityKey = _dbContext.Cities.OrderBy(x => x.Key).Last().Key + 1;
                var resCity = await _dbContext.Cities.AddAsync(new City { Name = listingDetail.City.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")), Key = newCityKey });
                await _dbContext.SaveChangesAsync();
                city = resCity.Entity;
            }
            District? district = await _dbContext.Districts.SingleOrDefaultAsync(x => x.IlKey == city.Key && x.Name.Trim() == listingDetail.District.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
            if (district is null)
            {
                int newDistrictKey = _dbContext.Districts.OrderBy(x => x.Key).Last().Key + 1;
                var resDist = await _dbContext.Districts.AddAsync(new District { Name = listingDetail.District.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")), IlKey = city.Key, Key = newDistrictKey });
                await _dbContext.SaveChangesAsync();
                district = resDist.Entity;
            }
            Neighborhood? neighborhood = await _dbContext.Neighborhoods.SingleOrDefaultAsync(x => x.IlceKey == district.Key && x.Name.Trim() == listingDetail.Neighborhood.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
            if (neighborhood is null)
            {
                int newNeighborhoodKey = _dbContext.Neighborhoods.OrderBy(x => x.Key).Last().Key + 1;
                var resNeigh = await _dbContext.Neighborhoods.AddAsync(new Neighborhood { Name = listingDetail.Neighborhood.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")), IlceKey = district.Key, Key = newNeighborhoodKey });
                await _dbContext.SaveChangesAsync();
                neighborhood = resNeigh.Entity;
            }

            var property = await _dbContext.Properties.AddAsync(new Property
            {
                PropertyListiningId = listingDetail.Id,
                AgentId = userId,
                Aidat = listingDetail.Fees,
                BalkonSayisi = (ushort)(listingDetail.IsThereBalcony ? 1 : 0),
                BanyoSayisi = (ushort)listingDetail.BathroomCount,
                BinaYasi = listingDetail.BuildingAge,
                BrutMetre = listingDetail.GrossSquareMeter,
                BulunduguKat = listingDetail.Floor,
                Cephe = "Belirtilmemiş",
                Description = listingDetail.DescriptionHtml,
                EsyaliMi = listingDetail.IsFurnished,
                IlceId = district.Id,
                IlId = city.Id,
                InternetTipi = "Belirtilmemiş",
                IsitmaTipi = listingDetail.HeatingType,
                KirediyeUygunMu = listingDetail.IsAvailableLoan,
                LocationLat = listingDetail.LocationLat,
                LocationLon = listingDetail.LocationLon,
                KullanimDurumu = listingDetail.UsingStatus,
                MahalleId = neighborhood.Id,
                NetMetre = listingDetail.UsableSquareMeter,
                OdaSayisi = (ushort)listingDetail.RoomCount,
                Price = listingDetail.Price,
                PropertyType = listingDetail.Type,
                SalonSayisi = (ushort)listingDetail.LivingRoomCount,
                SiteAdi = listingDetail.SiteName,
                SiteIcerisindeMi = listingDetail.IsOnSite,
                Status = listingDetail.Status,
                TapuDurumu = listingDetail.DeedStatus,
                Title = listingDetail.Title,
                ToplamKat = listingDetail.BuildingTotalFloor,
                IsActive = false
            });

            await _dbContext.SaveChangesAsync();

            foreach (var item in listingDetail.PropertyPhotos)
            {
                item.PropertyId = property.Entity.Id;
                if (item.SortIndex == 0)
                    item.BasePhoto = true;
                await _dbContext.PropertyPhotos.AddAsync(item);
            }
            await _dbContext.SaveChangesAsync();

            return Ok(new Response
            {
                Message = "Başarılı",
                Success = true,
                StatusCode = (int)HttpStatusCode.OK,
            });
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserVM model)
        {
            Agent agent = await _dbContext.Agents.FirstOrDefaultAsync(x => x.Email == model.Email.Trim());
            if (agent is null)
            {

                return BadRequest(new Response
                {
                    Message = "kullanıcı bulunamadı!",
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest
                });
            }
            if (!HashingHelper.VerifyPasswordHash(model.Password, agent.PassSalt, agent.PassHash))
            {
                return BadRequest(new Response
                {
                    Message = "Şifre hatalı!",
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest
                });
            }

            TokenHandler tokenHandler = new TokenHandler(_configuration);
            Token token = tokenHandler.CreateAccessToken(agent);
            agent.RefreshToken = token.RefreshToken;
            agent.RefresTokenExpireDate = token.Expiration.AddMinutes(5);
            _dbContext.SaveChanges();

            return Json(token);
        }
    }



    struct Response
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int StatusCode { get; set; }
    }

    public struct ScrapVM
    {
        public string Url { get; set; }
        public string OuterHtml { get; set; }
    }
}
