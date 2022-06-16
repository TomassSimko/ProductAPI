using ProductAPI.Controllers;
using ProductAPI.BindingModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProductAPI.Models;
using ProductAPI.Repositories;

namespace ProductAPI.Controllers; 

public class ProductController : DefaultController {
    private readonly ICharacterRepository _productRepository;
    
    #region GET
    [HttpGet()]
    // [AllowAuthorized(AccessRoles.Admin)]
    //[AllowAnonymous]
    public async Task<IActionResult> GetAllAsync ()
    {
        List<Product> productList = await _productRepository.GetAsync();
        if (productList.IsNullOrEmpty())
            return BadRequest($"Could not find any products");
        return Ok(productList);
    }
    
    
    [HttpGet("{id}")]
    //[AllowAuthorizedAttribute(AccessRoles.Admin)]
    public async Task<IActionResult> GetAsyncById(string id)
    {
        // Product product = await _productService.GetAsyncById(id);
        // if (product != null) 
        //     return Ok (product);
        // return BadRequest($"Could not find product with Id : {id}");
        return null;
    }

    #endregion
    
    #region POST
    [HttpPost()]
    //[AllowAuthorizedAttribute(AccessRoles.Admin)]
    public async Task<IActionResult> CreateAsync([FromBody]PostProductModel request)
    {
       //  // move to services 
       //  Product product = new Product()
       // {
       //     Id = Guid.NewGuid().ToString(),
       //     Title = request.Title,
       //     Description = request.Description,
       //     DoB = DateTime.Now,
       //     AgeLimit = request.AgeLimit
       //
       // };
       //  Product resultProduct = await _productService.CreateAsync(product);
       //  
       //  if(resultProduct == null) 
       //      return BadRequest($"Could not create product");
       //  return Ok(resultProduct);
       return null;
    }
 
    
    #endregion
    
    #region PUT
    [HttpPut()]
    //[Authorize(Roles ="Admin")]
    public async Task<IActionResult> UpdateAsync([FromBody]PostProductModel request)
    {
            // implement update 
        return null;
    }
    
    #endregion

    
    #region DELETE

    [HttpDelete("{id}")]
    //[Authorize(Roles ="Admin")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        // Product fetchedProduct = await _productService.GetAsyncById(id);
        // if(fetchedUser == null) BadRequest($"Could not find product with {id}");
        // bool result = await _productService.DeleteAsync(fetchedProduct.Id); 
        // if(result == null) BadRequest($"Could not delete product with {id}");
        // return Ok($"User with Id : {id} has been deleted !");
        return null;
    }
    #endregion
    
}