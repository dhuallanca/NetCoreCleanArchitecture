using Domain.ResultHandler;


namespace Domain.Result
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public T? Model { get; }
        public Error? Error { get; set; }

        // pivate constructor so cannot create instances of this class
        private Result(bool isSuccess, T? value, Error? error) { 
            IsSuccess = isSuccess;
            Model = value;
            Error = error;
        }

        public static Result<T> Success(T value) => new(true,value, null);
        public static Result<T> Failure(Error error) => new(false, default, error);
    }
}
