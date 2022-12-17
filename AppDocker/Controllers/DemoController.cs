using AppDocker.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly DataContext ctx;

        public DemoController(DataContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public async Task<IEnumerable<DemoData>> Get()
        {
            await ctx.Demos.AddAsync(new DemoData());
            await ctx.SaveChangesAsync();
            return await ctx.Demos.ToListAsync();
        }
    }
}
