using System;
using UnityEngine;

namespace EventQueue
{
    [CreateAssetMenu(fileName = "SoundConfig", menuName = "Config/EventQueue/SoundConfig")]
    public class SoundConfig : ScriptableObject
    {
        public SoundEntry[] sounds;
    }
    
    public enum SoundType
    {
        Move,Jump,Collect
    }

    [Serializable]
    public class SoundEntry
    {
        public SoundType type;
        public AudioClip audioClip;
        public float volume=1f;
    }
}