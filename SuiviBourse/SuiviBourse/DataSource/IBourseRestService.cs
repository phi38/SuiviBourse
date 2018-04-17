using SuiviBourse.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuiviBourse.DataSource
{
    public interface IBourseRestService
    {
        Task<List<BourseAction>> GetCoursDataAsync(List<BourseAction> list);
    }
}
