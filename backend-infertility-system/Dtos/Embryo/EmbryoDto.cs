namespace infertility_system.Dtos.Embryo
{
    public class EmbryoDto
    {
        public int EmbryoId { get; set; }

        public DateOnly CreateAt { get; set; }

        public DateOnly? TransferredAt { get; set; }

        public string? Quality { get; set; }

        public string? Type { get; set; }

        public string? Status { get; set; }

        public string? Note { get; set; }
    }
}
