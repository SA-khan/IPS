using IPS.Domain.Interfaces;

namespace IPS.Domain.Models;
public class Course : ICourse {
    public long Id { get; set; }
    public string Name { get; set; }
}