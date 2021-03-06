﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

namespace StoelenDans
{
    public class PlayerGlass : MonoBehaviour
    {

        [SerializeField]
        private GameObject m_Glass;

        private LiquidVolume m_GlassVolume;
        public LiquidVolume GlassVolume
        {
            get { return m_GlassVolume; }
            set { m_GlassVolume = value; }
        }

        // Use this for initialization
        void Start()
        {
            m_GlassVolume = m_Glass.GetComponent<LiquidVolume>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

