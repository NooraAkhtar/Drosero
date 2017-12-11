using Drosero.ServiceModel.Responses;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Drosero.ServiceModel.Requests
{
    [Route("/category", Verbs = "GET")]
    [Api("Catalog Service")]
    [Route("/category/{id}")]
    [Route("/category/{name}", Verbs = "GET, PUT")]
    public class CategoryRequest : IReturn<CategoryResponse>
    {
        [DataMember]
        [ApiMember(Name = "id", Description = "id", IsRequired = true)]
        [ApiAllowableValues("id", Type = "int")]
        public int Id { get; set; }

        [DataMember]
        [ApiMember(Name = "name", Description = "Category Name", IsRequired = true)]
        [ApiAllowableValues("name", Type = "string")]
        public string Name { get; set; }
    }
}
