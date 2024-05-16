class ProxyHandler
{
    private readonly string _proxyUrl;

    public ProxyHandler(string proxyUrl)
    {
        if (string.IsNullOrWhiteSpace(proxyUrl))
        {
            throw new ArgumentException("Proxy URL cannot be null or whitespace.", nameof(proxyUrl));
        }

        _proxyUrl = proxyUrl;
    }

    public HttpClient CreateHttpClient()
    {
        var httpClientHandler = new HttpClientHandler
        {
            Proxy = new WebProxy(_proxyUrl),
            PreAuthenticate = true,
            UseDefaultCredentials = false
        };

        return new HttpClient(httpClientHandler);
    }
}
