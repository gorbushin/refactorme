using System;
using System.Collections.Generic;

namespace refactorme.Models
{
    public class StrengthData
    {
        public int WeightLifted { get; set; }

        public int BodyWeight { get; set; }

        public GenderOptions Gender { get; set; }
    }

    public enum GenderOptions
    {
        Male,
        Female,
        Other
    }
}
