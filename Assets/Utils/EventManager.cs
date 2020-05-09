using System;
public class EventManager
{
    public EventManager()
    {
    }

    public delegate void ShiftScoreDelegate(int delta);
    public static event ShiftScoreDelegate OnShiftScore;
    public static void ShiftScore(int delta) {
        OnShiftScore?.Invoke(delta);
    }

}
