using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ICities;
using UnityEngine;

namespace TweetChirp
{
    public class TweetChirp : IUserMod
    {
        public string Description
        {
            get
            {
                return "Load Twitter messages into Chirper";
            }
        }

        public string Name
        {
            get
            {
                return "Twitter in Chirper";
            }
        }

        void OnCreated(IUserMod instance)
        { }
    }

    public class LoadingMod : ILoadingExtension
    {
        public void OnCreated(ILoading loading) { }

        public void OnLevelLoaded(LoadMode mode)
        {
            Debug.Log("test");
            GameObject template = new GameObject("TweetChirper");
            GameObject.Instantiate(template);
        }

        public void OnLevelUnloading() { }

        public void OnReleased() { }
    }
}
