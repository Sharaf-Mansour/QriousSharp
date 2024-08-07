# QriousSharp

A Blazor Lib creates QR for Blazor. Based on [qrious](https://www.npmjs.com/package/qrious).

# Install

Install this package in project packages with:

```bash
Install-Package QriousSharp -Version 4.0.2
```

# How to use

```html
<Qrious Id="123" @bind-QRious="qr"></Qrious>
<button @onclick="GenerateQR">Generate QR</button>
```

```csharp
    private QRious qr = new QRious
    {
        Value = "https://www.google.com",
        Size = 200
    };
    void GenerateQR()
    {
        qr = new QRious();
        qr.Size = 500;
        qr.Value = "https://www.bing.com";
     }

```
