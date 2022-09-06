namespace Ex_Fixacao11.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string? message) : base(message)
        {
        }
        
    }
}