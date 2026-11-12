
namespace EnviosExpress.Properties
{
    using System.Drawing;
    using System.Globalization;
    using System.Resources;

    internal static class Resources
    {
        private static ResourceManager resourceManager;

        internal static ResourceManager ResourceManager
        {
            get
            {
                if (resourceManager == null)
                    resourceManager = new ResourceManager("EnviosExpress.Properties.Resources", typeof(Resources).Assembly);

                return resourceManager;
            }
        }

    }
}
