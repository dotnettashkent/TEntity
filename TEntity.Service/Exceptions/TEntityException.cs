namespace TEntity.Service.Exceptions
{
    public class TEntityException : Exception
    {
        public int Code { get; set; }
        public TEntityException(int code, string message = "something wrong") : base(message)
        {
            this.Code = code;
        }
    }
}
