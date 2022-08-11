namespace FileIODemo2.DomainExceptions
{
    public class UnableToReadContactsException : ApplicationException
    {
        public UnableToReadContactsException(string msg = null, Exception innerExp = null) : base(msg, innerExp)
        {

        }
    }
}
