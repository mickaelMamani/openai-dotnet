// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalRunTruncationStrategyType : IEquatable<InternalRunTruncationStrategyType>
    {
        private readonly string _value;

        public InternalRunTruncationStrategyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string LastMessagesValue = "last_messages";

        public static InternalRunTruncationStrategyType Auto { get; } = new InternalRunTruncationStrategyType(AutoValue);
        public static InternalRunTruncationStrategyType LastMessages { get; } = new InternalRunTruncationStrategyType(LastMessagesValue);
        public static bool operator ==(InternalRunTruncationStrategyType left, InternalRunTruncationStrategyType right) => left.Equals(right);
        public static bool operator !=(InternalRunTruncationStrategyType left, InternalRunTruncationStrategyType right) => !left.Equals(right);
        public static implicit operator InternalRunTruncationStrategyType(string value) => new InternalRunTruncationStrategyType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalRunTruncationStrategyType other && Equals(other);
        public bool Equals(InternalRunTruncationStrategyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}