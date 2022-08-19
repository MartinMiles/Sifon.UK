using Markdig;
using Markdig.Extensions.AutoIdentifiers;
using Westwind.AspNetCore.Markdown;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRouting();
builder.Services.AddHealthChecks();

builder.Services.AddMarkdown(config =>
{
    // optional Tag BlackList
    config.HtmlTagBlackList = "script|iframe|object|embed|form"; // default

    // Simplest: Use all default settings
    var folderConfig = config.AddMarkdownProcessingFolder("/content/", "~/Pages/__MarkdownPageTemplate.cshtml");

    // Customized Configuration: Set FolderConfiguration options
    //folderConfig = config.AddMarkdownProcessingFolder("/posts/", "~/Pages/__MarkdownPageTemplate.cshtml");

    // Optionally strip script/iframe/form/object/embed tags ++
    folderConfig.SanitizeHtml = false;  //  default

    // Optional configuration settings
    folderConfig.ProcessExtensionlessUrls = true;  // default
    folderConfig.ProcessMdFiles = true; // default

    // Optional pre-processing - with filled model
    folderConfig.PreProcess = (model, controller) =>
    {
        // controller.ViewBag.Model = new MyCustomModel();
    };

    // folderConfig.BasePath = "https://github.com/RickStrahl/Westwind.AspNetCore.Markdow/raw/master";

    // Create your own IMarkdownParserFactory and IMarkdownParser implementation
    // to replace the default Markdown Processing
    //config.MarkdownParserFactory = new CustomMarkdownParserFactory();                 

    // optional custom MarkdigPipeline (using MarkDig; for extension methods)
    config.ConfigureMarkdigPipeline = builder =>
    {
        builder.UseEmphasisExtras(Markdig.Extensions.EmphasisExtras.EmphasisExtraOptions.Default)
            .UsePipeTables()
            .UseGridTables()
            .UseAutoIdentifiers(AutoIdentifierOptions.GitHub) // Headers get id="name" 
            .UseAutoLinks() // URLs are parsed into anchors
            .UseAbbreviations()
            .UseYamlFrontMatter()
            .UseEmojiAndSmiley(true)
            .UseListExtras()
            .UseFigures()
            .UseTaskLists()
            .UseCustomContainers()
            //.DisableHtml()   // renders HTML tags as text including script
            .UseGenericAttributes();
    };
});

// We need to use MVC so we can use a Razor Configuration Template
// for the Markdown Processing Middleware
builder.Services.AddMvc()
    // have to let MVC know we have a controller otherwise it won't be found
    .AddApplicationPart(typeof(MarkdownPageProcessorMiddleware).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "index.md", "index.html" }
});

app.MapHealthChecks("/healthz");

app.UseHttpsRedirection();

app.UseMarkdown();
app.UseRouting();
app.UseStaticFiles();


//app.UseMvc();

//app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapDefaultControllerRoute();
});

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
