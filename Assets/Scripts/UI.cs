﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LiteNetLib;

public class UI : MonoBehaviour
{
    [SerializeField]
    private GameObject uiObject;
    
    //[SerializeField]
    //private Server server;

    [SerializeField]
    private Client client;

    [SerializeField]
    private InputField ip;

    private void Awake()
    {
        ip.text = NetUtils.GetLocalIp(LocalAddrType.IPv4);
    }

    public void OnHostClick()
    {
        //server.StartServer();
        client.Connect("localhost");
        uiObject.SetActive(false);
    }

    public void OnJoinClick()
    {
        client.Connect(ip.text);
        uiObject.SetActive(false);
    }
}