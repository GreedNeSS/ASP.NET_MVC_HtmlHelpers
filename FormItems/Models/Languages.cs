using System.ComponentModel.DataAnnotations;

namespace FormItems.Models
{
    public enum Languages
    {
        [Display(Name = ".NET C#")]
        CSharp,
        [Display(Name = "NodeJS JavaScript")]
        JavaScript,
        [Display(Name = "Django Pyton")]
        Pyton,
        [Display(Name = "Spring Java")]
        Java
    }
}
