namespace Project_Food_Nutrition.Domain
{
    public class Staff : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        public string? MacrosName { get; set; }
        public int MacrosValue { get; set; }

        public virtual MacrosTracking?  MacrosTracking { get; set; }
        public int CustomerId { get; set; }
        public virtual Users? Customer { get; set; }
    }
}
