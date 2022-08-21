using Microsoft.AspNetCore.Mvc;
using MediatR;
using IPS.Domain.Interfaces;

using IPS.Application.Core.v1.Course.Query;

namespace IPS.API.Controllers.v1;
public class CourseController : BaseController {

    private ICourseRepository _repository;

    public CourseController(ICourseRepository repo, IMediator mediator)
    {
        _repository = repo;
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult GetAllCourses() {
        return Ok(_mediator.Send(new GetAllCoursesQuery()));
    }
}