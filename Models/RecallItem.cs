namespace PortfolioApi.Models
{
    public class RecallItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public string? ImageUrl { get; set; }
        public string? Secret { get; set; }
    }
    public class RecallItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public string? ImageUrl { get; set; }
    }
}
