namespace real_estate_web.Models.HelperEntities
{
    public record Pagination
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 12;
    }
}
