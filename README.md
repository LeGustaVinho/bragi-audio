# Bragi - Audio System

Bragi is a simple audio management system that makes it easy to configure audio clips, load and play.

**Functionalities:**

- Each AudioClip has a configuration file, specifying playback parameters (such as volume) and loading strategy.
- It supports dynamic asset loading (loading by Resources is already available Built-In) of any other type (like Addressables), for that just implement a new AssetProvider strategy.
- Play back soundtracks and BGM easily using Jukebox
- Group audios together and easily play in sequence, chained sequence, random or simultaneously using the same API as if it were a single audio.

**Dependencies:**

- [Legendary Tools - Commons](https://github.com/LeGustaVinho/legendary-tools-common "Legendary Tools - Commons")
- [Legendary Tools - Singleton](https://github.com/LeGustaVinho/singleton "Legendary Tools - Singleton")
- [Legendary Tools - Asset Provider](https://github.com/LeGustaVinho/asset-provider "Legendary Tools - Asset Provider")
- [Legendary Tools - MonoBehaviour Facade](https://github.com/LeGustaVinho/monobehaviour-facade "Legendary Tools - MonoBehaviour Facade")
- [Legendary Tools - Pool System](https://github.com/LeGustaVinho/pool "Legendary Tools - Pool System")

### How to install

#### - From OpenUPM: 

- Open **Edit -> Project Settings -> Package Manager**
- Add a new Scoped Registry (or edit the existing OpenUPM entry) 

| Name  | package.openupm.com  |
| ------------ | ------------ |
| URL  | https://package.openupm.com  |
| Scope(s)  | com.legustavinho  |

- Open Window -> Package Manager
- Click `+`
- Select `Add package from git URL...`
- Paste `com.legustavinho.legendary-tools-bragi-audio` and click `Add`

#### - From Git: 
- Open **Window -> Package Manager**
- Click `+`
- Select `Add package from git URL...`
- Paste and press `Add` for all these URLs, do it in this order:
	- https://github.com/LeGustaVinho/legendary-tools-common.git
	- https://github.com/LeGustaVinho/singleton.git
	- https://github.com/LeGustaVinho/asset-provider.git
	- https://github.com/LeGustaVinho/pool.git
	- https://github.com/LeGustaVinho/screen-flow.git
	- https://github.com/LeGustaVinho/monobehaviour-facade.git

### How to use:

#### Basic configuration

For each `AudioClip`, create a new ScriptableObject of type `ResourcesAudioConfig` (or another type if you have created a new loading strategy), so to create it, in the project, Right-click Create -> Tools -> Bragi -> ResourcesAudioConfig.

#### Playing Audio

To play an audio, reference the `ResourcesAudioConfig` in the script and call the Play() function, alternatively you can use `Bragi.Instance`, for example:

```csharp
public class BragiSample : MonoBehaviour
{
    public ResourcesAudioConfig sampleAudioConfig;
	
    void Start()
    {
        sampleAudioConfig.Play();

        Bragi.Instance.Play(sampleAudioConfig);
    }
}
```