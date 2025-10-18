namespace buoi7
{
    internal class Program
    {
        // Tạo danh sach các con vật
        static List<Animal> animals = new List<Animal>();
        static void Main(string[] args)
        {
            //Them cac con vat vao danh sach
            animals.Add(new Dog() { Name = "Cho Pug" });
            animals.Add(new Cat() { Name = "Meo Anh" });
            animals.Add(new Duck() { Name = "Vit Troi" });

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
        
    }
    
}
