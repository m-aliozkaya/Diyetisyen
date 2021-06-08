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
        private int patientID = 0;
        private List<Diet> _diets;
        private List<Disease> _diseases;
        private List<IUser> _users;
        private List<Patient> _patients;

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
            patient.Id = ++patientID;
            _patients.Add(patient);
        }

        public void AddDietician(Dietician dietician)
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
            return _patients;
        }

        public List<Diet> GetDiets()
        {
            return _diets;
        }

        public List<Dietician> GetDieticians()
        {
            return _users.Where(u => u.GetType() == typeof(Dietician)).Cast<Dietician>().ToList();
        }
        public List<Disease> GetDiseases()
        {
            return _diseases;
        }

        private void createPatients()
        {
            _patients = new List<Patient>();
            List<Dietician> dietician = _users.Where(d => d.GetType() == typeof(Dietician)).Cast<Dietician>().ToList();
            _patients.Add(new Patient { Diet = _diets[0], Disease = _diseases[0], Id = ++patientID, TcNo = "1111", Dietician = dietician[0], FirstName = "salih", LastName = "ÖZKARA" });
            _patients.Add(new Patient { Diet = _diets[1], Disease = _diseases[1], Id = ++patientID, TcNo = "1111", Dietician = dietician[1], FirstName = "ali", LastName = "ÖZKAYA" });
            _patients.Add(new Patient { Diet = _diets[2], Disease = _diseases[2], Id = ++patientID, TcNo = "1111", Dietician = dietician[2], FirstName = "beyza", LastName = "ERDEM" });
            _patients.Add(new Patient { Diet = _diets[3], Disease = _diseases[0], Id = ++patientID, TcNo = "1111", Dietician = dietician[0], FirstName = "muhammed", LastName = "ÖZKAYA" });
            _patients.Add(new Patient { Diet = _diets[0], Disease = _diseases[1], Id = ++patientID, TcNo = "1111", Dietician = dietician[1], FirstName = "ahmet", LastName = "ÇAKIR" });
            _patients.Add(new Patient { Diet = _diets[1], Disease = _diseases[2], Id = ++patientID, TcNo = "1111", Dietician = dietician[2], FirstName = "veli", LastName = "ÇETİN" });
            _patients.Add(new Patient { Diet = _diets[2], Disease = _diseases[0], Id = ++patientID, TcNo = "1111", Dietician = dietician[0], FirstName = "eren", LastName = "GÜRSOY" });
            _patients.Add(new Patient { Diet = _diets[3], Disease = _diseases[1], Id = ++patientID, TcNo = "1111", Dietician = dietician[1], FirstName = "ayşe", LastName = "YILMAZ" });
            _patients.Add(new Patient { Diet = _diets[0], Disease = _diseases[2], Id = ++patientID, TcNo = "1111", Dietician = dietician[2], FirstName = "ali", LastName = "KORKMAZ" });
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
            _diseases = new List<Disease>();
            _diseases.Add(new Celiac());
            _diseases.Add(new Obese());
            _diseases.Add(new Diabetes());
        }
        private void createDietician()
        {
            _users.Add(new Dietician { Id = ++userID, City = "Burdur", Experience = 2, FirstName = "Beyza", LastName = "ERDEM", HospitalName = "Burdur Devlet Hastanesi", Image = "", TcNo = "123", UniversityName = "Manisa Celal Bayar Universitesi", Password = "12345", UserName = "DBeyza" });
            _users.Add(new Dietician { Id = ++userID, City = "Sinop", Experience = 1, FirstName = "Muhammed Ali", LastName = "ÖZKAYA", HospitalName = "Sinop Devlet Hastanesi", Image = "", TcNo = "123", UniversityName = "Manisa Celal Bayar Universitesi", Password = "12345", UserName = "krai" });
            _users.Add(new Dietician { Id = ++userID, City = "Tokat", Experience = 1, FirstName = "Salih", LastName = "ÖZKARA", HospitalName = "Tokat Devlet Hastanesi", Image = "", TcNo = "123", UniversityName = "Manisa Celal Bayar Universitesi", Password = "12345", UserName = "DSalih" });
        }

        private void creatAdmins()
        {
            _users.Add(new Admin { Id = ++userID, TcNo = "123", FirstName = "", LastName = "", Password = "12345", UserName = "admin" });
        }
    }

}
