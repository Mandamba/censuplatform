namespace Enterprise.Census.Management.API.Extentions
{
    public static class CorsPolicyExtensions
    {
        public static void ConfigureCoresPolicy(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", builder =>
                {
                    builder.WithOrigins("https://censusplatformfrontend.vercel.app")
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
        }
    }
}
