﻿namespace GT.Administration.System.Common
{
    public interface ISuccess
    { }

    public interface ISuccess<T> : ISuccess
    {
        T Data { get; }
    }
}
