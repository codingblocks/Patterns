﻿namespace Patterns.Specification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
	{
		public abstract bool IsSatisfiedBy(T item);

		public ISpecification<T> And(ISpecification<T> specification)
		{
			return new AndSpecification<T>(this, specification);
		}
		public ISpecification<T> Or(ISpecification<T> specification)
		{
			return new OrSpecification<T>(this, specification);
		}
		public ISpecification<T> Not(ISpecification<T> specification)
		{
			return new NotSpecification<T>(specification);
		}
	}
}
