using BinanceBot;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace DTO.Abstract
{

	public abstract class BaseRepo<T> where T : class
	{
		protected DatabaseContext _context;
		protected DbSet<T> _dbSet;
		public BaseRepo(DatabaseContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}
		public bool IsExistRecord(int ID) => GetById(ID) != null;
		public void Add(T entity)
		{
			_dbSet.Add(entity);
			_context.SaveChanges();
		}
		public T GetById(int ID) => _dbSet.Find(ID);
		public List<T> GetList() => _dbSet.ToList();
		public void Remove(int ID)
		{
			_dbSet.Remove(GetById(ID));
			_context.SaveChanges();
		}
		public void Update(T obje)
		{
			_dbSet.Update(obje);
			_context.SaveChanges();
		}
	}
}
