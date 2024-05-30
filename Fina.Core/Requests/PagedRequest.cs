namespace Fina.Core;

public abstract class PagedRequest : Request
{
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
}
