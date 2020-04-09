using System;

namespace Models
{
    public class FundDetails{
        public int FundId {get; set;}
        public string FundName {get; set;}
        public int IsActive {get; set;}
        public DateTime StartDateOnFAS {get; set;}
        public DateTime CreatedOnFAS {get; set;}
    }
}