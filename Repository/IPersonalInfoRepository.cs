using jQueryDatatablesMVC.Models;

namespace jQueryDatatablesMVC.Repository
{
    public interface IPersonalInfoRepository: IGenericRepository<PersonalInfo>
    {
        PersonalInfo Get(int blogId);
    }
}
