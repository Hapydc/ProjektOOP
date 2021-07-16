using System.Reflection;
using System.Resources;

namespace ProjektOOP
{
    public class TranslationService
    {
        public static string GetTranslationByKey(string translationKey)
        {
            var resourceManger = new ResourceManager("ProjektOOP.Resource",
               Assembly.GetExecutingAssembly());

            return resourceManger.GetString(translationKey);
        }
    }
}
