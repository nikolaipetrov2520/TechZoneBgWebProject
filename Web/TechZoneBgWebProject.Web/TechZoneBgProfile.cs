namespace TechZoneBgWebProject.Web
{
    using System.Linq;

    using AutoMapper;

    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Web.InputModels.Posts;
    using TechZoneBgWebProject.Web.InputModels.Replais;
    using TechZoneBgWebProject.Web.ViewModels.Posts;
    using TechZoneBgWebProject.Web.ViewModels.Replies;

    public class TechZoneBgProfile : Profile
    {
        public TechZoneBgProfile()
        {
            this.CreateMap<Post, PostsDeleteViewModel>();
            this.CreateMap<Post, PostsDeleteConfirmedViewModel>();
            this.CreateMap<Post, PostsEditInputModel>();
            this.CreateMap<Post, PostsListingViewModel>()
                .ForMember(
                    dest => dest.Likes,
                    dest => dest.MapFrom(src => src.Reactions.Count(r => r.ReactionType != ReactionType.Neutral)))
                .ForMember(
                    dest => dest.RepliesCount,
                    dest => dest.MapFrom(src => src.Replies.Count(r => !r.IsDeleted)));

            this.CreateMap<Post, PostsDetailsViewModel>()
                .ForMember(
                dest => dest.AuthorId,
                dest => dest.MapFrom(src => src.Author.Id))
                .ForMember(
                dest => dest.AuthorFirstName,
                dest => dest.MapFrom(src => src.Author.FirstName))
                .ForMember(
                dest => dest.AuthorLastName,
                dest => dest.MapFrom(src => src.Author.LastName))
                .ForMember(
                dest => dest.AuthorProfilePicture,
                dest => dest.MapFrom(src => src.Author.ProfilePicture));

            this.CreateMap<Category, PostsCategoryDetailsViewModel>();
            this.CreateMap<Category, PostsCategoryViewModel>()
               .ForMember(
                   dest => dest.Id,
                   dest => dest.MapFrom(src => src.Id))
               .ForMember(
                   dest => dest.Name,
                   dest => dest.MapFrom(src => src.Name));

            this.CreateMap<PostTag, PostsTagsDetailsViewModel>();
            this.CreateMap<PostTag, PostsTagsViewModel>()
               .ForMember(
                   dest => dest.Id,
                   dest => dest.MapFrom(src => src.PostId))
               .ForMember(
                   dest => dest.Name,
                   dest => dest.MapFrom(src => src.Post.Title));

            this.CreateMap<Tag, PostsTagsDetailsViewModel>();
            this.CreateMap<Tag, PostsTagsViewModel>();

            this.CreateMap<Reply, RepliesEditInputModel>();
            this.CreateMap<Reply, RepliesDetailsViewModel>();
            this.CreateMap<Reply, RepliesDeleteViewModel>();
            this.CreateMap<Reply, RepliesDeleteConfirmedViewModel>();
            this.CreateMap<Reply, PostsRepliesDetailsViewModel>()
                .ForMember(
                dest => dest.AuthorId,
                dest => dest.MapFrom(src => src.Author.Id))
                .ForMember(
                dest => dest.AuthorFirstName,
                dest => dest.MapFrom(src => src.Author.FirstName))
                .ForMember(
                dest => dest.AuthorLastName,
                dest => dest.MapFrom(src => src.Author.LastName))
                .ForMember(
                dest => dest.AuthorProfilePicture,
                dest => dest.MapFrom(src => src.Author.ProfilePicture));
        }
    }
}
