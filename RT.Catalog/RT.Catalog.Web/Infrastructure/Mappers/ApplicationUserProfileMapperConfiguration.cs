using RT.Catalog.Data;
using RT.Catalog.Web.Infrastructure.Mappers.Base;
using RT.Catalog.Web.Infrastructure.ViewModels.AccountViewModels;

namespace RT.Catalog.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Mapper Configuration for entity Person
    /// </summary>
    public class ApplicationUserProfileMapperConfiguration:MapperConfigurationBase
    {
        /// <inheritdoc />
        public ApplicationUserProfileMapperConfiguration()
        {
            CreateMap<RegisterViewModel, ApplicationUserProfile>()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}