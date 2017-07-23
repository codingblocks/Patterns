using System;
namespace Patterns.Specification
{
    public class ExpressionSpecification<T> : CompositeSpecification<T>
	{
		private Func<T, bool> expression;
		public ExpressionSpecification(Func<T, bool> expression)
		{
			if (expression == null)
				throw new ArgumentNullException();
			else
				this.expression = expression;
		}

		public override bool IsSatisfiedBy(T item)
		{
			return this.expression(item);
		}
	}
}
