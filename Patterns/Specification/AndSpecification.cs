namespace Patterns.Specification
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        ISpecification<T> firstSpecification;
        ISpecification<T> secondSpecification;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.firstSpecification = first;
            this.secondSpecification = second;
        }

        public override bool IsSatisfiedBy(T item)
        {
            return this.firstSpecification.IsSatisfiedBy(item)
                   && this.secondSpecification.IsSatisfiedBy(item);
        }
    }
}
