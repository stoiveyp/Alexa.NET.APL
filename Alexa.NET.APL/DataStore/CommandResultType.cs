using System.Runtime.Serialization;

namespace Alexa.NET.APL.DataStore;

public enum CommandResultType
{
    [EnumMember(Value="SUCCESS")]
    Success,
    [EnumMember(Value="INVALID_DEVICE")]
    InvalidDevice,
    [EnumMember(Value="DEVICE_UNAVAILABLE")]
    DeviceUnavailable,
    [EnumMember(Value= "DEVICE_PERMANENTLY_UNAVAILABLE ")]
    DevicePermanentlyUnavailable,
    [EnumMember(Value="CONCURRENCY_ERROR")]
    ConcurrencyError,
    [EnumMember(Value="INTERNAL_ERROR")]
    InternalError,
    [EnumMember(Value= "PENDING_REQUEST_COUNT_EXCEEDS_LIMIT")]
    PendingRequestCountExceedsLimit
}