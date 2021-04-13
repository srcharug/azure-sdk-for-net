// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines the names of all character filters supported by Azure Cognitive Search. </summary>
    public readonly partial struct CharFilterName : IEquatable<CharFilterName>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CharFilterName"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CharFilterName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HtmlStripValue = "html_strip";

        /// <summary> A character filter that attempts to strip out HTML constructs. See https://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/charfilter/HTMLStripCharFilter.html. </summary>
        public static CharFilterName HtmlStrip { get; } = new CharFilterName(HtmlStripValue);
        /// <summary> Determines if two <see cref="CharFilterName"/> values are the same. </summary>
        public static bool operator ==(CharFilterName left, CharFilterName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CharFilterName"/> values are not the same. </summary>
        public static bool operator !=(CharFilterName left, CharFilterName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CharFilterName"/>. </summary>
        public static implicit operator CharFilterName(string value) => new CharFilterName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CharFilterName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CharFilterName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
