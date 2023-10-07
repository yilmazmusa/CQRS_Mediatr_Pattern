using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest deleteProductCommandRequest)
        {
            var deleteProduct = ApplicationDBContext.Products.FirstOrDefault(p => p.Id == deleteProductCommandRequest.Id);

            ApplicationDBContext.Products.Remove(deleteProduct);

            return new DeleteProductCommandResponse
            {
                IsSucces = true
            };
        }
    }
}
