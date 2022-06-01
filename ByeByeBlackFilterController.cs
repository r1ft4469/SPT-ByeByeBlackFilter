using UnityEngine;
using UnityStandardAssets.ImageEffects;

namespace r1ft.ByeByeBlackFilter
{
    public class ByeByeBlackFilterController : MonoBehaviour
    {
        private bool Enabled { get; set; } = false;
        private ColorCorrectionCurves CurvesCache { get; set; } = null;

        public void Update()
        {
            if (Camera.main == null)
            {
                CurvesCache = null;
                Enabled = false;
                return;
            }

            if (CurvesCache == null)
                Set();

            return;
        }

        private void Set()
        {
            if (CurvesCache == null)
            {
                CurvesCache = Camera.main.GetComponent<ColorCorrectionCurves>();
                if (CurvesCache == null)
                    return;
            }

            CurvesCache.enabled = Enabled;
            Enabled = !Enabled;
        }
    }
}
