// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Xunit;

namespace System.Collections.Immutable.Tests
{
    public abstract partial class ImmutablesTestBase
    {
        /// <summary>
        /// Tests the EqualsStructurally public method and the IStructuralEquatable.Equals method.
        /// </summary>
        /// <typeparam name="TCollection">The type of tested collection.</typeparam>
        /// <typeparam name="TElement">The type of element stored in the collection.</typeparam>
        /// <param name="objectUnderTest">An instance of the collection to test, which must have at least two elements.</param>
        /// <param name="additionalItem">A unique item that does not already exist in <paramref name="objectUnderTest" />.</param>
        /// <param name="equalsStructurally">A delegate that invokes the EqualsStructurally method.</param>
        protected static void StructuralEqualityHelper<TCollection, TElement>(TCollection objectUnderTest, TElement additionalItem, Func<TCollection, IEnumerable<TElement>, bool> equalsStructurally)
            where TCollection : class, IEnumerable<TElement>
        {
            Requires.NotNull(objectUnderTest, nameof(objectUnderTest));
            Requires.Argument(objectUnderTest.Count() >= 2, nameof(objectUnderTest), "Collection must contain at least two elements.");
            Requires.NotNull(equalsStructurally, nameof(equalsStructurally));

            var structuralEquatableUnderTest = objectUnderTest as IStructuralEquatable;

            List<TElement> equivalentSequence = objectUnderTest.ToList();
            IEnumerable<TElement> shorterSequence = equivalentSequence.Take(equivalentSequence.Count() - 1);
            IEnumerable<TElement> longerSequence = equivalentSequence.Concat(new[] { additionalItem });
            IEnumerable<TElement> nonUniqueSubsetSequenceOfSameLength = shorterSequence.Concat(shorterSequence.Take(1));

            var testValues = new IEnumerable<TElement>[] {
                objectUnderTest,
                null,
                Enumerable.Empty<TElement>(),
                equivalentSequence,
                longerSequence,
                shorterSequence,
                nonUniqueSubsetSequenceOfSameLength,
            };

            foreach (IEnumerable<TElement> value in testValues)
            {
                bool expectedResult = value != null && Enumerable.SequenceEqual(objectUnderTest, value);

                if (structuralEquatableUnderTest != null)
                {
                    Assert.Equal(expectedResult, structuralEquatableUnderTest.Equals(value, null));

                    if (value != null)
                    {
                        Assert.Equal(
                            expectedResult,
                            structuralEquatableUnderTest.Equals(new NonGenericEnumerableWrapper(value), null));
                    }
                }

                Assert.Equal(expectedResult, equalsStructurally(objectUnderTest, value));
            }
        }

        private class NonGenericEnumerableWrapper : IEnumerable
        {
            private readonly IEnumerable _enumerable;

            internal NonGenericEnumerableWrapper(IEnumerable enumerable)
            {
                Requires.NotNull(enumerable, nameof(enumerable));
                _enumerable = enumerable;
            }

            public IEnumerator GetEnumerator()
            {
                return _enumerable.GetEnumerator();
            }
        }
    }
}
