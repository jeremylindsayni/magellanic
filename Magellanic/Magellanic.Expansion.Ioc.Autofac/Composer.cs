using Autofac;
using Magellanic.Expansion.Ioc.Autofac.Interfaces;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;

namespace Magellanic.Expansion.Ioc.Autofac
{
    public class Composer
    {
        private Assembly AssemblyContainingTypesForComposition { get; set; }

        private ContainerBuilder ContainerBuilder { get; set; }

        public Composer(Assembly assemblyContainingTypesForComposition, ContainerBuilder builder)
        {
            this.AssemblyContainingTypesForComposition = assemblyContainingTypesForComposition;
            this.ContainerBuilder = builder;
        }

        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public Composer(Type typeFoundInAssembly, ContainerBuilder builder)
        {
            Contract.Requires<ArgumentNullException>(typeFoundInAssembly != null, "must not pass in a null type - it is necessary to de-reference this type to identify the enclosing assembly.");

            this.AssemblyContainingTypesForComposition = typeFoundInAssembly.Assembly;
            this.ContainerBuilder = builder;
        }

        /// <summary>
        /// Registers the composable types in container builder.
        /// </summary>
        public void RegisterComposableTypesInContainerBuilder()
        {
            IComposable assemblyInstance;
            
            var listOfMatchingTypes = this.AssemblyContainingTypesForComposition
                .GetTypes()
                .Where(m => typeof(IComposable).IsAssignableFrom(m))
                .ToList();

            foreach (var composableType in listOfMatchingTypes)
            {
                Contract.Assume(composableType != null);
                assemblyInstance = this.GetComposableAssembly(composableType);
                assemblyInstance.RegisterType();
            }
        }

        private IComposable GetComposableAssembly(Type composableType)
        {
            Contract.Requires<ArgumentNullException>(composableType != null, "The composable type cannot be null");
            
            var assembly = Activator.CreateInstance(composableType, this.ContainerBuilder) as IComposable;

            Contract.Assume(assembly != null);

            return assembly;
        }
    }
}
