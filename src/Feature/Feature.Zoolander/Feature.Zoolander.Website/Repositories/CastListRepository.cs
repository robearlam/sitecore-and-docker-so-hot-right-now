using Feature.Zoolander.Website.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace Feature.Zoolander.Website.Repositories
{
    public class CastListRepository : ModelRepository, ICastListRepository
    {
        public override IRenderingModelBase GetModel()
        {
            var model = new CastListModel();

            model.Title = GetTitle();

            return model;
        }

        private string GetTitle()
        {
            //return PageContext.Current[Templates_Title.Fields.Title];

            return "PAGE TITLE";
        }
    }
}