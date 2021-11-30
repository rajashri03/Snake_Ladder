using System;
class Employeewage
{
    public static void Main()
    {
        //UC1
        UC1_Start uc1 = new UC1_Start();

        //UC2
        UC2_ToGetNum0_6 uc2 = new UC2_ToGetNum0_6();
       

        bool isRun = true;
        while (isRun)
        {
            Console.WriteLine("\nSelect UC Number:\n" +
                "1.Start \n" +
                "2.Rolls the die\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    uc1.Start();
                    break;
                case 2:
                    uc2.GetNumber();
                    break;
                default:
                    isRun = !isRun;
                    break;
            }
        }

    }
}