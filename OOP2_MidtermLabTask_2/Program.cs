using System;

namespace OOP2_MidtermLabTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ServiceProvider.Insert(new Manager("PH-01", "Shuvo", "Uttara", 5));
            ServiceProvider.Insert(new Manager("PH-02", "Jahid", "Badda", 1));
            ServiceProvider.Insert(new Laborer("PL-001", "Shohan", "Mirpur", 85, 20));
            ServiceProvider.Insert(new Laborer("PL-002", "Jisan", "Kuril", 65, 44));
            ServiceProvider.Insert(new Laborer("PL-003", "Numan", "Banani", 88, 3));

            // Manager(id, name, address, yearsofExperience)
            // Laborer(id, name, address, userrating, noOfServices)

            ServiceProvider.ProvideDetails();
            ServiceProvider.SkilledWorder();

        }
    }
}
