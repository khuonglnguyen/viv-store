using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SourceCode.Data;
using SourceCode.Models;

namespace SourceCode.Service
{
    public interface IProductCategoryParentService
    {
        IEnumerable<ProductCategoryParent> GetProductCategoryParentList();
        ProductCategoryParent GetByID(int ID);
    }
    public class ProductCategoryParentService : IProductCategoryParentService
    {
        private readonly UnitOfWork context;
        public ProductCategoryParentService(UnitOfWork repositoryContext)
        {
            this.context = repositoryContext;
        }
        public ProductCategoryParent GetByID(int ID)
        {
            return this.context.ProductCategoryParentRepository.GetDataByID(ID);
        }

        public IEnumerable<ProductCategoryParent> GetProductCategoryParentList()
        {
            IEnumerable<ProductCategoryParent> listProductCategoryParent = this.context.ProductCategoryParentRepository.GetAllData();
            return listProductCategoryParent;
        }
    }
}