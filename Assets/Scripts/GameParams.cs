using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class GameParams : MonoBehaviour
{
    public static int NumberOfPlayers;
    public static readonly List<PlayerParams> PlayersList = new List<PlayerParams>();
    
    public struct PlayerParams
    {
        public string Name { get; private set; }
        public string Role { get; private set; }
        public PlayerParams(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
