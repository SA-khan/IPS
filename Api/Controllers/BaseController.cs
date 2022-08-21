using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("api/v1/[action]")]
[ApiController]
public class BaseController : Controller {
    public ISender _mediator;
    public ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
}