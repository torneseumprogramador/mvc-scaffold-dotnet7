public class Routes
{
    public static void Registar(WebApplication app)
    {
        app.MapControllerRoute(
            name: "nova_home",
            pattern: "nova_home",
            defaults: new { controller = "Home", action = "Index" }
        );

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
    }
}