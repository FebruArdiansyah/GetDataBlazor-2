using GetDataBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); 
builder.Services.AddServerSideBlazor();

// Gunakan IHttpClientFactory agar tidak ada konflik Singleton-Scoped
builder.Services.AddHttpClient<CommentService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
