using MultDataSaveDemo.DAL;
using MultDataSaveDemo.Entities;
using MultDataSaveDemo.Interface;
using MultDataSaveDemo.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultDataSaveDemo.BAL
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public bool RegistrationBulk(List<RegistrationViewModel> model)
        {
            try
            {
                var registration = model.Select(x => new Registration()
                {
                    CitiesId = x.CityId,
                    Date = DateTime.Now,
                    Mobile = x.Mobile,
                    Name = x.Name
                }).ToList();

                _context.Registration.AddRange(registration);

                int i = _context.SaveChanges();
                if (i > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public List<RegistrationViewModel> GetRegration()
        {
            try
            {
                var data = _context.Registration.Select(x => new RegistrationViewModel()
                {
                    CityId = x.Cities.Id,
                    CityName = x.Cities.Name,
                    Name = x.Name,
                    Id = x.Id,
                    Date = x.Date,
                    Mobile = x.Mobile
                }).ToList();
                return data;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public List<CityViewModel> GetAllCity()
        {
            try
            {
                var cityes = _context.Cities.Select(x => new CityViewModel()
                {
                    Id = x.Id,
                    CityName = x.Name
                }).ToList();
                return cityes;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public bool AddCity(CityViewModel city)
        {
            try
            {
                Cities cities = new Cities()
                {
                    Name = city.CityName
                };
                _context.Cities.Add(cities);
                int i = _context.SaveChanges();
                if (i > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                throw;
            }
        }
        //--public 
    }
}
