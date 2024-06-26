using TechJobs6Persistent;
using TechJobs6Persistent.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobs6Persistent.ViewModels;


public class AddJobViewModel {
    private List<Employer> employers;

    public AddJobViewModel(List<Employer> employers)
    {
        this.employers = employers;
    }

    [Required(ErrorMessage ="Job Needs a Name")]
    public string Name { get; set; }
    public int EmployerId { get; set; }
    public List<SelectListItem>? Employers { get; set; } 
}