namespace backend.DTOs
{
    public record ConfigDTO
    {
        public string dbName { get; set; }

        public string dbHost { get; set; }

        public string dbUsername { get; set; }

        public string dbPassword { get; set; }
        public string timezoneId { get; set; }
    }
}