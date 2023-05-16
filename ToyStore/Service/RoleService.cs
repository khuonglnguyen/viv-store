using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SourceCode.Data;
using SourceCode.Models;

namespace SourceCode.Service
{
    public interface IRoleService
    {
        IEnumerable<Role> GetRoleList();
        Role GetRoleByID(int ID);
    }
    public class RoleService : IRoleService
    {
        private readonly UnitOfWork context;
        public RoleService(UnitOfWork repositoryContext)
        {
            this.context = repositoryContext;
        }

        public Role GetRoleByID(int ID)
        {
            return context.RoleRepository.GetDataByID(ID);
        }

        public IEnumerable<Role> GetRoleList()
        {
            return context.RoleRepository.GetAllData();
        }
    }
}