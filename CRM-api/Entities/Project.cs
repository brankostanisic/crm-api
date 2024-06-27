namespace CRM_api.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public DateTime Deadline { get; set; }

        public required string Status { get; set; }

        public int? UserId { get; set; }
    }
}