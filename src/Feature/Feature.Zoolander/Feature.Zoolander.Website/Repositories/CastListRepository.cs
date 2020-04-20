using Feature.Zoolander.Website.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace Feature.Zoolander.Website.Repositories
{
    public class CastListRepository : ModelRepository, ICastListRepository
    {
        public override IRenderingModelBase GetModel()
        {
            var model = new CastListModel
            {
                Cast = GetCastList()
            };

            return model;
        }

        private List<CastMemberModel> GetCastList()
        {
            if(Rendering.DataSourceItem != null)
            {
                return Rendering.DataSourceItem.Children.Select(x => new CastMemberModel(x)).ToList();
            }
            return new List<CastMemberModel>();
        }
    }
}