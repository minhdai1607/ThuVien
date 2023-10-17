using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnLibrary.EntityFramework
{
    public enum Status
    {
        [Display(Name = "Hoạt động")]
        Active = 1,
        [Display(Name = "Dừng")]
        DeActive = 2,
    }
}
