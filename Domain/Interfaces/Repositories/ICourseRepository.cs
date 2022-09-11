using IPS.Domain.Models;

namespace IPS.Domain.Interfaces;

public interface ICourseRepository {
    public Task<IEnumerable<Course>> GetAllCourses();
}