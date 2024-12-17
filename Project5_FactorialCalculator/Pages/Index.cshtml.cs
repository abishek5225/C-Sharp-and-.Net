using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int? Number { get; set; }

    public string Result { get; set; }

    public void OnPost()
    {
        if (Number < 0)
        {
            Result = "Factorial is not defined for negative numbers.";
            return;
        }

     
        long factorial = 1;
        for (int i = 1; i <= Number; i++)
        {
            factorial *= i;
        }
        Result = $"The factorial of {Number} is: {factorial}";
    }
}
