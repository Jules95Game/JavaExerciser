using JavaExerciser.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JavaExerciser.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProblemsController : ControllerBase
{
    private readonly DataContext _dataContext;

    public ProblemsController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
}
