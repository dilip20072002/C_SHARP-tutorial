using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class A_Basic
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello from new repo!");
            // B_DataType.ShowData(args);            // C# basically run at Visual Studio platform, but I am using it in GitHub Cdoespace so every new created file(public method) will be called in First Program through Main() method, after this process we can run that new file, just like it...
            // C_String.ShowString(args);
            // D_Number.ShowNumber(args);
            // E_GetInput.GetInput(args);
            // F_Array.ShowArray(args);
            // G_Method.ShowMethod(args);
            // H_Statement.ShowStatement(args);
            // I_Loop.ShowLoop(args);
            // J_Exception.ShowException(0args);

            // calling K_Class
            K_Class MyIntro = new K_Class();
            MyIntro.name = "John Doe";
            MyIntro.address = "123 Main St";
            MyIntro.age = 30;
            // Console.WriteLine("Name: " + MyIntro.name);
            // Console.WriteLine("Address: " + MyIntro.address);
            // Console.WriteLine("Age: " + MyIntro.age);
            // End of K_Class usage

            // calling L_Constructor
            L_Constructor defaultConstructor = new L_Constructor();
            // Console.WriteLine("Default Constructor Name: " + defaultConstructor.name);
            L_Constructor parameterizedConstructor = new L_Constructor("Custom Name");
            // Console.WriteLine("Parameterized Constructor Name: " + parameterizedConstructor.name);
            // End of L_Constructor usage

            // calling M_Object
            M_Object myObject = new M_Object();
            // Console.WriteLine("Object Age: " + myObject.age(23));
            // End of M_Object usage

            // calling N_Getter_Setter
            N_Getter_Setter person1 = new N_Getter_Setter("Rohan", "456 Elm St", 28);
            N_Getter_Setter person2 = new N_Getter_Setter("Shubham", "432 Lam Xt", 25);
            // Console.WriteLine("Person 1 Name: " + person1.name);
            // Console.WriteLine("Person 1 Address: " + person1.address);
            // Console.WriteLine("Person 1 Age: " + person1.Age);
            // Console.WriteLine("Person 2 Name: " + person2.name);
            // Console.WriteLine("Person 2 Address: " + person2.address);
            // Console.WriteLine("Person 2 Age: " + person2.Age);
            // End of N_Getter_Setter usage

            // calling O_Static Class Attribute
            O_Static song1 = new O_Static("Song Title", "Artist Name", 240);
            // Console.WriteLine("Song 1: " + O_Static.songCount);
            O_Static song2 = new O_Static("Song Title", "Artist Name", 240);
            // Console.WriteLine("Song 2: " + O_Static.songCount);
            // End of O_Static usage

            // calling Inheritance 'P_Chef'
            P_Chef chef = new P_Chef();
            // chef.MakeCHicken();
            // chef.MakeFish();
            // chef.MakeSpecialDish();
            Q_ItalianChef italianChef = new Q_ItalianChef();
            // italianChef.MakeCHicken();
            // italianChef.MakePasta();
            // italianChef.MakeSpecialDish();
            // End of P_Chef usage

        }
    }
}