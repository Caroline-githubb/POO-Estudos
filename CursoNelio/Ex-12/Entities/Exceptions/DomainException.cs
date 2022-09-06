namespace Ex_12.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string? message) : base(message)
        {
        }
    }
}