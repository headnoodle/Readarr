using System.Collections.Generic;
using System.Linq;
using NzbDrone.Core.Tags;
using Readarr.Http.REST;

namespace Readarr.Api.V1.Tags
{
    public class TagDetailsResource : RestResource
    {
        public string Label { get; set; }
        public List<int> DelayProfileIds { get; set; }
        public List<int> ImportListIds { get; set; }
        public List<int> NotificationIds { get; set; }
        public List<int> RestrictionIds { get; set; }
        public List<int> IndexerIds { get; set; }
        public List<int> DownloadClientIds { get; set; }
        public List<int> AuthorIds { get; set; }
    }

    public static class TagDetailsResourceMapper
    {
        public static TagDetailsResource ToResource(this TagDetails model)
        {
            if (model == null)
            {
                return null;
            }

            return new TagDetailsResource
            {
                Id = model.Id,
                Label = model.Label,
                DelayProfileIds = model.DelayProfileIds,
                ImportListIds = model.ImportListIds,
                NotificationIds = model.NotificationIds,
                RestrictionIds = model.RestrictionIds,
                IndexerIds = model.IndexerIds,
                DownloadClientIds = model.DownloadClientIds,
                AuthorIds = model.AuthorIds
            };
        }

        public static List<TagDetailsResource> ToResource(this IEnumerable<TagDetails> models)
        {
            return models.Select(ToResource).ToList();
        }
    }
}
