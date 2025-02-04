// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary>
    /// The status of the lot.
    /// Serialized Name: Status
    /// </summary>
    public readonly partial struct ConsumptionLotStatus : IEquatable<ConsumptionLotStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConsumptionLotStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConsumptionLotStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ActiveValue = "Active";
        private const string InactiveValue = "Inactive";
        private const string ExpiredValue = "Expired";
        private const string CompleteValue = "Complete";
        private const string CanceledValue = "Canceled";

        /// <summary>
        /// None
        /// Serialized Name: Status.None
        /// </summary>
        public static ConsumptionLotStatus None { get; } = new ConsumptionLotStatus(NoneValue);
        /// <summary>
        /// Active
        /// Serialized Name: Status.Active
        /// </summary>
        public static ConsumptionLotStatus Active { get; } = new ConsumptionLotStatus(ActiveValue);
        /// <summary>
        /// Inactive
        /// Serialized Name: Status.Inactive
        /// </summary>
        public static ConsumptionLotStatus Inactive { get; } = new ConsumptionLotStatus(InactiveValue);
        /// <summary>
        /// Expired
        /// Serialized Name: Status.Expired
        /// </summary>
        public static ConsumptionLotStatus Expired { get; } = new ConsumptionLotStatus(ExpiredValue);
        /// <summary>
        /// Complete
        /// Serialized Name: Status.Complete
        /// </summary>
        public static ConsumptionLotStatus Complete { get; } = new ConsumptionLotStatus(CompleteValue);
        /// <summary>
        /// Canceled
        /// Serialized Name: Status.Canceled
        /// </summary>
        public static ConsumptionLotStatus Canceled { get; } = new ConsumptionLotStatus(CanceledValue);
        /// <summary> Determines if two <see cref="ConsumptionLotStatus"/> values are the same. </summary>
        public static bool operator ==(ConsumptionLotStatus left, ConsumptionLotStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConsumptionLotStatus"/> values are not the same. </summary>
        public static bool operator !=(ConsumptionLotStatus left, ConsumptionLotStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConsumptionLotStatus"/>. </summary>
        public static implicit operator ConsumptionLotStatus(string value) => new ConsumptionLotStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConsumptionLotStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConsumptionLotStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
