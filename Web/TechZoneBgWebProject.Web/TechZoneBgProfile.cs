namespace TechZoneBgWebProject.Web
{
    using System.Linq;

    using AutoMapper;

    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Web.ViewModels.Posts;

    public class TechZoneBgProfile : Profile
    {
        public TechZoneBgProfile()
        {

            this.CreateMap<Post, PostsListingViewModel>()
                .ForMember(
                    dest => dest.Likes,
                    dest => dest.MapFrom(src => src.Reactions.Count(r => r.ReactionType != ReactionType.Neutral)))
                .ForMember(
                    dest => dest.RepliesCount,
                    dest => dest.MapFrom(src => src.Replies.Count(r => !r.IsDeleted)));

            this.CreateMap<Category, PostsCategoryViewModel>()
               .ForMember(
                   dest => dest.Id,
                   dest => dest.MapFrom(src => src.Id))
               .ForMember(
                   dest => dest.Name,
                   dest => dest.MapFrom(src => src.Name));

            this.CreateMap<PostTag, PostsTagsViewModel>()
               .ForMember(
                   dest => dest.Id,
                   dest => dest.MapFrom(src => src.PostId))
               .ForMember(
                   dest => dest.Name,
                   dest => dest.MapFrom(src => src.Post.Title));
        }
    }
}