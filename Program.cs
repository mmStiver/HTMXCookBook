using HtmxCookbook.Pages.ClickToEdit;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddSingleton<HtmxCookbook.Pages.ClickToEdit.IContactService, HtmxCookbook.Pages.ClickToEdit.ContactService>();
builder.Services.AddSingleton<HtmxCookbook.Pages.BulkUpdate.IContactService, HtmxCookbook.Pages.BulkUpdate.ContactService>();
builder.Services.AddSingleton<HtmxCookbook.Pages.DeleteRow.IContactService, HtmxCookbook.Pages.DeleteRow.ContactService>();
builder.Services.AddSingleton<HtmxCookbook.Pages.EditRow.IContactService, HtmxCookbook.Pages.EditRow.ContactService>();

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddAntiforgery(options => options.ign = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
