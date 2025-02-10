using VasGreZolFullStack.Backend.Repos;
using VasGreZolFullStack.Common.Assemblers.Base;
using VasGreZolFullStack.Common.Models;
using VasGreZolFullStack.Common.Responses;
using Microsoft.AspNetCore.Mvc;
using VasGreZolFullStack.Backend.Repos.Base;


namespace VasGreZolFullStack.Backend.Controllers.Base
{
    public abstract class BaseController<TModel, TDto> : ControllerBase
        where TModel : class, IDbEntity<TModel>, new()
        where TDto : class, new()
    {
        protected BaseAssembler<TModel, TDto> _baseAssembler;
        protected IBaseRepo<TModel> _repo;

        public BaseController(BaseAssembler<TModel, TDto>? baseAssembler, IBaseRepo<TModel>? repo)
        {
            _baseAssembler = baseAssembler ?? throw new ArgumentNullException(nameof(baseAssembler));
            _repo = repo ?? throw new ArgumentNullException(nameof(_repo));
        }

        // TODO: HTTPs

    }
}
