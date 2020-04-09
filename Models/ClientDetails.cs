using System;

namespace Models
{
    public class ClientDetails{
        public int ClientId {get; set;}
        public string ClientName {get; set;}
        public int IsActive {get; set;}
        public DateTime StartDateOnFAS {get; set;}
        public DateTime CreatedOnFAS {get; set;}
        public int[]  FundId {get; set;}
    }
}