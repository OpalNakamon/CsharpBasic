// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello {0}", "world");
//Console.WriteLine("Hello {0}", 2019-2023);

/////////ลองสร้างตัวแปร
//int num1 = 0;
//long num2 = 10;

//Console.WriteLine("num1 = {0}", num1);
//Console.WriteLine("num2 = {0}", num2);
//Console.WriteLine($"num1 = {num1}");

//////// Parse Method to convert data
//string numtext1 = "100";
//string numtext2 = "500";

//int num1 = int.Parse(numtext1);
//int num2 = int.Parse(numtext2);

//Console.WriteLine(num1 + num2);

/////////input ข้อมูล
//Console.Write("Num1 : ");
//string Num1 = Console.ReadLine();

//Console.Write("Num2 : ");
//string Num2 = Console.ReadLine();

//Console.WriteLine($"(Num1) + (Num2) = (Num1+Num2)");

//////////////////////////////////////////////Lab 01
///student1
//Console.WriteLine("---Student1---");
//Console.Write("Name : ");
//string name1 = Console.ReadLine(); 

//Console.Write("Input Weight(kg) : ");
//double w1 = double.Parse(Console.ReadLine());

//Console.Write("Input Height(cm) : ");
//double h1 =double.Parse(Console.ReadLine());

///student2
//Console.WriteLine("---Student2---");
//Console.Write("Name : ");
//string name2 = Console.ReadLine();
//Console.Write("Inpur Weight(kg) : ");
//double w2 = double.Parse(Console.ReadLine());
//Console.Write("Inpur Height(cm) : ");
//double h2 = double.Parse(Console.ReadLine());

///หาค่า bmi 1
//double BMI1 = Math.Round(w1 / Math.Pow(h1 / 100, 2), 2);
//double BMI2 = Math.Round(w2 / Math.Pow(h2 / 100, 2), 2);

//Console.WriteLine{$"\n(name1.ToUpper())}
//Console.WriteLine($"\n(name2.ToUpper()) BMI = (BMI2)");

//Console.WriteLine($"\nMax BMI = " ,(Math.Max(BMI1,BMI2)));


///////////////////////////////Lab02

///input position
// Console.Write("Your Position : ");
//string position = Console.ReadLine();
///input salary
//Console.Write("Your Salary : ");
//float salary = float.Parse(Console.ReadLine());

//float addedSalary = 0f;

//        if (position == "Assistant Developer")
//  {
//addedSalary = salary * 0.05f;
//}
//else if (position == "IT Support")
//{
//addedSalary = salary * 0.07f;
//}
//else if (position == "Senior Developer")
//{
//addedSalary = salary * 0.1f;
//}
//   else if (position == "Administrator")
//{
//addedSalary = salary * 0.08f;
// }
//  else
//{
//addedSalary = salary * 0.03f;
//}

//salary += addedSalary; 
//Console.WriteLine($"Your salary will be increased to : {salary}");

/////////////////////////////////////////////////lab3




///input number of student  
/*Console.Write("Number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        string[] studentIds = new string[numberOfStudents];
        int[] studentScores = new int[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write("Student Id : ");
            string studentId = Console.ReadLine();

            // Check if student ID already exists
            int existingIndex = Array.IndexOf(studentIds, studentId);
            if (existingIndex != -1)
            {
                Console.WriteLine($"Updating score for student {studentId}");
                Console.Write("Score: ");
                studentScores[existingIndex] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Student score: ");
                int studentScore = int.Parse(Console.ReadLine());
                studentIds[i] = studentId;
                studentScores[i] = studentScore;
            }
        }

        Console.Write("Exit? (Y/N): ");
        string exitInput = Console.ReadLine();

        while (exitInput != "Y")
        {
            Console.Write("Student ID: ");
            string studentId = Console.ReadLine();

            // Check if student ID already exists
            int checkIndex = Array.IndexOf(studentIds, studentId);
            if (checkIndex != -1)
            {
                Console.WriteLine($"Update score for {studentId}");
                Console.Write("Student score: ");
                studentScores[checkIndex] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Student score: ");
                int studentScore = int.Parse(Console.ReadLine());
                Array.Resize(ref studentIds, studentIds.Length + 1);
                Array.Resize(ref studentScores, studentScores.Length + 1);
                studentIds[studentIds.Length - 1] = studentId;
                studentScores[studentScores.Length - 1] = studentScore;
                numberOfStudents++;
            }

            Console.Write("Exit? (Y/N): ");
            exitInput = Console.ReadLine();
        }

        // Print summary data
        Console.WriteLine($"Number of students: {numberOfStudents}");
        Console.WriteLine("-----------");
        

        // Find max and min scores
        int maxScore = studentScores[0];
        int minScore = studentScores[0];
        for (int i = 1; i < numberOfStudents; i++)
        {
            if (studentScores[i] > maxScore)
            {
                maxScore = studentScores[i];
            }
            else if (studentScores[i] < minScore)
            {
                minScore = studentScores[i];
            }
        }

        // Print max and min scores
        Console.WriteLine($"Max score: {maxScore}");
        Console.WriteLine($"Min score: {minScore}");
*/

///////////////////////////////////////////////////lab 4
class Pet
{
    public string name;
    public int age;

    public Pet(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name} \n Age: {age}");
    }
}

class Dog : Pet
{
    public string breed;
    public string color;
    

    public Dog(string name, int age, string breed, string color) : base(name, age)
    {
        this.breed = breed;
        this.color = color;
        
    }

    public void Bark()
    {
        Console.WriteLine("The dog make sound like Woof!");
    }

    public void Color()
    {
        Console.WriteLine($"The color of dog is {color}");
    }
    public void Breed()
    {
        Console.WriteLine($"Breed: {breed}");
    }
}

public class Program
{
    public static void Main()
    {
        Dog pet1 = new Dog("Lucky", 3,"Puddle","Brown");
        pet1.PrintInfo();
        pet1.Breed();
        pet1.Bark();
        pet1.Color();

    }
}
