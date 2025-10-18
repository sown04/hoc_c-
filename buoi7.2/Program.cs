namespace buoi7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>();
            var c = new Circle()
            {
                Name = "Hinh tron",
                Radius = 5,
            };
            var r = new Retangle()
            {
                Name = "Hinh chu nhat",
                Height = 10,
                Width = 9,
            };
            // Them vao danh sach
            shapes.Add(c);
            shapes.Add(r);
            // IN ra thu
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Name);
                Console.WriteLine($"Dien tich: {shape.GetArea()}.");
                
                Console.WriteLine($"Chu vi: {shape.GetPerimeter()}.");
                

            }
        }
    }
}
