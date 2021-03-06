#pragma warning disable CS1591
#pragma warning disable SA1600

namespace MediaBrowser.Model.Configuration
{
    public enum SubtitlePlaybackMode
    {
        Default = 0,
        Always = 1,
        OnlyForced = 2,
        None = 3,
        Smart = 4
    }
}
