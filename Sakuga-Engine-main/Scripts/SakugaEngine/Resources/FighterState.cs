using Godot;

namespace SakugaEngine.Resources
{
    [GlobalClass]
    public partial class FighterState : Resource
    {
        [Export] public string StateName;
        [Export] public Global.MasterStance BaseStance;
        [Export] public Global.StateType Type;
        [Export] public AnimationData AnimationData;
        [Export] public FrameDataEvent[] TransitionEvents;
        [Export] public FrameDataEvent[] OnEnterEvents;
        [Export] public FrameDataEvent[] OnTickEvents;
        [Export] public FrameDataEvent[] OnExitEvents;
        [Export] public FrameDataEvent[] OnHitConfirmEvents;
        [Export] public FrameDataEvent[] OnHitReactionEvents;
        [ExportSubgroup("AI Flags")]
        [Export] public Global.AIFlags AIFlags;
    }
}