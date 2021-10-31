using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.Networking;
using Unity.Netcode.Transports;
using Unity.Netcode.Transports.UNET;
using UnityEngine.UI;

public class MenuAI : MonoBehaviour
{
    public InputField IpInput;
    public void Host()
    {
        NetworkManager.Singleton.StartHost();
        gameObject.SetActive(false);
    }

    public void Join()
    {
        //clicked join
        if (IpInput.text.Length <=0) NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = "127.0.0.1";
        else NetworkManager.Singleton.GetComponent<UNetTransport>().ConnectAddress = IpInput.text;
        NetworkManager.Singleton.StartClient();
        gameObject.SetActive(false);
    }
}
