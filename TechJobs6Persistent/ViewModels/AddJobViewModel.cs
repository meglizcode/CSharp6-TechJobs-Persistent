using TechJobs6Persistent;
using TechJobs6Persistent.Models;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels;


public class AddJobViewModel {
    [Required(ErrorMessage ="Employer Id Required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Location Required")]
    public string Location { get; set; }
}