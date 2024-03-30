using UnityEngine;
using UnityEngine.Rendering;

namespace Project.Scripts
{
    [RequireComponent(typeof(SkinnedMeshRenderer))]
    public class GpuInstancingEnabler : MonoBehaviour
    {
        private void Awake()
        {
            /*GraphicsSettings.useScriptableRenderPipelineBatching = false;*/
            MaterialPropertyBlock materialPropertyBlock = new();
            var meshRenderer = GetComponent<SkinnedMeshRenderer>();

            meshRenderer.SetPropertyBlock(materialPropertyBlock);
        }
    }
}