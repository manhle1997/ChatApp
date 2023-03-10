namespace ChatApp.Base
{
    public  class ResultBase
    {
        public int StatusCode { get; set; } = 200;
        public string Message { get; set; }
        public bool Success { get; set; } = true;
        public object Data { get; set; }

        public static ResultBase GetResultBase(int statusCode = 200, string message = "", bool success = false, object data = null)
        {
            return new ResultBase { StatusCode = statusCode, Message = message, Success = success, Data = data };
        }

    }
}
