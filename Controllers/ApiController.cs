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
            new FundDetails{FundId=1, FundName = "Test1", IsActive=1, StartDateOnFAS=new DateTime(2000,04,30), CreatedOnFAS=new DateTime(2000,04,30)},
            new FundDetails{FundId=2, FundName = "Test2", IsActive=0, StartDateOnFAS=new DateTime(2000,04,30), CreatedOnFAS=new DateTime(2000,04,30)},
            new FundDetails{FundId=3, FundName = "Test3", IsActive=1, StartDateOnFAS=new DateTime(2010,04,29), CreatedOnFAS=new DateTime(2010,04,29)},
            new FundDetails{FundId=4, FundName = "Test4", IsActive=1, StartDateOnFAS=new DateTime(2010,04,29), CreatedOnFAS=new DateTime(2010,04,29)},
            new FundDetails{FundId=5, FundName = "Test5", IsActive=0, StartDateOnFAS=new DateTime(2011,05,29), CreatedOnFAS=new DateTime(2011,05,29)},
            new FundDetails{FundId=6, FundName = "Test6", IsActive=1, StartDateOnFAS=new DateTime(2011,05,29), CreatedOnFAS=new DateTime(2011,05,29)},
            new FundDetails{FundId=7, FundName = "Test7", IsActive=1, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29)},
            new FundDetails{FundId=8, FundName = "Test8", IsActive=1, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29)},
            new FundDetails{FundId=9, FundName = "Test9", IsActive=0, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29)},
            new FundDetails{FundId=10, FundName = "Test10", IsActive=1, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25)},
            new FundDetails{FundId=11, FundName = "Test11", IsActive=1, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25)},
            new FundDetails{FundId=12, FundName = "Test12", IsActive=0, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25)},
            new FundDetails{FundId=13, FundName = "Test13", IsActive=0, StartDateOnFAS=new DateTime(2014,06,25), CreatedOnFAS=new DateTime(2014,06,25)},
            new FundDetails{FundId=14, FundName = "Test14", IsActive=1, StartDateOnFAS=new DateTime(2015,06,25), CreatedOnFAS=new DateTime(2015,06,25)},
            new FundDetails{FundId=15, FundName = "Test15", IsActive=0, StartDateOnFAS=new DateTime(2016,06,25), CreatedOnFAS=new DateTime(2016,06,25)},
            new FundDetails{FundId=16, FundName = "Test16", IsActive=1, StartDateOnFAS=new DateTime(2016,06,18), CreatedOnFAS=new DateTime(2016,06,18)},
            new FundDetails{FundId=17, FundName = "Test17", IsActive=0, StartDateOnFAS=new DateTime(2017,12,18), CreatedOnFAS=new DateTime(2017,12,18)},
            new FundDetails{FundId=18, FundName = "Test18", IsActive=1, StartDateOnFAS=new DateTime(2018,12,18), CreatedOnFAS=new DateTime(2018,12,18)},
            new FundDetails{FundId=19, FundName = "Test19", IsActive=1, StartDateOnFAS=new DateTime(2019,12,18), CreatedOnFAS=new DateTime(2019,12,18)},
            new FundDetails{FundId=20, FundName = "Test20", IsActive=0, StartDateOnFAS=new DateTime(2020,12,18), CreatedOnFAS=new DateTime(2020,12,18)},
            new FundDetails{FundId=21, FundName = "Test21", IsActive=1, StartDateOnFAS=new DateTime(2020,10,15), CreatedOnFAS=new DateTime(2020,10,15)},
            new FundDetails{FundId=22, FundName = "Test22", IsActive=0, StartDateOnFAS=new DateTime(2012,10,15), CreatedOnFAS=new DateTime(2012,10,15)},
            new FundDetails{FundId=23, FundName = "Test23", IsActive=1, StartDateOnFAS=new DateTime(2020,10,15), CreatedOnFAS=new DateTime(2020,10,15)} 
        };

        ClientDetails[] clientDetails = new ClientDetails[]
        {
            new ClientDetails{ClientId=1,  ClientName = "Client1",   IsActive=1, StartDateOnFAS=new DateTime(2000,04,30), CreatedOnFAS=new DateTime(2000,04,30),FundId = new[] {1,2,3}},
            new ClientDetails{ClientId=2,  ClientName = "Client2",   IsActive=1, StartDateOnFAS=new DateTime(2000,04,30), CreatedOnFAS=new DateTime(2000,04,30),FundId = new[] {3,4,5}},
            new ClientDetails{ClientId=3,  ClientName = "Client3",   IsActive=1, StartDateOnFAS=new DateTime(2010,04,29), CreatedOnFAS=new DateTime(2010,04,29),FundId = new[] {4,5,6}},
            new ClientDetails{ClientId=4,  ClientName = "Client4",   IsActive=1, StartDateOnFAS=new DateTime(2010,04,29), CreatedOnFAS=new DateTime(2010,04,29),FundId = new[] {5,6,7}},
            new ClientDetails{ClientId=5,  ClientName = "Client5",   IsActive=0, StartDateOnFAS=new DateTime(2011,05,29), CreatedOnFAS=new DateTime(2011,05,29),FundId = new[] {6,7,8}},
            new ClientDetails{ClientId=6,  ClientName = "Client6",   IsActive=0, StartDateOnFAS=new DateTime(2011,05,29), CreatedOnFAS=new DateTime(2011,05,29),FundId = new[] {7,8,9}},
            new ClientDetails{ClientId=7,  ClientName = "Client7",   IsActive=0, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),FundId = new[] {8,9,10}},
            new ClientDetails{ClientId=8,  ClientName = "Client8",   IsActive=1, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),FundId = new[] {9,10,11}},
            new ClientDetails{ClientId=9,  ClientName = "Client9",   IsActive=1, StartDateOnFAS=new DateTime(2012,05,29), CreatedOnFAS=new DateTime(2012,05,29),FundId = new[] {10,11,12}},
            new ClientDetails{ClientId=10, ClientName = "Client10",  IsActive=0, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundId = new[] {11,12,13}},
            new ClientDetails{ClientId=11, ClientName = "Client11",  IsActive=0, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundId = new[] {12,13,14}},
            new ClientDetails{ClientId=12, ClientName = "Client12",  IsActive=0, StartDateOnFAS=new DateTime(2013,06,25), CreatedOnFAS=new DateTime(2013,06,25),FundId = new[] {13,14,15}},
            new ClientDetails{ClientId=13, ClientName = "Client13",  IsActive=1, StartDateOnFAS=new DateTime(2014,06,25), CreatedOnFAS=new DateTime(2014,06,25),FundId = new[] {14,15,16}},
            new ClientDetails{ClientId=14, ClientName = "Client14",  IsActive=0, StartDateOnFAS=new DateTime(2015,06,25), CreatedOnFAS=new DateTime(2015,06,25),FundId = new[] {15,16,17}},
            new ClientDetails{ClientId=15, ClientName = "Client15",  IsActive=0, StartDateOnFAS=new DateTime(2016,06,25), CreatedOnFAS=new DateTime(2016,06,25),FundId = new[] {16,17,18}},
            new ClientDetails{ClientId=16, ClientName = "Client16",  IsActive=0, StartDateOnFAS=new DateTime(2016,06,18), CreatedOnFAS=new DateTime(2016,06,18),FundId = new[] {17,18,19}},
            new ClientDetails{ClientId=17, ClientName = "Client17",  IsActive=0, StartDateOnFAS=new DateTime(2017,12,18), CreatedOnFAS=new DateTime(2017,12,18),FundId = new[] {18,19,20}},
            new ClientDetails{ClientId=18, ClientName = "Client18",  IsActive=1, StartDateOnFAS=new DateTime(2018,12,18), CreatedOnFAS=new DateTime(2018,12,18),FundId = new[] {19,20,21}},
            new ClientDetails{ClientId=19, ClientName = "Client19",  IsActive=1, StartDateOnFAS=new DateTime(2019,12,18), CreatedOnFAS=new DateTime(2019,12,18),FundId = new[] {20,21,22}}
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