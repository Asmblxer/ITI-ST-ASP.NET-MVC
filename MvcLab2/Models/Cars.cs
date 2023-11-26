using MvcLab.Models;
public class Car
{
    public string? Manufacturer { get; set; }
    public string? Model { get; set; }
    public string? Image { get; set; }
    public string? HtmlDescription { get; set; }
    public DateTime FirstUseDate { get; set; }

    public static List<Car> GetCars()
        => new() {
        new Car
        {
            Manufacturer = "Toyota",
            Model = "Camry",
            Image = "https://hips.hearstapps.com/hmg-prod/images/c-005-1500x1000-1652713137.jpg?crop=0.920xw:0.776xh;0.0657xw,0.103xh&resize=1200:*",
            HtmlDescription = "The Toyota Camry is a mid-size car manufactured by Toyota since 1982.",
            FirstUseDate = new DateTime(1982, 3, 4)
        },
        new Car
        {
            Manufacturer = "Honda",
            Model = "Civic",
            Image = "https://hips.hearstapps.com/hmg-prod/images/2022-honda-civic-hatchback-sport-touring-309-1634066512.jpg?crop=0.617xw:0.520xh;0.298xw,0.477xh&resize=1200:*",
            HtmlDescription = "The Honda Civic is a line of cars manufactured by Honda.",
            FirstUseDate = new DateTime(1972, 7, 11)
        },
        new Car {
            Manufacturer = "Ford",
            Model = "Mustang",
            Image = "https://hips.hearstapps.com/hmg-prod/images/2022-ford-mustang-shelby-gt500-02-1636734552.jpg?crop=1.00xw:0.891xh;0,0.0759xh&resize=1200:*",
            HtmlDescription = "The Ford Mustang is a series of American muscle cars.",
            FirstUseDate = new DateTime(1964, 4, 17)
        },
        new Car {
            Manufacturer = "Chevrolet",
            Model = "Corvette",
            Image = "https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/gallery_slide/public/chevrolet-corvette-z06-01-front-tracking.jpg?itok=oWivxglQ",
            HtmlDescription = "The Chevrolet Corvette is a sports car produced by Chevrolet.",
            FirstUseDate = new DateTime(1953, 6, 30)
        },
        new Car {
            Manufacturer = "Mercedes-Benz",
            Model = "S-Class",
            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/Mercedes-Benz_W223_IMG_6663.jpg/640px-Mercedes-Benz_W223_IMG_6663.jpg",
            HtmlDescription = "The Mercedes-Benz S-Class is a series of luxury cars.",
            FirstUseDate = new DateTime(1972, 6, 1)
        },
        new Car {
            Manufacturer = "BMW",
            Model = "3 Series",
            Image = "https://media.autoexpress.co.uk/image/private/s--FvpaNhh6--/v1652787822/evo/2022/05/2022%20BMW%203series%20facelift%20May%2022-2.jpg",
            HtmlDescription = "The BMW 3 Series is a line of compact executive cars.",
            FirstUseDate = new DateTime(1975, 5, 2)
        },
        new Car {
            Manufacturer = "Audi",
            Model = "A4",
            Image = "https://media.ed.edmunds-media.com/audi/a4/2022/oem/2022_audi_a4_sedan_prestige-s-line_fq_oem_8_600.jpg",
            HtmlDescription = "The Audi A4 is a line of compact executive cars.",
            FirstUseDate = new DateTime(1994, 11, 4)
        },
        new Car {
            Manufacturer = "Mazda",
            Model = "MX-5",
            Image = "https://www.topgear.com/sites/default/files/2023/04/Mazda_-MX-5_-RF_-SKYACTIV-G-2.0_-Soul_Red_0089.jpg",
            HtmlDescription = "The Mazda MX-5 is a two-seater sports car manufactured by Mazda.",
            FirstUseDate = new DateTime(1989, 5, 18)
        },
        new Car {
            Manufacturer = "Porsche",
            Model = "911",
            Image = "https://i.gaw.to/vehicles/photos/40/25/402523-2021-porsche-911.jpg?1024x640",
            HtmlDescription = "The Porsche 911 is a line of high-performance sports cars.",
            FirstUseDate = new DateTime(1963, 9, 12)
        },
        new Car {
            Manufacturer = "Tesla",
            Model = "Model S",
            Image = "https://image.cnbcfm.com/api/v1/image/104836103-p100d-review.JPG?v=1510586447",
            HtmlDescription = "The Tesla Model S is an electric car produced by Tesla, Inc.",
            FirstUseDate = new DateTime(2012, 6, 22)
        }
        };

}