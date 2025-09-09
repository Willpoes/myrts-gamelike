using UnityEngine;

namespace ideadores.RTS.Player
{
    [System.Serializable] //serialziable class que se quiere mirar en el inspector
    public class CameraConfig
    {

        #region panning, rotation, zooming: slerp y funciones setting for the reset VARIABLES
        [field: SerializeField] public float KeyboardPanSpeed { get; private set; } = 5;
        [field: SerializeField] public float ZoomSpeed { get; private set; } = 1;
        [field: SerializeField] public float RotationSpeed { get; private set; } = 1;
        [field: SerializeField] public float MinZoomDistance { get; private set; } = 7.5f;
        
        [field: SerializeField] public bool EnableEdgePan { get; private set; } = true;
        [field: SerializeField] public float MousePanSpeed { get; private set; } = 5;
        [field: SerializeField] public float EdgePanSize { get; private set; } = 50;
        #endregion




    }
}