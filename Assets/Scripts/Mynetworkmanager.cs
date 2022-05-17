using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mynetworkmanager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log("Server started");
    }

    public override void OnStopServer()
    {
        Debug.Log("Server stopped");
    }
     public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Connected to Server!");
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("Disconnected from Server!");
    }
}
