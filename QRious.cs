namespace QriousSharp;
/// <summary>
/// Represents the properties for configuring a QR code.
/// </summary>
public class QRious
{
    /// <summary>
    /// Gets or sets the background color of the QR code.
    /// Default value is "white".
    /// </summary>
    public string Background { get; set; } = "white";
    /// <summary>
    /// Gets or sets the background alpha (transparency) of the QR code.
    /// Default value is 1.0.
    /// </summary>
    public double BackgroundAlpha { get; set; } = 1.0;
    /// <summary>
    /// Gets or sets the foreground color of the QR code.
    /// Default value is "black".
    /// </summary>
    public string Foreground { get; set; } = "black";

    /// <summary>
    /// Gets or sets the foreground alpha (transparency) of the QR code.
    /// Default value is 1.0.
    /// </summary>
    public double ForegroundAlpha { get; set; } = 1.0;

    /// <summary>
    /// Gets or sets the error correction level of the QR code.
    /// Valid values are "L", "M", "Q", and "H".
    /// Default value is "L".
    /// </summary>
    public string Level { get; set; } = "L";

    /// <summary>
    /// Gets or sets the MIME type used to render the image for the QR code.
    /// Default value is "image/png".
    /// </summary>
    public string Mime { get; set; } = "image/png";
    /// <summary>
    /// Gets or sets the padding for the QR code in pixels.
    /// Default value is null (auto).
    /// </summary>
    public int? Padding { get; set; } = null;

    /// <summary>
    /// Gets or sets the size of the QR code in pixels.
    /// Default value is 100.
    /// </summary>
    public int Size { get; set; } = 100;

    /// <summary>
    /// Gets or sets the value encoded within the QR code.
    /// Default value is an empty string.
    /// </summary>
    public string Value { get; set; } = "";
}
