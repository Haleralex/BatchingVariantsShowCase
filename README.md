We got the way to significally improve our performance in games on Unity - batching. Batching - combining objects with same materials in one instructions for GPU, so we can have a lot of active objects on our scene, but at the same time high FPS. We got 3 cases:
1) static batching
2) batching for not static objects with MeshRenderer - GPU Instancing
3) batching for not static objects with SkinnedMeshRenderer - GPU Instancing (in dev)
   
This project contains examples how to solve this 3 problems 
