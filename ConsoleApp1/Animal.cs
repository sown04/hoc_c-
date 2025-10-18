using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi7
{
    public class Animal
    {
        public string Name { get; set; } = "";
        // Hàm virtual giúp hàm mẹ  có thể dùng được , nhưng dạng ảo, bên các
        // Class con mới thực sự thực thi và trả về kết quả cho method virtual này
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} bat dau keu");
        }
    }
}
