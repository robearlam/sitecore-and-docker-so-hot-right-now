using Sitecore.Data.Items;

namespace Feature.Zoolander.Website.Models
{
    public class CastMemberModel
    {
        public Item Item { get; set; }

        public CastMemberModel(Item castItem)
        {
            Item = castItem;
        }
    }
}