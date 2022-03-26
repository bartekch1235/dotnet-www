using System.ComponentModel.DataAnnotations;

namespace trololo.Models
{
    public class FizzBuzz
    {

        [Required,Range(1898, 2023, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]


        [Display(Name = "Twój szczęśliwy numerek")]
        public int? Number { get; set; }

        [Required,MaxLength(99,ErrorMessage ="tak sie wcale nie nazywasz!!!")]
        [Display(Name = "Twój szczęśliwy imie")]
        public string? Imie { get; set; } 
        public string CheckRange()
        {
            if(Number == null)
            {
                
                return "to nie powinno tu byc";
            }
            if(Number>2022||Number<1989)
                return "zla data";
            if (Imie.Length<100 )
                return "zle imie";

            else
                return "zle";
        }
        public bool Check()
        {
            if(Number>1898&&Number<2023&&Imie!=null&&Imie.Length<100)
            {
                return true;
            }
            return false;
        }
        public string Przestepca()
        {
            if (Number % 4 == 0)
                return "przestepca";
                    return "nie przestepca";
        }

    }
}
