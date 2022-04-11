using FieldGroups.Data.Models;
using FieldGroups.Shared.Validators;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Additional validators
builder.Services.AddScoped<PasswordValidator>();
builder.Services.AddScoped<NotEmptyValidator>();
builder.Services.AddScoped<EmailValidator>();
builder.Services.AddScoped<PriceValidator>();
builder.Services.AddScoped<PhoneValidator>();
builder.Services.AddScoped<ZipValidator>();
builder.Services.AddScoped<BypassValidator>();
builder.Services.AddScoped<DiscountValidator>();
builder.Services.AddScoped<BaseValidator<DateRange>>();
builder.Services.AddScoped<BaseValidator<List<Rate>>>();
builder.Services.AddScoped<BaseValidator<Interval>>();

builder.Services.AddMudServices();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
