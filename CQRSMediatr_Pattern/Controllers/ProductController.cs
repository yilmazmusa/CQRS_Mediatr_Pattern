using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using DAL.CQRS.Handlers.CommandHandlers;
using DAL.CQRS.Handlers.QueryHandlers;
using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using Microsoft.AspNetCore.Mvc;


namespace CQRSMediatr_Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class ProductController : ControllerBase
    {
        CreateProductCommandHandler _createProductCommandHandler;
        DeleteProductCommandHandler _deleteProductCommandHandler;
        GetAllProductQueryHandler _getAllProductQueryHandler;
        GetByIdProductQueryHandler _getByIdProductQueryHandler;


        public ProductController(
        CreateProductCommandHandler createProductCommandHandler,
        DeleteProductCommandHandler deleteProductCommandHandler,
        GetAllProductQueryHandler getAllProductQueryHandler,
        GetByIdProductQueryHandler getByIdProductQueryHandler)
        {
            _createProductCommandHandler = createProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getAllProductQueryHandler = getAllProductQueryHandler;
            _getByIdProductQueryHandler = getByIdProductQueryHandler;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll([FromQuery] GetAllProductQueryRequest requestModel)
        {
            List<GetAllProductQueryResponse> allProducts = _getAllProductQueryHandler.GetAllProduct(requestModel);
            
            return Ok(allProducts);
        }

        [HttpGet("Get")]
        public IActionResult Get([FromQuery] GetByIdProductQueryRequest requestModel)
        {
            GetByIdProductQueryResponse product = _getByIdProductQueryHandler.GetByIdProduct(requestModel);
            return Ok(product);
        }

        [HttpPost("CreateProduct")]
        public IActionResult Create([FromQuery] CreateProductCommandRequest requestModel)
        {
            CreateProductCommandResponse createProduct = _createProductCommandHandler.CreateProduct(requestModel);

            return Ok(createProduct);
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult Delete([FromQuery] DeleteProductCommandRequest requestModel)
        {
            DeleteProductCommandResponse deleteProduct = _deleteProductCommandHandler.DeleteProduct(requestModel);
            return Ok(deleteProduct);
        }
    }


}
