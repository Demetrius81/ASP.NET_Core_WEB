﻿namespace TimeSheets.Infrastucture.Extentions
{
    public static class DateTimeExtentions
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long ToEpochTime(this DateTime dateTime) => (long)(dateTime - Epoch).TotalSeconds;
    }
}
