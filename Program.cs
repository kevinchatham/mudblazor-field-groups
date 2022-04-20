using FieldGroups.Data.Models;
using FieldGroups.Shared.Validators;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();

// Register validators with dependency injection.
builder.Services.AddTransient<AddressValidator>();
builder.Services.AddTransient<CityValidator>();
builder.Services.AddTransient<DescriptionValidator>();
builder.Services.AddTransient<DiscountValidator>();
builder.Services.AddTransient<EmailExistsValidator>();
builder.Services.AddTransient<EmailValidator>();
builder.Services.AddTransient<MatchesValidator>();
builder.Services.AddTransient<NameValidator>();
builder.Services.AddTransient<NoteValidator>();
builder.Services.AddTransient<PasswordValidator>();
builder.Services.AddTransient<PhoneValidator>();
builder.Services.AddTransient<PriceValidator>();
builder.Services.AddTransient<ZipValidator>();

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
