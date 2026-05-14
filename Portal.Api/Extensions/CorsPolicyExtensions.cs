namespace Portal.Api.Extensions;
public static class CorsPolicyExtensions
{
    public static void ConfigureCorsPolicy(this IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddDefaultPolicy(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });

        //         builder.Services.AddCors(options =>
        // {
        //     options.AddPolicy("AllowAll",
        //         builder =>
        //         {
        //             builder.AllowAnyOrigin()
        //                    .AllowAnyMethod()
        //                    .AllowAnyHeader();
        //         });
        // });

    }
}