using System;

namespace DTO
{
    public class Installation
    {
        public int RegistrationNumber { get; set; }
        public String Street { get; set; }
        public int Number { get; set; }
        public int Postcode { get; set; }
        public String City { get; set; }
        public String Energy { get; set; }
        public String Integration { get; set; }
        public String PVCells { get; set; }
        public double FieldOrientation { get; set; }
        public double SlopRoof { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }
    }
}
