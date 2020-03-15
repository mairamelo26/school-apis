using System;
using System.Linq;
using System.Linq.Expressions;
using Utils.Enums;

namespace Utils.Extensions
{
    public static class FiltersCompute
    {
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string sortingColumn, SortDirection sortDirection)
        {

            if (String.IsNullOrEmpty(sortingColumn))
            {
                return source;
            }

            ParameterExpression parameter = Expression.Parameter(source.ElementType, String.Empty);

            MemberExpression property = Expression.Property(parameter, sortingColumn);
            LambdaExpression lambda = Expression.Lambda(property, parameter);

            string methodName = sortDirection == SortDirection.Ascending ? "OrderBy" : "OrderByDescending";

            Expression methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                                new Type[] { source.ElementType, property.Type },
                                                source.Expression, Expression.Quote(lambda));

            return source.Provider.CreateQuery<T>(methodCallExpression);
        }

    }
}

