namespace VasGreZolFullStack.Common.Responses
{
    public class Response : ErrorStore
    {
        public bool IsSuccess => !HasError;
        public Response() : base() { }
    }
}
