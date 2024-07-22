using System;
using System.Globalization;

internal class Program
{
    #region subject 
    class subject
    {
        private string name;
        private int code;
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    #endregion
    #region student 
    class Student
    {
        private int id;
        private string fname;
        private string lname;
        private subject[] subjects;
        public int i = 0;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Fname
        {
            get { return fname; }
            set
            {
                fname = value;
            }
        }
        public string Lname
        {
            get { return lname; }
            set
            {
                lname = value;
            }
        }
        public subject[] Subjects
        {
            get { return subjects; }
            set
            {
                subjects = value;
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i =0;i< subjects.Length;i++)
            {
                s += $"{i+1}- subject :"+subjects[i].Name+" ";

            }
            return $" id: {ID} Fname: {Fname} Lname: {Lname} subjects: {s}";
        }


    }
    #endregion
    static void Main(string[] args)
    {
        #region list
        List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
        numbers.Sort();
        var q3 = from s in numbers.Distinct() select s;

        foreach (int i in q3)
        {
            Console.WriteLine(i);

        }
        foreach (int i in q3)
        {
            Console.WriteLine($"< Number = {i}, Multiply = {i * i} >");

        }

        #endregion
        #region string array
        String[] names = { "tom", "Dick", "Harry", "Mary", "jay" };
        var q1 = from s in names where s.Length == 3 select s;
        foreach (string i in q1)
        {
            Console.WriteLine(i);
        }

        var q2 = from s in names where s.Contains('a') orderby s.Length select s;

        foreach (string i in q2)
        {
            Console.WriteLine(i);
        }
        #endregion
        #region student
        List<Student> students = new List<Student>() { new Student() { ID = 1, Fname = "Ali", Lname = "Mohammed", Subjects = new subject[] {new subject() { Code=22,Name="EF"}, new subject() { Code = 33, Name = "UML" }  } },
                                                    new Student() { ID = 2, Fname = "Mona", Lname = "Gala", Subjects = new subject[] { new subject() { Code = 22, Name = "EF" }, new subject() { Code = 34, Name = "xML" } ,new subject() { Code = 25, Name = "JS" } } },
                                                    new Student() { ID = 3, Fname = "Yara", Lname = "Yousf", Subjects = new subject[] { new subject() { Code = 25, Name = "JS" } ,new subject() { Code = 22, Name = "EF" } } },
                                                     new Student() { ID = 4, Fname = "Ali", Lname = "Ali", Subjects = new subject[] { new subject() { Code = 33, Name = "UML" } } },
                                                    };
        var q7 = students.Select( (Student s) => new{ name = s.Fname + " " + s.Lname, length = s.Subjects.Length});
        foreach(var i in q7)
        {
            Console.WriteLine($"< full name : {i.name} ,nymber of subjects = {i.length} >");
        }
        var q8 = from s in students.OrderByDescending(s => s.Fname) .ThenBy(s=>s.Lname)  select s ;
        foreach(var i in q8)
        {
            Console.WriteLine(i.ToString() );
        }

                #endregion
    }
}