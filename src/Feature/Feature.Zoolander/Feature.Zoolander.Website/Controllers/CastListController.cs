using Feature.Zoolander.Website.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Feature.Zoolander.Website.Controllers
{
    public class CastListController : StandardController
    {
        private readonly ICastListRepository _repository;

        public CastListController(ICastListRepository repository)
        {
            _repository = repository;
        }

        protected override object GetModel()
        {
            return _repository.GetModel();
        }
    }
}