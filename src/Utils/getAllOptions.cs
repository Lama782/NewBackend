public class GetAllOptions
    {
        public int Limit { get; set; } = 100;
        public int Offset { get; set; } = 0;
        public string? Search { get; set; } = string.Empty;
    }