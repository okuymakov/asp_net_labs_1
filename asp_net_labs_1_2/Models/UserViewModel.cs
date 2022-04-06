using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asp_net_labs_1_2.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="Укажите имя")]
        public string Name { get; set; }
        public List<string> Languages { get; set; } = new() { };
        [Required(ErrorMessage = "Укажите группу")]
        public string Group { get; set; }
        [Required(ErrorMessage = "Укажите пол")]
        public string Gender { get; set; }

    }

    
    public class Groups
    {
        public static List<string> All { get; private set; } = new()
        {
            "б1-ИФСТ-21",
            "б1-ИФСТ-22",
            "б2-ИФСТ-21",
            "б2-ИФСТ-22"
        };
    }

    public class Languages
    {
        public static List<string> All { get; private set; } = new()
        {
            "Java",
            "C#",
            "Js",
            "Python",
            "C++"
        };
    }
}
