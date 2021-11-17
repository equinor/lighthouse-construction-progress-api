namespace lighthouse_construction_progress_api.Domain.Exceptions;

public class UnsupportedColourException : Exception
{
    public UnsupportedColourException(string code)
        : base($"Colour \"{code}\" is unsupported.")
    {
    }
}
