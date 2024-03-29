﻿// See https://aka.ms/new-console-template for more information
public class Mixer
{
    public List<Channel> InputChannels { get; set; }
    public List<Channel> OutputChannels { get; set; }
    private int volume;

    //costruttore senza parametri
    public Mixer()
    {
        // inizializzazione variabili
        InputChannels = new List<Channel>();
        OutputChannels = new List<Channel>();
        volume = 0;
    }

    //metodo che setta il volume con dei controlli
    public void SetVolume(int newVolume)
    {
        if (newVolume > 100)
        {
            volume = 100;
        }
        else if (newVolume < 0)
        {
            volume = 0;
        }
        else
        {
            volume = newVolume;
        }
    }

    // get volume
    public int GetVolume() 
    { 
        return volume; 
    }

    public void CreateChannels()
    {
        InputChannels.Add(new Channel());
        InputChannels.Add(new Channel());
        InputChannels.Add(new Channel());
        InputChannels.Add(new Channel());

        OutputChannels.Add(new Channel());
        OutputChannels.Add(new Channel());
        OutputChannels.Add(new Channel());
        OutputChannels.Add(new Channel());
    }
}