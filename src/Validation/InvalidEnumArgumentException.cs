﻿// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the Ms-PL license. See LICENSE.txt file in the project root for full license information.

#if NETSTANDARD1_0 || NETSTANDARD1_3
namespace System.ComponentModel
{
    using System.Runtime.CompilerServices;

    using Validation;

    /// <summary>
    /// The exception that is thrown when using invalid arguments that are enumerators.
    /// </summary>
#if NETSTANDARD1_3
    [Serializable]
#endif
    [TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public class InvalidEnumArgumentException : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref='InvalidEnumArgumentException'/>
        /// class without a message.
        /// </summary>
        public InvalidEnumArgumentException()
            : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref='InvalidEnumArgumentException'/>
        /// class with the specified message.
        /// </summary>
        public InvalidEnumArgumentException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidEnumArgumentException"/> class with a specified error message.
        /// and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        public InvalidEnumArgumentException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref='InvalidEnumArgumentException'/>
        /// class with a message generated from the argument, invalid value, and
        /// enumeration class.
        /// </summary>
        public InvalidEnumArgumentException(string? argumentName, int invalidValue, Type enumClass)
            : base(PrivateErrorHelpers.Format(Strings.InvalidEnumArgument, argumentName, invalidValue, enumClass?.Name), argumentName)
        {
            if (enumClass == null)
            {
                throw new ArgumentNullException(nameof(enumClass));
            }
        }
    }
}
#endif