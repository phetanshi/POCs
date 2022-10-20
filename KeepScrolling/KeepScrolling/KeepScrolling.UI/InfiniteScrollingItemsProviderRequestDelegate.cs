namespace KeepScrolling.UI
{
    public delegate Task<IEnumerable<T>> InfiniteScrollingItemsProviderRequestDelegate<T>(InfiniteScrollingItemsProviderRequest context);
}
