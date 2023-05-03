using System;
using LegendaryTools.Systems.AssetProvider;
using UnityEngine;

namespace LegendaryTools.Bragi
{
    [Serializable]
    public class AssetLoadableAudioClipString : AssetLoadable<AudioClip, string>
    {
    }
    
    [CreateAssetMenu(menuName = "Tools/Bragi/ResourcesAudioConfig")]
    public class ResourcesAudioConfig : AudioConfig
    {
        [Header("Loader")]
        public AssetLoadableAudioClipString AssetLoadable;

        public override IAssetLoaderConfig AssetLoaderConfig => AssetLoadable;
    }
}