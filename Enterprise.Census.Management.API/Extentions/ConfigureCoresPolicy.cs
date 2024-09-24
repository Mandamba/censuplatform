namespace Enterprise.Census.Management.API.Extentions
{
    public static class CorsPolicyExtensions
    {
        public static void ConfigureCoresPolicy(this IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddDefaultPolicy(builder => builder 
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }
    }
}
