<div align='center' class='text-center'>
  <img alt='' src='./assets/logo.png' width='200' />
  <h1 align='center' class='text-center'>MasspaySdk</h1>
</div>

<div align='center' class='text-center'>
  <a aria-label='Version' href='#'>
    <img alt='' src='https://img.shields.io/badge/version-1.0.0-blue' />
  </a>
  <a aria-label='License' href='https://opensource.org/licenses/MIT'>
    <img alt='' src='https://img.shields.io/badge/License-MIT-blue.svg' />
  </a>
</div>

Welcome to our MasspaySdk. We are committed to providing you with the best SDK services experience possible. Please use our step-by-step instructions to become familiar with how to use our SDK.

- Current API version: 0.1.4
- Current package version: 1.0.0

## Table of Contents

- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Frequently Asked Questions (FAQ)](#frequently-asked-questions-faq)

## Requirements

- Installed .NET, stable version >= 7.0. If you do not have it installed, please refer to the [Microsoft website](https://dotnet.microsoft.com/en-us/download/dotnet/7.0).
- MassPay.io API credentials.

## Installation

Use this command to install MasspaySdk in your terminal.

```bash
dotnet add package MasspaySdk
```

## Usage

In case that you successfully installed our MasspaySdk please execute this code:

```csharp
using MasspaySdk.Core;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var config = new OpenAPIConfig();
        config.SetTokenValue("YOUR_API_KEY");
        var sdk = new MasspaySdk.Sdk(config);
        
        try {
            var response = await sdk.Account.getAccountBalance(/* query parameters */);
            // Use response data
        } catch (ApiError e) {
            // Handle exception
        }
    }
}
```

## Features

Kindly note that every URI is relative to _https://api.masspay.io/v0.1.4_.

The table displays all features categorized based on their specific purposes.

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
_MasspaySdk.Sdk.Account_ | **GetAccountBalance** | **GET** /account/balance | Get current available balance
_MasspaySdk.Sdk.Account_ | **GetAccountStatement** | **GET** /account/statement | Get certified account statement
_MasspaySdk.Sdk.Attribute_ | **GetAllAttrs** | **GET** /attribute/{user_token} | Get all stored user attributes
_MasspaySdk.Sdk.Attribute_ | **StoreAttrs** | **POST** /attribute/{user_token}/{destination_token}/{currency} | Store user attributes
_MasspaySdk.Sdk.Attribute_ | **GetAttrs** | **GET** /attribute/{user_token}/{destination_token}/{currency} | Get user attributes for destination_token
_MasspaySdk.Sdk.Card_ | **GetWalletCardInfo** | **GET** /wallet/{user_token}/{wallet_token}/card | Get MassPay card information
_MasspaySdk.Sdk.Card_ | **UpdateWalletCardInfo** | **PUT** /wallet/{user_token}/{wallet_token}/card | Update MassPay card information
_MasspaySdk.Sdk.Catalog_ | **GetCountryList** | **GET** /country/list | Gets a list of countries where services offered.
_MasspaySdk.Sdk.Catalog_ | **GetCountryServices** | **GET** /country/{country_code} | Gets a list of Companies and their service offerings for the given country code.
_MasspaySdk.Sdk.Catalog_ | **GetCheapestCountryServices** | **GET** /country/{country_code}/cheapest | Gets a list of Companies and their cheapest service offerings for the given country code.
_MasspaySdk.Sdk.Catalog_ | **GetDestinationTokenAlternatives** | **GET** /service/{destination_token}/alternatives | Returns list of alternative service to a provided service
_MasspaySdk.Sdk.Catalog_ | **GetDestinationToken** | **GET** /service/{destination_token} | Returns provided service
_MasspaySdk.Sdk.Catalog_ | **GetUserAgreement** | **GET** /user-agreements | Get user agreement
_MasspaySdk.Sdk.Catalog_ | **GetUserAgreementsNames** | **OPTIONS** /user-agreements | Get available user agreements
_MasspaySdk.Sdk.Kyc_ | **FindAttributesVelocity** | **POST** /attribute/{user_token}/velocity | Attributes velocity check
_MasspaySdk.Sdk.Kyc_ | **GetUserUserTokenKycAu10Tix** | **GET** /user/{user_token}/kyc/au10tix | Get an Au10tix session link
_MasspaySdk.Sdk.Kyc_ | **UploadIdPhotos** | **POST** /user/{user_token}/kyc/id | Upload ID photos
_MasspaySdk.Sdk.Kyc_ | **GetUserUserTokenKycVeriff** | **GET** /user/{user_token}/kyc/veriff | Get a Veriff session link
_MasspaySdk.Sdk.Load_ | **ResendBalanceNotification** | **PUT** /wallet/{user_token} | Resend balance notification
_MasspaySdk.Sdk.Load_ | **LoadUser** | **POST** /load/{user_token} | Initiate a load transaction
_MasspaySdk.Sdk.Load_ | **GetUserLoadsByToken** | **GET** /load/{user_token} | Get history of loads by user token
_MasspaySdk.Sdk.Load_ | **ResendLoadNotification** | **PUT** /load/{user_token} | Resend load notification
_MasspaySdk.Sdk.Load_ | **CancelUserLoad** | **DELETE** /load/{user_token} | Reverse a user load
_MasspaySdk.Sdk.Payout_ | **InitiatePayout** | **POST** /payout/{user_token} | Initiate a payout transaction
_MasspaySdk.Sdk.Payout_ | **GetUserPayoutsByToken** | **GET** /payout/{user_token} | Get history of payouts by user token
_MasspaySdk.Sdk.Payout_ | **CommitPayoutTxn** | **PUT** /payout/{user_token}/{payout_token} | Commit payout transaction
_MasspaySdk.Sdk.Payout_ | **GetPayoutStatus** | **GET** /payout/{user_token}/{payout_token} | Get status of a payout by payout token
_MasspaySdk.Sdk.Payout_ | **GetTransactionConfirmationDetails** | **PATCH** /payout/{user_token}/{payout_token} | Get transaction confirmation details
_MasspaySdk.Sdk.SpendBack_ | **GetUserSpendbacksByToken** | **GET** /spendback/{user_token} | Get history of spend backs by user token
_MasspaySdk.Sdk.SpendBack_ | **InitiateSpendback** | **POST** /spendback/{user_token} | Initiate a spend back transaction
_MasspaySdk.Sdk.Tax_ | **GetTaxUsers** | **GET** /tax | Get list of users' annual balance
_MasspaySdk.Sdk.Tax_ | **GetTaxInterviewLink** | **GET** /{user_token}/tax | Get link for tax interview
_MasspaySdk.Sdk.User_ | **CreateUser** | **POST** /user | Create a user
_MasspaySdk.Sdk.User_ | **GetUserByToken** | **GET** /user/{user_token} | Get user by user token
_MasspaySdk.Sdk.User_ | **UpdateUser** | **PUT** /user/{user_token} | Updated user
_MasspaySdk.Sdk.User_ | **UserLookup** | **GET** /user/lookup | Lookup an existing user
_MasspaySdk.Sdk.User_ | **GetUserHistory** | **GET** /user/{user_token}/history | Transactions history
_MasspaySdk.Sdk.Wallet_ | **GetWallet** | **GET** /wallet/{user_token} | Retrieve all available wallets for a user
_MasspaySdk.Sdk.Wallet_ | **GetAutopayRules** | **GET** /wallet/{user_token}/{wallet_token}/autopay | Get all autopay rules
_MasspaySdk.Sdk.Wallet_ | **CreateAutopayRule** | **POST** /wallet/{user_token}/{wallet_token}/autopay | Add autopay rule
_MasspaySdk.Sdk.Wallet_ | **DeleteAutopayRule** | **DELETE** /wallet/{user_token}/{wallet_token}/autopay | Delete autopay rule


## Contributing

To learn more about the possibility of contributing to the subsequent development of this SDK, please visit our [contributing page](./CONTRIBUTING.md). Kindly note that contributions are limited by a unique set of rules in order to ensure clarity.

## License

Please refer to the [license page](./LICENSE) for more information about the license type and the corresponding terms of use.

## Contact

We kindly request that you direct all questions to our support email:

- [info@masspay.io](mailto:info@masspay.io)

## Frequently Asked Questions (FAQ)


