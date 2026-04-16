using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// ── Short routes ──
app.MapControllerRoute(name: "career", pattern: "career", defaults: new { controller = "Career", action = "Career" });
app.MapControllerRoute(name: "contact", pattern: "contact", defaults: new { controller = "ContactUs", action = "ContactUs" });
app.MapControllerRoute(name: "about", pattern: "about", defaults: new { controller = "About", action = "CompanyProfile" });
app.MapControllerRoute(name: "fleet", pattern: "fleet", defaults: new { controller = "Fleet", action = "FleetOverview" });
app.MapControllerRoute(name: "esg", pattern: "esg", defaults: new { controller = "ESG", action = "ESG" });
app.MapControllerRoute(name: "news", pattern: "news", defaults: new { controller = "News", action = "News" });
app.MapControllerRoute(name: "license", pattern: "license", defaults: new { controller = "License_Cert", action = "License" });
app.MapControllerRoute(name: "sitemap", pattern: "sitemap.xml", defaults: new { controller = "Sitemap", action = "Sitemap" });

// ── Hyphenated top-level routes ──
app.MapControllerRoute(name: "contact-us", pattern: "contact-us", defaults: new { controller = "ContactUs", action = "ContactUs" });
app.MapControllerRoute(name: "contact-us-s", pattern: "contact-us/", defaults: new { controller = "ContactUs", action = "ContactUs" });
app.MapControllerRoute(name: "career-h", pattern: "career/", defaults: new { controller = "Career", action = "Career" });
app.MapControllerRoute(name: "esg-h", pattern: "esg/", defaults: new { controller = "ESG", action = "ESG" });
app.MapControllerRoute(name: "news-h", pattern: "news/", defaults: new { controller = "News", action = "News" });
app.MapControllerRoute(name: "license-cert", pattern: "license-cert", defaults: new { controller = "License_Cert", action = "License" });

// ── About Us nested routes (Google indexed these) ──
app.MapControllerRoute(name: "about-us", pattern: "about-us", defaults: new { controller = "About", action = "CompanyProfile" });
app.MapControllerRoute(name: "about-us-s", pattern: "about-us/", defaults: new { controller = "About", action = "CompanyProfile" });
app.MapControllerRoute(name: "about-company-profile", pattern: "about-us/company-profile", defaults: new { controller = "About", action = "CompanyProfile" });
app.MapControllerRoute(name: "about-company-profile-s", pattern: "about-us/company-profile/", defaults: new { controller = "About", action = "CompanyProfile" });
app.MapControllerRoute(name: "about-md-greeting", pattern: "about-us/md-greeting", defaults: new { controller = "About", action = "MdMeeting" });
app.MapControllerRoute(name: "about-md-greeting-s", pattern: "about-us/md-greeting/", defaults: new { controller = "About", action = "MdMeeting" });
app.MapControllerRoute(name: "about-vision", pattern: "about-us/vision-mission", defaults: new { controller = "About", action = "VisionMission" });
app.MapControllerRoute(name: "about-vision-s", pattern: "about-us/vision-mission/", defaults: new { controller = "About", action = "VisionMission" });
app.MapControllerRoute(name: "about-core", pattern: "about-us/core-values", defaults: new { controller = "About", action = "CoreValues" });
app.MapControllerRoute(name: "about-core-s", pattern: "about-us/core-values/", defaults: new { controller = "About", action = "CoreValues" });
app.MapControllerRoute(name: "about-hse", pattern: "about-us/hse", defaults: new { controller = "About", action = "HSE" });
app.MapControllerRoute(name: "about-hse-s", pattern: "about-us/hse/", defaults: new { controller = "About", action = "HSE" });
app.MapControllerRoute(name: "about-corporate-structure", pattern: "about-us/corporate-structure", defaults: new { controller = "About", action = "CompanyProfile" });
app.MapControllerRoute(name: "about-corporate-s", pattern: "about-us/corporate-structure/", defaults: new { controller = "About", action = "CompanyProfile" });

// ── Default route (always LAST) ──
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Home}/{id?}");

app.Run();