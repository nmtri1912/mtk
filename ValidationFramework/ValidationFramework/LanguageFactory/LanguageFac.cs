using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.LanguageFactory
{
    class LanguageFac
    {
        // Singleton
        private static LanguageFac instance;

        private LanguageFac()
        {
        }

        public static LanguageFac getInstance()
        {
            if(instance == null)
            {
                return new LanguageFac();
            }
            return instance;
        }

        // Factory Method
        public LanguageNotification getNotificationType(string type)
        {
            switch (type)
            {
                case "vi":
                    return new Vietnamese();
                case "en":
                    return new English();
                default:
                    return null;
            }
        }
    }
}
