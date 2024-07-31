/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using MasspaySdk.Models;
using MasspaySdk.Core;
using MasspaySdk.Services;
using System.Net.Http;
namespace MasspaySdk;
public class Sdk
{
    public AccountService Account { get; }
    public AttributeService Attribute { get; }
    public CardService Card { get; }
    public CatalogService Catalog { get; }
    public KycService Kyc { get; }
    public LoadService Load { get; }
    public PayoutService Payout { get; }
    public SpendBackService SpendBack { get; }
    public SubaccountService Subaccount { get; }
    public TaxService Tax { get; }
    public UserService User { get; }
    public WalletService Wallet { get; }
    private readonly IHttpRequest _httpRequest;
    public Sdk() : this(new OpenAPIConfig())
    { }
    public Sdk(OpenAPIConfig config)
    {
        _httpRequest = new HttpRequest(config);
        Account = new AccountService(_httpRequest);
        Attribute = new AttributeService(_httpRequest);
        Card = new CardService(_httpRequest);
        Catalog = new CatalogService(_httpRequest);
        Kyc = new KycService(_httpRequest);
        Load = new LoadService(_httpRequest);
        Payout = new PayoutService(_httpRequest);
        SpendBack = new SpendBackService(_httpRequest);
        Subaccount = new SubaccountService(_httpRequest);
        Tax = new TaxService(_httpRequest);
        User = new UserService(_httpRequest);
        Wallet = new WalletService(_httpRequest);
    }
}
