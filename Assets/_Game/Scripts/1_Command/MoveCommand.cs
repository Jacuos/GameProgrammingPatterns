using UnityEngine;

namespace Command
{
    public class MoveCommand : ICommand
    {
        private Player _myPlayer;
        private int _oldX;
        private int _oldZ;
        private int _dirX;
        private int _dirZ;
        
        public MoveCommand(Player player, int x, int z)
        {
            _myPlayer = player;
            _dirX = x;
            _dirZ = z;
        }
        
        public void Execute()
        {
            _oldX = (int)_myPlayer.transform.position.x;
            _oldZ = (int)_myPlayer.transform.position.z;
            _myPlayer.transform.position += new Vector3(_dirX,0,_dirZ);
        }

        public void Undo()
        {
            _myPlayer.transform.position = new Vector3(_oldX,0,_oldZ);
        }
    }
}