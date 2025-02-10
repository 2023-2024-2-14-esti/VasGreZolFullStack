using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VasGreZolFullStack.Common.Models;

namespace VasGreZolFullStack.Backend.Repos.Base
{
    public static class IQuerybleExtension
    {
        public static IQueryable<TEntity> FindByCondition<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IDbEntity<TEntity>, new()
        {
            return query.Where(expression);
        }
    }
}
