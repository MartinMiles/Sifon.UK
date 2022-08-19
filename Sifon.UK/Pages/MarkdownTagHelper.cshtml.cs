using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sifon.UK.Pages
{
    public class MarkdownControlModel : PageModel
    {
        public string MarkdownText { get; set; } = 
            @"This is **Markdown Text** that was bound to a `PageModel.MarkdownText` property:

```html
<markdown markdown=""MarkdownText"" />
```
";

        public void OnGet()
        {            
        }
    }
}
