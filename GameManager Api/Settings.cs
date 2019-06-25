using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public AudioSource volumeMusic;
    public AudioSource volumeSound;



    public void DeactivatevolumeMusic()
    {
        if(volumeMusic.volume > 0)
        volumeMusic.volume = 0;
        else 
        volumeMusic.volume = 1;
    }

     public void DeactivatevolumeSound()
    {
        if(volumeSound.volume > 0)
        volumeSound.volume = 0;
        else 
        volumeSound.volume = 1;
    }
  
    public void setvolumeMusic(float val)
    {
        volumeMusic.volume = val;
    }

     public void setvolumeSound(float val)
    {
        volumeSound.volume = val;
    }

     public float getvolumeMusic()
    {
       return volumeMusic.volume;
    }

     public float getvolumeSound()
    {
      return  volumeSound.volume;
    }

 public void saveData()
{
 SaveSystem.SaveSettings(this);
}


public void loadData()
{
  SettingsData data = SaveSystem.LoadSettings();
   volumeMusic.volume = data.musicVolume;
   volumeSound.volume = data.soundVolume;
    
}
    

}
