using System;
using System.Runtime.Serialization;

namespace Microsoft.DotNet.Tools
{
    internal class CommonLocalizableStrings
    {
        internal static readonly string ProjectDoesNotExist;
        internal static readonly string ProjectIsInvalid;
        internal static readonly string FoundInvalidProject;
        internal static readonly string CouldNotFindProjectOrDirectory;
        internal static readonly string CouldNotFindAnyProjectInDirectory;
        internal static readonly string MoreThanOneProjectInDirectory;
        internal static readonly IFormatProvider ProjectCouldNotBeEvaluated;
        internal static readonly IFormatProvider ProjectAlreadyHasAreference;
        internal static readonly IFormatProvider ReferenceAddedToTheProject;
        internal static readonly IFormatProvider ProjectReferenceCouldNotBeFound;
        internal static readonly IFormatProvider ProjectReferenceRemoved;
        internal static readonly string UnableToLocateDotnetMultiplexer;
    }
}