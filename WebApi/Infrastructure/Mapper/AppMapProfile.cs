using AutoMapper;
using Data.Entities;
using Data.Entities.Identity;
using Infrastructure.Models.DTO.AccountDTO;
using Infrastructure.Models.DTO.CategoryDTO;
using Infrastructure.Models.DTO.CommentDTO;
using Infrastructure.Models.DTO.ProductDTO;
using Infrastructure.Models.DTO.RoleDTO;

namespace Infrastructure.Mapper
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<UserCreateDTO, UserEntity>()
              .ForMember(x => x.Image, opt => opt.Ignore())
              .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Email));

            CreateMap<CategoryEntity, CategoryItemDTO>();

            CreateMap<CategoryItemDTO, CategoryEntity>()
            //.ForMember(x => x.Image, opt => opt.MapFrom(x => $"/Images/{x.Image}"));
            .ForMember(x => x.Image, opt => opt.Ignore());

            CreateMap<CategoryCreateDTO, CategoryEntity>()
                //.ForMember(x => x.Image, opt => opt.MapFrom(x => $"/Images/{x.Image}"));
            .ForMember(x => x.Image, opt => opt.Ignore());
            CreateMap<CommentCreateDTO, CommentEntity>();
            CreateMap<CommentEntity, CommentItemDTO>();

            CreateMap<ProductEntity, ProductItemDTO>()
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name));

            CreateMap<ProductCreateDTO, ProductEntity>();
                //.ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId == 0 ? null : x.CategoryId));
            CreateMap<ProductEntity, ProductCreateDTO>();
                //.ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId == 0 ? null : x.CategoryId));
            CreateMap<ProductEditDTO, ProductEntity>();
            CreateMap<ProductEntity, ProductEditDTO>();

            CreateMap<ProductImageEntity, ProductImageItemDTO>();
            CreateMap<ProductImageItemDTO, ProductImageEntity>();

            CreateMap<CommentImageEntity, CommentImageItemDTO>();
            CreateMap<CommentImageItemDTO, CommentImageEntity>();

            CreateMap<CommentEditDTO, CommentEntity>();

            CreateMap<PermissionsEntity, PermissionItemDTO>();
            CreateMap<PermissionItemDTO, PermissionsEntity>();

            CreateMap<UserItemDTO, UserEntity>();
            CreateMap<UserEntity, UserItemDTO>();

            CreateMap<UserEditDTO, UserEntity>();
            //CreateMap<UserCreateDTO, UserEntity>();
            //CreateMap<UserEntity, UserCreateDTO>();
        }
    }
}
