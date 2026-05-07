using FormSubmission.AdminPortal.Components; using FormSubmission.AdminPortal.Services;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddHttpClient("Api", c => c.BaseAddress = new Uri(builder.Configuration["ApiBaseUrl"] ?? "https://localhost:7001/"));
builder.Services.AddScoped<SubmissionApiService>(); builder.Services.AddScoped<AuthStateService>();
var app = builder.Build();
if (!app.Environment.IsDevelopment()) { app.UseExceptionHandler("/Error"); app.UseHsts(); }
app.UseHttpsRedirection(); app.UseStaticFiles(); app.UseAntiforgery();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode(); app.Run();
