using UnityEngine;

namespace TypeObject
{
	[CreateAssetMenu(menuName = "Config/Breed")]
    public class Breed : ScriptableObject
    {
		public int health;
        public string attackDescription;
    }
}