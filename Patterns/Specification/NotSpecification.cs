namespace Patterns.Specification
{
    public class NotSpecification<T> : CompositeSpecification<T>
	{
		ISpecification<T> specification;

		public NotSpecification(ISpecification<T> spec)
		{
			this.specification = spec;
		}

		public override bool IsSatisfiedBy(T item)
		{
            return this.specification.IsSatisfiedBy(item) == false;
		}
	}
}
