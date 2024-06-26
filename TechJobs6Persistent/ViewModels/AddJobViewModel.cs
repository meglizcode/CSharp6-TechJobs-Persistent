using TechJobs6Persistent;
using TechJobs6Persistent.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobs6Persistent.ViewModels;


public class AddJobViewModel {
    private List<Employer> employers;
    [Required(ErrorMessage ="Job Needs a Name")]
    public string Name { get; set; }
    public int EmployerId { get; set; }
    public List<SelectListItem>? Employers { get; set; } 
    public AddJobViewModel() {}
    public AddJobViewModel(List<Employer> employers)
    {
        Employers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
            }
    }
    
}