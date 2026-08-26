using Content.Shared.Eui;
using Robust.Shared.Serialization;

namespace Content.Shared._HL.Brainwashing;

[Serializable, NetSerializable]
public sealed class BrainwashViewerState(List<(string, bool)> compulsions) : EuiStateBase
{
    public List<(string, bool)> Compulsions { get; } = compulsions;
}
