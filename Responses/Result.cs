namespace PractiaTest.Models.Responses
{
    public enum ResultCode
    {
        Ok = 0,
        BadRequest = 400,
        InternalError = 500
    }
    
    public class Result
    {
        public string ErrorMessage { get; set; }
        public ResultCode ResultCode { get; set; }
    }

    public class Result<T> : Result
    {
        public T Data { get; set; }
    }
}