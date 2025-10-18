namespace buoi7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface giúp thực hiên các chức năng riêng trên cùng một đối tượng.
            IStudent student = new Student();
            student.Name = "Test";
            student.GetName();

            IInfo infoStudent = new Student();
            infoStudent.Age = 15;
        }
    }
    //4 tính chất của Interface:
    // - Không có thân hàm.
    // - Không thể tạo thêm đối tượng.
    // - Chỉ có public các thành viên , không có private.
    // - Có thể thực hiện Đa kế thừa.
    interface IStudent
    {
        string Name { get; set; }
        void GetName();
    }
    interface IInfo
    {
        int Age { get; set; }
    }

    class Student : IStudent, IInfo
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public void GetName()
        {
            Console.WriteLine($"Xin Chao {Name}");
        }
    }
}

