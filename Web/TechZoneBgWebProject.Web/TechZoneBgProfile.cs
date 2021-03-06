namespace TechZoneBgWebProject.Web
{
    using System.Globalization;
    using System.Linq;

    using AutoMapper;
    using TechZoneBgWebProject.Common;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Data.Models.Enums;
    using TechZoneBgWebProject.Web.InputModels.Categories;
    using TechZoneBgWebProject.Web.InputModels.Posts;
    using TechZoneBgWebProject.Web.InputModels.Replais;
    using TechZoneBgWebProject.Web.InputModels.ReplyReports;
    using TechZoneBgWebProject.Web.InputModels.Reports;
    using TechZoneBgWebProject.Web.ViewModels.Categories;
    using TechZoneBgWebProject.Web.ViewModels.Messages;
    using TechZoneBgWebProject.Web.ViewModels.Posts;
    using TechZoneBgWebProject.Web.ViewModels.Replies;
    using TechZoneBgWebProject.Web.ViewModels.ReplyReports;
    using TechZoneBgWebProject.Web.ViewModels.Reports;
    using TechZoneBgWebProject.Web.ViewModels.Tags;
    using TechZoneBgWebProject.Web.ViewModels.Users;
    using TechZoneBgWebProject.Web.ViewModels.Roles;
    using Microsoft.AspNetCore.Identity;
    using TechZoneBgWebProject.Web.ViewModels.Products;
    using TechZoneBgWebProject.Web.ViewModels.Carts;
    using TechZoneBgWebProject.Web.ViewModels.Orders;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class TechZoneBgProfile : Profile
    {
        public TechZoneBgProfile()
        {
            this.CreateMap<ApplicationUser, UsersLoginStatusViewModel>();
            this.CreateMap<ApplicationUser, UsersViewModel>()
                .ForMember(
                    dest => dest.ThreadsCount,
                    dest => dest.MapFrom(src => src.Posts.Count(p => !p.IsDeleted)));
            this.CreateMap<ApplicationUser, ChatUserViewModel>();
            this.CreateMap<ApplicationUser, UsersOrdersViewModel>()
                .ForMember(
                    dest => dest.ExecutingCount,
                    dest => dest.MapFrom(src => src.Carts.Count(c => !c.IsSend && !c.IsDeleted && c.IsFinished)));
            this.CreateMap<ApplicationUser, ChatViewModel>();
            this.CreateMap<ApplicationUser, UsersDetailsViewModel>();
            this.CreateMap<ApplicationUser, UsersRolesViewModel>();
            this.CreateMap<IdentityUserRole<string>, RolesUsersViewModel>();

            this.CreateMap<Post, PostsDeleteViewModel>();
            this.CreateMap<Post, PostsDeleteConfirmedViewModel>();
            this.CreateMap<Post, UsersThreadsViewModel>()
                .ForMember(
                dest => dest.CategoryId,
                dest => dest.MapFrom(src => src.Category.Id))
                .ForMember(
                dest => dest.CategoryName,
                dest => dest.MapFrom(src => src.Category.Name));
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
                    dest => dest.Likes,
                    dest => dest.MapFrom(src => src.Reactions.Count(r => r.ReactionType == ReactionType.Like)))
                .ForMember(
                    dest => dest.Dislike,
                    dest => dest.MapFrom(src => src.Reactions.Count(r => r.ReactionType == ReactionType.Dislike)))
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
                dest => dest.MapFrom(src => src.Author.ProfilePicture))
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)));

            this.CreateMap<Category, PostsCategoryDetailsViewModel>();
            this.CreateMap<Category, CategoriesEditInputModel>();
            this.CreateMap<Category, CategoriesInfoViewModel>();
            this.CreateMap<Category, PostsCategoryViewModel>()
               .ForMember(
                   dest => dest.Id,
                   dest => dest.MapFrom(src => src.Id))
               .ForMember(
                   dest => dest.Name,
                   dest => dest.MapFrom(src => src.Name));

            this.CreateMap<PostTag, PostsTagsDetailsViewModel>();
            this.CreateMap<PostTag, UsersThreadsTagsViewModel>();
            this.CreateMap<PostTag, PostsTagsViewModel>()
               .ForMember(
                   dest => dest.Id,
                   dest => dest.MapFrom(src => src.PostId))
               .ForMember(
                   dest => dest.Name,
                   dest => dest.MapFrom(src => src.Post.Title));

            this.CreateMap<Tag, PostsTagsDetailsViewModel>();
            this.CreateMap<Tag, UsersThreadsTagsViewModel>();
            this.CreateMap<Tag, TagsInfoViewModel>();
            this.CreateMap<Tag, PostsTagsViewModel>();

            this.CreateMap<Reply, RepliesEditInputModel>();
            this.CreateMap<Reply, UsersRepliesViewModel>().ForMember(
                    dest => dest.Activity,
                    dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeShortFormat, CultureInfo.InvariantCulture)));
            this.CreateMap<Reply, RepliesDetailsViewModel>()
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)));
            this.CreateMap<Reply, RepliesDeleteViewModel>()
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)));
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
                dest => dest.MapFrom(src => src.Author.ProfilePicture))
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)))
                .ForMember(
                    dest => dest.Likes,
                    dest => dest.MapFrom(src => src.Reactions.Count(r => r.ReactionType == ReactionType.Like)))
                .ForMember(
                    dest => dest.Dislike,
                    dest => dest.MapFrom(src => src.Reactions.Count(r => r.ReactionType == ReactionType.Dislike)));

            this.CreateMap<Message, ChatMessagesWithUserViewModel>()
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)));

            this.CreateMap<UserFollower, UsersViewModel>();
            this.CreateMap<Post, ReportsInputModel>();
            this.CreateMap<PostReport, PostReportsListingViewModel>()
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)));
            this.CreateMap<PostReport, PostReportsDetailsViewModel>()
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)));
            this.CreateMap<Reply, ReplyReportsInputModel>();
            this.CreateMap<ReplyReport, ReplyReportsListingViewModel>()
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)));
            this.CreateMap<ReplyReport, ReplyReportsDetailsViewModel>()
                .ForMember(
                dest => dest.CreatedOn,
                dest => dest.MapFrom(src => src.CreatedOn.ToString(GlobalConstants.DateTime.DateTimeFormat, CultureInfo.InvariantCulture)));
            this.CreateMap<ApplicationUser, RolesInfoViewMolel>()
                .ForMember(
                dest => dest.Username,
                dest => dest.MapFrom(src => src.FirstName + " " + src.LastName))
                .ForMember(
                dest => dest.Roles,
                dest => dest.MapFrom(src => src.Roles));
            this.CreateMap<ApplicationRole, RolesViewModel>()
                .ForMember(
                dest => dest.Role,
                dest => dest.MapFrom(src => src.Name.ToString()));
            this.CreateMap<Product, ProductsListingViewModel>();
            this.CreateMap<Product, ProductDetailsViewModel>();
            this.CreateMap<Cart, CartsListingViewModel>();
            this.CreateMap<Cart, CartsFinishingViewModel>();
            this.CreateMap<Cart, OrdersListingViewModel>();
            this.CreateMap<Product, CartProductsViewModel>();
            this.CreateMap<Product, ProductsListModel>();
            this.CreateMap<CartProduct, CartProductsViewModel>()
                .ForMember(
                dest => dest.Price,
                dest => dest.MapFrom(src => src.Product.Price))
                .ForMember(
                dest => dest.Barcode,
                dest => dest.MapFrom(src => src.Product.Barcode))
                .ForMember(
                dest => dest.Name,
                dest => dest.MapFrom(src => src.Product.Name))
                .ForMember(
                dest => dest.Id,
                dest => dest.MapFrom(src => src.Product.Id))
                .ForMember(
                dest => dest.Pic,
                dest => dest.MapFrom(src => src.Product.Pic));
            this.CreateMap<Brand, DevicesBrandsDetailsViewModel>();
            this.CreateMap<Condition, DevicesConditionsDetailsViewModel>();
            this.CreateMap<Status, DevicesStatusDetailsViewModel>();
            this.CreateMap<DeviceModel, DevicesModelsDetailsViewModel>();
            this.CreateMap<CheckListsChecks, DevicesChecksDetailsViewModel>()
                .ForMember(
                dest => dest.Name,
                dest => dest.MapFrom(src => src.Check.Name))
                .ForMember(
                dest => dest.Id,
                dest => dest.MapFrom(src => src.Check.Id))
                .ForMember(
                dest => dest.Condition,
                dest => dest.MapFrom(src => src.Condition))
                .ForMember(
                dest => dest.Description,
                dest => dest.MapFrom(src => src.Description));
        }
    }
}
