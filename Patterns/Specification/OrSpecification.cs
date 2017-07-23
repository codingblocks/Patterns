namespace Patterns.Specification
{
    public class OrSpecification<T> : CompositeSpecification<T>
	{
		ISpecification<T> firstSpecification;
		ISpecification<T> secondSpecification;

		public OrSpecification(ISpecification<T> first, ISpecification<T> second)
		{
            this.firstSpecification = first;
			this.secondSpecification = second;
		}

		public override bool IsSatisfiedBy(T item)
		{
			return this.firstSpecification.IsSatisfiedBy(item)
				|| this.secondSpecification.IsSatisfiedBy(item);
		}
	}
}
