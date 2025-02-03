using System.Linq.Expressions;

namespace School_Finanzauto.Repository.Repository.Interface
{
	public interface IRepository<T>
	{
		T SingleFindBy(Expression<Func<T, bool>> predicate);
		IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
		IEnumerable<T> All();
		IEnumerable<T> FindByInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
		T SingleFindByInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
		void Insert(T entity);
		void Update(T entity);
	}
}
