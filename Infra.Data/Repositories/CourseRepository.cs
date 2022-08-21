using System.Threading.Tasks;

using IPS.Domain.Models;
using IPS.Domain.Interfaces;
using IPS.Infra.Data.Context;
using System.Collections;

namespace IPS.Infra.Data.Repositories;

public class CourseRepository : ICourseRepository {
    private IApplicationDbContext _context;
    public CourseRepository(IApplicationDbContext ctx)
    {
        _context = ctx;
    }
    public async Task<IEnumerable<Course>> GetAllCourses(){
        return await Task.FromResult(_context.Courses);
    }
}