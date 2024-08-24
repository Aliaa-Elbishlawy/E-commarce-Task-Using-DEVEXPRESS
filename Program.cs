using Microsoft.Extensions.Configuration;

namespace E_commarce
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize the configuration builder and load the appsettings.json file
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();

            // Retrieve the connection string
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Create and run the ProductForm
            Application.Run(new Landing(connectionString));
        }
    }
}