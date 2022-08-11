namespace FileIODemo2.DomainExceptions
{
    public class UnableToSaveContactException : ApplicationException
    {
        public UnableToSaveContactException(string msg = null, Exception innerExp = null) : base(msg, innerExp)
        {

        }
    }
}
