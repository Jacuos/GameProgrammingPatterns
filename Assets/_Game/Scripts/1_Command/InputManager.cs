using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private Player _currentPlayer;
        private Stack<ICommand> _commandStack = new Stack<ICommand>();
        void Update()
        {
            ICommand newCommand = null;
            if(Input.GetKeyDown(KeyCode.UpArrow))
                newCommand = new MoveCommand(_currentPlayer,0,1);
            else if(Input.GetKeyDown(KeyCode.DownArrow))
                newCommand = new MoveCommand(_currentPlayer,0,-1);
            else if(Input.GetKeyDown(KeyCode.LeftArrow))
                newCommand = new MoveCommand(_currentPlayer,-1,0);
            else if (Input.GetKeyDown(KeyCode.RightArrow))
                newCommand = new MoveCommand(_currentPlayer, 1, 0);
            else if (Input.GetKeyDown(KeyCode.Space))
                newCommand = new SpawnCommand(_currentPlayer.bombPrefab,_currentPlayer.transform.position);
            else if(Input.GetKeyDown(KeyCode.R))
                TryUndo();    
            if(newCommand != null)
                ExecuteCommand(newCommand);
        }

        void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandStack.Push(command);
        }

        void TryUndo()
        {
            ICommand lastcommand; 
            if(_commandStack.TryPop(out lastcommand))
                lastcommand.Undo();
        }
    }
}