namespace GT.Administration.System.Common.CleanArch
{
    public interface IResultInteractor<TRequest, TResult> : MediatR.IRequestHandler<TRequest, Result<TResult>>
        where TRequest : IResultRequest<TResult>
    { }
}
