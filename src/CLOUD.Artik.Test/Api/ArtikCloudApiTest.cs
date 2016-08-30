using System.IO;
using CLOUD.Artik.Test.Utils;

namespace CLOUD.Artik.Test
{
    public abstract class ArtikCloudApiTest
    {
        private const string PROPERTIES_FILENAME = "artik.properties";
        protected Properties Properties = new Properties();

        /**
         * Loads the artik.properties
         */

        protected ArtikCloudApiTest()
        {
            Properties.LoadFromFile(PROPERTIES_FILENAME);
        }
    }
}