using Microsoft.AspNetCore.Mvc;

using MultDataSaveDemo.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultDataSaveDemo.Interface
{
    public interface IUserService
    {
        public bool RegistrationBulk(List<RegistrationViewModel> model);

        public List<RegistrationViewModel> GetRegration();

        public List<CityViewModel> GetAllCity();
        public bool AddCity(CityViewModel city);
    }
}
