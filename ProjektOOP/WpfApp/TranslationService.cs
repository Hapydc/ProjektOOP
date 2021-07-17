using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class TranslationService
    {
        public static string GetTranslationByKey(string translationKey)
        {
            var resourceManger = new ResourceManager("Resource",
               Assembly.GetExecutingAssembly());

            return resourceManger.GetString(translationKey);
        }
    }
}
