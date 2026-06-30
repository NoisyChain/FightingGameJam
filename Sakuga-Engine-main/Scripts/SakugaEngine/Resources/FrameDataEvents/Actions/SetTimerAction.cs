using Godot;

namespace SakugaEngine.Resources
{
    [GlobalClass]
    public partial class SetTimerAction : FrameDataAction
    {
        [Export] private int ByIndex = -1;
        [Export] private string ByName;
        public enum TimerSetMode { START, PAUSE, STOP }
        [Export] private TimerSetMode TimerMode;
        [Export] private uint Time = 0;

        public override void Execute(ref SakugaActor Actor)
        {
            if (Actor.Parameters == null) return;
            FrameTimer timer = null;
            if (ByIndex >= 0) Actor.Parameters.GetTimer(ByIndex);
            else if (ByName != "") timer = Actor.Parameters.GetTimer(ByName);
            if (timer == null) return;

            switch (TimerMode)
            {
                case TimerSetMode.START:
                    if (timer.IsPaused()) timer.Resume();
                    else timer.Start(Time);
                    break;
                case TimerSetMode.PAUSE:
                    timer.Pause();
                    break;
                case TimerSetMode.STOP:
                    timer.Stop();
                    break;  
            }
        }
    }
}
