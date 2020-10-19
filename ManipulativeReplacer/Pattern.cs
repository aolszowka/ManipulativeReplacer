// -----------------------------------------------------------------------
// <copyright file="Pattern.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2015. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ManipulativeReplacer
{

    /// <summary>
    /// DTO to save Manipulative Replacer Patterns
    /// </summary>
    public class Pattern
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pattern"/> class.
        /// </summary>
        /// <param name="name">The name of this pattern.</param>
        /// <param name="value">The pattern.</param>
        public Pattern(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the name assigned to this Pattern.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Pattern (value).
        /// </summary>
        public string Value
        {
            get;
            set;
        }
    }
}
