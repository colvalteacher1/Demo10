namespace Demo10.Dtos
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        public string? CustomerName { get; set; } = string.Empty;

        public string? City { get; set; } = string.Empty;

        public DateOnly? CreationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
