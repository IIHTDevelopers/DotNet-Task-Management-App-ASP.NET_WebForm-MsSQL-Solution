using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TaskManagementApp.DAL.Interfaces;

namespace TaskManagementApp.DAL.Services
{
    public class TaskRepository : Interfaces.ITaskRepository
    {
        private TaskDbContext _context;

        public TaskRepository(TaskDbContext context)
        {
            _context = context;
        }

        public Model.TaskModel GetById(int id)
        {
            return _context.TaskModels.FirstOrDefault(t => t.Id == id);
        }

        public string GetAll()
        {
            string qry = "select* from TaskModels";
            return qry;
        }

        public string Add()
        {
            string qry = "insert into TaskModels(Title, IsCompleted, DueDate)" +
                "values('";
            return qry;
        }

        public string Update()
        {
            var query = "update TaskModels set Title='";
            return query;
        }

        public string Delete()
        {
            var query = "delete from TaskModels where Id='";
            return query;
        }
    }
}