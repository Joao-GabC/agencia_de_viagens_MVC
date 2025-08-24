using AgenciaDeViagens.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AgenciaDeViagens.Controllers
{
    public class BaseController : Controller
    {
        protected readonly SignInManager<IdentityUser> _signInManager;
        protected readonly ApplicationDbContext _context;


        public BaseController(SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (_signInManager.IsSignedIn(User))
            {
                ViewBag.NomeCliente = _context.Clientes.FirstOrDefault(c => c.Email == User.Identity!.Name!);
            }
            else
            {
                ViewBag.NomeCliente = "not defined";
            }
            base.OnActionExecuting(context);
        }
    }
}
