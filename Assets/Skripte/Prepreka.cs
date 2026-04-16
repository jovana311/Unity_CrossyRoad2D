using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

    [System.Serializable]
    public class Prepreka
    {
        public GameObject prepreka;
        public Vector3 pocetniPolozaj;
        public Prepreka(GameObject prepreka, Vector3 pocetniPolozaj)
        {
            this.prepreka = prepreka;
            this.pocetniPolozaj = pocetniPolozaj;
        }
    }

