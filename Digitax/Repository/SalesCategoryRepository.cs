using CoreSM.Interface;
using CoreSM.Models;
using CoreSM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CoreSM.Model
{
    public class SalesCategoryRepository : GenericRepository<tbl_Company>, ISalesCategory_Repository
    {
        private readonly SalesDbContext db;

        public SalesCategoryRepository(SalesDbContext context) : base(context)
        {
        }

        public void Add(SalesCategory entity)
        {
            _context.SalesCategory.Add(entity);
            _context.SaveChanges();
        }

        public void AddRange(IEnumerable<SalesCategory> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesCategory> Find(Expression<Func<SalesCategory, bool>> expression)
        {
            return _context.SalesCategory.Where(expression);
        }

        public void Remove(SalesCategory entity)
        {
            _context.SalesCategory.Remove(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<SalesCategory> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<SalesCategory> IGenericRepository<SalesCategory>.GetAll()
        {
            return _context.SalesCategory.ToList();
        }

        SalesCategory IGenericRepository<SalesCategory>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesCategory> GetSalesCategoryByType(string Type, string PayerType)
        {
            return _context.SalesCategory.Where(x => x.Type == Type && x.PayerType == PayerType).ToList();
        }

        public SalesCategory GetSalesTaxByCategory(int ID)
        {
            return _context.SalesCategory.Where(x => x.ID == ID).FirstOrDefault();
        }

        public SalesCategory PutSalesCategory(SalesCategory category)
        {
            _context.SalesCategory.Update(category);
            _context.SaveChanges();
            return _context.SalesCategory.Where(x => x.ID == category.ID).FirstOrDefault();
        }
    }
}