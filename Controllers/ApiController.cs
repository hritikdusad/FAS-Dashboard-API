using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Models;

namespace Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class ApiController
    {
        FundDetails[] fundDetails = new FundDetails[]
        {
            new FundDetails{FundId=1, FundName = "Test1", IsActive=1, StartDateOnFAS=new DateTime(2009,04,30), CreatedOnFAS=new DateTime(2009,04,30),  FundPerformanceTime=9.40,RenewalPeriod="Yearly",FundType="MasterFeeder"},
            new FundDetails{FundId=2, FundName = "Test2", IsActive=0, StartDateOnFAS=new DateTime(2009,04,30), CreatedOnFAS=new DateTime(2009,04,30),  FundPerformanceTime=11.89,RenewalPeriod="Quarterly",FundType="CapitalCall"},
            new FundDetails{FundId=3, FundName = "Test3", IsActive=1, StartDateOnFAS=new DateTime(2010,04,29), CreatedOnFAS=new DateTime(2010,04,29),  FundPerformanceTime=12.01,RenewalPeriod="Yearly",FundType="Regular"},
            new FundDetails{FundId=4, FundName = "Test4", IsActive=1, StartDateOnFAS=new DateTime(2010,04,29), CreatedOnFAS=new DateTime(2010,04,29),  FundPerformanceTime=11.92,RenewalPeriod="Monthly",FundType="MasterFeeder"},
            new FundDetails{FundId=5, FundName = "Test5", IsActive=0, StartDateOnFAS=new DateTime(2011,05,29), CreatedOnFAS=new DateTime(2011,05,29),  FundPerformanceTime=11.35,RenewalPeriod="Yearly",FundType="CapitalCall"},
            new FundDetails{FundId=6, FundName = "Test6", IsActive=1, StartDateOnFAS=new DateTime(2011,05,29), CreatedOnFAS=new DateTime(2011,05,29),  FundPerformanceTime=12.28,RenewalPeriod="Monthly",FundType="Modal"},
            new FundDetails{FundId=7, FundName = "Test7", IsActive=1, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),  FundPerformanceTime=14.96,RenewalPeriod="Yearly",FundType="Regular"},
            new FundDetails{FundId=8, FundName = "Test8", IsActive=1, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),  FundPerformanceTime=12.70,RenewalPeriod="Yearly",FundType="Modal"},
            new FundDetails{FundId=9, FundName = "Test9", IsActive=0, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),  FundPerformanceTime=10.76,RenewalPeriod="Monthly",FundType="MasterFeeder"},
            new FundDetails{FundId=10, FundName = "Test10", IsActive=1, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundPerformanceTime=13.08,RenewalPeriod="Quarterly",FundType="CapitalCall"},
            new FundDetails{FundId=11, FundName = "Test11", IsActive=1, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundPerformanceTime=14.91,RenewalPeriod="Weekly",FundType="MasterFeeder"},
            new FundDetails{FundId=12, FundName = "Test12", IsActive=0, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundPerformanceTime=13.53,RenewalPeriod="Yearly",FundType="CapitalCall"},
            new FundDetails{FundId=13, FundName = "Test13", IsActive=0, StartDateOnFAS=new DateTime(2014,06,25), CreatedOnFAS=new DateTime(2014,06,25),FundPerformanceTime=11.77,RenewalPeriod="Weekly",FundType="MasterFeeder"},
            new FundDetails{FundId=14, FundName = "Test14", IsActive=1, StartDateOnFAS=new DateTime(2015,06,25), CreatedOnFAS=new DateTime(2015,06,25),FundPerformanceTime=10.30,RenewalPeriod="Quarterly",FundType="Modal"},
            new FundDetails{FundId=15, FundName = "Test15", IsActive=0, StartDateOnFAS=new DateTime(2016,06,25), CreatedOnFAS=new DateTime(2016,06,25),FundPerformanceTime=13.07,RenewalPeriod="Yearly",FundType="MasterFeeder"},
            new FundDetails{FundId=16, FundName = "Test16", IsActive=1, StartDateOnFAS=new DateTime(2016,06,18), CreatedOnFAS=new DateTime(2016,06,18),FundPerformanceTime=14.03,RenewalPeriod="Yearly",FundType="MasterFeeder"},
            new FundDetails{FundId=17, FundName = "Test17", IsActive=0, StartDateOnFAS=new DateTime(2017,12,18), CreatedOnFAS=new DateTime(2017,12,18),FundPerformanceTime=12.47,RenewalPeriod="Monthly",FundType="Modal"},
            new FundDetails{FundId=18, FundName = "Test18", IsActive=1, StartDateOnFAS=new DateTime(2018,12,18), CreatedOnFAS=new DateTime(2018,12,18),FundPerformanceTime=12.25,RenewalPeriod="Quarterly",FundType="MasterFeeder"},
            new FundDetails{FundId=19, FundName = "Test19", IsActive=1, StartDateOnFAS=new DateTime(2019,12,18), CreatedOnFAS=new DateTime(2019,12,18),FundPerformanceTime=12.59,RenewalPeriod="Weekly",FundType="CapitalCall"},
            new FundDetails{FundId=20, FundName = "Test20", IsActive=0, StartDateOnFAS=new DateTime(2020,12,18), CreatedOnFAS=new DateTime(2020,12,18),FundPerformanceTime=13.44,RenewalPeriod="Weekly",FundType="MasterFeeder"},
            new FundDetails{FundId=21, FundName = "Test21", IsActive=1, StartDateOnFAS=new DateTime(2020,1,15), CreatedOnFAS=new DateTime(2020,1,15),  FundPerformanceTime=12.07,RenewalPeriod="Yearly",FundType="Modal"},
            new FundDetails{FundId=22, FundName = "Test22", IsActive=0, StartDateOnFAS=new DateTime(2012,1,15), CreatedOnFAS=new DateTime(2012,1,15),  FundPerformanceTime=10.88,RenewalPeriod="Yearly",FundType="Regular"},
            new FundDetails{FundId=23, FundName = "Test23", IsActive=1, StartDateOnFAS=new DateTime(2020,2,15), CreatedOnFAS=new DateTime(2020,2,15),  FundPerformanceTime=9.13,RenewalPeriod="Monthly",FundType="MasterFeeder"},
            new FundDetails{FundId=24, FundName = "Test24", IsActive=1, StartDateOnFAS=new DateTime(2013,2,25), CreatedOnFAS=new DateTime(2013,2,25),  FundPerformanceTime=11.31,RenewalPeriod="Yearly",FundType="CapitalCall"},
            new FundDetails{FundId=25, FundName = "Test25", IsActive=1, StartDateOnFAS=new DateTime(2013,2,25), CreatedOnFAS=new DateTime(2013,2,25),  FundPerformanceTime=11.27,RenewalPeriod="Quarterly",FundType="Modal"},
            new FundDetails{FundId=26, FundName = "Test26", IsActive=0, StartDateOnFAS=new DateTime(2013,3,25), CreatedOnFAS=new DateTime(2013,3,25),  FundPerformanceTime=14.79,RenewalPeriod="Weekly",FundType="MasterFeeder"},
            new FundDetails{FundId=27, FundName = "Test27", IsActive=0, StartDateOnFAS=new DateTime(2014,4,25), CreatedOnFAS=new DateTime(2014,3,25),  FundPerformanceTime=12.91,RenewalPeriod="Weekly",FundType="MasterFeeder"},
            new FundDetails{FundId=28, FundName = "Test28", IsActive=1, StartDateOnFAS=new DateTime(2015,7,25), CreatedOnFAS=new DateTime(2015,7,25),  FundPerformanceTime=14.29,RenewalPeriod="Yearly",FundType="CapitalCall"},
            new FundDetails{FundId=29, FundName = "Test29", IsActive=0, StartDateOnFAS=new DateTime(2016,7,25), CreatedOnFAS=new DateTime(2016,7,25),  FundPerformanceTime=13.21,RenewalPeriod="Quarterly",FundType="MasterFeeder"},
            new FundDetails{FundId=30, FundName = "Test30", IsActive=1, StartDateOnFAS=new DateTime(2016,8,18), CreatedOnFAS=new DateTime(2016,8,18),  FundPerformanceTime=11.74,RenewalPeriod="Yearly",FundType="Modal"},
            new FundDetails{FundId=31, FundName = "Test31", IsActive=0, StartDateOnFAS=new DateTime(2017,9,18), CreatedOnFAS=new DateTime(2017,9,18),  FundPerformanceTime=12.49,RenewalPeriod="Monthly",FundType="Modal"},
            new FundDetails{FundId=32, FundName = "Test32", IsActive=1, StartDateOnFAS=new DateTime(2018,9,18), CreatedOnFAS=new DateTime(2018,9,18),  FundPerformanceTime=12.20,RenewalPeriod="Yearly",FundType="MasterFeeder"},
            new FundDetails{FundId=33, FundName = "Test33", IsActive=1, StartDateOnFAS=new DateTime(2019,11,18), CreatedOnFAS=new DateTime(2019,11,18),FundPerformanceTime=10.39,RenewalPeriod="Weekly",FundType="Modal"},
            new FundDetails{FundId=34, FundName = "Test34", IsActive=0, StartDateOnFAS=new DateTime(2020,12,18), CreatedOnFAS=new DateTime(2020,12,18),FundPerformanceTime=12.04,RenewalPeriod="Yearly",FundType="Regular"},
            new FundDetails{FundId=35, FundName = "Test35", IsActive=1, StartDateOnFAS=new DateTime(2020,10,15), CreatedOnFAS=new DateTime(2020,10,15),FundPerformanceTime=13.79,RenewalPeriod="Quarterly",FundType="MasterFeeder"},
            new FundDetails{FundId=36, FundName = "Test36", IsActive=0, StartDateOnFAS=new DateTime(2012,10,15), CreatedOnFAS=new DateTime(2012,10,15),FundPerformanceTime=10.10,RenewalPeriod="Yearly",FundType="CapitalCall"},
            new FundDetails{FundId=37, FundName = "Test37", IsActive=1, StartDateOnFAS=new DateTime(2020,10,15), CreatedOnFAS=new DateTime(2020,10,15),FundPerformanceTime=13.25,RenewalPeriod="Monthly",FundType="Modal"},
            new FundDetails{FundId=38, FundName = "Test38", IsActive=1, StartDateOnFAS=new DateTime(2020,03,01), CreatedOnFAS=new DateTime(2020,03,01),FundPerformanceTime=11.62,RenewalPeriod="Yearly",FundType="Modal"},
            new FundDetails{FundId=39, FundName = "Test39", IsActive=0, StartDateOnFAS=new DateTime(2020,03,02), CreatedOnFAS=new DateTime(2020,03,02),FundPerformanceTime=10.40,RenewalPeriod="Yearly",FundType="Regular"},
            new FundDetails{FundId=40, FundName = "Test40", IsActive=0, StartDateOnFAS=new DateTime(2020,03,03), CreatedOnFAS=new DateTime(2020,03,03),FundPerformanceTime=8.44,RenewalPeriod="Weekly",FundType="CapitalCall"},
            new FundDetails{FundId=41, FundName = "Test41", IsActive=1, StartDateOnFAS=new DateTime(2020,03,04), CreatedOnFAS=new DateTime(2020,03,04),FundPerformanceTime=14.99,RenewalPeriod="Weekly",FundType="Modal"},
            new FundDetails{FundId=42, FundName = "Test42", IsActive=0, StartDateOnFAS=new DateTime(2020,03,05), CreatedOnFAS=new DateTime(2020,03,05),FundPerformanceTime=15.42,RenewalPeriod="Monthly",FundType="MasterFeeder"},
            new FundDetails{FundId=43, FundName = "Test43", IsActive=1, StartDateOnFAS=new DateTime(2020,03,06), CreatedOnFAS=new DateTime(2020,03,06),FundPerformanceTime=9.85,RenewalPeriod="Quarterly",FundType="Modal"},
            new FundDetails{FundId=44, FundName = "Test44", IsActive=0, StartDateOnFAS=new DateTime(2020,03,07), CreatedOnFAS=new DateTime(2020,03,07),FundPerformanceTime=12.76,RenewalPeriod="Yearly",FundType="Modal"},
            new FundDetails{FundId=45, FundName = "Test45", IsActive=1, StartDateOnFAS=new DateTime(2020,03,08), CreatedOnFAS=new DateTime(2020,03,08),FundPerformanceTime=14.21,RenewalPeriod="Monthly",FundType="Regular"},
            new FundDetails{FundId=46, FundName = "Test46", IsActive=0, StartDateOnFAS=new DateTime(2020,03,09), CreatedOnFAS=new DateTime(2020,03,09),FundPerformanceTime=12.99,RenewalPeriod="Yearly",FundType="MasterFeeder"},
            new FundDetails{FundId=47, FundName = "Test47", IsActive=1, StartDateOnFAS=new DateTime(2020,03,10), CreatedOnFAS=new DateTime(2020,03,10),FundPerformanceTime=9.93,RenewalPeriod="Quarterly",FundType="Modal"},
            new FundDetails{FundId=48, FundName = "Test48", IsActive=0, StartDateOnFAS=new DateTime(2020,03,11), CreatedOnFAS=new DateTime(2020,03,11),FundPerformanceTime=14.08,RenewalPeriod="Yearly",FundType="CapitalCall"},
            new FundDetails{FundId=49, FundName = "Test49", IsActive=1, StartDateOnFAS=new DateTime(2020,03,12), CreatedOnFAS=new DateTime(2020,03,12),FundPerformanceTime=10.55,RenewalPeriod="Monthly",FundType="Modal"},
            new FundDetails{FundId=50, FundName = "Test50", IsActive=1, StartDateOnFAS=new DateTime(2020,03,13), CreatedOnFAS=new DateTime(2020,03,13),FundPerformanceTime=13.50,RenewalPeriod="Yearly",FundType="MasterFeeder"},
            new FundDetails{FundId=51, FundName = "Test51", IsActive=0, StartDateOnFAS=new DateTime(2020,03,14), CreatedOnFAS=new DateTime(2020,03,14),FundPerformanceTime=10.42,RenewalPeriod="Weekly",FundType="Regular"},
            new FundDetails{FundId=52, FundName = "Test52", IsActive=1, StartDateOnFAS=new DateTime(2020,03,15), CreatedOnFAS=new DateTime(2020,03,15),FundPerformanceTime=9.14,RenewalPeriod="Monthly",FundType="Modal"},
            new FundDetails{FundId=53, FundName = "Test53", IsActive=1, StartDateOnFAS=new DateTime(2020,03,16), CreatedOnFAS=new DateTime(2020,03,16),FundPerformanceTime=13.13,RenewalPeriod="Yearly",FundType="CapitalCall"},
            new FundDetails{FundId=54, FundName = "Test54", IsActive=0, StartDateOnFAS=new DateTime(2020,03,17), CreatedOnFAS=new DateTime(2020,03,17),FundPerformanceTime=12.69,RenewalPeriod="Quarterly",FundType="MasterFeeder"},
            new FundDetails{FundId=55, FundName = "Test55", IsActive=1, StartDateOnFAS=new DateTime(2020,03,18), CreatedOnFAS=new DateTime(2020,03,18),FundPerformanceTime=10.88,RenewalPeriod="Weekly",FundType="Modal"},
            new FundDetails{FundId=56, FundName = "Test56", IsActive=0, StartDateOnFAS=new DateTime(2020,03,19), CreatedOnFAS=new DateTime(2020,03,19),FundPerformanceTime=10.94,RenewalPeriod="Yearly",FundType="Regular"},
            new FundDetails{FundId=57, FundName = "Test57", IsActive=1, StartDateOnFAS=new DateTime(2020,03,20), CreatedOnFAS=new DateTime(2020,03,20),FundPerformanceTime=11.04,RenewalPeriod="Yearly",FundType="Modal"},
            new FundDetails{FundId=58, FundName = "Test58", IsActive=0, StartDateOnFAS=new DateTime(2020,03,21), CreatedOnFAS=new DateTime(2020,03,21),FundPerformanceTime=9.93,RenewalPeriod="Weekly",FundType="MasterFeeder"},
            new FundDetails{FundId=59, FundName = "Test59", IsActive=1, StartDateOnFAS=new DateTime(2020,03,22), CreatedOnFAS=new DateTime(2020,03,22),FundPerformanceTime=11.90,RenewalPeriod="Yearly",FundType="CapitalCall"},
            new FundDetails{FundId=60, FundName = "Test60", IsActive=0, StartDateOnFAS=new DateTime(2020,03,23), CreatedOnFAS=new DateTime(2020,03,23),FundPerformanceTime=8.03,RenewalPeriod="Quarterly",FundType="Modal"},
            new FundDetails{FundId=61, FundName = "Test61", IsActive=1, StartDateOnFAS=new DateTime(2020,03,24), CreatedOnFAS=new DateTime(2020,03,24),FundPerformanceTime=15.02,RenewalPeriod="Yearly",FundType="Modal"},
            new FundDetails{FundId=62, FundName = "Test62", IsActive=0, StartDateOnFAS=new DateTime(2020,03,25), CreatedOnFAS=new DateTime(2020,03,25),FundPerformanceTime=12.04,RenewalPeriod="Yearly",FundType="Regular"},
            new FundDetails{FundId=63, FundName = "Test63", IsActive=1, StartDateOnFAS=new DateTime(2020,03,26), CreatedOnFAS=new DateTime(2020,03,26),FundPerformanceTime=10.52,RenewalPeriod="Monthly",FundType="MasterFeeder"},
            new FundDetails{FundId=64, FundName = "Test64", IsActive=0, StartDateOnFAS=new DateTime(2020,03,27), CreatedOnFAS=new DateTime(2020,03,27),FundPerformanceTime=12.49,RenewalPeriod="Yearly",FundType="Modal"},
            new FundDetails{FundId=65, FundName = "Test65", IsActive=1, StartDateOnFAS=new DateTime(2020,03,28), CreatedOnFAS=new DateTime(2020,03,28),FundPerformanceTime=15.73,RenewalPeriod="Weekly",FundType="CapitalCall"},
            new FundDetails{FundId=66, FundName = "Test66", IsActive=1, StartDateOnFAS=new DateTime(2020,03,29), CreatedOnFAS=new DateTime(2020,03,29),FundPerformanceTime=10.81,RenewalPeriod="Yearly",FundType="Regular"},
            new FundDetails{FundId=67, FundName = "Test67", IsActive=0, StartDateOnFAS=new DateTime(2020,03,30), CreatedOnFAS=new DateTime(2020,03,30),FundPerformanceTime=10.89,RenewalPeriod="Monthly",FundType="MasterFeeder"},
            new FundDetails{FundId=68, FundName = "Test68", IsActive=1, StartDateOnFAS=new DateTime(2020,03,31), CreatedOnFAS=new DateTime(2020,03,31),FundPerformanceTime=11.90,RenewalPeriod="Quarterly",FundType="MasterFeeder"}
              
        };

       ClientDetails[] clientDetails = new ClientDetails[]
        {
            new ClientDetails{ClientId=1,  ClientName = "Client1",   IsActive=1, StartDateOnFAS=new DateTime(2009,04,30), CreatedOnFAS=new DateTime(2009,04,30),FundId = new[] {1,2,3,4,5,6}},
            new ClientDetails{ClientId=2,  ClientName = "Client2",   IsActive=1, StartDateOnFAS=new DateTime(2009,04,30), CreatedOnFAS=new DateTime(2009,04,30),FundId = new[] {3,4,5,6,7,8}},
            new ClientDetails{ClientId=3,  ClientName = "Client3",   IsActive=1, StartDateOnFAS=new DateTime(2010,04,29), CreatedOnFAS=new DateTime(2010,04,29),FundId = new[] {4,5,6,7,8,9,10}},
            new ClientDetails{ClientId=4,  ClientName = "Client4",   IsActive=1, StartDateOnFAS=new DateTime(2010,04,29), CreatedOnFAS=new DateTime(2010,04,29),FundId = new[] {5,6,7,37,36,33,30}},
            new ClientDetails{ClientId=5,  ClientName = "Client5",   IsActive=0, StartDateOnFAS=new DateTime(2011,05,29), CreatedOnFAS=new DateTime(2011,05,29),FundId = new[] {6,7,8,9,11,13,15}},
            new ClientDetails{ClientId=6,  ClientName = "Client6",   IsActive=0, StartDateOnFAS=new DateTime(2011,05,29), CreatedOnFAS=new DateTime(2011,05,29),FundId = new[] {7,8,9,12,13,15,16}},
            new ClientDetails{ClientId=7,  ClientName = "Client7",   IsActive=0, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),FundId = new[] {8,9,10,15,17,18,19}},
            new ClientDetails{ClientId=8,  ClientName = "Client8",   IsActive=1, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),FundId = new[] {9,10,11,28,29,25,26}},
            new ClientDetails{ClientId=9,  ClientName = "Client9",   IsActive=1, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),FundId = new[] {10,11,12,15,18,21,24,27,30}},
            new ClientDetails{ClientId=10, ClientName = "Client10",  IsActive=0, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundId = new[] {11,12,13,17,21,25,29,33,37}},
            new ClientDetails{ClientId=11, ClientName = "Client11",  IsActive=0, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundId = new[] {12,13,14,19,24,29,34,36}},
            new ClientDetails{ClientId=12, ClientName = "Client12",  IsActive=0, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundId = new[] {13,14,15,18,21,24,26,30,32}},
            new ClientDetails{ClientId=13, ClientName = "Client13",  IsActive=1, StartDateOnFAS=new DateTime(2014,06,25), CreatedOnFAS=new DateTime(2014,06,25),FundId = new[] {14,15,16,20,22,25,29,30,32}},
            new ClientDetails{ClientId=14, ClientName = "Client14",  IsActive=0, StartDateOnFAS=new DateTime(2015,06,25), CreatedOnFAS=new DateTime(2015,06,25),FundId = new[] {15,16,17,19,20,21,24,27,29}},
            new ClientDetails{ClientId=15, ClientName = "Client15",  IsActive=0, StartDateOnFAS=new DateTime(2016,06,25), CreatedOnFAS=new DateTime(2016,06,25),FundId = new[] {16,17,18,18,22,25,27,31,33,37}},
            new ClientDetails{ClientId=16, ClientName = "Client16",  IsActive=0, StartDateOnFAS=new DateTime(2016,06,18), CreatedOnFAS=new DateTime(2016,06,18),FundId = new[] {17,18,19,20,23,25,27,29,31,33,35}},
            new ClientDetails{ClientId=17, ClientName = "Client17",  IsActive=0, StartDateOnFAS=new DateTime(2017,12,18), CreatedOnFAS=new DateTime(2017,12,18),FundId = new[] {18,19,20,17,13,12,15,9,1,3,35,29,25}},
            new ClientDetails{ClientId=18, ClientName = "Client18",  IsActive=1, StartDateOnFAS=new DateTime(2018,12,18), CreatedOnFAS=new DateTime(2018,12,18),FundId = new[] {19,20,21,3,5,7,11,23,27,32,37}},
            new ClientDetails{ClientId=19, ClientName = "Client19",  IsActive=1, StartDateOnFAS=new DateTime(2019,12,18), CreatedOnFAS=new DateTime(2019,12,18),FundId = new[] {20,21,22,6,9,11,13,15,17,19,27}},
            new ClientDetails{ClientId=20, ClientName = "Client20",  IsActive=1, StartDateOnFAS=new DateTime(2020,4,15), CreatedOnFAS=new DateTime(2020,4,15),FundId = new[] {1,3,5,7,9,11,13,15,17,19,21,23,27,29,31,33,35,37}},
            new ClientDetails{ClientId=21, ClientName = "Client21",  IsActive=0, StartDateOnFAS=new DateTime(2020,4,16), CreatedOnFAS=new DateTime(2020,4,16),FundId = new[] {38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68}}
        };

        [HttpGet("Funds")]
        public IEnumerable<FundDetails> ListAllfunds()
        {
            return fundDetails;
        }

        [HttpGet("Clients")]
        public IEnumerable<ClientDetails> ListAllClients()
        {
            return clientDetails;
        }
        [HttpGet("Clients/{ClientId}")]
        public IEnumerable<ClientDetails> ListFundsBySelection(int ClientId)
        {
             IEnumerable<ClientDetails> retVal =
                from g in clientDetails 
                where g.ClientId.Equals(ClientId) 
                select g;

            return retVal;

        }


        // [HttpGet("description/{desart}")]
        // public IEnumerable<Products> ListProductsByDescription(string desart)
        // {
        //     IEnumerable<Products> retVal = 
        //         from g in products
        //         where g.Description.ToUpper().Contains(desart.ToUpper())
        //         orderby g.Code
        //         select g;
                
        //     return retVal;
            
        // }
    }
}