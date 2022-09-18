namespace Task
{
    internal class StudentClass
    {
        public void StdClass()
        {
           StudentClass Sc = new StudentClass();
            Sc.StudentName = "Musab";
            Sc.Email = "musabsheikh2002@gmail.com";
            Sc.City = "Chandrapur";
            Sc.Age = 20;
            Console.WriteLine($"StudentName:- {Sc.StudentName}");
            Console.WriteLine($"Email Id:- {Sc.Email}");
            Console.WriteLine($"City:- {Sc.City}");
            Console.WriteLine($"Age:- {Sc.Age}");


        }
        public string StudentName;
        public string Email;
        public string City;
        public int Age;


    }
}
