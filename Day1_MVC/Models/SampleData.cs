
    public class SampleData
    {
        public static List<Employee> Employees { get; set; }
        static SampleData()
        {
            Employees = new List<Employee>()
            {
                new Employee() {ID=1,Name="Ali",Age=20,Salary=3000,Address="Cairo",Email="ali@gmail.com"},
                new Employee() {ID=2,Name="Omar",Age=20,Salary = 3000 ,Address="Cairo",Email="omar@gmail.com"},
                new Employee() {ID=3,Name="Ola",Age=20,Salary = 3000, Address="Cairo",Email="ola@gmail.com"},
                new Employee() {ID=4,Name="Mona",Age=20,Salary = 3000,Address="Alex",Email="mona@gmail.com"},
                new Employee() {ID=5,Name="Ahmed",Age=20,Salary = 3000, Address="Alex",Email="ahmed@gmail.com"},
                new Employee() {ID=6,Name="Yasser",Age=20,Salary = 3000, Address="Alex",Email="yasser@gmail.com"},
            };
        }
    }

