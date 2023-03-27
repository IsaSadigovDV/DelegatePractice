Console.WriteLine();

//void show1(string data)
//{
//    Console.WriteLine(data);
//}

//void show2(int data)
//{
//    Console.WriteLine(data);
//}

//Show<string> showString = show1;
//Show<int> showInt = show2;

//delegate void Show<T>(T data);
//-----------------------------------------------------------
//return typei void olanlara aiddir
//action vasitesile 16 -ya qeder type qebul edir ve bizim isimisi asanlasdirir.
Action<int, string, double, char> action;
//-------------------------------------------------------

// en sonuncu return type-dir, action-dan ferqi budur
Func<int, string, double> func;

//=========================================

//predicate bir parametr qebul edir laki geriye boolean gonderir yeni true yaxud false
//Predicate<int> predicate;


Student student = new Student();
student.Name = "Isa";


Student student2 = new Student();
student2.Name = "Nicat";

Student student3 = new Student();
student3.Name = "Ilkin";


List<Student> students = new List<Student>();
students.Add(student);
students.Add(student2);
students.Add(student3);

Student result = students.Find(x => x.Id == 1);
Console.WriteLine(result.Name);



class Student
{
    static int id;
    public int Id;
    public string Name;


    public Student()
    {
        id++;
        id = id;
    }
}


