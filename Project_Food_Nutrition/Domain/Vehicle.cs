namespace Project_Food_Nutrition.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public virtual Make? Make { get; set; }
        public int ModelId { get; set; }
        public virtual Model? Model { get; set; }
        public int ColourId { get; set; }
    }
}
