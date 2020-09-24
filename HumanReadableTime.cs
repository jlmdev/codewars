public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hours = (seconds / 3600);
            var minutesAndSeconds = seconds % 3600;
            int minutes = minutesAndSeconds / 60;
            int resultSeconds = minutesAndSeconds % 60;
            string hourString = hours.ToString("00");
            string minuteString = minutes.ToString("00");
            string secondString = resultSeconds.ToString("00");
            string result = $"{hourString}:{minuteString}:{secondString}";
            return result;
    }
}
