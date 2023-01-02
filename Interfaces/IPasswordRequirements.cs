﻿namespace Easy_Password_Validator.Interfaces
{
    /// <summary>
    /// Interface to define elements required by built-in password tester
    /// </summary>
    public interface IPasswordRequirements
    {
        /// <summary>
        /// Specifies the minimum length requirement for a password
        /// </summary>
        int MinLength { get; set; }

        /// <summary>
        /// Specifies the minimum amount of unique characters required in a password
        /// </summary>
        int MinUniqueCharacters { get; set; }

        /// <summary>
        /// Specifies the maximum amount of times a single character may appear beside itself in a password
        /// </summary>
        int MaxRepeatSameCharacter { get; set; }

        /// <summary>
        /// Specifies the maximum amount of characters neighboring one another on the keyboard that may appear in a password
        /// </summary>
        int MaxNeighboringCharacter { get; set; }

        /// <summary>
        /// Specifies whether a password must contain at least one digit
        /// </summary>
        bool RequireDigit { get; set; }

        /// <summary>
        /// Specifies whether a password must contain at least one lowercase letter
        /// </summary>
        bool RequireLowercase { get; set; }

        /// <summary>
        /// Specifies whether a password must contain at least one uppercase letter
        /// </summary>
        bool RequireUppercase { get; set; }

        /// <summary>
        /// Specifies whether a password must contain at least one punctuation mark
        /// </summary>
        bool RequirePunctuation { get; set; }

        /// <summary>
        /// Specifies the minimum total score required for a password to be considered valid
        /// </summary>
        int MinScore { get; set; }

        /// <summary>
        /// Specifies the minimum entropy score required for a password to be considered valid
        /// </summary>
        float MinEntropy { get; set; }

        /// <summary>
        /// Specifies whether to use the entropy checking test
        /// </summary>
        bool UseEntropy { get; set; }

        /// <summary>
        /// Specifies whether to stop execution on the first failure or continue and report after all tests complete
        /// </summary>
        bool ExitOnFailure { get; set; }
    }
}
