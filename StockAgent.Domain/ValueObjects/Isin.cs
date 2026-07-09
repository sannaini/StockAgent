using System.Text.RegularExpressions;

namespace StockAgent.Domain.ValueObjects
{
    public readonly record struct Isin
    {
        // Compiled regex for structural validation (2 letters, 9 alphanumeric, 1 digit)
        private static readonly Regex StructuralRegex = new(
            @"^[A-Z]{2}[A-Z0-9]{9}[0-9]{1}$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        // Encapsulated underlying value
        public string Value { get; }

        // Helper properties for domain logic
        public string CountryCode => Value[..2];
        public string NationalId => Value[2..11];
        public char CheckDigit => Value[11];

        // Private constructor guarantees the object can only be created in a valid state
        private Isin(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Factory method to create and validate an ISIN.
        /// </summary>
        public static Isin Create(string rawValue)
        {
            if (string.IsNullOrWhiteSpace(rawValue))
                throw new ArgumentException("ISIN cannot be null or empty.", nameof(rawValue));

            string normalized = rawValue.Trim().ToUpperInvariant();

            if (!StructuralRegex.IsMatch(normalized))
                throw new ArgumentException($"The value '{rawValue}' does not match the 12-character ISIN format.", nameof(rawValue));
            
            return new Isin(normalized);
        }

        /// <summary>
        /// Safe parsing pattern to avoid throwing exceptions.
        /// </summary>
        public static bool TryParse(string rawValue, out Isin isin)
        {
            try
            {
                isin = Create(rawValue);
                return true;
            }
            catch
            {
                isin = default;
                return false;
            }
        }

        // Overrides for clean string outputs
        public override string ToString() => Value;
    }

}
