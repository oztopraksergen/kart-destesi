using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Örnek bir veri kaynağı (listesi)
        List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Alice", Age = 25 },
            new User { Id = 2, Name = "Bob", Age = 30 },
            new User { Id = 3, Name = "Charlie", Age = 22 },
            new User { Id = 4, Name = "David", Age = 35 }, // Yeni kullanıcılar ekle ve yaş sıralaması yerine ismi Bob olan kişileri getir
        };

        // Yaşı 25'ten büyük olan kullanıcıları seçen bir LINQ sorgusu
        var filteredUsers = users.Where(u => u.Age > 25).ToList();

        // Sonuçları ekrana yazdırma
        foreach (var user in filteredUsers)
        {
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
        }
    }
}
