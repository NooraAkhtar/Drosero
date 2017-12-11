using Drosero.ServiceModel.Responses;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Drosero.ServiceModel.Requests
{
    [Route("/foodItem", Verbs = "GET")]
    [Api("FoodItem Service")]
    [Route("/foodItem/{id}")]
    [Route("/foodItem/{name}", Verbs = "GET, PUT")]
    [Route("/foodItem/{categoryId}", Verbs = "GET, PUT")]
    public class FoodItemRequest:IReturn<FoodItemResponse>
    {
        [DataMember]
        [ApiMember(Name = "id", Description = "id", IsRequired = true)]
        [ApiAllowableValues("id", Type = "int")]
        public int Id { get; set; }

        [DataMember]
        [ApiMember(Name = "name", Description = "Food Item Name")]
        [ApiAllowableValues("name", Type = "string")]
        public string Name { get; set; }

        [DataMember]
        [ApiMember(Name = "categoryId", Description = "Category Id")]
        [ApiAllowableValues("CategoryId", Type = "int")]
        public string CategoryId { get; set; }
    }
}
