using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TaskManagementApp.DAL.Interfaces;
using TaskManagementApp.Model;

namespace TaskManagementApp.DAL.Services
{
    public class TaskService : Interfaces.ITaskService
    {
        private Interfaces.ITaskRepository _repository;

        public TaskService(Interfaces.ITaskRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            return _repository.GetAll();
        }

        public string Add()
        {
            return _repository.Add();
        }

        public string Update()
        {
            return _repository.Update();
        }

        public string Delete()
        {
            return _repository.Delete();
        }
    }
}