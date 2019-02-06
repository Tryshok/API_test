using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using API_Test.Mapping;

namespace API_Test.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpPost]
        [Route("api/login_check")]
        public Token PostLogin([FromBody]Mapping.Login value)
        {
            return new Token { token = "qdqdsqd" };
        }

        [HttpGet]
        [Route("api/client/fetch")]
        public List<Clients> Post_AllClients([FromBody]Mapping.Login value)
        {
            return new List<Clients>()
            {
                new Clients { id= 0, lastName = "HUET", firstName = "Nicolas", company = "18" },
                new Clients { id= 1, lastName = "REAL", firstName = "Guillaume", company = "18"},
                new Clients { id= 2, lastName = "LEGOUX", firstName = "Alan", company = "18" },
                new Clients { id= 3, lastName = "CARPENTEUR", firstName = "Nicolas", company = "sa mere la truite"},
                new Clients { id= 4, lastName = "POLETTI", firstName = "Matthieu", company = "2"},
            };
        }

        [HttpPost]
        [Route("api/client/new")]
        public Clients Post_NewClient([FromBody]Mapping.Clients p_value)
        {
            return p_value;
        }
        [HttpPost]
        [Route("api/employee/new")]
        public Employees Post_NewEmploye([FromBody]Mapping.Employees p_value)
        {
            return p_value;
        }

        [HttpPost]
        [Route("api/employee/update")]
        public List<Mapping.Employees> Post_UpdateEmployee([FromBody]Mapping.Employees p_value)
        {
            return new List<Employees>() { p_value };
        }

        [HttpPost]
        [Route("api/client/update")]
        public List<Mapping.Clients> Post_UpdateClient([FromBody]Mapping.Clients p_value)
        {
            return new List<Clients>() { p_value };
        }

        [HttpGet]
        [Route("api/product/fetch")]
        public List<Mapping.Products> Get_AllProducts([FromBody]Mapping.Clients p_value)
        {
            return new List<Products>()
            {
                new Products { id = 0,  name = "Perceuse" , position = 0 },
                new Products { id = 1,  name = "Pompe", position = 1 },
                new Products { id = 2,  name = "Imprimante", position = 0 },
                new Products { id = 3,  name = "Tapis de course", position = 0 },
                new Products { id = 4,  name = "Robot", position = 1 },
            };
        }

        [HttpGet]
        [Route("api/product/parts/{productID}")]
        public List<Mapping.Parts> Get_PartsFromProductId([FromUri]int productID)
        {
            var coucou = new List<Parts>()
            {
                new Parts { id = 0, product = 1, name = "Perceuse" , description = "Truc qui perce" },
                new Parts { id = 1, product = 2, name = "Tonnerre" , description = "Encre" },
                new Parts { id = 2, product = 2, name = "Moteur", description = "AWS-DFS-454" },
                new Parts { id = 3, product = 2, name = "Jet d'encre", description = "SQC-ZEA5" },
                new Parts { id = 4, product = 3, name = "Tapis", description = "lol" },
                new Parts { id = 5, product = 3, name = "Course", description = "tromarrant" },
            };

            return  coucou.Where(a => a.product == productID).ToList();

        }


        [HttpGet]
        [Route("api/employee/fetch")]
        public List<Mapping.Employees> Get_AllEmployees([FromBody]Mapping.Clients p_value)
        {
            return new List<Employees>()
            {
                new Employees { lastName = "Jean", firstName = "Didier",  phone = 04423687, service = "Boulangerie" },
                new Employees { lastName = "Jean", firstName = "Michel",  phone = 06423687, service = "Crapaud"},
                new Employees { lastName = "Brigitte", firstName = "Betancour",  phone = 04423687, service = "Police"},
                new Employees { lastName = "Carpentier", firstName = "Nicolas",  phone = 09458765, service = "Politicien"},
            };
        }
    }
}

