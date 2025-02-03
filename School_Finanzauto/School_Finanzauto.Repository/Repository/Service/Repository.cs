using Microsoft.EntityFrameworkCore;
using School_Finanzauto.Repository.Context;
using School_Finanzauto.Repository.Entity.Base;
using School_Finanzauto.Repository.Repository.Interface;
using System;
using System.Linq.Expressions;

namespace School_Finanzauto.Repository.Repository.Service
{
	public class Repository<T> : IRepository<T> where T : BaseEntity
	{
		private readonly SchoolContext contextDataBase;
		private readonly DbSet<T> entity;

		public Repository(SchoolContext contextDataBase)
		{
			this.contextDataBase = contextDataBase;
			this.entity = this.contextDataBase.Set<T>();
		}

		public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
		{
			IQueryable<T> query = this.entity
				.AsNoTracking()
				.Where(predicate);

			return query.ToList();
		}

		public IEnumerable<T> FindByInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
		{
			IQueryable<T> query = this.entity
				.AsNoTracking()
				.Where(predicate);

			foreach (var include in includes)
			{
				query = query.Include(include);
			}

			return query.ToList();
		}
		public T SingleFindBy(Expression<Func<T, bool>> predicate)
		{
			return this.entity.SingleOrDefault(predicate);
		}

		public void Insert(T entity)
		{
			if (entity == null) throw new ArgumentNullException("entity");
			this.entity.Add(entity);
			this.contextDataBase.SaveChanges();
		}

		public void Update(T entity)
		{
			if (entity == null) throw new ArgumentNullException("entity");
			this.contextDataBase.SaveChanges();
		}

		public IEnumerable<T> All()
		{
			IQueryable<T> query = this.entity
				.AsNoTracking();

			return query.ToList();
		}

		public T SingleFindByInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
		{
			IQueryable<T> query = this.entity
			   .AsNoTracking()
			   .Where(predicate);

			foreach (var include in includes)
			{
				query = query.Include(include);
			}

			return query.SingleOrDefault();
		}
	}
}
