using Godot;
using System;

namespace SakugaEngine.Resources
{
    [GlobalClass]
    public partial class FighterStance : Resource
    {
        [ExportCategory("Settings")]
        [Export] public bool IsDamagePersistent;
        [Export] public bool IsRoundPersistent;
        [Export] public int DefaultState = 0;
        [Export] public MoveSettings[] Moves;
        [Export] public int[] HitReactions;
        [Export] public BlockSettings[] BlockReactions;
        [ExportCategory("Throw Escape")]
        [Export] public MotionInputs ThrowEscapeInput;
        [Export] public int GroundThrowEscapeState = -1;
        [Export] public int AirThrowEscapeState = -1;
    }
}
