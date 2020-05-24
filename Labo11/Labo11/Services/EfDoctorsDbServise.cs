using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labo11.Services
{
    public class EfDoctorsDbServise : IDoctorsDbService
    {
        DoctorsDbContext _context;
        public EfDoctorsDbServise(DoctorsDbContext context)
        {
            _context = context;
        }

      

        public void AddDoctor(Doctor doctor)
        {
           _context.Doctors.Add(doctor);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
           return _context.Doctors.ToList();
        }

        public void RemoveDoctor(int id)
        {
            _context.Doctors.Remove(_context.Doctors.First(d => d.IdDoctor == id));
        }

        public void  UpdateDoctor(Doctor doctor)
        {
            var toUpdate = _context.Doctors.First(d => d.IdDoctor == doctor.IdDoctor);

            toUpdate.LastName = doctor.LastName;
            toUpdate.Email = doctor.E;
            toUpdate.FirstName = doctor.FirstName;
        }
    }
}
