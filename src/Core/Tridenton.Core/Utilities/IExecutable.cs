﻿namespace Tridenton.Core.Utilities;

public interface IExecutable
{
    ValueTask<Result> ExecuteAsync(CancellationToken cancellationToken = default);
}

public interface IExecutable<TParams>
{
    ValueTask<Result> ExecuteAsync(TParams @params, CancellationToken cancellationToken = default);
}
