using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using FluentNHibernate.Utils;


namespace Fluency.Utils
{
	public static class PropertyExpressionExtensions
	{
		/// <summary>
		/// Gets the property info for the specified expression targeting a generic list.
		/// </summary>
		/// <typeparam name="TPropertyType">The type of the property type.</typeparam>
		/// <param name="propertyExpression">The property expression.</param>
		/// <returns></returns>
		public static PropertyInfo GetPropertyInfo< TPropertyType, T >( this Expression< Func< T, IList< TPropertyType > > > propertyExpression ) where T : class, new()
		{
			return ReflectionHelper.GetProperty( propertyExpression );
		}


		/// <summary>
		/// Gets the property info for the specified expression.
		/// </summary>
		/// <typeparam name="TPropertyType">The type of the property type.</typeparam>
		/// <param name="propertyExpression">The property expression.</param>
		/// <returns></returns>
		public static PropertyInfo GetPropertyInfo< TPropertyType, T >( this Expression< Func< T, TPropertyType > > propertyExpression ) where T : class, new()
		{
			return ReflectionHelper.GetProperty( propertyExpression );
		}
	}
}