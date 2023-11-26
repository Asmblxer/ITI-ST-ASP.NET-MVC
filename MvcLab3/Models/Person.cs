using MVC_Lab3.Models;
using System;

namespace MVC_Lab3.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public int Age { get; set; }

        public string Image { get; set; } = "https://cdn1.vectorstock.com/i/1000x1000/06/30/businessman-cartoon-icon-vector-12780630.jpg";


        public static List<Person> GetPersons() => new() 
        {
            new Person { Id = 1, Name = "Mohamed", Age = 18, Image = "https://img.a.transfermarkt.technology/portrait/big/38165-1574079822.jpg?lm=1" },
            new Person { Id = 2, Name = "Asem", Age = 21, Image = "https://scontent.fcai21-2.fna.fbcdn.net/v/t39.30808-6/357557172_1092397518401966_6432667359309477918_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=UeEPdlN87h0AX8SeRGd&_nc_ht=scontent.fcai21-2.fna&oh=00_AfB1SZu71sQRavGrsNhWMGtGo0g72MPEEfbifc30RiX4bg&oe=64EBD720" },
            new Person { Id = 3, Name = "Ibrahim", Age = 25, Image = "https://yt3.googleusercontent.com/4-C0u8iVgKxJEO3M2uhauQVg-BVNTi2HMWaCOQKPDp5lk-vOzCmw-kZjpyvpm4XHkTcH4aOe=s900-c-k-c0x00ffffff-no-rj" },
            new Person { Id = 4, Name = "Ahmed", Age = 30, Image = "https://media.licdn.com/dms/image/D4D03AQF6W-xKRQb6Zw/profile-displayphoto-shrink_800_800/0/1689491254986?e=1698278400&v=beta&t=Uoa8-Dc_2eALe1E7nC5u7x6AAp0CGHNl1baDw2FjPyI"},
            new Person { Id = 5, Name = "Lotfy", Age = 35 },
        };

    }
}