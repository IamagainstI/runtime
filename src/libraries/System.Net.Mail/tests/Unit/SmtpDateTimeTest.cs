// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Net.Mime.Tests
{
    public class SmtpDateTimeTest
    {
        private static readonly DateTime s_validDateStringDateTimeEquivalent = new DateTime(2009, 5, 17, 15, 34, 07, DateTimeKind.Utc);

        private const string UnspecifiedTimeZone = "-0000";
        private const string ValidDateStringDateTimeEquivalentString = "Sun, 17 May 2009 15:34:07 +0000";
        private const string ValidCompleteDateString = "Sun, 17 May 2009 15:34:07 +0000";
        private const string ValidDateStringWithNoDayOfWeek = "17 May 2009 15:34:07 +0000";
        private const string ValidDateStringWithKnownShortHandTimeZone = "Sun, 17 May 2009 15:34:07 GMT";
        private const string ValidDateStringWithUnknownButValidShortHandTimeZone = "Sun, 17 May 2009 15:34:07 BST";
        private const string ValidDateStringWithOnlyTabsAsWhitespace = "Sun,\t17 May\t2009\t15:34:07\tGMT";
        private const string ValidDateStringWithMixedTabsAndSpacesAsWhitespace = "Sun,\t17 May\t 2009 \t15:34:07 \t GMT  \t ";
        private const string ValidDateStringWithTrailingWhitespaceAndCommentAfterTimeZone = "Sun,\t17 May\t2009 15:34:07\tGMT\t \"comment\"";
        private const string InvalidDateStringWithBadDayOfWeek = "Thursday, 17 May 2009 15:34:07 +0000";
        private const string InvalidDateStringWithBadDay = "Sun, 37 May 2009 15:34:07 +0000";
        private const string InvalidDateStringWithBadMonth = "Sun, 17 Smarch 2009 15:34:07 +0000";
        private const string InvalidDateStringWithBadYear = "Sun, 17 May 20099 15:34:07 +0000";
        private const string InvalidDateStringWithBadTimeHours = "Sun, 17 May 2009 27:34:07 +0000";
        private const string InvalidDateStringWithBadTimeMinutes = "Sun, 17 May 2009 15:88:07 +0000";
        private const string InvalidDateStringWithBadTimeSeconds = "Sun, 17 May 2009 15:34:87 +0000";
        private const string InvalidDateStringWithInvalidTimeZone = "Sun, 17 May 2009 15:34:07 7M-Gte";

        [Fact]
        public void SmtpDateTime_WithInvalidTimeZone_ShouldParseDateCorrectly()
        {
            string timeZoneOffset;
            DateTime result = SmtpDateTime.ParseValue(InvalidDateStringWithInvalidTimeZone, out timeZoneOffset);

            Assert.Equal("7M-Gte", timeZoneOffset);
            Assert.Equal(new DateTime(2009, 5, 17, 15, 34, 07), result);
        }

        [Theory]
        [InlineData(InvalidDateStringWithBadTimeSeconds)]
        [InlineData(InvalidDateStringWithBadTimeMinutes)]
        [InlineData(InvalidDateStringWithBadTimeHours)]
        [InlineData(InvalidDateStringWithBadYear)]
        [InlineData(InvalidDateStringWithBadDay)]
        [InlineData(InvalidDateStringWithBadMonth)]
        [InlineData(InvalidDateStringWithBadDayOfWeek)]
        public void SmtpDateTime_InvalidInput_ShouldThrowException(string input)
        {
            Assert.Throws<FormatException>(() =>
            {
                string timeZoneOffset;
                DateTime results = SmtpDateTime.ParseValue(input, out timeZoneOffset);
            });
        }

        [Fact]
        public void SmtpDateTime_WithDateThatHasUnspecifiedKind_ShouldSetTimeZoneCorrectly()
        {
            DateTime date = new DateTime(2008, 1, 1, 12, 00, 00, DateTimeKind.Unspecified);
            var smtpDt = new SmtpDateTime(date);

            Assert.Equal(date, smtpDt.Date);
            Assert.Equal(DateTimeKind.Unspecified, smtpDt.Date.Kind);
        }

        [Fact]
        public void SmtpDateTime_WithDateThatHasKindSetToLocal_ShouldSetTimeZoneCorrectly()
        {
            var date = new DateTime(2008, 1, 1, 12, 00, 00, DateTimeKind.Local);
            var smtpDt = new SmtpDateTime(date);
            Assert.Equal(date, smtpDt.Date);
        }

        [Theory]
        [InlineData(ValidCompleteDateString, 2009, 5, 17, 15, 34, 7, "+0000", DateTimeKind.Unspecified)]
        [InlineData(ValidDateStringWithKnownShortHandTimeZone, 2009, 5, 17, 15, 34, 7, "GMT", DateTimeKind.Unspecified)]
        [InlineData(ValidDateStringWithNoDayOfWeek, 2009, 5, 17, 15, 34, 7, "+0000", DateTimeKind.Unspecified)]
        [InlineData(ValidDateStringWithOnlyTabsAsWhitespace, 2009, 5, 17, 15, 34, 7, "GMT", DateTimeKind.Unspecified)]
        [InlineData(ValidDateStringWithTrailingWhitespaceAndCommentAfterTimeZone, 2009, 5, 17, 15, 34, 7, "GMT", DateTimeKind.Unspecified)]
        [InlineData(ValidDateStringWithMixedTabsAndSpacesAsWhitespace, 2009, 5, 17, 15, 34, 7, "GMT", DateTimeKind.Unspecified)]
        public void SmtpDateTime_CreatedFromDateTimeString_ShouldParseCorrectly(
            string input,
            int expectedYear, int expectedMonth, int expectedDay,
            int expectedHour, int expectedMinut, int expectedSecond,
            string expectedTimeZoneOffset,
            DateTimeKind expectedKind)
        {
            DateTime result = SmtpDateTime.ParseValue(input, out string timeZoneOffset);

            Assert.Equal(expectedYear, result.Year);
            Assert.Equal(expectedMonth, result.Month);
            Assert.Equal(expectedDay, result.Day);
            Assert.Equal(expectedHour, result.Hour);
            Assert.Equal(expectedMinut, result.Minute);
            Assert.Equal(expectedSecond, result.Second);
            Assert.Equal(expectedKind, result.Kind);
            Assert.Equal(expectedTimeZoneOffset, timeZoneOffset);
        }

        [Fact]
        public void SmtpDate_ToString_ShouldOutputCorrectDateString()
        {
            var smtpDt = new SmtpDateTime(s_validDateStringDateTimeEquivalent);
            Assert.Equal(ValidDateStringDateTimeEquivalentString, smtpDt.ToString());
        }

        [Fact]
        public void SmtpDate_ValidateTimeZoneShortHandValue_WithValidShortHand_ShouldReturnTrue()
        {
            SmtpDateTime.ValidateTimeZoneShortHandValue("GMT");
        }

        [Fact]
        public void SmtpDate_ValidateTimeZoneShortHandValue_WithInvalidShortHand_ShouldReturnFalse()
        {
            Assert.Throws<FormatException>(() => SmtpDateTime.ValidateTimeZoneShortHandValue("7M-GTE"));
        }

        [Fact]
        public void SmtpDate_ValidateTimeZoneOffsetValue_WithValidAndInvalidOffsets_ShouldReturnCorrectly()
        {
            bool positive;
            int hours;
            int minutes;

            SmtpDateTime.ValidateAndGetTimeZoneOffsetValues("+0000", out positive, out hours, out minutes);
            SmtpDateTime.ValidateAndGetTimeZoneOffsetValues("+9959", out positive, out hours, out minutes);
            SmtpDateTime.ValidateAndGetTimeZoneOffsetValues("-9959", out positive, out hours, out minutes);
            SmtpDateTime.ValidateAndGetTimeZoneOffsetValues("+0900", out positive, out hours, out minutes);

            Assert.Throws<FormatException>(() => SmtpDateTime.ValidateAndGetTimeZoneOffsetValues("+0080", out positive, out hours, out minutes));
            Assert.Throws<FormatException>(() => SmtpDateTime.ValidateAndGetTimeZoneOffsetValues("+-0045", out positive, out hours, out minutes));
            Assert.Throws<FormatException>(() => SmtpDateTime.ValidateAndGetTimeZoneOffsetValues("+10000", out positive, out hours, out minutes));
            Assert.Throws<FormatException>(() => SmtpDateTime.ValidateAndGetTimeZoneOffsetValues("-A000", out positive, out hours, out minutes));
        }

        [Fact]
        public void SmtpDate_WithCompletelyInvalidDateString_ShouldThrowException()
        {
            Assert.Throws<FormatException>(() => new SmtpDateTime("asdiwefhn m.sdf,m,sdfl\""));
        }

        [Fact]
        public void SmtpDate_TryParseTimeZoneString_WithValidShortHand_ShouldReturnCorrectOffset()
        {
            TimeSpan span;
            Assert.True(SmtpDateTime.TryParseTimeZoneString("GMT", out span));
            Assert.Equal(TimeSpan.Zero, span);
        }

        [Fact]
        public void SmtpDate_TryParseTimeZoneString_WithUnknownShortHand_ShouldReturnFalse()
        {
            TimeSpan span;
            Assert.False(SmtpDateTime.TryParseTimeZoneString("ABCD", out span));
        }

        [Fact]
        public void SmtpDate_TryParseTimeZoneString_WithInvalidShortHand_ShouldThrowException()
        {
            TimeSpan span;
            Assert.Throws<FormatException>(() => SmtpDateTime.TryParseTimeZoneString("7mGTE", out span));
        }
    }
}
