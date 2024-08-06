namespace real_estate_web.Models.Database
{
    public class PropertyPhoto : BaseEntity
    {
        public int PropertyId { get; set; }
        public string? PropertyListingDetailId { get; set; }
        public string Path { get; set; }
        public bool BasePhoto { get; set; } = false;
        public int? SortIndex { get; set; }
    }
}
