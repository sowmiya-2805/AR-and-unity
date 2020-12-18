using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Apple
    {
        #region Fields

        float amountleft; //to hold the amount of apple left for consumption
        bool organic; // whether pesticide is added to the apple or not

        #endregion

        #region Constructor
        public Apple(bool organic, float size)
        {
            this.organic = organic;
            this.amountleft = size;
        }

        #endregion

        #region Properties

        public float Amountleft
        {
            get { return amountleft; }

        }

        public bool Organic
        {
            get { return organic; }
        }
        #endregion

        #region Methods
        public void TakeBite(float size)
        {
            this.amountleft -= size;
        }

        #endregion
    }
}
