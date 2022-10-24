var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
/* Research local storage, or how to keep data safe for users?
 * -If sign in, learn if SQL database can have versions for different users
 * -If not sign in, learn how to create a plan in a downloadable form that is also reuploadable
 * Fill out MySqlDatabase
 * Research informational links to add to database
 * Add bill API
 * -Consider adding numbers to local and state senators
 * Look for API for ecological organizations
 * Add recycling API
 * Add functionality to make your own action plan
 * 
 * Home page that has colorful links to the main resources of the website
 * Bill search page
 * Organization API page (& get directions?)
 * Recycling centers' API page (& get directions?)
 * 
 */