﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WizardWars
{
    public class LobbyManager : Photon.PunBehaviour
    {
        #region Public Variables

        #endregion

        #region Private Variables

        #endregion

        #region Public Methods

        /// <summary>
        /// If the user is the master client then load game scene
        /// </summary>
        public void StartClick()
        {
            if (!PhotonNetwork.isMasterClient)
            { 
                Debug.LogError("PhotonNetwork : Trying to Load a level but we are not the master Client");
            }
            else
            {
                PhotonNetwork.LoadLevel("Test Scene");
            }
        }

        #endregion

        #region Private Methods

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion

        #region Photon.PunBehaviour CallBacks

        public override void OnPhotonPlayerDisconnected(PhotonPlayer player)
        {
            Debug.Log("OnPhotonPlayerDisconnected() called");
        }

        public override void OnMasterClientSwitched(PhotonPlayer player)
        {
            Debug.Log("OnMasterClientSwitched() called");
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene(0);
        }

        #endregion

    }
}

