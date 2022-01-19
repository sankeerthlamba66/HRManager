namespace HRManager.Code
{
    public class ErrorMessage
    {
        public ErrorMessage(int ErrorId)
        {
            Message = string.Format("Something went wrong. Please refer the following code for assistance. Code: {0}", ErrorId);
        }

        public string Message { get; set; }
    }
}
