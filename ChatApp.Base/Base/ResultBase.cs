namespace ChatApp.Base
{
    public  class ResultBase
    {
        public int StatusCode { get; set; } = 200;
        public string Message { get; set; }
        public bool Success { get; set; } = true;
        public object Data { get; set; }

    }
}
