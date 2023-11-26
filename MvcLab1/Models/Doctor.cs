using MvcLab.Models;
public class Doctor 
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public string Specialty { get; set; } = "";
    public string image { get; set; } = "";

    public static List <Doctor> GetDoctors() { 
        List <Doctor> doctors = new () {
            new Doctor() { ID = 1, Name = "Dr. Osama", Specialty = "Pediatrics", image = "https://familydoctor.org/wp-content/uploads/2018/02/41808433_l-705x470.jpg" },
            new Doctor() { ID = 2, Name = "Dr. Ali", Specialty = "Obstetrics", image = "https://hips.hearstapps.com/hmg-prod/images/portrait-of-a-happy-young-doctor-in-his-clinic-royalty-free-image-1661432441.jpg?crop=0.66698xw:1xh;center,top&resize=1200:*" },
            new Doctor() { ID = 3, Name = "Dr. Mohamed", Specialty = "Podiatry", image = "https://media.istockphoto.com/id/138205019/photo/happy-healthcare-practitioner.jpg?s=2048x2048&w=is&k=20&c=WLIRybzDkzFZujYpntsfxVNi_V1piRGWPYF2ipxaB5k=" },
            new Doctor() { ID = 4, Name = "Dr. Williams", Specialty = "Pediatrics", image = "https://media.istockphoto.com/id/1199745866/photo/portrait-of-a-cheerful-doctor-in-modern-office.jpg?s=1024x1024&w=is&k=20&c=MEn6tpDihb8fRlt1lvrgp2Xh1QUNjo7taId2NDvgYI0=" },
            new Doctor() { ID = 5, Name = "Dr. Ahmed", Specialty = "Obstetrics", image  = "https://yt3.googleusercontent.com/ytc/AOPolaSw9TfEPjWHVnvMsBBSHUrDFgwwQd5MpSIn7kBNKA=s176-c-k-c0x00ffffff-no-rj" },
        };
        return doctors;
    }
    public override string ToString() {
        return $"Doctor_ID: {ID}___Specialty: {Specialty}";
    }
}