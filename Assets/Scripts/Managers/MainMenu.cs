﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WizardWars
{
    public class MainMenu : Photon.MonoBehaviour
    {

        #region Public Variables

        #endregion

        #region Private Variables

        #endregion

        #region Public Methods

        /// <summary>
        /// Go to the create lobby menu
        /// </summary>
        public void CreateClick ()
        {
            SceneManager.LoadScene("Create Menu");
        }

        /// <summary>
        /// Go to the join lobby menu
        /// </summary>
        public void JoinClick()
        {
            SceneManager.LoadScene("Join Menu");
        }

        /// <summary>
        /// Go to the controls menu
        /// </summary>
        public void ControlsClick()
        {
            SceneManager.LoadScene("Controls Menu");
        }

        /// <summary>
        /// Exit the game
        /// </summary>
        public void ExitClick()
        {
            Application.Quit();
        }

        /// <summary>
        /// Go to Collection scene
        /// </summary>
        public void CollectionClick()
        {
            SceneManager.LoadScene("Athenaeum");
        }

        #endregion

        #region Private Methods

        #endregion



        // Use this for initialization
        void Start () {

            PhotonNetwork.playerName = PlayerPrefs.GetString("PlayerName");

	    }
    }

}