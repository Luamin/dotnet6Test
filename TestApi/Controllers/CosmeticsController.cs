using System.Net;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
public class CosmeticsController : ControllerBase {

    [HttpGet]
    public List<Cosmetics> GetCosmeticses(){
        return new List<Cosmetics>();
    }

}