using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest getAllProductQueryRequest)
        {
            return ApplicationDBContext.Products.Select( product => new GetAllProductQueryResponse{

                Id = product.Id,
                Name= product.Name,
                Quantity = product.Quantity,
                Price= product.Price,
                CreateTime= product.CreateTime
            }).ToList();
        }
    }
}
