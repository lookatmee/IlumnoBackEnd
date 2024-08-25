﻿namespace Ilumno.Core.Common.Models;

public class KeySetPaginationBase<T> where T : class
{
    public T? Reference { get; set; }
    public int PageSize { get; set; } = 10;
    public string SearchCriteria { get; set; } = string.Empty;
}

