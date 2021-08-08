namespace TechZoneBgWebProject.Web.Components
{
    using Microsoft.AspNetCore.Mvc;

    using TechZoneBgWebProject.Web.InputModels.Replais;

    [ViewComponent(Name = "CreateReply")]
    public class CreateReplyViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int? parentId, int postId)
        {
            var viewModel = new RepliesCreateInputModel
            {
                ParentId = parentId,
                PostId = postId,
            };

            return this.View(viewModel);
        }
    }
}
