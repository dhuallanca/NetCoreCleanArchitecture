﻿using Application.ResultHandler;
using System.Data.SqlTypes;


namespace Application.Result
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public T? Model { get; }
        public Error? Error { get; set; }
        public bool IsElse { get; }

        private Result(bool isSuccess, T? value, Error? error) { 
            IsSuccess = isSuccess;
            Model = value;
            Error = error;
        }

        public static Result<T> Success(T value) => new(true,value, null);
        public static Result<T> Failure(Error error) => new(false, default, error);
    }
}
