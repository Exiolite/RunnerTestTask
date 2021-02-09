﻿using Objects;
using UnityEngine.Events;

namespace Events
{
    public static class LevelEvent
    {
        public static readonly PlayerWins PlayerWins = new PlayerWins();
        public static readonly PlayerLose PlayerLose = new PlayerLose();
        
        public static readonly SetPlayer SetPlayer = new SetPlayer();
        public static readonly ResetPlayer ResetPlayer = new ResetPlayer();
    }
    public class PlayerWins : UnityEvent {}
    public class PlayerLose : UnityEvent {}
    
    public class SetPlayer : UnityEvent <Player> {}
    public class ResetPlayer : UnityEvent {}
}