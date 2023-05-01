namespace Padutronics.Formatting.Ranges;

public sealed class RangeFormatOptions
{
    public string ClosingExclusiveCap { get; set; } = ")";

    public string ClosingInclusiveCap { get; set; } = "]";

    public string Delimiter { get; set; } = ",";

    public bool InsertSpaceAfterDelimiter { get; set; } = true;

    public bool InsertSpaceBeforeDelimiter { get; set; }

    public bool InsertSpaceWithinCaps { get; set; }

    public string OpeningExclusiveCap { get; set; } = "(";

    public string OpeningInclusiveCap { get; set; } = "[";
}