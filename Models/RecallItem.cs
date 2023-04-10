﻿namespace PortfolioApi.Models
{
    public class RecallItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsComplete { get; set; }
    }
}