
/**
 * MassPay API
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Http;
using System;
using System.Text.Json.Serialization;
using MasspaySdk.Models;
using MasspaySdk.Core;

namespace MasspaySdk.Services;


public class CardService
{
    public IHttpRequest HttpRequest { get; }

    public CardService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Get MassPay card information
     * This **GET** endpoint is used to retrieve MassPay card information associated with the provided wallet token. <br> You can use this endpoint to obtain information about the MassPay card associated with the wallet. <br> To use this endpoint, you need to provide the `user_token` and `wallet_token` as required parameters in the URL Path. <br> The response will include a JSON object containing details for the MassPay card, including the card number, balance, status. If your company is not PCI compliant, each field would contain a url that displays the corresponding card detail once accessed through an iFrame.
     * @param userToken Token representing the user who owns the wallet
     * @param walletToken Token representing the wallet
     * @returns CardResp? Succesful operation.
     * @throws ApiError
     */
    public Task<CardResp?> GetWalletCardInfo(
      string userToken,
      string walletToken
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("wallet_token", walletToken);

        return this.HttpRequest.Request<CardResp?>(
          new ApiRequestOptions
          {
              Params = parameters,
              Method = HttpMethod.Get,
              Path = "/wallet/{user_token}/{wallet_token}/card"
          }
        );
    }



    /**
     * Update MassPay card information
     * This **PUT** endpoint is used to update the MassPay card information for a provided user token and wallet token. <br> You can use this endpoint to help your users manage their MassPay card information, including updating their card PIN number or status. <br> To use this endpoint, you need to provide the `user_token` and `wallet_token` as parameters in the URL Path, along with the parameters in the request Query, including the card pin number or(and) status. <br> The endpoint will then update the card information for the provided user and wallet token.
     * @param userToken Token representing the user who owns the wallet
     * @param walletToken Token representing the wallet
     * @param pin New 4 digit pin number for the card (To be used in ATM machines)
     * @param status New status for the card
     * @returns void? Succesful operation.
     * @throws ApiError
     */
    public Task UpdateWalletCardInfo(
      string userToken,
      string walletToken,
      string? pin,
      UpdateWalletCardInfoStatus? status
    )
    {
        var parameters = new Dictionary<string, object>();
        parameters.Add("user_token", userToken);
        parameters.Add("wallet_token", walletToken);

        var query = new Dictionary<string, object>();
        if (pin != null)
        {
            query.Add("pin", pin);
        }
        if (status != null)
        {
            query.Add("status", status);
        }

        return this.HttpRequest.Request(
          new ApiRequestOptions
          {
              Params = parameters,
              Query = query,
              Method = HttpMethod.Put,
              Path = "/wallet/{user_token}/{wallet_token}/card"
          }
        );
    }






    /**
     * New status for the card
     */
    [JsonConverter(typeof(StringValueEnumConverter<UpdateWalletCardInfoStatus>))]
    public enum UpdateWalletCardInfoStatus
    {
        [StringValue("SUSPEND")]
        SUSPEND,
        [StringValue("UNSUSPEND")]
        UNSUSPEND,
        [StringValue("CLOSE")]
        CLOSE
    }
}
