
using MediatR;
using System.Collections;
using System.Threading.Tasks;

using IPS.Domain.Models;
using IPS.Domain.Interfaces;
using IPS.Infra.Data.Repositories;

namespace IPS.Application.Core.v1.Course.Query;
public class GetAllCoursesQuery : IRequest<IEnumerable<IPS.Domain.Models.Course>> {

}

public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, IEnumerable<IPS.Domain.Models.Course>>, IGetAllCoursesQueryHandler {
    private ICourseRepository _repository;
    public GetAllCoursesQueryHandler(ICourseRepository repo)
    {
        _repository = repo;
    }
    public async Task<IEnumerable<IPS.Domain.Models.Course>> Handle(GetAllCoursesQuery query, CancellationToken cancellationToken) {
        return await _repository.GetAllCourses();
    }
}

public interface IGetAllCoursesQueryHandler {

}