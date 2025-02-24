namespace GT.Administration.System.Common.CleanArch
{
    public interface IResultRequest<TResult> : MediatR.IRequest<Result<TResult>>
    { }
}
