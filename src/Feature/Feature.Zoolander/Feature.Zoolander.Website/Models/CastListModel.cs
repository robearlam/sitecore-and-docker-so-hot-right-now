using Sitecore.XA.Foundation.Mvc.Models;
using System.Collections.Generic;

namespace Feature.Zoolander.Website.Models
{
    public class CastListModel : RenderingModelBase
    {
        public List<CastMemberModel> Cast { get; set; }
    }
}