var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();//Hello-st dfdffdfffsdfcvcv fgbbgbbngfgfgfgvcvvcvc

// Configure the HTTP request pipeline.ffggfgfgfbbvbvbvbvbvbvbvdfdfff
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");//ghghghg
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();//ggggg

app.UseRouting();

app.UseAuthorization();//Hello second person


app.MapRazorPages();//Hello11111111

app.MapRazorPages();//Hello2222


app.Run();//hello1111
