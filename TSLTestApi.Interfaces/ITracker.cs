using System;
using TSLTestApi.ViewModels;

namespace TSLTestApi.Interfaces
{
    public interface ITracker
    {
        TrackingDataViewModel GetTrackingData(string trackingId);
    }
}
