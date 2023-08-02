namespace Pro3ventos.Application.Input.Handlers
{
    public class State
    {
        public State(int statusCode, string message, object data)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; private set; }


        public void SetData(object data)
        {
            Data = data;
        }
    }
}
