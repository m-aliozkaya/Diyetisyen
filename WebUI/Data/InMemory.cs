using System.Collections.Generic;
using System.Linq;
using WebUI.Entity;
using WebUI.Entity.Diets.Abstract;
using WebUI.Entity.Diets.Concrete;
using WebUI.Entity.Diseases.Abstract;
using WebUI.Entity.Diseases.Concrete;

namespace WebUI.Data
{
    public class InMemory
    {
        private static InMemory _inMemory;
        private static object _lockObject = new object();
        private int userID = 0;
        private List<Diet> _diets;
        private List<IDisease> _diseases;
        private List<IUser> _users;

        public static InMemory Memory
        {
            get
            {
                lock (_lockObject)
                {
                    if (_inMemory == null)
                    {
                        _inMemory = new InMemory();
                    }
                }
                return _inMemory;
            }
        }

        private InMemory()
        {
            _users = new List<IUser>();
            createDietician();
            createDiseases();
            createDiets();
            creatAdmins();
            createPatients();
        }

        public void AddPatient(Patient patient)
        {
            patient.Id = ++userID;
            _users.Add(patient);
        }

        public void AddDieticion(Dietician dietician)
        {
            dietician.Id = ++userID;
            _users.Add(dietician);
        }

        public List<IUser> GetUsers()
        {
            return _users;
        }
        public List<Patient> GetPatients()
        {
            return _users.Where(u => u.GetType() == typeof(Patient)).Cast<Patient>().ToList();
        }

        public List<Diet> GetDiets()
        {
            return _diets;
        }

        public List<Dietician> GetDieticians()
        {
            return _users.Where(u => u.GetType() == typeof(Dietician)).Cast<Dietician>().ToList();
        }
        public List<IDisease> GetDiseases()
        {
            return _diseases;
        }

        private void createPatients()
        {
            List<Dietician> dietician = _users.Where(d => d.GetType() == typeof(Dietician)).Cast<Dietician>().ToList();
            _users.Add(new Patient { Diet = _diets[0], Disease = _diseases[0], Id = ++userID, FirstName = "salih", TcNo = "1111", Dietician = dietician[0] ,Password = "12345",UserName = "salih"});
            _users.Add(new Patient { Diet = _diets[1], Disease = _diseases[1], Id = ++userID, FirstName = "ali", TcNo = "1111", Dietician = dietician[1], Password = "12345", UserName = "ali" });
            _users.Add(new Patient { Diet = _diets[2], Disease = _diseases[2], Id = ++userID, FirstName = "beyza", TcNo = "1111", Dietician = dietician[2] ,Password = "12345",UserName = "beyza"});
            _users.Add(new Patient { Diet = _diets[3], Disease = _diseases[0], Id = ++userID, FirstName = "muhammed", TcNo = "1111", Dietician = dietician[0] ,Password = "12345",UserName = "muhammed"});
            _users.Add(new Patient { Diet = _diets[0], Disease = _diseases[1], Id = ++userID, FirstName = "ahmet", TcNo = "1111", Dietician = dietician[1] ,Password = "12345",UserName = "ahmet"});
            _users.Add(new Patient { Diet = _diets[1], Disease = _diseases[2], Id = ++userID, FirstName = "veli", TcNo = "1111", Dietician = dietician[2] ,Password = "12345",UserName = "veli"});
            _users.Add(new Patient { Diet = _diets[2], Disease = _diseases[0], Id = ++userID, FirstName = "eren", TcNo = "1111", Dietician = dietician[0] ,Password = "12345",UserName = "eren"});
            _users.Add(new Patient { Diet = _diets[3], Disease = _diseases[1], Id = ++userID, FirstName = "ayşe", TcNo = "1111", Dietician = dietician[1] ,Password = "12345",UserName = "ayse"});
            _users.Add(new Patient { Diet = _diets[0], Disease = _diseases[2], Id = ++userID, FirstName = "ali", TcNo = "1111", Dietician = dietician[2] ,Password = "12345",UserName = "ali2"});
        }

        private void createDiets()
        {
            _diets = new List<Diet>();
            _diets.Add(new GlutenFree());
            _diets.Add(new Mediterranean());
            _diets.Add(new SeaProducts());
            _diets.Add(new WorldOfGreenery());
        }

        private void createDiseases()
        {
            _diseases = new List<IDisease>();
            _diseases.Add(new Celiac());
            _diseases.Add(new Obese());
            _diseases.Add(new Diabetes());
        }
        private void createDietician()
        {
            _users.Add(new Dietician { Id = ++userID, City = "Burdur", Experience = 2, FirstName = "Beyza", LastName = "ERDEM", HospitalName = "Burdur Devlet Hastanesi", Image = "", TcNo = "123", UniversityName = "Manisa Celal Bayar Universitesi",Password = "12345",UserName = "DBeyza" });
            _users.Add(new Dietician { Id = ++userID, City = "Sinop", Experience = 1, FirstName = "Muhammed Ali", LastName = "ÖZKAYA", HospitalName = "Sinop Devlet Hastanesi", Image = "", TcNo = "123", UniversityName = "Manisa Celal Bayar Universitesi",Password = "12345",UserName = "krai" });
            _users.Add(new Dietician { Id = ++userID, City = "Tokat", Experience = 1, FirstName = "Salih", LastName = "ÖZKARA", HospitalName = "Tokat Devlet Hastanesi", Image = "", TcNo = "123", UniversityName = "Manisa Celal Bayar Universitesi",Password = "12345",UserName = "DSalih" });
        }

        private void creatAdmins()
        {
            _users.Add(new Admin{Id = ++userID,TcNo = "123",FirstName = "",LastName = "",Password = "12345",UserName = "admin"});
        }
    }

}
