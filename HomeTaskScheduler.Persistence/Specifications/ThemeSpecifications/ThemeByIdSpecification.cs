using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.ThemeSpecifications;

public class ThemeByIdSpecification : Specification<Theme>
{
    public ThemeByIdSpecification(Guid themeId): base(theme => theme.Id == themeId)
    {
        AddInclude(x => x.Tasks);
    }
}