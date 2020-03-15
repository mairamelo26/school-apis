using System.ComponentModel;

namespace Utils.Constants
{
    public static class GlobalVars
    {
        //TODO: Must replace this by a get current location dynamically
        //public static string LOCAL_URL = "http://gdpr.pessoaseprocessos.com/";
        //public static string LOCAL_URL = "http://firestar.pep.int/";
        public static string LOCAL_URL = "http://localhost:4200/";
        //public static string LOCAL_URL = "https://portal.izyrgpd.com/";



        public static int PAGE_SIZE = 12;

        public static int HTTP_ERROR_UNPROCESSABLE_ENTITY = 422;
        
        public enum AppEmailEnum
        {
            //[Description("suporte@izyrgpd.com")]
            [Description("gdpr.teste@pessoaseprocessos.com")]
            Support = 1,
            //[Description("comercial@izyrgpd.com")]
            [Description("gdpr.teste@pessoaseprocessos.com")]
            Comercial = 2
        }

    }
}
