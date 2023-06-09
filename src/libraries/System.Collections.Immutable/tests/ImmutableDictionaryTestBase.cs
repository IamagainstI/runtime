// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace System.Collections.Immutable.Tests
{
    public abstract partial class ImmutableDictionaryTestBase : ImmutablesTestBase
    {
        [Fact]
        public virtual void EmptyTest()
        {
            this.EmptyTestHelper(Empty<int, bool>(), 5);
        }

        [Fact]
        public void ContainsTest()
        {
            this.ContainsTestHelper(Empty<int, string>(), 5, "foo");
        }

        [Fact]
        public void RemoveTest()
        {
            this.RemoveTestHelper(Empty<int, GenericParameterHelper>(), 5);
        }

        [Fact]
        public void SetItemTest()
        {
            IImmutableDictionary<string, int> map = this.Empty<string, int>()
                .SetItem("Microsoft", 100)
                .SetItem("Corporation", 50);
            Assert.Equal(2, map.Count);

            map = map.SetItem("Microsoft", 200);
            Assert.Equal(2, map.Count);
            Assert.Equal(200, map["Microsoft"]);

            // Set it to the same thing again and make sure it's all good.
            IImmutableDictionary<string, int> sameMap = map.SetItem("Microsoft", 200);
            Assert.Same(map, sameMap);
        }

        [Fact]
        public void SetItemsTest()
        {
            var template = new Dictionary<string, int>
            {
                { "Microsoft", 100 },
                { "Corporation", 50 },
            };
            IImmutableDictionary<string, int> map = this.Empty<string, int>().SetItems(template);
            Assert.Equal(2, map.Count);

            var changes = new Dictionary<string, int>
            {
                { "Microsoft", 150 },
                { "Dogs", 90 },
            };
            map = map.SetItems(changes);
            Assert.Equal(3, map.Count);
            Assert.Equal(150, map["Microsoft"]);
            Assert.Equal(50, map["Corporation"]);
            Assert.Equal(90, map["Dogs"]);

            map = map.SetItems(
                new[] {
                    new KeyValuePair<string, int>("Microsoft", 80),
                    new KeyValuePair<string, int>("Microsoft", 70),
                });
            Assert.Equal(3, map.Count);
            Assert.Equal(70, map["Microsoft"]);
            Assert.Equal(50, map["Corporation"]);
            Assert.Equal(90, map["Dogs"]);

            map = this.Empty<string, int>().SetItems(new[] { // use an array for code coverage
                new KeyValuePair<string, int>("a", 1), new KeyValuePair<string, int>("b", 2),
                new KeyValuePair<string, int>("a", 3),
            });
            Assert.Equal(2, map.Count);
            Assert.Equal(3, map["a"]);
            Assert.Equal(2, map["b"]);
        }

        [Fact]
        public void ContainsKeyTest()
        {
            this.ContainsKeyTestHelper(Empty<int, GenericParameterHelper>(), 1, new GenericParameterHelper());
        }

        [Fact]
        public void IndexGetNonExistingKeyThrowsTest()
        {
            Assert.Throws<KeyNotFoundException>(() => this.Empty<int, int>()[3]);
        }

        [Fact]
        public void IndexGetTest()
        {
            IImmutableDictionary<int, int> map = this.Empty<int, int>().Add(3, 5);
            Assert.Equal(5, map[3]);
        }

        /// <summary>
        /// Verifies that the GetHashCode method returns the standard one.
        /// </summary>
        [Fact]
        public void GetHashCodeTest()
        {
            IImmutableDictionary<string, int> dictionary = Empty<string, int>();
            Assert.Equal(EqualityComparer<object>.Default.GetHashCode(dictionary), dictionary.GetHashCode());
        }

        [Fact]
        public void ICollectionOfKVMembers()
        {
            var dictionary = (ICollection<KeyValuePair<string, int>>)Empty<string, int>();
            Assert.Throws<NotSupportedException>(() => dictionary.Add(new KeyValuePair<string, int>()));
            Assert.Throws<NotSupportedException>(() => dictionary.Remove(new KeyValuePair<string, int>()));
            Assert.Throws<NotSupportedException>(() => dictionary.Clear());
            Assert.True(dictionary.IsReadOnly);
        }

        [Fact]
        public void ICollectionMembers()
        {
            ((ICollection)Empty<string, int>()).CopyTo(new object[0], 0);

            var dictionary = (ICollection)Empty<string, int>().Add("a", 1);
            Assert.True(dictionary.IsSynchronized);
            Assert.NotNull(dictionary.SyncRoot);
            Assert.Same(dictionary.SyncRoot, dictionary.SyncRoot);

            var array = new object[2];
            dictionary.CopyTo(array, 1);
            Assert.Null(array[0]);
            Assert.Equal(new DictionaryEntry("a", 1), (DictionaryEntry)array[1]);
        }

        [Fact]
        public void IDictionaryOfKVMembers()
        {
            var dictionary = (IDictionary<string, int>)Empty<string, int>().Add("c", 3);
            Assert.Throws<NotSupportedException>(() => dictionary.Add("a", 1));
            Assert.Throws<NotSupportedException>(() => dictionary.Remove("a"));
            Assert.Throws<NotSupportedException>(() => dictionary["a"] = 2);
            Assert.Throws<KeyNotFoundException>(() => dictionary["a"]);
            Assert.Equal(3, dictionary["c"]);
        }

        [Fact]
        public void IDictionaryMembers()
        {
            var dictionary = (IDictionary)Empty<string, int>().Add("c", 3);
            Assert.Throws<NotSupportedException>(() => dictionary.Add("a", 1));
            Assert.Throws<NotSupportedException>(() => dictionary.Remove("a"));
            Assert.Throws<NotSupportedException>(() => dictionary["a"] = 2);
            Assert.Throws<NotSupportedException>(() => dictionary.Clear());
            Assert.False(dictionary.Contains("a"));
            Assert.True(dictionary.Contains("c"));
            Assert.Throws<KeyNotFoundException>(() => dictionary["a"]);
            Assert.Equal(3, dictionary["c"]);
            Assert.True(dictionary.IsFixedSize);
            Assert.True(dictionary.IsReadOnly);
            Assert.Equal(new[] { "c" }, dictionary.Keys.Cast<string>().ToArray());
            Assert.Equal(new[] { 3 }, dictionary.Values.Cast<int>().ToArray());
        }

        [Fact]
        public void IDictionaryEnumerator()
        {
            var dictionary = (IDictionary)Empty<string, int>().Add("a", 1);
            IDictionaryEnumerator enumerator = dictionary.GetEnumerator();
            Assert.Throws<InvalidOperationException>(() => enumerator.Current);
            Assert.Throws<InvalidOperationException>(() => enumerator.Key);
            Assert.Throws<InvalidOperationException>(() => enumerator.Value);
            Assert.Throws<InvalidOperationException>(() => enumerator.Entry);
            Assert.True(enumerator.MoveNext());
            Assert.Equal(enumerator.Entry, enumerator.Current);
            Assert.Equal(enumerator.Key, enumerator.Entry.Key);
            Assert.Equal(enumerator.Value, enumerator.Entry.Value);
            Assert.Equal("a", enumerator.Key);
            Assert.Equal(1, enumerator.Value);
            Assert.False(enumerator.MoveNext());
            Assert.Throws<InvalidOperationException>(() => enumerator.Current);
            Assert.Throws<InvalidOperationException>(() => enumerator.Key);
            Assert.Throws<InvalidOperationException>(() => enumerator.Value);
            Assert.Throws<InvalidOperationException>(() => enumerator.Entry);
            Assert.False(enumerator.MoveNext());

            enumerator.Reset();
            Assert.Throws<InvalidOperationException>(() => enumerator.Current);
            Assert.Throws<InvalidOperationException>(() => enumerator.Key);
            Assert.Throws<InvalidOperationException>(() => enumerator.Value);
            Assert.Throws<InvalidOperationException>(() => enumerator.Entry);
            Assert.True(enumerator.MoveNext());
            Assert.Equal(enumerator.Key, ((DictionaryEntry)enumerator.Current).Key);
            Assert.Equal(enumerator.Value, ((DictionaryEntry)enumerator.Current).Value);
            Assert.Equal("a", enumerator.Key);
            Assert.Equal(1, enumerator.Value);
            Assert.False(enumerator.MoveNext());
            Assert.Throws<InvalidOperationException>(() => enumerator.Current);
            Assert.Throws<InvalidOperationException>(() => enumerator.Key);
            Assert.Throws<InvalidOperationException>(() => enumerator.Value);
            Assert.Throws<InvalidOperationException>(() => enumerator.Entry);
            Assert.False(enumerator.MoveNext());
        }

        [Fact]
        public void TryGetKey()
        {
            IImmutableDictionary<string, int> dictionary = Empty<int>(StringComparer.OrdinalIgnoreCase)
                .Add("a", 1);
            string actualKey;
            Assert.True(dictionary.TryGetKey("a", out actualKey));
            Assert.Equal("a", actualKey);

            Assert.True(dictionary.TryGetKey("A", out actualKey));
            Assert.Equal("a", actualKey);

            Assert.False(dictionary.TryGetKey("b", out actualKey));
            Assert.Equal("b", actualKey);
        }

        protected void EmptyTestHelper<K, V>(IImmutableDictionary<K, V> empty, K someKey)
        {
            Assert.Same(empty, empty.Clear());
            Assert.Equal(0, empty.Count);
            Assert.Equal(0, empty.Count());
            Assert.Equal(0, empty.Keys.Count());
            Assert.Equal(0, empty.Values.Count());
            Assert.Same(EqualityComparer<V>.Default, GetValueComparer(empty));
            Assert.False(empty.ContainsKey(someKey));
            Assert.False(empty.Contains(new KeyValuePair<K, V>(someKey, default(V))));
            Assert.Equal(default(V), empty.GetValueOrDefault(someKey));

            V value;
            Assert.False(empty.TryGetValue(someKey, out value));
            Assert.Equal(default(V), value);
        }

        protected void AddExistingKeySameValueTestHelper<TKey, TValue>(IImmutableDictionary<TKey, TValue> map, TKey key, TValue value1, TValue value2)
        {
            Assert.NotNull(map);
            Assert.NotNull(key);
            Assert.True(GetValueComparer(map).Equals(value1, value2));

            map = map.Add(key, value1);
            Assert.Same(map, map.Add(key, value2));
            Assert.Same(map, map.AddRange(new[] { new KeyValuePair<TKey, TValue>(key, value2) }));
        }

        /// <summary>
        /// Verifies that adding a key-value pair where the key already is in the map but with a different value throws.
        /// </summary>
        /// <typeparam name="TKey">The type of key in the map.</typeparam>
        /// <typeparam name="TValue">The type of value in the map.</typeparam>
        /// <param name="map">The map to manipulate.</param>
        /// <param name="key">The key to add.</param>
        /// <param name="value1">The first value to add.</param>
        /// <param name="value2">The second value to add.</param>
        /// <remarks>
        /// Adding a key-value pair to a map where that key already exists, but with a different value, cannot fit the
        /// semantic of "adding", either by just returning or mutating the value on the existing key.  Throwing is the only reasonable response.
        /// </remarks>
        protected void AddExistingKeyDifferentValueTestHelper<TKey, TValue>(IImmutableDictionary<TKey, TValue> map, TKey key, TValue value1, TValue value2)
        {
            Assert.NotNull(map);
            Assert.NotNull(key);
            Assert.False(GetValueComparer(map).Equals(value1, value2));

            IImmutableDictionary<TKey, TValue> map1 = map.Add(key, value1);
            IImmutableDictionary<TKey, TValue> map2 = map.Add(key, value2);
            AssertExtensions.Throws<ArgumentException>(null, () => map1.Add(key, value2));
            AssertExtensions.Throws<ArgumentException>(null, () => map2.Add(key, value1));
        }

        protected void ContainsKeyTestHelper<TKey, TValue>(IImmutableDictionary<TKey, TValue> map, TKey key, TValue value)
        {
            Assert.False(map.ContainsKey(key));
            Assert.True(map.Add(key, value).ContainsKey(key));
        }

        protected void ContainsTestHelper<TKey, TValue>(IImmutableDictionary<TKey, TValue> map, TKey key, TValue value)
        {
            Assert.False(map.Contains(new KeyValuePair<TKey, TValue>(key, value)));
            Assert.False(map.Contains(key, value));
            Assert.True(map.Add(key, value).Contains(new KeyValuePair<TKey, TValue>(key, value)));
            Assert.True(map.Add(key, value).Contains(key, value));
        }

        protected void RemoveTestHelper<TKey, TValue>(IImmutableDictionary<TKey, TValue> map, TKey key)
        {
            // no-op remove
            Assert.Same(map, map.Remove(key));
            Assert.Same(map, map.RemoveRange(Enumerable.Empty<TKey>()));

            // substantial remove
            IImmutableDictionary<TKey, TValue> addedMap = map.Add(key, default(TValue));
            IImmutableDictionary<TKey, TValue> removedMap = addedMap.Remove(key);
            Assert.NotSame(addedMap, removedMap);
            Assert.False(removedMap.ContainsKey(key));
        }

        protected abstract IImmutableDictionary<TKey, TValue> Empty<TKey, TValue>();

        protected abstract IImmutableDictionary<string, TValue> Empty<TValue>(StringComparer comparer);

        protected abstract IEqualityComparer<TValue> GetValueComparer<TKey, TValue>(IImmutableDictionary<TKey, TValue> dictionary);
    }
}
