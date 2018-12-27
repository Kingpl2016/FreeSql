﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreeSql {
	public interface ISelect<T1, T2, T3> : ISelect0<ISelect<T1, T2, T3>, T1> where T1 : class where T2 : class where T3 : class {

		List<TReturn> ToList<TReturn>(Expression<Func<T1, T2, T3, TReturn>> select);

		TMember Sum<TMember>(Expression<Func<T1, T2, T3, TMember>> column);
		TMember Min<TMember>(Expression<Func<T1, T2, T3, TMember>> column);
		TMember Max<TMember>(Expression<Func<T1, T2, T3, TMember>> column);
		TMember Avg<TMember>(Expression<Func<T1, T2, T3, TMember>> column);

		ISelect<T1, T2, T3> Where(Expression<Func<T1, T2, T3, bool>> exp);
		ISelect<T1, T2, T3> WhereIf(bool condition, Expression<Func<T1, T2, T3, bool>> exp);

		ISelectGrouping<TKey> GroupBy<TKey>(Expression<Func<T1, T2, T3, TKey>> exp);

		ISelect<T1, T2, T3> OrderBy<TMember>(Expression<Func<T1, T2, T3, TMember>> column);
		ISelect<T1, T2, T3> OrderByDescending<TMember>(Expression<Func<T1, T2, T3, TMember>> column);
	}
}