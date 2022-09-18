using System.Reflection;

namespace Task
{

    public class MobileClass
    {
        
        public class Mobile
        {
            public string CompanyName;
            public string ModelName;
            public float ScreenSize;
            public int Ram;
        }
        public void Class()
        {
            MobileClass.Mobile M1 = new MobileClass.Mobile();
            M1.CompanyName = "Mi";
            M1.ModelName = "Poco F1";
            M1.ScreenSize = 6;
            M1.Ram = 6;
            Console.WriteLine($"CompanyName:- {M1.CompanyName}");
            Console.WriteLine($"ModelName:- {M1.ModelName}");
            Console.WriteLine($"ScreenSize:- {M1.ScreenSize}");
            Console.WriteLine($"{M1.Ram}Gb Ram");

        }


    }
}
