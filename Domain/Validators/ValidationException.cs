namespace Domain.Validators
{
    public class ValidationException : Exception
    {
        public ValidationException(string error) : base(error)
        { }

        public static void When(bool hasError, string message)
        {
            if (hasError)
            {
                throw new ValidationException(message);
            }
        }
    }
}