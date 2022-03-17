using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameParams : MonoBehaviour
{
    public static int NumberOfPlayers;
    public static readonly List<PlayerParams> PlayersList = new List<PlayerParams>();
    
    public struct PlayerParams
    {
        private string _name;
        private string _role;
        public PlayerParams(string name, string role)
        {
            _name = name;
            _role = role;
        }

        public void NameSetter(string name)
        {
            _name = name;
        }
        public void RoleSetter(string role)
        {
            _role = role;
        }

        public string NameGetter()
        {
            return _name;
        }

        public string RoleGetter()
        {
            return _role;
        }
    }
}
