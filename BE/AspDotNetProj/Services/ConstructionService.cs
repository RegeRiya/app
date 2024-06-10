using System.Collections.Generic;
using AspDotNetProj.Models;
namespace AspDotNetProj.Services {
    
    public class ConstructionService {
        
        List<ConstructionProject> _projects = null;
        public ConstructionService ()
        {
            _projects = new List<ConstructionProject>();
        }

        public List<ConstructionProject> GetProjects() {
            return _projects;
        }
        
        public void AddProject(ConstructionProject project) {
            _projects.Add(project);
        }
    }
} 