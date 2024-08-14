using System;
using Microsoft.Xrm.Sdk;

namespace CodeBase.Plugins
{
    /// <summary>
    /// Plugin to update the 'name' field of an account record.
    /// </summary>
    public class UpdateAccountNamePlugin : IPlugin
    {
        /// <summary>
        /// Executes the plugin logic.
        /// </summary>
        /// <param name="context">The service provider context.</param>
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the execution context from the service provider.
            var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            // Ensure this plugin runs in the context of an update operation on an account.
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity entity && entity.LogicalName == "account")
            {
                // Obtain the organization service reference.
                var serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                var service = serviceFactory.CreateOrganizationService(context.UserId);

                try
                {
                    // Get the account's current name.
                    string currentName = entity.Contains("name") ? (string)entity["name"] : string.Empty;

                    // Append a suffix to the account's name.
                    string newName = currentName + " - Updated";

                    // Create a new entity with the updated name.
                    var updatedAccount = new Entity(entity.Id)
                    {
                        ["name"] = newName
                    };

                    // Update the account record.
                    service.Update(updatedAccount);
                }
                catch (Exception ex)
                {
                    // Handle exceptions and log errors.
                    throw new InvalidPluginExecutionException("An error occurred in UpdateAccountNamePlugin.", ex);
                }
            }
        }
    }
}
