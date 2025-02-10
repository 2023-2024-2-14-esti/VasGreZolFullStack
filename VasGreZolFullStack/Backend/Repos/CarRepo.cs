using VasGreZolFullStack.Common.Models;
using VasGreZolFullStack.Backend.Context;
using VasGreZolFullStack.Backend.Repos.Base;
using Microsoft.EntityFrameworkCore;

namespace VasGreZolFullStack.Backend.Repos
{
    public class CarRepo<TDbContext> : BaseRepo<TDbContext, Car>, 
    {
    }
}
