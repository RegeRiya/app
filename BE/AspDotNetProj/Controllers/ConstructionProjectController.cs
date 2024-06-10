using Microsoft.AspNetCore.Mvc;
using AspDotNetProj.Services;
using AspDotNetProj.Models;

 namespace AspDotNetProj.Controllers{
    
    [ApiController]
    [Route("[controller]")]
    public class ConstructionProjectController : ControllerBase 
    {
        ConstructionService _constructionService;
        
         public ConstructionProjectController ()
        {
            _constructionService = new ConstructionService();
        }

        [HttpGet]
        public ActionResult Get ()
        {
            return Ok(_constructionService.GetProjects());
        }

        [HttpPost]
        public ActionResult Post (ConstructionProject project) 
        {
            this._constructionService.AddProject(project);
            return Ok();
        }
    }
 
 }