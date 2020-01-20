using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.File.Default;
using R5T.Dacia.Extensions;
using R5T.Lombardy;


namespace R5T.Bath.File.Chamavia.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddHumanOutputFilePathProvider_DirectConfigurationBased<TStringlyTypedPathOperator>(this IServiceCollection services)
            where TStringlyTypedPathOperator : class, IStringlyTypedPathOperator
        {
            services
                .AddSingleton<IHumanOutputFilePathProvider, DirectConfigurationBasedHumanOutputFilePathProvider>()
                .TryAddSingletonFluent<IStringlyTypedPathOperator, TStringlyTypedPathOperator>()
                ;

            return services;
        }

        public static IServiceCollection AddHumanOutputFilePathProvider_DirectConfigurationBasedFromDirectoryPathAndFileName<TStringlyTypedPathOperator>(this IServiceCollection services)
            where TStringlyTypedPathOperator : class, IStringlyTypedPathOperator
        {
            services
                .AddSingleton<IHumanOutputFilePathProvider, DefaultHumanOutputFilePathProvider>()
                .AddSingleton<IHumanOutputFileDirectoryPathProvider, DirectConfigurationBasedHumanOutputFileDirectoryPathProvider>()
                .AddSingleton<IHumanOutputFileNameProvider, DirectConfigurationBasedHumanOutputFileNameProvider>()
                .TryAddSingletonFluent<IStringlyTypedPathOperator, TStringlyTypedPathOperator>()
                ;

            return services;
        }
    }
}
