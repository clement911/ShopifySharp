#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IProductServiceFactory
{
    /// Creates a new instance of the <see cref="IProductService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IProductService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IProductService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IProductService Create(ShopifyApiCredentials credentials);
}

public class ProductServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IProductServiceFactory
{
    /// <inheritDoc />
    public virtual IProductService Create(string shopDomain, string accessToken)
    {
        var service = new ProductService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IProductService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}