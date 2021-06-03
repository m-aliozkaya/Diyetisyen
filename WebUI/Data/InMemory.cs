using System.Collections.Generic;
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
        private int patientsID = 0;
        private int dieticiansID = 0;
        private List<Patient> _patients;
        private List<Diet> _diets;
        private List<Dietician> _dieticians;
        private List<IDisease> _diseases;

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


        public InMemory()
        {
            createPatients();
            createDiets();
            createDiseases();
            createDietician();
        }

        public void AddPatients(Patient patient)
        {
            patient.Id = ++patientsID;
            _patients.Add(patient);
        }

        public void AddDieticion(Dietician dietician)
        {
            dietician.Id = ++dieticiansID;
            _dieticians.Add(dietician);
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
            return _dieticians;
        }
        public List<IDisease> GetDiseases()
        {
            return _diseases;
        }
        private void createPatients()
        {
            _patients = new List<Patient>();
            _patients.Add(new Patient { Diet = new GlutenFree(), Disease = new Obese(), Id = ++patientsID, Name = "salih", TcNo = "1111",DieticianId = 1});
            _patients.Add(new Patient { Diet = new Mediterranean(), Disease =new Celiac(), Id = ++patientsID, Name = "ali", TcNo = "1111", DieticianId = 2 });
            _patients.Add(new Patient { Diet = new SeaProducts(), Disease = new Diabetes(), Id = ++patientsID, Name = "beyza", TcNo = "1111",DieticianId = 3 });
            _patients.Add(new Patient { Diet = new WorldOfGreenery(), Disease = new Obese(), Id = ++patientsID, Name = "muhammed", TcNo = "1111",DieticianId = 1 });
            _patients.Add(new Patient { Diet = new GlutenFree(), Disease = new Celiac(), Id = ++patientsID, Name = "ahmet", TcNo = "1111",DieticianId = 2 });
            _patients.Add(new Patient { Diet = new WorldOfGreenery(), Disease = new Diabetes(), Id = ++patientsID, Name = "veli", TcNo = "1111" ,DieticianId = 3});
            _patients.Add(new Patient { Diet = new GlutenFree(), Disease = new Obese(), Id = ++patientsID, Name = "eren", TcNo = "1111",DieticianId = 1 });
            _patients.Add(new Patient { Diet = new SeaProducts(), Disease = new Celiac(), Id = ++patientsID, Name = "ayşe", TcNo = "1111",DieticianId = 2 });
            _patients.Add(new Patient { Diet = new GlutenFree(), Disease = new Diabetes(), Id = ++patientsID, Name = "ali", TcNo = "1111", DieticianId = 3 });
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
            _dieticians = new List<Dietician>();
            _dieticians.Add(new Dietician{Id = ++dieticiansID});
            _dieticians.Add(new Dietician { Id = ++dieticiansID });
            _dieticians.Add(new Dietician { Id = ++dieticiansID });
        }
    }

}
